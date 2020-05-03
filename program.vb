Imports System

Module Program

    Function ascii(ByVal x As String, ByVal y As Integer, ByVal z As Boolean) As String
        Dim hasil As String = ""

        'initialize (x+n) mod 26
        For Each c As Char In x
            Dim a As Integer
            If z Then
                a = Asc(c) + y
            Else
                a = Asc(c) + 26 - y
            End If

            'check the ascii encoding 
            'if greater than z subctract by 26 back to beginning
            If Char.IsLower(c) Then
                If a > Asc("z") Then
                    a -= 26
                End If
                hasil += Chr(a)
            ElseIf Char.IsUpper(c) Then
                If a > Asc("z") Then
                    a -= 26
                End If
                hasil += Chr(a)
            Else
                hasil += Chr(a)
            End If
        Next
        Return hasil
    End Function

    Sub Main(args As String())
        Dim text As String
        Dim offset As Integer
        Dim hasil As String
        Dim input As String
start:
        Console.WriteLine("---------------------Sandi Geser---------------------")
        Console.WriteLine("1. Enkripsi")
        Console.WriteLine("2. Dekripsi")
        Console.WriteLine("3. Tutup")
        Console.WriteLine()
        Console.Write("input : ")
        input = Console.ReadLine()

        Do


            Select Case input
                Case "1"
                    Console.WriteLine("massukkan text")
                    text = Console.ReadLine()
                    Console.WriteLine("massukkan offset")
                    offset = Console.ReadLine()

                    If offset <> 0 Then

                        Try
                            hasil = ascii(text, offset, True)
                            Console.WriteLine("chipper :" + hasil)
                        Catch ex As InvalidCastException
                            Console.WriteLine(ex)
                            Console.ReadLine()
                            GoTo start
                        End Try

                        Console.ReadLine()
                        Console.Clear()
                        GoTo start
                    Else
                        Console.WriteLine("input invalid")
                        Console.ReadLine()
                        Console.Clear()
                        GoTo start
                    End If

                Case "2"
                    Console.WriteLine("massukkan text")
                    text = Console.ReadLine()
                    Console.WriteLine("massukkan offset")
                    offset = Console.ReadLine()

                    If offset <> 0 Then

                        Try
                            hasil = ascii(text, offset, False)
                            Console.WriteLine("plaintext :" + hasil)
                        Catch ex As InvalidCastException
                            Console.WriteLine(ex)
                            Console.ReadLine()
                            GoTo start
                        End Try


                        Console.ReadLine()
                        Console.Clear()
                        GoTo start
                    Else
                        Console.WriteLine("input invalid")
                        Console.ReadLine()
                        Console.Clear()
                        GoTo start
                    End If

                Case "3"
                    Exit Do
                Case Else
                    Console.WriteLine("input invalid")
                    Console.ReadLine()
                    Console.Clear()
                    GoTo start
            End Select
        Loop

        Console.WriteLine()
        Console.WriteLine("Tekan enter untuk keluar")
        Console.Read()
    End Sub
End Module
