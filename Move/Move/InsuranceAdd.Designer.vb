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
        Me.lblPolicyNum = New System.Windows.Forms.Label()
        Me.txtPolicyNum = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lblProvider = New System.Windows.Forms.Label()
        Me.txtProvider = New System.Windows.Forms.TextBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.txtStatus = New System.Windows.Forms.TextBox()
        Me.lblEffDate = New System.Windows.Forms.Label()
        Me.txtEffDate = New System.Windows.Forms.TextBox()
        Me.txtEnd = New System.Windows.Forms.TextBox()
        Me.lblEndDate = New System.Windows.Forms.Label()
        Me.SuspendLayout()
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
        'txtEnd
        '
        Me.txtEnd.Location = New System.Drawing.Point(193, 114)
        Me.txtEnd.MaxLength = 10
        Me.txtEnd.Name = "txtEnd"
        Me.txtEnd.Size = New System.Drawing.Size(100, 20)
        Me.txtEnd.TabIndex = 12
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
        Me.Controls.Add(Me.txtEnd)
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
        Me.Name = "InsuranceAdd"
        Me.Text = "InsuranceAdd"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPolicyNum As Label
    Friend WithEvents txtPolicyNum As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents lblProvider As Label
    Friend WithEvents txtProvider As TextBox
    Friend WithEvents lblStatus As Label
    Friend WithEvents txtStatus As TextBox
    Friend WithEvents lblEffDate As Label
    Friend WithEvents txtEffDate As TextBox
    Friend WithEvents txtEnd As TextBox
    Friend WithEvents lblEndDate As Label
End Class
