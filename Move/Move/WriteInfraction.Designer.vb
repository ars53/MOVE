<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WriteInfraction
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
        Me.lblDriverID = New System.Windows.Forms.Label()
        Me.txtDriverID = New System.Windows.Forms.TextBox()
        Me.lblDescribe = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.lblOffId = New System.Windows.Forms.Label()
        Me.txtOfficerId = New System.Windows.Forms.TextBox()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.lblState = New System.Windows.Forms.Label()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.lblCounty = New System.Windows.Forms.Label()
        Me.txtCounty = New System.Windows.Forms.TextBox()
        Me.lblZip = New System.Windows.Forms.Label()
        Me.txtZip = New System.Windows.Forms.TextBox()
        Me.lblVin = New System.Windows.Forms.Label()
        Me.txtVin = New System.Windows.Forms.TextBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblDriverID
        '
        Me.lblDriverID.AutoSize = True
        Me.lblDriverID.Location = New System.Drawing.Point(3, 12)
        Me.lblDriverID.Name = "lblDriverID"
        Me.lblDriverID.Size = New System.Drawing.Size(84, 13)
        Me.lblDriverID.TabIndex = 0
        Me.lblDriverID.Text = "License Number"
        '
        'txtDriverID
        '
        Me.txtDriverID.Location = New System.Drawing.Point(94, 12)
        Me.txtDriverID.Name = "txtDriverID"
        Me.txtDriverID.Size = New System.Drawing.Size(100, 20)
        Me.txtDriverID.TabIndex = 1
        '
        'lblDescribe
        '
        Me.lblDescribe.AutoSize = True
        Me.lblDescribe.Location = New System.Drawing.Point(12, 184)
        Me.lblDescribe.Name = "lblDescribe"
        Me.lblDescribe.Size = New System.Drawing.Size(103, 13)
        Me.lblDescribe.TabIndex = 2
        Me.lblDescribe.Text = "Description of Event"
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(16, 200)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(412, 74)
        Me.txtDescription.TabIndex = 3
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(222, 18)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(87, 13)
        Me.lblDate.TabIndex = 4
        Me.lblDate.Text = "Date yyyy-mm-dd"
        '
        'txtDate
        '
        Me.txtDate.Location = New System.Drawing.Point(316, 18)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(100, 20)
        Me.txtDate.TabIndex = 5
        '
        'lblOffId
        '
        Me.lblOffId.AutoSize = True
        Me.lblOffId.Location = New System.Drawing.Point(12, 52)
        Me.lblOffId.Name = "lblOffId"
        Me.lblOffId.Size = New System.Drawing.Size(47, 13)
        Me.lblOffId.TabIndex = 6
        Me.lblOffId.Text = "OfficerId"
        '
        'txtOfficerId
        '
        Me.txtOfficerId.Location = New System.Drawing.Point(94, 52)
        Me.txtOfficerId.Name = "txtOfficerId"
        Me.txtOfficerId.Size = New System.Drawing.Size(100, 20)
        Me.txtOfficerId.TabIndex = 7
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(15, 85)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(45, 13)
        Me.lblAddress.TabIndex = 8
        Me.lblAddress.Text = "Address"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(94, 85)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(322, 20)
        Me.txtAddress.TabIndex = 9
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.Location = New System.Drawing.Point(225, 58)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(24, 13)
        Me.lblCity.TabIndex = 10
        Me.lblCity.Text = "City"
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(270, 51)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(100, 20)
        Me.txtCity.TabIndex = 11
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Location = New System.Drawing.Point(13, 116)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(32, 13)
        Me.lblState.TabIndex = 12
        Me.lblState.Text = "State"
        '
        'txtState
        '
        Me.txtState.Location = New System.Drawing.Point(94, 113)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(100, 20)
        Me.txtState.TabIndex = 13
        '
        'lblCounty
        '
        Me.lblCounty.AutoSize = True
        Me.lblCounty.Location = New System.Drawing.Point(246, 116)
        Me.lblCounty.Name = "lblCounty"
        Me.lblCounty.Size = New System.Drawing.Size(40, 13)
        Me.lblCounty.TabIndex = 14
        Me.lblCounty.Text = "County"
        '
        'txtCounty
        '
        Me.txtCounty.Location = New System.Drawing.Point(292, 113)
        Me.txtCounty.Name = "txtCounty"
        Me.txtCounty.Size = New System.Drawing.Size(100, 20)
        Me.txtCounty.TabIndex = 15
        '
        'lblZip
        '
        Me.lblZip.AutoSize = True
        Me.lblZip.Location = New System.Drawing.Point(15, 146)
        Me.lblZip.Name = "lblZip"
        Me.lblZip.Size = New System.Drawing.Size(46, 13)
        Me.lblZip.TabIndex = 16
        Me.lblZip.Text = "Zipcode"
        '
        'txtZip
        '
        Me.txtZip.Location = New System.Drawing.Point(94, 146)
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(100, 20)
        Me.txtZip.TabIndex = 17
        '
        'lblVin
        '
        Me.lblVin.AutoSize = True
        Me.lblVin.Location = New System.Drawing.Point(249, 152)
        Me.lblVin.Name = "lblVin"
        Me.lblVin.Size = New System.Drawing.Size(25, 13)
        Me.lblVin.TabIndex = 18
        Me.lblVin.Text = "VIN"
        '
        'txtVin
        '
        Me.txtVin.Location = New System.Drawing.Point(292, 149)
        Me.txtVin.Name = "txtVin"
        Me.txtVin.Size = New System.Drawing.Size(100, 20)
        Me.txtVin.TabIndex = 19
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(18, 280)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(410, 40)
        Me.btnSubmit.TabIndex = 20
        Me.btnSubmit.Text = "Submit and Print Ticket"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'WriteInfraction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(440, 337)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.txtVin)
        Me.Controls.Add(Me.lblVin)
        Me.Controls.Add(Me.txtZip)
        Me.Controls.Add(Me.lblZip)
        Me.Controls.Add(Me.txtCounty)
        Me.Controls.Add(Me.lblCounty)
        Me.Controls.Add(Me.txtState)
        Me.Controls.Add(Me.lblState)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.lblCity)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.txtOfficerId)
        Me.Controls.Add(Me.lblOffId)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.lblDescribe)
        Me.Controls.Add(Me.txtDriverID)
        Me.Controls.Add(Me.lblDriverID)
        Me.Name = "WriteInfraction"
        Me.Text = "WriteInfraction"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblDriverID As Label
    Friend WithEvents txtDriverID As TextBox
    Friend WithEvents lblDescribe As Label
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents lblDate As Label
    Friend WithEvents txtDate As TextBox
    Friend WithEvents lblOffId As Label
    Friend WithEvents txtOfficerId As TextBox
    Friend WithEvents lblAddress As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents lblCity As Label
    Friend WithEvents txtCity As TextBox
    Friend WithEvents lblState As Label
    Friend WithEvents txtState As TextBox
    Friend WithEvents lblCounty As Label
    Friend WithEvents txtCounty As TextBox
    Friend WithEvents lblZip As Label
    Friend WithEvents txtZip As TextBox
    Friend WithEvents lblVin As Label
    Friend WithEvents txtVin As TextBox
    Friend WithEvents btnSubmit As Button
End Class
