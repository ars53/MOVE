Public Class UpdatePersonInfo
    Protected personID As Integer
    Protected db As New db

    Public Sub New(ByVal qid As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        personID = qid

        txtFrstName.Text = Lookup.getQuestionvalue("FrsName").ToString

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        db.sql = "UPDATE Driver SET FrsName = @frs WHERE LicenseNumber = @driver_ID"
        db.bind("@frs", txtFrstName.Text)
        db.bind("@driver_ID", personID)
        db.execute()
        Me.Dispose()

    End Sub
End Class