Public Class WriteInfraction
    Protected db As db = New db
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        db.sql = "INSERT INTO Infractions (Description, Date_of_Issue, Officer_ID, Address, City, State, County, Zipcode, Driver_ID, VIN) VALUES (@describe1, @date, @offID, @address, @city, @state, @county, @zip, @driver_id, @vin)"
        db.bind("@describe1", txtDescription.Text)
        db.bind("@date", txtDate.Text)
        db.bind("@offID", txtOfficerId.Text)
        db.bind("@address", txtAddress.Text)
        db.bind("@city", txtCity.Text)
        db.bind("@state", txtState.Text)
        db.bind("@county", txtCounty.Text)
        db.bind("@zip", txtZip.Text)
        db.bind("@driver_id", txtDriverID.Text)
        db.bind("@vin", txtVin.Text)
        db.execute()
        Me.Dispose()
    End Sub
End Class