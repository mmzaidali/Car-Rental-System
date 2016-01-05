Public Class reportCar

    Private Sub reportCar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'crsDataSet2.car' table. You can move, or remove it, as needed.
        Me.carTableAdapter.Fill(Me.crsDataSet2.car)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub home_Click(sender As Object, e As EventArgs) Handles home.Click
        adminPage.Show()
        Me.Close()
    End Sub
End Class