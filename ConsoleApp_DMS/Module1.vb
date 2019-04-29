Module Module1



    Sub Main()

        aTimer.AutoReset = True
        aTimer.Interval = 100
        AddHandler aTimer.Elapsed, AddressOf tick
        aTimer.Start()
        'Console.WriteLine(Math.Pow(2, 25))
        Console.ReadKey()
    End Sub

    Dim aTimer As New System.Timers.Timer
    Dim intTmp As Integer = 0

    Private Sub tick(ByVal sender As Object, ByVal e As System.Timers.ElapsedEventArgs)

        Dim dms As New DMS_Transform
        dms.Resolution = Math.Pow(2, 25)
        dms.Position = intTmp
        Console.WriteLine(dms.Degree & Chr(176) & dms.Minute & Chr(34) & dms.Second & Chr(39))

        intTmp += 1

    End Sub

End Module
