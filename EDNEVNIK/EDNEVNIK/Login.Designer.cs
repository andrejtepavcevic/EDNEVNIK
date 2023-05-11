
namespace EDNEVNIK
{
    partial class Login
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.LbWelcome = new System.Windows.Forms.Label();
            this.Welcome2LB = new System.Windows.Forms.Label();
            this.lmail = new System.Windows.Forms.Label();
            this.lpass = new System.Windows.Forms.Label();
            this.btOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(141, 83);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(144, 20);
            this.txtName.TabIndex = 1;
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(141, 136);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(144, 20);
            this.txtpass.TabIndex = 2;
            // 
            // LbWelcome
            // 
            this.LbWelcome.AutoSize = true;
            this.LbWelcome.Location = new System.Drawing.Point(182, 9);
            this.LbWelcome.Name = "LbWelcome";
            this.LbWelcome.Size = new System.Drawing.Size(60, 13);
            this.LbWelcome.TabIndex = 3;
            this.LbWelcome.Text = "Dobrodosli!";
            // 
            // Welcome2LB
            // 
            this.Welcome2LB.AutoSize = true;
            this.Welcome2LB.Location = new System.Drawing.Point(149, 33);
            this.Welcome2LB.Name = "Welcome2LB";
            this.Welcome2LB.Size = new System.Drawing.Size(127, 13);
            this.Welcome2LB.TabIndex = 4;
            this.Welcome2LB.Text = "Da biste nastavili unesite:";
            // 
            // lmail
            // 
            this.lmail.AutoSize = true;
            this.lmail.Location = new System.Drawing.Point(89, 86);
            this.lmail.Name = "lmail";
            this.lmail.Size = new System.Drawing.Size(32, 13);
            this.lmail.TabIndex = 5;
            this.lmail.Text = "Email";
            // 
            // lpass
            // 
            this.lpass.AutoSize = true;
            this.lpass.Location = new System.Drawing.Point(89, 139);
            this.lpass.Name = "lpass";
            this.lpass.Size = new System.Drawing.Size(44, 13);
            this.lpass.TabIndex = 6;
            this.lpass.Text = "Lozinka";
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(176, 185);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(75, 23);
            this.btOk.TabIndex = 7;
            this.btOk.Text = "Potvrdi";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(419, 220);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.lpass);
            this.Controls.Add(this.lmail);
            this.Controls.Add(this.Welcome2LB);
            this.Controls.Add(this.LbWelcome);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtName);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Label LbWelcome;
        private System.Windows.Forms.Label Welcome2LB;
        private System.Windows.Forms.Label lmail;
        private System.Windows.Forms.Label lpass;
        private System.Windows.Forms.Button btOk;
    }
}