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
            Close();
            ChangeCreateForm changeForm = new ChangeCreateForm(product, product.orderCards);
            changeForm.IsFromMain = false;
            changeForm.ShowDialog();
        }

        private void InfoCard_Load(object sender, EventArgs e)
        {
            lblGroup.Text += " " + Convert.ToString(product.group_id);
            lblName.Text += " " + product.name.Text;
            pictureBox1.Image = product.pic.Image;
            lblRest.Text = product.rest + "/" + product.in_stock;
            lblPrice.Text += " " + Convert.ToString(product.sale);
            lblCostSale.Text += " " + Convert.ToString(product.purch_price);
            richTextBox1.Text = product.description;
        }
    }
}
