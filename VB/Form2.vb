Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms

Namespace dxKB3226
	''' <summary>
	''' Summary description for Form2.
	''' </summary>
	Public Class Form2
		Inherits System.Windows.Forms.Form
		Public chartControl1 As DevExpress.XtraCharts.ChartControl
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.Container = Nothing

		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()

			'
			' TODO: Add any constructor code after InitializeComponent call
			'
		End Sub

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
		 Me.chartControl1 = New DevExpress.XtraCharts.ChartControl()
		 CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
		 Me.SuspendLayout()
		 ' 
		 ' chartControl1
		 ' 
		 Me.chartControl1.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)
		 Me.chartControl1.Diagram = Nothing
		 Me.chartControl1.Location = New System.Drawing.Point(8, 8)
		 Me.chartControl1.Name = "chartControl1"
		 Me.chartControl1.Size = New System.Drawing.Size(856, 440)
		 Me.chartControl1.TabIndex = 0
		 ' 
		 ' Form2
		 ' 
		 Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
		 Me.ClientSize = New System.Drawing.Size(872, 454)
		 Me.Controls.AddRange(New System.Windows.Forms.Control() { Me.chartControl1})
		 Me.Name = "Form2"
		 Me.Text = "Category, Year"
		 CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).EndInit()
		 Me.ResumeLayout(False)

		End Sub
		#End Region
	End Class
End Namespace
