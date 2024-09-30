<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataForm
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        btnCalculate = New Button()
        Button2 = New Button()
        txtBasicPay = New TextBox()
        TextBox2 = New TextBox()
        txtMedicalAllowance = New TextBox()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(144, 106)
        Label1.Name = "Label1"
        Label1.Size = New Size(94, 15)
        Label1.TabIndex = 0
        Label1.Text = "Employee Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(144, 153)
        Label2.Name = "Label2"
        Label2.Size = New Size(56, 15)
        Label2.TabIndex = 1
        Label2.Text = "Basic Pay"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(144, 201)
        Label3.Name = "Label3"
        Label3.Size = New Size(107, 15)
        Label3.TabIndex = 2
        Label3.Text = "Medical Allowance"
        ' 
        ' btnCalculate
        ' 
        btnCalculate.Location = New Point(320, 285)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(94, 42)
        btnCalculate.TabIndex = 3
        btnCalculate.Text = "Calculate"
        btnCalculate.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(563, 285)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 41)
        Button2.TabIndex = 4
        Button2.Text = "Next"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' txtBasicPay
        ' 
        txtBasicPay.Location = New Point(300, 150)
        txtBasicPay.Name = "txtBasicPay"
        txtBasicPay.Size = New Size(402, 23)
        txtBasicPay.TabIndex = 5
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(300, 103)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(402, 23)
        TextBox2.TabIndex = 6
        ' 
        ' txtMedicalAllowance
        ' 
        txtMedicalAllowance.Location = New Point(300, 198)
        txtMedicalAllowance.Name = "txtMedicalAllowance"
        txtMedicalAllowance.Size = New Size(402, 23)
        txtMedicalAllowance.TabIndex = 7
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(398, 41)
        Label4.Name = "Label4"
        Label4.Size = New Size(59, 15)
        Label4.TabIndex = 8
        Label4.Text = "DataForm"
        ' 
        ' DataForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label4)
        Controls.Add(txtMedicalAllowance)
        Controls.Add(TextBox2)
        Controls.Add(txtBasicPay)
        Controls.Add(Button2)
        Controls.Add(btnCalculate)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "DataForm"
        Text = "DataForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents txtBasicPay As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents txtMedicalAllowance As TextBox
    Friend WithEvents Label4 As Label
End Class
