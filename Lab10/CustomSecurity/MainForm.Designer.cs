namespace CustomSecurity {
    partial class MainForm {
        private System.Windows.Forms.ToolBarButton btnViewUsers;
        private System.Windows.Forms.ToolBarButton btnEditUsers;
        private System.Windows.Forms.ImageList toolBoxIcons;
        private System.Windows.Forms.ToolBar toolBar;
        private System.Windows.Forms.ListView lstViewUsers;
        private System.Windows.Forms.ColumnHeader colUserName;
        private System.Windows.Forms.ColumnHeader colUserRole;
        private System.Windows.Forms.ColumnHeader colUserId;
        private System.ComponentModel.IContainer components;

        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolBar = new System.Windows.Forms.ToolBar();
            this.btnViewUsers = new System.Windows.Forms.ToolBarButton();
            this.btnEditUsers = new System.Windows.Forms.ToolBarButton();
            this.toolBoxIcons = new System.Windows.Forms.ImageList(this.components);
            this.lstViewUsers = new System.Windows.Forms.ListView();
            this.colUserName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colUserRole = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colUserId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // toolBar
            // 
            this.toolBar.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.btnViewUsers,
            this.btnEditUsers});
            this.toolBar.DropDownArrows = true;
            this.toolBar.ImageList = this.toolBoxIcons;
            this.toolBar.Location = new System.Drawing.Point(0, 0);
            this.toolBar.Name = "toolBar";
            this.toolBar.ShowToolTips = true;
            this.toolBar.Size = new System.Drawing.Size(424, 28);
            this.toolBar.TabIndex = 0;
            this.toolBar.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBar_ButtonClick);
            // 
            // btnViewUsers
            // 
            this.btnViewUsers.ImageIndex = 0;
            this.btnViewUsers.Name = "btnViewUsers";
            this.btnViewUsers.Tag = "view";
            this.btnViewUsers.ToolTipText = "Вывести список пользователей";
            // 
            // btnEditUsers
            // 
            this.btnEditUsers.ImageIndex = 1;
            this.btnEditUsers.Name = "btnEditUsers";
            this.btnEditUsers.Tag = "edit";
            this.btnEditUsers.ToolTipText = "Редактировать роль пользователя";
            // 
            // toolBoxIcons
            // 
            this.toolBoxIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("toolBoxIcons.ImageStream")));
            this.toolBoxIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.toolBoxIcons.Images.SetKeyName(0, "1.png");
            this.toolBoxIcons.Images.SetKeyName(1, "2.png");
            // 
            // lstViewUsers
            // 
            this.lstViewUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colUserName,
            this.colUserRole,
            this.colUserId});
            this.lstViewUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lstViewUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstViewUsers.FullRowSelect = true;
            this.lstViewUsers.GridLines = true;
            this.lstViewUsers.Location = new System.Drawing.Point(0, 28);
            this.lstViewUsers.MultiSelect = false;
            this.lstViewUsers.Name = "lstViewUsers";
            this.lstViewUsers.Size = new System.Drawing.Size(424, 238);
            this.lstViewUsers.SmallImageList = this.toolBoxIcons;
            this.lstViewUsers.TabIndex = 1;
            this.lstViewUsers.UseCompatibleStateImageBehavior = false;
            this.lstViewUsers.View = System.Windows.Forms.View.Details;
            // 
            // colUserName
            // 
            this.colUserName.Text = "Имя пользователя";
            this.colUserName.Width = 125;
            // 
            // colUserRole
            // 
            this.colUserRole.Text = "Роль пользователя";
            this.colUserRole.Width = 125;
            // 
            // colUserId
            // 
            this.colUserId.Text = "Уникальный идентификатор";
            this.colUserId.Width = 175;
            // 
            // MainForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(424, 266);
            this.Controls.Add(this.lstViewUsers);
            this.Controls.Add(this.toolBar);
            this.Name = "MainForm";
            this.Text = "Ролевая безопасность";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}

