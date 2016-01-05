Imports MySql.Data.MySqlClient

Public Class register

    Dim conn As New MySqlConnection
    Dim reader As MySqlDataReader

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        On Error GoTo err
        Dim query1 As String = "insert into user (name , username , password , icNo , noTel , address , email) values ('" & txtName.Text & "','" & txtUser.Text & "','" & txtPassword.Text & "','" & txtIC.Text & "','" & txtTel.Text & "','" & txtAddress.Text & "','" & txtMail.Text & "')"

        Dim cmd As New MySqlCommand(query1, conn)




        conn.Open()
        reader = cmd.ExecuteReader()

        reader.Close()
        conn.Close()
        Me.Close()
        MsgBox("WELCOME AS OUR MEMBER !", MsgBoxStyle.Information, "Car Rental System")
        Main.Show()

        Exit Sub

err:
        If reader.IsClosed = False Then
            reader.Close()
            conn.Close()
        End If
        MsgBox(Err.Description)
        reader.Close()
        conn.Close()
    End Sub

    Private Sub linkQ_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkQ.LinkClicked

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Main.Show()
        Me.Close()
    End Sub

    Private Sub register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "server=localhost ; user='crs' ; password = 'password' ; database = 'crs' "
    End Sub
End Class