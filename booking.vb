Imports MySql.Data.MySqlClient

Public Class booking

    Dim conn As New MySqlConnection
    Dim reader As MySqlDataReader

    Private Sub booking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.txtName.Text = user.lblUser.Text

        conn.ConnectionString = "server=localhost ; user='crs' ; password = 'password' ; database = 'crs' "

        Dim pull As String = "SELECT name,icNo,noTel FROM user WHERE username = '" & txtName.Text & "'"

        Dim comm As New MySqlCommand(pull, conn)

        conn.Open()
        reader = comm.ExecuteReader()

        If reader.HasRows Then
            reader.Read()
            txtName.Text = reader("name")
            txtIC.Text = reader("icNo")
            txtPhone.Text = reader("noTel")
        End If

        reader.Close()
        conn.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        On Error GoTo err

        Dim Cars As String = ""

        If cboCars.SelectedIndex = 1 Then
            Cars = "Viva"
        ElseIf cboCars.SelectedIndex = 2 Then
            Cars = "Viva Elite"
        ElseIf cboCars.SelectedIndex = 3 Then
            Cars = "Myvi"
        ElseIf cboCars.SelectedIndex = 4 Then
            Cars = "Myvi SE"
        ElseIf cboCars.SelectedIndex = 5 Then
            Cars = "Satria Neo"
        ElseIf cboCars.SelectedIndex = 6 Then
            Cars = "Suprima"
        ElseIf cboCars.SelectedIndex = 7 Then
            Cars = "Kia Rio"
        ElseIf cboCars.SelectedIndex = 8 Then
            Cars = "Jazz Hybrid"
        ElseIf cboCars.SelectedIndex = 9 Then
            Cars = "CR-Z Hybrid"
        ElseIf cboCars.SelectedIndex = 10 Then
            Cars = "Peugeot 308"
        ElseIf cboCars.SelectedIndex = 13 Then
            Cars = "Saga SV"
        ElseIf cboCars.SelectedIndex = 14 Then
            Cars = "Vios TRD"
        ElseIf cboCars.SelectedIndex = 15 Then
            Cars = "Preve"
        ElseIf cboCars.SelectedIndex = 16 Then
            Cars = "Honda City"
        ElseIf cboCars.SelectedIndex = 19 Then
            Cars = "Volkswagen Combi"
        ElseIf cboCars.SelectedIndex = 20 Then
            Cars = "Exora"
        ElseIf cboCars.SelectedIndex = 21 Then
            Cars = "Wish"
        ElseIf cboCars.SelectedIndex = 22 Then
            Cars = "Alza"
        ElseIf cboCars.SelectedIndex = 23 Then
            Cars = "Avanza"
        ElseIf cboCars.SelectedIndex = 24 Then
            Cars = "Alphard"
        End If



        Dim query1 As String = "insert into booking (name , icNo , noTel , car , dateStart , dateEnd , area) values ('" & txtName.Text & "','" & txtIC.Text & "','" & txtPhone.Text & "','" & Cars & "','" + dateStart.Text + "','" + dateEnd.Text + "','" & CheckArea.Text & "')"
        Dim cmd As New MySqlCommand(query1, conn)

        conn.Open()
        reader = cmd.ExecuteReader()

        reader.Close()
        conn.Close()
        Me.Dispose()
        MsgBox("Do the payment while pickup the car. Thank You.", MsgBoxStyle.Information, "Car Rental System")
        user.Show()

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

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Dispose()
        user.Show()
    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged

    End Sub

    Private Sub cboCars_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCars.SelectedIndexChanged

    End Sub
End Class
