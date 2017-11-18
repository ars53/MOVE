Public Class InsuranceAdd
    Protected db As db = New db

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        db.sql = "INSERT INTO Insurance (PolicyNumber, Provider, Status, EffectiveDate, ExpirationDate) Values (@policy,@provider,@status,@Effective,@exp)"
        db.bind("@policy", txtPolicyNum.Text)
        db.bind("@Provider", txtProvider.Text)
        db.bind("@status", txtStatus.Text)
        db.bind("@effective", txtEffDate.Text)
        db.bind("@exp", txtEnd.Text)
        db.execute()
        Me.Dispose()
    End Sub
End Class