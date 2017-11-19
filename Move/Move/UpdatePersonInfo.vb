Public Class UpdatePersonInfo
    Protected personID As Integer
    Protected db As New db

    Public Sub New(ByVal qid As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        personID = qid


        txtFrstName.Text = Lookup.getPersonvalue("FrsName").ToString
        txtMiddle.Text = Lookup.getPersonvalue("MiddleNme").ToString
        txtLast.Text = Lookup.getPersonvalue("LstName").ToString
        txtAddress.Text = Lookup.getPersonvalue("Address").ToString
        txtCity.Text = Lookup.getPersonvalue("City").ToString
        txtState.Text = Lookup.getPersonvalue("State").ToString
        txtCounty.Text = Lookup.getPersonvalue("County").ToString
        txtZip.Text = Lookup.getPersonvalue("Zipcode").ToString
        txtIns.Text = Lookup.getPersonvalue("InsurancePolicyID").ToString
        txtType.Text = Lookup.getPersonvalue("LicenseType").ToString
        txtExpir.Text = Lookup.getPersonvalue("ExpirationDate").ToString
        txtEndorse.Text = Lookup.getPersonvalue("Endorsements").ToString
        txtHeight.Text = Lookup.getPersonvalue("Height").ToString
        txtHair.Text = Lookup.getPersonvalue("HairClr").ToString
        txtWeight.Text = Lookup.getPersonvalue("Weight").ToString
        txtEyes.Text = Lookup.getPersonvalue("EyeClr").ToString
        cmbGender.Text = Lookup.getPersonvalue("Gender").ToString
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        db.sql = "UPDATE Driver SET FrsName = @frs, MiddleNme = @mid, LstName = @last, Address = @address, City = @city, State = @state, County = @county, Zipcode = @zip, InsurancePolicyID = @ins, LicenseType = @type, ExpirationDate = @expir, Endorsements = @endorse, Height = @height, HairClr = @hair, Weight = @weight, EyeClr = @eyes, Gender = @gender WHERE LicenseNumber = @driver_ID"

        db.bind("@frs", txtFrstName.Text)
        db.bind("@mid", txtMiddle.Text)
        db.bind("@Last", txtLast.Text)
        db.bind("@address", txtAddress.Text)
        db.bind("@city", txtCity.Text)
        db.bind("@state", txtState.Text)
        db.bind("@county", txtCounty.Text)
        db.bind("@zip", txtZip.Text)
        db.bind("@ins", txtIns.Text)
        db.bind("@type", txtType.Text)
        db.bind("@expir", txtExpir.Text)
        db.bind("@endorse", txtEndorse.Text)
        db.bind("@height", txtHeight.Text)
        db.bind("@hair", txtHair.Text)
        db.bind("@weight", txtWeight.Text)
        db.bind("@eyes", txtEyes.Text)
        db.bind("@gender", cmbGender.Text)
        db.bind("@driver_ID", personID)
        db.execute()
        Me.Dispose()

    End Sub
End Class