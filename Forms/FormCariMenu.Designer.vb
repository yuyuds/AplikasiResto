<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormCariMenu
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCariMenu = New System.Windows.Forms.TextBox()
        Me.LVCariMenu = New System.Windows.Forms.ListView()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCariMenu)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(353, 57)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Inputkan nama menu"
        '
        'txtCariMenu
        '
        Me.txtCariMenu.Location = New System.Drawing.Point(16, 19)
        Me.txtCariMenu.Name = "txtCariMenu"
        Me.txtCariMenu.Size = New System.Drawing.Size(316, 20)
        Me.txtCariMenu.TabIndex = 5
        '
        'LVCariMenu
        '
        Me.LVCariMenu.HideSelection = False
        Me.LVCariMenu.Location = New System.Drawing.Point(12, 92)
        Me.LVCariMenu.Name = "LVCariMenu"
        Me.LVCariMenu.Size = New System.Drawing.Size(472, 300)
        Me.LVCariMenu.TabIndex = 34
        Me.LVCariMenu.UseCompatibleStateImageBehavior = False
        '
        'FormCariMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(502, 415)
        Me.Controls.Add(Me.LVCariMenu)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormCariMenu"
        Me.Text = "FormCariMenu"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtCariMenu As TextBox
    Friend WithEvents LVCariMenu As ListView
End Class
