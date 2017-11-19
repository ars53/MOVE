Public Class VehicleAdd
    Protected db As db = New db
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        db.sql = "INSERT INTO Vehicle (VIN, Year, Make, Model, Color, RegisNumber, ExpirDate, InsurancePolicyID, PlateNumber) VALUES (@Vin, @Year, @Make, @Model, @Color, @Reg, @Exp, @Ins, @Plate)"
        db.bind("@Vin", txtVin.Text)
        db.bind("@Year", txtYear.Text)
        db.bind("@Make", txtMake.Text)
        db.bind("@Model", txtModel.Text)
        db.bind("@Color", txtColor.Text)
        db.bind("@Reg", txtRegis.Text)
        db.bind("@Exp", txtExpir.Text)
        db.bind("@Ins", txtIns.Text)
        db.bind("@Plate", txtPlate.Text)
        db.execute()
        Me.Dispose()
    End Sub
End Class