Public Interface ITest
    ''' <summary>
    ''' Runs multiple tests with different approaches to a problem.
    ''' </summary>
    ''' <param name="iterations">Number of iterations to perform test.</param>
    ''' <returns><see cref="Dictionary(Of String, Double)"/> with tested method as key and resulting time as double.</returns>
    Function Test(iterations As Long) As Dictionary(Of String, Double)
End Interface
