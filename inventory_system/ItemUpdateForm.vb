Imports System.Data.OleDb
Imports System.ComponentModel

Public Class ItemUpdateForm
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

    Dim dbPath As String = IO.Path.Combine(Application.StartupPath, "Inventory.accdb")
    Dim connStr As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & dbPath & ";Persist Security Info=False;"

    Private Sub ItemUpdateForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using conn As New OleDbConnection(connStr)
            conn.Open()
            Dim cmd As New OleDbCommand("SELECT ItemID, ItemName FROM Items", conn)
            Dim dt As New DataTable()
            dt.Load(cmd.ExecuteReader())

            cboItems.DataSource = dt
            cboItems.DisplayMember = "ItemName"
            cboItems.ValueMember = "ItemID"

            cboItems.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            cboItems.AutoCompleteSource = AutoCompleteSource.ListItems
        End Using
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        ItemID = cboItems.SelectedValue.ToString()
        ItemName = cboItems.Text

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