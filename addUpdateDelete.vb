Imports MySql.Data.MySqlClient

Public Class addUpdateDelete

    Dim conn As New MySqlConnection
    Dim reader As MySqlDataReader

    Private Sub addUpdateDelete_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "server=localhost ; user='crs' ; password = 'password' ; database = 'crs' "

        Call showData()
    End Sub

    Sub showData()

        Dim query As String = "SELECT * FROM car "

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

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        On Error GoTo err

        Dim i As Integer

        i = DataGridView1.CurrentRow.Index

        Me.txtID.Text = DataGridView1.Item(0, i).Value

        Me.txtName.Text = DataGridView1.Item(1, i).Value

        Me.txtType.Text = DataGridView1.Item(2, i).Value

        Me.priceD.Text = DataGridView1.Item(3, i).Value

        Me.txtWeek.Text = DataGridView1.Item(4, i).Value

        Me.priceM.Text = DataGridView1.Item(5, i).Value

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

    Private Sub BackToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.Dispose()
        adminPage.Show()
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.Dispose()
        MsgBox("You are logged out.", MsgBoxStyle.Information, "Car Rental System")
        Main.Show()
    End Sub

    Private Sub btnUpdate_Click_1(sender As Object, e As EventArgs) Handles btnUpdate.Click
        On Error GoTo err
        Dim query2 As String = "update car set type = '" & txtType.Text & "', carName ='" & txtName.Text & "', priceDaily = '" & priceD.Text & "',priceWeekly = '" & txtWeek.Text & "', priceMonthly = '" & priceM.Text & "' where idcar = '" & txtID.Text & "'"

        Dim cmd As New MySqlCommand(query2, conn)

        conn.Open()
        reader = cmd.ExecuteReader()

        reader.Close()
        conn.Close()

        Call showData()

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

    Private Sub btnAdd_Click_1(sender As Object, e As EventArgs) Handles btnAdd.Click
        On Error GoTo err
        Dim query1 As String = "insert into car (carName , type, priceDaily, priceWeekly, priceMonthly) values ('" & txtName.Text & "','" & txtType.Text & "','" & priceD.Text & "','" & txtWeek.Text & "','" & priceM.Text & "')"

        Dim cmd As New MySqlCommand(query1, conn)

        conn.Open()
        reader = cmd.ExecuteReader()

        reader.Close()
        conn.Close()

        Call showData()

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

    Private Sub btnDelete_Click_1(sender As Object, e As EventArgs) Handles btnDelete.Click
        On Error GoTo err

        Dim query3 As String = "delete from car where idcar = '" & txtID.Text & "'"

        Dim cmd As New MySqlCommand(query3, conn)




        conn.Open()
        reader = cmd.ExecuteReader()

        reader.Close()
        conn.Close()

        Call showData()

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

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        adminPage.Show()
        Me.Close()
    End Sub
End Class