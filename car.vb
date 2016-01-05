Imports MySql.Data.MySqlClient

Public Class car
    Dim conn As New MySqlConnection
    Dim reader As MySqlDataReader

    Private Sub btnHome_Click_1(sender As Object, e As EventArgs) Handles btnHome.Click
        user.Show()
        Me.Close()
    End Sub
End Class