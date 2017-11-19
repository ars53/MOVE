<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DVA_Plate
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
        Me.dgvPlateLookup = New System.Windows.Forms.DataGridView()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        CType(Me.dgvPlateLookup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvPlateLookup
        '
        Me.dgvPlateLookup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPlateLookup.Location = New System.Drawing.Point(13, 31)
        Me.dgvPlateLookup.Name = "dgvPlateLookup"
        Me.dgvPlateLookup.Size = New System.Drawing.Size(418, 218)
        Me.dgvPlateLookup.TabIndex = 0
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(153, 2)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(134, 23)
        Me.btnSearch.TabIndex = 1
        Me.btnSearch.Text = "Search Selected Driver"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(13, 2)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(96, 23)
        Me.btnBack.TabIndex = 2
        Me.btnBack.Text = "Back to Search"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'DVA_Plate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(443, 261)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.dgvPlateLookup)
        Me.Name = "DVA_Plate"
        Me.Text = "DVA_Plate"
        CType(Me.dgvPlateLookup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvPlateLookup As DataGridView
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnBack As Button
End Class
