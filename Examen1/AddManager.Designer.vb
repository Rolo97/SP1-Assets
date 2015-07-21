<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddManager
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
        Me.cbxChoseUser = New System.Windows.Forms.ComboBox()
        Me.btnAddManager = New System.Windows.Forms.Button()
        Me.btnCancelManager = New System.Windows.Forms.Button()
        Me.lblManager = New System.Windows.Forms.Label()
        Me.txbDescriptionManager = New System.Windows.Forms.TextBox()
        Me.lblDescriptionManager = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cbxChoseUser
        '
        Me.cbxChoseUser.FormattingEnabled = True
        Me.cbxChoseUser.Location = New System.Drawing.Point(171, 100)
        Me.cbxChoseUser.Name = "cbxChoseUser"
        Me.cbxChoseUser.Size = New System.Drawing.Size(121, 21)
        Me.cbxChoseUser.TabIndex = 0
        '
        'btnAddManager
        '
        Me.btnAddManager.Location = New System.Drawing.Point(104, 208)
        Me.btnAddManager.Name = "btnAddManager"
        Me.btnAddManager.Size = New System.Drawing.Size(75, 23)
        Me.btnAddManager.TabIndex = 1
        Me.btnAddManager.Text = "Agregar"
        Me.btnAddManager.UseVisualStyleBackColor = True
        '
        'btnCancelManager
        '
        Me.btnCancelManager.Location = New System.Drawing.Point(235, 208)
        Me.btnCancelManager.Name = "btnCancelManager"
        Me.btnCancelManager.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelManager.TabIndex = 2
        Me.btnCancelManager.Text = "Cancelar"
        Me.btnCancelManager.UseVisualStyleBackColor = True
        '
        'lblManager
        '
        Me.lblManager.AutoSize = True
        Me.lblManager.Location = New System.Drawing.Point(30, 103)
        Me.lblManager.Name = "lblManager"
        Me.lblManager.Size = New System.Drawing.Size(114, 13)
        Me.lblManager.TabIndex = 3
        Me.lblManager.Text = "Escojer nuevo gerente"
        '
        'txbDescriptionManager
        '
        Me.txbDescriptionManager.Location = New System.Drawing.Point(222, 154)
        Me.txbDescriptionManager.Name = "txbDescriptionManager"
        Me.txbDescriptionManager.Size = New System.Drawing.Size(121, 20)
        Me.txbDescriptionManager.TabIndex = 4
        '
        'lblDescriptionManager
        '
        Me.lblDescriptionManager.AutoSize = True
        Me.lblDescriptionManager.Location = New System.Drawing.Point(30, 154)
        Me.lblDescriptionManager.Name = "lblDescriptionManager"
        Me.lblDescriptionManager.Size = New System.Drawing.Size(163, 13)
        Me.lblDescriptionManager.TabIndex = 5
        Me.lblDescriptionManager.Text = "Describir funcion o departamento"
        '
        'AddManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(403, 262)
        Me.Controls.Add(Me.lblDescriptionManager)
        Me.Controls.Add(Me.txbDescriptionManager)
        Me.Controls.Add(Me.lblManager)
        Me.Controls.Add(Me.btnCancelManager)
        Me.Controls.Add(Me.btnAddManager)
        Me.Controls.Add(Me.cbxChoseUser)
        Me.MaximizeBox = False
        Me.Name = "AddManager"
        Me.ShowIcon = False
        Me.Text = "Escoja el usuario que sera gerente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbxChoseUser As System.Windows.Forms.ComboBox
    Friend WithEvents btnAddManager As System.Windows.Forms.Button
    Friend WithEvents btnCancelManager As System.Windows.Forms.Button
    Friend WithEvents lblManager As System.Windows.Forms.Label
    Friend WithEvents txbDescriptionManager As System.Windows.Forms.TextBox
    Friend WithEvents lblDescriptionManager As System.Windows.Forms.Label
End Class
