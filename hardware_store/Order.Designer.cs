
namespace hardware_store
{
    partial class Order
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Order));
            this.picBox = new System.Windows.Forms.PictureBox();
            this.lblRest = new System.Windows.Forms.Label();
            this.lblGroup = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCostSale = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.txtBoxCount = new System.Windows.Forms.TextBox();
            this.btnToOrder = new System.Windows.Forms.Button();
            this.btnReject = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // picBox
            // 
            this.picBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(244)))), ((int)(((byte)(233)))));
            this.picBox.Location = new System.Drawing.Point(20, 24);
            this.picBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(200, 206);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox.TabIndex = 0;
            this.picBox.TabStop = false;
            // 
            // lblRest
            // 
            this.lblRest.AutoSize = true;
            this.lblRest.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(143)))), ((int)(((byte)(122)))));
            this.lblRest.Location = new System.Drawing.Point(236, 93);
            this.lblRest.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRest.Name = "lblRest";
            this.lblRest.Size = new System.Drawing.Size(73, 37);
            this.lblRest.TabIndex = 1;
            this.lblRest.Text = "thrh";
            // 
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(143)))), ((int)(((byte)(122)))));
            this.lblGroup.Location = new System.Drawing.Point(15, 262);
            this.lblGroup.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(111, 31);
            this.lblGroup.TabIndex = 2;
            this.lblGroup.Text = "Группа:";
            this.lblGroup.Visible = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(143)))), ((int)(((byte)(122)))));
            this.lblName.Location = new System.Drawing.Point(15, 294);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(145, 31);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Название:";
            // 
            // lblCostSale
            // 
            this.lblCostSale.AutoSize = true;
            this.lblCostSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCostSale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(143)))), ((int)(((byte)(122)))));
            this.lblCostSale.Location = new System.Drawing.Point(15, 326);
            this.lblCostSale.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCostSale.Name = "lblCostSale";
            this.lblCostSale.Size = new System.Drawing.Size(275, 31);
            this.lblCostSale.TabIndex = 4;
            this.lblCostSale.Text = "Стоимость продажи:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(143)))), ((int)(((byte)(122)))));
            this.lblPrice.Location = new System.Drawing.Point(15, 358);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(266, 31);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "Стоимость закупки:";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(143)))), ((int)(((byte)(122)))));
            this.lblCount.Location = new System.Drawing.Point(15, 389);
            this.lblCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(279, 31);
            this.lblCount.TabIndex = 6;
            this.lblCount.Text = "Количество деталей:";
            // 
            // txtBoxCount
            // 
            this.txtBoxCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxCount.Location = new System.Drawing.Point(302, 402);
            this.txtBoxCount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxCount.Name = "txtBoxCount";
            this.txtBoxCount.Size = new System.Drawing.Size(93, 20);
            this.txtBoxCount.TabIndex = 7;
            // 
            // btnToOrder
            // 
            this.btnToOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(244)))), ((int)(((byte)(233)))));
            this.btnToOrder.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(136)))), ((int)(((byte)(137)))));
            this.btnToOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnToOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(202)))), ((int)(((byte)(135)))));
            this.btnToOrder.Location = new System.Drawing.Point(20, 470);
            this.btnToOrder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnToOrder.Name = "btnToOrder";
            this.btnToOrder.Size = new System.Drawing.Size(156, 49);
            this.btnToOrder.TabIndex = 8;
            this.btnToOrder.Text = "Заказать";
            this.btnToOrder.UseVisualStyleBackColor = false;
            this.btnToOrder.Click += new System.EventHandler(this.btnToOrder_Click);
            // 
            // btnReject
            // 
            this.btnReject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(244)))), ((int)(((byte)(233)))));
            this.btnReject.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(136)))), ((int)(((byte)(137)))));
            this.btnReject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReject.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(136)))), ((int)(((byte)(123)))));
            this.btnReject.Location = new System.Drawing.Point(214, 470);
            this.btnReject.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(150, 49);
            this.btnReject.TabIndex = 9;
            this.btnReject.Text = "Отмена";
            this.btnReject.UseVisualStyleBackColor = false;
            this.btnReject.Click += new System.EventHandler(this.btnReject_Click);
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(215)))), ((int)(((byte)(210)))));
            this.ClientSize = new System.Drawing.Size(404, 553);
            this.Controls.Add(this.btnReject);
            this.Controls.Add(this.btnToOrder);
            this.Controls.Add(this.txtBoxCount);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblCostSale);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblGroup);
            this.Controls.Add(this.lblRest);
            this.Controls.Add(this.picBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(420, 592);
            this.MinimumSize = new System.Drawing.Size(420, 592);
            this.Name = "Order";
            this.Text = "Order";
            this.Load += new System.EventHandler(this.Order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Label lblRest;
        private System.Windows.Forms.Label lblGroup;
        public System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCostSale;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.TextBox txtBoxCount;
        private System.Windows.Forms.Button btnToOrder;
        private System.Windows.Forms.Button btnReject;
    }
}