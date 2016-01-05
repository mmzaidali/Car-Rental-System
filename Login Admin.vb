Imports MySql.Data.MySqlClient

Public Class Login_Admin

    Dim conn As New MySqlConnection
    Dim reader As MySqlDataReader

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        conn.ConnectionString = "server=localhost ; user='crs' ; password = 'password' ; database = 'crs' "

        Dim query1 As String = "SELECT staff,pass FROM admin WHERE staff = '" & txtStaff.Text & "' and pass = '" & txtPass.Text & "'"
        Dim cmd As New MySqlCommand(query1, conn)
        cmd.Connection = conn
        conn.Open()
        reader = cmd.ExecuteReader

        If reader.HasRows Then
            MsgBox("Login Successful !", MsgBoxStyle.Information, "Car Rental System")
            adminPage.Show()
            Me.Visible = False
            txtStaff.Text = ""
            txtPass.Text = ""
        Else
            MsgBox("Invalid username or password !", MsgBoxStyle.Critical)
        End If

        reader.Close()
        conn.Close()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Main.Show()
        Me.Close()
    End Sub

End Class
