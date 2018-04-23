using DevExpress.XtraScheduler;
namespace Sample {
    partial class XtraReport1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.AptDescriptionLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.AptTimeLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.DayOfWeekLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.DateLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.AptDescriptionLabel,
            this.AptTimeLabel});
            this.Detail.HeightF = 46.87503F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.Detail.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.Detail_BeforePrint);
            // 
            // AptDescriptionLabel
            // 
            this.AptDescriptionLabel.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
                        | DevExpress.XtraPrinting.BorderSide.Right)
                        | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.AptDescriptionLabel.LocationFloat = new DevExpress.Utils.PointFloat(132.2917F, 10.00001F);
            this.AptDescriptionLabel.Multiline = true;
            this.AptDescriptionLabel.Name = "AptDescriptionLabel";
            this.AptDescriptionLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 2, 0, 0, 100F);
            this.AptDescriptionLabel.SizeF = new System.Drawing.SizeF(517.7083F, 23F);
            this.AptDescriptionLabel.StylePriority.UseBorders = false;
            this.AptDescriptionLabel.StylePriority.UsePadding = false;
            this.AptDescriptionLabel.Text = "Description";
            this.AptDescriptionLabel.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.AptDescriptionLabel_BeforePrint);
            // 
            // AptTimeLabel
            // 
            this.AptTimeLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AptTimeLabel.LocationFloat = new DevExpress.Utils.PointFloat(0F, 10.00001F);
            this.AptTimeLabel.Name = "AptTimeLabel";
            this.AptTimeLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.AptTimeLabel.SizeF = new System.Drawing.SizeF(132.2917F, 23F);
            this.AptTimeLabel.StylePriority.UseFont = false;
            this.AptTimeLabel.Text = "Time";
            this.AptTimeLabel.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.AptTimeLabel_BeforePrint);
            // 
            // TopMargin
            // 
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.DayOfWeekLabel,
            this.DateLabel});
            this.GroupHeader1.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("Start", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader1.HeightF = 61.45833F;
            this.GroupHeader1.Name = "GroupHeader1";
            this.GroupHeader1.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.GroupHeader1_BeforePrint);
            // 
            // DayOfWeekLabel
            // 
            this.DayOfWeekLabel.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Start", "{0:dddd}")});
            this.DayOfWeekLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DayOfWeekLabel.LocationFloat = new DevExpress.Utils.PointFloat(221.8749F, 29.24999F);
            this.DayOfWeekLabel.Name = "DayOfWeekLabel";
            this.DayOfWeekLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.DayOfWeekLabel.SizeF = new System.Drawing.SizeF(197.9167F, 29.25F);
            this.DayOfWeekLabel.StylePriority.UseFont = false;
            this.DayOfWeekLabel.StylePriority.UseTextAlignment = false;
            this.DayOfWeekLabel.Text = "[Start]";
            this.DayOfWeekLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // DateLabel
            // 
            this.DateLabel.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Start", "{0:dd MMMM, yyyy}")});
            this.DateLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateLabel.LocationFloat = new DevExpress.Utils.PointFloat(221.875F, 0F);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.DateLabel.SizeF = new System.Drawing.SizeF(197.9166F, 29.25F);
            this.DateLabel.StylePriority.UseFont = false;
            this.DateLabel.StylePriority.UseTextAlignment = false;
            this.DateLabel.Text = "[Start]";
            this.DateLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(DevExpress.XtraScheduler.AppointmentBaseCollection);
            // 
            // XtraReport1
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.GroupHeader1});
            this.DataSource = this.bindingSource1;
            this.Version = "11.1";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DevExpress.XtraReports.UI.XRLabel AptDescriptionLabel;
        private DevExpress.XtraReports.UI.XRLabel AptTimeLabel;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
        private DevExpress.XtraReports.UI.XRLabel DayOfWeekLabel;
        private DevExpress.XtraReports.UI.XRLabel DateLabel;
    }
}
