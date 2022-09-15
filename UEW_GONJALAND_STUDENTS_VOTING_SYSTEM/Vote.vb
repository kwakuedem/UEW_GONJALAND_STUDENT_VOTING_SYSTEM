Public Class Vote
    Dim data As New Database
    Dim iExit As DialogResult
    Dim choice As String
    Dim post As String
    Dim agree As String
    Dim index As String = Nothing


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        resetVote()
        lblIndexNumber.Text = student_index
    End Sub

    Private Sub buttonSubmit_Click(sender As Object, e As EventArgs) Handles buttonSubmit.Click
        Try
            validateVote()
        Catch ex As Exception

        End Try
    End Sub

    'check of a position is not voted for
    Sub validateVote()
        If (Choice_Aziz.Checked = True Or Choice_Dawal.Checked = True) And (Choice_Sabiratu_Yes.Checked = True Or Choice_Sabiratu_No.Checked = True) And (Choice_Abubakari.Checked = True Or Choice_Yussif.Checked = True) And (Choice_Mohammed.Checked = True Or Choice_Abdul_Jalil.Checked = True) And (Choice_Jacob_Yes.Checked = True Or Choice_Jacob_No.Checked = True) And (Choice_magdalene_Yes.Checked = True Or Choice_magdalene_No.Checked = True) And (Choice_Borenyi_Yes.Checked = True Or Choice_Borenyi_No.Checked = True) Then
            Try
                checkPresidentailVote()
                checkSecondVicePresidentailVote()
                checkSecretaryVote()
                checkTreasurerVote()
                checkOrganizerVote()
                checkWomenCommisionerlVote()
                checkPublicRelationOfficerVote()
                changeVoterStatusToVoted()

                iExit = MessageBox.Show("Votes have been cast successfully !", "Vote casted", MessageBoxButtons.OK, MessageBoxIcon.Information)
                If iExit = DialogResult.OK Then
                    resetVote()
                    Login.Show()
                    Me.Close()
                End If

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

        Else
            MessageBox.Show("Please make sure you cast for all post !", "All post must be voted for", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    'reset form for new voter
    Sub resetVote()
        Choice_Abdul_Jalil.Checked = False
        Choice_Abubakari.Checked = False
        Choice_Aziz.Checked = False
        Choice_Dawal.Checked = False
        Choice_Sabiratu_Yes.Checked = False
        Choice_Sabiratu_No.Checked = False
        Choice_Yussif.Checked = False
        Choice_Mohammed.Checked = False
        Choice_Abdul_Jalil.Checked = False
        Choice_Jacob_Yes.Checked = False
        Choice_Jacob_No.Checked = False
        Choice_magdalene_Yes.Checked = False
        Choice_magdalene_No.Checked = False
        Choice_Borenyi_Yes.Checked = False
        Choice_Borenyi_No.Checked = False
    End Sub

    Private Sub buttonClose_Click(sender As Object, e As EventArgs) Handles buttonClose.Click
        iExit = MessageBox.Show("Are you sure you want to exit ? ", "Exit Application ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If iExit = DialogResult.Yes Then
            Application.ExitThread()
        End If
    End Sub

    'choice for presidential
    Sub checkPresidentailVote()
        index = lblIndexNumber.Text
        post = "President"
        Try
            If Choice_Aziz.Checked = True Then
                choice = "pres_01"
            ElseIf Choice_Dawal.Checked = True Then
                choice = "pres_02"
            End If

            data.ExecuteQuery("INSERT INTO votes(student_index,post,choice) VALUE('" & index & "','" & post & "','" & choice & "');")
            If data.HasException = True Then
                MsgBox(data.exception)
            End If

        Catch ex As Exception

        End Try
    End Sub


    'choice for 2nd vice president
    Sub checkSecondVicePresidentailVote()
        index = lblIndexNumber.Text
        post = "2nd vice president"
        Try
            If Choice_Sabiratu_Yes.Checked = True Then
                choice = "2Vicepres_01"
                agree = "yes"
            ElseIf Choice_Sabiratu_No.Checked = True Then
                choice = "2Vicepres_01"
                agree = "no"
            End If

            data.ExecuteQuery("INSERT INTO votes(student_index,post,choice,agree) VALUE('" & index & "','" & post & "','" & choice & "','" & agree & "');")
            If data.HasException = True Then
                MsgBox(data.exception)
            End If
        Catch ex As Exception

        End Try
    End Sub

    'choice for secretary
    Sub checkSecretaryVote()
        index = lblIndexNumber.Text
        post = "Secretary"
        Try
            If Choice_Abubakari.Checked = True Then
                choice = "secret_01"
            ElseIf Choice_Yussif.Checked = True Then
                choice = "secret_02"
            End If

            data.ExecuteQuery("INSERT INTO votes(student_index,post,choice) VALUE('" & index & "','" & post & "','" & choice & "');")
            If data.HasException = True Then
                MsgBox(data.exception)
            End If

        Catch ex As Exception

        End Try
    End Sub

    'choice for Treasurer
    Sub checkTreasurerVote()
        index = lblIndexNumber.Text
        post = "Treasurer"
        Try
            If Choice_Mohammed.Checked = True Then
                choice = "treas_01"
            ElseIf Choice_Abdul_Jalil.Checked = True Then
                choice = "treas_02"
            End If

            data.ExecuteQuery("INSERT INTO votes(student_index,post,choice) VALUE('" & index & "','" & post & "','" & choice & "');")
            If data.HasException = True Then
                MsgBox(data.exception)
            End If

        Catch ex As Exception

        End Try
    End Sub


    'choice for organizer
    Sub checkOrganizerVote()
        index = lblIndexNumber.Text
        post = "Organizer"
        Try
            If Choice_Jacob_Yes.Checked = True Then
                choice = "organ_01"
                agree = "yes"
            ElseIf Choice_Jacob_No.Checked = True Then
                choice = "organ_01"
                agree = "no"
            End If

            data.ExecuteQuery("INSERT INTO votes(student_index,post,choice,agree) VALUE('" & index & "','" & post & "','" & choice & "','" & agree & "');")
            If data.HasException = True Then
                MsgBox(data.exception)
            End If

        Catch ex As Exception

        End Try
    End Sub

    'choice for Women Commisioner
    Sub checkWomenCommisionerlVote()
        index = lblIndexNumber.Text
        post = "Women Commissioner"
        Try
            If Choice_magdalene_Yes.Checked = True Then
                choice = "womenCo_01"
                agree = "yes"
            ElseIf Choice_magdalene_No.Checked = True Then
                choice = "womenCo_01"
                agree = "no"
            End If

            data.ExecuteQuery("INSERT INTO votes(student_index,post,choice,agree) VALUE('" & index & "','" & post & "','" & choice & "','" & agree & "');")
            If data.HasException = True Then
                MsgBox(data.exception)
            End If

        Catch ex As Exception

        End Try
    End Sub

    'choice for Women Commisioner
    Sub checkPublicRelationOfficerVote()
        index = lblIndexNumber.Text
        post = "Public Relation"
        Try
            If Choice_Borenyi_Yes.Checked = True Then
                choice = "pubReOf_01"
                agree = "yes"
            ElseIf Choice_Borenyi_No.Checked = True Then
                choice = "pubReOf_01"
                agree = "no"
            End If

            data.ExecuteQuery("INSERT INTO votes(student_index,post,choice,agree) VALUE('" & index & "','" & post & "','" & choice & "','" & agree & "');")
            If data.HasException = True Then
                MsgBox(data.exception)
            End If

        Catch ex As Exception

        End Try
    End Sub

    'button to maximized and minimized
    Private Sub buttonMinMax_Click(sender As Object, e As EventArgs) Handles buttonMinMax.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        ElseIf Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    'updateVotedIndexToTrue
    Sub changeVoterStatusToVoted()
        index = lblIndexNumber.Text
        Try
            data.ExecuteQuery("UPDATE `users` SET `status` = 1 WHERE `student_index` = '" & index & "';")
            If data.HasException = True Then
                MsgBox(data.exception)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

End Class
