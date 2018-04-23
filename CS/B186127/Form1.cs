using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraScheduler;
using DevExpress.Utils;
using DevExpress.XtraScheduler.Drawing;
using DevExpress.XtraScheduler.Forms;
using DevExpress.XtraReports.UI;

namespace Sample {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            this.carSchedulingTableAdapter.Fill(this.carsDBDataSet.CarScheduling);
            schedulerControl1.Start = new DateTime(2010, 7, 10);
        }

        private void simpleButton1_Click(object sender, EventArgs e) {
            AppointmentBaseCollection aptCollection = schedulerStorage1.GetAppointments(schedulerControl1.ActiveView.GetVisibleIntervals());

            if (aptCollection.Count == 0) {
                MessageBox.Show("There are no visible Appointments");
                return;
            }

            XtraReport1 report = new XtraReport1() { SchedulerStorage = schedulerStorage1};
            report.DataSource = AppointmentsDataHelper.GenerateAppointmentsPerDay(aptCollection);
            report.ShowPreviewDialog();
        }
    }
}
