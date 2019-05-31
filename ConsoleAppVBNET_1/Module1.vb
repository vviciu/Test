Module Module1

    Sub Main()
        Dim name As String = "Tomasz Witkowski"

        Console.WriteLine("My name is Thomas")
        Console.WriteLine("This is branch 1")
        Console.WriteLine(Signature(name))
        Console.ReadKey()

    End Sub

    Function Signature(ByVal name) As String
        Signature = "My name is:" & name
    End Function


End Module
