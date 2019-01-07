using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace CustomSecurity {
    /// <summary>
    /// Форма ввода имени пользователя.
    /// </summary>
    public partial class LoginForm : System.Windows.Forms.Form {

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, System.EventArgs e) {
            // Устанавливаем положительный  результат выполнения
            // и закрываем форму.
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}