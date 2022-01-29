using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Animals
{
    /// <summary>
    /// Interaction logic for RaportWindow.xaml
    /// </summary>
    public partial class RaportWindow : Window
    {
        public RaportWindow()
        {

            InitializeComponent();

            this.ctlReport.ReportLoaded += (sen, arg) =>
            {
                List<BoldReports.Windows.DataSourceCredentials> dataSourceCrdentials = new List<BoldReports.Windows.DataSourceCredentials>();

                foreach (var dataSource in this.ctlReport.GetDataSources())
                {
                    BoldReports.Windows.DataSourceCredentials crdentials = new BoldReports.Windows.DataSourceCredentials();
                    crdentials.Name = dataSource.Name;
                    crdentials.UserId = null;
                    crdentials.Password = null;
                    crdentials.IntegratedSecurity = true;
                    dataSourceCrdentials.Add(crdentials);
                }
                this.ctlReport.SetDataSourceCredentials(dataSourceCrdentials);
            };
            this.ctlReport.ReportServerUrl = "http://desktop-9ehfhc1/ReportServer"; //adres do serwera
            this.ctlReport.ReportServerCredential = System.Net.CredentialCache.DefaultCredentials;
            this.ctlReport.ReportPath = "/asdasd/Report1"; //The report path should be in the format of  "/folder name/report name"
            this.ctlReport.RefreshReport();

        }
    }
}
