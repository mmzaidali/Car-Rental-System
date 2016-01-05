Imports MySql.Data.MySqlClient

Public Class approve

    Dim conn As New MySqlConnection
    Dim reader As MySqlDataReader

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        adminPage.Show()
        Me.Close()
    End Sub

    Private Sub approve_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "server=localhost ; user='crs' ; password = 'password' ; database = 'crs' "
        Call showData()
    End Sub

    Sub showData()

        Dim query As String = "SELECT idbooking,name,car,dateStart,dateEnd,status FROM booking"

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

    Private Sub btnApp_Click(sender As Object, e As EventArgs) Handles btnApp.Click
        Dim S As String = ""

        If cboS.SelectedIndex = 1 Then
            S = "Picked"
        ElseIf cboS.SelectedIndex = 2 Then
            S = "Returned"
        End If

        Dim query2 As String = "update booking set status = '" & cboS.Text & "'  where idbooking = '" & txtID.Text & "'"

        Dim cmd As New MySqlCommand(query2, conn)

        conn.Open()
        reader = cmd.ExecuteReader()

        reader.Close()
        conn.Close()

        Call showData()

        txtID.Text = ""
        cboS.Text = "- - - -"
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        On Error GoTo err
        Dim i As Integer

        i = DataGridView1.CurrentRow.Index

        Me.txtID.Text = DataGridView1.Item(0, i).Value

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
End Class