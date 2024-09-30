<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportForm
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
        Label4 = New Label()
        btnBack = New Button()
        lblGrossPayReport = New TextBox()
        lblNSSF = New TextBox()
        lblNetPayReport = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(126, 89)
        Label1.Name = "Label1"
        Label1.Size = New Size(58, 15)
        Label1.TabIndex = 0
        Label1.Text = "Gross Pay"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(126, 146)
        Label2.Name = "Label2"
        Label2.Size = New Size(105, 15)
        Label2.TabIndex = 1
        Label2.Text = "NSSF Contribution"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(126, 198)
        Label3.Name = "Label3"
        Label3.Size = New Size(48, 15)
        Label3.TabIndex = 2
        Label3.Text = "Net Pay"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(381, 28)
        Label4.Name = "Label4"
        Label4.Size = New Size(70, 15)
        Label4.TabIndex = 3
        Label4.Text = "ReportForm"
        ' 
        ' btnBack
        ' 
        btnBack.Location = New Point(371, 263)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(100, 41)
        btnBack.TabIndex = 4
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' lblGrossPayReport
        ' 
        lblGrossPayReport.Location = New Point(262, 89)
        lblGrossPayReport.Name = "lblGrossPayReport"
        lblGrossPayReport.Size = New Size(418, 23)
        lblGrossPayReport.TabIndex = 5
        ' 
        ' lblNSSF
        ' 
        lblNSSF.Location = New Point(262, 143)
        lblNSSF.Name = "lblNSSF"
        lblNSSF.Size = New Size(418, 23)
        lblNSSF.TabIndex = 6
        ' 
        ' lblNetPayReport
        ' 
        lblNetPayReport.Location = New Point(262, 195)
        lblNetPayReport.Name = "lblNetPayReport"
        lblNetPayReport.Size = New Size(418, 23)
        lblNetPayReport.TabIndex = 7
        ' 
        ' reportform
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblNetPayReport)
        Controls.Add(lblNSSF)
        Controls.Add(lblGrossPayReport)
        Controls.Add(btnBack)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "reportform"
        Text = "ReportForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents lblGrossPayReport As TextBox
    Friend WithEvents lblNSSF As TextBox
    Friend WithEvents lblNetPayReport As TextBox
End Class
