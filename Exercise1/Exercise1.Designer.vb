<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Exercise1
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
        Me.lblHello = New System.Windows.Forms.Label()
        Me.btnHello = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblHello
        '
        Me.lblHello.AutoSize = True
        Me.lblHello.Font = New System.Drawing.Font("Segoe Script", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHello.Location = New System.Drawing.Point(92, 92)
        Me.lblHello.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblHello.Name = "lblHello"
        Me.lblHello.Size = New System.Drawing.Size(180, 80)
        Me.lblHello.TabIndex = 0
        Me.lblHello.Text = "Hello!"
        Me.lblHello.Visible = False
        '
        'btnHello
        '
        Me.btnHello.BackColor = System.Drawing.Color.Teal
        Me.btnHello.FlatAppearance.BorderSize = 0
        Me.btnHello.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHello.Font = New System.Drawing.Font("Segoe UI Semibold", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHello.ForeColor = System.Drawing.Color.White
        Me.btnHello.Location = New System.Drawing.Point(142, 207)
        Me.btnHello.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnHello.Name = "btnHello"
        Me.btnHello.Size = New System.Drawing.Size(86, 32)
        Me.btnHello.TabIndex = 1
        Me.btnHello.Text = "Say Hi!"
        Me.btnHello.UseVisualStyleBackColor = False
        '
        'Exercise1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(418, 343)
        Me.Controls.Add(Me.btnHello)
        Me.Controls.Add(Me.lblHello)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Exercise1"
        Me.Text = "Visbility Exercise"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHello As Label
    Friend WithEvents btnHello As Button
End Class
