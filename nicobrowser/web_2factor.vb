Imports Gecko

Public Class web_2factor

    Private Sub web_2factor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        fx_2factor.Navigate("https://account.nicovideo.jp/login")

        Do
            Application.DoEvents()
        Loop Until fx_2factor.IsBusy = False


        If fx_2factor.Document.Uri = "https://account.nicovideo.jp/login" Then
            Console.WriteLine("ログイン画面のはず " & fx_2factor.Url.ToString())

            With fx_2factor
                .Document.GetElementsByName（"mail_tel"）（0）.SetAttribute（"value", Setting.txtaddress.Text）
                .Document.GetElementsByName（"password"）（0）.SetAttribute（"value", Setting.txtpass.Text）
                Dim forms As GeckoElement = fx_2factor.Document.GetElementById("login__submit")
                Dim element As GeckoHtmlElement = forms
                element.Click()

            End With

        End If


    End Sub

    Private Sub btngetusersession_Click(sender As Object, e As EventArgs) Handles btngetusersession.Click

        fx_2factor.Navigate("https://api.ce.nicovideo.jp/api/v1/session.create")

    End Sub


End Class