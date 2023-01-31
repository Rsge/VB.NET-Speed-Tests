''' <summary>
''' Tests different ways of formatting a string, i.e. inserting strings into defined positions of another string.
''' </summary>
Public Class StringFormatTest
    Implements ITest

    ' String constants
    ''' <summary>
    ''' Labels of tested action's methods in order of running them in code.
    ''' </summary>
    Private Shared ReadOnly _methodLabels As String() = {
        "Using $""""",
        "Using String.Format"
    }
    ''' <summary>
    ''' String to test the methods with.
    ''' </summary>
    Private Shared ReadOnly _insertString As String = "Meow"


    ''' <summary>
    ''' Runs tests with different methods of approaching a problem, measuring the time they take.
    ''' </summary>
    ''' <param name="iterations">How many times each testing action should be run.</param>
    ''' <returns><see cref="Dictionary(Of String, Double)"/> with labels for the tested methods as <see cref="String"/> as key and the times they took as <see cref="Double"/> as value.</returns>
    Public Function Test(iterations As Long) As Dictionary(Of String, Double) Implements ITest.Test
        ' Basic variables
        Dim i As Long
        Dim testString As String
        Dim startTimes As New List(Of Date)
        Dim endTimes As New List(Of Date)
        Dim results As New Dictionary(Of String, Double)

        ' Test $"".
        startTimes.Add(Date.Now)
        For i = 1 To iterations
            testString = $"Test{_insertString}Example{_insertString}Test{_insertString}Example{_insertString}Test"
        Next
        endTimes.Add(Date.Now)

        ' Test String.Format.
        testString = "Test{0}Example{1}Test{2}Example{3}Test" ' I know this can be done with just 0s, that's not the point though =P
        startTimes.Add(Date.Now)
        For i = 1 To iterations
            testString = String.Format(testString, _insertString, _insertString, _insertString, _insertString)
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
