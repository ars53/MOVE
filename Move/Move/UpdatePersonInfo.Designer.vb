<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdatePersonInfo
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
        Me.lblFrst = New System.Windows.Forms.Label()
        Me.txtFrstName = New System.Windows.Forms.TextBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblFrst
        '
        Me.lblFrst.AutoSize = True
        Me.lblFrst.Location = New System.Drawing.Point(12, 29)
        Me.lblFrst.Name = "lblFrst"
        Me.lblFrst.Size = New System.Drawing.Size(57, 13)
        Me.lblFrst.TabIndex = 0
        Me.lblFrst.Text = "First Name"
        '
        'txtFrstName
        '
        Me.txtFrstName.Location = New System.Drawing.Point(15, 46)
        Me.txtFrstName.Name = "txtFrstName"
        Me.txtFrstName.Size = New System.Drawing.Size(100, 20)
        Me.txtFrstName.TabIndex = 1
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(42, 280)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(310, 60)
        Me.btnSubmit.TabIndex = 2
        Me.btnSubmit.Text = "Submit Changes"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'UpdatePersonInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(398, 352)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.txtFrstName)
        Me.Controls.Add(Me.lblFrst)
        Me.Name = "UpdatePersonInfo"
        Me.Text = "UpdatePersonInfo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFrst As Label
    Friend WithEvents txtFrstName As TextBox
    Friend WithEvents btnSubmit As Button
End Class
