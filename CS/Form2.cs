using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace dxKB3226
{
	/// <summary>
	/// Summary description for Form2.
	/// </summary>
	public class Form2 : System.Windows.Forms.Form
	{
		public DevExpress.XtraCharts.ChartControl chartControl1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form2()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
         this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
         ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
         this.SuspendLayout();
         // 
         // chartControl1
         // 
         this.chartControl1.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right);
         this.chartControl1.Diagram = null;
         this.chartControl1.Location = new System.Drawing.Point(8, 8);
         this.chartControl1.Name = "chartControl1";
         this.chartControl1.Size = new System.Drawing.Size(856, 440);
         this.chartControl1.TabIndex = 0;
         // 
         // Form2
         // 
         this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
         this.ClientSize = new System.Drawing.Size(872, 454);
         this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                      this.chartControl1});
         this.Name = "Form2";
         this.Text = "Category, Year";
         ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
         this.ResumeLayout(false);

      }
		#endregion
	}
}
