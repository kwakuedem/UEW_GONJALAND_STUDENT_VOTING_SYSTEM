﻿Public Class Login
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
                        Dim voted As Integer = data.DatabaseTable.Rows(0)(3)
                        student_index = data.DatabaseTable(0)(1)
                        If role = 0 Then
                            DashBoard.Show()
                            Me.Hide()
                        ElseIf Not (role = 0) And (voted = 0) Then
                            Vote.Show()
                            Me.Hide()
                        Else
                            MessageBox.Show("Please you are not allowed to Vote twice ", "Already Voted", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblauthor.Text = "Copyright © 2022, Edem Kwaku"
    End Sub
End Class