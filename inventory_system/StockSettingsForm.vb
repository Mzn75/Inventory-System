Imports System.ComponentModel
Imports System.ComponentModel.Design.Serialization
Public Class StockSettingsForm
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Public Property LowThreshold As Integer
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Public Property MediumThreshold As Integer
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Public Property HighThreshold As Integer

    Private Sub StockSettingsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        numLow.Value = LowThreshold
        numMedium.Value = MediumThreshold
        numHigh.Value = HighThreshold
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        LowThreshold = Convert.ToInt32(numLow.Value)
        MediumThreshold = Convert.ToInt32(numMedium.Value)
        HighThreshold = Convert.ToInt32(numHigh.Value)
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class