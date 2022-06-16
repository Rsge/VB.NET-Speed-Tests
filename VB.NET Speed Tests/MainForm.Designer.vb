<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.StartButton = New System.Windows.Forms.Button()
        Me.TestsList = New System.Windows.Forms.ComboBox()
        Me.TestsLabel = New System.Windows.Forms.Label()
        Me.IterationsLabel = New System.Windows.Forms.Label()
        Me.IterationPotencyCount = New System.Windows.Forms.NumericUpDown()
        Me.IterationsPowerLabel = New System.Windows.Forms.Label()
        CType(Me.IterationPotencyCount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StartButton
        '
        Me.StartButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StartButton.Location = New System.Drawing.Point(12, 104)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Size = New System.Drawing.Size(164, 43)
        Me.StartButton.TabIndex = 2
        Me.StartButton.Text = "Start Test"
        Me.StartButton.UseVisualStyleBackColor = True
        '
        'TestsList
        '
        Me.TestsList.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TestsList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TestsList.FormattingEnabled = True
        Me.TestsList.Location = New System.Drawing.Point(12, 31)
        Me.TestsList.Name = "TestsList"
        Me.TestsList.Size = New System.Drawing.Size(164, 23)
        Me.TestsList.TabIndex = 0
        '
        'TestsLabel
        '
        Me.TestsLabel.AutoSize = True
        Me.TestsLabel.Location = New System.Drawing.Point(13, 13)
        Me.TestsLabel.Name = "TestsLabel"
        Me.TestsLabel.Size = New System.Drawing.Size(27, 15)
        Me.TestsLabel.TabIndex = 3
        Me.TestsLabel.Text = "Test"
        '
        'IterationsLabel
        '
        Me.IterationsLabel.AutoSize = True
        Me.IterationsLabel.Location = New System.Drawing.Point(12, 57)
        Me.IterationsLabel.Name = "IterationsLabel"
        Me.IterationsLabel.Size = New System.Drawing.Size(56, 15)
        Me.IterationsLabel.TabIndex = 4
        Me.IterationsLabel.Text = "Iterations"
        '
        'IterationPotencyCount
        '
        Me.IterationPotencyCount.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IterationPotencyCount.Location = New System.Drawing.Point(49, 75)
        Me.IterationPotencyCount.Maximum = New Decimal(New Integer() {18, 0, 0, 0})
        Me.IterationPotencyCount.Name = "IterationPotencyCount"
        Me.IterationPotencyCount.Size = New System.Drawing.Size(127, 23)
        Me.IterationPotencyCount.TabIndex = 1
        Me.IterationPotencyCount.ThousandsSeparator = True
        Me.IterationPotencyCount.Value = New Decimal(New Integer() {8, 0, 0, 0})
        '
        'IterationsPowerLabel
        '
        Me.IterationsPowerLabel.AutoSize = True
        Me.IterationsPowerLabel.Location = New System.Drawing.Point(13, 77)
        Me.IterationsPowerLabel.Name = "IterationsPowerLabel"
        Me.IterationsPowerLabel.Size = New System.Drawing.Size(30, 15)
        Me.IterationsPowerLabel.TabIndex = 6
        Me.IterationsPowerLabel.Text = "10 ^"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(188, 159)
        Me.Controls.Add(Me.IterationsPowerLabel)
        Me.Controls.Add(Me.IterationPotencyCount)
        Me.Controls.Add(Me.IterationsLabel)
        Me.Controls.Add(Me.TestsLabel)
        Me.Controls.Add(Me.TestsList)
        Me.Controls.Add(Me.StartButton)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(136, 180)
        Me.Name = "MainForm"
        Me.Text = "Speed Tests"
        CType(Me.IterationPotencyCount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StartButton As Button
    Friend WithEvents TestsList As ComboBox
    Friend WithEvents TestsLabel As Label
    Friend WithEvents IterationsLabel As Label
    Friend WithEvents IterationPotencyCount As NumericUpDown
    Friend WithEvents IterationsPowerLabel As Label
End Class
