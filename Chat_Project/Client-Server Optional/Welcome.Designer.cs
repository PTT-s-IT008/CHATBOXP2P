namespace Client_Server_Optional
{
    partial class Welcome
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.host_btn = new System.Windows.Forms.Button();
            this.join_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Do you want to host a server or  join one ?";
            // 
            // host_btn
            // 
            this.host_btn.Location = new System.Drawing.Point(88, 96);
            this.host_btn.Name = "host_btn";
            this.host_btn.Size = new System.Drawing.Size(118, 76);
            this.host_btn.TabIndex = 1;
            this.host_btn.Text = "HOST";
            this.host_btn.UseVisualStyleBackColor = true;
            this.host_btn.Click += new System.EventHandler(this.host_btn_Click);
            // 
            // join_btn
            // 
            this.join_btn.Location = new System.Drawing.Point(281, 96);
            this.join_btn.Name = "join_btn";
            this.join_btn.Size = new System.Drawing.Size(118, 76);
            this.join_btn.TabIndex = 2;
            this.join_btn.Text = "JOIN";
            this.join_btn.UseVisualStyleBackColor = true;
            this.join_btn.Click += new System.EventHandler(this.join_btn_Click);
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 235);
            this.Controls.Add(this.join_btn);
            this.Controls.Add(this.host_btn);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Welcome";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            this.Load += new System.EventHandler(this.Welcome_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Welcome_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button host_btn;
        private System.Windows.Forms.Button join_btn;
    }
}

