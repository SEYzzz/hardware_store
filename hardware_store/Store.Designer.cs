
namespace hardware_store
{
    partial class Store
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblStuff = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panelToOrder = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panelLeftStat = new System.Windows.Forms.Panel();
            this.panelDockStat = new System.Windows.Forms.Panel();
            this.btnReport = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panelToOrder.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panelDockStat.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1582, 753);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(136)))), ((int)(((byte)(137)))));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1574, 724);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Товары на складе";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(244)))), ((int)(((byte)(233)))));
            this.panel1.Controls.Add(this.lblStuff);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(203, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1368, 718);
            this.panel1.TabIndex = 0;
            // 
            // lblStuff
            // 
            this.lblStuff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblStuff.AutoSize = true;
            this.lblStuff.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStuff.Location = new System.Drawing.Point(3, 670);
            this.lblStuff.Name = "lblStuff";
            this.lblStuff.Size = new System.Drawing.Size(488, 46);
            this.lblStuff.TabIndex = 0;
            this.lblStuff.Text = "Всего товаров доступно:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(215)))), ((int)(((byte)(210)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 718);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(244)))), ((int)(((byte)(233)))));
            this.tabPage2.Controls.Add(this.panelToOrder);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1574, 724);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Заказ товаров";
            // 
            // panelToOrder
            // 
            this.panelToOrder.Controls.Add(this.label1);
            this.panelToOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelToOrder.Location = new System.Drawing.Point(3, 3);
            this.panelToOrder.Name = "panelToOrder";
            this.panelToOrder.Size = new System.Drawing.Size(1568, 718);
            this.panelToOrder.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(136)))), ((int)(((byte)(137)))));
            this.label1.Location = new System.Drawing.Point(0, 672);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(421, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Заказов в обработке:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panelLeftStat);
            this.tabPage3.Controls.Add(this.panelDockStat);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1574, 724);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Статисткиа";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panelLeftStat
            // 
            this.panelLeftStat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(215)))), ((int)(((byte)(210)))));
            this.panelLeftStat.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftStat.Location = new System.Drawing.Point(3, 3);
            this.panelLeftStat.Name = "panelLeftStat";
            this.panelLeftStat.Size = new System.Drawing.Size(200, 718);
            this.panelLeftStat.TabIndex = 1;
            this.panelLeftStat.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLeftStat_Paint);
            // 
            // panelDockStat
            // 
            this.panelDockStat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(244)))), ((int)(((byte)(233)))));
            this.panelDockStat.Controls.Add(this.btnReport);
            this.panelDockStat.Controls.Add(this.button1);
            this.panelDockStat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDockStat.Location = new System.Drawing.Point(3, 3);
            this.panelDockStat.Name = "panelDockStat";
            this.panelDockStat.Size = new System.Drawing.Size(1568, 718);
            this.panelDockStat.TabIndex = 0;
            // 
            // btnReport
            // 
            this.btnReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(215)))), ((int)(((byte)(210)))));
            this.btnReport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(136)))), ((int)(((byte)(137)))));
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(136)))), ((int)(((byte)(137)))));
            this.btnReport.Location = new System.Drawing.Point(1273, 661);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(167, 54);
            this.btnReport.TabIndex = 1;
            this.btnReport.Text = "Создать отчёт";
            this.btnReport.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Store
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1582, 753);
            this.Controls.Add(this.tabControl1);
            this.MinimumSize = new System.Drawing.Size(1600, 800);
            this.Name = "Store";
            this.Text = "Store";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panelToOrder.ResumeLayout(false);
            this.panelToOrder.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.panelDockStat.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelToOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelLeftStat;
        private System.Windows.Forms.Panel panelDockStat;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblStuff;
    }
}

