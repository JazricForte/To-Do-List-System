<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        ExitBTN = New Button()
        confirmBTN = New Button()
        toDoInput = New TextBox()
        SuspendLayout()
        ' 
        ' ExitBTN
        ' 
        ExitBTN.Font = New Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0)
        ExitBTN.Location = New Point(282, 134)
        ExitBTN.Name = "ExitBTN"
        ExitBTN.Size = New Size(122, 40)
        ExitBTN.TabIndex = 4
        ExitBTN.Text = "Exit"
        ExitBTN.UseVisualStyleBackColor = True
        ' 
        ' confirmBTN
        ' 
        confirmBTN.Font = New Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0)
        confirmBTN.Location = New Point(111, 134)
        confirmBTN.Name = "confirmBTN"
        confirmBTN.Size = New Size(122, 40)
        confirmBTN.TabIndex = 3
        confirmBTN.Text = "Confirm"
        confirmBTN.UseVisualStyleBackColor = True
        ' 
        ' toDoInput
        ' 
        toDoInput.Location = New Point(94, 84)
        toDoInput.Name = "toDoInput"
        toDoInput.Size = New Size(332, 27)
        toDoInput.TabIndex = 2
        ' 
        ' Form5
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(533, 234)
        Controls.Add(ExitBTN)
        Controls.Add(confirmBTN)
        Controls.Add(toDoInput)
        Name = "Form5"
        Text = "Form5"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ExitBTN As Button
    Friend WithEvents confirmBTN As Button
    Friend WithEvents toDoInput As TextBox
End Class
