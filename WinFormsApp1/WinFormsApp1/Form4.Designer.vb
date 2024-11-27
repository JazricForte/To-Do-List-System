<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        toDoInput = New TextBox()
        confirmBTN = New Button()
        ExitBTN = New Button()
        SuspendLayout()
        ' 
        ' toDoInput
        ' 
        toDoInput.Location = New Point(96, 86)
        toDoInput.Name = "toDoInput"
        toDoInput.Size = New Size(332, 27)
        toDoInput.TabIndex = 0
        ' 
        ' confirmBTN
        ' 
        confirmBTN.Font = New Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        confirmBTN.Location = New Point(113, 136)
        confirmBTN.Name = "confirmBTN"
        confirmBTN.Size = New Size(122, 40)
        confirmBTN.TabIndex = 1
        confirmBTN.Text = "Confirm"
        confirmBTN.UseVisualStyleBackColor = True
        ' 
        ' ExitBTN
        ' 
        ExitBTN.Font = New Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ExitBTN.Location = New Point(284, 136)
        ExitBTN.Name = "ExitBTN"
        ExitBTN.Size = New Size(122, 40)
        ExitBTN.TabIndex = 1
        ExitBTN.Text = "Exit"
        ExitBTN.UseVisualStyleBackColor = True
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(533, 234)
        Controls.Add(ExitBTN)
        Controls.Add(confirmBTN)
        Controls.Add(toDoInput)
        Name = "Form4"
        Text = "Form4"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents toDoInput As TextBox
    Friend WithEvents confirmBTN As Button
    Friend WithEvents ExitBTN As Button
End Class
