Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form3
    Dim conn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim READER As MySqlDataReader
    Public Shared pickedToDoList As String

    Private Sub addBTN_Click(sender As Object, e As EventArgs) Handles addBTN.Click
        Form4.id = Form1.id
        Form4.Show()
    End Sub

    Public Function RefreshToDoList()

        toDoLIST.Items.Clear()

        conn = New MySqlConnection
        conn.ConnectionString = "server=127.0.0.1;userid=root;password='';database=todolistdb"
        Dim READER As MySqlDataReader

        Try
            conn.Open()
            Dim query As String
            query = "SELECT * FROM todolistdb.tabletodolist WHERE userid = '" & Form1.id & "'"
            COMMAND = New MySqlCommand(query, conn)
            READER = COMMAND.ExecuteReader
            While READER.Read()
                toDoLIST.Items.Add(READER.GetString("todo"))
            End While

            conn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Function

    Private Sub form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        userNameLBL.Text = Form1.userName
        conn = New MySqlConnection
        conn.ConnectionString = "server=127.0.0.1;userid=root;password='';database=todolistdb"
        Dim READER As MySqlDataReader

        Try
            conn.Open()
            Dim query As String
            query = "SELECT * FROM todolistdb.tabletodolist WHERE userid = '" & Form1.id & "'"
            COMMAND = New MySqlCommand(query, conn)
            READER = COMMAND.ExecuteReader
            While READER.Read()
                toDoLIST.Items.Add(READER.GetString("todo"))
            End While

            conn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub editBTN_Click(sender As Object, e As EventArgs) Handles editBTN.Click
        If pickedToDoList IsNot Nothing Then
            Form5.Show()
        Else
            MessageBox.Show("Please pick an objective you want to edit")
        End If

    End Sub

    Private Sub signOutBtn_Click(sender As Object, e As EventArgs) Handles signOutBtn.Click
        Form1.id = Nothing
        Form1.userName = Nothing
        Form1.TextBox1.Text = Nothing
        Form1.TextBox2.Text = Nothing
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub toDoLIST_SelectedIndexChanged(sender As Object, e As EventArgs) Handles toDoLIST.SelectedIndexChanged
        conn = New MySqlConnection
        conn.ConnectionString = "server=127.0.0.1;userid=root;password='';database=databasesample"
        Dim READER As MySqlDataReader

        Try
            conn.Open()
            Dim query As String
            query = "SELECT * FROM todolistdb.tabletodolist WHERE todo = '" & toDoLIST.Text & "'"
            COMMAND = New MySqlCommand(query, conn)
            READER = COMMAND.ExecuteReader
            While READER.Read
                pickedToDoList = READER.GetString("todo")
            End While

            conn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub removeBTN_Click(sender As Object, e As EventArgs) Handles removeBTN.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=127.0.0.1;userid=root;password='';database=databasesample"
        Dim READER As MySqlDataReader

        Try
            conn.Open()

            If pickedToDoList IsNot Nothing Then
                Dim result As DialogResult
                result = MsgBox("Are you sure you want to delete this objective?", MessageBoxButtons.YesNo, "WARNING!")
                If result = DialogResult.Yes Then

                    Dim query As String
                    query = "DELETE FROM todolistdb.tabletodolist WHERE todo = '" & pickedToDoList & "'"
                    COMMAND = New MySqlCommand(query, conn)
                    READER = COMMAND.ExecuteReader

                    RefreshToDoList()

                    MessageBox.Show("Deleted")
                End If
            Else
                MessageBox.Show("Please pick an objective you want to delete")
            End If

            conn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub
End Class