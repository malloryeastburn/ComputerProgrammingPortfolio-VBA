<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.mnuMainMenu = New System.Windows.Forms.MenuStrip()
        Me.mnuMainMenuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMainMenuAboutMe = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMainMenuFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMainMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuMainMenu
        '
        Me.mnuMainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuMainMenuFile, Me.mnuMainMenuAboutMe})
        Me.mnuMainMenu.Location = New System.Drawing.Point(0, 0)
        Me.mnuMainMenu.Name = "mnuMainMenu"
        Me.mnuMainMenu.Size = New System.Drawing.Size(784, 24)
        Me.mnuMainMenu.TabIndex = 0
        Me.mnuMainMenu.Text = "MenuStrip1"
        '
        'mnuMainMenuFile
        '
        Me.mnuMainMenuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuMainMenuFileExit})
        Me.mnuMainMenuFile.Name = "mnuMainMenuFile"
        Me.mnuMainMenuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuMainMenuFile.Text = "&File"
        '
        'mnuMainMenuAboutMe
        '
        Me.mnuMainMenuAboutMe.Name = "mnuMainMenuAboutMe"
        Me.mnuMainMenuAboutMe.Size = New System.Drawing.Size(72, 20)
        Me.mnuMainMenuAboutMe.Text = "&About Me"
        '
        'mnuMainMenuFileExit
        '
        Me.mnuMainMenuFileExit.Name = "mnuMainMenuFileExit"
        Me.mnuMainMenuFileExit.Size = New System.Drawing.Size(180, 22)
        Me.mnuMainMenuFileExit.Text = "E&xit"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(784, 461)
        Me.Controls.Add(Me.mnuMainMenu)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.mnuMainMenu
        Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Computer Programming Portfolio - Mallory Eastburn"
        Me.mnuMainMenu.ResumeLayout(False)
        Me.mnuMainMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuMainMenu As MenuStrip
    Friend WithEvents mnuMainMenuFile As ToolStripMenuItem
    Friend WithEvents mnuMainMenuFileExit As ToolStripMenuItem
    Friend WithEvents mnuMainMenuAboutMe As ToolStripMenuItem
End Class
