Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraScheduler
Imports DevExpress.Utils
Imports DevExpress.XtraScheduler.Drawing
Imports DevExpress.XtraScheduler.Forms
Imports DevExpress.XtraReports.UI

Namespace Sample
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            Me.carSchedulingTableAdapter.Fill(Me.carsDBDataSet.CarScheduling)
            schedulerControl1.Start = New Date(2010, 7, 10)
        End Sub

        Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton1.Click
            Dim aptCollection As AppointmentBaseCollection = schedulerStorage1.GetAppointments(schedulerControl1.ActiveView.GetVisibleIntervals())

            If aptCollection.Count = 0 Then
                MessageBox.Show("There are no visible Appointments")
                Return
            End If

            Dim report As New XtraReport1() With {.SchedulerStorage = schedulerStorage1}
            report.DataSource = AppointmentsDataHelper.GenerateAppointmentsPerDay(aptCollection)
            report.ShowPreviewDialog()
        End Sub
    End Class
End Namespace
