Imports System.Data
Imports System.Data.OleDb
Imports System.Windows.Forms.DataVisualization.Charting
Imports ClosedXML.Excel


Public Class InventoryForm
    Dim conn As OleDbConnection
    Dim adapter As OleDbDataAdapter
    Dim dt As DataTable
    Dim dbPath As String = IO.Path.Combine(Application.StartupPath, "Inventory.accdb")
    Dim connStr As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & dbPath & ";Persist Security Info=False;"

    Private Sub StockStatus()
        For Each row As DataGridViewRow In gridItems.Rows
            If Not row.IsNewRow Then
                Dim qty As Integer = 0
                If row.Cells("Quantity").Value IsNot Nothing AndAlso Not IsDBNull(row.Cells("Quantity").Value) Then
                    qty = Convert.ToInt32(row.Cells("Quantity").Value)
                End If

                If qty < 100 Then
                    row.Cells("StockStatus").Value = "Low"
                    row.Cells("StockStatus").Style.BackColor = Color.LightCoral
                ElseIf qty < 500 Then
                    row.Cells("StockStatus").Value = "Medium"
                    row.Cells("StockStatus").Style.BackColor = Color.Khaki
                Else
                    row.Cells("StockStatus").Value = "High"
                    row.Cells("StockStatus").Style.BackColor = Color.LightGreen
                End If
            End If
        Next
    End Sub

    Private Sub LoadChart()
        If dt Is Nothing OrElse dt.Rows.Count = 0 Then Exit Sub

        Chart1.Series.Clear()
        Dim seriesName As String = "Inventory"
        Chart1.Series.Add(seriesName)
        Chart1.Series(seriesName).ChartType = SeriesChartType.Pie

        For Each row As DataRow In dt.Rows
            Dim itemName As String = row("ItemName").ToString()
            Dim itemQuantity As Double = Convert.ToDouble(row("Quantity"))
            Dim itemID As Double = Convert.ToDouble(row("itemID"))
            Chart1.Series(seriesName).Points.AddXY(itemID, itemQuantity)
        Next

        Chart1.Series(seriesName).IsValueShownAsLabel = True
        Chart1.Series("Inventory").Font = New Font("Calibri", 10, FontStyle.Bold)
    End Sub

    Private Sub ShowInventory()
        If Not IO.File.Exists(dbPath) Then
            MessageBox.Show("Database file not found: " & dbPath)
            Exit Sub
        End If

        Using conn As New OleDbConnection(connStr)
            adapter = New OleDbDataAdapter("SELECT * FROM Items", conn)
            dt = New DataTable()
            adapter.Fill(dt)
            gridItems.DataSource = dt
            gridItems.Sort(gridItems.Columns("ItemID"), System.ComponentModel.ListSortDirection.Ascending)
            gridItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        End Using

        If Not gridItems.Columns.Contains("StockStatus") Then
            Dim statusCol As New DataGridViewTextBoxColumn()
            statusCol.Name = "StockStatus"
            statusCol.HeaderText = "Stock Status"
            gridItems.Columns.Add(statusCol)
        End If

        StockStatus()
        LoadChart()
    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        ShowInventory()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim dlg As New ItemAddForm

        If dlg.ShowDialog = DialogResult.OK Then
            Dim newId = dlg.ItemID

            Using conn As New OleDbConnection(connStr)
                conn.Open()

                Dim checkCmd As New OleDbCommand("SELECT COUNT(*) FROM Items WHERE ItemID=@id", conn)
                checkCmd.Parameters.AddWithValue("@id", newId)
                Dim exists = Convert.ToInt32(checkCmd.ExecuteScalar)
                If exists > 0 Then
                    MessageBox.Show("Item ID already exists.")
                    Return
                End If

                Dim cmd As New OleDbCommand("INSERT INTO Items (ItemID, ItemName, Quantity, Price) VALUES (@id, @name, @qty, @price)", conn)
                cmd.Parameters.AddWithValue("@id", dlg.ItemID)
                cmd.Parameters.AddWithValue("@name", dlg.ItemName)
                cmd.Parameters.AddWithValue("@qty", dlg.Quantity)
                cmd.Parameters.AddWithValue("@price", dlg.Price)
                cmd.ExecuteNonQuery()
            End Using

            StockStatus()
            ShowInventory()
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim dlg As New ItemUpdateForm()
        dlg.ItemID = gridItems.CurrentRow.Cells("ItemID").Value.ToString()
        dlg.ItemName = gridItems.CurrentRow.Cells("ItemName").Value.ToString()
        dlg.Quantity = Convert.ToInt32(gridItems.CurrentRow.Cells("Quantity").Value)
        dlg.Price = Convert.ToDecimal(gridItems.CurrentRow.Cells("Price").Value)

        If dlg.ShowDialog() = DialogResult.OK Then
            Using conn As New OleDbConnection(connStr)
                conn.Open()

                Dim cmd As New OleDbCommand(
                "UPDATE Items SET ItemName=@name, Quantity=@qty, Price=@price WHERE ItemID=@id", conn)

                cmd.Parameters.AddWithValue("@name", dlg.ItemName)
                cmd.Parameters.AddWithValue("@qty", dlg.Quantity)
                cmd.Parameters.AddWithValue("@price", dlg.Price)
                cmd.Parameters.AddWithValue("@id", dlg.ItemID)

                cmd.ExecuteNonQuery()
            End Using

            ShowInventory()
            StockStatus()
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If gridItems.CurrentRow Is Nothing Then Return
        Dim itemId As String = gridItems.CurrentRow.Cells("ItemID").Value.ToString()
        If MessageBox.Show("Delete Item ID " & itemId & "?", "Confirm Delete", MessageBoxButtons.YesNo) = DialogResult.No Then Return

        Using conn As New OleDbConnection(connStr)
            conn.Open()
            Dim cmd As New OleDbCommand("DELETE FROM Items WHERE ItemID=@id", conn)
            cmd.Parameters.AddWithValue("@id", itemId)
            cmd.ExecuteNonQuery()
        End Using

        ShowInventory()
        StockStatus()
        LoadChart()
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        Dim sfd As New SaveFileDialog()
        sfd.Filter = "Excel files (*.xlsx)|*.xlsx"
        sfd.FileName = "InventoryExport.xlsx"

        If sfd.ShowDialog() = DialogResult.OK Then
            Dim wb As New XLWorkbook()
            Dim ws = wb.Worksheets.Add("Inventory")

            For i As Integer = 0 To gridItems.Columns.Count - 1
                ws.Cell(1, i + 1).Value = gridItems.Columns(i).HeaderText
                ws.Cell(1, i + 1).Style.Font.Bold = True
            Next

            For r As Integer = 0 To gridItems.Rows.Count - 1
                If Not gridItems.Rows(r).IsNewRow Then
                    For c As Integer = 0 To gridItems.Columns.Count - 1
                        Dim val = gridItems.Rows(r).Cells(c).Value
                        If val Is Nothing OrElse IsDBNull(val) Then
                            ws.Cell(r + 2, c + 1).Value = ""
                        Else
                            ws.Cell(r + 2, c + 1).Value = val.ToString()
                        End If
                    Next
                End If
            Next

            wb.SaveAs(sfd.FileName)
            MessageBox.Show("Exported successfully to " & sfd.FileName)
        End If
    End Sub

    Private Sub btnImport_Click(sender As Object, e As EventArgs) Handles btnImport.Click
        Dim ofd As New OpenFileDialog()
        ofd.Filter = "Excel files (*.xlsx)|*.xlsx"
        ofd.Title = "Select Excel File"

        If ofd.ShowDialog() = DialogResult.OK Then
            Dim dt As New DataTable()

            Using wb As New XLWorkbook(ofd.FileName)
                Dim ws = wb.Worksheet(1)

                Dim headerRow = ws.Row(1)
                For Each cell In headerRow.Cells()
                    dt.Columns.Add(cell.Value.ToString())
                Next

                For r As Integer = 2 To ws.LastRowUsed().RowNumber()
                    Dim dataRow = dt.NewRow()
                    For c As Integer = 1 To dt.Columns.Count
                        dataRow(c - 1) = ws.Cell(r, c).Value.ToString()
                    Next
                    dt.Rows.Add(dataRow)
                Next
            End Using

            Using conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\Inventory.accdb")
                conn.Open()
                For Each row As DataRow In dt.Rows
                    Dim checkCmd As New OleDbCommand("SELECT COUNT(*) FROM Items WHERE ItemID=@id", conn)
                    checkCmd.Parameters.AddWithValue("@id", row("ItemID"))
                    Dim exists As Integer = CInt(checkCmd.ExecuteScalar())

                    If exists = 0 Then
                        Dim insertCmd As New OleDbCommand("INSERT INTO Items (ItemID, ItemName, Quantity, Price) VALUES (@id,@name,@qty,@price)", conn)
                        insertCmd.Parameters.AddWithValue("@id", row("ItemID"))
                        insertCmd.Parameters.AddWithValue("@name", row("ItemName"))
                        insertCmd.Parameters.AddWithValue("@qty", row("Quantity"))
                        insertCmd.Parameters.AddWithValue("@price", row("Price"))
                        insertCmd.ExecuteNonQuery()
                    Else
                    End If
                Next
            End Using

            gridItems.DataSource = dt
            MessageBox.Show("Imported successfully and saved to Access.")
        End If

        StockStatus()
        ShowInventory()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim sf As New SearchForm()
        sf.ShowDialog()
    End Sub


End Class
