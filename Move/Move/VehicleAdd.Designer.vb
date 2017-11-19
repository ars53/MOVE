<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VehicleAdd
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblVin = New System.Windows.Forms.Label()
        Me.txtVin = New System.Windows.Forms.TextBox()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.txtYear = New System.Windows.Forms.TextBox()
        Me.lblMake = New System.Windows.Forms.Label()
        Me.txtMake = New System.Windows.Forms.TextBox()
        Me.lblModel = New System.Windows.Forms.Label()
        Me.txtModel = New System.Windows.Forms.TextBox()
        Me.lblClr = New System.Windows.Forms.Label()
        Me.txtColor = New System.Windows.Forms.TextBox()
        Me.lblRegisNumber = New System.Windows.Forms.Label()
        Me.txtRegis = New System.Windows.Forms.TextBox()
        Me.lblExpir = New System.Windows.Forms.Label()
        Me.txtExpir = New System.Windows.Forms.TextBox()
        Me.lblIns = New System.Windows.Forms.Label()
        Me.txtIns = New System.Windows.Forms.TextBox()
        Me.lblPlate = New System.Windows.Forms.Label()
        Me.txtPlate = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(41, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(203, 68)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Please Enter New Vehicle Information"
        '
        'lblVin
        '
        Me.lblVin.AutoSize = True
        Me.lblVin.Location = New System.Drawing.Point(13, 76)
        Me.lblVin.Name = "lblVin"
        Me.lblVin.Size = New System.Drawing.Size(25, 13)
        Me.lblVin.TabIndex = 1
        Me.lblVin.Text = "VIN"
        '
        'txtVin
        '
        Me.txtVin.Location = New System.Drawing.Point(13, 93)
        Me.txtVin.MaxLength = 18
        Me.txtVin.Name = "txtVin"
        Me.txtVin.Size = New System.Drawing.Size(100, 20)
        Me.txtVin.TabIndex = 2
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Location = New System.Drawing.Point(129, 76)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(29, 13)
        Me.lblYear.TabIndex = 3
        Me.lblYear.Text = "Year"
        '
        'txtYear
        '
        Me.txtYear.Location = New System.Drawing.Point(132, 92)
        Me.txtYear.MaxLength = 4
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(50, 20)
        Me.txtYear.TabIndex = 4
        '
        'lblMake
        '
        Me.lblMake.AutoSize = True
        Me.lblMake.Location = New System.Drawing.Point(201, 76)
        Me.lblMake.Name = "lblMake"
        Me.lblMake.Size = New System.Drawing.Size(34, 13)
        Me.lblMake.TabIndex = 5
        Me.lblMake.Text = "Make"
        '
        'txtMake
        '
        Me.txtMake.Location = New System.Drawing.Point(189, 92)
        Me.txtMake.MaxLength = 20
        Me.txtMake.Name = "txtMake"
        Me.txtMake.Size = New System.Drawing.Size(73, 20)
        Me.txtMake.TabIndex = 6
        '
        'lblModel
        '
        Me.lblModel.AutoSize = True
        Me.lblModel.Location = New System.Drawing.Point(13, 120)
        Me.lblModel.Name = "lblModel"
        Me.lblModel.Size = New System.Drawing.Size(36, 13)
        Me.lblModel.TabIndex = 7
        Me.lblModel.Text = "Model"
        '
        'txtModel
        '
        Me.txtModel.Location = New System.Drawing.Point(13, 137)
        Me.txtModel.MaxLength = 10
        Me.txtModel.Name = "txtModel"
        Me.txtModel.Size = New System.Drawing.Size(100, 20)
        Me.txtModel.TabIndex = 8
        '
        'lblClr
        '
        Me.lblClr.AutoSize = True
        Me.lblClr.Location = New System.Drawing.Point(132, 120)
        Me.lblClr.Name = "lblClr"
        Me.lblClr.Size = New System.Drawing.Size(31, 13)
        Me.lblClr.TabIndex = 9
        Me.lblClr.Text = "Color"
        '
        'txtColor
        '
        Me.txtColor.Location = New System.Drawing.Point(132, 136)
        Me.txtColor.MaxLength = 10
        Me.txtColor.Name = "txtColor"
        Me.txtColor.Size = New System.Drawing.Size(72, 20)
        Me.txtColor.TabIndex = 10
        '
        'lblRegisNumber
        '
        Me.lblRegisNumber.AutoSize = True
        Me.lblRegisNumber.Location = New System.Drawing.Point(223, 120)
        Me.lblRegisNumber.Name = "lblRegisNumber"
        Me.lblRegisNumber.Size = New System.Drawing.Size(103, 13)
        Me.lblRegisNumber.TabIndex = 11
        Me.lblRegisNumber.Text = "Registration Number"
        '
        'txtRegis
        '
        Me.txtRegis.Location = New System.Drawing.Point(226, 136)
        Me.txtRegis.MaxLength = 15
        Me.txtRegis.Name = "txtRegis"
        Me.txtRegis.Size = New System.Drawing.Size(100, 20)
        Me.txtRegis.TabIndex = 12
        '
        'lblExpir
        '
        Me.lblExpir.AutoSize = True
        Me.lblExpir.Location = New System.Drawing.Point(16, 164)
        Me.lblExpir.Name = "lblExpir"
        Me.lblExpir.Size = New System.Drawing.Size(79, 13)
        Me.lblExpir.TabIndex = 13
        Me.lblExpir.Text = "Expiration Date"
        '
        'txtExpir
        '
        Me.txtExpir.Location = New System.Drawing.Point(12, 180)
        Me.txtExpir.MaxLength = 10
        Me.txtExpir.Name = "txtExpir"
        Me.txtExpir.Size = New System.Drawing.Size(100, 20)
        Me.txtExpir.TabIndex = 14
        '
        'lblIns
        '
        Me.lblIns.AutoSize = True
        Me.lblIns.Location = New System.Drawing.Point(132, 164)
        Me.lblIns.Name = "lblIns"
        Me.lblIns.Size = New System.Drawing.Size(99, 13)
        Me.lblIns.TabIndex = 15
        Me.lblIns.Text = "Insurance Policy ID"
        '
        'txtIns
        '
        Me.txtIns.Location = New System.Drawing.Point(135, 180)
        Me.txtIns.MaxLength = 20
        Me.txtIns.Name = "txtIns"
        Me.txtIns.Size = New System.Drawing.Size(100, 20)
        Me.txtIns.TabIndex = 16
        '
        'lblPlate
        '
        Me.lblPlate.AutoSize = True
        Me.lblPlate.Location = New System.Drawing.Point(237, 164)
        Me.lblPlate.Name = "lblPlate"
        Me.lblPlate.Size = New System.Drawing.Size(71, 13)
        Me.lblPlate.TabIndex = 17
        Me.lblPlate.Text = "Plate Number"
        '
        'txtPlate
        '
        Me.txtPlate.Location = New System.Drawing.Point(241, 180)
        Me.txtPlate.MaxLength = 7
        Me.txtPlate.Name = "txtPlate"
        Me.txtPlate.Size = New System.Drawing.Size(88, 20)
        Me.txtPlate.TabIndex = 18
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(71, 206)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(207, 43)
        Me.btnAdd.TabIndex = 19
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'VehicleAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(341, 261)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtPlate)
        Me.Controls.Add(Me.lblPlate)
        Me.Controls.Add(Me.txtIns)
        Me.Controls.Add(Me.lblIns)
        Me.Controls.Add(Me.txtExpir)
        Me.Controls.Add(Me.lblExpir)
        Me.Controls.Add(Me.txtRegis)
        Me.Controls.Add(Me.lblRegisNumber)
        Me.Controls.Add(Me.txtColor)
        Me.Controls.Add(Me.lblClr)
        Me.Controls.Add(Me.txtModel)
        Me.Controls.Add(Me.lblModel)
        Me.Controls.Add(Me.txtMake)
        Me.Controls.Add(Me.lblMake)
        Me.Controls.Add(Me.txtYear)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.txtVin)
        Me.Controls.Add(Me.lblVin)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "VehicleAdd"
        Me.Text = "VehicleAdd"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblVin As Label
    Friend WithEvents txtVin As TextBox
    Friend WithEvents lblYear As Label
    Friend WithEvents txtYear As TextBox
    Friend WithEvents lblMake As Label
    Friend WithEvents txtMake As TextBox
    Friend WithEvents lblModel As Label
    Friend WithEvents txtModel As TextBox
    Friend WithEvents lblClr As Label
    Friend WithEvents txtColor As TextBox
    Friend WithEvents lblRegisNumber As Label
    Friend WithEvents txtRegis As TextBox
    Friend WithEvents lblExpir As Label
    Friend WithEvents txtExpir As TextBox
    Friend WithEvents lblIns As Label
    Friend WithEvents txtIns As TextBox
    Friend WithEvents lblPlate As Label
    Friend WithEvents txtPlate As TextBox
    Friend WithEvents btnAdd As Button
End Class
