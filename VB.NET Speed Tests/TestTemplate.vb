﻿'''' <summary>
'''' Tests different ways of 
'''' </summary>
'Public Class ExampleTest
'    Implements ITest

'    ' String constants.
'    ''' <summary>
'    ''' Labels of tested action's methods in order of running them in code.
'    ''' </summary>
'    Private Shared ReadOnly _methods As String() = {
'        "''",
'        "''",
'        "''",
'        "''"
'    }
'    ''' <summary>
'    ''' String to test the methods with.
'    ''' </summary>
'    Private Shared ReadOnly _testString As String = "TestExampleTestExampleTest"


'    ''' <summary>
'    ''' Runs tests with different methods of approaching a problem, measuring the time they take.
'    ''' </summary>
'    ''' <param name="iterations">How many times each testing action should be run.</param>
'    ''' <returns><see cref="Dictionary(Of String, Double)"/> with labels for the tested methods as <see cref="String"/> as key and the times they took as <see cref="Double"/> as value.</returns>
'    Public Function Test(iterations As Long) As Dictionary(Of String, Double) Implements ITest.Test
'        ' Basic variables
'        Dim i As Long
'        Dim testBool As Boolean
'        Dim startTimes As New List(Of Date)
'        Dim endTimes As New List(Of Date)
'        Dim results As New Dictionary(Of String, Double)

'        ' Test ''.
'        startTimes.Add(Date.Now)
'        For i = 1 To iterations
'            testBool = 
'        Next
'        endTimes.Add(Date.Now)

'        ' Test ''.
'        startTimes.Add(Date.Now)
'        For i = 1 To iterations
'            testBool = 
'        Next
'        endTimes.Add(Date.Now)

'        ' Test ''.
'        startTimes.Add(Date.Now)
'        For i = 1 To iterations
'            testBool = 
'        Next
'        endTimes.Add(Date.Now)

'        ' Test ''.
'        startTimes.Add(Date.Now)
'        For i = 1 To iterations
'            testBool = 
'        Next
'        endTimes.Add(Date.Now)


'        ' Get results.
'        Dim j As Integer
'        Dim diff As TimeSpan
'        For j = 0 To _methods.Length - 1
'            diff = endTimes(j) - startTimes(j)
'            results.Add(My.Resources.LabelMethod & " " & _methods(j), diff.TotalSeconds)
'        Next
'        Return results
'    End Function
'End Class
