<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add
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
        Me.grpInfo = New System.Windows.Forms.GroupBox()
        Me.cmbGender = New System.Windows.Forms.ComboBox()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.txtEyeColor = New System.Windows.Forms.TextBox()
        Me.lblEyes = New System.Windows.Forms.Label()
        Me.txtHaircolor = New System.Windows.Forms.TextBox()
        Me.lblHair = New System.Windows.Forms.Label()
        Me.txtWeight = New System.Windows.Forms.TextBox()
        Me.lblWeight = New System.Windows.Forms.Label()
        Me.txtHeight = New System.Windows.Forms.TextBox()
        Me.lblHeight = New System.Windows.Forms.Label()
        Me.txtEndorse = New System.Windows.Forms.TextBox()
        Me.lblEndorsements = New System.Windows.Forms.Label()
        Me.txtExp = New System.Windows.Forms.TextBox()
        Me.lblExp = New System.Windows.Forms.Label()
        Me.txtLType = New System.Windows.Forms.TextBox()
        Me.lblLicenseT = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.lblInsurance = New System.Windows.Forms.Label()
        Me.txtZip = New System.Windows.Forms.TextBox()
        Me.lblZip = New System.Windows.Forms.Label()
        Me.txtCounty = New System.Windows.Forms.TextBox()
        Me.lblCounty = New System.Windows.Forms.Label()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.lblState = New System.Windows.Forms.Label()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.txtMiddleN = New System.Windows.Forms.TextBox()
        Me.lblMiddleN = New System.Windows.Forms.Label()
        Me.txtLastN = New System.Windows.Forms.TextBox()
        Me.lblLastN = New System.Windows.Forms.Label()
        Me.txtFrstN = New System.Windows.Forms.TextBox()
        Me.lblFirstN = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.msMain.SuspendLayout()
        Me.grpInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'msMain
        '
        Me.msMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MainToolStripMenuItem, Me.LookupToolStripMenuItem, Me.AddDeleteUserToolStripMenuItem, Me.UpdateUserInfoToolStripMenuItem})
        Me.msMain.Location = New System.Drawing.Point(0, 0)
        Me.msMain.Name = "msMain"
        Me.msMain.Size = New System.Drawing.Size(598, 24)
        Me.msMain.TabIndex = 1
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
        Me.AddToolStripMenuItem.Enabled = False
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
        'grpInfo
        '
        Me.grpInfo.Controls.Add(Me.Button1)
        Me.grpInfo.Controls.Add(Me.cmbGender)
        Me.grpInfo.Controls.Add(Me.lblGender)
        Me.grpInfo.Controls.Add(Me.txtEyeColor)
        Me.grpInfo.Controls.Add(Me.lblEyes)
        Me.grpInfo.Controls.Add(Me.txtHaircolor)
        Me.grpInfo.Controls.Add(Me.lblHair)
        Me.grpInfo.Controls.Add(Me.txtWeight)
        Me.grpInfo.Controls.Add(Me.lblWeight)
        Me.grpInfo.Controls.Add(Me.txtHeight)
        Me.grpInfo.Controls.Add(Me.lblHeight)
        Me.grpInfo.Controls.Add(Me.txtEndorse)
        Me.grpInfo.Controls.Add(Me.lblEndorsements)
        Me.grpInfo.Controls.Add(Me.txtExp)
        Me.grpInfo.Controls.Add(Me.lblExp)
        Me.grpInfo.Controls.Add(Me.txtLType)
        Me.grpInfo.Controls.Add(Me.lblLicenseT)
        Me.grpInfo.Controls.Add(Me.TextBox5)
        Me.grpInfo.Controls.Add(Me.lblInsurance)
        Me.grpInfo.Controls.Add(Me.txtZip)
        Me.grpInfo.Controls.Add(Me.lblZip)
        Me.grpInfo.Controls.Add(Me.txtCounty)
        Me.grpInfo.Controls.Add(Me.lblCounty)
        Me.grpInfo.Controls.Add(Me.txtState)
        Me.grpInfo.Controls.Add(Me.lblState)
        Me.grpInfo.Controls.Add(Me.txtCity)
        Me.grpInfo.Controls.Add(Me.lblCity)
        Me.grpInfo.Controls.Add(Me.txtAddress)
        Me.grpInfo.Controls.Add(Me.lblAddress)
        Me.grpInfo.Controls.Add(Me.txtMiddleN)
        Me.grpInfo.Controls.Add(Me.lblMiddleN)
        Me.grpInfo.Controls.Add(Me.txtLastN)
        Me.grpInfo.Controls.Add(Me.lblLastN)
        Me.grpInfo.Controls.Add(Me.txtFrstN)
        Me.grpInfo.Controls.Add(Me.lblFirstN)
        Me.grpInfo.Location = New System.Drawing.Point(17, 103)
        Me.grpInfo.Name = "grpInfo"
        Me.grpInfo.Size = New System.Drawing.Size(571, 324)
        Me.grpInfo.TabIndex = 7
        Me.grpInfo.TabStop = False
        Me.grpInfo.Text = "Driver Info"
        '
        'cmbGender
        '
        Me.cmbGender.FormattingEnabled = True
        Me.cmbGender.Items.AddRange(New Object() {"M", "F"})
        Me.cmbGender.Location = New System.Drawing.Point(483, 132)
        Me.cmbGender.Name = "cmbGender"
        Me.cmbGender.Size = New System.Drawing.Size(39, 21)
        Me.cmbGender.TabIndex = 36
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Location = New System.Drawing.Point(480, 115)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(42, 13)
        Me.lblGender.TabIndex = 35
        Me.lblGender.Text = "Gender"
        '
        'txtEyeColor
        '
        Me.txtEyeColor.Location = New System.Drawing.Point(417, 131)
        Me.txtEyeColor.MaxLength = 3
        Me.txtEyeColor.Name = "txtEyeColor"
        Me.txtEyeColor.Size = New System.Drawing.Size(60, 20)
        Me.txtEyeColor.TabIndex = 34
        '
        'lblEyes
        '
        Me.lblEyes.AutoSize = True
        Me.lblEyes.Location = New System.Drawing.Point(414, 115)
        Me.lblEyes.Name = "lblEyes"
        Me.lblEyes.Size = New System.Drawing.Size(52, 13)
        Me.lblEyes.TabIndex = 33
        Me.lblEyes.Text = "Eye Color"
        '
        'txtHaircolor
        '
        Me.txtHaircolor.Location = New System.Drawing.Point(483, 44)
        Me.txtHaircolor.MaxLength = 3
        Me.txtHaircolor.Name = "txtHaircolor"
        Me.txtHaircolor.Size = New System.Drawing.Size(56, 20)
        Me.txtHaircolor.TabIndex = 32
        '
        'lblHair
        '
        Me.lblHair.AutoSize = True
        Me.lblHair.Location = New System.Drawing.Point(480, 27)
        Me.lblHair.Name = "lblHair"
        Me.lblHair.Size = New System.Drawing.Size(53, 13)
        Me.lblHair.TabIndex = 31
        Me.lblHair.Text = "Hair Color"
        '
        'txtWeight
        '
        Me.txtWeight.Location = New System.Drawing.Point(413, 43)
        Me.txtWeight.MaxLength = 3
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Size = New System.Drawing.Size(64, 20)
        Me.txtWeight.TabIndex = 30
        '
        'lblWeight
        '
        Me.lblWeight.AutoSize = True
        Me.lblWeight.Location = New System.Drawing.Point(412, 28)
        Me.lblWeight.Name = "lblWeight"
        Me.lblWeight.Size = New System.Drawing.Size(41, 13)
        Me.lblWeight.TabIndex = 29
        Me.lblWeight.Text = "Weight"
        '
        'txtHeight
        '
        Me.txtHeight.Location = New System.Drawing.Point(338, 43)
        Me.txtHeight.MaxLength = 6
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.Size = New System.Drawing.Size(68, 20)
        Me.txtHeight.TabIndex = 28
        '
        'lblHeight
        '
        Me.lblHeight.AutoSize = True
        Me.lblHeight.Location = New System.Drawing.Point(335, 28)
        Me.lblHeight.Name = "lblHeight"
        Me.lblHeight.Size = New System.Drawing.Size(38, 13)
        Me.lblHeight.TabIndex = 27
        Me.lblHeight.Text = "Height"
        '
        'txtEndorse
        '
        Me.txtEndorse.Location = New System.Drawing.Point(335, 131)
        Me.txtEndorse.MaxLength = 2
        Me.txtEndorse.Name = "txtEndorse"
        Me.txtEndorse.Size = New System.Drawing.Size(71, 20)
        Me.txtEndorse.TabIndex = 26
        '
        'lblEndorsements
        '
        Me.lblEndorsements.AutoSize = True
        Me.lblEndorsements.Location = New System.Drawing.Point(332, 115)
        Me.lblEndorsements.Name = "lblEndorsements"
        Me.lblEndorsements.Size = New System.Drawing.Size(74, 13)
        Me.lblEndorsements.TabIndex = 25
        Me.lblEndorsements.Text = "Endorsements"
        '
        'txtExp
        '
        Me.txtExp.Location = New System.Drawing.Point(224, 131)
        Me.txtExp.Name = "txtExp"
        Me.txtExp.Size = New System.Drawing.Size(100, 20)
        Me.txtExp.TabIndex = 24
        '
        'lblExp
        '
        Me.lblExp.AutoSize = True
        Me.lblExp.Location = New System.Drawing.Point(224, 115)
        Me.lblExp.Name = "lblExp"
        Me.lblExp.Size = New System.Drawing.Size(79, 13)
        Me.lblExp.TabIndex = 23
        Me.lblExp.Text = "Expiration Date"
        '
        'txtLType
        '
        Me.txtLType.Location = New System.Drawing.Point(158, 131)
        Me.txtLType.MaxLength = 2
        Me.txtLType.Name = "txtLType"
        Me.txtLType.Size = New System.Drawing.Size(40, 20)
        Me.txtLType.TabIndex = 22
        '
        'lblLicenseT
        '
        Me.lblLicenseT.AutoSize = True
        Me.lblLicenseT.Location = New System.Drawing.Point(143, 115)
        Me.lblLicenseT.Name = "lblLicenseT"
        Me.lblLicenseT.Size = New System.Drawing.Size(71, 13)
        Me.lblLicenseT.TabIndex = 21
        Me.lblLicenseT.Text = "License Type"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(37, 132)
        Me.TextBox5.MaxLength = 20
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(100, 20)
        Me.TextBox5.TabIndex = 20
        '
        'lblInsurance
        '
        Me.lblInsurance.AutoSize = True
        Me.lblInsurance.Location = New System.Drawing.Point(37, 115)
        Me.lblInsurance.Name = "lblInsurance"
        Me.lblInsurance.Size = New System.Drawing.Size(99, 13)
        Me.lblInsurance.TabIndex = 19
        Me.lblInsurance.Text = "Insurance Policy ID"
        '
        'txtZip
        '
        Me.txtZip.Location = New System.Drawing.Point(434, 87)
        Me.txtZip.MaxLength = 5
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(67, 20)
        Me.txtZip.TabIndex = 18
        '
        'lblZip
        '
        Me.lblZip.AutoSize = True
        Me.lblZip.Location = New System.Drawing.Point(431, 71)
        Me.lblZip.Name = "lblZip"
        Me.lblZip.Size = New System.Drawing.Size(46, 13)
        Me.lblZip.TabIndex = 17
        Me.lblZip.Text = "Zipcode"
        '
        'txtCounty
        '
        Me.txtCounty.Location = New System.Drawing.Point(313, 87)
        Me.txtCounty.MaxLength = 10
        Me.txtCounty.Name = "txtCounty"
        Me.txtCounty.Size = New System.Drawing.Size(115, 20)
        Me.txtCounty.TabIndex = 16
        '
        'lblCounty
        '
        Me.lblCounty.AutoSize = True
        Me.lblCounty.Location = New System.Drawing.Point(310, 71)
        Me.lblCounty.Name = "lblCounty"
        Me.lblCounty.Size = New System.Drawing.Size(40, 13)
        Me.lblCounty.TabIndex = 15
        Me.lblCounty.Text = "County"
        '
        'txtState
        '
        Me.txtState.Location = New System.Drawing.Point(265, 87)
        Me.txtState.MaxLength = 2
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(38, 20)
        Me.txtState.TabIndex = 14
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Location = New System.Drawing.Point(264, 71)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(32, 13)
        Me.lblState.TabIndex = 13
        Me.lblState.Text = "State"
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(158, 88)
        Me.txtCity.MaxLength = 15
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(100, 20)
        Me.txtCity.TabIndex = 12
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.Location = New System.Drawing.Point(155, 71)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(24, 13)
        Me.lblCity.TabIndex = 11
        Me.lblCity.Text = "City"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(37, 88)
        Me.txtAddress.MaxLength = 30
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(115, 20)
        Me.txtAddress.TabIndex = 10
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(34, 71)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(45, 13)
        Me.lblAddress.TabIndex = 9
        Me.lblAddress.Text = "Address"
        '
        'txtMiddleN
        '
        Me.txtMiddleN.Location = New System.Drawing.Point(118, 43)
        Me.txtMiddleN.MaxLength = 15
        Me.txtMiddleN.Name = "txtMiddleN"
        Me.txtMiddleN.Size = New System.Drawing.Size(100, 20)
        Me.txtMiddleN.TabIndex = 8
        '
        'lblMiddleN
        '
        Me.lblMiddleN.AutoSize = True
        Me.lblMiddleN.Location = New System.Drawing.Point(115, 28)
        Me.lblMiddleN.Name = "lblMiddleN"
        Me.lblMiddleN.Size = New System.Drawing.Size(69, 13)
        Me.lblMiddleN.TabIndex = 7
        Me.lblMiddleN.Text = "Middle Name"
        '
        'txtLastN
        '
        Me.txtLastN.Location = New System.Drawing.Point(224, 43)
        Me.txtLastN.MaxLength = 15
        Me.txtLastN.Name = "txtLastN"
        Me.txtLastN.Size = New System.Drawing.Size(100, 20)
        Me.txtLastN.TabIndex = 6
        '
        'lblLastN
        '
        Me.lblLastN.AutoSize = True
        Me.lblLastN.Location = New System.Drawing.Point(221, 27)
        Me.lblLastN.Name = "lblLastN"
        Me.lblLastN.Size = New System.Drawing.Size(58, 13)
        Me.lblLastN.TabIndex = 5
        Me.lblLastN.Text = "Last Name"
        '
        'txtFrstN
        '
        Me.txtFrstN.Location = New System.Drawing.Point(34, 44)
        Me.txtFrstN.MaxLength = 15
        Me.txtFrstN.Name = "txtFrstN"
        Me.txtFrstN.Size = New System.Drawing.Size(82, 20)
        Me.txtFrstN.TabIndex = 4
        '
        'lblFirstN
        '
        Me.lblFirstN.AutoSize = True
        Me.lblFirstN.Location = New System.Drawing.Point(31, 28)
        Me.lblFirstN.Name = "lblFirstN"
        Me.lblFirstN.Size = New System.Drawing.Size(57, 13)
        Me.lblFirstN.TabIndex = 3
        Me.lblFirstN.Text = "First Name"
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(12, 24)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(482, 76)
        Me.lblTitle.TabIndex = 6
        Me.lblTitle.Text = "Please Enter the Information Below to Add a New Driver"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(61, 230)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 37
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Add
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(598, 434)
        Me.Controls.Add(Me.grpInfo)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.msMain)
        Me.Name = "Add"
        Me.Text = "Add"
        Me.msMain.ResumeLayout(False)
        Me.msMain.PerformLayout()
        Me.grpInfo.ResumeLayout(False)
        Me.grpInfo.PerformLayout()
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
    Friend WithEvents grpInfo As GroupBox
    Friend WithEvents cmbGender As ComboBox
    Friend WithEvents lblGender As Label
    Friend WithEvents txtEyeColor As TextBox
    Friend WithEvents lblEyes As Label
    Friend WithEvents txtHaircolor As TextBox
    Friend WithEvents lblHair As Label
    Friend WithEvents txtWeight As TextBox
    Friend WithEvents lblWeight As Label
    Friend WithEvents txtHeight As TextBox
    Friend WithEvents lblHeight As Label
    Friend WithEvents txtEndorse As TextBox
    Friend WithEvents lblEndorsements As Label
    Friend WithEvents txtExp As TextBox
    Friend WithEvents lblExp As Label
    Friend WithEvents txtLType As TextBox
    Friend WithEvents lblLicenseT As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents lblInsurance As Label
    Friend WithEvents txtZip As TextBox
    Friend WithEvents lblZip As Label
    Friend WithEvents txtCounty As TextBox
    Friend WithEvents lblCounty As Label
    Friend WithEvents txtState As TextBox
    Friend WithEvents lblState As Label
    Friend WithEvents txtCity As TextBox
    Friend WithEvents lblCity As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents lblAddress As Label
    Friend WithEvents txtMiddleN As TextBox
    Friend WithEvents lblMiddleN As Label
    Friend WithEvents txtLastN As TextBox
    Friend WithEvents lblLastN As Label
    Friend WithEvents txtFrstN As TextBox
    Friend WithEvents lblFirstN As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents Button1 As Button
End Class
