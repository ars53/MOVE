<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.msTop = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddDeleteUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddInsuranceInfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblPrompt = New System.Windows.Forms.Label()
        Me.btnLookup = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnIns = New System.Windows.Forms.Button()
        Me.btnLookupCars = New System.Windows.Forms.Button()
        Me.btnOfficer = New System.Windows.Forms.Button()
        Me.msTop.SuspendLayout()
        Me.SuspendLayout()
        '
        'msTop
        '
        Me.msTop.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.AddDeleteUserToolStripMenuItem, Me.AddInsuranceInfoToolStripMenuItem})
        Me.msTop.Location = New System.Drawing.Point(0, 0)
        Me.msTop.Name = "msTop"
        Me.msTop.Size = New System.Drawing.Size(437, 24)
        Me.msTop.TabIndex = 0
        Me.msTop.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MainMenuToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'MainMenuToolStripMenuItem
        '
        Me.MainMenuToolStripMenuItem.Enabled = False
        Me.MainMenuToolStripMenuItem.Name = "MainMenuToolStripMenuItem"
        Me.MainMenuToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.MainMenuToolStripMenuItem.Text = "Main Menu"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'AddDeleteUserToolStripMenuItem
        '
        Me.AddDeleteUserToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddUserToolStripMenuItem})
        Me.AddDeleteUserToolStripMenuItem.Name = "AddDeleteUserToolStripMenuItem"
        Me.AddDeleteUserToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.AddDeleteUserToolStripMenuItem.Text = "User Info"
        '
        'AddUserToolStripMenuItem
        '
        Me.AddUserToolStripMenuItem.Name = "AddUserToolStripMenuItem"
        Me.AddUserToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.AddUserToolStripMenuItem.Text = "Add User"
        '
        'AddInsuranceInfoToolStripMenuItem
        '
        Me.AddInsuranceInfoToolStripMenuItem.Name = "AddInsuranceInfoToolStripMenuItem"
        Me.AddInsuranceInfoToolStripMenuItem.Size = New System.Drawing.Size(119, 20)
        Me.AddInsuranceInfoToolStripMenuItem.Text = "Add Insurance Info"
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(12, 24)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(376, 101)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Welcome to the Motor Operators Vehicular Repository Database System"
        '
        'lblPrompt
        '
        Me.lblPrompt.AutoSize = True
        Me.lblPrompt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrompt.Location = New System.Drawing.Point(13, 143)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.Size = New System.Drawing.Size(217, 24)
        Me.lblPrompt.TabIndex = 2
        Me.lblPrompt.Text = "What do you want to do?"
        '
        'btnLookup
        '
        Me.btnLookup.Location = New System.Drawing.Point(44, 235)
        Me.btnLookup.Name = "btnLookup"
        Me.btnLookup.Size = New System.Drawing.Size(85, 23)
        Me.btnLookup.TabIndex = 3
        Me.btnLookup.Text = "&Lookup User"
        Me.btnLookup.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(46, 275)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(342, 47)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "&Quit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnIns
        '
        Me.btnIns.Location = New System.Drawing.Point(135, 235)
        Me.btnIns.Name = "btnIns"
        Me.btnIns.Size = New System.Drawing.Size(120, 23)
        Me.btnIns.TabIndex = 8
        Me.btnIns.Text = "Add Insurance Info"
        Me.btnIns.UseVisualStyleBackColor = True
        '
        'btnLookupCars
        '
        Me.btnLookupCars.Location = New System.Drawing.Point(261, 235)
        Me.btnLookupCars.Name = "btnLookupCars"
        Me.btnLookupCars.Size = New System.Drawing.Size(150, 23)
        Me.btnLookupCars.TabIndex = 9
        Me.btnLookupCars.Text = "Lookup Vehicle Information"
        Me.btnLookupCars.UseVisualStyleBackColor = True
        '
        'btnOfficer
        '
        Me.btnOfficer.Location = New System.Drawing.Point(135, 206)
        Me.btnOfficer.Name = "btnOfficer"
        Me.btnOfficer.Size = New System.Drawing.Size(120, 23)
        Me.btnOfficer.TabIndex = 10
        Me.btnOfficer.Text = "Officer Interface"
        Me.btnOfficer.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(437, 347)
        Me.Controls.Add(Me.btnOfficer)
        Me.Controls.Add(Me.btnLookupCars)
        Me.Controls.Add(Me.btnIns)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnLookup)
        Me.Controls.Add(Me.lblPrompt)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.msTop)
        Me.MainMenuStrip = Me.msTop
        Me.Name = "Main"
        Me.Text = "Main"
        Me.msTop.ResumeLayout(False)
        Me.msTop.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents msTop As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MainMenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddDeleteUserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblPrompt As Label
    Friend WithEvents btnLookup As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents AddInsuranceInfoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnIns As Button
    Friend WithEvents AddUserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnLookupCars As Button
    Friend WithEvents btnOfficer As Button
End Class
