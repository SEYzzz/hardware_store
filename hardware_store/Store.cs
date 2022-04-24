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
        public Store()
        {
            InitializeComponent();
            Bl();
        }

        public void Bl()
        {
            ProductCard card = new ProductCard();
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

    }
}
