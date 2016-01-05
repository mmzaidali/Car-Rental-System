<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class reportBook
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.bookingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.crsDataSet2 = New bengkel.crsDataSet2()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Home = New System.Windows.Forms.Button()
        Me.bookingTableAdapter = New bengkel.crsDataSet2TableAdapters.bookingTableAdapter()
        CType(Me.bookingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.crsDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bookingBindingSource
        '
        Me.bookingBindingSource.DataMember = "booking"
        Me.bookingBindingSource.DataSource = Me.crsDataSet2
        '
        'crsDataSet2
        '
        Me.crsDataSet2.DataSetName = "crsDataSet2"
        Me.crsDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.bookingBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "bengkel.Report2.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(78, 102)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1152, 409)
        Me.ReportViewer1.TabIndex = 0
        '
        'Home
        '
        Me.Home.Font = New System.Drawing.Font("Minion Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Home.Location = New System.Drawing.Point(695, 534)
        Me.Home.Name = "Home"
        Me.Home.Size = New System.Drawing.Size(75, 32)
        Me.Home.TabIndex = 1
        Me.Home.Text = "HOME"
        Me.Home.UseVisualStyleBackColor = True
        '
        'bookingTableAdapter
        '
        Me.bookingTableAdapter.ClearBeforeFill = True
        '
        'reportBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.bengkel.My.Resources.Resources.water_curve_chairs
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.Home)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "reportBook"
        Me.Text = "reportBook"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.bookingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.crsDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Home As System.Windows.Forms.Button
    Friend WithEvents bookingBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents crsDataSet2 As bengkel.crsDataSet2
    Friend WithEvents bookingTableAdapter As bengkel.crsDataSet2TableAdapters.bookingTableAdapter
End Class
