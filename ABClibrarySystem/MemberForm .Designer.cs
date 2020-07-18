namespace ABClibrarySystem
{
    partial class MemberForm
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
            this.labelname = new System.Windows.Forms.Label();
            this.dataGridViewBookname = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelIssueid = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxIssueid = new System.Windows.Forms.TextBox();
            this.textBoxBookname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxMemberName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePickerIssudate = new System.Windows.Forms.DateTimePicker();
            this.textBoxMemberid = new System.Windows.Forms.TextBox();
            this.buttonIssueBook = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePickerReturndate = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewReturnbook = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.labelissueid1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.labelbookname = new System.Windows.Forms.Label();
            this.labelissuedate = new System.Windows.Forms.Label();
            this.labelReturndate = new System.Windows.Forms.Label();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lablelogout = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReturnbook)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelname
            // 
            this.labelname.AutoSize = true;
            this.labelname.Location = new System.Drawing.Point(63, 30);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(0, 13);
            this.labelname.TabIndex = 0;
            // 
            // dataGridViewBookname
            // 
            this.dataGridViewBookname.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBookname.Location = new System.Drawing.Point(6, 34);
            this.dataGridViewBookname.Name = "dataGridViewBookname";
            this.dataGridViewBookname.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBookname.Size = new System.Drawing.Size(359, 157);
            this.dataGridViewBookname.TabIndex = 2;
            this.dataGridViewBookname.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBookname_CellClick);
            this.dataGridViewBookname.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBookname_CellContentClick);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(21, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 39);
            this.label3.TabIndex = 32;
            this.label3.Text = "Member ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "IssueID";
            // 
            // labelIssueid
            // 
            this.labelIssueid.AutoSize = true;
            this.labelIssueid.Location = new System.Drawing.Point(76, 204);
            this.labelIssueid.Name = "labelIssueid";
            this.labelIssueid.Size = new System.Drawing.Size(0, 13);
            this.labelIssueid.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 351);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Member ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Book Name";
            // 
            // textBoxIssueid
            // 
            this.textBoxIssueid.Location = new System.Drawing.Point(123, 197);
            this.textBoxIssueid.Name = "textBoxIssueid";
            this.textBoxIssueid.Size = new System.Drawing.Size(200, 20);
            this.textBoxIssueid.TabIndex = 37;
            // 
            // textBoxBookname
            // 
            this.textBoxBookname.Location = new System.Drawing.Point(123, 226);
            this.textBoxBookname.Name = "textBoxBookname";
            this.textBoxBookname.Size = new System.Drawing.Size(200, 20);
            this.textBoxBookname.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "MemberName";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBoxMemberName
            // 
            this.textBoxMemberName.Location = new System.Drawing.Point(123, 255);
            this.textBoxMemberName.Name = "textBoxMemberName";
            this.textBoxMemberName.Size = new System.Drawing.Size(200, 20);
            this.textBoxMemberName.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 41;
            this.label6.Text = "Issue Date";
            // 
            // dateTimePickerIssudate
            // 
            this.dateTimePickerIssudate.Location = new System.Drawing.Point(123, 288);
            this.dateTimePickerIssudate.Name = "dateTimePickerIssudate";
            this.dateTimePickerIssudate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerIssudate.TabIndex = 42;
            // 
            // textBoxMemberid
            // 
            this.textBoxMemberid.Location = new System.Drawing.Point(123, 344);
            this.textBoxMemberid.Name = "textBoxMemberid";
            this.textBoxMemberid.Size = new System.Drawing.Size(200, 20);
            this.textBoxMemberid.TabIndex = 43;
            // 
            // buttonIssueBook
            // 
            this.buttonIssueBook.Location = new System.Drawing.Point(139, 380);
            this.buttonIssueBook.Name = "buttonIssueBook";
            this.buttonIssueBook.Size = new System.Drawing.Size(75, 23);
            this.buttonIssueBook.TabIndex = 44;
            this.buttonIssueBook.Text = "IssueBook";
            this.buttonIssueBook.UseVisualStyleBackColor = true;
            this.buttonIssueBook.Click += new System.EventHandler(this.buttonIssueBook_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 13);
            this.label8.TabIndex = 47;
            this.label8.Text = "Please Select your book";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(7, 320);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 13);
            this.label9.TabIndex = 48;
            this.label9.Text = "Select Reurn date";
            // 
            // dateTimePickerReturndate
            // 
            this.dateTimePickerReturndate.Location = new System.Drawing.Point(124, 315);
            this.dateTimePickerReturndate.Name = "dateTimePickerReturndate";
            this.dateTimePickerReturndate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerReturndate.TabIndex = 49;
            // 
            // dataGridViewReturnbook
            // 
            this.dataGridViewReturnbook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReturnbook.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewReturnbook.Name = "dataGridViewReturnbook";
            this.dataGridViewReturnbook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewReturnbook.Size = new System.Drawing.Size(476, 172);
            this.dataGridViewReturnbook.TabIndex = 50;
            this.dataGridViewReturnbook.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewReturnbook_CellClick);
            this.dataGridViewReturnbook.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewBookname);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTimePickerReturndate);
            this.groupBox1.Controls.Add(this.labelIssueid);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxIssueid);
            this.groupBox1.Controls.Add(this.textBoxBookname);
            this.groupBox1.Controls.Add(this.buttonIssueBook);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxMemberid);
            this.groupBox1.Controls.Add(this.textBoxMemberName);
            this.groupBox1.Controls.Add(this.dateTimePickerIssudate);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(12, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(394, 415);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Issue Book";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonReturn);
            this.groupBox2.Controls.Add(this.labelReturndate);
            this.groupBox2.Controls.Add(this.labelissuedate);
            this.groupBox2.Controls.Add(this.labelbookname);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.labelissueid1);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.dataGridViewReturnbook);
            this.groupBox2.Location = new System.Drawing.Point(425, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(488, 418);
            this.groupBox2.TabIndex = 52;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ReturnBook";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(15, 215);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 51;
            this.label10.Text = "Issue ID";
            // 
            // labelissueid1
            // 
            this.labelissueid1.AutoSize = true;
            this.labelissueid1.Location = new System.Drawing.Point(104, 215);
            this.labelissueid1.Name = "labelissueid1";
            this.labelissueid1.Size = new System.Drawing.Size(10, 13);
            this.labelissueid1.TabIndex = 52;
            this.labelissueid1.Text = ".";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(15, 243);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 13);
            this.label12.TabIndex = 53;
            this.label12.Text = "Book Name";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(15, 271);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 13);
            this.label13.TabIndex = 54;
            this.label13.Text = "Issue Date";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(15, 295);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 13);
            this.label14.TabIndex = 55;
            this.label14.Text = "Return Date";
            // 
            // labelbookname
            // 
            this.labelbookname.AutoSize = true;
            this.labelbookname.Location = new System.Drawing.Point(107, 242);
            this.labelbookname.Name = "labelbookname";
            this.labelbookname.Size = new System.Drawing.Size(0, 13);
            this.labelbookname.TabIndex = 56;
            // 
            // labelissuedate
            // 
            this.labelissuedate.AutoSize = true;
            this.labelissuedate.Location = new System.Drawing.Point(110, 271);
            this.labelissuedate.Name = "labelissuedate";
            this.labelissuedate.Size = new System.Drawing.Size(10, 13);
            this.labelissuedate.TabIndex = 57;
            this.labelissuedate.Text = ".";
            // 
            // labelReturndate
            // 
            this.labelReturndate.AutoSize = true;
            this.labelReturndate.Location = new System.Drawing.Point(113, 295);
            this.labelReturndate.Name = "labelReturndate";
            this.labelReturndate.Size = new System.Drawing.Size(10, 13);
            this.labelReturndate.TabIndex = 58;
            this.labelReturndate.Text = ".";
            // 
            // buttonReturn
            // 
            this.buttonReturn.Location = new System.Drawing.Point(170, 380);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(75, 23);
            this.buttonReturn.TabIndex = 59;
            this.buttonReturn.Text = "Return";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::ABClibrarySystem.Properties.Resources._1Logout_Rounded_Up_20px;
            this.pictureBox1.Location = new System.Drawing.Point(775, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 23);
            this.pictureBox1.TabIndex = 53;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lablelogout
            // 
            this.lablelogout.AutoSize = true;
            this.lablelogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lablelogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lablelogout.ForeColor = System.Drawing.Color.Red;
            this.lablelogout.Location = new System.Drawing.Point(809, 17);
            this.lablelogout.Name = "lablelogout";
            this.lablelogout.Size = new System.Drawing.Size(70, 20);
            this.lablelogout.TabIndex = 54;
            this.lablelogout.Text = "Log out";
            this.lablelogout.Click += new System.EventHandler(this.lablelogout_Click);
            // 
            // MemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(925, 476);
            this.Controls.Add(this.lablelogout);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelname);
            this.Name = "MemberForm";
            this.Text = "MemberForm";
            this.Load += new System.EventHandler(this.MemberForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReturnbook)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelname;
        private System.Windows.Forms.DataGridView dataGridViewBookname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelIssueid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxIssueid;
        private System.Windows.Forms.TextBox textBoxBookname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxMemberName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePickerIssudate;
        private System.Windows.Forms.TextBox textBoxMemberid;
        private System.Windows.Forms.Button buttonIssueBook;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePickerReturndate;
        private System.Windows.Forms.DataGridView dataGridViewReturnbook;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.Label labelReturndate;
        private System.Windows.Forms.Label labelissuedate;
        private System.Windows.Forms.Label labelbookname;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label labelissueid1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lablelogout;
    }
}