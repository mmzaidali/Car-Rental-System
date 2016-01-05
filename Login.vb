Imports MySql.Data.MySqlClient

Public Class Login

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
        Dim query1 As String = "SELECT username,password FROM user WHERE username = '" & txtUser.Text & "' and password = '" & txtPass.Text & "'"
        Dim cmd As New MySqlCommand(query1, conn)
        cmd.Connection = conn
        conn.Open()
        reader = cmd.ExecuteReader

        If reader.HasRows Then
            MsgBox("Login Successful !", MsgBoxStyle.Information, "Car Rental System")
            user.Show()
            Me.Visible = False
            txtUser.Text = ""
            txtPass.Text = ""
        Else
            MsgBox("Invalid username or password !" & vbNewLine.ToLower & "Please register if you are not our members.", MsgBoxStyle.Exclamation, "Car Rental System")
        End If

        reader.Close()
        conn.Close()

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Visible = False
        Main.Show()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "server=localhost ; user='crs' ; password = 'password' ; database = 'crs' "
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        MsgBox("Please contact Admin HelpLine" & vbNewLine.ToLower & "Thank You.", MsgBoxStyle.Information, "Car Rental System")
    End Sub
End Class
