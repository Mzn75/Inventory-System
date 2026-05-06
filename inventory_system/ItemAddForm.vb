Imports System.Data.OleDb

Public Class ItemAddForm
    Public Property ItemID As String
    Public Property ItemName As String
    Public Property Quantity As Integer
    Public Property Price As Decimal

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ItemID = txtID.Text.Trim()
        ItemName = txtName.Text.Trim()
        Quantity = If(String.IsNullOrEmpty(txtQty.Text), 0, Convert.ToInt32(txtQty.Text))
        Price = If(String.IsNullOrEmpty(txtPrice.Text), 0, Convert.ToDecimal(txtPrice.Text))

        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class