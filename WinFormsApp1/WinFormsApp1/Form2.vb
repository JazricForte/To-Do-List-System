Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI.Common

Public Class Form2
    Dim Gender As String
    Dim conn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim DBDataSet As New DataTable
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=127.0.0.1;userid=root;password='';database=todolistdb"


        Try
            conn.Open()

            Dim checkQuery As String = "SELECT COUNT(*) FROM todolistdb.usersign WHERE username = '" & TextBox1.Text.Replace("'", "''") & "'"
            Dim checkCommand As New MySqlCommand(checkQuery, conn)
            Dim userExists As Integer = Convert.ToInt32(checkCommand.ExecuteScalar())

            If userExists > 0 Then
                MessageBox.Show("Username is already taken. Please choose another one.")
                Exit Sub
            End If

            Dim query As String
            query = "INSERT INTO todolistdb.usersign (username, password) Values ('" & TextBox1.Text & "', '" & TextBox2.Text & "')"
            COMMAND = New MySqlCommand(query, conn)


            Dim result As Integer = COMMAND.ExecuteNonQuery()
            If result > 0 Then
                MessageBox.Show("Registered Successfully")
                Form1.Show()
                Me.Close()
            Else
                MessageBox.Show("Registration Failed")
            End If
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
End Class