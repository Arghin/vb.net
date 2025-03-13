Imports MySql.Data.MySqlClient
Public Class frmlogin
    Dim con As New MySqlConnection("server=localhost;user=root;password=;database=adfcdb1")

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim result As DialogResult = MessageBox.Show("Are you Do you want to exit this application?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.Yes Then 'test is yes btn was click
            Close() 'close the application
        End If
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        ok()
    End Sub

    Private Sub txtUser_TextChanged(sender As Object, e As EventArgs) Handles txtUser.TextChanged

    End Sub

    Private Sub txtUser_Enter(sender As Object, e As EventArgs) Handles txtUser.Enter
        txtUser.BackColor = Color.LightYellow
    End Sub

    Private Sub txtUser_Leave(sender As Object, e As EventArgs) Handles txtUser.Leave
        txtUser.BackColor = Color.White
    End Sub

    Private Sub txtPassword_Enter(sender As Object, e As EventArgs) Handles txtPassword.Enter
        txtPassword.BackColor = Color.LightYellow
    End Sub

    Private Sub txtPassword_Leave(sender As Object, e As EventArgs) Handles txtPassword.Leave
        txtPassword.BackColor = Color.White
    End Sub

    Private Sub txtUser_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUser.KeyDown
        If (e.KeyCode = 13) Then
            txtPassword.Focus()
        End If
    End Sub

    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            ok()
        End If
    End Sub

    Private Sub ok()
        'Try
        '    con.Open()
        '    If con.State = ConnectionState.Open Then
        '        MessageBox.Show("Connection to server is open")
        '    Else
        '        MessageBox.Show("Connection to server failed, Check your MYSQL server....")
        '    End If
        'Catch ex As Exception
        '    MessageBox.Show(ex.ToString)
        'End Try


        If ((txtUser.Text = Module1.user) And (txtPassword.Text = Module1.password)) Then
            Dim f1 As New Form1
            f1.Show()
            Me.Hide()
        Else
            MessageBox.Show("Invalid username or password", "User Log in", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPassword.Clear()
            txtUser.Text = ""
            txtUser.Focus()
        End If
    End Sub

    Private Sub frmlogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUser.Text = ""
        Me.ActiveControl = txtUser
        txtUser.Select()
        txtUser.Focus()

    End Sub
End Class