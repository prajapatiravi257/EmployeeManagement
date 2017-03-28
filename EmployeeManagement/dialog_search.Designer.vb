<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dialog_search
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
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.gb_search = New System.Windows.Forms.GroupBox()
        Me.tb_search_id = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gb_search.SuspendLayout()
        Me.SuspendLayout()
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(279, 24)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(96, 27)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "SEARCH"
        '
        'gb_search
        '
        Me.gb_search.Controls.Add(Me.OK_Button)
        Me.gb_search.Controls.Add(Me.tb_search_id)
        Me.gb_search.Controls.Add(Me.Label1)
        Me.gb_search.Location = New System.Drawing.Point(14, 10)
        Me.gb_search.Name = "gb_search"
        Me.gb_search.Size = New System.Drawing.Size(381, 83)
        Me.gb_search.TabIndex = 3
        Me.gb_search.TabStop = False
        Me.gb_search.Text = "Employee Search"
        '
        'tb_search_id
        '
        Me.tb_search_id.Location = New System.Drawing.Point(103, 27)
        Me.tb_search_id.Name = "tb_search_id"
        Me.tb_search_id.Size = New System.Drawing.Size(138, 23)
        Me.tb_search_id.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Employee ID"
        '
        'dialog_search
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(407, 107)
        Me.Controls.Add(Me.gb_search)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dialog_search"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Search"
        Me.gb_search.ResumeLayout(False)
        Me.gb_search.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents gb_search As GroupBox
    Friend WithEvents tb_search_id As TextBox
    Friend WithEvents Label1 As Label
End Class
