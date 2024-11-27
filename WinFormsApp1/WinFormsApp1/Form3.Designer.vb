<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        addBTN = New Button()
        userNameLBL = New Label()
        updateBTN = New Button()
        removeBTN = New Button()
        toDoLIST = New ListBox()
        SuspendLayout()
        ' 
        ' addBTN
        ' 
        addBTN.Font = New Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        addBTN.Location = New Point(80, 55)
        addBTN.Name = "addBTN"
        addBTN.Size = New Size(191, 50)
        addBTN.TabIndex = 1
        addBTN.Text = "Add Objective"
        addBTN.UseVisualStyleBackColor = True
        ' 
        ' userNameLBL
        ' 
        userNameLBL.AutoSize = True
        userNameLBL.Location = New Point(12, 9)
        userNameLBL.Name = "userNameLBL"
        userNameLBL.Size = New Size(53, 20)
        userNameLBL.TabIndex = 2
        userNameLBL.Text = "Label1"
        ' 
        ' updateBTN
        ' 
        updateBTN.Font = New Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        updateBTN.Location = New Point(310, 55)
        updateBTN.Name = "updateBTN"
        updateBTN.Size = New Size(191, 50)
        updateBTN.TabIndex = 1
        updateBTN.Text = "Update"
        updateBTN.UseVisualStyleBackColor = True
        ' 
        ' removeBTN
        ' 
        removeBTN.Font = New Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        removeBTN.Location = New Point(539, 55)
        removeBTN.Name = "removeBTN"
        removeBTN.Size = New Size(191, 50)
        removeBTN.TabIndex = 1
        removeBTN.Text = "Remove"
        removeBTN.UseVisualStyleBackColor = True
        ' 
        ' toDoLIST
        ' 
        toDoLIST.FormattingEnabled = True
        toDoLIST.Location = New Point(80, 146)
        toDoLIST.Name = "toDoLIST"
        toDoLIST.Size = New Size(650, 244)
        toDoLIST.TabIndex = 3
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(toDoLIST)
        Controls.Add(userNameLBL)
        Controls.Add(removeBTN)
        Controls.Add(updateBTN)
        Controls.Add(addBTN)
        Name = "Form3"
        Text = "Form3"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents addBTN As Button
    Friend WithEvents userNameLBL As Label
    Friend WithEvents updateBTN As Button
    Friend WithEvents removeBTN As Button
    Friend WithEvents toDoLIST As ListBox
End Class
