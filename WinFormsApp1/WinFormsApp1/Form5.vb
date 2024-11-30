Imports MySql.Data.MySqlClient

Public Class Form5
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
            query = "UPDATE todolistdb.tabletodolist SET todo = '" & toDoInput.Text & "' WHERE todo = '" & (Form3.pickedToDoList) & "'"
            COMMAND = New MySqlCommand(query, conn)
            READER = COMMAND.ExecuteReader

            Form3.RefreshToDoList()

            MessageBox.Show("Data Updated")
            conn.Close()

            toDoInput.Text = Nothing
            Form3.pickedToDoList = Nothing
            Me.Hide()

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