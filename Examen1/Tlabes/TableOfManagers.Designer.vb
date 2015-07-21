<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TableOfManagers
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
        Me.lbllManagers = New System.Windows.Forms.Label()
        Me.dgvListOfManager = New System.Windows.Forms.DataGridView()
        Me.btnUpDate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        CType(Me.dgvListOfManager, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbllManagers
        '
        Me.lbllManagers.AutoSize = True
        Me.lbllManagers.Font = New System.Drawing.Font("Arial Narrow", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllManagers.Location = New System.Drawing.Point(246, 33)
        Me.lbllManagers.Name = "lbllManagers"
        Me.lbllManagers.Size = New System.Drawing.Size(234, 33)
        Me.lbllManagers.TabIndex = 0
        Me.lbllManagers.Text = "Lista de Encargados"
        '
        'dgvListOfManager
        '
        Me.dgvListOfManager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListOfManager.Location = New System.Drawing.Point(105, 78)
        Me.dgvListOfManager.Name = "dgvListOfManager"
        Me.dgvListOfManager.Size = New System.Drawing.Size(502, 179)
        Me.dgvListOfManager.TabIndex = 1
        '
        'btnUpDate
        '
        Me.btnUpDate.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpDate.Location = New System.Drawing.Point(116, 277)
        Me.btnUpDate.Name = "btnUpDate"
        Me.btnUpDate.Size = New System.Drawing.Size(87, 47)
        Me.btnUpDate.TabIndex = 2
        Me.btnUpDate.Text = "Actualizar"
        Me.btnUpDate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(520, 277)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(87, 47)
        Me.btnDelete.TabIndex = 3
        Me.btnDelete.Text = "Eliminar"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'TableOfManagers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(732, 359)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpDate)
        Me.Controls.Add(Me.dgvListOfManager)
        Me.Controls.Add(Me.lbllManagers)
        Me.Name = "TableOfManagers"
        Me.Text = "TableOfManagers"
        CType(Me.dgvListOfManager, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbllManagers As System.Windows.Forms.Label
    Friend WithEvents dgvListOfManager As System.Windows.Forms.DataGridView
    Friend WithEvents btnUpDate As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
End Class
