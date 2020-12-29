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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Software_list = New System.Windows.Forms.CheckedListBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 271)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(103, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Install"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(121, 271)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(115, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "uninstall"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Software_list
        '
        Me.Software_list.FormattingEnabled = True
        Me.Software_list.Location = New System.Drawing.Point(40, 30)
        Me.Software_list.Name = "Software_list"
        Me.Software_list.Size = New System.Drawing.Size(156, 238)
        Me.Software_list.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(248, 322)
        Me.Controls.Add(Me.Software_list)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Fast-Setup"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Software_list As CheckedListBox
End Class
