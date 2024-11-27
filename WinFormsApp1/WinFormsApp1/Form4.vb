Imports MySql.Data.MySqlClient

Public Class Form4
    Public Property id As Integer
    Dim conn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim READER As MySqlDataReader
    Private Sub confirmBTN_Click(sender As Object, e As EventArgs) Handles confirmBTN.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=127.0.0.1;userid=root;password='';database=todolistdb"
        Dim READER As MySqlDataReader

        Try
            conn.Open()

            Dim query As String
            Dim no As String
            query = "INSERT INTO todolistdb.tabletodolist (todo, userid) Values ('" & toDoInput.Text & "', '" & id & "')"
            COMMAND = New MySqlCommand(query, conn)
            READER = COMMAND.ExecuteReader

            MessageBox.Show("Objective Saved")
            conn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub ExitBTN_Click(sender As Object, e As EventArgs) Handles ExitBTN.Click
        Me.Hide()
    End Sub
End Class