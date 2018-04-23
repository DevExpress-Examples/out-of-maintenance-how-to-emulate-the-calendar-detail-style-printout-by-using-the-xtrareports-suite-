Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraScheduler

Namespace Sample
	Partial Public Class XtraReport1
		Inherits DevExpress.XtraReports.UI.XtraReport
		Public Sub New()
			InitializeComponent()
		End Sub

		Private day As Integer = 0
		Private privateSchedulerStorage As SchedulerStorage
		Public Property SchedulerStorage() As SchedulerStorage
			Get
				Return privateSchedulerStorage
			End Get
			Set(ByVal value As SchedulerStorage)
				privateSchedulerStorage = value
			End Set
		End Property

		Private Sub AptTimeLabel_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles AptTimeLabel.BeforePrint
			Dim apt As Appointment = TryCast(GetCurrentRow(), Appointment)
			Dim label As XRLabel = TryCast(sender, XRLabel)

            If (apt.AllDay) Then
                label.Text = "All day"
            Else
                label.Text = String.Format("{0} - {1}", apt.Start.ToShortTimeString(), apt.End.ToShortTimeString())
            End If
        End Sub

		Private Sub AptDescriptionLabel_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles AptDescriptionLabel.BeforePrint
			Dim apt As Appointment = TryCast(GetCurrentRow(), Appointment)

			Dim label As XRLabel = TryCast(sender, XRLabel)
			label.Text = String.Format("{0} {1}" & Constants.vbLf & "{2}", apt.Subject, apt.Location, apt.Description)
			label.BackColor = SchedulerStorage.GetLabelColor(apt.LabelId)
		End Sub

		Private Sub Detail_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles Detail.BeforePrint
			day = Convert.ToDateTime(GetCurrentColumnValue("Start")).Day
		End Sub

		Private Sub GroupHeader1_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles GroupHeader1.BeforePrint
			e.Cancel = day = Convert.ToDateTime(GetCurrentColumnValue("Start")).Day
		End Sub
	End Class
End Namespace
