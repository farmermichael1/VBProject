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
        Me.rbInch = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbKilometer = New System.Windows.Forms.RadioButton()
        Me.rbMile = New System.Windows.Forms.RadioButton()
        Me.rbMeter = New System.Windows.Forms.RadioButton()
        Me.rbFeet = New System.Windows.Forms.RadioButton()
        Me.rbCentimeter = New System.Windows.Forms.RadioButton()
        Me.lbTitle = New System.Windows.Forms.Label()
        Me.lbResult = New System.Windows.Forms.Label()
        Me.lbSelect = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rbInch
        '
        Me.rbInch.AutoSize = True
        Me.rbInch.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold)
        Me.rbInch.Location = New System.Drawing.Point(6, 47)
        Me.rbInch.Name = "rbInch"
        Me.rbInch.Size = New System.Drawing.Size(206, 23)
        Me.rbInch.TabIndex = 0
        Me.rbInch.TabStop = True
        Me.rbInch.Text = "Inches To Centimeters"
        Me.rbInch.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbKilometer)
        Me.GroupBox1.Controls.Add(Me.rbMile)
        Me.GroupBox1.Controls.Add(Me.rbMeter)
        Me.GroupBox1.Controls.Add(Me.rbFeet)
        Me.GroupBox1.Controls.Add(Me.rbCentimeter)
        Me.GroupBox1.Controls.Add(Me.rbInch)
        Me.GroupBox1.Location = New System.Drawing.Point(272, 244)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(296, 344)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'rbKilometer
        '
        Me.rbKilometer.AutoSize = True
        Me.rbKilometer.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold)
        Me.rbKilometer.Location = New System.Drawing.Point(6, 288)
        Me.rbKilometer.Name = "rbKilometer"
        Me.rbKilometer.Size = New System.Drawing.Size(190, 23)
        Me.rbKilometer.TabIndex = 2
        Me.rbKilometer.TabStop = True
        Me.rbKilometer.Text = "Kilometers To Miles"
        Me.rbKilometer.UseVisualStyleBackColor = True
        '
        'rbMile
        '
        Me.rbMile.AutoSize = True
        Me.rbMile.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold)
        Me.rbMile.Location = New System.Drawing.Point(6, 240)
        Me.rbMile.Name = "rbMile"
        Me.rbMile.Size = New System.Drawing.Size(190, 23)
        Me.rbMile.TabIndex = 2
        Me.rbMile.TabStop = True
        Me.rbMile.Text = "Miles To Kilometers"
        Me.rbMile.UseVisualStyleBackColor = True
        '
        'rbMeter
        '
        Me.rbMeter.AutoSize = True
        Me.rbMeter.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold)
        Me.rbMeter.Location = New System.Drawing.Point(6, 187)
        Me.rbMeter.Name = "rbMeter"
        Me.rbMeter.Size = New System.Drawing.Size(145, 23)
        Me.rbMeter.TabIndex = 1
        Me.rbMeter.TabStop = True
        Me.rbMeter.Text = "Meters To Feet"
        Me.rbMeter.UseVisualStyleBackColor = True
        '
        'rbFeet
        '
        Me.rbFeet.AutoSize = True
        Me.rbFeet.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold)
        Me.rbFeet.Location = New System.Drawing.Point(6, 143)
        Me.rbFeet.Name = "rbFeet"
        Me.rbFeet.Size = New System.Drawing.Size(145, 23)
        Me.rbFeet.TabIndex = 1
        Me.rbFeet.TabStop = True
        Me.rbFeet.Text = "Feet To Meters"
        Me.rbFeet.UseVisualStyleBackColor = True
        '
        'rbCentimeter
        '
        Me.rbCentimeter.AutoSize = True
        Me.rbCentimeter.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold)
        Me.rbCentimeter.Location = New System.Drawing.Point(6, 95)
        Me.rbCentimeter.Name = "rbCentimeter"
        Me.rbCentimeter.Size = New System.Drawing.Size(206, 23)
        Me.rbCentimeter.TabIndex = 0
        Me.rbCentimeter.TabStop = True
        Me.rbCentimeter.Text = "Centimeters To Inches"
        Me.rbCentimeter.UseVisualStyleBackColor = True
        '
        'lbTitle
        '
        Me.lbTitle.AutoSize = True
        Me.lbTitle.Font = New System.Drawing.Font("Rockwell", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTitle.Location = New System.Drawing.Point(502, 64)
        Me.lbTitle.Name = "lbTitle"
        Me.lbTitle.Size = New System.Drawing.Size(338, 36)
        Me.lbTitle.TabIndex = 3
        Me.lbTitle.Text = "Conversion Calculator"
        '
        'lbResult
        '
        Me.lbResult.AutoSize = True
        Me.lbResult.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbResult.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lbResult.Location = New System.Drawing.Point(202, 615)
        Me.lbResult.Name = "lbResult"
        Me.lbResult.Size = New System.Drawing.Size(440, 19)
        Me.lbResult.TabIndex = 4
        Me.lbResult.Text = "This is this measurement converted to this another one"
        Me.lbResult.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbSelect
        '
        Me.lbSelect.AutoSize = True
        Me.lbSelect.Font = New System.Drawing.Font("Rockwell", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSelect.Location = New System.Drawing.Point(278, 183)
        Me.lbSelect.Name = "lbSelect"
        Me.lbSelect.Size = New System.Drawing.Size(308, 36)
        Me.lbSelect.TabIndex = 5
        Me.lbSelect.Text = "Select Measurement"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.VBProject.My.Resources.Resources.ruler
        Me.PictureBox1.Location = New System.Drawing.Point(-5, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(467, 145)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnCalculate.Location = New System.Drawing.Point(52, 607)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(103, 37)
        Me.btnCalculate.TabIndex = 7
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnClear.Location = New System.Drawing.Point(659, 607)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(107, 37)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(847, 740)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lbSelect)
        Me.Controls.Add(Me.lbResult)
        Me.Controls.Add(Me.lbTitle)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rbInch As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbMile As RadioButton
    Friend WithEvents rbFeet As RadioButton
    Friend WithEvents rbKilometer As RadioButton
    Friend WithEvents rbMeter As RadioButton
    Friend WithEvents rbCentimeter As RadioButton
    Friend WithEvents lbTitle As Label
    Friend WithEvents lbResult As Label
    Friend WithEvents lbSelect As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
End Class
