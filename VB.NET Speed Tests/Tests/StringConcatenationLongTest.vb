Imports System.Text

''' <summary>
''' Tests different ways of concatenating a large number of strings.
''' </summary>
Public Class StringConcatenationLongTest
    Implements ITest

    ' String constants
    ''' <summary>
    ''' Labels of tested action's methods in order of running them in code.
    ''' </summary>
    Private Shared ReadOnly _methodLabels As String() = {
        "Using 'x &= x'",
        "Using a StringBuilder"
    }
    ''' <summary>
    ''' String to test the methods with.
    ''' </summary>
    Private Shared ReadOnly _testString As String = "Test"
    ''' <summary>
    ''' Number of repeats adding the test string to the result
    ''' </summary>
    Private Const _repeats As Integer = 100


    ''' <summary>
    ''' Runs tests with different methods of approaching a problem, measuring the time they take.
    ''' </summary>
    ''' <param name="iterations">How many times each testing action should be run.</param>
    ''' <returns><see cref="Dictionary(Of String, Double)"/> with labels for the tested methods as <see cref="String"/> as key and the times they took as <see cref="Double"/> as value.</returns>
    Public Function Test(iterations As Long) As Dictionary(Of String, Double) Implements ITest.Test
        ' Basic variables
        Dim i As Long
        Dim j As Integer
        Dim testResultString As String = String.Empty
        Dim startTimes As New List(Of Date)
        Dim endTimes As New List(Of Date)
        Dim results As New Dictionary(Of String, Double)

        ' Test 'x &= x.'.
        startTimes.Add(Date.Now)
        For i = 1 To iterations
            For j = 1 To _repeats
                testResultString &= _testString
            Next
            testResultString = String.Empty
        Next
        endTimes.Add(Date.Now)

        ' Test StringBuilder.
        startTimes.Add(Date.Now)
        For i = 1 To iterations
            Dim testBuilder As New StringBuilder
            For j = 1 To _repeats
                testBuilder.Append(_testString)
            Next
            testResultString = testBuilder.ToString
        Next
        endTimes.Add(Date.Now)


        ' Get results.
        Dim diff As TimeSpan
        For i = 0 To _methodLabels.Length - 1
            diff = endTimes(i) - startTimes(i)
            results.Add(_methodLabels(i), diff.TotalSeconds)
        Next
        Return results
    End Function
End Class
