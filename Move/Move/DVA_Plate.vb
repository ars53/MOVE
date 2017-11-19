Public Class DVA_Plate
    Protected db As New db
    Protected LPlate As String
    Public Function DVAgetPersonID() As Integer
        Return DVAgetPersonvalue("licenseNumber")
    End Function
    Public Function DVAgetPersonvalue(ByVal column As String)
        Return dgvPlateLookup.Item(column, dgvPlateLookup.CurrentRow.Index).Value
    End Function
    Private Sub DVA_Plate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        db.sql = "SELECT dva.licenseNumber, CONCAT(D.FrsName,' ', d.LstName) AS Driver_Name, v.PlateNumber FROM Driver_Vehicle_Asc dva JOIN Vehicle v on dva.VIN = v.VIN JOIN Driver d on Dva.LicenseNumber = d.licenseNumber WHERE v.plateNumber = @Plate"
        db.bind("@Plate", LPlate)
        db.fill(dgvPlateLookup)
    End Sub
    Public Sub New(ByVal plate As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LPlate = plate
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Dispose()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        ShowDriverInfo_Officer.ShowDialog()

    End Sub
End Class