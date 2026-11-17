Imports DocumentFormat.OpenXml.Packaging
Imports DocumentFormat.OpenXml.Validation

Public Class Form1
    Public Sub ValidateDOCX(ByVal filepath As String)
        Try
            Using docx As WordprocessingDocument = WordprocessingDocument.Open(filepath, True)
                Try
                    Dim validator As New OpenXmlValidator()
                    Dim count As Integer = 0
                    For Each [error] As ValidationErrorInfo In validator.Validate(docx)
                        count += 1
                        RichTextBox1.AppendText("Error " & count & vbCrLf)
                        RichTextBox1.AppendText("Description: " & [error].Description & vbCrLf)
                        RichTextBox1.AppendText("ErrorType: " & [error].ErrorType & vbCrLf)
                        RichTextBox1.AppendText("Node: " & [error].Node.ToString() & vbCrLf)
                        RichTextBox1.AppendText("Path: " & [error].Path.XPath & vbCrLf)
                        RichTextBox1.AppendText("Part: " & [error].Part.Uri.ToString() & vbCrLf)
                        RichTextBox1.AppendText("-------------------------------------------" & vbCrLf)
                    Next
                    RichTextBox1.AppendText("count=" & count & vbCrLf)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub ValidatePPTX(ByVal filepath As String)
        Try
            Using pptx As PresentationDocument = PresentationDocument.Open(filepath, True)
                Try
                    Dim validator As New OpenXmlValidator()
                    Dim count As Integer = 0
                    For Each [error] As ValidationErrorInfo In validator.Validate(pptx)
                        count += 1
                        RichTextBox1.AppendText("Error " & count & vbCrLf)
                        RichTextBox1.AppendText("Description: " & [error].Description & vbCrLf)
                        RichTextBox1.AppendText("ErrorType: " & [error].ErrorType & vbCrLf)
                        RichTextBox1.AppendText("Node: " & [error].Node.ToString() & vbCrLf)
                        RichTextBox1.AppendText("Path: " & [error].Path.XPath & vbCrLf)
                        RichTextBox1.AppendText("Part: " & [error].Part.Uri.ToString() & vbCrLf)
                        RichTextBox1.AppendText("-------------------------------------------" & vbCrLf)
                    Next
                    RichTextBox1.AppendText("count=" & count & vbCrLf)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub ValidateXLSX(ByVal filepath As String)
        Try
            Using xlsx As SpreadsheetDocument = SpreadsheetDocument.Open(filepath, True)
                Try
                    Dim validator As New OpenXmlValidator()
                    Dim count As Integer = 0
                    For Each [error] As ValidationErrorInfo In validator.Validate(xlsx)
                        count += 1
                        RichTextBox1.AppendText("Error " & count & vbCrLf)
                        RichTextBox1.AppendText("Description: " & [error].Description & vbCrLf)
                        RichTextBox1.AppendText("ErrorType: " & [error].ErrorType & vbCrLf)
                        RichTextBox1.AppendText("Node: " & [error].Node.ToString() & vbCrLf)
                        RichTextBox1.AppendText("Path: " & [error].Path.XPath & vbCrLf)
                        RichTextBox1.AppendText("Part: " & [error].Part.Uri.ToString() & vbCrLf)
                        RichTextBox1.AppendText("-------------------------------------------" & vbCrLf)
                    Next
                    RichTextBox1.AppendText("count=" & count & vbCrLf)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        RichTextBox1.Clear()
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            ValidateDOCX(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        RichTextBox1.Clear()
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            ValidatePPTX(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        RichTextBox1.Clear()
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            ValidateXLSX(OpenFileDialog1.FileName)
        End If
    End Sub
End Class
