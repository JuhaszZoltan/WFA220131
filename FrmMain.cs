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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.konyv;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            lblMaiDatum.Text = DateTime.Now.ToString("yyyy. MMMM dd.");

            using (var conn = new SqlConnection(Program.ConnectionString))
            {
                conn.Open();
                //idezetekSzama
                var reader = new SqlCommand(
                    "SELECT COUNT(idezetID) FROM idezet;",
                    conn).ExecuteReader();
                reader.Read();
                int idezetCount = reader.GetInt32(0);
                lblIdezetekSzama.Text += $"\n{idezetCount}";
                reader.Close();

                //rndIdezet
                reader = new SqlCommand(
                    "SELECT idezetID FROM idezet;",
                    conn).ExecuteReader();

                var idList = new List<int>();
                while (reader.Read())
                {
                    idList.Add(reader.GetInt32(0));
                }
                reader.Close();
                int rndId = idList[Program.RND.Next(idList.Count)];

                reader = new SqlCommand(
                    "SELECT szoveg, nev, cim " +
                    "FROM idezet " +
                    "INNER JOIN forras ON idezet.forrasID = forras.forrasID " +
                    "INNER JOIN szerzo ON forras.szerzoID = szerzo.szerzoID " +
                    $"WHERE idezetID = {rndId};",
                    conn).ExecuteReader();
                reader.Read();
                lblNapIdezete.Text = $"\"{reader[0]}\"\n({reader[1]}: {reader[2]})";
                reader.Close();

                //GBtema
                reader = new SqlCommand(
                    "SELECT megnevezes, COUNT(utalas.idezetID) " +
                    "FROM tema " +
                    "INNER JOIN utalas ON tema.temaID = utalas.temaID " +
                    "GROUP BY megnevezes " +
                    "ORDER BY megnevezes ASC;",
                    conn).ExecuteReader();
                while (reader.Read())
                {
                    dgvTemaSzerint.Rows.Add(reader[0], reader[1]);
                }
                reader.Close();

                //GBszerzo
                reader = new SqlCommand(
                    "SELECT nev, COUNT(idezet.idezetID) " +
                    "FROM szerzo " +
                    "INNER JOIN forras ON szerzo.szerzoID = forras.szerzoID " +
                    "INNER JOIN idezet ON forras.forrasID = idezet.forrasID " +
                    "GROUP BY nev " +
                    "ORDER BY nev ASC;",
                    conn).ExecuteReader();
                while (reader.Read())
                {
                    dgvSzerzoSzerint.Rows.Add(reader[0], reader[1]);
                }
            }
        }

        private void TsmiSzerzo_Click(object sender, EventArgs e)
        {
            new FrmSzerzo().ShowDialog();
        }
    }
}
