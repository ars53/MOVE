<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Lookup
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
        Me.msMain = New System.Windows.Forms.MenuStrip()
        Me.MainToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LookupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddDeleteUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateUserInfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblLookup = New System.Windows.Forms.Label()
        Me.txtDL = New System.Windows.Forms.TextBox()
        Me.dgvLookup = New System.Windows.Forms.DataGridView()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.msMain.SuspendLayout()
        CType(Me.dgvLookup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'msMain
        '
        Me.msMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MainToolStripMenuItem, Me.LookupToolStripMenuItem, Me.AddDeleteUserToolStripMenuItem, Me.UpdateUserInfoToolStripMenuItem})
        Me.msMain.Location = New System.Drawing.Point(0, 0)
        Me.msMain.Name = "msMain"
        Me.msMain.Size = New System.Drawing.Size(532, 24)
        Me.msMain.TabIndex = 0
        Me.msMain.Text = "MenuStrip1"
        '
        'MainToolStripMenuItem
        '
        Me.MainToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MainMenuToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MainToolStripMenuItem.Name = "MainToolStripMenuItem"
        Me.MainToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.MainToolStripMenuItem.Text = "File"
        '
        'MainMenuToolStripMenuItem
        '
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
        'LookupToolStripMenuItem
        '
        Me.LookupToolStripMenuItem.Enabled = False
        Me.LookupToolStripMenuItem.Name = "LookupToolStripMenuItem"
        Me.LookupToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.LookupToolStripMenuItem.Text = "Lookup"
        '
        'AddDeleteUserToolStripMenuItem
        '
        Me.AddDeleteUserToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToolStripMenuItem, Me.DeleteToolStripMenuItem})
        Me.AddDeleteUserToolStripMenuItem.Name = "AddDeleteUserToolStripMenuItem"
        Me.AddDeleteUserToolStripMenuItem.Size = New System.Drawing.Size(105, 20)
        Me.AddDeleteUserToolStripMenuItem.Text = "Add/Delete User"
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AddToolStripMenuItem.Text = "Add"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'UpdateUserInfoToolStripMenuItem
        '
        Me.UpdateUserInfoToolStripMenuItem.Name = "UpdateUserInfoToolStripMenuItem"
        Me.UpdateUserInfoToolStripMenuItem.Size = New System.Drawing.Size(107, 20)
        Me.UpdateUserInfoToolStripMenuItem.Text = "Update User Info"
        '
        'lblLookup
        '
        Me.lblLookup.AutoSize = True
        Me.lblLookup.Location = New System.Drawing.Point(13, 28)
        Me.lblLookup.Name = "lblLookup"
        Me.lblLookup.Size = New System.Drawing.Size(143, 13)
        Me.lblLookup.TabIndex = 1
        Me.lblLookup.Text = "Enter Driver License Number"
        '
        'txtDL
        '
        Me.txtDL.Location = New System.Drawing.Point(13, 45)
        Me.txtDL.Name = "txtDL"
        Me.txtDL.Size = New System.Drawing.Size(143, 20)
        Me.txtDL.TabIndex = 2
        '
        'dgvLookup
        '
        Me.dgvLookup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLookup.Location = New System.Drawing.Point(13, 81)
        Me.dgvLookup.Name = "dgvLookup"
        Me.dgvLookup.Size = New System.Drawing.Size(489, 341)
        Me.dgvLookup.TabIndex = 3
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(191, 41)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(75, 23)
        Me.btnLoad.TabIndex = 4
        Me.btnLoad.Text = "GO"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(325, 43)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(111, 23)
        Me.btnUpdate.TabIndex = 5
        Me.btnUpdate.Text = "Update Information"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'Lookup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 434)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.dgvLookup)
        Me.Controls.Add(Me.txtDL)
        Me.Controls.Add(Me.lblLookup)
        Me.Controls.Add(Me.msMain)
        Me.MainMenuStrip = Me.msMain
        Me.Name = "Lookup"
        Me.Text = "Lookup"
        Me.msMain.ResumeLayout(False)
        Me.msMain.PerformLayout()
        CType(Me.dgvLookup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents msMain As MenuStrip
    Friend WithEvents MainToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MainMenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LookupToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddDeleteUserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateUserInfoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblLookup As Label
    Friend WithEvents txtDL As TextBox
    Friend WithEvents dgvLookup As DataGridView
    Friend WithEvents btnLoad As Button
    Friend WithEvents btnUpdate As Button
End Class
