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
    public partial class Ocena : Form
    {
        DataTable dt_Ocena;
        public Ocena()
        {
            InitializeComponent();
        }

        private void Ocena_Load(object sender, EventArgs e)
        {
            cmb_GodinaPopulate();
            cmbPredmet.Enabled = false;
            cmbOdeljenje.Enabled = false;
            cmbUcenikl.Enabled = false;
            cmbOcena.Items.Add(1);
            cmbOcena.Items.Add(2);
            cmbOcena.Items.Add(3);
            cmbOcena.Items.Add(4);
            cmbOcena.Items.Add(5);
            //cmbOcena.Enabled = false;
            cmb_ProfesorPopulate();
        }

        private void cmb_GodinaPopulate()
        {
            SqlConnection veza = Konekcija.Connect();
            SqlDataAdapter adapter = new SqlDataAdapter("Select * From skolska_godina", veza);
            DataTable dt_godina = new DataTable();
            adapter.Fill(dt_godina);
            cmbGodina.DataSource = dt_godina;
            cmbGodina.ValueMember = "id";
            cmbGodina.DisplayMember = "naziv";
            cmbGodina.SelectedValue = 2;

        }

        private void cmbGodina_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbGodina.IsHandleCreated && cmbGodina.Focused)
            {
                cmb_ProfesorPopulate();
            }
        }

        private void cmb_ProfesorPopulate()
        {
            
            StringBuilder naredba = new StringBuilder("Select DISTINCT osoba.id AS id, ime+' ' + prezime AS naziv From osoba ");
            naredba.Append("JOIN raspodela ON osoba.id = nastavnik_id ");
            naredba.Append("WHERE godina_id = " + cmbGodina.SelectedValue.ToString());
           // textBox2.Text = naredba.ToString();
            SqlConnection veza = Konekcija.Connect();
            SqlDataAdapter adapter = new SqlDataAdapter(naredba.ToString(), veza);
            DataTable dt_Profesor = new DataTable();
            adapter.Fill(dt_Profesor);
            cmbProfesor.DataSource = dt_Profesor;
            cmbProfesor.ValueMember = "id";
            cmbProfesor.DisplayMember = "naziv";
            cmbProfesor.SelectedIndex = -1;
        }

        private void cmbProfesor_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbProfesor.IsHandleCreated && cmbProfesor.Focused)
            {
                cmb_PredmetPopulate();
                cmbPredmet.Enabled = true;

                cmbOdeljenje.SelectedIndex = -1;
                cmbOdeljenje.Enabled = false;

                cmbUcenikl.SelectedIndex = -1;
                cmbUcenikl.Enabled = false;

                cmbOcena.SelectedIndex = -1;
                cmbOcena.Enabled = false;

                dt_Ocena = new DataTable();
                DTGocene.DataSource = dt_Ocena;
            }
        }

        private void cmb_PredmetPopulate()
        {

            
            StringBuilder naredba = new StringBuilder("Select Distinct predmet.id as id, naziv From predmet ");
            naredba.Append(" JOIN raspodela ON predmet.id = predmet_id ");
            naredba.Append(" Where godina_id = " + cmbGodina.SelectedValue.ToString());
            naredba.Append(" AND nastavnik_id = " + cmbProfesor.SelectedValue.ToString());
            //textBox2.Text = naredba.ToString();
            SqlConnection veza = Konekcija.Connect();
            SqlDataAdapter adapter = new SqlDataAdapter(naredba.ToString(), veza);
            DataTable dt_Predmet = new DataTable();
            adapter.Fill(dt_Predmet);
            cmbPredmet.DataSource = dt_Predmet;
            cmbPredmet.ValueMember = "id";
            cmbPredmet.DisplayMember = "naziv";
            cmbPredmet.SelectedIndex = -1;

        }

        private void cmbPredmet_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbPredmet.IsHandleCreated && cmbPredmet.Focused)
            {
                cmb_OdeljenjePopulate();
                cmbOdeljenje.Enabled = true;
                cmbOdeljenje.SelectedIndex = -1;

                cmbUcenikl.SelectedIndex = -1;
                cmbUcenikl.Enabled = false;

                cmbOcena.SelectedIndex = -1;
                cmbOcena.Enabled = false;

                dt_Ocena = new DataTable();
                DTGocene.DataSource = dt_Ocena;
            }
        }
        private void cmb_OdeljenjePopulate()
        {
            StringBuilder naredba = new StringBuilder("Select Distinct odeljenje.id as id, STR(razred) + '-' + indeks AS naziv FROM odeljenje ");
            naredba.Append("JOIN raspodela ON odeljenje.id = odeljenje_id ");
            naredba.Append(" WHERE raspodela.godina_id = " + cmbGodina.SelectedValue.ToString());
            naredba.Append(" AND nastavnik_id = " + cmbProfesor.SelectedValue.ToString());
            naredba.Append(" AND predmet_id = " + cmbPredmet.SelectedValue.ToString());
           // textBox2.Text = naredba.ToString();
            SqlConnection veza = Konekcija.Connect();
            SqlDataAdapter adapter = new SqlDataAdapter(naredba.ToString(), veza);
            DataTable dt_odeljnje = new DataTable();
            adapter.Fill(dt_odeljnje);
            cmbOdeljenje.DataSource = dt_odeljnje;
            cmbOdeljenje.ValueMember = "id";
            cmbOdeljenje.DisplayMember = "naziv";
            

        }
        
         private void cmbOdeljenje_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbOdeljenje.IsHandleCreated && cmbOdeljenje.Focused)
            {
                cmb_UcenikPopulate();
                cmbUcenikl.Enabled = true;
                cmbOcena.Enabled = true;
                GridPopulate();
                UcenikOcenaIdSet(0);


            }
            
       }

        private void cmb_UcenikPopulate()
        {
            StringBuilder naredba = new StringBuilder("Select osoba.id as id, ime + ' ' + prezime as naziv from osoba ");
           naredba.Append(" JOIN upisnica ON osoba.id = osoba_id ");
         naredba.Append(" Where upisnica.odeljenje_id = " + cmbOdeljenje.SelectedValue.ToString());
            //textBox2.Text = naredba.ToString();
            SqlConnection veza = Konekcija.Connect();
            SqlDataAdapter adapder = new SqlDataAdapter(naredba.ToString(), veza);
            DataTable dt_ucenik = new DataTable();
            adapder.Fill(dt_ucenik);
            cmbUcenikl.DataSource = dt_ucenik;
           cmbUcenikl.ValueMember = "id";
           cmbUcenikl.DisplayMember = "naziv";
           cmbUcenikl.SelectedIndex = -1;

        }
        private void GridPopulate()
        {
            StringBuilder naredba = new StringBuilder("Select ocena.id as id, ime + ' ' + prezime as naziv, ocena, ucenik_id, datum FROM osoba ");
            naredba.Append(" JOIN ocena ON osoba.id = ucenik_id ");
            naredba.Append(" JOIN raspodela ON raspodela_id = raspodela.id ");
            naredba.Append(" WHERE raspodela_id = (" );
            naredba.Append(" Select id from raspodela ");
            naredba.Append(" Where godina_id = " + cmbGodina.SelectedValue.ToString());
            naredba.Append(" AND nastavnik_id = " + cmbProfesor.SelectedValue.ToString());
            naredba.Append(" And predmet_id = " + cmbPredmet.SelectedValue.ToString());
            naredba.Append(" And odeljenje_id = " + cmbOdeljenje.SelectedValue.ToString() + ")");
            // textBox2.Text = naredba.ToString();
            SqlConnection veza = Konekcija.Connect();
            SqlDataAdapter adapder = new SqlDataAdapter(naredba.ToString(), veza);
            dt_Ocena = new DataTable();
            adapder.Fill(dt_Ocena);
            DTGocene.DataSource = dt_Ocena;
            DTGocene.AllowUserToAddRows = false;
            DTGocene.Columns["ucenik_id"].Visible = false;

        }

        private void DTGocene_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                UcenikOcenaIdSet(e.RowIndex);
            }
        }

        private void UcenikOcenaIdSet( int broj_sloga)
        {
            cmbUcenikl.SelectedValue = dt_Ocena.Rows[broj_sloga]["ucenik_id"];
            cmbOcena.SelectedItem = dt_Ocena.Rows[broj_sloga]["ocena"];
            tbId.Text = dt_Ocena.Rows[broj_sloga]["id"].ToString();
        }

        private void BtInsert_Click(object sender, EventArgs e)
        {
            StringBuilder naredba = new StringBuilder("Select id from raspodela");
            naredba.Append(" Where godina_id = " + cmbGodina.SelectedValue.ToString());
            naredba.Append(" AND nastavnik_id = " + cmbProfesor.SelectedValue.ToString());
            naredba.Append(" AND predmet_id " + cmbPredmet.SelectedValue.ToString());
            naredba.Append(" AND odeljenje_id " + cmbOdeljenje.SelectedValue.ToString());
            SqlConnection veza = Konekcija.Connect();
            SqlCommand Komanda = new SqlCommand(naredba.ToString(), veza);
            int id_raspodele = 0;

            try
            {
                veza.Open();
                id_raspodele = (int)Komanda.ExecuteScalar();
                veza.Close();
            }
            catch(Exception Greska)
            {
                MessageBox.Show(Greska.Message);   
            }

            if (id_raspodele > 0)
            {
                naredba = new StringBuilder(" Insert into ocena (datum, raspodela_id, ucenik_id, ocena) Values('");
                DateTime datum = Datum.Value;
                naredba.Append(datum.ToString("yyyy-MM-dd") + "', '");
                naredba.Append(id_raspodele.ToString() + "', '");
                naredba.Append(cmbUcenikl.SelectedValue.ToString() + "', '");
                naredba.Append(cmbOcena.SelectedItem.ToString() + "') ");
                Komanda = new SqlCommand(naredba.ToString(), veza );
                try
                {
                    veza.Open();
                    Komanda.ExecuteNonQuery();
                    veza.Close();
                }
                catch(Exception Greska)
                {
                    MessageBox.Show(Greska.Message);
                    
                }

            }
            GridPopulate();

        }

        private void BtUpdate_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(tbId.Text) > 0)
            {
                DateTime datum = Datum.Value;
                StringBuilder naredba = new StringBuilder("Update ocena SET ");
                naredba.Append(" ucenik_id = '" + cmbUcenikl.SelectedValue.ToString() + "', ");
                naredba.Append("ocena = '" + cmbOcena.SelectedItem.ToString() + "', ");
                naredba.Append(" datum = '" + datum.ToString("yyyy-MM-dd") + "' ");
                naredba.Append(" Where id = " + tbId.Text);
                SqlConnection veza = Konekcija.Connect();
                SqlCommand Komanda = new SqlCommand(naredba.ToString(), veza);
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
            }
            GridPopulate();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(tbId.Text) > 0)
            {
                string naredba = "DELETE FROM ocena WHERE id = " + tbId.Text;
                SqlConnection veza = Konekcija.Connect();
                SqlCommand Komanda = new SqlCommand(naredba, veza);
                try
                {
                    veza.Open();
                    Komanda.ExecuteNonQuery();
                    veza.Close();
                    GridPopulate();
                    UcenikOcenaIdSet(0);
                }
                catch (Exception Greska)
                {
                    MessageBox.Show(Greska.Message);

                }
            }
        }
    }

}
