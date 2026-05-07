Imports System.ComponentModel
Imports System.Data.OleDb
Imports System

Public Class ItemAddForm
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Public Property ItemID As String
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Public Property ItemName As String
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Public Property Quantity As Integer
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Public Property Price As Decimal
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Public Property LastUpdated As DateTime

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ItemID = txtID.Text.Trim()
        ItemName = txtName.Text.Trim()
        Quantity = If(String.IsNullOrEmpty(txtQty.Text), 0, Convert.ToInt32(txtQty.Text))
        Price = If(String.IsNullOrEmpty(txtPrice.Text), 0, Convert.ToDecimal(txtPrice.Text))
        LastUpdated = DateTime.Now

        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class