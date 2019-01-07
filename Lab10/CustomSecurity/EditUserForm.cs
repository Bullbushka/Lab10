using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace CustomSecurity {
    /// <summary>
    /// Форма изменения роли пользователя
    /// </summary>
    public partial class EditUserForm : System.Windows.Forms.Form {
        private string UserName;
        // Обратите внимание на то, что у формы переопределен конструктор.
        // Это сделано для передачи форме имени пользователя,
        // роль которого необходимо изменить.
        public EditUserForm(string userName) {
            UserName = userName;
            InitializeComponent();
        }

        private void button2_Click(object sender, System.EventArgs e) {
            // Устанавливаем положительный результат выполнения
            // и закрываем форму.
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void EditUserForm_Load(object sender, System.EventArgs e) {
            // При загрузке формы устанавливаем имя пользователя в
            //элемент управления lblUserName
            lblUserName.Text = UserName;
        }
    }
}