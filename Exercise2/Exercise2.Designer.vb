<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Exercise2
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
        Me.lblChooseSize = New System.Windows.Forms.Label()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.lstSelection = New System.Windows.Forms.ListBox()
        Me.grpSoda = New System.Windows.Forms.GroupBox()
        Me.radSmall = New System.Windows.Forms.RadioButton()
        Me.radMedium = New System.Windows.Forms.RadioButton()
        Me.radLarge = New System.Windows.Forms.RadioButton()
        Me.grpSoda.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblChooseSize
        '
        Me.lblChooseSize.AutoSize = True
        Me.lblChooseSize.Font = New System.Drawing.Font("Segoe UI", 13.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChooseSize.Location = New System.Drawing.Point(27, 37)
        Me.lblChooseSize.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblChooseSize.Name = "lblChooseSize"
        Me.lblChooseSize.Size = New System.Drawing.Size(182, 25)
        Me.lblChooseSize.TabIndex = 0
        Me.lblChooseSize.Text = "Choose a Soda Size"
        '
        'btnSelect
        '
        Me.btnSelect.BackColor = System.Drawing.Color.Gold
        Me.btnSelect.FlatAppearance.BorderSize = 0
        Me.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSelect.Font = New System.Drawing.Font("Segoe UI Semibold", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelect.Location = New System.Drawing.Point(32, 284)
        Me.btnSelect.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(104, 31)
        Me.btnSelect.TabIndex = 1
        Me.btnSelect.Text = "Selection"
        Me.btnSelect.UseVisualStyleBackColor = False
        '
        'lstSelection
        '
        Me.lstSelection.FormattingEnabled = True
        Me.lstSelection.Location = New System.Drawing.Point(230, 101)
        Me.lstSelection.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.lstSelection.Name = "lstSelection"
        Me.lstSelection.Size = New System.Drawing.Size(200, 173)
        Me.lstSelection.TabIndex = 2
        '
        'grpSoda
        '
        Me.grpSoda.Controls.Add(Me.radLarge)
        Me.grpSoda.Controls.Add(Me.radMedium)
        Me.grpSoda.Controls.Add(Me.radSmall)
        Me.grpSoda.Location = New System.Drawing.Point(32, 101)
        Me.grpSoda.Name = "grpSoda"
        Me.grpSoda.Size = New System.Drawing.Size(177, 173)
        Me.grpSoda.TabIndex = 3
        Me.grpSoda.TabStop = False
        Me.grpSoda.Text = "Soda"
        '
        'radSmall
        '
        Me.radSmall.AutoSize = True
        Me.radSmall.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radSmall.Location = New System.Drawing.Point(7, 34)
        Me.radSmall.Name = "radSmall"
        Me.radSmall.Size = New System.Drawing.Size(65, 20)
        Me.radSmall.TabIndex = 0
        Me.radSmall.TabStop = True
        Me.radSmall.Text = "Small"
        Me.radSmall.UseVisualStyleBackColor = True
        '
        'radMedium
        '
        Me.radMedium.AutoSize = True
        Me.radMedium.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radMedium.Location = New System.Drawing.Point(7, 58)
        Me.radMedium.Name = "radMedium"
        Me.radMedium.Size = New System.Drawing.Size(80, 20)
        Me.radMedium.TabIndex = 1
        Me.radMedium.TabStop = True
        Me.radMedium.Text = "Medium"
        Me.radMedium.UseVisualStyleBackColor = True
        '
        'radLarge
        '
        Me.radLarge.AutoSize = True
        Me.radLarge.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radLarge.Location = New System.Drawing.Point(7, 82)
        Me.radLarge.Name = "radLarge"
        Me.radLarge.Size = New System.Drawing.Size(66, 20)
        Me.radLarge.TabIndex = 2
        Me.radLarge.TabStop = True
        Me.radLarge.Text = "Large"
        Me.radLarge.UseVisualStyleBackColor = True
        '
        'Exercise2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(468, 364)
        Me.Controls.Add(Me.grpSoda)
        Me.Controls.Add(Me.lstSelection)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(Me.lblChooseSize)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Exercise2"
        Me.Text = "Working with GroupBoxes"
        Me.grpSoda.ResumeLayout(False)
        Me.grpSoda.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblChooseSize As Label
    Friend WithEvents btnSelect As Button
    Friend WithEvents lstSelection As ListBox
    Friend WithEvents grpSoda As GroupBox
    Friend WithEvents radLarge As RadioButton
    Friend WithEvents radMedium As RadioButton
    Friend WithEvents radSmall As RadioButton
End Class
