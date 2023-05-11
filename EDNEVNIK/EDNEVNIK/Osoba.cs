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
    public partial class Osoba : Form
    {
        int brojsloga = 0;
        DataTable tabela;

        public Osoba()
        {
            InitializeComponent();
        }
        // metoda za ucitavanje podataka
        private void Load_Data()
        {
            SqlConnection veza = Konekcija.Connect();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM osoba", veza);
            tabela = new DataTable();
            adapter.Fill(tabela);
        }
        //metoda za osvezavanje textboxova
        private void TextBox_Load()
        {
            if (tabela.Rows.Count==-0)
            {
                textBoxId.Text = "";
                textBoxIme.Text = "";
                textBoxPrezime.Text = "";
                textBoxAdesa.Text = "";
                textBoxJMBG.Text = "";
                textBoxEmail.Text = "";
                textBoxLozinka.Text = "";
                textBoxUloga.Text = "";
                buttonDelete.Enabled = false;
            }
            else
            {
                textBoxId.Text = tabela.Rows[brojsloga]["Id"].ToString();
                textBoxIme.Text = tabela.Rows[brojsloga]["Ime"].ToString();
                textBoxPrezime.Text = tabela.Rows[brojsloga]["Prezime"].ToString();
                textBoxAdesa.Text = tabela.Rows[brojsloga]["Adresa"].ToString();
                textBoxJMBG.Text = tabela.Rows[brojsloga]["JMBG"].ToString();
                textBoxEmail.Text = tabela.Rows[brojsloga]["Email"].ToString();
                textBoxLozinka.Text = tabela.Rows[brojsloga]["pass"].ToString();
                textBoxUloga.Text = tabela.Rows[brojsloga]["Uloga"].ToString();
                buttonDelete.Enabled = true;
            }
            if (brojsloga == 0)
            {
                buttonFirst.Enabled = false;
                buttonPrev.Enabled = false;
            }
            else
            {
                buttonFirst.Enabled = true;
                buttonPrev.Enabled = true;
            }
            if (brojsloga == tabela.Rows.Count-1)
            {
                buttonLast.Enabled = false;
                buttonNext.Enabled = false;
            }
            else
            {
                buttonLast.Enabled = true;
                buttonNext.Enabled = true;
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Load_Data();
            TextBox_Load();
        }

        private void buttonFirst_Click(object sender, EventArgs e)
        {
            brojsloga = 0;
            TextBox_Load();
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            brojsloga--;
            TextBox_Load();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            brojsloga++;
            TextBox_Load();
        }

        private void buttonLast_Click(object sender, EventArgs e)
        {
            brojsloga = tabela.Rows.Count - 1;
            TextBox_Load();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            StringBuilder Naredba = new StringBuilder("INSERT INTO osoba (ime, prezime, adresa, jmbg, email, pass, uloga) VALUES ('");
            Naredba.Append(textBoxIme.Text + "', '");
            Naredba.Append(textBoxPrezime.Text + "', '");
            Naredba.Append(textBoxAdesa.Text + "', '");
            Naredba.Append(textBoxJMBG.Text + "', '");
            Naredba.Append(textBoxEmail.Text + "', '");
            Naredba.Append(textBoxLozinka.Text + "', '");
            Naredba.Append(textBoxUloga.Text + "')");

            SqlConnection veza = Konekcija.Connect();
            SqlCommand Komanda = new SqlCommand(Naredba.ToString(), veza);
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
            Load_Data();
            brojsloga = tabela.Rows.Count - 1;
            TextBox_Load();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            // Update osoba Set ime = 'Stefan', prezime = 'Cosic', adresa = 'Radnicka' ,jmbg = '1212457', email = 'coske@gmail.com',
            // pass = '1212', uloga = '1'
            //Where id = 2
            StringBuilder Naredba = new StringBuilder("Update osoba set ");
            Naredba.Append("ime = '" + textBoxIme.Text + "',");
            Naredba.Append("Prezime = '" + textBoxPrezime.Text + "',");
            Naredba.Append("Adresa = '" + textBoxAdesa.Text + "',");
            Naredba.Append("Jmbg = '" + textBoxJMBG.Text + "',");
            Naredba.Append("Email = '" + textBoxEmail.Text + "',");
            Naredba.Append("pass = '" + textBoxLozinka.Text + "',");
            Naredba.Append("Uloga = '" + textBoxUloga.Text + "'");
            Naredba.Append("Where id = " + textBoxId.Text);

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
            TextBox_Load();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string Naredba = "Delete from osoba where id = " + textBoxId.Text;

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
                Load_Data();
                if (brojsloga > 0) brojsloga--;
                TextBox_Load();
            }
          
           
        }
    }
    
}
