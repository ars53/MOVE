Public Class Add
    Protected db As db = New db

    Private Sub MainMenuToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Main.Show()
        Me.Close()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub LookupToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Lookup.Show()
        Me.Close()

    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Delete.Show()
        Me.Close()

    End Sub

    Private Sub UpdateUserInfoToolStripMenuItem_Click(sender As Object, e As EventArgs)
        UpdateInfo.Show()
        Me.Close()

    End Sub

    Private Sub btnAddUser_Click(sender As Object, e As EventArgs) Handles btnAddUser.Click
        db.sql = "INSERT INTO Driver (FrsName, LstName, MiddleNme, Address, City, State, County, Zipcode, InsurancePolicyId, LicenseType, ExpirationDate, Endorsements, Height, HairClr, Weight, Eyeclr, Gender) Values (@frst, @lst, @middle, @address, @city, @state, @county, @zipcode,@Ins, @Type, @Exp, @endorse, @height, @hair, @weight, @eyes, @gender)"
        db.bind("@frst", txtFrstN.Text)
        db.bind("@lst", txtLastN.Text)
        db.bind("@middle", txtMiddleN.Text)
        db.bind("@address", txtAddress.Text)
        db.bind("@city", txtCity.Text)
        db.bind("@state", txtState.Text.ToUpper)
        db.bind("@County", txtCounty.Text)
        db.bind("@zipcode", txtZip.Text)
        db.bind("@Ins", txtIns.Text)
        db.bind("@Type", txtLType.Text)
        db.bind("@Exp", txtExp.Text)
        db.bind("@endorse", txtEndorse.Text)
        db.bind("@height", txtHeight.Text)
        db.bind("@hair", txtHaircolor.Text)
        db.bind("@weight", txtWeight.Text)
        db.bind("@eyes", txtEyeColor.Text)
        db.bind("@gender", cmbGender.Text)
        db.execute()
        Me.Dispose()
    End Sub

End Class