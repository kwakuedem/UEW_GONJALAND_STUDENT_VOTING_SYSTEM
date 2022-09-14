Public Class DashBoard
    Dim iExit As DialogResult
    Dim data As New Database

    'close button
    Private Sub buttonClose_Click(sender As Object, e As EventArgs) Handles buttonClose.Click
        iExit = MessageBox.Show("Are you sure you want to exit ? ", "Exit Application ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If iExit = DialogResult.Yes Then
            Application.ExitThread()
        End If
    End Sub

    Private Sub buttonLogout_Click(sender As Object, e As EventArgs) Handles buttonLogout.Click
        Dim log_in As New Login

        log_in.Show()
        Me.Hide()
    End Sub

    Private Sub MinMaxButton_Click(sender As Object, e As EventArgs) Handles MinMaxButton.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        ElseIf Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub


    Private Sub buttonStatistics_Click(sender As Object, e As EventArgs) Handles buttonStatistics.Click
        Dim stat As New Statistics
        stat.Show()
        Me.Hide()

    End Sub

    'codes to execute when the load
    Private Sub DashBoard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        updateDashboard()

        countTotalNumbertVoters()

    End Sub

    'count votes for presidential candidates
    Sub countPresident()
        Try
            'count ADAM ABDUL-AZIZ
            data.ExecuteQuery("SELECT COUNT(DISTINCT(student_index)) from votes WHERE choice='" & "pres_01" & "';")
            lblPres1.Text = data.DatabaseTable(0)(0)

            'count TAHIRU ABDUL WADUD DAWAL
            data.ExecuteQuery("SELECT COUNT(DISTINCT(student_index)) from votes WHERE choice='" & "pres_02" & "';")
            lblPres2.Text = data.DatabaseTable(0)(0)

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub


    'count votes for 2nd vice presidial candidates
    Sub count2ndVicePresident2()
        Try
            'count YES votes for INUSAH SABIRATU
            data.ExecuteQuery("SELECT COUNT(DISTINCT(student_index)) from votes WHERE choice='" & "2Vicepres_01" & "' AND agree='" & "yes" & "';")
            lbl2ndYes.Text = data.DatabaseTable(0)(0)

            'count NO votes for INUSAH SABIRATU
            data.ExecuteQuery("SELECT COUNT(DISTINCT(student_index)) from votes WHERE choice='" & "2Vicepres_01" & "' AND agree='" & "no" & "';")
            lbl2ndNo.Text = data.DatabaseTable(0)(0)

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub


    'count votes for Secretary candidates
    Sub countSecretary()
        Try
            'count ZAKARIA ABUBAKARI
            data.ExecuteQuery("SELECT COUNT(DISTINCT(student_index)) from votes WHERE choice='" & "secret_01" & "';")
            secret1.Text = data.DatabaseTable(0)(0)

            'count ABUBAKARI YUSSIF
            data.ExecuteQuery("SELECT COUNT(DISTINCT(student_index)) from votes WHERE choice='" & "secret_02" & "';")
            secret2.Text = data.DatabaseTable(0)(0)

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub



    'count votes for Treasurer candidates
    Sub countTreasurer()
        Try
            'count BAWA MOHAMMED
            data.ExecuteQuery("SELECT COUNT(DISTINCT(student_index)) from votes WHERE choice='" & "treas_01" & "';")
            lblTreas1.Text = data.DatabaseTable(0)(0)

            'count ALIDU ABDUL-JALIL
            data.ExecuteQuery("SELECT COUNT(DISTINCT(student_index)) from votes WHERE choice='" & "treas_02" & "';")
            lblTreas2.Text = data.DatabaseTable(0)(0)

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub


    'count votes for Organizer candidates
    Sub countOrganizer()
        Try
            'count YES votes for DANAA JACOB
            data.ExecuteQuery("SELECT COUNT(DISTINCT(student_index)) from votes WHERE choice='" & "organ_01" & "' AND agree='" & "yes" & "';")
            lblOrganizerYes.Text = data.DatabaseTable(0)(0)

            'count NO votes for DANAA JACOB
            data.ExecuteQuery("SELECT COUNT(DISTINCT(student_index)) from votes WHERE choice='" & "organ_01" & "' AND agree='" & "no" & "';")
            lblOrganizerNo.Text = data.DatabaseTable(0)(0)

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub


    'count votes for Women Commissioner candidate
    Sub countWomenCommissioner()
        Try
            'count YES votes for JOHN B. MAGDALENE
            data.ExecuteQuery("SELECT COUNT(DISTINCT(student_index)) from votes WHERE choice='" & "womenCo_01" & "' AND agree='" & "yes" & "';")
            lblWomenCommYes.Text = data.DatabaseTable(0)(0)

            'count NO votes for JOHN B. MAGDALENE
            data.ExecuteQuery("SELECT COUNT(DISTINCT(student_index)) from votes WHERE choice='" & "womenCo_01" & "' AND agree='" & "no" & "';")
            lblWomenCommNo.Text = data.DatabaseTable(0)(0)

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub


    'count votes for Women Commissioner candidate
    Sub countPublicRelationOfficer()
        Try
            'count YES votes for DARI ZULKANDEEN BORENYI
            data.ExecuteQuery("SELECT COUNT(DISTINCT(student_index)) from votes WHERE choice='" & "pubReOf_01" & "' AND agree='" & "yes" & "';")
            lblPublicRelatioOffYes.Text = data.DatabaseTable(0)(0)

            'count NO votes for DARI ZULKANDEEN BORENYI
            data.ExecuteQuery("SELECT COUNT(DISTINCT(student_index)) from votes WHERE choice='" & "pubReOf_01" & "' AND agree='" & "no" & "';")
            lblPublicRelatioOffNo.Text = data.DatabaseTable(0)(0)

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    'current voters
    Sub countCurrentVoters()
        Try
            data.ExecuteQuery("SELECT COUNT(DISTINCT(student_index)) from votes;")

            Dim result As Integer = data.RecordCount

            lblcurrentVoters.Text = data.DatabaseTable(0)(0)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub


    'total number of voters
    Sub countTotalNumbertVoters()
        Try
            data.ExecuteQuery("SELECT COUNT(DISTINCT(student_index)) from users;")

            lblTotalNumberOfVoter.Text = data.DatabaseTable(0)(0) - 1
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    'update records
    Sub updateDashboard()
        countPresident()
        count2ndVicePresident2()
        countPublicRelationOfficer()
        countSecretary()
        countTreasurer()
        countOrganizer()
        countWomenCommissioner()


        countCurrentVoters()
    End Sub
End Class