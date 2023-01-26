Public Class AssignEmptyStringTest
    Implements ITest

    ' String constants
    ''' <summary>
    ''' Labels of tested action's methods in order of running them in code.
    ''' </summary>
    Private Shared ReadOnly _methodLabels As String() = {
        "Using '""""'",
        "Using 'vbNullString'",
        "Using 'String.Empty'"
    }

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


        ' Test '""'.
        startTimes.Add(Date.Now)
        For i = 1 To iterations
            testString = ""
        Next
        endTimes.Add(Date.Now)

        ' Test 'vbNullString'.
        startTimes.Add(Date.Now)
        For i = 1 To iterations
            testString = vbNullString
        Next
        endTimes.Add(Date.Now)

        ' Test 'String.Empty'.
        startTimes.Add(Date.Now)
        For i = 1 To iterations
            testString = String.Empty
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
