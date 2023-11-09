﻿Imports System.Text

''' <summary>
''' Tests different ways of concatenating a small number of strings.
''' </summary>
Public Class StringConcatenationShortTest
    Implements ITest

    ' String constants
    ''' <summary>
    ''' Labels of tested action's methods in order of running them in code.
    ''' </summary>
    Private Shared ReadOnly _methodLabels As String() = {
        "Using 'x & x & ...'",
        "Using '$""""'",
        "Using String.Join",
        "Using a StringBuilder"
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
        Dim testResultString As String
        Dim startTimes As New List(Of Date)
        Dim endTimes As New List(Of Date)


        ' Test 'x & x & ...'.
        startTimes.Add(Date.Now)
        For i = 1 To iterations
            testResultString = _testString & _testString & _testString & _testString & _testString
        Next
        endTimes.Add(Date.Now)

        ' Test '$""'.
        startTimes.Add(Date.Now)
        For i = 1 To iterations
            testResultString = $"{_testString}{_testString}{_testString}{_testString}{_testString}"
        Next
        endTimes.Add(Date.Now)

        ' Test String.Join.
        startTimes.Add(Date.Now)
        For i = 1 To iterations
            testResultString = String.Join(String.Empty, _testString, _testString, _testString, _testString, _testString)
        Next
        endTimes.Add(Date.Now)

        ' Test StringBuilder.
        startTimes.Add(Date.Now)
        For i = 1 To iterations
            Dim testBuilder As New StringBuilder
            testBuilder.Append(_testString).Append(_testString).Append(_testString).Append(_testString).Append(_testString)
            testResultString = testBuilder.ToString
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
