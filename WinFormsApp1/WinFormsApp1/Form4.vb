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

            Dim checkQuerry As String = "SELECT COUNT(*) FROM todolistdb.tabletodolist WHERE todo = '" & toDoInput.Text & "'"
            Dim query As String
            query = "INSERT INTO todolistdb.tabletodolist (todo, userid) Values ('" & toDoInput.Text & "', '" & id & "')"
            COMMAND = New MySqlCommand(checkQuerry, conn)
            Dim objectiveCount As Integer = Convert.ToInt32(COMMAND.ExecuteScalar())

            If objectiveCount = 0 Then
                COMMAND = New MySqlCommand(query, conn)
                COMMAND.ExecuteNonQuery()
                MessageBox.Show("Objective Saved")

            Else
                MessageBox.Show("You already have that objective, please add a different one")
            End If

            toDoInput.Text = Nothing
            Form3.RefreshToDoList()

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