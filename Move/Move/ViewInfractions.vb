Public Class ViewInfractions
    Protected db As db = New db
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        db.sql = "SELECT * FROM Infractions WHERE Driver_ID = @driver_id"
        db.bind("@driver_id", txtDriverID.Text)
        db.fill(dgvInfractios)

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub
End Class