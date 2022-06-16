Public Class StringEmptyTest
    Implements ITest

    'String constants
    Private Shared ReadOnly _methodLabels As String() = {
        "Using '= """"'",
        "Using '= vbNullString'",
        "Using '= String.Empty'",
        "Using '.Length = 0'"
    }
    Private Shared ReadOnly testString As String = "TestExampleTestExampleTest"


    Public Function Test(iterations As Long) As Dictionary(Of String, Double) Implements ITest.Test
        'Basic variables
        Dim i As Long
        Dim testBool As Boolean
        Dim startTimes As New List(Of Date)
        Dim endTimes As New List(Of Date)
        Dim results As New Dictionary(Of String, Double)

        'Testing '= ""'
        startTimes.Add(Date.Now)
        For i = 1 To iterations
            testBool = testString = ""
        Next
        endTimes.Add(Date.Now)

        'Testing '= vbNullString'
        startTimes.Add(Date.Now)
        For i = 1 To iterations
            testBool = testString = vbNullString
        Next
        endTimes.Add(Date.Now)

        'Testing '= String.Empty'
        startTimes.Add(Date.Now)
        For i = 1 To iterations
            testBool = testString = String.Empty
        Next
        endTimes.Add(Date.Now)

        'Testing '.Length = 0'
        startTimes.Add(Date.Now)
        For i = 1 To iterations
            testBool = testString.Length = 0
        Next
        endTimes.Add(Date.Now)


        'Getting results
        Dim diff As TimeSpan
        For i = 0 To _methodLabels.Length - 1
            diff = endTimes(i) - startTimes(i)
            results.Add(_methodLabels(i), diff.TotalSeconds)
        Next
        Return results
    End Function
End Class
