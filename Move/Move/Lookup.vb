Public Class Lookup
    Protected db As New db
    Private Sub MainMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MainMenuToolStripMenuItem.Click
        Main.Show()
        Me.Close()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AddToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem.Click
        Add.Show()
        Me.Close()

    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        Delete.Show()
        Me.Close()

    End Sub

    Private Sub UpdateUserInfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateUserInfoToolStripMenuItem.Click
        UpdateInfo.Show()
        Me.Close()

    End Sub

    Protected Sub loadPeople()
        db.sql = "SELECT * FROM Driver ORDER BY LstName"
        db.fill(dgvLookup)
    End Sub
    Private Sub Lookup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadPeople()

    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        db.sql = "Select * FROM Driver Where LicenseNumber = @driverID"
        db.bind("@driverID", txtDL.Text)

        db.fill(dgvLookup)

    End Sub
    Public Function getPersonID() As Integer
        Return getPersonvalue("LicenseNumber")
    End Function
    Public Function getPersonvalue(ByVal column As String)
        Return dgvLookup.Item(column, dgvLookup.CurrentRow.Index).Value
    End Function
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim UpdatePersonInfo As New UpdatePersonInfo(getPersonID())
        UpdatePersonInfo.ShowDialog()
        loadPeople()

    End Sub
End Class