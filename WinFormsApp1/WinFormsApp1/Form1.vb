Imports MySql.Data.MySqlClient
Public Class Form1
    Dim conn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim READER As MySqlDataReader
    Public Shared Property id As String
    Public Shared Property userName As String
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=127.0.0.1;userid=root;password='';database=todolistdb"
        Dim READER As MySqlDataReader

        Try
            conn.Open()
            Dim query As String
            query = "SELECT * FROM todolistdb.usersign WHERE username = '" & TextBox1.Text & "' AND password = '" & TextBox2.Text & "' "
            COMMAND = New MySqlCommand(query, conn)
            READER = COMMAND.ExecuteReader
            Dim count As Integer
            count = 0

            While READER.Read()
                count += 1

            End While

            If count = 1 Then
                MessageBox.Show("Username and Password are correct")

                Dim query2 As String
                query2 = "SELECT id FROM todolistdb.usersign WHERE username = '" & TextBox1.Text & "' AND password = '" & TextBox2.Text & "'"
                COMMAND = New MySqlCommand(query2, conn)
                READER.Read()
                id = Convert.ToString(READER("id"))
                userName = TextBox1.Text

                Form3.Show()
                Me.Hide()
            ElseIf count > 1 Then
                MessageBox.Show("Username and Password are Duplicate")
            Else
                MessageBox.Show("Username and Password are not correct")
            End If

            conn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show()
        Me.Hide()
    End Sub
End Class
