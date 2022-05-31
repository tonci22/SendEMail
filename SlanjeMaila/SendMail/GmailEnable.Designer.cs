namespace SlanjeMaila
{
    partial class GmailEnable
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
            this.lblNotify = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.linkGoogle = new System.Windows.Forms.LinkLabel();
            this.chkBxEnable = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblNotify
            // 
            this.lblNotify.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNotify.Location = new System.Drawing.Point(12, 9);
            this.lblNotify.Name = "lblNotify";
            this.lblNotify.Size = new System.Drawing.Size(270, 30);
            this.lblNotify.TabIndex = 0;
            this.lblNotify.Text = "\"Za primanje maila priko gmail providera trebas ukljucit \"Less secure apps\"";
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(207, 64);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // linkGoogle
            // 
            this.linkGoogle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linkGoogle.Location = new System.Drawing.Point(12, 39);
            this.linkGoogle.Name = "linkGoogle";
            this.linkGoogle.Size = new System.Drawing.Size(270, 18);
            this.linkGoogle.TabIndex = 2;
            this.linkGoogle.TabStop = true;
            this.linkGoogle.Text = "UKLJUCI OPCIJU";
            this.linkGoogle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkGoogle.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkGoogle_LinkClicked);
            // 
            // chkBxEnable
            // 
            this.chkBxEnable.AutoSize = true;
            this.chkBxEnable.Location = new System.Drawing.Point(15, 64);
            this.chkBxEnable.Name = "chkBxEnable";
            this.chkBxEnable.Size = new System.Drawing.Size(101, 17);
            this.chkBxEnable.TabIndex = 3;
            this.chkBxEnable.Text = "Ne prikazuj vise";
            this.chkBxEnable.UseVisualStyleBackColor = true;
            this.chkBxEnable.CheckedChanged += new System.EventHandler(this.chkBxEnable_CheckedChanged);
            // 
            // GmailEnable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 99);
            this.Controls.Add(this.chkBxEnable);
            this.Controls.Add(this.linkGoogle);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblNotify);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(310, 138);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(310, 138);
            this.Name = "GmailEnable";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BITNO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNotify;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.LinkLabel linkGoogle;
        private System.Windows.Forms.CheckBox chkBxEnable;
    }
}