Imports MySqlConnector

Public Class Database

    Private DatabaseConnection As New MySqlConnection("server=localhost;username=root;database=uew_gonja_land_election")
    Private DatabaseCommand As MySqlCommand

    ' Database Data
    Public DatabaseAdapter As MySqlDataAdapter
    Public DatabaseTable As DataTable

    ' Query Parameters
    Public parameters As New List(Of MySqlParameter)

    ' Query set
    Public RecordCount As Integer
    Public exception As String

    Public Sub New()

    End Sub

    ' Allow connection string override
    Public Sub New(ConnectionString As String)
        DatabaseConnection = New MySqlConnection(ConnectionString)
    End Sub

    ' Execute Query sub
    Public Sub ExecuteQuery(Query As String)
        ' Reset Query Stats
        RecordCount = 0
        exception = ""

        Try
            DatabaseConnection.Open()

            'Create Database command
            DatabaseCommand = New MySqlCommand(Query, DatabaseConnection)

            ' Load parameters into Database Command
            parameters.ForEach(Sub(p) DatabaseCommand.Parameters.Add(p))

            ' Clear Parameter list
            parameters.Clear()

            'Execute Command and Fill Dataset
            DatabaseTable = New DataTable
            DatabaseAdapter = New MySqlDataAdapter(DatabaseCommand)
            RecordCount = DatabaseAdapter.Fill(DatabaseTable)

        Catch ex As Exception
            ' Capture Error
            exception = "ExecuteQuery Error: " & vbNewLine & ex.Message
        Finally
            ' Close Connection
            If DatabaseConnection.State = ConnectionState.Open Then DatabaseConnection.Close()
        End Try
    End Sub

    ' Add parameters
    Public Sub AddParameters(Name As String, value As Object)
        Dim newParameter As New MySqlParameter(Name, value)
        parameters.Add(newParameter)
    End Sub

    ' Error Checking
    Public Function HasException(Optional Report As Boolean = False) As Boolean
        If String.IsNullOrEmpty(exception) Then Return False
        If Report = True Then MsgBox(exception, MsgBoxStyle.Critical, "Exception")
        Return True
    End Function

End Class
