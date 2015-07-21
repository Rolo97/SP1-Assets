<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TableOfUsers
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
        Me.dgvTableUsers = New System.Windows.Forms.DataGridView()
        Me.lblListOfUsers = New System.Windows.Forms.Label()
        CType(Me.dgvTableUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvTableUsers
        '
        Me.dgvTableUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTableUsers.Location = New System.Drawing.Point(12, 97)
        Me.dgvTableUsers.Name = "dgvTableUsers"
        Me.dgvTableUsers.Size = New System.Drawing.Size(649, 232)
        Me.dgvTableUsers.TabIndex = 0
        '
        'lblListOfUsers
        '
        Me.lblListOfUsers.AutoSize = True
        Me.lblListOfUsers.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblListOfUsers.Location = New System.Drawing.Point(202, 37)
        Me.lblListOfUsers.Name = "lblListOfUsers"
        Me.lblListOfUsers.Size = New System.Drawing.Size(241, 31)
        Me.lblListOfUsers.TabIndex = 1
        Me.lblListOfUsers.Text = "Lista de Usuarios"
        '
        'TableOfUsers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(677, 444)
        Me.Controls.Add(Me.lblListOfUsers)
        Me.Controls.Add(Me.dgvTableUsers)
        Me.Name = "TableOfUsers"
        Me.ShowIcon = False
        Me.Text = "TableOfUsers"
        CType(Me.dgvTableUsers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvTableUsers As System.Windows.Forms.DataGridView
    Friend WithEvents lblListOfUsers As System.Windows.Forms.Label
End Class
