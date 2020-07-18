namespace ABClibrarySystem
{
    partial class ManageIssueBook
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
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridViewReturnbook = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.richTextBoxContent = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxEMAIL = new System.Windows.Forms.TextBox();
            this.buttonmail = new System.Windows.Forms.Button();
            this.textBoxBookNAME = new System.Windows.Forms.TextBox();
            this.textBoxMemberName = new System.Windows.Forms.TextBox();
            this.textBoxIssueDate = new System.Windows.Forms.TextBox();
            this.textBoxReturndate = new System.Windows.Forms.TextBox();
            this.textBoxMembeerid = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReturnbook)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(58, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(246, 37);
            this.label8.TabIndex = 75;
            this.label8.Text = "Manage Issue Book";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // dataGridViewReturnbook
            // 
            this.dataGridViewReturnbook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReturnbook.Location = new System.Drawing.Point(19, 65);
            this.dataGridViewReturnbook.Name = "dataGridViewReturnbook";
            this.dataGridViewReturnbook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewReturnbook.Size = new System.Drawing.Size(742, 209);
            this.dataGridViewReturnbook.TabIndex = 76;
            this.dataGridViewReturnbook.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewReturnbook_CellClick);
            this.dataGridViewReturnbook.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewReturnbook_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 299);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 77;
            this.label1.Text = "Book Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 341);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 78;
            this.label2.Text = "Member Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 375);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 79;
            this.label3.Text = "Issue  Date";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(239, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 80;
            this.label4.Text = "Return Date";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(245, 357);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 81;
            this.label5.Text = "Member ID";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // richTextBoxContent
            // 
            this.richTextBoxContent.Location = new System.Drawing.Point(509, 317);
            this.richTextBoxContent.Name = "richTextBoxContent";
            this.richTextBoxContent.Size = new System.Drawing.Size(228, 90);
            this.richTextBoxContent.TabIndex = 82;
            this.richTextBoxContent.Text = "Please give your book return  as soon possible ";
            this.richTextBoxContent.TextChanged += new System.EventHandler(this.richTextBoxContent_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(432, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 83;
            this.label6.Text = "Email";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // textBoxEMAIL
            // 
            this.textBoxEMAIL.Location = new System.Drawing.Point(509, 291);
            this.textBoxEMAIL.Name = "textBoxEMAIL";
            this.textBoxEMAIL.Size = new System.Drawing.Size(169, 20);
            this.textBoxEMAIL.TabIndex = 84;
            this.textBoxEMAIL.TextChanged += new System.EventHandler(this.textBoxEMAIL_TextChanged);
            // 
            // buttonmail
            // 
            this.buttonmail.Location = new System.Drawing.Point(770, 354);
            this.buttonmail.Name = "buttonmail";
            this.buttonmail.Size = new System.Drawing.Size(75, 23);
            this.buttonmail.TabIndex = 85;
            this.buttonmail.Text = "Send Email";
            this.buttonmail.UseVisualStyleBackColor = true;
            this.buttonmail.Click += new System.EventHandler(this.buttonmail_Click);
            // 
            // textBoxBookNAME
            // 
            this.textBoxBookNAME.Location = new System.Drawing.Point(99, 299);
            this.textBoxBookNAME.Name = "textBoxBookNAME";
            this.textBoxBookNAME.Size = new System.Drawing.Size(134, 20);
            this.textBoxBookNAME.TabIndex = 86;
            this.textBoxBookNAME.TextChanged += new System.EventHandler(this.textBoxBookNAME_TextChanged);
            // 
            // textBoxMemberName
            // 
            this.textBoxMemberName.Location = new System.Drawing.Point(102, 341);
            this.textBoxMemberName.Name = "textBoxMemberName";
            this.textBoxMemberName.Size = new System.Drawing.Size(131, 20);
            this.textBoxMemberName.TabIndex = 87;
            this.textBoxMemberName.TextChanged += new System.EventHandler(this.textBoxMemberName_TextChanged);
            // 
            // textBoxIssueDate
            // 
            this.textBoxIssueDate.Location = new System.Drawing.Point(99, 375);
            this.textBoxIssueDate.Name = "textBoxIssueDate";
            this.textBoxIssueDate.Size = new System.Drawing.Size(134, 20);
            this.textBoxIssueDate.TabIndex = 88;
            this.textBoxIssueDate.TextChanged += new System.EventHandler(this.textBoxIssueDate_TextChanged);
            // 
            // textBoxReturndate
            // 
            this.textBoxReturndate.Location = new System.Drawing.Point(310, 299);
            this.textBoxReturndate.Name = "textBoxReturndate";
            this.textBoxReturndate.Size = new System.Drawing.Size(116, 20);
            this.textBoxReturndate.TabIndex = 89;
            this.textBoxReturndate.TextChanged += new System.EventHandler(this.textBoxReturndate_TextChanged);
            // 
            // textBoxMembeerid
            // 
            this.textBoxMembeerid.Location = new System.Drawing.Point(310, 354);
            this.textBoxMembeerid.Name = "textBoxMembeerid";
            this.textBoxMembeerid.Size = new System.Drawing.Size(116, 20);
            this.textBoxMembeerid.TabIndex = 90;
            this.textBoxMembeerid.TextChanged += new System.EventHandler(this.textBoxMembeerid_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(432, 330);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 91;
            this.label7.Text = "Content";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Back
            // 
            this.Back.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Back.AutoSize = true;
            this.Back.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Back.Location = new System.Drawing.Point(5, -1);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(47, 50);
            this.Back.TabIndex = 106;
            this.Back.Text = "<";
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // ManageIssueBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 424);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxMembeerid);
            this.Controls.Add(this.textBoxReturndate);
            this.Controls.Add(this.textBoxIssueDate);
            this.Controls.Add(this.textBoxMemberName);
            this.Controls.Add(this.textBoxBookNAME);
            this.Controls.Add(this.buttonmail);
            this.Controls.Add(this.textBoxEMAIL);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.richTextBoxContent);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewReturnbook);
            this.Controls.Add(this.label8);
            this.Name = "ManageIssueBook";
            this.Text = "ManageIssueBook";
            this.Load += new System.EventHandler(this.ManageIssueBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReturnbook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridViewReturnbook;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTextBoxContent;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxEMAIL;
        private System.Windows.Forms.Button buttonmail;
        private System.Windows.Forms.TextBox textBoxBookNAME;
        private System.Windows.Forms.TextBox textBoxMemberName;
        private System.Windows.Forms.TextBox textBoxIssueDate;
        private System.Windows.Forms.TextBox textBoxReturndate;
        private System.Windows.Forms.TextBox textBoxMembeerid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Back;
    }
}