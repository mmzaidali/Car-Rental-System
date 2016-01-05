Public Class reportBook

    Private Sub reportBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'crsDataSet2.booking' table. You can move, or remove it, as needed.
        Me.bookingTableAdapter.Fill(Me.crsDataSet2.booking)
        'TODO: This line of code loads data into the 'crsDataSet.booking' table. You can move, or remove it, as needed

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Home_Click(sender As Object, e As EventArgs) Handles Home.Click
        adminPage.Show()
        Me.Close()
    End Sub
End Class