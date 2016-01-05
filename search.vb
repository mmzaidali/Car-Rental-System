Imports MySql.Data.MySqlClient

Public Class search

    Dim conn As New MySqlConnection
    Dim reader As MySqlDataReader


    Private Sub search_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "server=localhost ; user='crs' ; password = 'password' ; database = 'crs' "
        Call showData()
        Call showData1()
        Call showData2()

    End Sub

    Sub showData()

        Dim query As String = "SELECT * FROM booking;"

        Dim cmd As New MySqlCommand(query, conn)


        Try

            conn.Open()
            reader = cmd.ExecuteReader

            Dim table As New DataTable
            table.Load(reader)
            DataGridView1.DataSource = table

            reader.Close()
            conn.Close()

        Catch ex As Exception
            MessageBox.Show("Error")
        End Try
    End Sub

    Sub showData1()

        Dim query As String = "SELECT * FROM car;"

        Dim cmd As New MySqlCommand(query, conn)


        Try

            conn.Open()
            reader = cmd.ExecuteReader

            Dim table As New DataTable
            table.Load(reader)
            DataGridView2.DataSource = table

            reader.Close()
            conn.Close()

        Catch ex As Exception
            MessageBox.Show("Error")
        End Try
    End Sub

    Sub showData2()

        Dim query As String = "SELECT * FROM user;"

        Dim cmd As New MySqlCommand(query, conn)


        Try

            conn.Open()
            reader = cmd.ExecuteReader

            Dim table As New DataTable
            table.Load(reader)
            DataGridView3.DataSource = table

            reader.Close()
            conn.Close()

        Catch ex As Exception
            MessageBox.Show("Error")
        End Try
    End Sub


    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim column As String = ""


        If cboColumn.SelectedIndex = 0 Then
            column = "name"
        ElseIf cboColumn.SelectedIndex = 1 Then
            column = "icNo"
        ElseIf cboColumn.SelectedIndex = 2 Then
            column = "noTel"
        ElseIf cboColumn.SelectedIndex = 3 Then
            column = "car"
        ElseIf cboColumn.SelectedIndex = 4 Then
            column = "dateStart"
        ElseIf cboColumn.SelectedIndex = 5 Then
            column = "dateEnd"
        ElseIf cboColumn.SelectedIndex = 6 Then
            column = "area"
        ElseIf cboColumn.SelectedIndex = 7 Then
            column = "status"
        ElseIf cboColumn.SelectedIndex = 8 Then
            column = "payment"
        End If


        Dim strSqlSearch As String = "SELECT * FROM booking WHERE " & column & " LIKE '%" & txtSearch.Text & "%'"


        Dim mysqlCommand As New MySqlCommand(strSqlSearch, conn)


        Try
            conn.Open()
            reader = mysqlCommand.ExecuteReader

            Dim table As New DataTable
            table.Load(reader)
            DataGridView1.DataSource = table



        Catch ex As Exception

            MsgBox("No results found.", MsgBoxStyle.OkOnly, "Car Rental System")

        Finally

            reader.Close()
            conn.Close()

        End Try


    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtSearch.Text = ""
        cboColumn.Text = ""

        Call showData()


    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        adminPage.Show()
        Me.Close()

    End Sub

    Private Sub DataGridView3_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView3.CellContentClick

    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnSearch1.Click
        Dim C As String = ""


        If cboC.SelectedIndex = 0 Then
            C = "carName"
        ElseIf cboC.SelectedIndex = 1 Then
            C = "type"
        End If


        Dim strSql As String = "SELECT * FROM car WHERE " & C & " LIKE '%" & txtSearch1.Text & "%'"


        Dim sqlCommand As New MySqlCommand(strSql, conn)


        Try
            conn.Open()
            reader = sqlCommand.ExecuteReader

            Dim table As New DataTable
            table.Load(reader)
            DataGridView2.DataSource = table



        Catch ex As Exception

            MsgBox("No results found.", MsgBoxStyle.OkOnly, "Car Rental System")

        Finally

            reader.Close()
            conn.Close()

        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtSearch1.Text = ""
        cboC.Text = ""

        Call showData1()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnSearch2.Click
        Dim pay As String = ""


        If cboPay.SelectedIndex = 0 Then
            pay = "name"
        ElseIf cboPay.SelectedIndex = 1 Then
            pay = "username"
        ElseIf cboPay.SelectedIndex = 2 Then
            pay = "password"
        ElseIf cboPay.SelectedIndex = 3 Then
            pay = "icNo"
        ElseIf cboPay.SelectedIndex = 4 Then
            pay = "noTel"
        ElseIf cboPay.SelectedIndex = 5 Then
            pay = "address"
        ElseIf cboPay.SelectedIndex = 6 Then
            pay = "email"
        End If


        Dim strPay As String = "SELECT * FROM user WHERE " & pay & " LIKE '%" & txtPay.Text & "%'"


        Dim sqlCommand As New MySqlCommand(strPay, conn)


        Try
            conn.Open()
            reader = sqlCommand.ExecuteReader

            Dim table As New DataTable
            table.Load(reader)
            DataGridView3.DataSource = table



        Catch ex As Exception

            MsgBox("No results found.", MsgBoxStyle.OkOnly, "Car Rental System")

        Finally

            reader.Close()
            conn.Close()

        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        txtPay.Text = ""
        cboPay.Text = ""

        Call showData2()
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        adminPage.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        adminPage.Show()
        Me.Close()

    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
        reportCar.Show()
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        reportBook.Show()
        Me.Close()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        reportUser.Show()
        Me.Close()
    End Sub
End Class