namespace QuanLyTruongHoc_WF.DBA.UC
{
    partial class UserAndRole
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            panel3 = new Panel();
            userGrid = new DataGridView();
            label3 = new Label();
            panel2 = new Panel();
            button8 = new Button();
            button4 = new Button();
            role_search_text = new TextBox();
            button5 = new Button();
            label2 = new Label();
            button6 = new Button();
            panel1 = new Panel();
            button7 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            user_search_text = new TextBox();
            label1 = new Label();
            panel4 = new Panel();
            roleGrid = new DataGridView();
            label4 = new Label();
            tableLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)userGrid).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)roleGrid).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel3, 0, 1);
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel4, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(778, 508);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // panel3
            // 
            tableLayoutPanel1.SetColumnSpan(panel3, 2);
            panel3.Controls.Add(userGrid);
            panel3.Controls.Add(label3);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 103);
            panel3.Name = "panel3";
            panel3.Size = new Size(772, 198);
            panel3.TabIndex = 2;
            // 
            // userGrid
            // 
            userGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            userGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            userGrid.Location = new Point(3, 23);
            userGrid.Name = "userGrid";
            userGrid.Size = new Size(766, 172);
            userGrid.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 1;
            label3.Text = "USER";
            // 
            // panel2
            // 
            panel2.Controls.Add(button8);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(role_search_text);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(button6);
            panel2.Location = new Point(392, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(383, 94);
            panel2.TabIndex = 1;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button8.Location = new Point(310, 23);
            button8.Name = "button8";
            button8.Size = new Size(73, 27);
            button8.TabIndex = 6;
            button8.Text = "Search";
            button8.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.BackColor = Color.Red;
            button4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(270, 56);
            button4.Name = "button4";
            button4.Size = new Size(110, 35);
            button4.TabIndex = 9;
            button4.Text = "Delete Role";
            button4.UseVisualStyleBackColor = false;
            // 
            // role_search_text
            // 
            role_search_text.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            role_search_text.Location = new Point(-3, 23);
            role_search_text.Name = "role_search_text";
            role_search_text.Size = new Size(307, 27);
            role_search_text.TabIndex = 6;
            // 
            // button5
            // 
            button5.BackColor = Color.Khaki;
            button5.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(133, 56);
            button5.Name = "button5";
            button5.Size = new Size(110, 35);
            button5.TabIndex = 8;
            button5.Text = "Update Role";
            button5.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(-3, 0);
            label2.Name = "label2";
            label2.Size = new Size(89, 20);
            label2.TabIndex = 5;
            label2.Text = "Search Role";
            // 
            // button6
            // 
            button6.BackColor = Color.PaleGreen;
            button6.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.Location = new Point(0, 56);
            button6.Name = "button6";
            button6.Size = new Size(110, 35);
            button6.TabIndex = 7;
            button6.Text = "Create Role";
            button6.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(user_search_text);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(383, 94);
            panel1.TabIndex = 0;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.Location = new Point(310, 23);
            button7.Name = "button7";
            button7.Size = new Size(73, 27);
            button7.TabIndex = 5;
            button7.Text = "Search";
            button7.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(273, 56);
            button3.Name = "button3";
            button3.Size = new Size(110, 35);
            button3.TabIndex = 4;
            button3.Text = "Delete User";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Khaki;
            button2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(136, 56);
            button2.Name = "button2";
            button2.Size = new Size(110, 35);
            button2.TabIndex = 3;
            button2.Text = "Update User";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.PaleGreen;
            button1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(3, 56);
            button1.Name = "button1";
            button1.Size = new Size(110, 35);
            button1.TabIndex = 2;
            button1.Text = "Create User";
            button1.UseVisualStyleBackColor = false;
            // 
            // user_search_text
            // 
            user_search_text.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            user_search_text.Location = new Point(0, 23);
            user_search_text.Name = "user_search_text";
            user_search_text.Size = new Size(304, 27);
            user_search_text.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(90, 20);
            label1.TabIndex = 0;
            label1.Text = "Search User";
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.SetColumnSpan(panel4, 2);
            panel4.Controls.Add(roleGrid);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(3, 307);
            panel4.Name = "panel4";
            panel4.Size = new Size(772, 198);
            panel4.TabIndex = 3;
            // 
            // roleGrid
            // 
            roleGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            roleGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            roleGrid.Location = new Point(3, 24);
            roleGrid.Name = "roleGrid";
            roleGrid.Size = new Size(766, 171);
            roleGrid.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(44, 20);
            label4.TabIndex = 2;
            label4.Text = "ROLE";
            // 
            // UserAndRole
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            MinimumSize = new Size(778, 497);
            Name = "UserAndRole";
            Size = new Size(778, 508);
            Load += UserAndRole_Load;
            tableLayoutPanel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)userGrid).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)roleGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel2;
        private Panel panel1;
        private TextBox user_search_text;
        private Label label1;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button4;
        private TextBox role_search_text;
        private Button button5;
        private Label label2;
        private Button button6;
        private Button button7;
        private Button button8;
        private Panel panel3;
        private Label label3;
        private Panel panel4;
        private Label label4;
        private DataGridView userGrid;
        private DataGridView roleGrid;
    }
}
