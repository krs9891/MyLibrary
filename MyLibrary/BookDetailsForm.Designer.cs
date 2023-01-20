namespace MyLibrary
{
    partial class BookDetailsForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDetId = new System.Windows.Forms.Label();
            this.picBox2 = new System.Windows.Forms.PictureBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtDetISBN = new System.Windows.Forms.TextBox();
            this.txtDetTitle = new System.Windows.Forms.TextBox();
            this.txtDetAuthor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDetImgUrl = new System.Windows.Forms.TextBox();
            this.btnDetLoadImg = new System.Windows.Forms.Button();
            this.btnDetEdit = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnCnl = new System.Windows.Forms.Button();
            this.checkDetIsRead = new System.Windows.Forms.CheckBox();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Author:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Title:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "ISBN:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "ID:";
            // 
            // lblDetId
            // 
            this.lblDetId.AutoSize = true;
            this.lblDetId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetId.Location = new System.Drawing.Point(106, 84);
            this.lblDetId.Name = "lblDetId";
            this.lblDetId.Size = new System.Drawing.Size(59, 20);
            this.lblDetId.TabIndex = 9;
            this.lblDetId.Text = "label5";
            // 
            // picBox2
            // 
            this.picBox2.Location = new System.Drawing.Point(497, 113);
            this.picBox2.MaximumSize = new System.Drawing.Size(160, 215);
            this.picBox2.Name = "picBox2";
            this.picBox2.Size = new System.Drawing.Size(160, 215);
            this.picBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBox2.TabIndex = 13;
            this.picBox2.TabStop = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(437, 23);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(138, 23);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete Book";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtDetISBN
            // 
            this.txtDetISBN.Enabled = false;
            this.txtDetISBN.Location = new System.Drawing.Point(106, 141);
            this.txtDetISBN.Name = "txtDetISBN";
            this.txtDetISBN.Size = new System.Drawing.Size(316, 22);
            this.txtDetISBN.TabIndex = 15;
            // 
            // txtDetTitle
            // 
            this.txtDetTitle.Enabled = false;
            this.txtDetTitle.Location = new System.Drawing.Point(106, 214);
            this.txtDetTitle.Name = "txtDetTitle";
            this.txtDetTitle.Size = new System.Drawing.Size(316, 22);
            this.txtDetTitle.TabIndex = 16;
            // 
            // txtDetAuthor
            // 
            this.txtDetAuthor.Enabled = false;
            this.txtDetAuthor.Location = new System.Drawing.Point(106, 290);
            this.txtDetAuthor.Name = "txtDetAuthor";
            this.txtDetAuthor.Size = new System.Drawing.Size(316, 22);
            this.txtDetAuthor.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 363);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Img URL:";
            // 
            // txtDetImgUrl
            // 
            this.txtDetImgUrl.Enabled = false;
            this.txtDetImgUrl.Location = new System.Drawing.Point(106, 361);
            this.txtDetImgUrl.Name = "txtDetImgUrl";
            this.txtDetImgUrl.Size = new System.Drawing.Size(316, 22);
            this.txtDetImgUrl.TabIndex = 19;
            // 
            // btnDetLoadImg
            // 
            this.btnDetLoadImg.Enabled = false;
            this.btnDetLoadImg.Location = new System.Drawing.Point(306, 389);
            this.btnDetLoadImg.Name = "btnDetLoadImg";
            this.btnDetLoadImg.Size = new System.Drawing.Size(116, 23);
            this.btnDetLoadImg.TabIndex = 20;
            this.btnDetLoadImg.Text = "Load Image";
            this.btnDetLoadImg.UseVisualStyleBackColor = true;
            this.btnDetLoadImg.Click += new System.EventHandler(this.btnDetLoadImg_Click);
            // 
            // btnDetEdit
            // 
            this.btnDetEdit.Location = new System.Drawing.Point(24, 23);
            this.btnDetEdit.Name = "btnDetEdit";
            this.btnDetEdit.Size = new System.Drawing.Size(75, 23);
            this.btnDetEdit.TabIndex = 21;
            this.btnDetEdit.Text = "Edit";
            this.btnDetEdit.UseVisualStyleBackColor = true;
            this.btnDetEdit.Click += new System.EventHandler(this.btnDetEdit_Click);
            // 
            // btnApply
            // 
            this.btnApply.Enabled = false;
            this.btnApply.Location = new System.Drawing.Point(105, 23);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(146, 23);
            this.btnApply.TabIndex = 22;
            this.btnApply.Text = "Apply changes";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnCnl
            // 
            this.btnCnl.Enabled = false;
            this.btnCnl.Location = new System.Drawing.Point(258, 23);
            this.btnCnl.Name = "btnCnl";
            this.btnCnl.Size = new System.Drawing.Size(75, 23);
            this.btnCnl.TabIndex = 23;
            this.btnCnl.Text = "Cancel";
            this.btnCnl.UseVisualStyleBackColor = true;
            this.btnCnl.Click += new System.EventHandler(this.btnCnl_Click);
            // 
            // checkDetIsRead
            // 
            this.checkDetIsRead.AutoSize = true;
            this.checkDetIsRead.Enabled = false;
            this.checkDetIsRead.Location = new System.Drawing.Point(214, 88);
            this.checkDetIsRead.Name = "checkDetIsRead";
            this.checkDetIsRead.Size = new System.Drawing.Size(108, 20);
            this.checkDetIsRead.TabIndex = 24;
            this.checkDetIsRead.Text = "Mark as read";
            this.checkDetIsRead.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(581, 23);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 25;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // BookDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 495);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.checkDetIsRead);
            this.Controls.Add(this.btnCnl);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnDetEdit);
            this.Controls.Add(this.btnDetLoadImg);
            this.Controls.Add(this.txtDetImgUrl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDetAuthor);
            this.Controls.Add(this.txtDetTitle);
            this.Controls.Add(this.txtDetISBN);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.picBox2);
            this.Controls.Add(this.lblDetId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BookDetailsForm";
            this.Text = "BookDetailsForm";
            this.Load += new System.EventHandler(this.BookDetailsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDetId;
        private System.Windows.Forms.PictureBox picBox2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtDetISBN;
        private System.Windows.Forms.TextBox txtDetTitle;
        private System.Windows.Forms.TextBox txtDetAuthor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDetImgUrl;
        private System.Windows.Forms.Button btnDetLoadImg;
        private System.Windows.Forms.Button btnDetEdit;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnCnl;
        private System.Windows.Forms.CheckBox checkDetIsRead;
        private System.Windows.Forms.Button btnClose;
    }
}