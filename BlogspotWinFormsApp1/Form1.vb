Imports System.Net.Http
Imports System.Net.Http.Headers
Imports System.Text.RegularExpressions

Public Class Form1
    Private Async Sub Go_Button_Click(sender As Object, e As EventArgs) Handles Go_Button.Click
        Title_TextBox.Text = ""
        Desc_TextBox.Text = ""
        Try
            Using httpClient As New HttpClient()

                'httpClient.DefaultRequestHeaders.Authorization = New AuthenticationHeaderValue("Bearer", bearerToken)
                'Dim content As New StringContent(jsonRequestData, Encoding.UTF8, "application/json")

                Dim response As HttpResponseMessage = Await httpClient.GetAsync("https://hihihihi1221.blogspot.com/2023/10/2.html")

                If response.IsSuccessStatusCode Then
                    Dim responseBody As String = Await response.Content.ReadAsStringAsync()
                    GetContentJson(responseBody)
                Else
                    Console.WriteLine("Http Status Code : " & response.StatusCode)
                End If

            End Using

        Catch ex As Exception
            Debug.WriteLine(ex)

        End Try
    End Sub


    Public Sub GetContentJson(htmlContent)
        Dim pattern As String = "_WidgetManager\.(_SetDataContext)\(([\s\S]+?])\)"

        ' Find the match using the regular expression
        Dim match As Match = Regex.Match(htmlContent, pattern, RegexOptions.IgnoreCase)

        ' Check if a match is found
        If match.Success Then
            ' Extract the JSON data
            Dim jsonText As String = match.Groups(2).Value
            Debug.WriteLine(jsonText)
            jsonText = jsonText.Replace("\", "")
            Dim jsonData As Object = Newtonsoft.Json.JsonConvert.DeserializeObject(jsonText)
            For Each item In jsonData
                Debug.WriteLine(item)
                If item("name") = "view" Then
                    Dim view_title = item("data")("title").ToString()
                    Dim view_description = item("data")("description").ToString().Replace("xa0", "")
                    'view_description = view_description.Replace("0xa0", "")

                    Title_TextBox.Text = view_title
                    Desc_TextBox.Text = view_description
                End If

            Next

        Else
            ' No match found
            Debug.WriteLine("JSON data not found in the HTML content.")
        End If

    End Sub


End Class
