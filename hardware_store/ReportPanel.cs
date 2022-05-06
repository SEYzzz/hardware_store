using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace hardware_store
{
   public class ReportPanel:Panel
    {
        public Label NameProduct { get; set; }
        public Label CountOfProduct { get; set; }
        public Panel InformationPanel { get; set; }
        public TextBox ReadInformation { get; set; }
        public ProductCard productcard { get; private set; }

        public ReportPanel(ProductCard card)
        {
            productcard = card;
            Inicialization();
            this.SizeChanged += ReportPanel_SizeChanged;
        }

        private void ReportPanel_SizeChanged(object sender, EventArgs e)
        {
            InformationPanel.Size = new Size(Width - 100, Height);
            ReadInformation.Location = new Point(Width - 100, 5);
        }

        private void Inicialization()
        {
            NameProduct = new Label();
            CountOfProduct = new Label();
            InformationPanel = new Panel();
            ReadInformation = new TextBox();
            Controls.Add(ReadInformation);
            Controls.Add(CountOfProduct);
           Controls.Add(NameProduct);
            
            Controls.Add(InformationPanel);


            //настройки этой панели
            Anchor = AnchorStyles.Left | AnchorStyles.Right;
            BackColor= Color.FromArgb(194, 215, 210);
            //настройка панели
            InformationPanel.Location=new Point(0, 25);
            InformationPanel.Size = new Size(Width - 100, Height);
            InformationPanel.Anchor = Anchor = AnchorStyles.Left | AnchorStyles.Right;
            InformationPanel.BackColor = Color.FromArgb(194, 215, 210);

            //настройка названия
            
            NameProduct.BackColor= Color.FromArgb(194, 215, 210);
            NameProduct.ForeColor = Color.FromArgb(92, 136, 137);
            NameProduct.Font = new Font(ReadInformation.Font.FontFamily, 20);
            NameProduct.Location = new Point(0, 35);
            NameProduct.Anchor = AnchorStyles.Left;
            NameProduct.Text = productcard.name.Text;
            NameProduct.AutoSize = false;
            NameProduct.Size = new Size(NameProduct.Width, 40);

            //настройка количества
            CountOfProduct.BackColor=Color.FromArgb(194, 215, 210);
            CountOfProduct.ForeColor = Color.FromArgb(92, 136, 137);
            CountOfProduct.Font = new Font(ReadInformation.Font.FontFamily, 20);
            CountOfProduct.Text = $"Из {productcard.rest} купили";
            CountOfProduct.Location = new Point(5, 35);
            CountOfProduct.Anchor = AnchorStyles.Right;
            
            CountOfProduct.AutoSize = false;
            CountOfProduct.Size = new Size(NameProduct.Width, 40);

            //настройка ввода
            ReadInformation.BackColor = Color.FromArgb(194, 215, 210);
            ReadInformation.ForeColor = Color.FromArgb(92, 136, 137);
            ReadInformation.Font = new Font(ReadInformation.Font.FontFamily, 22);
            ReadInformation.Location = new Point(Width - 100, 5);
            ReadInformation.Text = 0.ToString();



        }
    }
}
