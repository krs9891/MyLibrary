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
            this.lblDetISBN = new System.Windows.Forms.Label();
            this.lblDetTitle = new System.Windows.Forms.Label();
            this.lblDetAuthor = new System.Windows.Forms.Label();
            this.picBox2 = new System.Windows.Forms.PictureBox();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Author:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Title:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "ISBN:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "ID:";
            // 
            // lblDetId
            // 
            this.lblDetId.AutoSize = true;
            this.lblDetId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetId.Location = new System.Drawing.Point(141, 34);
            this.lblDetId.Name = "lblDetId";
            this.lblDetId.Size = new System.Drawing.Size(59, 20);
            this.lblDetId.TabIndex = 9;
            this.lblDetId.Text = "label5";
            // 
            // lblDetISBN
            // 
            this.lblDetISBN.AutoSize = true;
            this.lblDetISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetISBN.Location = new System.Drawing.Point(141, 91);
            this.lblDetISBN.Name = "lblDetISBN";
            this.lblDetISBN.Size = new System.Drawing.Size(59, 20);
            this.lblDetISBN.TabIndex = 10;
            this.lblDetISBN.Text = "label6";
            // 
            // lblDetTitle
            // 
            this.lblDetTitle.AutoSize = true;
            this.lblDetTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetTitle.Location = new System.Drawing.Point(141, 148);
            this.lblDetTitle.Name = "lblDetTitle";
            this.lblDetTitle.Size = new System.Drawing.Size(59, 20);
            this.lblDetTitle.TabIndex = 11;
            this.lblDetTitle.Text = "label7";
            // 
            // lblDetAuthor
            // 
            this.lblDetAuthor.AutoSize = true;
            this.lblDetAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetAuthor.Location = new System.Drawing.Point(141, 205);
            this.lblDetAuthor.Name = "lblDetAuthor";
            this.lblDetAuthor.Size = new System.Drawing.Size(59, 20);
            this.lblDetAuthor.TabIndex = 12;
            this.lblDetAuthor.Text = "label8";
            // 
            // picBox2
            // 
            this.picBox2.Location = new System.Drawing.Point(557, 54);
            this.picBox2.Name = "picBox2";
            this.picBox2.Size = new System.Drawing.Size(159, 215);
            this.picBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBox2.TabIndex = 13;
            this.picBox2.TabStop = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(557, 370);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // BookDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.picBox2);
            this.Controls.Add(this.lblDetAuthor);
            this.Controls.Add(this.lblDetTitle);
            this.Controls.Add(this.lblDetISBN);
            this.Controls.Add(this.lblDetId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BookDetailsForm";
            this.Text = "BookDetailsForm";
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
        private System.Windows.Forms.Label lblDetISBN;
        private System.Windows.Forms.Label lblDetTitle;
        private System.Windows.Forms.Label lblDetAuthor;
        private System.Windows.Forms.PictureBox picBox2;
        private System.Windows.Forms.Button btnDelete;
    }
}