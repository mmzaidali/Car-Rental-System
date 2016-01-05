Imports MySql.Data.MySqlClient

Public Class adminPage

    Dim conn As New MySqlConnection
    Dim reader As MySqlDataReader

    Private Sub CarToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles CarToolStripMenuItem4.Click
        Me.Dispose()
        addUpdateDelete.Show()
    End Sub

    Private Sub CarToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles CarToolStripMenuItem5.Click
        Me.Dispose()
        addUpdateDelete.Show()
    End Sub

    Private Sub CarToolStripMenuItem6_Click(sender As Object, e As EventArgs) Handles CarToolStripMenuItem6.Click
        Me.Dispose()
        addUpdateDelete.Show()
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        Me.Close()
        MessageBox.Show("You are logged out. Thank you")
        Main.Show()
    End Sub

    Private Sub PaymentToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles PaymentToolStripMenuItem2.Click
        Me.Dispose()
        payment.Show()
    End Sub

    Private Sub BookingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BookingToolStripMenuItem.Click
        Me.Dispose()
        search.Show()
    End Sub

    Private Sub adminPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "server=localhost ; user='crs' ; password = 'password' ; database = 'crs' "
        Call showData()
    End Sub

    Sub showData()

        Dim query As String = "SELECT  idbooking,name,car,dateStart,dateEnd,status FROM booking"

        Dim cmd As New MySqlCommand(query, conn)


        Try

            conn.Open()

            reader = cmd.ExecuteReader()

            Dim table As New DataTable
            table.Load(reader)
            DataGridView1.DataSource = table

            reader.Close()
            conn.Close()

        Catch ex As Exception
            MessageBox.Show("Error")
        End Try
    End Sub

    Private Sub CarToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles CarToolStripMenuItem3.Click
        Me.Dispose()
        search.Show()
    End Sub

    Private Sub PaymentToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PaymentToolStripMenuItem1.Click
        Me.Dispose()
        search.Show()
    End Sub

    Private Sub CheckToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckToolStripMenuItem.Click
        Me.Dispose()
        approve.Show()
    End Sub
End Class