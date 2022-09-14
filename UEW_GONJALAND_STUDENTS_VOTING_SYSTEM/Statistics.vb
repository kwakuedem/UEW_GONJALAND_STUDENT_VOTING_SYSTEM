Public Class Statistics
    Dim iExit As DialogResult

    Private Sub buttonDashboard_Click(sender As Object, e As EventArgs) Handles buttonDashboard.Click
        Dim dash As New DashBoard
        dash.Show()
    End Sub

    Private Sub MinMaxButton_Click(sender As Object, e As EventArgs) Handles MinMaxButton.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        ElseIf Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub buttonLogout_Click(sender As Object, e As EventArgs) Handles buttonLogout.Click
        Dim log_in As New Login
        log_in.Show()
        Me.Hide()
    End Sub

    Private Sub buttonClose_Click(sender As Object, e As EventArgs) Handles buttonClose.Click
        iExit = MessageBox.Show("Are you sure you want to exit ? ", "Exit Application ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If iExit = DialogResult.Yes Then
            Application.ExitThread()
        End If
    End Sub
End Class