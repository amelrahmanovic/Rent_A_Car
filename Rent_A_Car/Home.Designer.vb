<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Home
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItemAuta = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItemKorisnik = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItemDodatnaOprema = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItemAuta, Me.ToolStripMenuItemKorisnik, Me.ToolStripMenuItemDodatnaOprema})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItemAuta
        '
        Me.ToolStripMenuItemAuta.Name = "ToolStripMenuItemAuta"
        Me.ToolStripMenuItemAuta.Size = New System.Drawing.Size(44, 20)
        Me.ToolStripMenuItemAuta.Text = "Auta"
        '
        'ToolStripMenuItemKorisnik
        '
        Me.ToolStripMenuItemKorisnik.Name = "ToolStripMenuItemKorisnik"
        Me.ToolStripMenuItemKorisnik.Size = New System.Drawing.Size(64, 20)
        Me.ToolStripMenuItemKorisnik.Text = "Korisnici"
        '
        'ToolStripMenuItemDodatnaOprema
        '
        Me.ToolStripMenuItemDodatnaOprema.Name = "ToolStripMenuItemDodatnaOprema"
        Me.ToolStripMenuItemDodatnaOprema.Size = New System.Drawing.Size(108, 20)
        Me.ToolStripMenuItemDodatnaOprema.Text = "Dodatna oprema"
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.Name = "Home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItemAuta As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItemKorisnik As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItemDodatnaOprema As ToolStripMenuItem
End Class
