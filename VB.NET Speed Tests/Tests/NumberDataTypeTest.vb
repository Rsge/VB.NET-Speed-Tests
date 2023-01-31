''' <summary>
''' Tests different types of whole numbers in calculations.
''' </summary>
Public Class NumberDataTypeTest
    Implements ITest

    ' String constants
    ''' <summary>
    ''' Labels of tested action's methods in order of running them in code.
    ''' </summary>
    Private Shared ReadOnly _methodLabels As String() = {
        "Using a Byte",
        "Using a Short",
        "Using an Integer",
        "Using a Long"
    }


    ''' <summary>
    ''' Runs tests with different methods of approaching a problem, measuring the time they take.
    ''' </summary>
    ''' <param name="iterations">How many times each testing action should be run.</param>
    ''' <returns><see cref="Dictionary(Of String, Double)"/> with labels for the tested methods as <see cref="String"/> as key and the times they took as <see cref="Double"/> as value.</returns>
    Public Function Test(iterations As Long) As Dictionary(Of String, Double) Implements ITest.Test
        ' Basic variables
        Dim i As Long
        Dim startTimes As New List(Of Date)
        Dim endTimes As New List(Of Date)
        Dim results As New Dictionary(Of String, Double)

        ' Test Byte.
        startTimes.Add(Date.Now)
        For i = 1 To iterations
            Dim T1 As Byte = 10
            Dim T2 As Byte = 100
            Dim T3 As Byte = T1 + T2
        Next
        endTimes.Add(Date.Now)

        ' Test Short.
        startTimes.Add(Date.Now)
        For i = 1 To iterations
            Dim T1 As Short = 10
            Dim T2 As Short = 100
            Dim T3 As Short = T1 + T2
        Next
        endTimes.Add(Date.Now)

        ' Test Integer.
        startTimes.Add(Date.Now)
        For i = 1 To iterations
            Dim T1 As Integer = 10
            Dim T2 As Integer = 100
            Dim T3 As Integer = T1 + T2
        Next
        endTimes.Add(Date.Now)

        ' Test Long.
        startTimes.Add(Date.Now)
        For i = 1 To iterations
            Dim T1 As Long = 10
            Dim T2 As Long = 100
            Dim T3 As Long = T1 + T2
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
