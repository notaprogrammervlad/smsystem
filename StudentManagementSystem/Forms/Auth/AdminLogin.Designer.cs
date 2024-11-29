namespace StudentManagementSystem.Forms.Auth
{
    partial class AdminLogin
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
            this.userTxt = new System.Windows.Forms.TextBox();
            this.passTxt = new System.Windows.Forms.TextBox();
            this.userLbl = new System.Windows.Forms.Label();
            this.passLbl = new System.Windows.Forms.Label();
            this.adminLbl = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.Button();
            this.backtologinBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userTxt
            // 
            this.userTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTxt.Location = new System.Drawing.Point(167, 172);
            this.userTxt.MaxLength = 15;
            this.userTxt.Name = "userTxt";
            this.userTxt.Size = new System.Drawing.Size(255, 40);
            this.userTxt.TabIndex = 0;
            // 
            // passTxt
            // 
            this.passTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passTxt.Location = new System.Drawing.Point(167, 256);
            this.passTxt.MaxLength = 15;
            this.passTxt.Name = "passTxt";
            this.passTxt.Size = new System.Drawing.Size(255, 40);
            this.passTxt.TabIndex = 1;
            // 
            // userLbl
            // 
            this.userLbl.AutoSize = true;
            this.userLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLbl.ForeColor = System.Drawing.Color.White;
            this.userLbl.Location = new System.Drawing.Point(55, 182);
            this.userLbl.Name = "userLbl";
            this.userLbl.Size = new System.Drawing.Size(110, 25);
            this.userLbl.TabIndex = 1;
            this.userLbl.Text = "Username";
            // 
            // passLbl
            // 
            this.passLbl.AutoSize = true;
            this.passLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passLbl.ForeColor = System.Drawing.Color.White;
            this.passLbl.Location = new System.Drawing.Point(55, 266);
            this.passLbl.Name = "passLbl";
            this.passLbl.Size = new System.Drawing.Size(106, 25);
            this.passLbl.TabIndex = 1;
            this.passLbl.Text = "Password";
            // 
            // adminLbl
            // 
            this.adminLbl.AutoSize = true;
            this.adminLbl.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminLbl.ForeColor = System.Drawing.Color.White;
            this.adminLbl.Location = new System.Drawing.Point(63, 76);
            this.adminLbl.Name = "adminLbl";
            this.adminLbl.Size = new System.Drawing.Size(371, 58);
            this.adminLbl.TabIndex = 1;
            this.adminLbl.Text = "ADMIN LOGIN";
            // 
            // loginBtn
            // 
            this.loginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.Location = new System.Drawing.Point(296, 340);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(126, 40);
            this.loginBtn.TabIndex = 2;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // backtologinBtn
            // 
            this.backtologinBtn.BackColor = System.Drawing.Color.Blue;
            this.backtologinBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.backtologinBtn.FlatAppearance.BorderSize = 0;
            this.backtologinBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backtologinBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backtologinBtn.ForeColor = System.Drawing.Color.White;
            this.backtologinBtn.Location = new System.Drawing.Point(214, 12);
            this.backtologinBtn.Name = "backtologinBtn";
            this.backtologinBtn.Size = new System.Drawing.Size(259, 40);
            this.backtologinBtn.TabIndex = 3;
            this.backtologinBtn.Text = "Back to user login";
            this.backtologinBtn.UseVisualStyleBackColor = false;
            this.backtologinBtn.Click += new System.EventHandler(this.backtologinBtn_Click);
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(485, 450);
            this.ControlBox = false;
            this.Controls.Add(this.backtologinBtn);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.adminLbl);
            this.Controls.Add(this.passLbl);
            this.Controls.Add(this.userLbl);
            this.Controls.Add(this.passTxt);
            this.Controls.Add(this.userTxt);
            this.MaximizeBox = false;
            this.Name = "AdminLogin";
            this.Text = "AdminLogin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminLogin_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminLogin_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userTxt;
        private System.Windows.Forms.TextBox passTxt;
        private System.Windows.Forms.Label userLbl;
        private System.Windows.Forms.Label passLbl;
        private System.Windows.Forms.Label adminLbl;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Button backtologinBtn;
    }
}