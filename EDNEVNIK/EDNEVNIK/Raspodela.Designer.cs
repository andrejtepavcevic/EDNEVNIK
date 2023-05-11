
namespace EDNEVNIK
{
    partial class Raspodela
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
            this.cmbNastavnik = new System.Windows.Forms.ComboBox();
            this.cmbGodina = new System.Windows.Forms.ComboBox();
            this.cmbPredmet = new System.Windows.Forms.ComboBox();
            this.cmbOdeljenje = new System.Windows.Forms.ComboBox();
            this.lblID = new System.Windows.Forms.Label();
            this.LblGodina = new System.Windows.Forms.Label();
            this.LblNastavnik = new System.Windows.Forms.Label();
            this.LblPredmet = new System.Windows.Forms.Label();
            this.LblOdeljenje = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btPrev = new System.Windows.Forms.Button();
            this.btNext = new System.Windows.Forms.Button();
            this.btFirst = new System.Windows.Forms.Button();
            this.btLast = new System.Windows.Forms.Button();
            this.btadd = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbNastavnik
            // 
            this.cmbNastavnik.FormattingEnabled = true;
            this.cmbNastavnik.Location = new System.Drawing.Point(89, 110);
            this.cmbNastavnik.Name = "cmbNastavnik";
            this.cmbNastavnik.Size = new System.Drawing.Size(145, 21);
            this.cmbNastavnik.TabIndex = 0;
            // 
            // cmbGodina
            // 
            this.cmbGodina.FormattingEnabled = true;
            this.cmbGodina.Location = new System.Drawing.Point(89, 70);
            this.cmbGodina.Name = "cmbGodina";
            this.cmbGodina.Size = new System.Drawing.Size(145, 21);
            this.cmbGodina.TabIndex = 1;
            // 
            // cmbPredmet
            // 
            this.cmbPredmet.FormattingEnabled = true;
            this.cmbPredmet.Location = new System.Drawing.Point(89, 152);
            this.cmbPredmet.Name = "cmbPredmet";
            this.cmbPredmet.Size = new System.Drawing.Size(145, 21);
            this.cmbPredmet.TabIndex = 2;
            // 
            // cmbOdeljenje
            // 
            this.cmbOdeljenje.FormattingEnabled = true;
            this.cmbOdeljenje.Location = new System.Drawing.Point(89, 191);
            this.cmbOdeljenje.Name = "cmbOdeljenje";
            this.cmbOdeljenje.Size = new System.Drawing.Size(145, 21);
            this.cmbOdeljenje.TabIndex = 3;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(24, 33);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 4;
            this.lblID.Text = "ID";
            // 
            // LblGodina
            // 
            this.LblGodina.AutoSize = true;
            this.LblGodina.Location = new System.Drawing.Point(24, 73);
            this.LblGodina.Name = "LblGodina";
            this.LblGodina.Size = new System.Drawing.Size(41, 13);
            this.LblGodina.TabIndex = 5;
            this.LblGodina.Text = "Godina";
            // 
            // LblNastavnik
            // 
            this.LblNastavnik.AutoSize = true;
            this.LblNastavnik.Location = new System.Drawing.Point(24, 115);
            this.LblNastavnik.Name = "LblNastavnik";
            this.LblNastavnik.Size = new System.Drawing.Size(55, 13);
            this.LblNastavnik.TabIndex = 6;
            this.LblNastavnik.Text = "Nastavnik";
            // 
            // LblPredmet
            // 
            this.LblPredmet.AutoSize = true;
            this.LblPredmet.Location = new System.Drawing.Point(24, 154);
            this.LblPredmet.Name = "LblPredmet";
            this.LblPredmet.Size = new System.Drawing.Size(46, 13);
            this.LblPredmet.TabIndex = 7;
            this.LblPredmet.Text = "Predmet";
            // 
            // LblOdeljenje
            // 
            this.LblOdeljenje.AutoSize = true;
            this.LblOdeljenje.Location = new System.Drawing.Point(24, 194);
            this.LblOdeljenje.Name = "LblOdeljenje";
            this.LblOdeljenje.Size = new System.Drawing.Size(51, 13);
            this.LblOdeljenje.TabIndex = 8;
            this.LblOdeljenje.Text = "Odeljenje";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(89, 30);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(145, 20);
            this.txtID.TabIndex = 9;
            // 
            // btPrev
            // 
            this.btPrev.Location = new System.Drawing.Point(27, 227);
            this.btPrev.Name = "btPrev";
            this.btPrev.Size = new System.Drawing.Size(75, 28);
            this.btPrev.TabIndex = 10;
            this.btPrev.Text = "<";
            this.btPrev.UseVisualStyleBackColor = true;
            this.btPrev.Click += new System.EventHandler(this.btPrev_Click);
            // 
            // btNext
            // 
            this.btNext.Location = new System.Drawing.Point(131, 227);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(75, 28);
            this.btNext.TabIndex = 11;
            this.btNext.Text = ">";
            this.btNext.UseVisualStyleBackColor = true;
            this.btNext.Click += new System.EventHandler(this.btNext_Click);
            // 
            // btFirst
            // 
            this.btFirst.Location = new System.Drawing.Point(27, 261);
            this.btFirst.Name = "btFirst";
            this.btFirst.Size = new System.Drawing.Size(75, 28);
            this.btFirst.TabIndex = 12;
            this.btFirst.Text = "<<";
            this.btFirst.UseVisualStyleBackColor = true;
            this.btFirst.Click += new System.EventHandler(this.btFirst_Click);
            // 
            // btLast
            // 
            this.btLast.Location = new System.Drawing.Point(131, 261);
            this.btLast.Name = "btLast";
            this.btLast.Size = new System.Drawing.Size(75, 28);
            this.btLast.TabIndex = 13;
            this.btLast.Text = ">>";
            this.btLast.UseVisualStyleBackColor = true;
            this.btLast.Click += new System.EventHandler(this.btLast_Click);
            // 
            // btadd
            // 
            this.btadd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btadd.Location = new System.Drawing.Point(27, 295);
            this.btadd.Name = "btadd";
            this.btadd.Size = new System.Drawing.Size(75, 28);
            this.btadd.TabIndex = 14;
            this.btadd.Text = "Dodaj";
            this.btadd.UseVisualStyleBackColor = false;
            this.btadd.Click += new System.EventHandler(this.btadd_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btUpdate.Location = new System.Drawing.Point(79, 339);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(75, 28);
            this.btUpdate.TabIndex = 15;
            this.btUpdate.Text = "Izmeni";
            this.btUpdate.UseVisualStyleBackColor = false;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btDelete
            // 
            this.btDelete.BackColor = System.Drawing.Color.Red;
            this.btDelete.Location = new System.Drawing.Point(131, 295);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(75, 28);
            this.btDelete.TabIndex = 16;
            this.btDelete.Text = "Obrisi";
            this.btDelete.UseVisualStyleBackColor = false;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // Raspodela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(344, 450);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.btadd);
            this.Controls.Add(this.btLast);
            this.Controls.Add(this.btFirst);
            this.Controls.Add(this.btNext);
            this.Controls.Add(this.btPrev);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.LblOdeljenje);
            this.Controls.Add(this.LblPredmet);
            this.Controls.Add(this.LblNastavnik);
            this.Controls.Add(this.LblGodina);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.cmbOdeljenje);
            this.Controls.Add(this.cmbPredmet);
            this.Controls.Add(this.cmbGodina);
            this.Controls.Add(this.cmbNastavnik);
            this.Name = "Raspodela";
            this.Text = "Raspodela";
            this.Load += new System.EventHandler(this.Raspodela_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbNastavnik;
        private System.Windows.Forms.ComboBox cmbGodina;
        private System.Windows.Forms.ComboBox cmbPredmet;
        private System.Windows.Forms.ComboBox cmbOdeljenje;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label LblGodina;
        private System.Windows.Forms.Label LblNastavnik;
        private System.Windows.Forms.Label LblPredmet;
        private System.Windows.Forms.Label LblOdeljenje;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btPrev;
        private System.Windows.Forms.Button btNext;
        private System.Windows.Forms.Button btFirst;
        private System.Windows.Forms.Button btLast;
        private System.Windows.Forms.Button btadd;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btDelete;
    }
}