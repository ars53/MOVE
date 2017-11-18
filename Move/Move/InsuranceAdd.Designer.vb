<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InsuranceAdd
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
        Me.LookupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddDeleteUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateUserInfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddInsuranceInfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblPolicyNum = New System.Windows.Forms.Label()
        Me.txtPolicyNum = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lblProvider = New System.Windows.Forms.Label()
        Me.txtProvider = New System.Windows.Forms.TextBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.txtStatus = New System.Windows.Forms.TextBox()
        Me.lblEffDate = New System.Windows.Forms.Label()
        Me.txtEffDate = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblEndDate = New System.Windows.Forms.Label()
        Me.msTop.SuspendLayout()
        Me.SuspendLayout()
        '
        'msTop
        '
        Me.msTop.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.LookupToolStripMenuItem, Me.AddDeleteUserToolStripMenuItem, Me.UpdateUserInfoToolStripMenuItem, Me.AddInsuranceInfoToolStripMenuItem})
        Me.msTop.Location = New System.Drawing.Point(0, 0)
        Me.msTop.Name = "msTop"
        Me.msTop.Size = New System.Drawing.Size(470, 24)
        Me.msTop.TabIndex = 1
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
        Me.MainMenuToolStripMenuItem.Name = "MainMenuToolStripMenuItem"
        Me.MainMenuToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.MainMenuToolStripMenuItem.Text = "Main Menu"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'LookupToolStripMenuItem
        '
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
        'AddInsuranceInfoToolStripMenuItem
        '
        Me.AddInsuranceInfoToolStripMenuItem.Enabled = False
        Me.AddInsuranceInfoToolStripMenuItem.Name = "AddInsuranceInfoToolStripMenuItem"
        Me.AddInsuranceInfoToolStripMenuItem.Size = New System.Drawing.Size(119, 20)
        Me.AddInsuranceInfoToolStripMenuItem.Text = "Add Insurance Info"
        '
        'lblPolicyNum
        '
        Me.lblPolicyNum.AutoSize = True
        Me.lblPolicyNum.Location = New System.Drawing.Point(12, 49)
        Me.lblPolicyNum.Name = "lblPolicyNum"
        Me.lblPolicyNum.Size = New System.Drawing.Size(75, 13)
        Me.lblPolicyNum.TabIndex = 2
        Me.lblPolicyNum.Text = "Policy Number"
        '
        'txtPolicyNum
        '
        Me.txtPolicyNum.Location = New System.Drawing.Point(15, 65)
        Me.txtPolicyNum.Name = "txtPolicyNum"
        Me.txtPolicyNum.Size = New System.Drawing.Size(100, 20)
        Me.txtPolicyNum.TabIndex = 3
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(35, 233)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(400, 76)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'lblProvider
        '
        Me.lblProvider.AutoSize = True
        Me.lblProvider.Location = New System.Drawing.Point(136, 49)
        Me.lblProvider.Name = "lblProvider"
        Me.lblProvider.Size = New System.Drawing.Size(46, 13)
        Me.lblProvider.TabIndex = 5
        Me.lblProvider.Text = "Provider"
        '
        'txtProvider
        '
        Me.txtProvider.Location = New System.Drawing.Point(139, 64)
        Me.txtProvider.Name = "txtProvider"
        Me.txtProvider.Size = New System.Drawing.Size(100, 20)
        Me.txtProvider.TabIndex = 6
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(260, 49)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(37, 13)
        Me.lblStatus.TabIndex = 7
        Me.lblStatus.Text = "Status"
        '
        'txtStatus
        '
        Me.txtStatus.Location = New System.Drawing.Point(245, 65)
        Me.txtStatus.MaxLength = 1
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.Size = New System.Drawing.Size(100, 20)
        Me.txtStatus.TabIndex = 8
        '
        'lblEffDate
        '
        Me.lblEffDate.AutoSize = True
        Me.lblEffDate.Location = New System.Drawing.Point(32, 97)
        Me.lblEffDate.Name = "lblEffDate"
        Me.lblEffDate.Size = New System.Drawing.Size(118, 13)
        Me.lblEffDate.TabIndex = 9
        Me.lblEffDate.Text = "Start Date (yyyy-mm-dd)"
        '
        'txtEffDate
        '
        Me.txtEffDate.Location = New System.Drawing.Point(35, 114)
        Me.txtEffDate.MaxLength = 10
        Me.txtEffDate.Name = "txtEffDate"
        Me.txtEffDate.Size = New System.Drawing.Size(100, 20)
        Me.txtEffDate.TabIndex = 10
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(193, 114)
        Me.TextBox1.MaxLength = 10
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 12
        '
        'lblEndDate
        '
        Me.lblEndDate.AutoSize = True
        Me.lblEndDate.Location = New System.Drawing.Point(190, 97)
        Me.lblEndDate.Name = "lblEndDate"
        Me.lblEndDate.Size = New System.Drawing.Size(115, 13)
        Me.lblEndDate.TabIndex = 11
        Me.lblEndDate.Text = "End Date (yyyy-mm-dd)"
        '
        'InsuranceAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(470, 339)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblEndDate)
        Me.Controls.Add(Me.txtEffDate)
        Me.Controls.Add(Me.lblEffDate)
        Me.Controls.Add(Me.txtStatus)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.txtProvider)
        Me.Controls.Add(Me.lblProvider)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtPolicyNum)
        Me.Controls.Add(Me.lblPolicyNum)
        Me.Controls.Add(Me.msTop)
        Me.Name = "InsuranceAdd"
        Me.Text = "InsuranceAdd"
        Me.msTop.ResumeLayout(False)
        Me.msTop.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents msTop As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MainMenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LookupToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddDeleteUserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateUserInfoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddInsuranceInfoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblPolicyNum As Label
    Friend WithEvents txtPolicyNum As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents lblProvider As Label
    Friend WithEvents txtProvider As TextBox
    Friend WithEvents lblStatus As Label
    Friend WithEvents txtStatus As TextBox
    Friend WithEvents lblEffDate As Label
    Friend WithEvents txtEffDate As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblEndDate As Label
End Class
