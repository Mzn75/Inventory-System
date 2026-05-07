<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        btnSearch = New Button()
        txtSearch = New TextBox()
        gridItems = New DataGridView()
        CType(gridItems, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = Color.SteelBlue
        btnSearch.Font = New Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSearch.ForeColor = Color.White
        btnSearch.Location = New Point(253, 41)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(97, 46)
        btnSearch.TabIndex = 17
        btnSearch.Text = "Go"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(190, 12)
        txtSearch.Name = "txtSearch"
        txtSearch.PlaceholderText = "Type Item Name or ID"
        txtSearch.Size = New Size(227, 23)
        txtSearch.TabIndex = 18
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
        gridItems.Location = New Point(12, 93)
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
        gridItems.Size = New Size(592, 244)
        gridItems.TabIndex = 19
        ' 
        ' SearchForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(616, 349)
        Controls.Add(gridItems)
        Controls.Add(txtSearch)
        Controls.Add(btnSearch)
        FormBorderStyle = FormBorderStyle.Fixed3D
        MaximizeBox = False
        MinimizeBox = False
        Name = "SearchForm"
        Text = "Search"
        CType(gridItems, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents gridItems As DataGridView
End Class
