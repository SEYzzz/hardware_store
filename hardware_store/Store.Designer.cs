
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Store));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblStuff = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chekListGroups = new System.Windows.Forms.CheckedListBox();
            this.btnGruopDelete = new System.Windows.Forms.Button();
            this.btnGroupAdd = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panelToOrder = new System.Windows.Forms.Panel();
            this.btnUp2 = new System.Windows.Forms.Button();
            this.btnDown2 = new System.Windows.Forms.Button();
            this.lblOrders = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panelLeftStat = new System.Windows.Forms.Panel();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.panelDockStat = new System.Windows.Forms.Panel();
            this.btnUp3 = new System.Windows.Forms.Button();
            this.btnDown3 = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.UmeletzMeniPicture = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panelToOrder.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panelLeftStat.SuspendLayout();
            this.panelDockStat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UmeletzMeniPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1188, 618);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(136)))), ((int)(((byte)(137)))));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(1180, 592);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Товары на складе";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(244)))), ((int)(((byte)(233)))));
            this.panel1.Controls.Add(this.btnDown);
            this.panel1.Controls.Add(this.btnUp);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.lblStuff);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(152, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1026, 588);
            this.panel1.TabIndex = 0;
            this.panel1.Resize += new System.EventHandler(this.panel1_Resize);
            // 
            // btnDown
            // 
            this.btnDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(136)))), ((int)(((byte)(137)))));
            this.btnDown.FlatAppearance.BorderSize = 0;
            this.btnDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(244)))), ((int)(((byte)(233)))));
            this.btnDown.Location = new System.Drawing.Point(960, 523);
            this.btnDown.Margin = new System.Windows.Forms.Padding(2);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(56, 61);
            this.btnDown.TabIndex = 4;
            this.btnDown.Text = "ᐯ";
            this.btnDown.UseVisualStyleBackColor = false;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnUp
            // 
            this.btnUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(136)))), ((int)(((byte)(137)))));
            this.btnUp.FlatAppearance.BorderSize = 0;
            this.btnUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(244)))), ((int)(((byte)(233)))));
            this.btnUp.Location = new System.Drawing.Point(960, 445);
            this.btnUp.Margin = new System.Windows.Forms.Padding(2);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(56, 57);
            this.btnUp.TabIndex = 3;
            this.btnUp.Text = "ᐱ";
            this.btnUp.UseVisualStyleBackColor = false;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(136)))), ((int)(((byte)(137)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(136)))), ((int)(((byte)(123)))));
            this.btnDelete.Location = new System.Drawing.Point(960, 97);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(56, 55);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "-";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(136)))), ((int)(((byte)(137)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(202)))), ((int)(((byte)(135)))));
            this.btnAdd.Location = new System.Drawing.Point(960, 20);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(56, 55);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblStuff
            // 
            this.lblStuff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblStuff.AutoSize = true;
            this.lblStuff.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStuff.Location = new System.Drawing.Point(2, 549);
            this.lblStuff.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStuff.Name = "lblStuff";
            this.lblStuff.Size = new System.Drawing.Size(370, 37);
            this.lblStuff.TabIndex = 0;
            this.lblStuff.Text = "Всего товаров доступно:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(215)))), ((int)(((byte)(210)))));
            this.panel2.Controls.Add(this.UmeletzMeniPicture);
            this.panel2.Controls.Add(this.chekListGroups);
            this.panel2.Controls.Add(this.btnGruopDelete);
            this.panel2.Controls.Add(this.btnGroupAdd);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 588);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // chekListGroups
            // 
            this.chekListGroups.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(215)))), ((int)(((byte)(210)))));
            this.chekListGroups.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chekListGroups.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(136)))), ((int)(((byte)(137)))));
            this.chekListGroups.FormattingEnabled = true;
            this.chekListGroups.Location = new System.Drawing.Point(2, 2);
            this.chekListGroups.Margin = new System.Windows.Forms.Padding(2);
            this.chekListGroups.Name = "chekListGroups";
            this.chekListGroups.Size = new System.Drawing.Size(102, 525);
            this.chekListGroups.TabIndex = 2;
            // 
            // btnGruopDelete
            // 
            this.btnGruopDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGruopDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(136)))), ((int)(((byte)(137)))));
            this.btnGruopDelete.FlatAppearance.BorderSize = 0;
            this.btnGruopDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGruopDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGruopDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(244)))), ((int)(((byte)(233)))));
            this.btnGruopDelete.Location = new System.Drawing.Point(62, 549);
            this.btnGruopDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnGruopDelete.Name = "btnGruopDelete";
            this.btnGruopDelete.Size = new System.Drawing.Size(40, 35);
            this.btnGruopDelete.TabIndex = 1;
            this.btnGruopDelete.Text = "-";
            this.btnGruopDelete.UseVisualStyleBackColor = false;
            this.btnGruopDelete.Click += new System.EventHandler(this.btnGruopDelete_Click);
            // 
            // btnGroupAdd
            // 
            this.btnGroupAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGroupAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(136)))), ((int)(((byte)(137)))));
            this.btnGroupAdd.FlatAppearance.BorderSize = 0;
            this.btnGroupAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGroupAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGroupAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(238)))), ((int)(((byte)(141)))));
            this.btnGroupAdd.Location = new System.Drawing.Point(106, 549);
            this.btnGroupAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnGroupAdd.Name = "btnGroupAdd";
            this.btnGroupAdd.Size = new System.Drawing.Size(39, 35);
            this.btnGroupAdd.TabIndex = 0;
            this.btnGroupAdd.Text = "+";
            this.btnGroupAdd.UseVisualStyleBackColor = false;
            this.btnGroupAdd.Click += new System.EventHandler(this.btnGroupAdd_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(244)))), ((int)(((byte)(233)))));
            this.tabPage2.Controls.Add(this.panelToOrder);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(1180, 592);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Заказ товаров";
            // 
            // panelToOrder
            // 
            this.panelToOrder.Controls.Add(this.btnUp2);
            this.panelToOrder.Controls.Add(this.btnDown2);
            this.panelToOrder.Controls.Add(this.lblOrders);
            this.panelToOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelToOrder.Location = new System.Drawing.Point(2, 2);
            this.panelToOrder.Margin = new System.Windows.Forms.Padding(2);
            this.panelToOrder.Name = "panelToOrder";
            this.panelToOrder.Size = new System.Drawing.Size(1176, 588);
            this.panelToOrder.TabIndex = 0;
            // 
            // btnUp2
            // 
            this.btnUp2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUp2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(136)))), ((int)(((byte)(137)))));
            this.btnUp2.FlatAppearance.BorderSize = 0;
            this.btnUp2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUp2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUp2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(244)))), ((int)(((byte)(233)))));
            this.btnUp2.Location = new System.Drawing.Point(1132, 500);
            this.btnUp2.Margin = new System.Windows.Forms.Padding(2);
            this.btnUp2.Name = "btnUp2";
            this.btnUp2.Size = new System.Drawing.Size(40, 41);
            this.btnUp2.TabIndex = 2;
            this.btnUp2.Text = "ᐱ";
            this.btnUp2.UseVisualStyleBackColor = false;
            this.btnUp2.Click += new System.EventHandler(this.btnUp2_Click);
            // 
            // btnDown2
            // 
            this.btnDown2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDown2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(136)))), ((int)(((byte)(137)))));
            this.btnDown2.FlatAppearance.BorderSize = 0;
            this.btnDown2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDown2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDown2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(244)))), ((int)(((byte)(233)))));
            this.btnDown2.Location = new System.Drawing.Point(1132, 545);
            this.btnDown2.Margin = new System.Windows.Forms.Padding(2);
            this.btnDown2.Name = "btnDown2";
            this.btnDown2.Size = new System.Drawing.Size(40, 41);
            this.btnDown2.TabIndex = 1;
            this.btnDown2.Text = "ᐯ";
            this.btnDown2.UseVisualStyleBackColor = false;
            this.btnDown2.Click += new System.EventHandler(this.btnDown2_Click);
            // 
            // lblOrders
            // 
            this.lblOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblOrders.AutoSize = true;
            this.lblOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOrders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(136)))), ((int)(((byte)(137)))));
            this.lblOrders.Location = new System.Drawing.Point(0, 551);
            this.lblOrders.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOrders.Name = "lblOrders";
            this.lblOrders.Size = new System.Drawing.Size(329, 37);
            this.lblOrders.TabIndex = 0;
            this.lblOrders.Text = "Заказов в обработке:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panelLeftStat);
            this.tabPage3.Controls.Add(this.panelDockStat);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage3.Size = new System.Drawing.Size(1180, 592);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Статисткиа";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panelLeftStat
            // 
            this.panelLeftStat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(215)))), ((int)(((byte)(210)))));
            this.panelLeftStat.Controls.Add(this.pictureBox1);
            this.panelLeftStat.Controls.Add(this.checkedListBox1);
            this.panelLeftStat.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftStat.Location = new System.Drawing.Point(2, 2);
            this.panelLeftStat.Margin = new System.Windows.Forms.Padding(2);
            this.panelLeftStat.Name = "panelLeftStat";
            this.panelLeftStat.Size = new System.Drawing.Size(150, 588);
            this.panelLeftStat.TabIndex = 1;
            this.panelLeftStat.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLeftStat_Paint);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(215)))), ((int)(((byte)(210)))));
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(136)))), ((int)(((byte)(137)))));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(4, 2);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(128, 525);
            this.checkedListBox1.TabIndex = 0;
            // 
            // panelDockStat
            // 
            this.panelDockStat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(244)))), ((int)(((byte)(233)))));
            this.panelDockStat.Controls.Add(this.btnUp3);
            this.panelDockStat.Controls.Add(this.btnDown3);
            this.panelDockStat.Controls.Add(this.btnReport);
            this.panelDockStat.Controls.Add(this.button1);
            this.panelDockStat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDockStat.Location = new System.Drawing.Point(2, 2);
            this.panelDockStat.Margin = new System.Windows.Forms.Padding(2);
            this.panelDockStat.Name = "panelDockStat";
            this.panelDockStat.Size = new System.Drawing.Size(1176, 588);
            this.panelDockStat.TabIndex = 0;
            // 
            // btnUp3
            // 
            this.btnUp3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUp3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(136)))), ((int)(((byte)(137)))));
            this.btnUp3.FlatAppearance.BorderSize = 0;
            this.btnUp3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUp3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUp3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(244)))), ((int)(((byte)(233)))));
            this.btnUp3.Location = new System.Drawing.Point(1127, 486);
            this.btnUp3.Margin = new System.Windows.Forms.Padding(2);
            this.btnUp3.Name = "btnUp3";
            this.btnUp3.Size = new System.Drawing.Size(45, 49);
            this.btnUp3.TabIndex = 3;
            this.btnUp3.Text = "ᐱ";
            this.btnUp3.UseVisualStyleBackColor = false;
            // 
            // btnDown3
            // 
            this.btnDown3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDown3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(136)))), ((int)(((byte)(137)))));
            this.btnDown3.FlatAppearance.BorderSize = 0;
            this.btnDown3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDown3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDown3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(244)))), ((int)(((byte)(233)))));
            this.btnDown3.Location = new System.Drawing.Point(1127, 540);
            this.btnDown3.Margin = new System.Windows.Forms.Padding(2);
            this.btnDown3.Name = "btnDown3";
            this.btnDown3.Size = new System.Drawing.Size(45, 49);
            this.btnDown3.TabIndex = 2;
            this.btnDown3.Text = "ᐯ";
            this.btnDown3.UseVisualStyleBackColor = false;
            // 
            // btnReport
            // 
            this.btnReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(215)))), ((int)(((byte)(210)))));
            this.btnReport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(136)))), ((int)(((byte)(137)))));
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(136)))), ((int)(((byte)(137)))));
            this.btnReport.Location = new System.Drawing.Point(998, 542);
            this.btnReport.Margin = new System.Windows.Forms.Padding(2);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(125, 44);
            this.btnReport.TabIndex = 1;
            this.btnReport.Text = "Создать отчёт";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 19);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // UmeletzMeniPicture
            // 
            this.UmeletzMeniPicture.BackColor = System.Drawing.Color.Transparent;
            this.UmeletzMeniPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.UmeletzMeniPicture.Dock = System.Windows.Forms.DockStyle.Left;
            this.UmeletzMeniPicture.Image = ((System.Drawing.Image)(resources.GetObject("UmeletzMeniPicture.Image")));
            this.UmeletzMeniPicture.Location = new System.Drawing.Point(0, 0);
            this.UmeletzMeniPicture.Name = "UmeletzMeniPicture";
            this.UmeletzMeniPicture.Size = new System.Drawing.Size(150, 588);
            this.UmeletzMeniPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UmeletzMeniPicture.TabIndex = 3;
            this.UmeletzMeniPicture.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 588);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Store
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 618);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(1204, 657);
            this.Name = "Store";
            this.Text = "Store";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Store_FormClosing);
            this.Load += new System.EventHandler(this.Store_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panelToOrder.ResumeLayout(false);
            this.panelToOrder.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.panelLeftStat.ResumeLayout(false);
            this.panelDockStat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UmeletzMeniPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TabControl tabControl1;
        public System.Windows.Forms.TabPage tabPage1;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Panel panelToOrder;
        private System.Windows.Forms.Label lblOrders;
        private System.Windows.Forms.Panel panelLeftStat;
        private System.Windows.Forms.Panel panelDockStat;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblStuff;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnGruopDelete;
        private System.Windows.Forms.Button btnGroupAdd;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnUp;
        public System.Windows.Forms.CheckedListBox chekListGroups;
        public System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button btnUp2;
        private System.Windows.Forms.Button btnDown2;
        private System.Windows.Forms.Button btnUp3;
        private System.Windows.Forms.Button btnDown3;
        private System.Windows.Forms.PictureBox UmeletzMeniPicture;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

