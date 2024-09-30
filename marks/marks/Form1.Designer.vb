<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txtMarks = New TextBox()
        txtGrade = New TextBox()
        btnEvaluate = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(249, 54)
        Label1.Name = "Label1"
        Label1.Size = New Size(136, 15)
        Label1.TabIndex = 0
        Label1.Text = "Grading Scale Calculator"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(162, 109)
        Label2.Name = "Label2"
        Label2.Size = New Size(69, 15)
        Label2.TabIndex = 1
        Label2.Text = "Enter Marks"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(162, 146)
        Label3.Name = "Label3"
        Label3.Size = New Size(38, 15)
        Label3.TabIndex = 2
        Label3.Text = "Grade"
        ' 
        ' txtMarks
        ' 
        txtMarks.Location = New Point(300, 101)
        txtMarks.Name = "txtMarks"
        txtMarks.Size = New Size(230, 23)
        txtMarks.TabIndex = 3
        ' 
        ' txtGrade
        ' 
        txtGrade.Location = New Point(300, 138)
        txtGrade.Name = "txtGrade"
        txtGrade.Size = New Size(230, 23)
        txtGrade.TabIndex = 4
        ' 
        ' btnEvaluate
        ' 
        btnEvaluate.Location = New Point(249, 201)
        btnEvaluate.Name = "btnEvaluate"
        btnEvaluate.Size = New Size(95, 36)
        btnEvaluate.TabIndex = 5
        btnEvaluate.Text = "Evaluate"
        btnEvaluate.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnEvaluate)
        Controls.Add(txtGrade)
        Controls.Add(txtMarks)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Grade Calculator"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtMarks As TextBox
    Friend WithEvents txtGrade As TextBox
    Friend WithEvents btnEvaluate As Button

End Class
