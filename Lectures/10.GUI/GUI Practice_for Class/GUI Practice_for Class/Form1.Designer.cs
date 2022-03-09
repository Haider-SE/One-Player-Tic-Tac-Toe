namespace GUI_Practice_for_Class
{
    partial class Main_frm
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
            this.btn_enter = new System.Windows.Forms.Button();
            this.btn_Active = new System.Windows.Forms.Button();
            this.lbl_name = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.chkbox_red = new System.Windows.Forms.CheckBox();
            this.chkBox_green = new System.Windows.Forms.CheckBox();
            this.lstBox_name = new System.Windows.Forms.ListBox();
            this.picBox_pic1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_pic1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_enter
            // 
            this.btn_enter.Enabled = false;
            this.btn_enter.Location = new System.Drawing.Point(358, 308);
            this.btn_enter.Name = "btn_enter";
            this.btn_enter.Size = new System.Drawing.Size(75, 23);
            this.btn_enter.TabIndex = 0;
            this.btn_enter.Text = "Enter";
            this.btn_enter.UseVisualStyleBackColor = true;
            this.btn_enter.Click += new System.EventHandler(this.btn_enter_Click);
            // 
            // btn_Active
            // 
            this.btn_Active.Enabled = false;
            this.btn_Active.Location = new System.Drawing.Point(358, 267);
            this.btn_Active.Name = "btn_Active";
            this.btn_Active.Size = new System.Drawing.Size(75, 23);
            this.btn_Active.TabIndex = 1;
            this.btn_Active.Text = "Active";
            this.btn_Active.UseVisualStyleBackColor = true;
            this.btn_Active.Click += new System.EventHandler(this.btn_Active_Click);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(24, 46);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(35, 13);
            this.lbl_name.TabIndex = 2;
            this.lbl_name.Text = "Name";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(106, 43);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(100, 20);
            this.txt_name.TabIndex = 3;
            // 
            // chkbox_red
            // 
            this.chkbox_red.AutoSize = true;
            this.chkbox_red.Location = new System.Drawing.Point(27, 84);
            this.chkbox_red.Name = "chkbox_red";
            this.chkbox_red.Size = new System.Drawing.Size(46, 17);
            this.chkbox_red.TabIndex = 4;
            this.chkbox_red.Text = "Red";
            this.chkbox_red.UseVisualStyleBackColor = true;
            this.chkbox_red.CheckedChanged += new System.EventHandler(this.chkbox_red_CheckedChanged);
            // 
            // chkBox_green
            // 
            this.chkBox_green.AutoSize = true;
            this.chkBox_green.Location = new System.Drawing.Point(27, 107);
            this.chkBox_green.Name = "chkBox_green";
            this.chkBox_green.Size = new System.Drawing.Size(55, 17);
            this.chkBox_green.TabIndex = 5;
            this.chkBox_green.Text = "Green";
            this.chkBox_green.UseVisualStyleBackColor = true;
            this.chkBox_green.CheckedChanged += new System.EventHandler(this.chkBox_green_CheckedChanged);
            // 
            // lstBox_name
            // 
            this.lstBox_name.FormattingEnabled = true;
            this.lstBox_name.Location = new System.Drawing.Point(27, 144);
            this.lstBox_name.Name = "lstBox_name";
            this.lstBox_name.Size = new System.Drawing.Size(120, 95);
            this.lstBox_name.TabIndex = 6;
            // 
            // picBox_pic1
            // 
            this.picBox_pic1.Location = new System.Drawing.Point(263, 84);
            this.picBox_pic1.Name = "picBox_pic1";
            this.picBox_pic1.Size = new System.Drawing.Size(170, 86);
            this.picBox_pic1.TabIndex = 7;
            this.picBox_pic1.TabStop = false;
            // 
            // Main_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(460, 362);
            this.Controls.Add(this.picBox_pic1);
            this.Controls.Add(this.lstBox_name);
            this.Controls.Add(this.chkBox_green);
            this.Controls.Add(this.chkbox_red);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.btn_Active);
            this.Controls.Add(this.btn_enter);
            this.Name = "Main_frm";
            this.Text = "Main Form";
            ((System.ComponentModel.ISupportInitialize)(this.picBox_pic1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_enter;
        private System.Windows.Forms.Button btn_Active;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.CheckBox chkbox_red;
        private System.Windows.Forms.CheckBox chkBox_green;
        private System.Windows.Forms.ListBox lstBox_name;
        private System.Windows.Forms.PictureBox picBox_pic1;
    }
}

