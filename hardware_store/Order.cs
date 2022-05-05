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
        public int count { get; private set; }
        private List<OrderCard> cards { get; set; }

        public Order()
        {
            InitializeComponent();
        }
        public Order(ProductCard product, List<OrderCard> cards)
        {
            InitializeComponent();
            this.product = product;
            this.cards = cards;
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Order_Load(object sender, EventArgs e)
        {
            lblName.Text += " " + product.name.Text;
            picBox.Image = product.pic.Image;
            lblCostSale.Text += " " + product.sale;
            lblPrice.Text += " " + product.purch_price;
            lblRest.Text = product.rest + "/" + product.in_stock;
        }

        private void btnToOrder_Click(object sender, EventArgs e)
        {
            if(txtBoxCount.Text.All(Char.IsDigit))
            {
                cards.Add(new OrderCard(product, Convert.ToInt32(txtBoxCount.Text)));
                //cards.Last().ToAccept.Click += 
                Close();
            }
            else
            {
                MessageBox.Show("Введите корректные данные", "Ошибка");
            }
        }
    }
}
