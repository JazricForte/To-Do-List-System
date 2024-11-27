Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form3
    Dim conn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim READER As MySqlDataReader
    Public Property id As Integer
    Public Property userName As String

    Dim OBJ As New Form4()
    Private Sub addBTN_Click(sender As Object, e As EventArgs) Handles addBTN.Click, updateBTN.Click, removeBTN.Click
        OBJ.id = id
        OBJ.Show()
    End Sub

    Private Sub userNameLBL_Click(sender As Object, e As EventArgs) Handles userNameLBL.Click
        userNameLBL.Text = userName
    End Sub

    Private Sub form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New MySqlConnection
        conn.ConnectionString = "server=127.0.0.1;userid=root;password='';database=todolistdb"
        Dim READER As MySqlDataReader

        Try
            conn.Open()
            Dim query As String
            query = "SELECT * FROM todolistdb.tabletodolist WHERE userid = '" & id & "'"
            COMMAND = New MySqlCommand(query, conn)
            READER = COMMAND.ExecuteReader
            While READER.Read
                Dim toDO = READER.GetString("todo")
                toDoLIST.Items.Add(toDO)
            End While

            conn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles toDoLIST.SelectedIndexChanged

    End Sub
End Class