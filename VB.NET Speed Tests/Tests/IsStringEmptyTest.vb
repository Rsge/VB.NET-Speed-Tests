''' <summary>
''' Tests different ways of determining if a string is empty.
''' </summary>
Public Class IsStringEmptyTest
    Implements ITest

    ' String constants
    ''' <summary>
    ''' Labels of tested action's methods in order of running them in code.
    ''' </summary>
    Private Shared ReadOnly _methodLabels As String() = {
        "Using '= """"'",
        "Using '= vbNullString'",
        "Using '= String.Empty'",
        "Using '.Length = 0'"
    }
    ''' <summary>
    ''' String to test the methods with.
    ''' </summary>
    Private Shared ReadOnly _testString As String = "TestExampleTestExampleTest"

    ''' <summary>
    ''' Runs tests with different methods of approaching a problem, measuring the time they take.
    ''' </summary>
    ''' <param name="iterations">How many times each testing action should be run.</param>
    ''' <returns><see cref="Dictionary(Of String, Double)"/> with labels for the tested methods as <see cref="String"/> as key and the times they took as <see cref="Double"/> as value.</returns>
    Public Function Test(iterations As Long) As Dictionary(Of String, Double) Implements ITest.Test
        ' Basic variables
        Dim i As Long
        Dim testBool As Boolean
        Dim startTimes As New List(Of Date)
        Dim endTimes As New List(Of Date)


        ' Test '= ""'.
        startTimes.Add(Date.Now)
        For i = 1 To iterations
            testBool = _testString = ""
        Next
        endTimes.Add(Date.Now)

        ' Test '= vbNullString'.
        startTimes.Add(Date.Now)
        For i = 1 To iterations
            testBool = _testString = vbNullString
        Next
        endTimes.Add(Date.Now)

        ' Test '= String.Empty'.
        startTimes.Add(Date.Now)
        For i = 1 To iterations
            testBool = _testString = String.Empty
        Next
        endTimes.Add(Date.Now)

        ' Test '.Length = 0'.
        startTimes.Add(Date.Now)
        For i = 1 To iterations
            testBool = _testString.Length = 0
        Next
        endTimes.Add(Date.Now)


        ' Get results.
        Dim j As Integer
        Dim diff As TimeSpan
        Dim results As New Dictionary(Of String, Double)
        For j = 0 To _methodLabels.Length - 1
            diff = endTimes(j) - startTimes(j)
            results.Add(_methodLabels(j), diff.TotalSeconds)
        Next
        Return results
    End Function
End Class
