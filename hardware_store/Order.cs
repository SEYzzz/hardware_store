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
    public partial class Order : Form
    {
        ProductCard product { get; set; }

        public Order()
        {
            InitializeComponent();
        }
        public Order(ProductCard product)
        {
            InitializeComponent();
            this.product = product;
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Order_Load(object sender, EventArgs e)
        {
            lblName.Text += " " + product.name.Text;
            picBox.Image = product.pic.Image;
        }

        private void btnToOrder_Click(object sender, EventArgs e)
        {
            if((txtBoxCount.TextLength != 0) && txtBoxCount.Text.Any(Char.IsDigit) && (!txtBoxCount.Text.Any(Char.IsLetter)) && (!txtBoxCount.Text.Any(Char.IsWhiteSpace)))
            {

            }
        }
    }
}
