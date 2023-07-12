namespace Assignment
{
    partial class Form1
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblHobbies = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.textNumber = new System.Windows.Forms.TextBox();
            this.textHobbies = new System.Windows.Forms.TextBox();
            this.rbtmale = new System.Windows.Forms.RadioButton();
            this.rbtfemale = new System.Windows.Forms.RadioButton();
            this.rbtother = new System.Windows.Forms.RadioButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblplanguage = new System.Windows.Forms.Label();
            this.cmbplanguage = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(94, 107);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(50, 16);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name: ";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(94, 185);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(112, 16);
            this.lblNumber.TabIndex = 1;
            this.lblNumber.Text = "Personal Number";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(94, 250);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(52, 16);
            this.lblGender.TabIndex = 2;
            this.lblGender.Text = "Gender";
            // 
            // lblHobbies
            // 
            this.lblHobbies.AutoSize = true;
            this.lblHobbies.Location = new System.Drawing.Point(94, 378);
            this.lblHobbies.Name = "lblHobbies";
            this.lblHobbies.Size = new System.Drawing.Size(148, 16);
            this.lblHobbies.TabIndex = 3;
            this.lblHobbies.Text = "Hobbies(0 -1000 words)";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(275, 107);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(298, 22);
            this.textName.TabIndex = 4;
            // 
            // textNumber
            // 
            this.textNumber.Location = new System.Drawing.Point(275, 179);
            this.textNumber.Name = "textNumber";
            this.textNumber.Size = new System.Drawing.Size(298, 22);
            this.textNumber.TabIndex = 5;
            // 
            // textHobbies
            // 
            this.textHobbies.Location = new System.Drawing.Point(275, 378);
            this.textHobbies.Multiline = true;
            this.textHobbies.Name = "textHobbies";
            this.textHobbies.Size = new System.Drawing.Size(298, 135);
            this.textHobbies.TabIndex = 6;
            // 
            // rbtmale
            // 
            this.rbtmale.AutoSize = true;
            this.rbtmale.Location = new System.Drawing.Point(275, 250);
            this.rbtmale.Name = "rbtmale";
            this.rbtmale.Size = new System.Drawing.Size(58, 20);
            this.rbtmale.TabIndex = 7;
            this.rbtmale.TabStop = true;
            this.rbtmale.Text = "Male";
            this.rbtmale.UseVisualStyleBackColor = true;
            // 
            // rbtfemale
            // 
            this.rbtfemale.AutoSize = true;
            this.rbtfemale.Location = new System.Drawing.Point(379, 250);
            this.rbtfemale.Name = "rbtfemale";
            this.rbtfemale.Size = new System.Drawing.Size(74, 20);
            this.rbtfemale.TabIndex = 8;
            this.rbtfemale.TabStop = true;
            this.rbtfemale.Text = "Female";
            this.rbtfemale.UseVisualStyleBackColor = true;
            // 
            // rbtother
            // 
            this.rbtother.AutoSize = true;
            this.rbtother.Location = new System.Drawing.Point(513, 250);
            this.rbtother.Name = "rbtother";
            this.rbtother.Size = new System.Drawing.Size(60, 20);
            this.rbtother.TabIndex = 9;
            this.rbtother.TabStop = true;
            this.rbtother.Text = "Other";
            this.rbtother.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(332, 554);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(136, 37);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // lblplanguage
            // 
            this.lblplanguage.AutoSize = true;
            this.lblplanguage.Location = new System.Drawing.Point(94, 314);
            this.lblplanguage.Name = "lblplanguage";
            this.lblplanguage.Size = new System.Drawing.Size(152, 16);
            this.lblplanguage.TabIndex = 12;
            this.lblplanguage.Text = "Programming Language";
            this.lblplanguage.UseMnemonic = false;
            // 
            // cmbplanguage
            // 
            this.cmbplanguage.FormattingEnabled = true;
            this.cmbplanguage.Location = new System.Drawing.Point(275, 314);
            this.cmbplanguage.Name = "cmbplanguage";
            this.cmbplanguage.Size = new System.Drawing.Size(235, 24);
            this.cmbplanguage.TabIndex = 13;
            this.cmbplanguage.SelectedIndexChanged += new System.EventHandler(this.cmbplanguage_SelectedIndexChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(1171, 111);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(117, 31);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // textSearch
            // 
            this.textSearch.Location = new System.Drawing.Point(864, 115);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(254, 22);
            this.textSearch.TabIndex = 15;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(853, 246);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(466, 120);
            this.dataGridView1.TabIndex = 16;
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(1171, 170);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(99, 31);
            this.btnupdate.TabIndex = 17;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(513, 554);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(98, 37);
            this.btndelete.TabIndex = 18;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1392, 619);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cmbplanguage);
            this.Controls.Add(this.lblplanguage);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.rbtother);
            this.Controls.Add(this.rbtfemale);
            this.Controls.Add(this.rbtmale);
            this.Controls.Add(this.textHobbies);
            this.Controls.Add(this.textNumber);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.lblHobbies);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.lblName);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

       
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblHobbies;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textNumber;
        private System.Windows.Forms.TextBox textHobbies;
        private System.Windows.Forms.RadioButton rbtmale;
        private System.Windows.Forms.RadioButton rbtfemale;
        private System.Windows.Forms.RadioButton rbtother;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblplanguage;
        private System.Windows.Forms.ComboBox cmbplanguage;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
    }
}

