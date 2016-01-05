<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class reportUser
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
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.crsDataSet2 = New bengkel.crsDataSet2()
        Me.userBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.userTableAdapter = New bengkel.crsDataSet2TableAdapters.userTableAdapter()
        CType(Me.crsDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.userBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource3.Name = "DataSet1"
        ReportDataSource3.Value = Me.userBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "bengkel.Report4.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(92, 118)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1133, 424)
        Me.ReportViewer1.TabIndex = 0
        '
        'btnHome
        '
        Me.btnHome.Font = New System.Drawing.Font("Minion Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHome.Location = New System.Drawing.Point(660, 561)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(89, 33)
        Me.btnHome.TabIndex = 1
        Me.btnHome.Text = "HOME"
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'crsDataSet2
        '
        Me.crsDataSet2.DataSetName = "crsDataSet2"
        Me.crsDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'userBindingSource
        '
        Me.userBindingSource.DataMember = "user"
        Me.userBindingSource.DataSource = Me.crsDataSet2
        '
        'userTableAdapter
        '
        Me.userTableAdapter.ClearBeforeFill = True
        '
        'reportUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.bengkel.My.Resources.Resources.water_curve_chairs
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "reportUser"
        Me.Text = "reportUser"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.crsDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.userBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents btnHome As System.Windows.Forms.Button
    Friend WithEvents userBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents crsDataSet2 As bengkel.crsDataSet2
    Friend WithEvents userTableAdapter As bengkel.crsDataSet2TableAdapters.userTableAdapter
End Class
