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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtpass.Text == "")
            {
                MessageBox.Show("Unesite Email i Lozinku");
                return;
            }
            else
            {
                try
                {
                    SqlConnection veza = Konekcija.Connect();
                    SqlCommand komanda = new SqlCommand("Select * from osoba where email=@username", veza);
                    komanda.Parameters.AddWithValue("@username", txtName.Text);
                    SqlDataAdapter adapter = new SqlDataAdapter(komanda);
                    DataTable tabela = new DataTable();
                    adapter.Fill(tabela);
                    int brojac = tabela.Rows.Count;
                    if (brojac == 1)
                    {
                        if (String.Compare(tabela.Rows[0]["pass"].ToString(), txtpass.Text) == 0)
                        {
                            MessageBox.Show("Uspesno logovanje!");
                            Program.user_ime = tabela.Rows[0]["ime"].ToString();
                            Program.user_prezime = tabela.Rows[0]["prezime"].ToString();
                            Program.user_uloga = (int)tabela.Rows[0]["uloga"];
                            this.Hide();
                            Glavni_meni formGlava = new Glavni_meni();
                            formGlava.Show();
                        }
                        else
                        {
                            MessageBox.Show("Uneli ste pogresnu lozinku!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nepostojeci email!!");
                    }
                }
                catch(Exception Greska)
                {
                    MessageBox.Show(Greska.Message); 
                }
            }
        }
    }
}
