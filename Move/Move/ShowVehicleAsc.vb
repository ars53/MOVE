Public Class ShowVehicleAsc
    Protected db As db = New db

    Private Sub ShowVehicleAsc_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        db.sql = "SELECT CONCAT(d.FrsName, ' ', d.LstName) AS DriverName, v.VIN FROM Driver_Vehicle_Asc v JOIN Driver d on v.LicenseNumber = d.LicenseNumber WHERE VIN = @Vin"
        db.bind("@vin", TextBox1.Text)
        db.fill(DataGridView1)

    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Me.Dispose()

    End Sub
End Class