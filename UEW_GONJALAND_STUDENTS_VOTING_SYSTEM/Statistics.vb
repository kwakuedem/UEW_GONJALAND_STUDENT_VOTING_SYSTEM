Public Class Statistics
    Dim iExit As DialogResult

    Private Sub buttonDashboard_Click(sender As Object, e As EventArgs) Handles buttonDashboard.Click
        Dim dash As New DashBoard
        dash.Show()
        Me.Hide()
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

    Private Sub Statistics_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        convertVoteCountToPercentage()
    End Sub

    'convert vote count to percentages
    Sub convertVoteCountToPercentage()
        If presd1 = 0 Then
            lblPres1.Text = 0 & "%"
        Else
            lblPres1.Text = ((presd1 / currVoters) * 100) & "%"
        End If


        If presd2 = 0 Then
            lblPres2.Text = 0 & "%"
        Else
            lblPres2.Text = ((presd1 / currVoters) * 100) & "%"
        End If

        If _2presY = 0 Then
            lbl2ndYes.Text = 0 & "%"
        Else
            lbl2ndYes.Text = ((_2presY / currVoters) * 100) & "%"
        End If

        If _2presN = 0 Then
            lbl2ndNo.Text = 0 & "%"
        Else
            lbl2ndNo.Text = ((_2presN / currVoters) * 100) & "%"
        End If

        If sec1 = 0 Then
            secret1.Text = 0 & "%"
        Else
            secret1.Text = ((sec1 / currVoters) * 100) & "%"
        End If

        If sec2 = 0 Then
            secret2.Text = 0 & "%"
        Else
            secret2.Text = ((sec2 / currVoters) * 100) & "%"
        End If

        If treas1 = 0 Then
            lblTreas1.Text = 0 & "%"
        Else
            lblTreas1.Text = ((treas1 / currVoters) * 100) & "%"
        End If

        If treas2 = 0 Then
            lblTreas2.Text = 0 & "%"
        Else
            lblTreas2.Text = ((treas2 / currVoters) * 100) & "%"
        End If

        If organY = 0 Then
            lblOrganizerYes.Text = 0 & "%"
        Else
            lblOrganizerYes.Text = ((organY / currVoters) * 100) & "%"
        End If

        If organN = 0 Then
            lblOrganizerNo.Text = 0 & "%"
        Else
            lblOrganizerNo.Text = ((organN / currVoters) * 100) & "%"
        End If

        If womenCoY = 0 Then
            lblWomenCommYes.Text = 0 & "%"
        Else
            lblWomenCommYes.Text = ((womenCoY / currVoters) * 100) & "%"
        End If

        If womenCoN = 0 Then
            lblWomenCommNo.Text = 0 & "%"
        Else
            lblWomenCommNo.Text = ((womenCoN / currVoters) * 100) & "%"
        End If


        If publiOfY = 0 Then
            lblPublicRelatioOffYes.Text = 0 & "%"
        Else
            lblPublicRelatioOffYes.Text = ((publiOfY / currVoters) * 100) & "%"
        End If

        If publiOfN = 0 Then
            lblPublicRelatioOffNo.Text = 0 & "%"
        Else
            lblPublicRelatioOffNo.Text = ((publiOfN / currVoters) * 100) & "%"
        End If
    End Sub
End Class