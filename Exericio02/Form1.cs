using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exericio02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ckAlteraCor.Checked)
            {
                if (lbRotulo.BackColor == Color.Red) {
                    lbRotulo.BackColor = Color.Blue;
                } else
                {
                    lbRotulo.BackColor = Color.Red;
                }
            } else
            {
                MessageBox.Show("A caixa não \nestá marcada.");
            }
        }
    }
}
