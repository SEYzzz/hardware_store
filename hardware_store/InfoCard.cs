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
    public partial class InfoCard : Form
    {
        ProductCard product { get; set; }
        public InfoCard()
        {
            InitializeComponent();
        }
        public InfoCard(ProductCard product)
        {
            InitializeComponent();
            this.product = product;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChangeCreateForm changeForm = new ChangeCreateForm(this);
            changeForm.Show();
        }

        private void InfoCard_Load(object sender, EventArgs e)
        {
            lblName.Text += " " + product.name.Text;
            pictureBox1.Image = product.pic.Image;
        }
    }
}
