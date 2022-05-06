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

        List<ReportPanel> report_panels = new List<ReportPanel>();
        List<ReportPanel> Show_report_panels = new List<ReportPanel>();
        int FirstReportPanel = 0;


        List<String> groups = new List<string>();

        DataTable prCards = new DataTable();
        DataTable ordCards = new DataTable();
        SQLiteConnection connection = DBclass.GetConnection();
        int count;
        int group_count;
        int order_count;

        public Store()
        {

            InitializeComponent();
            LoadDT_prCards();
            LoadDT_ordCards();

        }

        private void ProductCardsToPanel()
        {
            int X = ProductCard_Wigth;
            int Y = ProductCard_Hight;
            for (int y = 0; y < Y; y++)
            {
                for (int x = 0; x < X; x++)
                {
                    if ((x + y * X + FirstProductCard) < productCards.Count)
                    {
                        productCards[x + y * X + FirstProductCard].panel.Location = new Point(10 + x * 195, 10 + y * 250);
                        panel1.Controls.Add(productCards[x + y * X + FirstProductCard].GetProductCard());
                        products_panel.Add(productCards[x + y * X + FirstProductCard]);
                    }
                }
            }
            lblStuff.Text = "Товаров доступно: " + productCards.Count;
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
                ChangeCreateForm createForm = new ChangeCreateForm(productCards, orderCards);
                createForm.ShowDialog(); 
                CreateReporPanels();
                WriteDownPrCards();
                ProductCardsToPanel();
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

                foreach (ProductCard card in productCards)
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
                        DeleteFromDBordCard(orderCards[i].id);
                        panelToOrder.Controls.Remove(orderCards[i].GetOrderCard());
                        orderCards.Remove(orderCards[i]);
                    }
                }
                for (int i = productCards.Count - 1; i >= 0; i--)
                {
                    if (productCards[i].IsOnDelete)
                    {
                        DeleteFromDBprCard(productCards[i].id);

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
        private void DeleteFromDBprCard(int id)
        {
            connection.Open();
            string sqlExpression = $"DELETE  FROM productCards WHERE id='{ id}'";
            SQLiteCommand command = new SQLiteCommand(sqlExpression, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
        private void DeleteFromDBordCard(int id_prCard)
        {
            connection.Open();
            string sqlExpression = $"DELETE  FROM orderCards WHERE id='{ id_prCard}'";
            SQLiteCommand command = new SQLiteCommand(sqlExpression, connection);
            command.ExecuteNonQuery();
            connection.Close();
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
                if (!orderCards[i].IsSubs)
                {
                    orderCards[i].ToAccept.Click += tabControl1_Selected;
                    orderCards[i].ToReject.Click += tabControl1_Selected;
                    orderCards[i].IsSubs = true;
                }
                j += 130;
                order_on_panel.Add(orderCards[i]);
                panelToOrder.Controls.Add(orderCards[i].GetOrderCard());
            }
            lblOrders.Text = "Заказов в обработке: " + orderCards.Count;
        }

        //изменение размеров;
        private void ClearProductCards()
        {
            foreach (ProductCard card in products_panel)
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
            FirstProductCard = FirstProductCard >= productCards.Count ? FirstProductCard - ProductCard_Hight * ProductCard_Wigth : FirstProductCard;
            ClearProductCards();
            ProductCardsToPanel();
        }

        //кнопки листания вверх и вниз для OrderCard;
        private void Clear_Order()
        {
            foreach (OrderCard order in order_on_panel)
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
                if (chekListGroups.CheckedItems != null)
                {
                    for (int i = chekListGroups.CheckedItems.Count - 1; i >= 0; i--)
                    {
                        DeleteFromDBGroups();
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
        private void DeleteFromDBGroups()
        {
            connection.Open();
            for (int i = chekListGroups.CheckedItems.Count - 1; i >= 0; i--)
            {
                string name = chekListGroups.CheckedItems[i].ToString();
                string sqlExpression = $"DELETE  FROM Groups WHERE name='{name}'";
                SQLiteCommand command = new SQLiteCommand(sqlExpression, connection);
                command.ExecuteNonQuery();
            }
            connection.Close();
        }
        //для закрисовки репорт карточек
        private void CreateReporPanels()
        {
            for (int i = 0; i < productCards.Count; i++)
            {
                if (productCards[i].Reportpanel == null)
                {
                    ReportPanel panel = new ReportPanel(productCards[i]);
                    productCards[i].Reportpanel = panel;
                    panel.Size = new Size(700, 50);
                    panel.Location = new Point(250, 50 + i * 55);
                    report_panels.Add(panel);
                    panelDockStat.Controls.Add(panel);

                }

            }
        }
        private void btnReport_Click(object sender, EventArgs e)
        {
            bool flag = true;
            for (int i = 0; i < report_panels.Count; i++)
            {
                if (report_panels[i].ReadInformation.Text.Equals("")||!report_panels[i].ReadInformation.Text.All(char.IsDigit) || Convert.ToInt32(report_panels[i].ReadInformation.Text) < 0 || Convert.ToInt32(report_panels[i].ReadInformation.Text) > report_panels[i].productcard.rest)
                {
                    flag = false;
                    break;
                }
            }
            if (flag)
            {
                // $"{DateTime.Now.Day}/{DateTime.Now.Month}/{DateTime.Now.Year} {DateTime.Now.Hour}:{DateTime.Now.Minute}:{DateTime.Now.Second}" +
                //@"C:\Users\User\" +
          
                string path =Directory.GetCurrentDirectory()+'\\'+"WorkReport.xlsx" ;
                

                Excel excel = new Excel(path);
                excel.WriteToCell(0, 0, "Название");
                excel.WriteToCell(1, 0, "Количетсов проданного");
                excel.WriteToCell(2, 0, "Заработок");
                int sum = 0;
                int count = 0;
                for (int i = 0; i < report_panels.Count; i++)
                {
                    excel.WriteToCell(0, i + 2, report_panels[i].productcard.name.Text);
                    excel.WriteToCell(1, i + 2, report_panels[i].ReadInformation.Text);
                    excel.WriteToCell(2, i + 2, (-Convert.ToInt32(report_panels[i].ReadInformation.Text) * report_panels[i].productcard.sale+ Convert.ToInt32(report_panels[i].ReadInformation.Text) * report_panels[i].productcard.purch_price).ToString());
                    sum += -Convert.ToInt32(report_panels[i].ReadInformation.Text) * report_panels[i].productcard.sale + Convert.ToInt32(report_panels[i].ReadInformation.Text) * report_panels[i].productcard.purch_price;
                    count += Convert.ToInt32(report_panels[i].ReadInformation.Text);

                }
                excel.WriteToCell(0, 1, "Всего");
                excel.WriteToCell(1, 1, count.ToString());
                excel.WriteToCell(2, 1, sum.ToString());
                excel.SaveFiles();
                
            }
            else
            {
                MessageBox.Show("Ошибка ввода чисел");
            }
        }

        //штука для удаления карточек
        private void CheckOrderCards()
        {
            for (int i = orderCards.Count - 1; i >= 0; i--)
            {
                if (orderCards[i].IsOnDelete)
                {
                    DeleteFromDBordCard(orderCards[i].id);
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

        //выгрузка из бд
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
            group_count = chekListGroups.Items.Count;
        }
        private void LoadProductCards()
        {
            foreach (DataRow dr in prCards.Rows)
            {
                try
                {
                    int id = Convert.ToInt32(dr.ItemArray[0]);
                    string name = (string)dr.ItemArray[1];
                    string descrip = (string)dr.ItemArray[2];
                    Image image = DBclass.ByteToImage((byte[])dr.ItemArray[3]);
                    int group_id = Convert.ToInt32(dr.ItemArray[4]);
                    int price = Convert.ToInt32(dr.ItemArray[5]);
                    int sale = Convert.ToInt32(dr.ItemArray[6]);
                    int in_stock = Convert.ToInt32(dr.ItemArray[7]);
                    int rest = Convert.ToInt32(dr.ItemArray[8]);
                    productCards.Add(new ProductCard(id, name, descrip, image, group_id, price, sale, in_stock, rest));
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
                    int id = Convert.ToInt32(dr.ItemArray[3]);
                    //ProductCard card = productCards[Convert.ToInt32(dr.ItemArray[3])];
                    foreach (ProductCard card in productCards)
                    {
                        if (card.id == id)
                            orderCards.Add(new OrderCard(date, count, card));
                    }
                    orderCards.Last().id = Convert.ToInt32(dr.ItemArray[0]);
                    orderCards.Last().IsWritenObDB = true;
                    orderCards.Last().ToReject.Click += tabControl1_Selected;
                    orderCards.Last().ToAccept.Click += tabControl1_Selected;

                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message);
                }
            }
            order_count = orderCards.Count;
        }

        //запись в бд
        private void WriteDownGroups()
        {
            if (chekListGroups.Items.Count > group_count)
            {
                connection.Open();
                for (int i = group_count; i < chekListGroups.Items.Count; i++)
                {
                    string name = chekListGroups.Items[i].ToString();
                    SQLiteCommand command = new SQLiteCommand($"INSERT INTO Groups(name) VALUES('{name}')", connection);
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }
        private async void WriteDownPrCards()
        {
            connection.Open();
            int i = productCards.Count - 1;
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
                    $" VALUES('{name}', '{descr}', @image, '{gr_id}', '{price}', '{sale}', '{in_stock}', '{rest}')", connection);
                command.Parameters.Add(new SQLiteParameter("@image", image));
                command.ExecuteNonQuery();
            }
            connection.Close();
        }
        private void WriteDownOrdCards()
        {

            connection.Open();
            for (int i = 0; i < orderCards.Count; i++)
            {
                if (orderCards[i].id == 0)
                {
                    DateTime date = orderCards[i].order_date;
                    int order_count = orderCards[i].ord_count;
                    int product_id = orderCards[i].card.id;
                    SQLiteCommand command = new SQLiteCommand($"INSERT INTO orderCards(order_date, order_count, product_id)" +
                        $" VALUES('{date}', '{order_count}', '{product_id}')", connection);
                    command.ExecuteNonQuery();
                }

            }
            connection.Close();

        }

        private void Store_Load(object sender, EventArgs e)
        {
           
        
            
            LoadGroups();
            LoadProductCards();
            LoadOrderCards();
            Program.orderCards = orderCards;
            Program.productCards = productCards;
            ProductCard_Wigth = (panel1.Size.Width - 120) / 195;
            ProductCard_Hight = (panel1.Size.Height - 70) / 250;
            ProductCardsToPanel();
            CreateReporPanels();

        }


        private void Store_FormClosing(object sender, FormClosingEventArgs e)
        {
            CheckOrderCards();
            WriteDownGroups();
            WriteDownOrdCards();

        }


    }
}
