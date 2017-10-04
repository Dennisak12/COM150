<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.beforeSwapTxt = New System.Windows.Forms.TextBox()
        Me.afterSwapTxt = New System.Windows.Forms.TextBox()
        Me.swapBtn = New System.Windows.Forms.Button()
        Me.infoLbl = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'beforeSwapTxt
        '
        Me.beforeSwapTxt.Location = New System.Drawing.Point(110, 139)
        Me.beforeSwapTxt.Multiline = True
        Me.beforeSwapTxt.Name = "beforeSwapTxt"
        Me.beforeSwapTxt.Size = New System.Drawing.Size(146, 27)
        Me.beforeSwapTxt.TabIndex = 0
        '
        'afterSwapTxt
        '
        Me.afterSwapTxt.Location = New System.Drawing.Point(110, 242)
        Me.afterSwapTxt.Multiline = True
        Me.afterSwapTxt.Name = "afterSwapTxt"
        Me.afterSwapTxt.Size = New System.Drawing.Size(146, 27)
        Me.afterSwapTxt.TabIndex = 1
        '
        'swapBtn
        '
        Me.swapBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.swapBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.swapBtn.Location = New System.Drawing.Point(110, 190)
        Me.swapBtn.Name = "swapBtn"
        Me.swapBtn.Size = New System.Drawing.Size(146, 32)
        Me.swapBtn.TabIndex = 2
        Me.swapBtn.Text = "Swap"
        Me.swapBtn.UseVisualStyleBackColor = False
        '
        'infoLbl
        '
        Me.infoLbl.AutoSize = True
        Me.infoLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.infoLbl.Location = New System.Drawing.Point(82, 53)
        Me.infoLbl.Name = "infoLbl"
        Me.infoLbl.Size = New System.Drawing.Size(211, 20)
        Me.infoLbl.TabIndex = 5
        Me.infoLbl.Text = "Dennis Ak, Com150 HW1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Fuchsia
        Me.ClientSize = New System.Drawing.Size(376, 370)
        Me.Controls.Add(Me.infoLbl)
        Me.Controls.Add(Me.swapBtn)
        Me.Controls.Add(Me.afterSwapTxt)
        Me.Controls.Add(Me.beforeSwapTxt)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents beforeSwapTxt As TextBox
    Friend WithEvents afterSwapTxt As TextBox
    Friend WithEvents swapBtn As Button
    Friend WithEvents infoLbl As Label
End Class
