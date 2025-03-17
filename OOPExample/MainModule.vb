Module MainModule

    Sub Main()
        'DoSomethingInMainModule()
        'DoSomethingInSecondModule()
        ' MsgBox(ExampleClass.SumOf(4, 3))
        Dim jimmy As New Animal
        Dim bob As New Animal
        jimmy.move()
        bob.move()


    End Sub

    ''' <summary>
    ''' show a message box from within the main module
    ''' </summary>
    Sub DoSomethingInMainModule()
        MsgBox("Hello from the MainModule!")
    End Sub

End Module
