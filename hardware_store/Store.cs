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
    public partial class Store : Form
    {
        bool btnDelete_isClicked = false;
        bool btnGroup_isClicked = false;

        private int Hight = 4;
        private int Wigth = 2;
        private int FirstProductCard = 0;

        List<OrderCard> orderCards = new List<OrderCard>();
        List<ProductCard> productCards = new List<ProductCard>();
        List<ProductCard> products_panel = new List<ProductCard>();

        public Store()
        {
            InitializeComponent();
            Bl();
        }

        //вывод;
        public void Bl()
        {
            for (int i = 0; i < 100; i++)
            {
                productCards.Add(new ProductCard());
                productCards.Last().name.Text = "Name" + i;
            }
            ProductCardsToPanel();

        }
        private void ProductCardsToPanel()
        {
            int X = Wigth;
            int Y = Hight;
            for (int y = 0; y < Y; y++)
            {
                for (int x = 0; x < X; x++)
                {
                    if((x + y * X + FirstProductCard) < productCards.Count)
                    {
                        productCards[x + y * X + FirstProductCard].panel.Location = new Point(10 + x * 195, 10 + y * 250);
                        panel1.Controls.Add(productCards[x + y * X + FirstProductCard].GetProductCard());
                        products_panel.Add(productCards[x + y * X + FirstProductCard]);
                    }
                }
            }
        }

        private void panelLeftStat_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.panelLeftStat.ClientRectangle, Color.FromArgb(92, 136, 137), ButtonBorderStyle.Solid);
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.panel2.ClientRectangle, Color.FromArgb(92, 136, 137), ButtonBorderStyle.Solid);
        }

        private void Store_Resize(object sender, EventArgs e)
        {
            //метод для перерисовки панелей в панели;

            //панель товаров;


            //панель заказ товаров;


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!btnDelete_isClicked)
            {
                ChangeCreateForm createForm = new ChangeCreateForm();
                createForm.ShowDialog();
            }
            else
            {
                btnAdd.Text = "+";
                btnDelete.Text = "-";
                foreach (ProductCard card in productCards)
                {
                    card.ToOrder.Text = "Заказать";
                    card.ToOrder.ForeColor = Color.White;
                }

                btnDelete_isClicked = false;

            }

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!btnDelete_isClicked)
            {
                Button button = sender as Button;
                btnDelete_isClicked = true;

                button.Text = "✓";
                btnAdd.Text = "×";

                foreach(ProductCard card in productCards)
                {
                    card.ToOrder.Text = "Удалить";
                    card.ToOrder.ForeColor = Color.FromArgb(255, 136, 123);
                }
                
            }
            else
            {

            }

        }

        private void btnGroupAdd_Click(object sender, EventArgs e)
        {
            CreateGroup createGroup = new CreateGroup(this);
            createGroup.ShowDialog();
        }

        //вывод на панель OrderCard;
        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            int i = 10;
            foreach(OrderCard order in orderCards)
            {
                order.panel.Size = new Size(Size.Width-80, 120);
                order.panel.Location = new Point(10, i);
                order.ToAccept.Location = new Point(order.panel.Size.Width-150, 20);
                order.ToReject.Location = new Point(order.panel.Size.Width - 150, 60);
                i += 130;
            }
        }
        private void tabControl1_Selected(object sender, EventArgs e)
        {
            foreach (OrderCard order in orderCards)
            {
                order.panel.Size = new Size(Size.Width - 80, 120);
            }
        }

        private void Clear()
        {
            foreach(ProductCard card in products_panel)
            {
                panel1.Controls.Remove(card.GetProductCard());
            }
            products_panel.Clear();
        }

        private void panel1_Resize(object sender, EventArgs e)
        {
            Wigth = (panel1.Size.Width - 120) / 195;
            Hight = (panel1.Size.Height - 70) / 250;
            Clear();
            ProductCardsToPanel();
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            FirstProductCard -= Hight * Wigth;
            FirstProductCard = FirstProductCard < 0 ? 0 : FirstProductCard;
            Clear();
            ProductCardsToPanel();
        }
        private void btnDown_Click(object sender, EventArgs e)
        {
            FirstProductCard += Hight * Wigth;
            FirstProductCard = FirstProductCard >= productCards.Count ? productCards.Count - Hight * Wigth : FirstProductCard;
            Clear();
            ProductCardsToPanel();
        }
    }
}
