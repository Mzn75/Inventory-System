<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ItemUpdateForm
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
        btnCancel = New Button()
        btnUpdate = New Button()
        Panel1 = New Panel()
        cboItems = New ComboBox()
        GroupBox1 = New GroupBox()
        txtPrice = New TextBox()
        txtQty = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        Panel1.SuspendLayout()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.SteelBlue
        btnCancel.Font = New Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCancel.ForeColor = Color.White
        btnCancel.Location = New Point(175, 231)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(115, 52)
        btnCancel.TabIndex = 25
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = Color.SteelBlue
        btnUpdate.Font = New Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnUpdate.ForeColor = Color.White
        btnUpdate.Location = New Point(29, 231)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(115, 52)
        btnUpdate.TabIndex = 24
        btnUpdate.Text = "Update Item"
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(GroupBox1)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(cboItems)
        Panel1.Location = New Point(12, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(299, 213)
        Panel1.TabIndex = 23
        ' 
        ' cboItems
        ' 
        cboItems.FormattingEnabled = True
        cboItems.Location = New Point(3, 12)
        cboItems.Name = "cboItems"
        cboItems.Size = New Size(293, 23)
        cboItems.TabIndex = 0
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(txtPrice)
        GroupBox1.Controls.Add(txtQty)
        GroupBox1.FlatStyle = FlatStyle.Popup
        GroupBox1.Font = New Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.ForeColor = SystemColors.ButtonShadow
        GroupBox1.Location = New Point(127, 75)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(160, 124)
        GroupBox1.TabIndex = 15
        GroupBox1.TabStop = False
        GroupBox1.Text = "Item Details"
        ' 
        ' txtPrice
        ' 
        txtPrice.Font = New Font("Calibri", 9.75F)
        txtPrice.Location = New Point(0, 81)
        txtPrice.Name = "txtPrice"
        txtPrice.PlaceholderText = "Price"
        txtPrice.Size = New Size(158, 23)
        txtPrice.TabIndex = 3
        ' 
        ' txtQty
        ' 
        txtQty.Font = New Font("Calibri", 9.75F)
        txtQty.Location = New Point(2, 36)
        txtQty.Name = "txtQty"
        txtQty.PlaceholderText = "Quantity"
        txtQty.Size = New Size(158, 23)
        txtQty.TabIndex = 2
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Calibri", 14.25F, FontStyle.Bold)
        Label4.Location = New Point(17, 153)
        Label4.Name = "Label4"
        Label4.Size = New Size(50, 23)
        Label4.TabIndex = 14
        Label4.Text = "Price"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Calibri", 14.25F, FontStyle.Bold)
        Label3.Location = New Point(17, 111)
        Label3.Name = "Label3"
        Label3.Size = New Size(79, 23)
        Label3.TabIndex = 13
        Label3.Text = "Quantity"
        ' 
        ' ItemUpdateForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(323, 297)
        Controls.Add(btnCancel)
        Controls.Add(btnUpdate)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        MinimizeBox = False
        Name = "ItemUpdateForm"
        Text = "Update Item"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnCancel As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents cboItems As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtQty As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
End Class
