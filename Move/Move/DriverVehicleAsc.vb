Public Class DriverVehicleAsc
    Protected db As db = New db

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        db.sql = "INSERT INTO Driver_Vehicle_Asc (LicenseNumber, VIN) VALUES (@Driver, @VIN)"
        db.bind("@driver", txtDriver.Text)
        db.bind("@VIN", txtVin.Text)
        db.execute()
        Me.Dispose()
    End Sub
End Class