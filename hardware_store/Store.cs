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



        public Store()
        {
            InitializeComponent();
            Bl();
        }

        public void Bl()
        {
            ProductCard card = new ProductCard();
            ProductCard.cards.Add(card);
            panel1.Controls.Add(card.GetProductCard());

            OrderCard orderCard = new OrderCard();
            panelToOrder.Controls.Add(orderCard.GetOrderCard());

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
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!btnDelete_isClicked)
            {
                ChangeCreateForm createForm = new ChangeCreateForm();
                createForm.Show();
            }
            else
            {
                btnAdd.Text = "+";
                btnDelete.Text = "-";
                foreach (ProductCard card in ProductCard.cards)
                {
                    card.ToOrder.Text = "Заказать";
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

                foreach(ProductCard card in ProductCard.cards)
                {
                    card.ToOrder.Text = "Удалить";
                }
                
            }
            else
            {

            }



        }
    }
}
