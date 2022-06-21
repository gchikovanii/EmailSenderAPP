namespace EmailSenderApp
{
    partial class Email
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Email));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.emailTb = new System.Windows.Forms.TextBox();
            this.passwordTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.recipientEmailTb = new System.Windows.Forms.TextBox();
            this.Body = new System.Windows.Forms.Label();
            this.bodyRTB = new System.Windows.Forms.RichTextBox();
            this.sendBtn = new System.Windows.Forms.Button();
            this.subjectTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.senderNameTb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.attachmentTb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.attachBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(139, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email Sender";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // emailTb
            // 
            this.emailTb.Location = new System.Drawing.Point(16, 53);
            this.emailTb.Name = "emailTb";
            this.emailTb.Size = new System.Drawing.Size(364, 20);
            this.emailTb.TabIndex = 3;
            // 
            // passwordTb
            // 
            this.passwordTb.Location = new System.Drawing.Point(16, 103);
            this.passwordTb.Name = "passwordTb";
            this.passwordTb.PasswordChar = '*';
            this.passwordTb.Size = new System.Drawing.Size(364, 20);
            this.passwordTb.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Recipient Email";
            // 
            // recipientEmailTb
            // 
            this.recipientEmailTb.Location = new System.Drawing.Point(16, 202);
            this.recipientEmailTb.Name = "recipientEmailTb";
            this.recipientEmailTb.Size = new System.Drawing.Size(364, 20);
            this.recipientEmailTb.TabIndex = 6;
            // 
            // Body
            // 
            this.Body.AutoSize = true;
            this.Body.Location = new System.Drawing.Point(16, 361);
            this.Body.Name = "Body";
            this.Body.Size = new System.Drawing.Size(31, 13);
            this.Body.TabIndex = 7;
            this.Body.Text = "Body";
            // 
            // bodyRTB
            // 
            this.bodyRTB.Location = new System.Drawing.Point(16, 378);
            this.bodyRTB.Name = "bodyRTB";
            this.bodyRTB.Size = new System.Drawing.Size(364, 175);
            this.bodyRTB.TabIndex = 8;
            this.bodyRTB.Text = "";
            // 
            // sendBtn
            // 
            this.sendBtn.Location = new System.Drawing.Point(299, 563);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(81, 33);
            this.sendBtn.TabIndex = 9;
            this.sendBtn.Text = "Send";
            this.sendBtn.UseVisualStyleBackColor = true;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // subjectTb
            // 
            this.subjectTb.Location = new System.Drawing.Point(16, 258);
            this.subjectTb.Name = "subjectTb";
            this.subjectTb.Size = new System.Drawing.Size(364, 20);
            this.subjectTb.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Subject";
            // 
            // senderNameTb
            // 
            this.senderNameTb.Location = new System.Drawing.Point(16, 151);
            this.senderNameTb.Name = "senderNameTb";
            this.senderNameTb.Size = new System.Drawing.Size(364, 20);
            this.senderNameTb.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Sender Name";
            // 
            // attachmentTb
            // 
            this.attachmentTb.Location = new System.Drawing.Point(16, 317);
            this.attachmentTb.Name = "attachmentTb";
            this.attachmentTb.Size = new System.Drawing.Size(335, 20);
            this.attachmentTb.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 296);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Attachment";
            // 
            // attachBtn
            // 
            this.attachBtn.Location = new System.Drawing.Point(357, 318);
            this.attachBtn.Name = "attachBtn";
            this.attachBtn.Size = new System.Drawing.Size(23, 20);
            this.attachBtn.TabIndex = 16;
            this.attachBtn.Text = "...";
            this.attachBtn.UseVisualStyleBackColor = true;
            this.attachBtn.Click += new System.EventHandler(this.attachBtn_Click);
            // 
            // Email
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 606);
            this.Controls.Add(this.attachBtn);
            this.Controls.Add(this.attachmentTb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.senderNameTb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.subjectTb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.bodyRTB);
            this.Controls.Add(this.Body);
            this.Controls.Add(this.recipientEmailTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.passwordTb);
            this.Controls.Add(this.emailTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Email";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Email";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox emailTb;
        private System.Windows.Forms.TextBox passwordTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox recipientEmailTb;
        private System.Windows.Forms.Label Body;
        private System.Windows.Forms.RichTextBox bodyRTB;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.TextBox subjectTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox senderNameTb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox attachmentTb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button attachBtn;
    }
}

