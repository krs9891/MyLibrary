namespace MyLibrary
{
    partial class AddBook
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.btnSearchISBN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.picBox1 = new System.Windows.Forms.PictureBox();
            this.txtAddTitle = new System.Windows.Forms.TextBox();
            this.txtAddAuthor = new System.Windows.Forms.TextBox();
            this.txtAddImgUrl = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkIsRead = new System.Windows.Forms.CheckBox();
            this.btnImgRef = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ISBN: ";
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(101, 57);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(184, 22);
            this.txtISBN.TabIndex = 1;
            // 
            // btnSearchISBN
            // 
            this.btnSearchISBN.Location = new System.Drawing.Point(291, 57);
            this.btnSearchISBN.Name = "btnSearchISBN";
            this.btnSearchISBN.Size = new System.Drawing.Size(75, 23);
            this.btnSearchISBN.TabIndex = 2;
            this.btnSearchISBN.Text = "Search";
            this.btnSearchISBN.UseVisualStyleBackColor = true;
            this.btnSearchISBN.Click += new System.EventHandler(this.btnSearchISBN_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Title:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Author:";
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(456, 418);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save Book";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // picBox1
            // 
            this.picBox1.Location = new System.Drawing.Point(406, 57);
            this.picBox1.MaximumSize = new System.Drawing.Size(160, 215);
            this.picBox1.MinimumSize = new System.Drawing.Size(160, 215);
            this.picBox1.Name = "picBox1";
            this.picBox1.Size = new System.Drawing.Size(160, 215);
            this.picBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBox1.TabIndex = 8;
            this.picBox1.TabStop = false;
            // 
            // txtAddTitle
            // 
            this.txtAddTitle.Location = new System.Drawing.Point(102, 115);
            this.txtAddTitle.Name = "txtAddTitle";
            this.txtAddTitle.Size = new System.Drawing.Size(264, 22);
            this.txtAddTitle.TabIndex = 9;
            // 
            // txtAddAuthor
            // 
            this.txtAddAuthor.Location = new System.Drawing.Point(102, 163);
            this.txtAddAuthor.Name = "txtAddAuthor";
            this.txtAddAuthor.Size = new System.Drawing.Size(264, 22);
            this.txtAddAuthor.TabIndex = 10;
            // 
            // txtAddImgUrl
            // 
            this.txtAddImgUrl.Location = new System.Drawing.Point(101, 311);
            this.txtAddImgUrl.Name = "txtAddImgUrl";
            this.txtAddImgUrl.Size = new System.Drawing.Size(338, 22);
            this.txtAddImgUrl.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Img URL:";
            // 
            // checkIsRead
            // 
            this.checkIsRead.AutoSize = true;
            this.checkIsRead.Location = new System.Drawing.Point(101, 214);
            this.checkIsRead.Name = "checkIsRead";
            this.checkIsRead.Size = new System.Drawing.Size(108, 20);
            this.checkIsRead.TabIndex = 13;
            this.checkIsRead.Text = "Mark as read";
            this.checkIsRead.UseVisualStyleBackColor = true;
            // 
            // btnImgRef
            // 
            this.btnImgRef.Location = new System.Drawing.Point(445, 311);
            this.btnImgRef.Name = "btnImgRef";
            this.btnImgRef.Size = new System.Drawing.Size(121, 23);
            this.btnImgRef.TabIndex = 17;
            this.btnImgRef.Text = "Refresh Image";
            this.btnImgRef.UseVisualStyleBackColor = true;
            this.btnImgRef.Click += new System.EventHandler(this.btnImgRef_Click);
            // 
            // AddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 491);
            this.Controls.Add(this.btnImgRef);
            this.Controls.Add(this.checkIsRead);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAddImgUrl);
            this.Controls.Add(this.txtAddAuthor);
            this.Controls.Add(this.txtAddTitle);
            this.Controls.Add(this.picBox1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSearchISBN);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.label1);
            this.Name = "AddBook";
            this.Text = "AddBook";
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Button btnSearchISBN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox picBox1;
        private System.Windows.Forms.TextBox txtAddTitle;
        private System.Windows.Forms.TextBox txtAddAuthor;
        private System.Windows.Forms.TextBox txtAddImgUrl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkIsRead;
        private System.Windows.Forms.Button btnImgRef;
    }
}