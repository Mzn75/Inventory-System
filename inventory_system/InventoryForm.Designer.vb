<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InventoryForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New DataVisualization.Charting.Series()
        btnAdd = New Button()
        btnShow = New Button()
        gridItems = New DataGridView()
        Chart1 = New DataVisualization.Charting.Chart()
        btnUpdate = New Button()
        btnDelete = New Button()
        Panel2 = New Panel()
        btnSearch = New Button()
        btnImport = New Button()
        btnExport = New Button()
        btnStockSettings = New Button()
        CType(gridItems, ComponentModel.ISupportInitialize).BeginInit()
        CType(Chart1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnAdd
        ' 
        btnAdd.BackColor = Color.SteelBlue
        btnAdd.Font = New Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAdd.ForeColor = Color.White
        btnAdd.Location = New Point(17, 144)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(122, 122)
        btnAdd.TabIndex = 9
        btnAdd.Text = "Add Item"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' btnShow
        ' 
        btnShow.BackColor = Color.SteelBlue
        btnShow.Font = New Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnShow.ForeColor = Color.White
        btnShow.Location = New Point(17, 16)
        btnShow.Name = "btnShow"
        btnShow.Size = New Size(122, 122)
        btnShow.TabIndex = 10
        btnShow.Text = "Show Inventory"
        btnShow.UseVisualStyleBackColor = False
        ' 
        ' gridItems
        ' 
        gridItems.AllowUserToAddRows = False
        gridItems.AllowUserToDeleteRows = False
        gridItems.AllowUserToResizeColumns = False
        gridItems.AllowUserToResizeRows = False
        gridItems.BackgroundColor = Color.White
        gridItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Window
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = Color.SkyBlue
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.False
        gridItems.DefaultCellStyle = DataGridViewCellStyle1
        gridItems.EnableHeadersVisualStyles = False
        gridItems.Location = New Point(317, 11)
        gridItems.Name = "gridItems"
        gridItems.ReadOnly = True
        gridItems.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.LightSteelBlue
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        gridItems.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        gridItems.RowHeadersVisible = False
        gridItems.Size = New Size(868, 649)
        gridItems.TabIndex = 11
        ' 
        ' Chart1
        ' 
        ChartArea1.Name = "ChartArea1"
        Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Chart1.Legends.Add(Legend1)
        Chart1.Location = New Point(1191, 11)
        Chart1.Name = "Chart1"
        Chart1.Palette = DataVisualization.Charting.ChartColorPalette.SeaGreen
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = DataVisualization.Charting.SeriesChartType.Pie
        Series1.Font = New Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Series1.LabelForeColor = Color.White
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Chart1.Series.Add(Series1)
        Chart1.Size = New Size(416, 375)
        Chart1.TabIndex = 13
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = Color.SteelBlue
        btnUpdate.Font = New Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnUpdate.ForeColor = Color.White
        btnUpdate.Location = New Point(156, 16)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(122, 122)
        btnUpdate.TabIndex = 14
        btnUpdate.Text = "Update Item"
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.SteelBlue
        btnDelete.Font = New Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDelete.ForeColor = Color.White
        btnDelete.Location = New Point(156, 144)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(122, 122)
        btnDelete.TabIndex = 15
        btnDelete.Text = "Delete Item"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(btnStockSettings)
        Panel2.Controls.Add(btnSearch)
        Panel2.Controls.Add(btnImport)
        Panel2.Controls.Add(btnExport)
        Panel2.Controls.Add(btnDelete)
        Panel2.Controls.Add(btnUpdate)
        Panel2.Controls.Add(btnShow)
        Panel2.Controls.Add(btnAdd)
        Panel2.Location = New Point(12, 11)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(299, 542)
        Panel2.TabIndex = 20
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = Color.SteelBlue
        btnSearch.Font = New Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSearch.ForeColor = Color.White
        btnSearch.Location = New Point(17, 400)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(122, 122)
        btnSearch.TabIndex = 18
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' btnImport
        ' 
        btnImport.BackColor = Color.SteelBlue
        btnImport.Font = New Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnImport.ForeColor = Color.White
        btnImport.Location = New Point(156, 272)
        btnImport.Name = "btnImport"
        btnImport.Size = New Size(122, 122)
        btnImport.TabIndex = 17
        btnImport.Text = "Import"
        btnImport.UseVisualStyleBackColor = False
        ' 
        ' btnExport
        ' 
        btnExport.BackColor = Color.SteelBlue
        btnExport.Font = New Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnExport.ForeColor = Color.White
        btnExport.Location = New Point(17, 272)
        btnExport.Name = "btnExport"
        btnExport.Size = New Size(122, 122)
        btnExport.TabIndex = 16
        btnExport.Text = "Export"
        btnExport.UseVisualStyleBackColor = False
        ' 
        ' btnStockSettings
        ' 
        btnStockSettings.BackColor = Color.SteelBlue
        btnStockSettings.Font = New Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnStockSettings.ForeColor = Color.White
        btnStockSettings.Location = New Point(156, 400)
        btnStockSettings.Name = "btnStockSettings"
        btnStockSettings.Size = New Size(122, 122)
        btnStockSettings.TabIndex = 19
        btnStockSettings.Text = "Stock Settings"
        btnStockSettings.UseVisualStyleBackColor = False
        ' 
        ' InventoryForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        ClientSize = New Size(1619, 684)
        Controls.Add(Panel2)
        Controls.Add(Chart1)
        Controls.Add(gridItems)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "InventoryForm"
        Text = "Inventory"
        CType(gridItems, ComponentModel.ISupportInitialize).EndInit()
        CType(Chart1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnShow As Button
    Friend WithEvents gridItems As DataGridView
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnExport As Button
    Friend WithEvents btnImport As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnStockSettings As Button

End Class
