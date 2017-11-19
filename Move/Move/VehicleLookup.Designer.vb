<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VehicleLookup
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
        Me.lblLookupCar = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddVehicleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PairVehicleToDriverToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtLicensePlate = New System.Windows.Forms.TextBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.dgvCars = New System.Windows.Forms.DataGridView()
        Me.ShowVehicleAssociationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dgvCars, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblLookupCar
        '
        Me.lblLookupCar.AutoSize = True
        Me.lblLookupCar.Location = New System.Drawing.Point(12, 24)
        Me.lblLookupCar.Name = "lblLookupCar"
        Me.lblLookupCar.Size = New System.Drawing.Size(99, 13)
        Me.lblLookupCar.TabIndex = 0
        Me.lblLookupCar.Text = "Enter License Plate"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.AddVehicleToolStripMenuItem, Me.PairVehicleToDriverToolStripMenuItem, Me.ShowVehicleAssociationsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(639, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
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
        Me.MainMenuToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.MainMenuToolStripMenuItem.Text = "Main Menu"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'AddVehicleToolStripMenuItem
        '
        Me.AddVehicleToolStripMenuItem.Name = "AddVehicleToolStripMenuItem"
        Me.AddVehicleToolStripMenuItem.Size = New System.Drawing.Size(81, 20)
        Me.AddVehicleToolStripMenuItem.Text = "Add Vehicle"
        '
        'PairVehicleToDriverToolStripMenuItem
        '
        Me.PairVehicleToDriverToolStripMenuItem.Name = "PairVehicleToDriverToolStripMenuItem"
        Me.PairVehicleToDriverToolStripMenuItem.Size = New System.Drawing.Size(127, 20)
        Me.PairVehicleToDriverToolStripMenuItem.Text = "Pair Vehicle to Driver"
        '
        'txtLicensePlate
        '
        Me.txtLicensePlate.Location = New System.Drawing.Point(15, 41)
        Me.txtLicensePlate.MaxLength = 7
        Me.txtLicensePlate.Name = "txtLicensePlate"
        Me.txtLicensePlate.Size = New System.Drawing.Size(100, 20)
        Me.txtLicensePlate.TabIndex = 2
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(134, 37)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnSubmit.TabIndex = 3
        Me.btnSubmit.Text = "GO"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'dgvCars
        '
        Me.dgvCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCars.Location = New System.Drawing.Point(0, 85)
        Me.dgvCars.Name = "dgvCars"
        Me.dgvCars.Size = New System.Drawing.Size(627, 335)
        Me.dgvCars.TabIndex = 4
        '
        'ShowVehicleAssociationsToolStripMenuItem
        '
        Me.ShowVehicleAssociationsToolStripMenuItem.Name = "ShowVehicleAssociationsToolStripMenuItem"
        Me.ShowVehicleAssociationsToolStripMenuItem.Size = New System.Drawing.Size(157, 20)
        Me.ShowVehicleAssociationsToolStripMenuItem.Text = "Show Vehicle Associations"
        '
        'VehicleLookup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(639, 432)
        Me.Controls.Add(Me.dgvCars)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.txtLicensePlate)
        Me.Controls.Add(Me.lblLookupCar)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "VehicleLookup"
        Me.Text = "VehicleLookup"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dgvCars, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblLookupCar As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MainMenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents txtLicensePlate As TextBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents dgvCars As DataGridView
    Friend WithEvents AddVehicleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PairVehicleToDriverToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ShowVehicleAssociationsToolStripMenuItem As ToolStripMenuItem
End Class
