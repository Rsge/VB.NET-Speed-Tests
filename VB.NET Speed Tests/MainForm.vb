Imports System.Text

''' <summary>
''' Provides selection for the test to run and to run it.
''' </summary>
Public Class MainForm
    ''' <summary>
    ''' Decimals to round the taken time to.
    ''' </summary>
    Private Const _decimals As Integer = 4
    ''' <summary>
    ''' Dictionary of tests and their descriptions.
    ''' </summary>
    Private _testDict As Dictionary(Of String, String)

    ''' <summary>
    ''' On loading main form, populates dropdown w/ available tests.
    ''' </summary>
    ''' <param name="sender">Event sender.</param>
    ''' <param name="e">Triggering event.</param>
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Find & list all implemented tests.
        Dim baseType As Type = GetType(ITest)
        Dim tests As IEnumerable(Of String) = From assembly In AppDomain.CurrentDomain.GetAssemblies()
                                              From aType In assembly.GetTypes()
                                              Where baseType.IsAssignableFrom(aType) AndAlso aType IsNot baseType
                                              Select aType.Name
        _testDict = tests.ToDictionary(Function(key) key,
                                       Function(key) Convert.ToString( ' Nothing -> ""
                                       If(My.Resources.ResourceManager.GetObject(My.Resources.LabelResourceDesc & key), key))) ' No resource -> Use key.
        ' Populate dropdown.
        TestsList.Items.AddRange(_testDict.Values.ToArray())
        TestsList.SelectedIndex = 0
    End Sub

    ''' <summary>
    ''' On clicking the start button, runs the appropriate test with specified number of runs.
    ''' </summary>
    ''' <param name="sender">Event sender.</param>
    ''' <param name="e">Triggering event.</param>
    Private Sub StartButton_Click(sender As Object, e As EventArgs) Handles StartButton.Click
        ' Get selected iteration count and test type.
        Dim iterations As Long = CLng(Math.Pow(10, IterationPotencyCount.Value))
        Dim selectedType As Type = Type.GetType([GetType].Namespace & "." & _testDict.Keys(TestsList.SelectedIndex))
        Dim selectedTest As ITest = CType(Activator.CreateInstance(selectedType), ITest)
        ' Calculate results.
        Dim results As Dictionary(Of String, Double) = selectedTest.Test(iterations)
        Dim min As Double = results.Values.Min()
        Dim minKey As String = String.Empty
        ' Create output message.
        Dim resultOutputBuilder As New StringBuilder
        resultOutputBuilder.AppendLine(TestsList.SelectedItem.ToString()).
            AppendLine()
        For Each key As String In results.Keys
            resultOutputBuilder.Append(key).Append(":"c).Append(ControlChars.Tab).
                Append(Math.Round(results(key), _decimals)).AppendLine(My.Resources.UnitTime)
            If results(key).Equals(min) Then
                minKey = key
            End If
        Next
        resultOutputBuilder.AppendLine().
            Append(My.Resources.LabelFastestMethod & Space(1)).Append(minKey)
        MessageBox.Show(resultOutputBuilder.ToString)
    End Sub
End Class
