<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Exercise5
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
        Me.lstOut = New System.Windows.Forms.ListBox()
        Me.lblDesc = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstOut
        '
        Me.lstOut.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstOut.FormattingEnabled = True
        Me.lstOut.ItemHeight = 45
        Me.lstOut.Location = New System.Drawing.Point(101, 405)
        Me.lstOut.Name = "lstOut"
        Me.lstOut.Size = New System.Drawing.Size(636, 229)
        Me.lstOut.TabIndex = 8
        '
        'lblDesc
        '
        Me.lblDesc.AutoSize = True
        Me.lblDesc.Font = New System.Drawing.Font("Segoe UI", 13.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesc.Location = New System.Drawing.Point(191, 90)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(446, 50)
        Me.lblDesc.TabIndex = 7
        Me.lblDesc.Text = "Working with Structures"
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.Color.DeepPink
        Me.btnStart.FlatAppearance.BorderSize = 0
        Me.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStart.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnStart.Location = New System.Drawing.Point(219, 216)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(380, 90)
        Me.btnStart.TabIndex = 6
        Me.btnStart.Text = "Display Data"
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'Exercise5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(829, 722)
        Me.Controls.Add(Me.lstOut)
        Me.Controls.Add(Me.lblDesc)
        Me.Controls.Add(Me.btnStart)
        Me.Name = "Exercise5"
        Me.Text = "Exercise 5"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstOut As ListBox
    Friend WithEvents lblDesc As Label
    Friend WithEvents btnStart As Button
End Class
