using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SQLite;

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

        DataTable prCards = new DataTable();
        DataTable ordCards = new DataTable();
        SQLiteConnection connection = DBclass.GetConnection();
        int count;

        public Store()
        {
            InitializeComponent();
            LoadDT_prCards();
            LoadDT_ordCards();
            Bl();
        }

        //вывод;
        public void Bl()
        {
            for (int i = 0; i < 5; i++)
            {
                productCards.Add(new ProductCard());
                productCards.Last().name.Text = "Name" + i;
                productCards.Last().orderCards = orderCards;
            }
            ProductCardsToPanel();

            //for (int i = 0; i < 10; i++)
            //{
            //    orderCards.Add(new OrderCard());
            //    orderCards.Last().name.Text += i;
            //    orderCards.Last().ToReject.Click += tabControl1_Selected;
            //    orderCards.Last().ToAccept.Click += tabControl1_Selected;
            //}         
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
                for (int i = orderCards.Count - 1; i >= 0; i--)
                {
                    if ((orderCards[i].card != null) && orderCards[i].card.IsOnDelete)
                    {
                        panelToOrder.Controls.Remove(orderCards[i].GetOrderCard());
                        orderCards.Remove(orderCards[i]);
                    }
                }
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

        //вывод на панель OrderCard;
        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            CheckOrderCards();
            PaintOrderPanels();
        }
        private void tabControl1_Selected(object sender, EventArgs e)
        {
            CheckOrderCards();
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

        //кнопки добавить и удалить для групп
        private void btnGroupAdd_Click(object sender, EventArgs e)
        {
            if (btnGroupAdd.Text.Equals("+"))
            {
                CreateGroup createGroup = new CreateGroup(this);
                createGroup.ShowDialog();
            }
            else
            {
                btnGroupAdd.Text = "+";
                btnGroupAdd.ForeColor = Color.FromArgb(252, 238, 141);
                btnGruopDelete.Text = "-";
                btnGruopDelete.ForeColor = Color.White;
            }
        }
        private void btnGruopDelete_Click(object sender, EventArgs e)
        {
            if (btnGruopDelete.Text.Equals("-"))
            {
                btnGroupAdd.Text = "×";
                btnGroupAdd.ForeColor = Color.FromArgb(165, 202, 135);
                btnGruopDelete.Text = "✓";
                btnGruopDelete.ForeColor = Color.FromArgb(255, 136, 123);
            }
            else
            {
                if(chekListGroups.CheckedItems != null)
                {
                    for(int i = chekListGroups.CheckedItems.Count - 1; i >= 0; i--)
                    {
                        checkedListBox1.Items.Remove(chekListGroups.CheckedItems[i]);
                        chekListGroups.Items.Remove(chekListGroups.CheckedItems[i]);
                    }
                }
                btnGroupAdd.Text = "+";
                btnGroupAdd.ForeColor = Color.FromArgb(252, 238, 141);
                btnGruopDelete.Text = "-";
                btnGruopDelete.ForeColor = Color.White;
            }
        }

        //штука для удаления карточек
        private void CheckOrderCards()
        {
            for(int i = orderCards.Count - 1; i >= 0; i--)
            {
                if (orderCards[i].IsOnDelete)
                {
                    panelToOrder.Controls.Remove(orderCards[i].GetOrderCard());
                    orderCards.Remove(orderCards[i]);
                }
            }
        }

        //работа с SQLite
        private void LoadDT_prCards()
        {
            string sqlcommand = "SELECT* FROM productCards";
            connection.Open();
            SQLiteCommand command = new SQLiteCommand(sqlcommand, connection);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
            adapter.Fill(prCards);
            connection.Close();
        }
        private void LoadDT_ordCards()
        {
            string sqlcommand = "SELECT* FROM orderCards";
            connection.Open();
            SQLiteCommand command = new SQLiteCommand(sqlcommand, connection);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
            adapter.Fill(ordCards);
            connection.Close();
        }

        private void LoadGroups()
        {
            connection.Open();
            SQLiteCommand command = new SQLiteCommand("SELECT name FROM Groups", connection);
            IDataReader rdr = command.ExecuteReader();
            try
            {
                while (rdr.Read())
                {
                    chekListGroups.Items.Add(rdr.GetString(0));
                    checkedListBox1.Items.Add(rdr.GetString(0));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            rdr.Close();
            connection.Close();
        }
        private void LoadProductCards()
        {
            foreach(DataRow dr in prCards.Rows)
            {
                try
                {
                    string name = (string)dr.ItemArray[1];
                    string descrip = (string)dr.ItemArray[2];
                    Image image = DBclass.ByteToImage((byte[])dr.ItemArray[3]);
                    int group_id = Convert.ToInt32(dr.ItemArray[4]);
                    int price = Convert.ToInt32(dr.ItemArray[5]);
                    int sale = Convert.ToInt32(dr.ItemArray[6]);
                    int in_stock = Convert.ToInt32(dr.ItemArray[7]);
                    int rest = Convert.ToInt32(dr.ItemArray[8]);
                    productCards.Add(new ProductCard(name, descrip, image, group_id, price, sale, in_stock, rest));
                    productCards.Last().orderCards = orderCards;
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message);
                }
            }
            count = productCards.Count();
        }
        private void LoadOrderCards()
        {
            foreach (DataRow dr in ordCards.Rows)
            {
                try
                {
                    DateTime date = Convert.ToDateTime(dr.ItemArray[1]);
                    int count = Convert.ToInt32(dr.ItemArray[2]);
                    ProductCard card = productCards[Convert.ToInt32(dr.ItemArray[3])];
                    orderCards.Add(new OrderCard(date, count, card));
                    orderCards.Last().ToReject.Click += tabControl1_Selected;
                    orderCards.Last().ToAccept.Click += tabControl1_Selected;
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message);
                }
            }

        }

        private void WriteDownGroups()
        {

        }
        private void WriteDownPrCards()
        {
            connection.Open();
            for (int i = count; i < productCards.Count; i++)
            {
                string name = productCards[i].name.Text;
                string descr = productCards[i].description;
                byte[] image = DBclass.ImageToByteArray(productCards[i].pic.Image);
                int gr_id = productCards[i].group_id;
                int price = productCards[i].sale;
                int sale = productCards[i].purch_price;
                int in_stock = 1;
                int rest = 0;
                SQLiteCommand command = new SQLiteCommand($"INSERT INTO productCards(name, description, image, group_id, price, sale, in_stock, rest)" +
                    $" VALUES('{name}', '{descr}', '{image}', '{gr_id}', '{price}', '{sale}', '{in_stock}', '{rest}')", connection);
                command.ExecuteNonQuery();
            }
            connection.Close();
        }

        private void Store_Load(object sender, EventArgs e)
        {
            LoadGroups();
            LoadProductCards();
            LoadOrderCards();
        }

        private void Store_FormClosing(object sender, FormClosingEventArgs e)
        {
            WriteDownPrCards();
        }
    }
}
