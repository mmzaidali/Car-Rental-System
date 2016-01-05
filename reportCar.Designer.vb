<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class reportCar
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
        Me.carBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.crsDataSet2 = New bengkel.crsDataSet2()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.home = New System.Windows.Forms.Button()
        Me.carTableAdapter = New bengkel.crsDataSet2TableAdapters.carTableAdapter()
        CType(Me.carBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.crsDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'carBindingSource
        '
        Me.carBindingSource.DataMember = "car"
        Me.carBindingSource.DataSource = Me.crsDataSet2
        '
        'crsDataSet2
        '
        Me.crsDataSet2.DataSetName = "crsDataSet2"
        Me.crsDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.carBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "bengkel.Report3.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(101, 136)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(984, 364)
        Me.ReportViewer1.TabIndex = 0
        '
        'home
        '
        Me.home.Font = New System.Drawing.Font("Minion Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.home.Location = New System.Drawing.Point(493, 530)
        Me.home.Name = "home"
        Me.home.Size = New System.Drawing.Size(94, 36)
        Me.home.TabIndex = 1
        Me.home.Text = "HOME"
        Me.home.UseVisualStyleBackColor = True
        '
        'carTableAdapter
        '
        Me.carTableAdapter.ClearBeforeFill = True
        '
        'reportCar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.bengkel.My.Resources.Resources.water_curve_chairs
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.home)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "reportCar"
        Me.Text = "reportCar"
        CType(Me.carBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.crsDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents home As System.Windows.Forms.Button
    Friend WithEvents carBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents crsDataSet2 As bengkel.crsDataSet2
    Friend WithEvents carTableAdapter As bengkel.crsDataSet2TableAdapters.carTableAdapter
End Class
