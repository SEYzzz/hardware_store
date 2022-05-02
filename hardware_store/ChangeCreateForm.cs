using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hardware_store
{
    public partial class ChangeCreateForm : Form
    {
        public ChangeCreateForm()
        {
            InitializeComponent();
        }
        public ChangeCreateForm(InfoCard card)
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "png|*.png| jpg|*.jpg| bmp|*.bmp";
            openFileDialog1.ShowDialog();
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pctBox.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }
    }
}
