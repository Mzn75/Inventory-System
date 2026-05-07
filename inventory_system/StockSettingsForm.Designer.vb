<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StockSettingsForm
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
        NumericUpDown1 = New NumericUpDown()
        btnCancel = New Button()
        btnSave = New Button()
        Panel1 = New Panel()
        Label2 = New Label()
        Label1 = New Label()
        Label3 = New Label()
        numHigh = New NumericUpDown()
        numMedium = New NumericUpDown()
        numLow = New NumericUpDown()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(numHigh, ComponentModel.ISupportInitialize).BeginInit()
        CType(numMedium, ComponentModel.ISupportInitialize).BeginInit()
        CType(numLow, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' NumericUpDown1
        ' 
        NumericUpDown1.Location = New Point(139, 27)
        NumericUpDown1.Name = "NumericUpDown1"
        NumericUpDown1.Size = New Size(0, 23)
        NumericUpDown1.TabIndex = 0
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.SteelBlue
        btnCancel.Font = New Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCancel.ForeColor = Color.White
        btnCancel.Location = New Point(196, 143)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(115, 52)
        btnCancel.TabIndex = 28
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.SteelBlue
        btnSave.Font = New Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSave.ForeColor = Color.White
        btnSave.Location = New Point(12, 143)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(115, 52)
        btnSave.TabIndex = 27
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(numHigh)
        Panel1.Controls.Add(numMedium)
        Panel1.Controls.Add(numLow)
        Panel1.Location = New Point(12, 13)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(299, 111)
        Panel1.TabIndex = 26
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Calibri", 14.25F, FontStyle.Bold)
        Label2.Location = New Point(17, 72)
        Label2.Name = "Label2"
        Label2.Size = New Size(92, 23)
        Label2.TabIndex = 16
        Label2.Text = "High Level"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Calibri", 14.25F, FontStyle.Bold)
        Label1.Location = New Point(17, 43)
        Label1.Name = "Label1"
        Label1.Size = New Size(123, 23)
        Label1.TabIndex = 15
        Label1.Text = "Medium Level"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Calibri", 14.25F, FontStyle.Bold)
        Label3.Location = New Point(17, 14)
        Label3.Name = "Label3"
        Label3.Size = New Size(88, 23)
        Label3.TabIndex = 14
        Label3.Text = "Low Level"
        ' 
        ' numHigh
        ' 
        numHigh.Location = New Point(163, 72)
        numHigh.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        numHigh.Name = "numHigh"
        numHigh.Size = New Size(133, 23)
        numHigh.TabIndex = 2
        ' 
        ' numMedium
        ' 
        numMedium.Location = New Point(163, 43)
        numMedium.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        numMedium.Name = "numMedium"
        numMedium.Size = New Size(133, 23)
        numMedium.TabIndex = 1
        ' 
        ' numLow
        ' 
        numLow.Location = New Point(163, 14)
        numLow.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        numLow.Name = "numLow"
        numLow.Size = New Size(133, 23)
        numLow.TabIndex = 0
        ' 
        ' StockSettingsForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(323, 213)
        Controls.Add(btnCancel)
        Controls.Add(btnSave)
        Controls.Add(Panel1)
        Controls.Add(NumericUpDown1)
        Name = "StockSettingsForm"
        Text = "StockSettingsForm"
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(numHigh, ComponentModel.ISupportInitialize).EndInit()
        CType(numMedium, ComponentModel.ISupportInitialize).EndInit()
        CType(numLow, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents numHigh As NumericUpDown
    Friend WithEvents numMedium As NumericUpDown
    Friend WithEvents numLow As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
End Class
