Public Class ShowDriverInfo_Officer

    Protected db As New db
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        db.sql = "SELECT d.LicenseNumber, concat(d.frsName, ' ', d.MiddleNme, ' ', d.lstName) AS Full_Name, concat(d.address, ' ', d.City, ', ', d.State, ' ', d.Zipcode) AS Address, d.County, d.InsurancePolicyID, d.LicenseType, d.ExpirationDate, d.Endorsements, d.Height, d.Weight, d.HairClr, d.EyeClr, d.Gender, count(i.driver_id) AS NUmber_of_Infractions From Driver d JOIN Infractions i on d.LicenseNumber = i.Driver_ID  WHERE driver_id = @driver_id Group by d.LicenseNumber, concat(d.frsName, ' ', d.MiddleNme, ' ', d.lstName), concat(d.address, ' ', d.City, ', ', d.State, ' ', d.Zipcode),d.County, d.InsurancePolicyID, d.LicenseType, d.ExpirationDate, d.Endorsements, d.Height, d.Weight, d.HairClr, d.EyeClr, d.Gender"
        db.bind("@driver_ID", txtID.Text)
        db.fill(dgvPersonLookup)
    End Sub
End Class