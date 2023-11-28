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
        StartButton = New Button()
        TestsList = New ComboBox()
        TestsLabel = New Label()
        IterationsLabel = New Label()
        IterationPotencyCount = New NumericUpDown()
        IterationsPowerLabel = New Label()
        CType(IterationPotencyCount, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' StartButton
        ' 
        resources.ApplyResources(StartButton, "StartButton")
        StartButton.Name = "StartButton"
        StartButton.UseVisualStyleBackColor = True
        ' 
        ' TestsList
        ' 
        resources.ApplyResources(TestsList, "TestsList")
        TestsList.DropDownStyle = ComboBoxStyle.DropDownList
        TestsList.FormattingEnabled = True
        TestsList.Name = "TestsList"
        ' 
        ' TestsLabel
        ' 
        resources.ApplyResources(TestsLabel, "TestsLabel")
        TestsLabel.Name = "TestsLabel"
        ' 
        ' IterationsLabel
        ' 
        resources.ApplyResources(IterationsLabel, "IterationsLabel")
        IterationsLabel.Name = "IterationsLabel"
        ' 
        ' IterationPotencyCount
        ' 
        resources.ApplyResources(IterationPotencyCount, "IterationPotencyCount")
        IterationPotencyCount.Maximum = New Decimal(New Integer() {18, 0, 0, 0})
        IterationPotencyCount.Name = "IterationPotencyCount"
        IterationPotencyCount.Value = New Decimal(New Integer() {8, 0, 0, 0})
        ' 
        ' IterationsPowerLabel
        ' 
        resources.ApplyResources(IterationsPowerLabel, "IterationsPowerLabel")
        IterationsPowerLabel.Name = "IterationsPowerLabel"
        ' 
        ' MainForm
        ' 
        resources.ApplyResources(Me, "$this")
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(IterationsPowerLabel)
        Controls.Add(IterationPotencyCount)
        Controls.Add(IterationsLabel)
        Controls.Add(TestsLabel)
        Controls.Add(TestsList)
        Controls.Add(StartButton)
        Name = "MainForm"
        CType(IterationPotencyCount, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents StartButton As Button
    Friend WithEvents TestsList As ComboBox
    Friend WithEvents TestsLabel As Label
    Friend WithEvents IterationsLabel As Label
    Friend WithEvents IterationPotencyCount As NumericUpDown
    Friend WithEvents IterationsPowerLabel As Label
End Class
