<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateUser
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
        Me.txbIdNumberUser = New System.Windows.Forms.TextBox()
        Me.txbNameUser = New System.Windows.Forms.TextBox()
        Me.txbAgeUser = New System.Windows.Forms.TextBox()
        Me.txbPhoneNumberUser = New System.Windows.Forms.TextBox()
        Me.txbEmailUser = New System.Windows.Forms.TextBox()
        Me.txbSexUser = New System.Windows.Forms.TextBox()
        Me.lblNameUser = New System.Windows.Forms.Label()
        Me.lblIdNumber = New System.Windows.Forms.Label()
        Me.lblAgeUser = New System.Windows.Forms.Label()
        Me.lblSexUser = New System.Windows.Forms.Label()
        Me.lblPhoneNumber = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.btnCreateUser = New System.Windows.Forms.Button()
        Me.btnCancelCreateUser = New System.Windows.Forms.Button()
        Me.LblHeadLine = New System.Windows.Forms.Label()
        Me.lblPasswordUser = New System.Windows.Forms.Label()
        Me.txbPasswordUser = New System.Windows.Forms.TextBox()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.txbUserName = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txbIdNumberUser
        '
        Me.txbIdNumberUser.Location = New System.Drawing.Point(179, 139)
        Me.txbIdNumberUser.Name = "txbIdNumberUser"
        Me.txbIdNumberUser.Size = New System.Drawing.Size(132, 20)
        Me.txbIdNumberUser.TabIndex = 1
        '
        'txbNameUser
        '
        Me.txbNameUser.Location = New System.Drawing.Point(179, 65)
        Me.txbNameUser.Name = "txbNameUser"
        Me.txbNameUser.Size = New System.Drawing.Size(132, 20)
        Me.txbNameUser.TabIndex = 2
        '
        'txbAgeUser
        '
        Me.txbAgeUser.Location = New System.Drawing.Point(179, 178)
        Me.txbAgeUser.Name = "txbAgeUser"
        Me.txbAgeUser.Size = New System.Drawing.Size(132, 20)
        Me.txbAgeUser.TabIndex = 3
        '
        'txbPhoneNumberUser
        '
        Me.txbPhoneNumberUser.Location = New System.Drawing.Point(179, 258)
        Me.txbPhoneNumberUser.Name = "txbPhoneNumberUser"
        Me.txbPhoneNumberUser.Size = New System.Drawing.Size(132, 20)
        Me.txbPhoneNumberUser.TabIndex = 4
        '
        'txbEmailUser
        '
        Me.txbEmailUser.Location = New System.Drawing.Point(179, 295)
        Me.txbEmailUser.Name = "txbEmailUser"
        Me.txbEmailUser.Size = New System.Drawing.Size(132, 20)
        Me.txbEmailUser.TabIndex = 5
        '
        'txbSexUser
        '
        Me.txbSexUser.Location = New System.Drawing.Point(179, 221)
        Me.txbSexUser.Name = "txbSexUser"
        Me.txbSexUser.Size = New System.Drawing.Size(132, 20)
        Me.txbSexUser.TabIndex = 6
        '
        'lblNameUser
        '
        Me.lblNameUser.AutoSize = True
        Me.lblNameUser.Location = New System.Drawing.Point(48, 68)
        Me.lblNameUser.Name = "lblNameUser"
        Me.lblNameUser.Size = New System.Drawing.Size(44, 13)
        Me.lblNameUser.TabIndex = 7
        Me.lblNameUser.Text = "Nombre"
        '
        'lblIdNumber
        '
        Me.lblIdNumber.AutoSize = True
        Me.lblIdNumber.Location = New System.Drawing.Point(48, 142)
        Me.lblIdNumber.Name = "lblIdNumber"
        Me.lblIdNumber.Size = New System.Drawing.Size(70, 13)
        Me.lblIdNumber.TabIndex = 8
        Me.lblIdNumber.Text = "Identificacion"
        '
        'lblAgeUser
        '
        Me.lblAgeUser.AutoSize = True
        Me.lblAgeUser.Location = New System.Drawing.Point(48, 181)
        Me.lblAgeUser.Name = "lblAgeUser"
        Me.lblAgeUser.Size = New System.Drawing.Size(32, 13)
        Me.lblAgeUser.TabIndex = 9
        Me.lblAgeUser.Text = "Edad"
        '
        'lblSexUser
        '
        Me.lblSexUser.AutoSize = True
        Me.lblSexUser.Location = New System.Drawing.Point(48, 224)
        Me.lblSexUser.Name = "lblSexUser"
        Me.lblSexUser.Size = New System.Drawing.Size(31, 13)
        Me.lblSexUser.TabIndex = 10
        Me.lblSexUser.Text = "Sexo"
        '
        'lblPhoneNumber
        '
        Me.lblPhoneNumber.AutoSize = True
        Me.lblPhoneNumber.Location = New System.Drawing.Point(48, 261)
        Me.lblPhoneNumber.Name = "lblPhoneNumber"
        Me.lblPhoneNumber.Size = New System.Drawing.Size(49, 13)
        Me.lblPhoneNumber.TabIndex = 11
        Me.lblPhoneNumber.Text = "Telefono"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(48, 298)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(36, 13)
        Me.lblEmail.TabIndex = 12
        Me.lblEmail.Text = "E-Mail"
        '
        'btnCreateUser
        '
        Me.btnCreateUser.Location = New System.Drawing.Point(51, 381)
        Me.btnCreateUser.Name = "btnCreateUser"
        Me.btnCreateUser.Size = New System.Drawing.Size(75, 23)
        Me.btnCreateUser.TabIndex = 13
        Me.btnCreateUser.Text = "Aceptar"
        Me.btnCreateUser.UseVisualStyleBackColor = True
        '
        'btnCancelCreateUser
        '
        Me.btnCancelCreateUser.Location = New System.Drawing.Point(221, 381)
        Me.btnCancelCreateUser.Name = "btnCancelCreateUser"
        Me.btnCancelCreateUser.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelCreateUser.TabIndex = 14
        Me.btnCancelCreateUser.Text = "Cancelar"
        Me.btnCancelCreateUser.UseVisualStyleBackColor = True
        '
        'LblHeadLine
        '
        Me.LblHeadLine.AutoSize = True
        Me.LblHeadLine.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHeadLine.Location = New System.Drawing.Point(78, 19)
        Me.LblHeadLine.Name = "LblHeadLine"
        Me.LblHeadLine.Size = New System.Drawing.Size(198, 24)
        Me.LblHeadLine.TabIndex = 15
        Me.LblHeadLine.Text = "Introdusca los Datos"
        '
        'lblPasswordUser
        '
        Me.lblPasswordUser.AutoSize = True
        Me.lblPasswordUser.Location = New System.Drawing.Point(48, 331)
        Me.lblPasswordUser.Name = "lblPasswordUser"
        Me.lblPasswordUser.Size = New System.Drawing.Size(61, 13)
        Me.lblPasswordUser.TabIndex = 16
        Me.lblPasswordUser.Text = "Contraseña"
        '
        'txbPasswordUser
        '
        Me.txbPasswordUser.Location = New System.Drawing.Point(179, 328)
        Me.txbPasswordUser.Name = "txbPasswordUser"
        Me.txbPasswordUser.Size = New System.Drawing.Size(132, 20)
        Me.txbPasswordUser.TabIndex = 17
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.Location = New System.Drawing.Point(48, 105)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(98, 13)
        Me.lblUserName.TabIndex = 18
        Me.lblUserName.Text = "Nombre de Usuario"
        '
        'txbUserName
        '
        Me.txbUserName.Location = New System.Drawing.Point(179, 102)
        Me.txbUserName.Name = "txbUserName"
        Me.txbUserName.Size = New System.Drawing.Size(132, 20)
        Me.txbUserName.TabIndex = 19
        '
        'CreateUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(347, 452)
        Me.Controls.Add(Me.txbUserName)
        Me.Controls.Add(Me.lblUserName)
        Me.Controls.Add(Me.txbPasswordUser)
        Me.Controls.Add(Me.lblPasswordUser)
        Me.Controls.Add(Me.LblHeadLine)
        Me.Controls.Add(Me.btnCancelCreateUser)
        Me.Controls.Add(Me.btnCreateUser)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblPhoneNumber)
        Me.Controls.Add(Me.lblSexUser)
        Me.Controls.Add(Me.lblAgeUser)
        Me.Controls.Add(Me.lblIdNumber)
        Me.Controls.Add(Me.lblNameUser)
        Me.Controls.Add(Me.txbSexUser)
        Me.Controls.Add(Me.txbEmailUser)
        Me.Controls.Add(Me.txbPhoneNumberUser)
        Me.Controls.Add(Me.txbAgeUser)
        Me.Controls.Add(Me.txbNameUser)
        Me.Controls.Add(Me.txbIdNumberUser)
        Me.Name = "CreateUser"
        Me.ShowIcon = False
        Me.Text = "CreateUser"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txbIdNumberUser As System.Windows.Forms.TextBox
    Friend WithEvents txbNameUser As System.Windows.Forms.TextBox
    Friend WithEvents txbAgeUser As System.Windows.Forms.TextBox
    Friend WithEvents txbPhoneNumberUser As System.Windows.Forms.TextBox
    Friend WithEvents txbEmailUser As System.Windows.Forms.TextBox
    Friend WithEvents txbSexUser As System.Windows.Forms.TextBox
    Friend WithEvents lblNameUser As System.Windows.Forms.Label
    Friend WithEvents lblIdNumber As System.Windows.Forms.Label
    Friend WithEvents lblAgeUser As System.Windows.Forms.Label
    Friend WithEvents lblSexUser As System.Windows.Forms.Label
    Friend WithEvents lblPhoneNumber As System.Windows.Forms.Label
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents btnCreateUser As System.Windows.Forms.Button
    Friend WithEvents btnCancelCreateUser As System.Windows.Forms.Button
    Friend WithEvents LblHeadLine As System.Windows.Forms.Label
    Friend WithEvents lblPasswordUser As System.Windows.Forms.Label
    Friend WithEvents txbPasswordUser As System.Windows.Forms.TextBox
    Friend WithEvents lblUserName As System.Windows.Forms.Label
    Friend WithEvents txbUserName As System.Windows.Forms.TextBox
End Class
