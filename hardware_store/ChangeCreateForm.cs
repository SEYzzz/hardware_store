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
        public bool IsFromMain = true; 
        List<ProductCard> productCards { get; set; }
        ProductCard product { get; set; }
        private List<OrderCard> orders;
        public ChangeCreateForm(List<ProductCard> cards, List<OrderCard> orders)
        {
            InitializeComponent();
            productCards = cards;
            this.orders = orders;
        }
        public ChangeCreateForm(List<ProductCard> cards, int num) //номер карточки, которую надо заменить
        {
            InitializeComponent();
            productCards = cards;
        }
        public ChangeCreateForm(ProductCard product, List<OrderCard> orders)
        {
            InitializeComponent();
            this.product = product;
            this.orders = orders;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Добавление и изменение карточки товара
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsFromMain)
            {
                if (txtBoxName.Text.Any(Char.IsLetter) && txtBoxPrice.Text.Any(Char.IsDigit) &&
                txtBoxSale.Text.Any(Char.IsDigit) && txtBoxDescrp.Text.Any(Char.IsLetter))
                {
                    string name = txtBoxName.Text;
                    string descr = txtBoxDescrp.Text;
                    int gr_id = 1;
                    Image image = pctBox.Image;
                    int price = Convert.ToInt32(txtBoxSale.Text);
                    int sale = Convert.ToInt32(txtBoxPrice.Text);
                    int in_stock = 1;
                    int rest = 0;
                    productCards.Add(new ProductCard(name, descr, gr_id, image, price, sale, in_stock, rest));
                    productCards.Last().orderCards = orders;
                    Close();
                }
                else
                {
                    MessageBox.Show("Пожалуйста, введите адекватные значения в поля", "Ошибка");
                }
            }
            else
            {
                if (txtBoxName.Text.Any(Char.IsLetter) || txtBoxPrice.Text.All(Char.IsDigit) ||
                txtBoxSale.Text.All(Char.IsDigit) || txtBoxDescrp.Text.Any(Char.IsLetter))
                {
                    product.name.Text = txtBoxName.Text;
                    product.pic.Image = pctBox.Image;
                    product.sale = Convert.ToInt32(txtBoxPrice.Text);
                    product.purch_price = Convert.ToInt32(txtBoxSale.Text);
                    product.description = txtBoxDescrp.Text;
                    Close();
                }
                else
                {
                    MessageBox.Show("Пожалуйста, введите адекватные значения в поля", "Ошибка");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "png|*.png| jpg|*.jpg";
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pctBox.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void ChangeCreateForm_Load(object sender, EventArgs e)
        {
            if (!IsFromMain)
            {
                pctBox.Image = product.pic.Image;
                txtBoxName.Text = product.name.Text;
                if(product.purch_price != 0 && product.sale != 0)
                {
                    txtBoxPrice.Text = Convert.ToString(product.sale);
                    txtBoxSale.Text = Convert.ToString(product.purch_price);
                    txtBoxGroup.Text = Convert.ToString(product.group_id);
                    txtBoxDescrp.Text = product.description;
                }
            }
        }
    }
}
