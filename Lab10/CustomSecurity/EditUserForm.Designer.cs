namespace CustomSecurity {
    partial class EditUserForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblRole;
        public System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnEdit;
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
            System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(EditUserForm));
            this.lblName = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            //
            // lblName
            //
            this.lblName.Location = new System.Drawing.Point(16, 16);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(144, 23);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Имя пользователя";
            //
            // lblRole
            //
            this.lblRole.Location = new System.Drawing.Point(16, 48);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(144, 23);
            this.lblRole.TabIndex = 3;
            this.lblRole.Text = "Роль пользователя";
            //
            // btnCancel
            //
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(192, 112);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Отмена";
            //
            // btnEdit
            //
            this.btnEdit.Location = new System.Drawing.Point(72, 112);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Изменить";
            this.btnEdit.Click += new System.EventHandler(this.button2_Click);
            //
            // cmbRole
            //
            this.cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRole.Items.AddRange(new object[] {"admin", "manager", "operator"});
            this.cmbRole.Location = new System.Drawing.Point(176, 48);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(200, 21);
            this.cmbRole.TabIndex = 6;
            //
            // lblUserName
            //
            this.lblUserName.Location = new System.Drawing.Point(176, 16);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(200, 23);
            this.lblUserName.TabIndex = 7;
            //
            // EditUserForm
            //
            this.AcceptButton = this.btnEdit;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(386, 152);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.cmbRole);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.lblName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "EditUserForm";
            this.Text = "Изменение пользователя";
            this.Load += new System.EventHandler(this.EditUserForm_Load);
            this.ResumeLayout(false);
        }

        #endregion
    }
}