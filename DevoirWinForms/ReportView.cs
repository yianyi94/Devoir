using Devoir1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevoirWinForms
{
    public partial class ReportView : Form
    {
        public ReportView()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random Run = new Random();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.LocalReport.ReportPath = "Report1.rdlc";
            List<Produit> produits = new List<Produit>
            {
                new Produit("001","Robot Mixer",2,20000),
                new Produit("AB12","Ecran plat 32 pouces",1,90000),
                new Produit("AC16","Matelas",6,30000),
                new Produit("WA12","canapes",2,50000),
                new Produit("AB20","Micro onde",3,40000),
                new Produit("AD16","Gel de douche",12,1500),
            };

            List<Client> clients = new List<Client>()
            {
                new Client("Popouere stephane","willsteph54@yahoo.com",694831653),
            };
            this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", produits));
            this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet2", clients));
            this.reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
            this.reportViewer1.ZoomPercent = 100;
            this.reportViewer1.RefreshReport();
        }
    }
}
