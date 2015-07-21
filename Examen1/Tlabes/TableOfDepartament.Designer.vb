<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TableOfDepartament
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
        Me.dgvDepartamentsTable = New System.Windows.Forms.DataGridView()
        Me.lblListadeDepartamentos = New System.Windows.Forms.Label()
        Me.btnEdit = New System.Windows.Forms.Button()
        CType(Me.dgvDepartamentsTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvDepartamentsTable
        '
        Me.dgvDepartamentsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDepartamentsTable.Location = New System.Drawing.Point(12, 90)
        Me.dgvDepartamentsTable.Name = "dgvDepartamentsTable"
        Me.dgvDepartamentsTable.Size = New System.Drawing.Size(575, 131)
        Me.dgvDepartamentsTable.TabIndex = 0
        '
        'lblListadeDepartamentos
        '
        Me.lblListadeDepartamentos.AutoSize = True
        Me.lblListadeDepartamentos.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblListadeDepartamentos.Location = New System.Drawing.Point(162, 39)
        Me.lblListadeDepartamentos.Name = "lblListadeDepartamentos"
        Me.lblListadeDepartamentos.Size = New System.Drawing.Size(262, 25)
        Me.lblListadeDepartamentos.TabIndex = 1
        Me.lblListadeDepartamentos.Text = "Lista de Departamentos"
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(56, 277)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(103, 29)
        Me.btnEdit.TabIndex = 2
        Me.btnEdit.Text = "Editar"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'TableOfDepartament
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(599, 349)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.lblListadeDepartamentos)
        Me.Controls.Add(Me.dgvDepartamentsTable)
        Me.Name = "TableOfDepartament"
        Me.Text = "Form2"
        CType(Me.dgvDepartamentsTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvDepartamentsTable As System.Windows.Forms.DataGridView
    Friend WithEvents lblListadeDepartamentos As System.Windows.Forms.Label
    Friend WithEvents btnEdit As System.Windows.Forms.Button
End Class
