<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddDepartament
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
        Me.txbName = New System.Windows.Forms.TextBox()
        Me.txbDescription = New System.Windows.Forms.TextBox()
        Me.cbxManager = New System.Windows.Forms.ComboBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnDepartament = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txbName
        '
        Me.txbName.Location = New System.Drawing.Point(341, 90)
        Me.txbName.Name = "txbName"
        Me.txbName.Size = New System.Drawing.Size(100, 20)
        Me.txbName.TabIndex = 0
        '
        'txbDescription
        '
        Me.txbDescription.Location = New System.Drawing.Point(341, 116)
        Me.txbDescription.Name = "txbDescription"
        Me.txbDescription.Size = New System.Drawing.Size(100, 20)
        Me.txbDescription.TabIndex = 1
        '
        'cbxManager
        '
        Me.cbxManager.FormattingEnabled = True
        Me.cbxManager.Location = New System.Drawing.Point(341, 153)
        Me.cbxManager.Name = "cbxManager"
        Me.cbxManager.Size = New System.Drawing.Size(121, 21)
        Me.cbxManager.TabIndex = 2
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(71, 93)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(35, 13)
        Me.lblName.TabIndex = 3
        Me.lblName.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(71, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Descripcion"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(71, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Lider"
        '
        'btnDepartament
        '
        Me.btnDepartament.Location = New System.Drawing.Point(166, 216)
        Me.btnDepartament.Name = "btnDepartament"
        Me.btnDepartament.Size = New System.Drawing.Size(174, 28)
        Me.btnDepartament.TabIndex = 6
        Me.btnDepartament.Text = "Aceptar"
        Me.btnDepartament.UseVisualStyleBackColor = True
        '
        'AddDepartament
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(508, 295)
        Me.Controls.Add(Me.btnDepartament)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.cbxManager)
        Me.Controls.Add(Me.txbDescription)
        Me.Controls.Add(Me.txbName)
        Me.Name = "AddDepartament"
        Me.ShowIcon = False
        Me.Text = "Inserte los datos del nuevos departamento"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txbName As System.Windows.Forms.TextBox
    Friend WithEvents txbDescription As System.Windows.Forms.TextBox
    Friend WithEvents cbxManager As System.Windows.Forms.ComboBox
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnDepartament As System.Windows.Forms.Button

End Class
