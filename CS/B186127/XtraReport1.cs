using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.XtraScheduler;

namespace Sample {
    public partial class XtraReport1 : DevExpress.XtraReports.UI.XtraReport {
        public XtraReport1() {
            InitializeComponent();
        }

        int day = 0;
        public SchedulerStorage SchedulerStorage { get; set; }

        private void AptTimeLabel_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e) {
            Appointment apt = GetCurrentRow() as Appointment;
            XRLabel label = sender as XRLabel;

            label.Text = apt.AllDay ? "All day" : label.Text = string.Format("{0} - {1}", apt.Start.ToShortTimeString(), apt.End.ToShortTimeString());
        }

        private void AptDescriptionLabel_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e) {
            Appointment apt = GetCurrentRow() as Appointment;
            
            XRLabel label = sender as XRLabel;
            label.Text = string.Format("{0} {1}\n{2}", apt.Subject, apt.Location, apt.Description);
            label.BackColor = SchedulerStorage.GetLabelColor(apt.LabelId);
        }
        
        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e) {
            day = Convert.ToDateTime(GetCurrentColumnValue("Start")).Day;
        }

        private void GroupHeader1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e) {
            e.Cancel = day == Convert.ToDateTime(GetCurrentColumnValue("Start")).Day;
        }
    }
}
