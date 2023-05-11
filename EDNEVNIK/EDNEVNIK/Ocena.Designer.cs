
namespace EDNEVNIK
{
    partial class Ocena
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
            this.cmbGodina = new System.Windows.Forms.ComboBox();
            this.cmbProfesor = new System.Windows.Forms.ComboBox();
            this.cmbPredmet = new System.Windows.Forms.ComboBox();
            this.cmbOdeljenje = new System.Windows.Forms.ComboBox();
            this.cmbUcenikl = new System.Windows.Forms.ComboBox();
            this.cmbOcena = new System.Windows.Forms.ComboBox();
            this.Datum = new System.Windows.Forms.DateTimePicker();
            this.tbId = new System.Windows.Forms.TextBox();
            this.BtInsert = new System.Windows.Forms.Button();
            this.BtUpdate = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.DTGocene = new System.Windows.Forms.DataGridView();
            this.lbGodina = new System.Windows.Forms.Label();
            this.lbProfesor = new System.Windows.Forms.Label();
            this.LbPRedmet = new System.Windows.Forms.Label();
            this.lbOdeljenje = new System.Windows.Forms.Label();
            this.LbUcenik = new System.Windows.Forms.Label();
            this.lbOcena = new System.Windows.Forms.Label();
            this.LbID = new System.Windows.Forms.Label();
            this.LbDatum = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DTGocene)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbGodina
            // 
            this.cmbGodina.FormattingEnabled = true;
            this.cmbGodina.Location = new System.Drawing.Point(34, 57);
            this.cmbGodina.Name = "cmbGodina";
            this.cmbGodina.Size = new System.Drawing.Size(121, 21);
            this.cmbGodina.TabIndex = 0;
            this.cmbGodina.SelectedValueChanged += new System.EventHandler(this.cmbGodina_SelectedValueChanged);
            // 
            // cmbProfesor
            // 
            this.cmbProfesor.FormattingEnabled = true;
            this.cmbProfesor.Location = new System.Drawing.Point(161, 57);
            this.cmbProfesor.Name = "cmbProfesor";
            this.cmbProfesor.Size = new System.Drawing.Size(121, 21);
            this.cmbProfesor.TabIndex = 1;
            this.cmbProfesor.SelectedValueChanged += new System.EventHandler(this.cmbProfesor_SelectedValueChanged);
            // 
            // cmbPredmet
            // 
            this.cmbPredmet.FormattingEnabled = true;
            this.cmbPredmet.Location = new System.Drawing.Point(288, 57);
            this.cmbPredmet.Name = "cmbPredmet";
            this.cmbPredmet.Size = new System.Drawing.Size(121, 21);
            this.cmbPredmet.TabIndex = 2;
            this.cmbPredmet.SelectedValueChanged += new System.EventHandler(this.cmbPredmet_SelectedValueChanged);
            // 
            // cmbOdeljenje
            // 
            this.cmbOdeljenje.FormattingEnabled = true;
            this.cmbOdeljenje.Location = new System.Drawing.Point(415, 57);
            this.cmbOdeljenje.Name = "cmbOdeljenje";
            this.cmbOdeljenje.Size = new System.Drawing.Size(121, 21);
            this.cmbOdeljenje.TabIndex = 3;
            this.cmbOdeljenje.SelectedValueChanged += new System.EventHandler(this.cmbOdeljenje_SelectedValueChanged);
            // 
            // cmbUcenikl
            // 
            this.cmbUcenikl.FormattingEnabled = true;
            this.cmbUcenikl.Location = new System.Drawing.Point(34, 118);
            this.cmbUcenikl.Name = "cmbUcenikl";
            this.cmbUcenikl.Size = new System.Drawing.Size(121, 21);
            this.cmbUcenikl.TabIndex = 4;
            // 
            // cmbOcena
            // 
            this.cmbOcena.FormattingEnabled = true;
            this.cmbOcena.Location = new System.Drawing.Point(161, 118);
            this.cmbOcena.Name = "cmbOcena";
            this.cmbOcena.Size = new System.Drawing.Size(121, 21);
            this.cmbOcena.TabIndex = 5;
            // 
            // Datum
            // 
            this.Datum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Datum.Location = new System.Drawing.Point(415, 119);
            this.Datum.Name = "Datum";
            this.Datum.Size = new System.Drawing.Size(121, 20);
            this.Datum.TabIndex = 6;
            // 
            // tbId
            // 
            this.tbId.Enabled = false;
            this.tbId.Location = new System.Drawing.Point(288, 118);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(121, 20);
            this.tbId.TabIndex = 7;
            // 
            // BtInsert
            // 
            this.BtInsert.Location = new System.Drawing.Point(571, 57);
            this.BtInsert.Name = "BtInsert";
            this.BtInsert.Size = new System.Drawing.Size(75, 23);
            this.BtInsert.TabIndex = 8;
            this.BtInsert.Text = "Dodaj";
            this.BtInsert.UseVisualStyleBackColor = true;
            this.BtInsert.Click += new System.EventHandler(this.BtInsert_Click);
            // 
            // BtUpdate
            // 
            this.BtUpdate.Location = new System.Drawing.Point(571, 86);
            this.BtUpdate.Name = "BtUpdate";
            this.BtUpdate.Size = new System.Drawing.Size(75, 23);
            this.BtUpdate.TabIndex = 9;
            this.BtUpdate.Text = "Izmeni";
            this.BtUpdate.UseVisualStyleBackColor = true;
            this.BtUpdate.Click += new System.EventHandler(this.BtUpdate_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(571, 115);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(75, 23);
            this.btDelete.TabIndex = 10;
            this.btDelete.Text = "Brisi";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // DTGocene
            // 
            this.DTGocene.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGocene.Location = new System.Drawing.Point(34, 215);
            this.DTGocene.Name = "DTGocene";
            this.DTGocene.Size = new System.Drawing.Size(502, 164);
            this.DTGocene.TabIndex = 11;
            this.DTGocene.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DTGocene_CellClick);
            // 
            // lbGodina
            // 
            this.lbGodina.AutoSize = true;
            this.lbGodina.Location = new System.Drawing.Point(31, 32);
            this.lbGodina.Name = "lbGodina";
            this.lbGodina.Size = new System.Drawing.Size(41, 13);
            this.lbGodina.TabIndex = 12;
            this.lbGodina.Text = "Godina";
            // 
            // lbProfesor
            // 
            this.lbProfesor.AutoSize = true;
            this.lbProfesor.Location = new System.Drawing.Point(158, 32);
            this.lbProfesor.Name = "lbProfesor";
            this.lbProfesor.Size = new System.Drawing.Size(46, 13);
            this.lbProfesor.TabIndex = 13;
            this.lbProfesor.Text = "Profesor";
            // 
            // LbPRedmet
            // 
            this.LbPRedmet.AutoSize = true;
            this.LbPRedmet.Location = new System.Drawing.Point(285, 32);
            this.LbPRedmet.Name = "LbPRedmet";
            this.LbPRedmet.Size = new System.Drawing.Size(46, 13);
            this.LbPRedmet.TabIndex = 14;
            this.LbPRedmet.Text = "Predmet";
            // 
            // lbOdeljenje
            // 
            this.lbOdeljenje.AutoSize = true;
            this.lbOdeljenje.Location = new System.Drawing.Point(412, 32);
            this.lbOdeljenje.Name = "lbOdeljenje";
            this.lbOdeljenje.Size = new System.Drawing.Size(51, 13);
            this.lbOdeljenje.TabIndex = 15;
            this.lbOdeljenje.Text = "Odeljenje";
            // 
            // LbUcenik
            // 
            this.LbUcenik.AutoSize = true;
            this.LbUcenik.Location = new System.Drawing.Point(31, 93);
            this.LbUcenik.Name = "LbUcenik";
            this.LbUcenik.Size = new System.Drawing.Size(41, 13);
            this.LbUcenik.TabIndex = 16;
            this.LbUcenik.Text = "Ucenik";
            // 
            // lbOcena
            // 
            this.lbOcena.AutoSize = true;
            this.lbOcena.Location = new System.Drawing.Point(158, 93);
            this.lbOcena.Name = "lbOcena";
            this.lbOcena.Size = new System.Drawing.Size(39, 13);
            this.lbOcena.TabIndex = 17;
            this.lbOcena.Text = "Ocena";
            // 
            // LbID
            // 
            this.LbID.AutoSize = true;
            this.LbID.Location = new System.Drawing.Point(285, 93);
            this.LbID.Name = "LbID";
            this.LbID.Size = new System.Drawing.Size(53, 13);
            this.LbID.TabIndex = 18;
            this.LbID.Text = "ID Ocene";
            // 
            // LbDatum
            // 
            this.LbDatum.AutoSize = true;
            this.LbDatum.Location = new System.Drawing.Point(412, 93);
            this.LbDatum.Name = "LbDatum";
            this.LbDatum.Size = new System.Drawing.Size(38, 13);
            this.LbDatum.TabIndex = 19;
            this.LbDatum.Text = "Datum";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(34, 171);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(502, 20);
            this.textBox2.TabIndex = 20;
            // 
            // Ocena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.LbDatum);
            this.Controls.Add(this.LbID);
            this.Controls.Add(this.lbOcena);
            this.Controls.Add(this.LbUcenik);
            this.Controls.Add(this.lbOdeljenje);
            this.Controls.Add(this.LbPRedmet);
            this.Controls.Add(this.lbProfesor);
            this.Controls.Add(this.lbGodina);
            this.Controls.Add(this.DTGocene);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.BtUpdate);
            this.Controls.Add(this.BtInsert);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.Datum);
            this.Controls.Add(this.cmbOcena);
            this.Controls.Add(this.cmbUcenikl);
            this.Controls.Add(this.cmbOdeljenje);
            this.Controls.Add(this.cmbPredmet);
            this.Controls.Add(this.cmbProfesor);
            this.Controls.Add(this.cmbGodina);
            this.Name = "Ocena";
            this.Text = "Ocena";
            this.Load += new System.EventHandler(this.Ocena_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DTGocene)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbGodina;
        private System.Windows.Forms.ComboBox cmbProfesor;
        private System.Windows.Forms.ComboBox cmbPredmet;
        private System.Windows.Forms.ComboBox cmbOdeljenje;
        private System.Windows.Forms.ComboBox cmbUcenikl;
        private System.Windows.Forms.ComboBox cmbOcena;
        private System.Windows.Forms.DateTimePicker Datum;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Button BtInsert;
        private System.Windows.Forms.Button BtUpdate;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.DataGridView DTGocene;
        private System.Windows.Forms.Label lbGodina;
        private System.Windows.Forms.Label lbProfesor;
        private System.Windows.Forms.Label LbPRedmet;
        private System.Windows.Forms.Label lbOdeljenje;
        private System.Windows.Forms.Label LbUcenik;
        private System.Windows.Forms.Label lbOcena;
        private System.Windows.Forms.Label LbID;
        private System.Windows.Forms.Label LbDatum;
        private System.Windows.Forms.TextBox textBox2;
    }
}