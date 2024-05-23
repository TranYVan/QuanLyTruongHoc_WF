namespace QuanLyTruongHoc_WF.DBA
{
    partial class DBA_Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            UsersRolesPage = new TabPage();
            RolesPage = new TabPage();
            privilegesPage = new TabPage();
            SysPrivilegesPage = new TabPage();
            tablesViewsTab = new TabPage();
            auditPage = new TabPage();
            button1 = new Button();
            tabControl1.SuspendLayout();
            UsersRolesPage.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(UsersRolesPage);
            tabControl1.Controls.Add(RolesPage);
            tabControl1.Controls.Add(privilegesPage);
            tabControl1.Controls.Add(SysPrivilegesPage);
            tabControl1.Controls.Add(tablesViewsTab);
            tabControl1.Controls.Add(auditPage);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(786, 525);
            tabControl1.TabIndex = 0;
            // 
            // UsersRolesPage
            // 
            UsersRolesPage.Location = new Point(4, 24);
            UsersRolesPage.Name = "UsersRolesPage";
            UsersRolesPage.Padding = new Padding(3);
            UsersRolesPage.Size = new Size(778, 497);
            UsersRolesPage.TabIndex = 0;
            UsersRolesPage.Text = "Users & Roles";
            UsersRolesPage.UseVisualStyleBackColor = true;
            // 
            // RolesPage
            // 
            RolesPage.Location = new Point(4, 24);
            RolesPage.Name = "RolesPage";
            RolesPage.Padding = new Padding(3);
            RolesPage.Size = new Size(778, 497);
            RolesPage.TabIndex = 1;
            RolesPage.Text = "Roles of User";
            RolesPage.UseVisualStyleBackColor = true;
            // 
            // privilegesPage
            // 
            privilegesPage.Location = new Point(4, 24);
            privilegesPage.Name = "privilegesPage";
            privilegesPage.Padding = new Padding(3);
            privilegesPage.Size = new Size(778, 497);
            privilegesPage.TabIndex = 2;
            privilegesPage.Text = "Object Privileges";
            privilegesPage.UseVisualStyleBackColor = true;
            // 
            // SysPrivilegesPage
            // 
            SysPrivilegesPage.Location = new Point(4, 24);
            SysPrivilegesPage.Name = "SysPrivilegesPage";
            SysPrivilegesPage.Padding = new Padding(3);
            SysPrivilegesPage.Size = new Size(778, 497);
            SysPrivilegesPage.TabIndex = 4;
            SysPrivilegesPage.Text = "System Privileges";
            SysPrivilegesPage.UseVisualStyleBackColor = true;
            // 
            // tablesViewsTab
            // 
            tablesViewsTab.Location = new Point(4, 24);
            tablesViewsTab.Name = "tablesViewsTab";
            tablesViewsTab.Padding = new Padding(3);
            tablesViewsTab.Size = new Size(778, 497);
            tablesViewsTab.TabIndex = 3;
            tablesViewsTab.Text = "Tables & Views";
            tablesViewsTab.UseVisualStyleBackColor = true;
            // 
            // auditPage
            // 
            auditPage.Location = new Point(4, 24);
            auditPage.Name = "auditPage";
            auditPage.Padding = new Padding(3);
            auditPage.Size = new Size(778, 497);
            auditPage.TabIndex = 5;
            auditPage.Text = "Audit";
            auditPage.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.BackColor = Color.Crimson;
            button1.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.WhiteSmoke;
            button1.Location = new Point(698, 527);
            button1.Name = "button1";
            button1.Size = new Size(84, 35);
            button1.TabIndex = 1;
            button1.Text = "Sign Out";
            button1.UseVisualStyleBackColor = false;
            // 
            // DBA_Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(button1);
            Controls.Add(tabControl1);
            MinimumSize = new Size(800, 600);
            Name = "DBA_Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QUẢN LÝ TRƯỜNG HỌC";
            tabControl1.ResumeLayout(false);
            UsersRolesPage.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage UsersRolesPage;
        private TabPage privilegesPage;
        private TabControl tabControl1;
        private TabPage tablesViewsTab;
        private TabPage SysPrivilegesPage;
        private TabPage auditPage;
        /*private SysPrivs sysPrivs1;*/
        private Button button1;
        //private UserandRole useransRole1;
        //private Privilege privilege1;
        private TabPage RolesPage;
        //private DBA_RoleUI dbA_Roleui1;
        //private TablesViewsPage tablesViewsPage1;
    }
}