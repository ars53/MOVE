Public Class ShowDriverInfo_Officer

    Protected db As New db
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        db.sql = "SELECT Driver_name, Number_of_Infractions FROM Infractions_Count WHERE LicenseNumber = @driver_ID"
        db.bind("@driver_ID", txtID.Text)
        db.fill(dgvPersonLookup)
    End Sub

    Private Sub btnViewInfractions_Click(sender As Object, e As EventArgs) Handles btnViewInfractions.Click
        ViewInfractions.ShowDialog()

    End Sub
End Class