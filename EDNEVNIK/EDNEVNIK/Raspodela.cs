using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EDNEVNIK
{
    public partial class Raspodela : Form
    {
        DataTable raspodela;
        int brojSloga = 0;
        public Raspodela()
        {
            InitializeComponent();
        }
        private void ComboFill()
        {
            SqlConnection veza = Konekcija.Connect();
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from raspodela", veza);
            DataTable dt_godina, dt_nastavnik, dt_predmet, dt_odeljenje;

            adapter = new SqlDataAdapter("Select * from skolska_godina", veza);
            dt_godina = new DataTable();
            adapter.Fill(dt_godina);

            dt_nastavnik = new DataTable();
            adapter = new SqlDataAdapter("Select id, ime + prezime as naziv from osoba Where uloga =2", veza);
            adapter.Fill(dt_nastavnik);

            dt_predmet = new DataTable();
            adapter = new SqlDataAdapter("Select id, naziv from predmet", veza);
            adapter.Fill(dt_predmet);

            dt_odeljenje = new DataTable();
            adapter = new SqlDataAdapter("Select id, str(razred) + '-' + indeks as naziv from odeljenje  ", veza);
            adapter.Fill(dt_odeljenje);

            cmbGodina.DataSource = dt_godina;
            cmbGodina.ValueMember = "id";
            cmbGodina.DisplayMember = "naziv";
            

            cmbNastavnik.DataSource = dt_nastavnik;
            cmbNastavnik.ValueMember = "id";
            cmbNastavnik.DisplayMember = "naziv";
            

            cmbPredmet.DataSource = dt_predmet;
            cmbPredmet.ValueMember = "id";
            cmbPredmet.DisplayMember = "naziv";
            

            cmbOdeljenje.DataSource = dt_odeljenje;
            cmbOdeljenje.ValueMember = "id";
            cmbOdeljenje.DisplayMember = "naziv";
           

            txtID.Text = raspodela.Rows[brojSloga]["id"].ToString();

            if (raspodela.Rows.Count == 0)
            {
                cmbGodina.SelectedValue = -1;
                cmbNastavnik.SelectedValue = -1;
                cmbPredmet.SelectedValue = -1;
                cmbOdeljenje.SelectedValue = -1;
            }
            else
            {
                cmbGodina.SelectedValue = raspodela.Rows[brojSloga]["godina_id"];
                cmbNastavnik.SelectedValue = raspodela.Rows[brojSloga]["nastavnik_id"];
                cmbPredmet.SelectedValue = raspodela.Rows[brojSloga]["predmet_id"];
                cmbOdeljenje.SelectedValue = raspodela.Rows[brojSloga]["odeljenje_id"];
            }
            if (brojSloga == 0)
            {
                btFirst.Enabled = false;
                btPrev.Enabled = false;
            }
            else
            {
                btFirst.Enabled = true;
                btPrev.Enabled = true;
            }
            if (brojSloga == raspodela.Rows.Count - 1)
            {
                btLast.Enabled = false;
                btNext.Enabled = false;
            }
            else
            {
                btLast.Enabled = true;
                btNext.Enabled = true;
            }

        }
        private void Load_Data()
        {
            SqlConnection veza = Konekcija.Connect();
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from raspodela", veza);
            raspodela = new DataTable();
            adapter.Fill(raspodela);
        }
            
        private void Raspodela_Load(object sender, EventArgs e)
        {
            Load_Data();
            ComboFill();
        }

        private void btFirst_Click(object sender, EventArgs e)
        {
            brojSloga = 0;
            ComboFill();
        }

        private void btPrev_Click(object sender, EventArgs e)
        {
            brojSloga--;
            ComboFill();
        }

        private void btNext_Click(object sender, EventArgs e)
        {
            brojSloga++;
            ComboFill();
        }

        private void btLast_Click(object sender, EventArgs e)
        {
            brojSloga = raspodela.Rows.Count - 1;
            ComboFill();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            string Naredba = "Delete from raspodela where id = " + txtID.Text;

            SqlConnection veza = Konekcija.Connect();
            SqlCommand Komanda = new SqlCommand(Naredba, veza);
            Boolean brisano = false;
            try
            {
                veza.Open();
                Komanda.ExecuteNonQuery();
                veza.Close();
                brisano = true;
            }
            catch (Exception Greska)
            {
                MessageBox.Show(Greska.Message);
            }
            if (brisano)
            {
                ComboFill();
                if (brojSloga > 0) brojSloga--;
                Load_Data();
            }
        }

        private void btadd_Click(object sender, EventArgs e)
        {
            StringBuilder Naredba = new StringBuilder("INSERT INTO raspodela (godina_id, nastavnik_id, predmet_id, odeljenje_id) VALUES ('");
            Naredba.Append(cmbGodina.SelectedValue + "', '");
            Naredba.Append(cmbNastavnik.SelectedValue + "', '");
            Naredba.Append(cmbPredmet.SelectedValue + "', '");
            Naredba.Append(cmbOdeljenje.SelectedValue + "' )");

            SqlConnection veza = Konekcija.Connect();
            SqlCommand Komanda = new SqlCommand(Naredba.ToString(), veza);
            try
            {
                veza.Open();
                Komanda.ExecuteNonQuery();
                veza.Close();
            }
            catch (Exception Greska)
            {
                MessageBox.Show(Greska.Message);
            }
            Load_Data();
            brojSloga = raspodela.Rows.Count - 1;
            ComboFill();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            StringBuilder Naredba = new StringBuilder("Update raspodela set ");
            Naredba.Append("godina_id = '" + cmbGodina.SelectedValue + "',");
            Naredba.Append("nastavnik_id = '" + cmbNastavnik.SelectedValue + "',");
            Naredba.Append("predmet_id = '" + cmbPredmet.SelectedValue + "',");
            Naredba.Append("odeljenje_id = '" + cmbOdeljenje.SelectedValue + "'");
            Naredba.Append("Where id = " + txtID.Text);

            SqlConnection veza = Konekcija.Connect();
            SqlCommand Komanda = new SqlCommand(Naredba.ToString(), veza);
            try
            {
                veza.Open();
                Komanda.ExecuteNonQuery();
                veza.Close();
            }
            catch (Exception Greska)
            {
                MessageBox.Show(Greska.Message);
            }
            Load_Data();
            ComboFill();
        }
    }
}
