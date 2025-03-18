Module MainModule

    Sub Main()
        'DoSomethingInMainModule()
        'DoSomethingInSecondModule()
        ' MsgBox(ExampleClass.SumOf(4, 3))
        Dim jimmy As New Animal
        Dim bob As New Mammal
        Dim lucky As New Dog
        Dim pepe As New Dog
        Dim nemo As New Fish


        'jimmy.move()
        'Console.WriteLine(jimmy.skinType)
        'bob.move()
        'Console.WriteLine(bob.skinType)

        pepe.movement = "shiver"
        pepe.skinType = "hairless rat"
        pepe.vocalization = "yip yip"
        pepe.speak()
        pepe.move()

        lucky.speak()
        lucky.move()

        nemo.speak()

    End Sub

    ''' <summary>
    ''' show a message box from within the main module
    ''' </summary>
    Sub DoSomethingInMainModule()
        MsgBox("Hello from the MainModule!")
    End Sub

End Module
