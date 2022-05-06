using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace hardware_store
{
    public class OrderCard
    {
        
        public Panel panel;
        public Button ToAccept;
        public Button ToReject;
        public Label name;
        public PictureBox pic;
        public Label count;
        public Label date_Order;
        public ProductCard card;

        public int id = 0;
        public DateTime order_date { get; private set; }
        public int ord_count { get; private set; }
        public bool IsOnDelete= false;
        public bool IsSubs = false;
        public bool IsWritenObDB = false;
        public void Initialize()
        {
            panel = new Panel();
            ToAccept = new Button();
            ToReject = new Button();
            name = new Label();
            pic = new PictureBox();
            count = new Label();
            date_Order = new Label();

            //panel;
            panel.BackColor = Color.FromArgb(194, 215, 210);
            //panel.Size = new Size(1500, 120);
            panel.Location = new Point(10, 10);

            //ToAccept;
            ToAccept.ForeColor = Color.FromArgb(116, 142, 95);
            ToAccept.Text = "Принять";
            ToAccept.BackColor = Color.FromArgb(165, 202, 135);
            ToAccept.Size = new Size(100, 30);
            //ToAccept.Location = new Point(1000, 20);
            ToAccept.FlatAppearance.BorderSize = 0;
            ToAccept.FlatStyle = FlatStyle.Flat;
            ToAccept.Anchor = AnchorStyles.Right;

            //ToReject;
            ToReject.ForeColor = Color.White;
            ToReject.Text = "Отклонить";
            ToReject.BackColor = Color.FromArgb(255, 136, 123);
            ToReject.Size = new Size(100, 30);
            //ToReject.Location = new Point(1000, 60);
            ToReject.FlatAppearance.BorderSize = 0;
            ToReject.FlatStyle = FlatStyle.Flat;
            ToReject.Anchor = AnchorStyles.Right;

            //name;
            name.Text = "Название товара:";
            name.Location = new Point(150, 20);
            name.TextAlign = ContentAlignment.MiddleLeft;
            name.ForeColor = Color.FromArgb(92, 136, 137);
            name.Size = new Size(200, 20);
            name.AutoSize = false;

            //count;
            count.Text = "Количество товара:";
            count.Location = new Point(150, 50);
            count.TextAlign = ContentAlignment.MiddleLeft;
            count.ForeColor = Color.FromArgb(92, 136, 137);
            count.Size = new Size(200, 20);
            count.AutoSize = false;

            //date_Order;
            date_Order.Text = "Дата заказа:";
            date_Order.Location = new Point(150, 80);
            date_Order.TextAlign = ContentAlignment.MiddleLeft;
            date_Order.ForeColor = Color.FromArgb(92, 136, 137);
            date_Order.Size = new Size(200, 20);
            date_Order.AutoSize = false;

            //pic;
            pic.Location = new Point(20, 10);
            pic.Size = new Size(100, 100);
            pic.SizeMode = PictureBoxSizeMode.StretchImage;


            //Добавление;
            panel.Controls.Add(ToAccept);
            panel.Controls.Add(ToReject);
            panel.Controls.Add(pic);
            panel.Controls.Add(name);
            panel.Controls.Add(count);
            panel.Controls.Add(date_Order);

            ToAccept.Click += ToAccept_Click;
            ToReject.Click += ToReject_Click;
        }


        public OrderCard()
        {
            Initialize();
        }
        public OrderCard(ProductCard card)
        {
            Initialize();
            this.card = card;
            name = card.name;
        }
        public OrderCard(DateTime date, int count, ProductCard card)
        {
            Initialize();
            this.card = card;
            pic.Image = card.pic.Image;
            name.Text += " " + card.name.Text;
            ord_count = count;
            this.count.Text += " " + Convert.ToString(ord_count);
            order_date = date;
            date_Order.Text += " " + order_date.ToLongDateString();
        }
        public OrderCard(ProductCard card, int count)
        {
            Initialize();
            this.card = card;
            pic.Image = card.pic.Image;
            name.Text += " " + card.name.Text;
            ord_count = count;
            this.count.Text += " " + Convert.ToString(ord_count);
            order_date = DateTime.Now;
            date_Order.Text += " " + order_date.ToLongDateString();
        }

        public Panel GetOrderCard()
        {
            return panel;
        }

        public void ToAccept_Click(object sender, EventArgs e)
        {
            if(ord_count + card.rest > card.in_stock || ord_count > card.in_stock)
            {
                card.in_stock = ord_count + card.rest;
                card.rest += ord_count;
            }
            else
            {
                card.rest += ord_count;
            }
            card.Reportpanel.CountOfProduct.Text = $"Из {card.rest} купили";
            this.IsOnDelete = true;
        }
        public void ToReject_Click(object sender, EventArgs e)
        {
            this.IsOnDelete = true;
        }

    }
}
