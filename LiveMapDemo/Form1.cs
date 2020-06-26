using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiveMapDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LiveCharts.WinForms.GeoMap karta = new LiveCharts.WinForms.GeoMap();
            Random rasgele = new Random();
            Dictionary<string, double> maglumatlar = new Dictionary<string, double>();
            maglumatlar["TM"] = rasgele.Next(0, 100);
            maglumatlar["AZ"] = rasgele.Next(0, 100);
            maglumatlar["TR"] = rasgele.Next(0, 100);
            maglumatlar["TJ"] = rasgele.Next(0, 100);
            maglumatlar["GB"] = rasgele.Next(0, 100);
            maglumatlar["US"] = rasgele.Next(0, 100);
            maglumatlar["CN"] = rasgele.Next(0, 100);
            maglumatlar["UY"] = rasgele.Next(0, 100);
            karta.HeatMap = maglumatlar;
            karta.Source = $"{Application.StartupPath}\\World.xml";
            this.Controls.Add(karta);
            karta.Dock = DockStyle.Fill;
        }
    }
}
