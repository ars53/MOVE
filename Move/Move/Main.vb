Public Class Main
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub LookupToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Lookup.Show()
        Me.Close()

    End Sub

    Private Sub btnLookup_Click(sender As Object, e As EventArgs) Handles btnLookup.Click
        Lookup.Show()
        Me.Close()
    End Sub

    Private Sub AddToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Add.Show()
        Me.Close()

    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Delete.Show()
        Me.Close()

    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTitle.Focus()

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs)
        Add.ShowDialog()

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs)
        Delete.Show()
        Me.Close()

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs)
        UpdateInfo.Show()
        Me.Close()
    End Sub

    Private Sub UpdateUserInfoToolStripMenuItem_Click(sender As Object, e As EventArgs)
        UpdateInfo.Show()
        Me.Close()

    End Sub

    Private Sub AddInsuranceInfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddInsuranceInfoToolStripMenuItem.Click
        InsuranceAdd.ShowDialog()
    End Sub

    Private Sub AddDeleteUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddDeleteUserToolStripMenuItem.Click
        Lookup.Show()
        Me.Close()

    End Sub

    Private Sub AddUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddUserToolStripMenuItem.Click
        Add.ShowDialog()

    End Sub

    Private Sub btnLookupCars_Click(sender As Object, e As EventArgs) Handles btnLookupCars.Click
        VehicleLookup.Show()
        Me.Close()
    End Sub

    Private Sub btnOfficer_Click(sender As Object, e As EventArgs) Handles btnOfficer.Click
        LookupbyLicensePlate.Show()
        Me.Close()

    End Sub
End Class
