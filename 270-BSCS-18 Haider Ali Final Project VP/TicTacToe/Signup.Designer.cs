namespace TicTacToe
{
    partial class Signup
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
            this.label5 = new System.Windows.Forms.Label();
            this.newplayerpass = new System.Windows.Forms.TextBox();
            this.newplayername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.submitnewplayyer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Password";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // newplayerpass
            // 
            this.newplayerpass.Location = new System.Drawing.Point(67, 50);
            this.newplayerpass.Name = "newplayerpass";
            this.newplayerpass.Size = new System.Drawing.Size(100, 20);
            this.newplayerpass.TabIndex = 13;
            this.newplayerpass.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // newplayername
            // 
            this.newplayername.Location = new System.Drawing.Point(67, 28);
            this.newplayername.Name = "newplayername";
            this.newplayername.Size = new System.Drawing.Size(100, 20);
            this.newplayername.TabIndex = 12;
            this.newplayername.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Payer Info";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // submitnewplayyer
            // 
            this.submitnewplayyer.Location = new System.Drawing.Point(79, 89);
            this.submitnewplayyer.Name = "submitnewplayyer";
            this.submitnewplayyer.Size = new System.Drawing.Size(75, 23);
            this.submitnewplayyer.TabIndex = 15;
            this.submitnewplayyer.Text = "Submit";
            this.submitnewplayyer.UseVisualStyleBackColor = true;
            this.submitnewplayyer.Click += new System.EventHandler(this.button2_Click);
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(206, 130);
            this.Controls.Add(this.submitnewplayyer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.newplayerpass);
            this.Controls.Add(this.newplayername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Signup";
            this.Text = "Signup";
            this.Load += new System.EventHandler(this.Signup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox newplayerpass;
        private System.Windows.Forms.TextBox newplayername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button submitnewplayyer;
    }
}