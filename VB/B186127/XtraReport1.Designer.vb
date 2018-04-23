Imports DevExpress.XtraScheduler
Namespace Sample
    Partial Public Class XtraReport1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.AptDescriptionLabel = New DevExpress.XtraReports.UI.XRLabel()
            Me.AptTimeLabel = New DevExpress.XtraReports.UI.XRLabel()
            Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
            Me.DayOfWeekLabel = New DevExpress.XtraReports.UI.XRLabel()
            Me.DateLabel = New DevExpress.XtraReports.UI.XRLabel()
            Me.bindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
            DirectCast(Me.bindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' Detail
            ' 
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.AptDescriptionLabel, Me.AptTimeLabel})
            Me.Detail.HeightF = 46.87503F
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' AptDescriptionLabel
            ' 
            Me.AptDescriptionLabel.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
            Me.AptDescriptionLabel.LocationFloat = New DevExpress.Utils.PointFloat(132.2917F, 10.00001F)
            Me.AptDescriptionLabel.Multiline = True
            Me.AptDescriptionLabel.Name = "AptDescriptionLabel"
            Me.AptDescriptionLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 2, 0, 0, 100F)
            Me.AptDescriptionLabel.SizeF = New System.Drawing.SizeF(517.7083F, 23F)
            Me.AptDescriptionLabel.StylePriority.UseBorders = False
            Me.AptDescriptionLabel.StylePriority.UsePadding = False
            Me.AptDescriptionLabel.Text = "Description"
            ' 
            ' AptTimeLabel
            ' 
            Me.AptTimeLabel.Font = New System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(204)))
            Me.AptTimeLabel.LocationFloat = New DevExpress.Utils.PointFloat(0F, 10.00001F)
            Me.AptTimeLabel.Name = "AptTimeLabel"
            Me.AptTimeLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.AptTimeLabel.SizeF = New System.Drawing.SizeF(132.2917F, 23F)
            Me.AptTimeLabel.StylePriority.UseFont = False
            Me.AptTimeLabel.Text = "Time"
            ' 
            ' TopMargin
            ' 
            Me.TopMargin.Name = "TopMargin"
            Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' BottomMargin
            ' 
            Me.BottomMargin.Name = "BottomMargin"
            Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' GroupHeader1
            ' 
            Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.DayOfWeekLabel, Me.DateLabel})
            Me.GroupHeader1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() { New DevExpress.XtraReports.UI.GroupField("Start", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
            Me.GroupHeader1.HeightF = 61.45833F
            Me.GroupHeader1.Name = "GroupHeader1"
            ' 
            ' DayOfWeekLabel
            ' 
            Me.DayOfWeekLabel.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Start", "{0:dddd}")})
            Me.DayOfWeekLabel.Font = New System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
            Me.DayOfWeekLabel.LocationFloat = New DevExpress.Utils.PointFloat(221.8749F, 29.24999F)
            Me.DayOfWeekLabel.Name = "DayOfWeekLabel"
            Me.DayOfWeekLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.DayOfWeekLabel.SizeF = New System.Drawing.SizeF(197.9167F, 29.25F)
            Me.DayOfWeekLabel.StylePriority.UseFont = False
            Me.DayOfWeekLabel.StylePriority.UseTextAlignment = False
            Me.DayOfWeekLabel.Text = "[Start]"
            Me.DayOfWeekLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
            ' 
            ' DateLabel
            ' 
            Me.DateLabel.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Start", "{0:dd MMMM, yyyy}")})
            Me.DateLabel.Font = New System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
            Me.DateLabel.LocationFloat = New DevExpress.Utils.PointFloat(221.875F, 0F)
            Me.DateLabel.Name = "DateLabel"
            Me.DateLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.DateLabel.SizeF = New System.Drawing.SizeF(197.9166F, 29.25F)
            Me.DateLabel.StylePriority.UseFont = False
            Me.DateLabel.StylePriority.UseTextAlignment = False
            Me.DateLabel.Text = "[Start]"
            Me.DateLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
            ' 
            ' bindingSource1
            ' 
            Me.bindingSource1.DataSource = GetType(DevExpress.XtraScheduler.AppointmentBaseCollection)
            ' 
            ' XtraReport1
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.TopMargin, Me.BottomMargin, Me.GroupHeader1})
            Me.DataSource = Me.bindingSource1
            Me.Version = "11.1"
            DirectCast(Me.bindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub

        #End Region

        Private WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
        Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand
        Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
        Private bindingSource1 As System.Windows.Forms.BindingSource
        Private WithEvents AptDescriptionLabel As DevExpress.XtraReports.UI.XRLabel
        Private WithEvents AptTimeLabel As DevExpress.XtraReports.UI.XRLabel
        Private WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
        Private DayOfWeekLabel As DevExpress.XtraReports.UI.XRLabel
        Private DateLabel As DevExpress.XtraReports.UI.XRLabel
    End Class
End Namespace
