Imports MySql.Data.MySqlClient

Public Class user

    Dim conn As New MySqlConnection
    Dim reader As MySqlDataReader

    Private Sub user_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "server=localhost ; user='crs' ; password = 'password' ; database = 'crs' "
        lblUser.Text = Login.txtUser.Text
    End Sub

    Private Sub btnBook_Click(sender As Object, e As EventArgs) Handles btnBook.Click
        booking.Show()
        Me.Hide()
    End Sub

    Private Sub btnCar_Click(sender As Object, e As EventArgs) Handles btnCar.Click
        car.Show()
        Me.Hide()
    End Sub

    Private Sub btnLog_Click(sender As Object, e As EventArgs) Handles btnLog.Click
        Main.Show()
        Me.Close()
    End Sub

    Private Sub btnArea_Click(sender As Object, e As EventArgs) Handles btnArea.Click
        area.Show()
        Me.Hide()
    End Sub
End Class