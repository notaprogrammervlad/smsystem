namespace StudentManagementSystem.Forms.Auth
{
    partial class Register
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
            this.userLbl = new System.Windows.Forms.Label();
            this.userTxt = new System.Windows.Forms.TextBox();
            this.passLbl = new System.Windows.Forms.Label();
            this.passTxt = new System.Windows.Forms.TextBox();
            this.confpassLbl = new System.Windows.Forms.Label();
            this.confpassTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.registerBtn = new System.Windows.Forms.Button();
            this.backtologinBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userLbl
            // 
            this.userLbl.AutoSize = true;
            this.userLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLbl.Location = new System.Drawing.Point(110, 169);
            this.userLbl.Name = "userLbl";
            this.userLbl.Size = new System.Drawing.Size(97, 24);
            this.userLbl.TabIndex = 0;
            this.userLbl.Text = "Username";
            // 
            // userTxt
            // 
            this.userTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTxt.Location = new System.Drawing.Point(213, 165);
            this.userTxt.Name = "userTxt";
            this.userTxt.Size = new System.Drawing.Size(206, 31);
            this.userTxt.TabIndex = 0;
            // 
            // passLbl
            // 
            this.passLbl.AutoSize = true;
            this.passLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passLbl.Location = new System.Drawing.Point(110, 217);
            this.passLbl.Name = "passLbl";
            this.passLbl.Size = new System.Drawing.Size(92, 24);
            this.passLbl.TabIndex = 0;
            this.passLbl.Text = "Password";
            // 
            // passTxt
            // 
            this.passTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passTxt.Location = new System.Drawing.Point(213, 213);
            this.passTxt.Name = "passTxt";
            this.passTxt.PasswordChar = '*';
            this.passTxt.Size = new System.Drawing.Size(206, 31);
            this.passTxt.TabIndex = 1;
            // 
            // confpassLbl
            // 
            this.confpassLbl.AutoSize = true;
            this.confpassLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confpassLbl.Location = new System.Drawing.Point(50, 263);
            this.confpassLbl.Name = "confpassLbl";
            this.confpassLbl.Size = new System.Drawing.Size(162, 24);
            this.confpassLbl.TabIndex = 0;
            this.confpassLbl.Text = "Confirm Password";
            // 
            // confpassTxt
            // 
            this.confpassTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confpassTxt.Location = new System.Drawing.Point(213, 259);
            this.confpassTxt.Name = "confpassTxt";
            this.confpassTxt.PasswordChar = '*';
            this.confpassTxt.Size = new System.Drawing.Size(206, 31);
            this.confpassTxt.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(47, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(397, 42);
            this.label5.TabIndex = 0;
            this.label5.Text = "USER REGISTRATION";
            // 
            // registerBtn
            // 
            this.registerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerBtn.ForeColor = System.Drawing.Color.Black;
            this.registerBtn.Location = new System.Drawing.Point(279, 327);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(140, 37);
            this.registerBtn.TabIndex = 3;
            this.registerBtn.Text = "Register";
            this.registerBtn.UseVisualStyleBackColor = true;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // backtologinBtn
            // 
            this.backtologinBtn.BackColor = System.Drawing.Color.Blue;
            this.backtologinBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.backtologinBtn.FlatAppearance.BorderSize = 0;
            this.backtologinBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backtologinBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backtologinBtn.ForeColor = System.Drawing.Color.White;
            this.backtologinBtn.Location = new System.Drawing.Point(211, 22);
            this.backtologinBtn.Name = "backtologinBtn";
            this.backtologinBtn.Size = new System.Drawing.Size(259, 40);
            this.backtologinBtn.TabIndex = 4;
            this.backtologinBtn.Text = "Back to user login";
            this.backtologinBtn.UseVisualStyleBackColor = false;
            this.backtologinBtn.Click += new System.EventHandler(this.backtologinBtn_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(482, 450);
            this.ControlBox = false;
            this.Controls.Add(this.backtologinBtn);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.confpassTxt);
            this.Controls.Add(this.passTxt);
            this.Controls.Add(this.confpassLbl);
            this.Controls.Add(this.passLbl);
            this.Controls.Add(this.userTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.userLbl);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Register";
            this.Text = "Register";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Register_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Register_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userLbl;
        private System.Windows.Forms.TextBox userTxt;
        private System.Windows.Forms.Label passLbl;
        private System.Windows.Forms.TextBox passTxt;
        private System.Windows.Forms.Label confpassLbl;
        private System.Windows.Forms.TextBox confpassTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.Button backtologinBtn;
    }
}