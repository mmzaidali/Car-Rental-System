Imports MySql.Data.MySqlClient

Public Class payment

    Dim conn As New MySqlConnection
    Dim reader As MySqlDataReader

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim num As Integer

        'Calculate the payment
        If txtDay.Text >= 28 And txtDay.Text <= 31 Then
            num = txtDay.Text * TextBox2.Text
        ElseIf txtDay.Text >= 7 Then
            num = (txtDay.Text * txtWeek.Text) + TextBox1.Text
        Else
            num = txtDay.Text * TextBox1.Text
        End If


        'Print total payment
        lblResult.Text = num
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        adminPage.Show()
        Me.Close()
    End Sub

    Private Sub payment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "server=localhost ; user='crs' ; password = 'password' ; database = 'crs' "
        Call showData()
        Call showData1()
        Call showData2()
    End Sub

    Sub showData()
        On Error GoTo err

        Dim query As String = "SELECT idbooking,name,car,dateStart,dateEnd,status FROM booking"

        Dim cmd As New MySqlCommand(query, conn)

        conn.Open()

        reader = cmd.ExecuteReader()

        Dim table As New DataTable
        table.Load(reader)
        DataGridView1.DataSource = table

        reader.Close()
        conn.Close()

        Exit Sub

err:
        If reader.IsClosed = False Then
            reader.Close()
            conn.Close()
        End If
        MsgBox(Err.Description, MsgBoxStyle.Exclamation, "Car Rental System")
        reader.Close()
        conn.Close()

    End Sub

    Sub showData1()

        On Error GoTo err
        Dim query As String = "SELECT carName,priceDaily,priceWeekly,priceMonthly FROM car"

        Dim cmd As New MySqlCommand(query, conn)

        conn.Open()

        reader = cmd.ExecuteReader()

        Dim table As New DataTable
        table.Load(reader)
        DataGridView2.DataSource = table

        reader.Close()
        conn.Close()

        Exit Sub

err:
        If reader.IsClosed = False Then
            reader.Close()
            conn.Close()
        End If
        MsgBox(Err.Description, MsgBoxStyle.Exclamation, "Car Rental System")
        reader.Close()
        conn.Close()
    End Sub

    Sub showData2()

        On Error GoTo err
        Dim query As String = "SELECT idbooking,depPay,fullPay FROM pay"

        Dim cmd As New MySqlCommand(query, conn)

        conn.Open()

        reader = cmd.ExecuteReader()

            Dim table As New DataTable
            table.Load(reader)
            DataGridView3.DataSource = table

            reader.Close()
            conn.Close()

        Exit Sub

err:
        If reader.IsClosed = False Then
            reader.Close()
            conn.Close()
        End If
        MsgBox(Err.Description, MsgBoxStyle.Exclamation, "Car Rental System")
        reader.Close()
        conn.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        On Error GoTo err
        Dim i As Integer

        i = DataGridView1.CurrentRow.Index

        Me.txtID.Text = DataGridView1.Item(0, i).Value

        Me.txtStart.Text = DataGridView1.Item(3, i).Value

        Me.txtEnd.Text = DataGridView1.Item(4, i).Value

        Exit Sub

err:
        If reader.IsClosed = False Then
            reader.Close()
            conn.Close()
        End If
        MsgBox(Err.Description, MsgBoxStyle.Exclamation, "Car Rental System")
        reader.Close()
        conn.Close()

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        'List variables
        Dim dtmDate1 As Date
        Dim dtmDate2 As Date
        Dim intDays As Integer

        'Reassign variable names
        dtmDate1 = CDate(txtStart.Text)
        dtmDate2 = CDate(txtEnd.Text)
        intDays = DateDiff("d", dtmDate1, dtmDate2)

        'Print output
        txtDay.Text = intDays

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        On Error GoTo err
        Dim update As String = "insert into pay (idbooking,depPay) values ('" & txtID.Text & "','" & dep.Text & "')"

        Dim cmd As New MySqlCommand(update, conn)

        conn.Open()
        reader = cmd.ExecuteReader()

        reader.Close()
        conn.Close()

        Call showData2()

        txtID.Text = ""
        txtCar.Text = ""
        txtStart.Text = ""
        txtEnd.Text = ""
        lblResult.Text = ""
        txtDay.Text = ""
        dep.Text = ""
        cash.Text = ""
        lblBal.Text = ""
        TextBox1.Text = ""
        TextBox2.Text = ""
        txtWeek.Text = ""
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

    Private Sub btnPaid_Click(sender As Object, e As EventArgs) Handles btnPaid.Click

        Dim Update As String = "update pay set fullPay = '" & cash.Text & "' where idbooking = '" & txtID.Text & "'"

        Dim cmd As New MySqlCommand(Update, conn)

        conn.Open()
        reader = cmd.ExecuteReader()

        reader.Close()
        conn.Close()

        Call showData2()

        txtID.Text = ""
        txtCar.Text = ""
        txtStart.Text = ""
        txtEnd.Text = ""
        lblResult.Text = ""
        txtDay.Text = ""
        dep.Text = ""
        cash.Text = ""
        lblBal.Text = ""
        TextBox1.Text = ""
        TextBox2.Text = ""
        txtWeek.Text = ""
    End Sub

    Private Sub btnBal_Click(sender As Object, e As EventArgs) Handles btnBal.Click

        Dim balance As Integer
        'calculate the balance
        balance = lblResult.Text - dep.Text

        'Print balance payment
        lblBal.Text = balance
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        On Error GoTo err

        Dim i As Integer

        i = DataGridView2.CurrentRow.Index

        Me.txtCar.Text = DataGridView2.Item(0, i).Value

        Me.TextBox1.Text = DataGridView2.Item(1, i).Value

        Me.txtWeek.Text = DataGridView2.Item(2, i).Value

        Me.TextBox2.Text = DataGridView2.Item(3, i).Value

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

    Private Sub DataGridView3_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView3.CellContentClick
        On Error GoTo err

        Dim i As Integer

        i = DataGridView3.CurrentRow.Index

        Me.dep.Text = DataGridView3.Item(1, i).Value

        Me.cash.Text = DataGridView3.Item(2, i).Value

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