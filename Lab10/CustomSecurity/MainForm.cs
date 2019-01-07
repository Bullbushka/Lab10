using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using System.Xml;

namespace CustomSecurity {

    public partial class MainForm : System.Windows.Forms.Form {
        public MainForm() {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, System.EventArgs e) {
            // Получаем имя пользователя.
            LoginForm login = new LoginForm();
            if (login.ShowDialog() != DialogResult.OK) {
                // Если пользователь отменил ввод имени, закрываем приложение
                this.Close();
                return;
            }
            try {
                // Создаем объекты IIdentity и IPrincipal
                CustomIdentity identity = new CustomIdentity(login.txbUserName.Text);
                CustomPrincipal principal = new CustomPrincipal(identity);
                Thread.CurrentPrincipal = principal;
                this.ValidateUser();
            } catch (Exception ex) {
                // Обрабатываем исключения и закрываем приложение.
                MessageBox.Show("Во время выполнения приложения возникла ошибка: " + ex.Message, "Ошибка");
                this.Close();
                return;
            }

        }

        /// <summary>
        /// Изменяем пользовательский интерфейс в зависимости от роли пользователя.
        /// </summary>
        private void ValidateUser() {
            CustomPrincipal principal = Thread.CurrentPrincipal as CustomPrincipal;
            if (principal.IsInRole("operator")) {
                // Если роль пользователя — operator, скрываем функциональность.
                btnEditUsers.Enabled = false;
                btnViewUsers.Enabled = false;
            }
            if (principal.IsInRole("manager")) {
                // Для  роли пользователя manager скрываем возможности изменения роли пользователя.
                btnEditUsers.Enabled = false;
            }
        }

        private void toolBar_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e) {
            // Проверяем, какая кнопка была нажата, и
            // выполняем соответствующее действие.
            switch (e.Button.Tag.ToString()) {
                case "view":
                this.ViewUsers();
                break;
                case "edit":
                this.EditUser();
                break;
            }
        }
        /// <summary>
        /// Выводим пользователей на экран.
        /// </summary>
        private void ViewUsers() {
            lstViewUsers.Items.Clear();
            XmlTextReader xmlReader = new XmlTextReader("Users.xml");
            xmlReader.WhitespaceHandling = WhitespaceHandling.None;
            while (xmlReader.Read()) {
                // Считываем данные из XML-файла, представляем их в виде
                // строки элемента управления ListView
                if (xmlReader["name"] == null)
                    continue;
                ListViewItem item = new ListViewItem(new
                        string[] { xmlReader["name"], xmlReader["role"], xmlReader["id"] }, 0);
                lstViewUsers.Items.Add(item);
            }
            xmlReader.Close();
        }
        /// <summary>
        /// Изменяем  выбранного пользователя.
        /// </summary>
        private void EditUser() {
            if (lstViewUsers.SelectedItems.Count == 0) {
                MessageBox.Show("Вы дожны выбрать пользователя.", "Сообщение приложения");
            } else {
                string userName = lstViewUsers.SelectedItems[0].Text;
                EditUserForm edit = new EditUserForm(userName);
                if (edit.ShowDialog() != DialogResult.OK)
                    return;
                // Считываем новую роль.
                string newRole = edit.cmbRole.SelectedItem.ToString();
                // Обновляем файл XML  новыми данными.
                XmlDocument doc = new XmlDocument();
                StreamReader reader = new StreamReader("Users.xml");
                doc.LoadXml(reader.ReadToEnd());
                reader.Close();
                XmlElement root = doc.DocumentElement;
                foreach (XmlNode child in root.ChildNodes) {
                    if (child.Attributes["name"].Value == userName) {
                        child.Attributes["role"].Value = newRole;
                        break;
                    }
                }
                doc.Save("Users.xml");
                this.ViewUsers();
            }
        }
    }
}