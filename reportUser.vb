Public Class reportUser

    Private Sub reportUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'crsDataSet2.user' table. You can move, or remove it, as needed.
        Me.userTableAdapter.Fill(Me.crsDataSet2.user)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        adminPage.Show()
        Me.Close()
    End Sub
End Class