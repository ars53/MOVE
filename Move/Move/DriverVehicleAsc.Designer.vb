<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DriverVehicleAsc
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
        Me.lblVin = New System.Windows.Forms.Label()
        Me.txtVin = New System.Windows.Forms.TextBox()
        Me.lblDriverID = New System.Windows.Forms.Label()
        Me.txtDriver = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblVin
        '
        Me.lblVin.AutoSize = True
        Me.lblVin.Location = New System.Drawing.Point(13, 22)
        Me.lblVin.Name = "lblVin"
        Me.lblVin.Size = New System.Drawing.Size(114, 13)
        Me.lblVin.TabIndex = 0
        Me.lblVin.Text = "Currently Selected VIN"
        '
        'txtVin
        '
        Me.txtVin.Location = New System.Drawing.Point(13, 39)
        Me.txtVin.Name = "txtVin"
        Me.txtVin.Size = New System.Drawing.Size(114, 20)
        Me.txtVin.TabIndex = 1
        '
        'lblDriverID
        '
        Me.lblDriverID.AutoSize = True
        Me.lblDriverID.Location = New System.Drawing.Point(168, 22)
        Me.lblDriverID.Name = "lblDriverID"
        Me.lblDriverID.Size = New System.Drawing.Size(49, 13)
        Me.lblDriverID.TabIndex = 2
        Me.lblDriverID.Text = "Driver ID"
        '
        'txtDriver
        '
        Me.txtDriver.Location = New System.Drawing.Point(171, 38)
        Me.txtDriver.Name = "txtDriver"
        Me.txtDriver.Size = New System.Drawing.Size(93, 20)
        Me.txtDriver.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(16, 83)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(248, 69)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DriverVehicleAsc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 164)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtDriver)
        Me.Controls.Add(Me.lblDriverID)
        Me.Controls.Add(Me.txtVin)
        Me.Controls.Add(Me.lblVin)
        Me.Name = "DriverVehicleAsc"
        Me.Text = "DriverVehicleAsc"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblVin As Label
    Friend WithEvents txtVin As TextBox
    Friend WithEvents lblDriverID As Label
    Friend WithEvents txtDriver As TextBox
    Friend WithEvents Button1 As Button
End Class
