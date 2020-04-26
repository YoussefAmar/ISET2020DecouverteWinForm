using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISET_2020_Découverte_WinForm
{
    public partial class Ecranpropos : Form
    {
        EcranPrincipal fenPapa;
        public Ecranpropos(EcranPrincipal fen)
        {
            InitializeComponent();
            fenPapa = fen;
        }

        private void btnConfirmer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
