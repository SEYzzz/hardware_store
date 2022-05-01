using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace hardware_store
{
    class ProductCard
    {
        public Panel panel;
        public Button ToOrder;
        public Button Info;
        public Label name;
        public PictureBox pic;
        public Label icon;

        public static List<ProductCard> onDelete { get; set; }
        public int id { get; private set; }
        public bool IsOnDelete { get; set; } 

        private void Initialize()
        {
            panel = new Panel();
            ToOrder = new Button();
            Info = new Button();
            name = new Label();
            pic = new PictureBox();
            icon = new Label();
            onDelete = new List<ProductCard>();
            IsOnDelete = false;

            //panel;
            panel.BackColor = Color.FromArgb(194, 215, 210);
            panel.Size = new Size(185, 240);
            panel.Location = new Point(10, 10);

            //ToOrder;
            ToOrder.ForeColor = Color.White;
            ToOrder.Text = "Заказать";
            ToOrder.BackColor = Color.FromArgb(116, 142, 95);
            ToOrder.Size = new Size(65, 35);
            ToOrder.Location = new Point(15, 40);
            ToOrder.FlatAppearance.BorderSize = 0;
            ToOrder.FlatStyle = FlatStyle.Flat;
            ToOrder.Tag = this;

            //Info;
            Info.Text = "i";
            Info.ForeColor = Color.White;
            Info.Size = new Size(35, 35);
            Info.Location = new Point(130, 40);
            Info.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(136)))), ((int)(((byte)(137)))));
            Info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Info.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(136)))), ((int)(((byte)(137)))));

            //Lable;
            name.BackColor = Color.FromArgb(92, 136, 137);
            name.TextAlign = ContentAlignment.MiddleCenter;
            name.ForeColor = Color.FromArgb(165, 202, 135);
            name.AutoSize = false;
            name.Text = "Name";                                              //тут как-то заполнение названия из бд или при создании новой штуки;
            name.Size = new Size(150, 25);
            name.Location = new Point(15, 10);
            name.BringToFront();

            //pic;
            pic.Image = Image.FromFile("гантеля.jpg");
            pic.Location = new Point(20, 85);
            pic.Size = new Size(140, 140);
            pic.SizeMode = PictureBoxSizeMode.StretchImage;

            //icon
            icon.Text = "!";
            icon.Location = new Point(175, 220);
            //icon.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(10)));


            //Добавление
            panel.Controls.Add(name);
            panel.Controls.Add(ToOrder);
            panel.Controls.Add(Info);
            panel.Controls.Add(pic);
            panel.Controls.Add(icon);

            ToOrder.Click += ToOrder_Click;
            Info.Click += Info_Click;
        }

        public ProductCard()
        {
            Initialize();
        }

        public Panel GetProductCard()
        {
            return panel;
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.panel.ClientRectangle, Color.FromArgb(92, 136, 137), ButtonBorderStyle.Solid);
        }

        public void ToOrder_Click(object sender, EventArgs e)
        {
            if (ToOrder.Text.Equals("Заказать"))
            {
                Order order = new Order();
                order.ShowDialog();

                order.picBox.Image = this.pic.Image;
                order.lblName.Text = order.lblName.Text + " " + this.name.Text;
            }
            else
            {
                //удалять из листа и панели;
                Button button = sender as Button;
                button.BackColor = Color.FromArgb(252, 238, 141);

                ProductCard order = button.Tag as ProductCard;
                order.IsOnDelete = true;

            }

        }
        public void Info_Click(object sender, EventArgs e)
        {
            InfoCard infoCard = new InfoCard();
            infoCard.ShowDialog();

            infoCard.pictureBox1.Image = this.pic.Image;
            infoCard.lblName.Text = infoCard.lblName.Text + " " + this.name.Text;

        }


    }
}
