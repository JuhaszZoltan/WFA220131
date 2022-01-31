using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA220131
{
    public partial class FrmSzerzoLista : Form
    {
        private FrmSzerzo FrmSzerzo { get; set; } = null;
        public FrmSzerzoLista(FrmSzerzo frmSzerzo)
        {
            FrmSzerzo = frmSzerzo;
            InitializeComponent();
            this.Icon = Properties.Resources.author;
        }

        private void FrmSzerzoLista_Load(object sender, EventArgs e)
            => Szures();
        private void TbSzures_TextChanged(object sender, EventArgs e)
            => Szures();

        private void Szures()
        {
            dgvSzerzoLista.Rows.Clear();
            using (var conn = new SqlConnection(Program.ConnectionString))
            {
                conn.Open();
                var reader = new SqlCommand(
                    "SELECT * FROM szerzo " +
                    $"WHERE nev LIKE '{tbSzures.Text}%';",
                    conn).ExecuteReader();
                while (reader.Read())
                {
                    dgvSzerzoLista.Rows.Add(reader[0], reader[1]);
                }
            }
        }

        private void DgvSzerzoLista_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            FrmSzerzo.tbID.Text = dgvSzerzoLista[0, e.RowIndex].Value.ToString();
            FrmSzerzo.tbNev.Text = dgvSzerzoLista[1, e.RowIndex].Value.ToString();
            this.Close();
        }
    }
}
