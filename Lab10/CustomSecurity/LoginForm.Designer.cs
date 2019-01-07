namespace CustomSecurity {
    partial class LoginForm {
        // Обратите внимание на то, что модификатору доступа элемента
        // управления txbUserName  установлено  значение  public. Это сделано для того, чтобы
        // можно было из другой формы получить введенный в него текст.
        public System.Windows.Forms.TextBox txbUserName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblUserName;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.txbUserName = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.lblUserName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            //
            // txbUserName
            //
            this.txbUserName.Location = new System.Drawing.Point(16, 32);
            this.txbUserName.Name = "txbUserName";
            this.txbUserName.Size = new System.Drawing.Size(312, 20);
            this.txbUserName.TabIndex = 0;
            this.txbUserName.Text = "";
            //
            // btnCancel
            //
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(152, 80);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Отмена";
            //
            // btnOk
            //
            this.btnOk.Location = new System.Drawing.Point(248, 80);
            this.btnOk.Name = "btnOk";
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "ОК";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            //
            // lblUserName
            //
            this.lblUserName.Location = new System.Drawing.Point(16, 8);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(216, 24);
            this.lblUserName.TabIndex = 3;
            this.lblUserName.Text = "Введите имя пользователя:";
            //
            // LoginForm
            //
            this.AcceptButton = this.btnOk;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(342, 116);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txbUserName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.ResumeLayout(false);
        }

        #endregion
    }
}