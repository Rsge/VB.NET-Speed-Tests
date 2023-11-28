﻿Imports System.Text

''' <summary>
''' Provides selection for the test to run and to run it.
''' </summary>
Public Class MainForm
    ''' <summary>
    ''' Decimals to round the taken time to.
    ''' </summary>
    Private Const _decimals As Integer = 4

    ''' <summary>
    ''' On loading main form, populates dropdown w/ available tests.
    ''' </summary>
    ''' <param name="sender">Event sender.</param>
    ''' <param name="e">Triggering event.</param>
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Find & list all implemented tests.
        Dim type As Type = GetType(ITest)
        Dim subs As String() = AppDomain.CurrentDomain.GetAssemblies().
            SelectMany(Function(x) x.GetTypes()).
            Where(Function(x) type.IsAssignableFrom(x) And x IsNot type).
            Select(Function(x) x.Name).ToArray
        ' Populate dropdown.
        TestsList.Items.AddRange(subs)
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
        Dim selectedType As Type = Type.GetType(String.Join(".", [GetType].Namespace, TestsList.SelectedItem))
        Dim selectedTest As ITest = CType(Activator.CreateInstance(selectedType), ITest)
        ' Calculate results.
        Dim results As Dictionary(Of String, Double) = selectedTest.Test(iterations)
        Dim min As Double = results.Values.Min()
        Dim minKey As String = String.Empty
        ' Create output message.
        Dim resultOutputBuilder As New StringBuilder
        resultOutputBuilder.AppendLine(TestsList.SelectedItem.ToString()).AppendLine()
        For Each key As String In results.Keys
            resultOutputBuilder.Append(key).Append(":"c).Append(ControlChars.Tab).Append(Math.Round(results(key), _decimals)).
                AppendLine(My.Resources.TimeUnit)
            If results(key).Equals(min) Then
                minKey = key
            End If
        Next
        resultOutputBuilder.AppendLine().
            Append(My.Resources.FastestMethodLabel & Space(1)).Append(minKey)
        MessageBox.Show(resultOutputBuilder.ToString)
    End Sub
End Class
