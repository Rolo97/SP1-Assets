<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TableOfAssets
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
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.dgvAssets = New System.Windows.Forms.DataGridView()
        Me.lblListadeDepartamentos = New System.Windows.Forms.Label()
        CType(Me.dgvAssets, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(106, 74)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(118, 43)
        Me.btnUpdate.TabIndex = 42
        Me.btnUpdate.Text = "Actualizar"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(350, 74)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(118, 43)
        Me.btnEdit.TabIndex = 41
        Me.btnEdit.Text = "Editar"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'dgvAssets
        '
        Me.dgvAssets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAssets.Location = New System.Drawing.Point(12, 132)
        Me.dgvAssets.Name = "dgvAssets"
        Me.dgvAssets.Size = New System.Drawing.Size(547, 163)
        Me.dgvAssets.TabIndex = 40
        '
        'lblListadeDepartamentos
        '
        Me.lblListadeDepartamentos.AutoSize = True
        Me.lblListadeDepartamentos.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblListadeDepartamentos.Location = New System.Drawing.Point(117, 32)
        Me.lblListadeDepartamentos.Name = "lblListadeDepartamentos"
        Me.lblListadeDepartamentos.Size = New System.Drawing.Size(334, 25)
        Me.lblListadeDepartamentos.TabIndex = 44
        Me.lblListadeDepartamentos.Text = "Lista de Bienes Institucionales"
        '
        'TableOfAssets
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(573, 319)
        Me.Controls.Add(Me.lblListadeDepartamentos)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.dgvAssets)
        Me.Name = "TableOfAssets"
        Me.Text = "TableOfAssets"
        CType(Me.dgvAssets, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents dgvAssets As System.Windows.Forms.DataGridView
    Friend WithEvents lblListadeDepartamentos As System.Windows.Forms.Label
End Class
