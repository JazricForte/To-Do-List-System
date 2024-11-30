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
        editBTN = New Button()
        removeBTN = New Button()
        toDoLIST = New ListBox()
        signOutBtn = New Button()
        SuspendLayout()
        ' 
        ' addBTN
        ' 
        addBTN.Font = New Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        addBTN.Location = New Point(191, 92)
        addBTN.Name = "addBTN"
        addBTN.Size = New Size(191, 50)
        addBTN.TabIndex = 1
        addBTN.Text = "Add Objective"
        addBTN.UseVisualStyleBackColor = True
        ' 
        ' userNameLBL
        ' 
        userNameLBL.AutoSize = True
        userNameLBL.Font = New Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        userNameLBL.Location = New Point(12, 23)
        userNameLBL.Name = "userNameLBL"
        userNameLBL.Size = New Size(84, 31)
        userNameLBL.TabIndex = 2
        userNameLBL.Text = "Label1"
        ' 
        ' editBTN
        ' 
        editBTN.Font = New Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        editBTN.Location = New Point(486, 92)
        editBTN.Name = "editBTN"
        editBTN.Size = New Size(191, 50)
        editBTN.TabIndex = 1
        editBTN.Text = "Edit"
        editBTN.UseVisualStyleBackColor = True
        ' 
        ' removeBTN
        ' 
        removeBTN.Font = New Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        removeBTN.Location = New Point(486, 437)
        removeBTN.Name = "removeBTN"
        removeBTN.Size = New Size(191, 50)
        removeBTN.TabIndex = 1
        removeBTN.Text = "Remove"
        removeBTN.UseVisualStyleBackColor = True
        ' 
        ' toDoLIST
        ' 
        toDoLIST.FormattingEnabled = True
        toDoLIST.Location = New Point(104, 164)
        toDoLIST.Name = "toDoLIST"
        toDoLIST.Size = New Size(650, 244)
        toDoLIST.TabIndex = 3
        ' 
        ' signOutBtn
        ' 
        signOutBtn.Font = New Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        signOutBtn.Location = New Point(743, 12)
        signOutBtn.Name = "signOutBtn"
        signOutBtn.Size = New Size(123, 52)
        signOutBtn.TabIndex = 1
        signOutBtn.Text = "Sign Out"
        signOutBtn.UseVisualStyleBackColor = True
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(878, 509)
        Controls.Add(toDoLIST)
        Controls.Add(userNameLBL)
        Controls.Add(removeBTN)
        Controls.Add(editBTN)
        Controls.Add(signOutBtn)
        Controls.Add(addBTN)
        Name = "Form3"
        Text = "Form3"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents addBTN As Button
    Friend WithEvents userNameLBL As Label
    Friend WithEvents editBTN As Button
    Friend WithEvents removeBTN As Button
    Friend WithEvents toDoLIST As ListBox
    Friend WithEvents signOutBtn As Button
End Class
