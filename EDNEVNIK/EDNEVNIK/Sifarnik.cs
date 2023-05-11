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
    public partial class Sifarnik : Form
    {
        SqlDataAdapter Adapter;
        DataTable tabela;
        string ime_tabele;
        public Sifarnik(string tabela)
        {
            ime_tabele = tabela;
            InitializeComponent();
        }

        private void Sifarnik_Load(object sender, EventArgs e)
        {
            Adapter = new SqlDataAdapter("Select * from " + ime_tabele, Konekcija.Connect());
            tabela = new DataTable();
            Adapter.Fill(tabela);
            dataGridView1.DataSource = tabela;
            dataGridView1.Columns["id"].ReadOnly = true;
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            DataTable Promena = tabela.GetChanges();
            Adapter.UpdateCommand = new SqlCommandBuilder(Adapter).GetUpdateCommand();
            if (Promena != null)
            {
                Adapter.Update(Promena);
                this.Close();
            }
        }
    }
}
