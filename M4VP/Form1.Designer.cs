namespace M4VP
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblPrice = new Label();
            lblProfit = new Label();
            btnUpdate = new Button();
            btnCut = new Button();
            btnSaveMarket = new Button();
            btnBuy = new Button();
            lblTitle = new Label();
            SuspendLayout();
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrice.ForeColor = Color.Lime;
            lblPrice.Location = new Point(28, 29);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(334, 46);
            lblPrice.TabIndex = 0;
            lblPrice.Text = "XAAUSD : $1000.00";
            // 
            // lblProfit
            // 
            lblProfit.AutoSize = true;
            lblProfit.ForeColor = SystemColors.ButtonHighlight;
            lblProfit.Location = new Point(28, 85);
            lblProfit.Name = "lblProfit";
            lblProfit.Size = new Size(129, 20);
            lblProfit.TabIndex = 1;
            lblProfit.Text = "Total profit : $0.00";
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(40, 40, 55);
            btnUpdate.ForeColor = SystemColors.ButtonHighlight;
            btnUpdate.Location = new Point(516, 29);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(132, 48);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnCut
            // 
            btnCut.BackColor = Color.FromArgb(40, 40, 55);
            btnCut.ForeColor = SystemColors.ButtonHighlight;
            btnCut.Location = new Point(792, 29);
            btnCut.Name = "btnCut";
            btnCut.Size = new Size(132, 48);
            btnCut.TabIndex = 3;
            btnCut.Text = "CUT";
            btnCut.UseVisualStyleBackColor = false;
            btnCut.Click += btnCut_Click;
            // 
            // btnSaveMarket
            // 
            btnSaveMarket.BackColor = Color.FromArgb(40, 40, 55);
            btnSaveMarket.ForeColor = SystemColors.ButtonHighlight;
            btnSaveMarket.Location = new Point(930, 29);
            btnSaveMarket.Name = "btnSaveMarket";
            btnSaveMarket.Size = new Size(132, 48);
            btnSaveMarket.TabIndex = 4;
            btnSaveMarket.Text = "SAVE MARKET";
            btnSaveMarket.UseVisualStyleBackColor = false;
            btnSaveMarket.Click += btnSaveMarket_Click;
            // 
            // btnBuy
            // 
            btnBuy.BackColor = Color.FromArgb(40, 40, 55);
            btnBuy.ForeColor = SystemColors.ButtonHighlight;
            btnBuy.Location = new Point(654, 29);
            btnBuy.Name = "btnBuy";
            btnBuy.Size = new Size(132, 48);
            btnBuy.TabIndex = 5;
            btnBuy.Text = "BUY";
            btnBuy.UseVisualStyleBackColor = false;
            btnBuy.Click += btnBuy_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(253, 217, 0);
            lblTitle.Location = new Point(28, 143);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(416, 50);
            lblTitle.TabIndex = 6;
            lblTitle.Text = "XAAUSD PRICE CHART";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 18, 28);
            ClientSize = new Size(1110, 578);
            Controls.Add(lblTitle);
            Controls.Add(btnBuy);
            Controls.Add(btnSaveMarket);
            Controls.Add(btnCut);
            Controls.Add(btnUpdate);
            Controls.Add(lblProfit);
            Controls.Add(lblPrice);
            Name = "Form1";
            Text = "XAAUSD Market Sim";
            Load += Form1_Load;
            Paint += Form1_Paint;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPrice;
        private Label lblProfit;
        private Button btnUpdate;
        private Button btnCut;
        private Button btnSaveMarket;
        private Button btnBuy;
        private Label lblTitle;
    }
}
