namespace ABClibrarySystem
{
    partial class ViewBookForm
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
            this.dataGridViewBookdetails = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxSearchbook = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookdetails)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewBookdetails
            // 
            this.dataGridViewBookdetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBookdetails.Location = new System.Drawing.Point(46, 77);
            this.dataGridViewBookdetails.Name = "dataGridViewBookdetails";
            this.dataGridViewBookdetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBookdetails.Size = new System.Drawing.Size(855, 320);
            this.dataGridViewBookdetails.TabIndex = 1;
            this.dataGridViewBookdetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBookdetails_CellContentClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(639, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 13);
            this.label9.TabIndex = 80;
            this.label9.Text = "Search Book Name";
            // 
            // textBoxSearchbook
            // 
            this.textBoxSearchbook.Location = new System.Drawing.Point(757, 14);
            this.textBoxSearchbook.Name = "textBoxSearchbook";
            this.textBoxSearchbook.Size = new System.Drawing.Size(126, 20);
            this.textBoxSearchbook.TabIndex = 81;
            this.textBoxSearchbook.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxSearchbook_KeyUp);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(55, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(230, 37);
            this.label8.TabIndex = 82;
            this.label8.Text = "View Book Details";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // Back
            // 
            this.Back.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Back.AutoSize = true;
            this.Back.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.ForeColor = System.Drawing.Color.Red;
            this.Back.Location = new System.Drawing.Point(2, 4);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(47, 50);
            this.Back.TabIndex = 83;
            this.Back.Text = "<";
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // ViewBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(949, 420);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxSearchbook);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridViewBookdetails);
            this.Name = "ViewBookForm";
            this.Text = "ViewBookForm";
            this.Load += new System.EventHandler(this.ViewBookForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookdetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewBookdetails;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxSearchbook;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label Back;
    }
}