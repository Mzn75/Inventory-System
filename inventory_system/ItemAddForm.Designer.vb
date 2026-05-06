<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ItemAddForm
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
        Panel1 = New Panel()
        GroupBox1 = New GroupBox()
        txtPrice = New TextBox()
        txtQty = New TextBox()
        txtName = New TextBox()
        txtID = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        btnAdd = New Button()
        btnCancel = New Button()
        Panel1.SuspendLayout()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(GroupBox1)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(12, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(299, 213)
        Panel1.TabIndex = 20
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(txtPrice)
        GroupBox1.Controls.Add(txtQty)
        GroupBox1.Controls.Add(txtName)
        GroupBox1.Controls.Add(txtID)
        GroupBox1.FlatStyle = FlatStyle.Popup
        GroupBox1.Font = New Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.ForeColor = SystemColors.ButtonShadow
        GroupBox1.Location = New Point(118, 15)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(160, 176)
        GroupBox1.TabIndex = 12
        GroupBox1.TabStop = False
        GroupBox1.Text = "Item Details"
        ' 
        ' txtPrice
        ' 
        txtPrice.Font = New Font("Calibri", 9.75F)
        txtPrice.Location = New Point(2, 137)
        txtPrice.Name = "txtPrice"
        txtPrice.PlaceholderText = "Price"
        txtPrice.Size = New Size(158, 23)
        txtPrice.TabIndex = 3
        ' 
        ' txtQty
        ' 
        txtQty.Font = New Font("Calibri", 9.75F)
        txtQty.Location = New Point(2, 99)
        txtQty.Name = "txtQty"
        txtQty.PlaceholderText = "Quantity"
        txtQty.Size = New Size(158, 23)
        txtQty.TabIndex = 2
        ' 
        ' txtName
        ' 
        txtName.Font = New Font("Calibri", 9.75F)
        txtName.Location = New Point(2, 61)
        txtName.Name = "txtName"
        txtName.PlaceholderText = "Item Name"
        txtName.Size = New Size(158, 23)
        txtName.TabIndex = 1
        ' 
        ' txtID
        ' 
        txtID.Font = New Font("Calibri", 9.75F)
        txtID.Location = New Point(2, 22)
        txtID.Name = "txtID"
        txtID.PlaceholderText = "Item ID"
        txtID.Size = New Size(158, 23)
        txtID.TabIndex = 0
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Calibri", 14.25F, FontStyle.Bold)
        Label4.Location = New Point(17, 154)
        Label4.Name = "Label4"
        Label4.Size = New Size(50, 23)
        Label4.TabIndex = 7
        Label4.Text = "Price"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Calibri", 14.25F, FontStyle.Bold)
        Label3.Location = New Point(17, 116)
        Label3.Name = "Label3"
        Label3.Size = New Size(79, 23)
        Label3.TabIndex = 6
        Label3.Text = "Quantity"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Calibri", 14.25F, FontStyle.Bold)
        Label2.Location = New Point(17, 78)
        Label2.Name = "Label2"
        Label2.Size = New Size(98, 23)
        Label2.TabIndex = 5
        Label2.Text = "Item Name"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Calibri", 14.25F, FontStyle.Bold)
        Label1.Location = New Point(17, 39)
        Label1.Name = "Label1"
        Label1.Size = New Size(68, 23)
        Label1.TabIndex = 4
        Label1.Text = "Item ID"
        ' 
        ' btnAdd
        ' 
        btnAdd.BackColor = Color.SteelBlue
        btnAdd.Font = New Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAdd.ForeColor = Color.White
        btnAdd.Location = New Point(29, 231)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(115, 52)
        btnAdd.TabIndex = 21
        btnAdd.Text = "Add Item"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.SteelBlue
        btnCancel.Font = New Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCancel.ForeColor = Color.White
        btnCancel.Location = New Point(175, 231)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(115, 52)
        btnCancel.TabIndex = 22
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' ItemAddForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(323, 295)
        Controls.Add(btnCancel)
        Controls.Add(btnAdd)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        MinimizeBox = False
        Name = "ItemAddForm"
        Text = "Add Item"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtQty As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnCancel As Button
End Class
