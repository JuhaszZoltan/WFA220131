using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA220131
{
    public partial class FrmSzerzo : Form
    {
        public FrmSzerzo()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.author;
        }

        private void TsmiKereses_Click(object sender, EventArgs e)
            => new FrmSzerzoLista(this).ShowDialog();

        private void tbID_TextChanged(object sender, EventArgs e)
        { }
    }
}
