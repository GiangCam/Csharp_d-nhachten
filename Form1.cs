using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_dánhachten
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            lbsKQ.Items.Add(txtten.Text);
            txtten.Text = string.Empty;
        }

        private void txtten_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtten.Text = "Nguyễn Thị Tuyết \tNgân";
           
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            lbsKQ.Items.RemoveAt(lbsKQ.SelectedIndex);
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (lbsKQ.SelectedIndex < 0) return;
            lbsKQ.Items[lbsKQ.SelectedIndex] = txtten.Text;
        }
    }
}
