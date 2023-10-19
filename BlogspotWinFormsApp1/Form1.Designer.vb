<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Title_TextBox = New System.Windows.Forms.TextBox()
        Me.Desc_TextBox = New System.Windows.Forms.TextBox()
        Me.Go_Button = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Title_TextBox
        '
        Me.Title_TextBox.Location = New System.Drawing.Point(206, 12)
        Me.Title_TextBox.Name = "Title_TextBox"
        Me.Title_TextBox.Size = New System.Drawing.Size(248, 27)
        Me.Title_TextBox.TabIndex = 0
        '
        'Desc_TextBox
        '
        Me.Desc_TextBox.Location = New System.Drawing.Point(206, 45)
        Me.Desc_TextBox.Name = "Desc_TextBox"
        Me.Desc_TextBox.Size = New System.Drawing.Size(248, 27)
        Me.Desc_TextBox.TabIndex = 1
        '
        'Go_Button
        '
        Me.Go_Button.Location = New System.Drawing.Point(12, 12)
        Me.Go_Button.Name = "Go_Button"
        Me.Go_Button.Size = New System.Drawing.Size(94, 60)
        Me.Go_Button.TabIndex = 2
        Me.Go_Button.Text = "Go"
        Me.Go_Button.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(112, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 19)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Title"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(112, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 19)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Description"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(468, 114)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Go_Button)
        Me.Controls.Add(Me.Desc_TextBox)
        Me.Controls.Add(Me.Title_TextBox)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Title_TextBox As TextBox
    Friend WithEvents Desc_TextBox As TextBox
    Friend WithEvents Go_Button As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
