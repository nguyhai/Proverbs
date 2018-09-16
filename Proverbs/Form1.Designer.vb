<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmProverbs
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAnswer = New System.Windows.Forms.TextBox()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.btnRecord = New System.Windows.Forms.Button()
        Me.txtCorrectAnswer = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(73, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "True (T) or False (F)"
        '
        'txtAnswer
        '
        Me.txtAnswer.Location = New System.Drawing.Point(179, 69)
        Me.txtAnswer.Name = "txtAnswer"
        Me.txtAnswer.Size = New System.Drawing.Size(45, 20)
        Me.txtAnswer.TabIndex = 1
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(21, 97)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(119, 23)
        Me.btnDisplay.TabIndex = 3
        Me.btnDisplay.Text = "Display Proverb"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'btnRecord
        '
        Me.btnRecord.Location = New System.Drawing.Point(167, 97)
        Me.btnRecord.Name = "btnRecord"
        Me.btnRecord.Size = New System.Drawing.Size(127, 23)
        Me.btnRecord.TabIndex = 4
        Me.btnRecord.Text = "Record Answer"
        Me.btnRecord.UseVisualStyleBackColor = True
        '
        'txtCorrectAnswer
        '
        Me.txtCorrectAnswer.Location = New System.Drawing.Point(21, 21)
        Me.txtCorrectAnswer.Name = "txtCorrectAnswer"
        Me.txtCorrectAnswer.ReadOnly = True
        Me.txtCorrectAnswer.Size = New System.Drawing.Size(287, 20)
        Me.txtCorrectAnswer.TabIndex = 5
        Me.txtCorrectAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frmProverbs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(320, 145)
        Me.Controls.Add(Me.txtCorrectAnswer)
        Me.Controls.Add(Me.btnRecord)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.txtAnswer)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmProverbs"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Proverbs"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtAnswer As TextBox
    Friend WithEvents btnDisplay As Button
    Friend WithEvents btnRecord As Button
    Friend WithEvents txtCorrectAnswer As TextBox
End Class
