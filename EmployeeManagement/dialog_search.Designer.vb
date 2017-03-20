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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.gb_search = New System.Windows.Forms.GroupBox()
        Me.tb_search_name = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tb_search_id = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_search_note = New System.Windows.Forms.Label()
        Me.tb_search_lastname = New System.Windows.Forms.TextBox()
        Me.lbl_search_lastname = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.gb_search.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(279, 143)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'gb_search
        '
        Me.gb_search.Controls.Add(Me.lbl_search_note)
        Me.gb_search.Controls.Add(Me.tb_search_lastname)
        Me.gb_search.Controls.Add(Me.lbl_search_lastname)
        Me.gb_search.Controls.Add(Me.tb_search_name)
        Me.gb_search.Controls.Add(Me.Label2)
        Me.gb_search.Controls.Add(Me.tb_search_id)
        Me.gb_search.Controls.Add(Me.Label1)
        Me.gb_search.Location = New System.Drawing.Point(12, 24)
        Me.gb_search.Name = "gb_search"
        Me.gb_search.Size = New System.Drawing.Size(415, 104)
        Me.gb_search.TabIndex = 3
        Me.gb_search.TabStop = False
        Me.gb_search.Text = "Employee Search"
        '
        'tb_search_name
        '
        Me.tb_search_name.Location = New System.Drawing.Point(77, 32)
        Me.tb_search_name.Name = "tb_search_name"
        Me.tb_search_name.Size = New System.Drawing.Size(111, 20)
        Me.tb_search_name.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Firstname"
        '
        'tb_search_id
        '
        Me.tb_search_id.Location = New System.Drawing.Point(77, 64)
        Me.tb_search_id.Name = "tb_search_id"
        Me.tb_search_id.Size = New System.Drawing.Size(58, 20)
        Me.tb_search_id.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Emp ID"
        '
        'lbl_search_note
        '
        Me.lbl_search_note.AutoSize = True
        Me.lbl_search_note.Location = New System.Drawing.Point(166, 67)
        Me.lbl_search_note.Name = "lbl_search_note"
        Me.lbl_search_note.Size = New System.Drawing.Size(235, 13)
        Me.lbl_search_note.TabIndex = 6
        Me.lbl_search_note.Text = "NOTE: Search with ID or Name of the Employee"
        '
        'tb_search_lastname
        '
        Me.tb_search_lastname.Location = New System.Drawing.Point(264, 32)
        Me.tb_search_lastname.Name = "tb_search_lastname"
        Me.tb_search_lastname.Size = New System.Drawing.Size(137, 20)
        Me.tb_search_lastname.TabIndex = 8
        '
        'lbl_search_lastname
        '
        Me.lbl_search_lastname.AutoSize = True
        Me.lbl_search_lastname.Location = New System.Drawing.Point(204, 35)
        Me.lbl_search_lastname.Name = "lbl_search_lastname"
        Me.lbl_search_lastname.Size = New System.Drawing.Size(53, 13)
        Me.lbl_search_lastname.TabIndex = 7
        Me.lbl_search_lastname.Text = "Lastname"
        '
        'dialog_search
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(437, 181)
        Me.Controls.Add(Me.gb_search)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dialog_search"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Search"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.gb_search.ResumeLayout(False)
        Me.gb_search.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents gb_search As GroupBox
    Friend WithEvents tb_search_name As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tb_search_id As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_search_note As Label
    Friend WithEvents tb_search_lastname As TextBox
    Friend WithEvents lbl_search_lastname As Label
End Class
