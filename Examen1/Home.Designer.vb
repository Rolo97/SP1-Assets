<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListaDeUsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListaDeDepartamentosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListaDeBienesInstitucionalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListaDeEncargadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ContextMenuStrip3 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(284, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListasToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(50, 20)
        Me.ToolStripMenuItem1.Text = "Menu"
        '
        'ListasToolStripMenuItem
        '
        Me.ListasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListaDeUsuariosToolStripMenuItem, Me.ListaDeDepartamentosToolStripMenuItem, Me.ListaDeBienesInstitucionalesToolStripMenuItem, Me.ListaDeEncargadosToolStripMenuItem})
        Me.ListasToolStripMenuItem.Name = "ListasToolStripMenuItem"
        Me.ListasToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ListasToolStripMenuItem.Text = "Listas"
        '
        'ListaDeUsuariosToolStripMenuItem
        '
        Me.ListaDeUsuariosToolStripMenuItem.Name = "ListaDeUsuariosToolStripMenuItem"
        Me.ListaDeUsuariosToolStripMenuItem.Size = New System.Drawing.Size(230, 22)
        Me.ListaDeUsuariosToolStripMenuItem.Text = "Lista de Usuarios"
        '
        'ListaDeDepartamentosToolStripMenuItem
        '
        Me.ListaDeDepartamentosToolStripMenuItem.Name = "ListaDeDepartamentosToolStripMenuItem"
        Me.ListaDeDepartamentosToolStripMenuItem.Size = New System.Drawing.Size(230, 22)
        Me.ListaDeDepartamentosToolStripMenuItem.Text = "Lista de Departamentos"
        '
        'ListaDeBienesInstitucionalesToolStripMenuItem
        '
        Me.ListaDeBienesInstitucionalesToolStripMenuItem.Name = "ListaDeBienesInstitucionalesToolStripMenuItem"
        Me.ListaDeBienesInstitucionalesToolStripMenuItem.Size = New System.Drawing.Size(230, 22)
        Me.ListaDeBienesInstitucionalesToolStripMenuItem.Text = "Lista de Bienes Institucionales"
        '
        'ListaDeEncargadosToolStripMenuItem
        '
        Me.ListaDeEncargadosToolStripMenuItem.Name = "ListaDeEncargadosToolStripMenuItem"
        Me.ListaDeEncargadosToolStripMenuItem.Size = New System.Drawing.Size(230, 22)
        Me.ListaDeEncargadosToolStripMenuItem.Text = "Lista de Encargados"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(61, 4)
        '
        'ContextMenuStrip3
        '
        Me.ContextMenuStrip3.Name = "ContextMenuStrip3"
        Me.ContextMenuStrip3.Size = New System.Drawing.Size(61, 4)
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Home"
        Me.Text = "Menu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ContextMenuStrip2 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ListaDeUsuariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListaDeDepartamentosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListaDeBienesInstitucionalesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListaDeEncargadosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip3 As System.Windows.Forms.ContextMenuStrip
End Class
