Public Class Login
    Dim data As New Database

    Private Sub buttonLogin_Click(sender As Object, e As EventArgs) Handles buttonLogin.Click
        Dim indexNumber As String = txtIndexNuber.Text
        Try
            If (indexNumber.Length < 10) Or (indexNumber.Length > 10) Then
                MessageBox.Show("Index number must be 10 characters ", "Password Lenght", MessageBoxButtons.OK, MessageBoxIcon.Stop)

            Else
                Try
                    data.ExecuteQuery("select * from users where student_index ='" & indexNumber & "';")

                    Dim result As Integer = data.RecordCount
                    If result = 1 Then
                        Dim role As Integer = data.DatabaseTable.Rows(0)(2)
                        student_index = data.DatabaseTable(0)(1)
                        If role = 0 Then
                            DashBoard.Show()
                            Me.Hide()
                        Else
                            Vote.Show()
                            Me.Hide()
                        End If
                    Else
                        MessageBox.Show("Wrong index number Or Index number not found", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If

                    txtIndexNuber.Clear()

                Catch ex As Exception
                    MsgBox(ex.ToString, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try

            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class