<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class logIn
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
        Me.txbUser = New System.Windows.Forms.TextBox()
        Me.txbPassword = New System.Windows.Forms.TextBox()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.btnLogIn = New System.Windows.Forms.Button()
        Me.btnGoCreateUser = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txbUser
        '
        Me.txbUser.Location = New System.Drawing.Point(157, 78)
        Me.txbUser.Name = "txbUser"
        Me.txbUser.Size = New System.Drawing.Size(100, 20)
        Me.txbUser.TabIndex = 0
        '
        'txbPassword
        '
        Me.txbPassword.Location = New System.Drawing.Point(157, 129)
        Me.txbPassword.Name = "txbPassword"
        Me.txbPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(36)
        Me.txbPassword.Size = New System.Drawing.Size(100, 20)
        Me.txbPassword.TabIndex = 1
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Location = New System.Drawing.Point(45, 81)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(44, 13)
        Me.lblUser.TabIndex = 2
        Me.lblUser.Text = "Nombre"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(45, 132)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(61, 13)
        Me.lblPassword.TabIndex = 3
        Me.lblPassword.Text = "Contraseña"
        '
        'btnLogIn
        '
        Me.btnLogIn.Location = New System.Drawing.Point(48, 216)
        Me.btnLogIn.Name = "btnLogIn"
        Me.btnLogIn.Size = New System.Drawing.Size(75, 23)
        Me.btnLogIn.TabIndex = 4
        Me.btnLogIn.Text = "Aceptar"
        Me.btnLogIn.UseVisualStyleBackColor = True
        '
        'btnGoCreateUser
        '
        Me.btnGoCreateUser.Location = New System.Drawing.Point(157, 216)
        Me.btnGoCreateUser.Name = "btnGoCreateUser"
        Me.btnGoCreateUser.Size = New System.Drawing.Size(100, 23)
        Me.btnGoCreateUser.TabIndex = 5
        Me.btnGoCreateUser.Text = "Crear Usuario"
        Me.btnGoCreateUser.UseVisualStyleBackColor = True
        '
        'logIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(297, 322)
        Me.Controls.Add(Me.btnGoCreateUser)
        Me.Controls.Add(Me.btnLogIn)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.txbPassword)
        Me.Controls.Add(Me.txbUser)
        Me.Name = "logIn"
        Me.ShowIcon = False
        Me.Text = "Log In"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txbUser As System.Windows.Forms.TextBox
    Friend WithEvents txbPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents btnLogIn As System.Windows.Forms.Button
    Friend WithEvents btnGoCreateUser As System.Windows.Forms.Button

End Class
