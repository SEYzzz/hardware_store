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

        //для ProductCard
        private int ProductCard_Hight = 4;
        private int ProductCard_Wigth = 2;
        private int FirstProductCard = 0;

        //for OrderCard
        private int Order_Hight = 3;
        private int FirstOrderCard = 0;

        List<OrderCard> orderCards = new List<OrderCard>();
        List<OrderCard> order_on_panel = new List<OrderCard>();

        List<ProductCard> productCards = new List<ProductCard>();
        List<ProductCard> products_panel = new List<ProductCard>();

        List<String> groups = new List<string>();
              

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

            for (int i = 0; i < 10; i++)
            {
                orderCards.Add(new OrderCard());
                orderCards.Last().name.Text += i;
            }
            

        }
        private void ProductCardsToPanel()
        {
            int X = ProductCard_Wigth;
            int Y = ProductCard_Hight;
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

        //кнопки добавить и удалить для ProductCards;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button.Text.Equals("+"))
            {
                ChangeCreateForm createForm = new ChangeCreateForm(productCards);
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
                    card.ToOrder.BackColor = Color.FromArgb(116, 142, 95);
                    card.ChangeToOrder_ToDelete_Click();
                        
                }

                //btnDelete_isClicked = false;

            }

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button.Text.Equals("-"))
            {
                btnDelete_isClicked = true;

                button.Text = "✓";
                btnAdd.Text = "×";

                foreach(ProductCard card in productCards)
                {
                    card.ToOrder.Text = "Удалить";
                    card.ToOrder.ForeColor = Color.FromArgb(255, 136, 123);
                    card.ChangeToOrder_ToDelete_Click();
                }
                
            }
            else
            {
                for (int i = productCards.Count-1; i >= 0; i--)
                {
                    if (productCards[i].IsOnDelete)
                    {
                        panel1.Controls.Remove(productCards[i].GetProductCard());
                        productCards.Remove(productCards[i]);
                    }
                }
                ClearProductCards();
                ProductCardsToPanel();

                button.Text = "-";
                btnAdd.Text = "+";
                btnDelete_isClicked = false;
                foreach (ProductCard card in productCards)
                {
                    card.ToOrder.Text = "Заказать";
                    card.ToOrder.ForeColor = Color.White;
                    card.ChangeToOrder_ToDelete_Click();
                }

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
            PaintOrderPanels();
        }
        private void tabControl1_Selected(object sender, EventArgs e)
        {
            Clear_Order();
            Order_Hight = (panelToOrder.Height - 70) / 130;
            PaintOrderPanels();
        }
        private void PaintOrderPanels()
        {
            int j = 10;
            for (int i = FirstOrderCard; i < FirstOrderCard + Order_Hight && i < orderCards.Count; i++)
            {
                orderCards[i].panel.Size = new Size(panelToOrder.Size.Width - 80, 120);
                orderCards[i].panel.Location = new Point(10, j);
                orderCards[i].ToAccept.Location = new Point(orderCards[i].panel.Size.Width - 150, 20);
                orderCards[i].ToReject.Location = new Point(orderCards[i].panel.Size.Width - 150, 60);
                j += 130;
                order_on_panel.Add(orderCards[i]);
                panelToOrder.Controls.Add(orderCards[i].GetOrderCard());
            }
        }

        //изменение размеров;
        private void ClearProductCards()
        {
            foreach(ProductCard card in products_panel)
            {
                panel1.Controls.Remove(card.GetProductCard());
            }
            products_panel.Clear();
        }
        private void panel1_Resize(object sender, EventArgs e)
        {
            ProductCard_Wigth = (panel1.Size.Width - 120) / 195;
            ProductCard_Hight = (panel1.Size.Height - 70) / 250;
            ClearProductCards();
            ProductCardsToPanel();
        }

        //кнопки листания вверх и вниз для ProductCards;
        private void btnUp_Click(object sender, EventArgs e)
        {
            FirstProductCard -= ProductCard_Hight * ProductCard_Wigth;
            FirstProductCard = FirstProductCard < 0 ? 0 : FirstProductCard;
            ClearProductCards();
            ProductCardsToPanel();
        }
        private void btnDown_Click(object sender, EventArgs e)
        {
            FirstProductCard += ProductCard_Hight * ProductCard_Wigth;
            FirstProductCard = FirstProductCard >= productCards.Count ? productCards.Count - ProductCard_Hight * ProductCard_Wigth : FirstProductCard;
            ClearProductCards();
            ProductCardsToPanel();
        }

        //кнопки листания вверх и вниз для OrderCard;
        private void Clear_Order()
        {
            foreach(OrderCard order in order_on_panel)
            {
                panelToOrder.Controls.Remove(order.GetOrderCard());
            }
            order_on_panel.Clear();
        }
        private void btnUp2_Click(object sender, EventArgs e)
        {
            FirstOrderCard -= Order_Hight;
            FirstOrderCard = FirstOrderCard < 0 ? 0 : FirstOrderCard;
            Clear_Order();
            PaintOrderPanels();
        }
        private void btnDown2_Click(object sender, EventArgs e)
        {
            FirstOrderCard += Order_Hight;
            FirstOrderCard = FirstOrderCard > orderCards.Count ? FirstOrderCard - Order_Hight : FirstOrderCard;
            Clear_Order();
            PaintOrderPanels();
        }

    }
}
