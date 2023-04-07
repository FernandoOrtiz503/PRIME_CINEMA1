using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prime_cinema
{
    public partial class publi : Form
    {
        public publi()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnbuscanom_Click(object sender, EventArgs e)
        {
            abrirform(new busnom());
        }
        private void abrirform(object formabrir)
        {
            if (this.panelprin.Controls.Count > 0)
                this.panelprin.Controls.RemoveAt(0);
            Form fh = formabrir as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelprin.Controls.Add(fh);
            this.panelprin.Tag = fh;
            fh.Show();
        }

        private void btnmostcart_Click(object sender, EventArgs e)
        {
            abrirform(new mostcart());
        }

        private void btnbussucu_Click(object sender, EventArgs e)
        {
            abrirform(new buscarsucur());
        }
    }
}
