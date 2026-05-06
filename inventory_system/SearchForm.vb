Imports DocumentFormat.OpenXml.Wordprocessing
Imports System.Data.OleDb

Public Class SearchForm

    Private Sub StockStatus()
        For Each row As DataGridViewRow In gridItems.Rows
            If Not row.IsNewRow Then
                Dim qty As Integer = 0
                If row.Cells("Quantity").Value IsNot Nothing AndAlso Not IsDBNull(row.Cells("Quantity").Value) Then
                    qty = Convert.ToInt32(row.Cells("Quantity").Value)
                End If

                If qty < 100 Then
                    row.Cells("StockStatus").Value = "Low"
                    row.Cells("StockStatus").Style.BackColor = System.Drawing.Color.LightCoral
                ElseIf qty < 500 Then
                    row.Cells("StockStatus").Value = "Medium"
                    row.Cells("StockStatus").Style.BackColor = System.Drawing.Color.Khaki
                Else
                    row.Cells("StockStatus").Value = "High"
                    row.Cells("StockStatus").Style.BackColor = System.Drawing.Color.LightGreen
                End If
            End If
        Next
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim searchText As String = txtSearch.Text.Trim()

        If searchText = "" Then
            MessageBox.Show("Please enter a search term.")
            Return
        End If

        Using conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\Inventory.accdb")
            conn.Open()

            Dim sql As String = "SELECT * FROM Items WHERE ItemID LIKE @search OR ItemName LIKE @search"
            Dim cmd As New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@search", "%" & searchText & "%")

            Dim da As New OleDbDataAdapter(cmd)
            Dim dt As New DataTable()
            da.Fill(dt)

            gridItems.DataSource = dt
        End Using
        gridItems.Sort(gridItems.Columns("ItemID"), System.ComponentModel.ListSortDirection.Ascending)
        gridItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        StockStatus()
    End Sub

End Class