<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ShowDriverInfo_Officer
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
        Me.dgvPersonLookup = New System.Windows.Forms.DataGridView()
        Me.lblPrompt = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnViewInfractions = New System.Windows.Forms.Button()
        CType(Me.dgvPersonLookup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvPersonLookup
        '
        Me.dgvPersonLookup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPersonLookup.Location = New System.Drawing.Point(13, 36)
        Me.dgvPersonLookup.Name = "dgvPersonLookup"
        Me.dgvPersonLookup.Size = New System.Drawing.Size(946, 361)
        Me.dgvPersonLookup.TabIndex = 0
        '
        'lblPrompt
        '
        Me.lblPrompt.AutoSize = True
        Me.lblPrompt.Location = New System.Drawing.Point(13, 13)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.Size = New System.Drawing.Size(77, 13)
        Me.lblPrompt.TabIndex = 1
        Me.lblPrompt.Text = "Enter Driver ID"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(97, 10)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(100, 20)
        Me.txtID.TabIndex = 2
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(204, 10)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 3
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnViewInfractions
        '
        Me.btnViewInfractions.Location = New System.Drawing.Point(296, 10)
        Me.btnViewInfractions.Name = "btnViewInfractions"
        Me.btnViewInfractions.Size = New System.Drawing.Size(109, 23)
        Me.btnViewInfractions.TabIndex = 4
        Me.btnViewInfractions.Text = "See Infractions"
        Me.btnViewInfractions.UseVisualStyleBackColor = True
        '
        'ShowDriverInfo_Officer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(971, 409)
        Me.Controls.Add(Me.btnViewInfractions)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.lblPrompt)
        Me.Controls.Add(Me.dgvPersonLookup)
        Me.Name = "ShowDriverInfo_Officer"
        Me.Text = "ShowDriverInfo_Officer"
        CType(Me.dgvPersonLookup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvPersonLookup As DataGridView
    Friend WithEvents lblPrompt As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnViewInfractions As Button
End Class
