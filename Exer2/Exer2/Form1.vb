Imports MySql.Data.MySqlClient
Public Class Form1

    Dim con As New MySqlConnection("server=localhost;user=root;password=;database=adfcdb1")

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Welcome " + Module1.user

        Dim conn As New MySqlConnection("server=localhost;user=root;password=;database=adfcdb1")

        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable

        Dim cmd As New MySqlCommand
        Dim sql As String

        sql = "select * from student"

        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open()

        With cmd
            .Connection = conn
            .CommandText = sql
        End With

        da.SelectCommand = cmd
        da.Fill(dt)
        Me.DataGridView1.DataSource = dt
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim log As New frmlogin
        log.Show()
        Me.Hide()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex >= 0 Then
            Try
                ' Get the selected row index
                Dim rowIndex As Integer = e.RowIndex

                ' Update the text fields with the data from the selected row
                txtSId.Text = DataGridView1.Rows(rowIndex).Cells(0).Value.ToString()
                txtFName.Text = DataGridView1.Rows(rowIndex).Cells(1).Value.ToString()
                txtLName.Text = DataGridView1.Rows(rowIndex).Cells(2).Value.ToString()
                txtMName.Text = DataGridView1.Rows(rowIndex).Cells(3).Value.ToString()
                ExName.Text = DataGridView1.Rows(rowIndex).Cells(4).Value.ToString()
                Bday.Text = DataGridView1.Rows(rowIndex).Cells(5).Value.ToString()
                txtAge.Text = DataGridView1.Rows(rowIndex).Cells(6).Value.ToString()
                cbGender.Text = DataGridView1.Rows(rowIndex).Cells(7).Value.ToString()
                txtAddress.Text = DataGridView1.Rows(rowIndex).Cells(8).Value.ToString()
                cbCourse.Text = DataGridView1.Rows(rowIndex).Cells(9).Value.ToString()
                cbyrlevel.Text = DataGridView1.Rows(rowIndex).Cells(10).Value.ToString()

                ' Show the selected row index in a message box
                MessageBox.Show("Selected Row Index: " & rowIndex.ToString(), "Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
End Class
