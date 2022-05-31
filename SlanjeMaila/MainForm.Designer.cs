namespace SlanjeMaila
{
    partial class MainForm
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
            this.btnSendMailForm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReceiveMailForm = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSendMailForm
            // 
            this.btnSendMailForm.Location = new System.Drawing.Point(90, 52);
            this.btnSendMailForm.Name = "btnSendMailForm";
            this.btnSendMailForm.Size = new System.Drawing.Size(75, 23);
            this.btnSendMailForm.TabIndex = 0;
            this.btnSendMailForm.Text = "Send mail";
            this.btnSendMailForm.UseVisualStyleBackColor = true;
            this.btnSendMailForm.Click += new System.EventHandler(this.btnSendMailForm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dat GUI";
            // 
            // btnReceiveMailForm
            // 
            this.btnReceiveMailForm.Location = new System.Drawing.Point(86, 94);
            this.btnReceiveMailForm.Name = "btnReceiveMailForm";
            this.btnReceiveMailForm.Size = new System.Drawing.Size(86, 23);
            this.btnReceiveMailForm.TabIndex = 2;
            this.btnReceiveMailForm.Text = "Receive mail";
            this.btnReceiveMailForm.UseVisualStyleBackColor = true;
            this.btnReceiveMailForm.Click += new System.EventHandler(this.btnReceiveMailForm_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(178, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 40);
            this.label2.TabIndex = 3;
            this.label2.Text = "Receive trenutno ne radi";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnReceiveMailForm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSendMailForm);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSendMailForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReceiveMailForm;
        private System.Windows.Forms.Label label2;
    }
}