Imports MySql.Data.MySqlClient

Public Class frm_login

    Dim conn As New MySqlConnection("server=localhost;user=root;password=;database=adfcdb1")
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim res As DialogResult = MessageBox.Show("Are you sure you want to exit this application?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If res = DialogResult.Yes Then
            Close()
        End If
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        OK()
    End Sub

    Private Sub txtUsername_Enter(sender As Object, e As EventArgs) Handles txtUsername.Enter
        txtUsername.BackColor = Color.LightYellow
    End Sub

    Private Sub txtUsername_Leave(sender As Object, e As EventArgs) Handles txtUsername.Leave
        txtUsername.BackColor = Color.White
    End Sub

    Private Sub txtPassword_Enter(sender As Object, e As EventArgs) Handles txtPassword.Enter
        txtPassword.BackColor = Color.LightYellow
    End Sub

    Private Sub txtPassword_Leave(sender As Object, e As EventArgs) Handles txtPassword.Leave
        txtPassword.BackColor = Color.White
    End Sub

    Private Sub txtUsername_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUsername.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            txtPassword.Focus()
        End If
    End Sub

    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            OK()
        End If
    End Sub
    Private Sub OK()
        'Try
        '    conn.Open()
        '    If conn.State = ConnectionState.Open Then
        '        MessageBox.Show("Connection to server is open")
        '    Else
        '        MessageBox.Show("Connection to server failed, Check your MySQL server...")
        '    End If
        'Catch ex As Exception
        '    MessageBox.Show(ToString)
        'End Try
        If ((txtUsername.Text = Module1.user) And (txtPassword.Text = Module1.password)) Then
            Dim f1 As New Form1
            Me.Hide()
            f1.Show()
        Else
            MessageBox.Show("Wrong Username or Password", "User Login", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPassword.Clear()
            txtUsername.Clear()
            txtUsername.Focus()
        End If
    End Sub

    Private Sub frm_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class