Imports System.Data.OleDb

Public Class ItemUpdateForm
    Public Property ItemID As String
    Public Property ItemName As String
    Public Property Quantity As Integer
    Public Property Price As Decimal

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs)
        ItemID = txtID.Text.Trim()
        ItemName = txtName.Text.Trim()
        Quantity = If(String.IsNullOrEmpty(txtQty.Text), 0, Convert.ToInt32(txtQty.Text))
        Price = If(String.IsNullOrEmpty(txtPrice.Text), 0, Convert.ToDecimal(txtPrice.Text))

        DialogResult = DialogResult.OK
        Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs)
        DialogResult = DialogResult.Cancel
        Close()
    End Sub

End Class