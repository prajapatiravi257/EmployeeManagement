<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class frm_login
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
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_username As System.Windows.Forms.Label
    Friend WithEvents lbl_passwd As System.Windows.Forms.Label
    Friend WithEvents tb_username As System.Windows.Forms.TextBox
    Friend WithEvents tb_passwd As System.Windows.Forms.TextBox
    Friend WithEvents btn_login As System.Windows.Forms.Button
    Friend WithEvents btn_cancel As System.Windows.Forms.Button

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_login))
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.lbl_username = New System.Windows.Forms.Label()
        Me.lbl_passwd = New System.Windows.Forms.Label()
        Me.tb_username = New System.Windows.Forms.TextBox()
        Me.tb_passwd = New System.Windows.Forms.TextBox()
        Me.btn_login = New System.Windows.Forms.Button()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.llbl_forgotpasswd = New System.Windows.Forms.LinkLabel()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.Image = Global.EmployeeManagement.My.Resources.Resources.login_user_profile
        Me.LogoPictureBox.Location = New System.Drawing.Point(0, 0)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(192, 223)
        Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LogoPictureBox.TabIndex = 0
        Me.LogoPictureBox.TabStop = False
        '
        'lbl_username
        '
        Me.lbl_username.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_username.Location = New System.Drawing.Point(201, 28)
        Me.lbl_username.Name = "lbl_username"
        Me.lbl_username.Size = New System.Drawing.Size(257, 27)
        Me.lbl_username.TabIndex = 0
        Me.lbl_username.Text = "&User name"
        Me.lbl_username.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_passwd
        '
        Me.lbl_passwd.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_passwd.Location = New System.Drawing.Point(201, 87)
        Me.lbl_passwd.Name = "lbl_passwd"
        Me.lbl_passwd.Size = New System.Drawing.Size(257, 27)
        Me.lbl_passwd.TabIndex = 2
        Me.lbl_passwd.Text = "&Password"
        Me.lbl_passwd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tb_username
        '
        Me.tb_username.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.tb_username.Location = New System.Drawing.Point(204, 58)
        Me.tb_username.MaxLength = 15
        Me.tb_username.Name = "tb_username"
        Me.tb_username.Size = New System.Drawing.Size(256, 23)
        Me.tb_username.TabIndex = 1
        '
        'tb_passwd
        '
        Me.tb_passwd.Location = New System.Drawing.Point(203, 117)
        Me.tb_passwd.Name = "tb_passwd"
        Me.tb_passwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tb_passwd.Size = New System.Drawing.Size(256, 23)
        Me.tb_passwd.TabIndex = 3
        '
        'btn_login
        '
        Me.btn_login.Location = New System.Drawing.Point(230, 186)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(110, 27)
        Me.btn_login.TabIndex = 4
        Me.btn_login.Text = "&Login"
        '
        'btn_cancel
        '
        Me.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_cancel.Location = New System.Drawing.Point(350, 186)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(110, 27)
        Me.btn_cancel.TabIndex = 5
        Me.btn_cancel.Text = "&Cancel"
        '
        'llbl_forgotpasswd
        '
        Me.llbl_forgotpasswd.AutoSize = True
        Me.llbl_forgotpasswd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.llbl_forgotpasswd.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llbl_forgotpasswd.LinkColor = System.Drawing.Color.Blue
        Me.llbl_forgotpasswd.Location = New System.Drawing.Point(360, 152)
        Me.llbl_forgotpasswd.Name = "llbl_forgotpasswd"
        Me.llbl_forgotpasswd.Size = New System.Drawing.Size(99, 15)
        Me.llbl_forgotpasswd.TabIndex = 6
        Me.llbl_forgotpasswd.TabStop = True
        Me.llbl_forgotpasswd.Text = "Forgot password ?"
        Me.llbl_forgotpasswd.VisitedLinkColor = System.Drawing.Color.Blue
        '
        'frm_login
        '
        Me.AcceptButton = Me.btn_login
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btn_cancel
        Me.ClientSize = New System.Drawing.Size(480, 222)
        Me.Controls.Add(Me.llbl_forgotpasswd)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_login)
        Me.Controls.Add(Me.tb_passwd)
        Me.Controls.Add(Me.tb_username)
        Me.Controls.Add(Me.lbl_passwd)
        Me.Controls.Add(Me.lbl_username)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(50, 50)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_login"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents llbl_forgotpasswd As LinkLabel
End Class
