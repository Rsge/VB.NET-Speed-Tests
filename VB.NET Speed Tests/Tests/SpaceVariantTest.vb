''' <summary>
''' Tests different ways of creating a string with a space.
''' </summary>
Public Class SpaceVariantTest
    Implements ITest

    ' String constants.
    ''' <summary>
    ''' Labels of tested action's methods in order of running them in code.
    ''' </summary>
    Private Shared ReadOnly _methods As String() = {
        "'"" ""'",
        "'"" ""c'",
        "Space(1)",
        My.Resources.ArticleUndefined & " Const"
    }
    ''' <summary>
    ''' String to test the methods with.
    ''' </summary>
    Private Shared ReadOnly _testStringBase As String = "Test"
    Private Const _space As String = " "


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

        ' Test '" "'.
        startTimes.Add(Date.Now)
        For i = 1 To iterations
            testString = _testStringBase & " "
        Next
        endTimes.Add(Date.Now)

        ' Test '" "c'.
        startTimes.Add(Date.Now)
        For i = 1 To iterations
            testString = _testStringBase & " "c
        Next
        endTimes.Add(Date.Now)

        ' Test Space(1).
        startTimes.Add(Date.Now)
        For i = 1 To iterations
            testString = _testStringBase & Space(1)
        Next
        endTimes.Add(Date.Now)

        ' Test a Const.
        startTimes.Add(Date.Now)
        For i = 1 To iterations
            testString = _testStringBase & _space
        Next
        endTimes.Add(Date.Now)


        ' Get results.
        Dim j As Integer
        Dim diff As TimeSpan
        For j = 0 To _methods.Length - 1
            diff = endTimes(j) - startTimes(j)
            results.Add(My.Resources.LabelMethod & " " & _methods(j), diff.TotalSeconds)
        Next
        Return results
    End Function
End Class
