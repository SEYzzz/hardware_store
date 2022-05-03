
namespace hardware_store
{
    partial class InfoCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoCard));
            this.btnChange = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblGroup = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCostSale = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblDescrp = new System.Windows.Forms.Label();
            this.lblRest = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChange
            // 
            this.btnChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(238)))), ((int)(((byte)(141)))));
            this.btnChange.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(136)))), ((int)(((byte)(137)))));
            this.btnChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnChange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(136)))), ((int)(((byte)(137)))));
            this.btnChange.Location = new System.Drawing.Point(75, 594);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(358, 67);
            this.btnChange.TabIndex = 0;
            this.btnChange.Text = "Изменить";
            this.btnChange.UseVisualStyleBackColor = false;
            this.btnChange.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(21, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(277, 262);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(136)))), ((int)(((byte)(137)))));
            this.lblGroup.Location = new System.Drawing.Point(15, 306);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(125, 36);
            this.lblGroup.TabIndex = 2;
            this.lblGroup.Text = "Группа:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(136)))), ((int)(((byte)(137)))));
            this.lblName.Location = new System.Drawing.Point(15, 342);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(162, 36);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Название:";
            // 
            // lblCostSale
            // 
            this.lblCostSale.AutoSize = true;
            this.lblCostSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCostSale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(136)))), ((int)(((byte)(137)))));
            this.lblCostSale.Location = new System.Drawing.Point(15, 378);
            this.lblCostSale.Name = "lblCostSale";
            this.lblCostSale.Size = new System.Drawing.Size(236, 36);
            this.lblCostSale.TabIndex = 4;
            this.lblCostSale.Text = "Цена продажи:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(136)))), ((int)(((byte)(137)))));
            this.lblPrice.Location = new System.Drawing.Point(15, 414);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(217, 36);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "Цена закупки:";
            // 
            // lblDescrp
            // 
            this.lblDescrp.AutoSize = true;
            this.lblDescrp.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDescrp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(136)))), ((int)(((byte)(137)))));
            this.lblDescrp.Location = new System.Drawing.Point(15, 450);
            this.lblDescrp.Name = "lblDescrp";
            this.lblDescrp.Size = new System.Drawing.Size(273, 36);
            this.lblDescrp.TabIndex = 6;
            this.lblDescrp.Text = "Описание товара:";
            // 
            // lblRest
            // 
            this.lblRest.AutoSize = true;
            this.lblRest.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(136)))), ((int)(((byte)(137)))));
            this.lblRest.Location = new System.Drawing.Point(352, 112);
            this.lblRest.Name = "lblRest";
            this.lblRest.Size = new System.Drawing.Size(130, 69);
            this.lblRest.TabIndex = 7;
            this.lblRest.Text = "rest";
            // 
            // InfoCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(215)))), ((int)(((byte)(210)))));
            this.ClientSize = new System.Drawing.Size(537, 673);
            this.Controls.Add(this.lblRest);
            this.Controls.Add(this.lblDescrp);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblCostSale);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblGroup);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnChange);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(555, 720);
            this.MinimumSize = new System.Drawing.Size(555, 720);
            this.Name = "InfoCard";
            this.Text = "InfoCard";
            this.Load += new System.EventHandler(this.InfoCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChange;
        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblGroup;
        public System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCostSale;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblDescrp;
        private System.Windows.Forms.Label lblRest;
    }
}