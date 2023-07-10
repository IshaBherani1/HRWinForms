namespace HRWinForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DepartmentBox = new System.Windows.Forms.ComboBox();
            this.OrgLevelBox = new System.Windows.Forms.ComboBox();
            this.DepartmentLbl = new System.Windows.Forms.Label();
            this.OrgLevelLbl = new System.Windows.Forms.Label();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AddEmpBtn = new System.Windows.Forms.Button();
            this.InsertNewEmpBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NewDepartmentIDBox = new System.Windows.Forms.ComboBox();
            this.NewShiftIDBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // DepartmentBox
            // 
            this.DepartmentBox.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DepartmentBox.FormattingEnabled = true;
            this.DepartmentBox.Location = new System.Drawing.Point(32, 51);
            this.DepartmentBox.Name = "DepartmentBox";
            this.DepartmentBox.Size = new System.Drawing.Size(232, 32);
            this.DepartmentBox.TabIndex = 0;
            // 
            // OrgLevelBox
            // 
            this.OrgLevelBox.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OrgLevelBox.FormattingEnabled = true;
            this.OrgLevelBox.Location = new System.Drawing.Point(289, 51);
            this.OrgLevelBox.Name = "OrgLevelBox";
            this.OrgLevelBox.Size = new System.Drawing.Size(232, 32);
            this.OrgLevelBox.TabIndex = 1;
            // 
            // DepartmentLbl
            // 
            this.DepartmentLbl.AutoSize = true;
            this.DepartmentLbl.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DepartmentLbl.Location = new System.Drawing.Point(32, 23);
            this.DepartmentLbl.Name = "DepartmentLbl";
            this.DepartmentLbl.Size = new System.Drawing.Size(118, 24);
            this.DepartmentLbl.TabIndex = 2;
            this.DepartmentLbl.Text = "Department";
            // 
            // OrgLevelLbl
            // 
            this.OrgLevelLbl.AutoSize = true;
            this.OrgLevelLbl.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OrgLevelLbl.Location = new System.Drawing.Point(289, 23);
            this.OrgLevelLbl.Name = "OrgLevelLbl";
            this.OrgLevelLbl.Size = new System.Drawing.Size(179, 24);
            this.OrgLevelLbl.TabIndex = 3;
            this.OrgLevelLbl.Text = "Organization Level";
            //this.OrgLevelLbl.Click += new System.EventHandler(this.label2_Click);
            // 
            // SearchBtn
            // 
            this.SearchBtn.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SearchBtn.Location = new System.Drawing.Point(542, 51);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(122, 32);
            this.SearchBtn.TabIndex = 4;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 115);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(837, 517);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.Visible = false;
            // 
            // AddEmpBtn
            // 
            this.AddEmpBtn.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddEmpBtn.Location = new System.Drawing.Point(1069, 47);
            this.AddEmpBtn.Name = "AddEmpBtn";
            this.AddEmpBtn.Size = new System.Drawing.Size(200, 40);
            this.AddEmpBtn.TabIndex = 6;
            this.AddEmpBtn.Text = "Add Employee";
            this.AddEmpBtn.UseVisualStyleBackColor = true;
            this.AddEmpBtn.Visible = false;
            this.AddEmpBtn.Click += new System.EventHandler(this.AddEmpBtn_Click);
            // 
            // InsertNewEmpBtn
            // 
            this.InsertNewEmpBtn.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.InsertNewEmpBtn.Location = new System.Drawing.Point(1028, 331);
            this.InsertNewEmpBtn.Name = "InsertNewEmpBtn";
            this.InsertNewEmpBtn.Size = new System.Drawing.Size(279, 45);
            this.InsertNewEmpBtn.TabIndex = 8;
            this.InsertNewEmpBtn.Text = "Insert New Employee";
            this.InsertNewEmpBtn.UseVisualStyleBackColor = true;
            this.InsertNewEmpBtn.Visible = false;
            this.InsertNewEmpBtn.Click += new System.EventHandler(this.InsertNewEmpBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UpdateBtn.Location = new System.Drawing.Point(1104, 434);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(135, 38);
            this.UpdateBtn.TabIndex = 9;
            this.UpdateBtn.Text = "UPDATE";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Visible = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "DepartmentID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // NewDepartmentIDBox
            // 
            this.NewDepartmentIDBox.FormattingEnabled = true;
            this.NewDepartmentIDBox.Location = new System.Drawing.Point(921, 214);
            this.NewDepartmentIDBox.Name = "NewDepartmentIDBox";
            this.NewDepartmentIDBox.Size = new System.Drawing.Size(212, 33);
            this.NewDepartmentIDBox.TabIndex = 10;
            this.NewDepartmentIDBox.Visible = false;
            // 
            // NewShiftIDBox
            // 
            this.NewShiftIDBox.FormattingEnabled = true;
            this.NewShiftIDBox.Location = new System.Drawing.Point(1207, 214);
            this.NewShiftIDBox.Name = "NewShiftIDBox";
            this.NewShiftIDBox.Size = new System.Drawing.Size(200, 33);
            this.NewShiftIDBox.TabIndex = 11;
            this.NewShiftIDBox.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(941, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 27);
            this.label1.TabIndex = 12;
            this.label1.Text = "Department ID";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(1260, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 27);
            this.label2.TabIndex = 13;
            this.label2.Text = "Shift ID";
            this.label2.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1478, 644);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NewShiftIDBox);
            this.Controls.Add(this.NewDepartmentIDBox);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.InsertNewEmpBtn);
            this.Controls.Add(this.AddEmpBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.OrgLevelLbl);
            this.Controls.Add(this.DepartmentLbl);
            this.Controls.Add(this.OrgLevelBox);
            this.Controls.Add(this.DepartmentBox);
            this.Name = "Form1";
            this.Text = "Human Resource";
            //this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox DepartmentBox;
        private ComboBox OrgLevelBox;
        private Label DepartmentLbl;
        private Label OrgLevelLbl;
        private Button SearchBtn;
        private DataGridView dataGridView1;
        private Button AddEmpBtn;
        private Button InsertNewEmpBtn;
        private Button UpdateBtn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private ComboBox NewDepartmentIDBox;
        private ComboBox NewShiftIDBox;
        private Label label1;
        private Label label2;
    }
}