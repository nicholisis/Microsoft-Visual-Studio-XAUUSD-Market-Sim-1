using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace M4VP
{
    public partial class Form1 : Form
    {
        DataTable dt = new DataTable();
        Random rand = new Random();

        double buyPrice = -1; // -1 menandakan belum ada posisi BUY
        double totalProfit = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("market.xml"))
            {
                dt.ReadXml("market.xml");
            }
            else
            {
                CreateDefaultData();
            }

            UpdateLabelText();
        }

        private void CreateDefaultData()
        {
            dt.TableName = "XAUUSD";
            dt.Columns.Add("Price", typeof(int));

            dt.Rows.Add(1000);
        }

        private int GetCurrentPrice()
        {
            if (dt.Rows.Count > 0)
            {
                return Convert.ToInt32(dt.Rows[dt.Rows.Count - 1]["Price"]);
            }
            return 1000;
        }

        private void UpdateLabelText()
        {
            int currentPrice = GetCurrentPrice();
            lblPrice.Text = $"XAUUSD : ${currentPrice}.00";
            lblProfit.Text = $"Total Profit : ${totalProfit:N2}";
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            if (dt.Rows.Count == 0) return;

            int startX = 60;
            int baseY = 420;
            int topY = 220;
            int gap = 65;

            int maxEndX = 1030;

            int maxVisiblePoints = (maxEndX - startX) / gap + 1; 

            int startIndex = 0;
            if (dt.Rows.Count > maxVisiblePoints)
            {
                startIndex = dt.Rows.Count - maxVisiblePoints;
            }

            int visibleCount = dt.Rows.Count - startIndex;

            int minPrice = Convert.ToInt32(dt.Rows[startIndex]["Price"]);
            int maxPrice = Convert.ToInt32(dt.Rows[startIndex]["Price"]);

            for (int i = startIndex; i < dt.Rows.Count; i++)
            {
                int p = Convert.ToInt32(dt.Rows[i]["Price"]);
                if (p < minPrice) minPrice = p;
                if (p > maxPrice) maxPrice = p;
            }

            int priceRange = maxPrice - minPrice;
            int chartHeight = baseY - topY;

            Point[] points = new Point[visibleCount];

            for (int i = 0; i < visibleCount; i++)
            {
                int dataIndex = startIndex + i;
                int price = Convert.ToInt32(dt.Rows[dataIndex]["Price"]);

                int x = startX + (i * gap);
                int y;

                if (priceRange == 0)
                {
                    y = baseY; // kalo semua data nilainya sama
                }
                else
                {
                    float ratio = (float)(price - minPrice) / priceRange;
                    y = baseY - (int)(ratio * chartHeight);
                }

                points[i] = new Point(x, y);

                g.FillEllipse(Brushes.Lime, x - 5, y - 5, 10, 10);

                g.DrawString(
                    price.ToString(),
                    new Font("Arial", 8, FontStyle.Regular),
                    Brushes.White,
                    x - 12,
                    y - 18
                );
            }

            if (visibleCount > 1)
            {
                g.DrawLines(Pens.Lime, points);
            }

            g.DrawLine(Pens.Gray, 40, baseY, maxEndX, baseY);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int currentPrice = GetCurrentPrice();
            int priceChange = rand.Next(20, 81);

            int direction = rand.Next(0, 2);

            int newPrice;
            if (direction == 1)
            {
                newPrice = currentPrice + priceChange; // harga naik
            }
            else
            {
                newPrice = currentPrice - priceChange; // harga turun
            }

            // harga ndk iso turun ke 0
            if (newPrice < 1) newPrice = 1;

            dt.Rows.Add(newPrice);

            UpdateLabelText();
            Invalidate();
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            if (buyPrice != -1)
            {
                MessageBox.Show("Anda sudah melakukan BUY! Selesaikan posisi BUY terlebih dahulu dengan tombol CUT.");
                return;
            }

            buyPrice = GetCurrentPrice();

            MessageBox.Show($"BUY at ${buyPrice:N2}");
        }

        private void btnCut_Click(object sender, EventArgs e)
        {
            if (buyPrice == -1)
            {
                MessageBox.Show("Belum ada posisi BUY yang dibuka!");
                return;
            }

            int currentPrice = GetCurrentPrice();
            double profit = currentPrice - buyPrice;

            totalProfit += profit;

            MessageBox.Show($"CUT\nProfit : ${profit:N2}");

            buyPrice = -1;

            UpdateLabelText();
        }

        private void btnSaveMarket_Click(object sender, EventArgs e)
        {
            dt.WriteXml("market.xml", XmlWriteMode.WriteSchema);
            MessageBox.Show("Market Saved!");
        }
    }
}