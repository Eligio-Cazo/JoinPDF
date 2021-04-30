Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Module Module1

    Sub Main(ByVal args As String())
        ' Join up to 50 pfd files
        Dim m
        Dim A$(51)
        m = 0
        If args.Length = 0 Then
            System.Console.WriteLine("Please enter filename_1 filename_2 .... filename_N mergedfilename (fullpaths)")
            Console.Read()
        Else

            For i As Integer = 0 To args.Length - 1
                A$(i + 1) = args(i)
                m = m + 1
            Next

        End If

        Dim Lista As New List(Of String)
        Dim pd$(51)

        For i = 1 To m
            pd$(i) = A$(i)
        Next i

        For i = 1 To m - 1
            Lista.Add(pd$(i))
        Next i

        Dim sFileJoin As String = A$(m)

        Dim Doc As New Document()

        Try
            Dim fs As New FileStream(sFileJoin, FileMode.Create, FileAccess.Write, FileShare.None)
            Dim copy As New PdfCopy(Doc, fs)
            Doc.Open()
            Dim Rd As PdfReader
            Dim n As Integer

            For Each file In Lista

                Rd = New PdfReader(file)
                n = Rd.NumberOfPages
                Dim page As Integer = 0

                Do While page < n
                    page += 1
                    copy.AddPage(copy.GetImportedPage(Rd, page))
                Loop

                copy.FreeReader(Rd)
                Rd.Close()

            Next

        Catch ex As Exception

            MsgBox(ex.Message, vbExclamation, "Error in merge pdfs")

        Finally

            Doc.Close()

        End Try

    End Sub

End Module
