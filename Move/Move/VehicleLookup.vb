Public Class VehicleLookup
    Protected db As New db
    Private Sub MainMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MainMenuToolStripMenuItem.Click
        Main.Show()
        Me.Close()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()

    End Sub
    Protected Sub loadVehicles()
        db.sql = "SELECT * FROM Vehicle"
        db.fill(dgvCars)
    End Sub

    Private Sub VehicleLookup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadVehicles()

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        db.sql = "Select * FROM Vehicle Where PlateNumber = @plate"
        db.bind("@plate", txtLicensePlate.Text)

        db.fill(dgvCars)
    End Sub

    Private Sub AddVehicleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddVehicleToolStripMenuItem.Click
        VehicleAdd.ShowDialog()
        loadVehicles()

    End Sub

    Private Sub PairVehicleToDriverToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PairVehicleToDriverToolStripMenuItem.Click
        DriverVehicleAsc.ShowDialog()
        loadVehicles()
    End Sub

    Private Sub ShowVehicleAssociationsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowVehicleAssociationsToolStripMenuItem.Click
        ShowVehicleAsc.ShowDialog()

    End Sub
End Class