Imports Gecko

Public Class Setting

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK

        numstyle_index.Value = cmbstyle.SelectedIndex

        Dim _style As FontStyle = FontStyle.Regular

        If numstyle_index.Value = 0 Then
            _style = FontStyle.Regular

        ElseIf numstyle_index.Value = 1 Then
            _style = FontStyle.Bold

        ElseIf numstyle_index.Value = 2 Then
            _style = FontStyle.Italic

        End If


        Form1.lblname.Font = New Font(cmbfont.SelectedItem.ToString(), CInt(cmbfontsize.SelectedItem), _style)
        Form1.lblname.ForeColor = pnlfont_forecolor.BackColor
        Form1.lblname.BackColor = pnlfont_backcolor.BackColor

        Form1.lblnote.Font = New Font(cmbfont.SelectedItem.ToString(), CInt(cmbfontsize.SelectedItem), _style)
        Form1.lblnote.ForeColor = pnlfont_forecolor.BackColor
        Form1.lblnote.BackColor = pnlfont_backcolor.BackColor

        Form1.Panel1.BackColor = pnlfont_backcolor.BackColor

        Form1.txtfontname.Text = cmbfont.SelectedItem.ToString()
        Form1.numfontsize.Value = cmbfontsize.SelectedItem
        Form1.numfore_r.Value = pnlfont_forecolor.BackColor.R
        Form1.numfore_g.Value = pnlfont_forecolor.BackColor.G
        Form1.numfore_b.Value = pnlfont_forecolor.BackColor.B
        Form1.numback_r.Value = pnlfont_backcolor.BackColor.R
        Form1.numback_g.Value = pnlfont_backcolor.BackColor.G
        Form1.numback_b.Value = pnlfont_backcolor.BackColor.B
        Form1.numstyle.Value = numstyle_index.Value

        Form1.numwid.Value = numwid.Value
        Form1.numhei.Value = numhei.Value


        If chkover.Checked = False Then
            Form1.txtlabel_height.Text = Form1.lblname.Height
            Form1.Panel1.Height = Form1.lblname.Height

        ElseIf chkover.Checked = True Then

            If chklocklabel.Checked = True Then 'タイトルバー消去
                Form1.txtlabel_height.Text = 0
                Form1.Panel1.Height = 0

            ElseIf chklocklabel.Checked = False Then 'タイトルバーの高さを20pxに
                Form1.txtlabel_height.Text = 20
                Form1.Panel1.Height = 20

            End If

        End If


        If chklabelview.Checked = True Then
            Form1.lblname.Visible = True
            Form1.lblnote.Visible = True


            '■ラベルの位置設定
            If rdo1.Checked = True Then
                'ラベルの位置は(0,0)or(0,20)

                If chkover.Checked = False Then
                    Form1.lblname.Location = New Point(0, 0)
                    Form1.lblnote.Location = New Point(Form1.lblname.Width, 0)

                ElseIf chkover.Checked = True Then

                    If chklocklabel.Checked = True Then 'タイトルバー消去
                        Form1.lblname.Location = New Point(0, 0)
                        Form1.lblnote.Location = New Point(Form1.lblname.Width, 0)

                    ElseIf chklocklabel.Checked = False Then 'タイトルバーの高さを20pxに
                        Form1.lblname.Location = New Point(0, 20)
                        Form1.lblnote.Location = New Point(Form1.lblname.Width, 20)

                    End If

                End If


            ElseIf rdo2.Checked = True Then
                'ラベルの位置は(右端-name.width,0 or 20)
                If chkover.Checked = False Then
                    Form1.lblname.Location = New Point(numwid.Value - Form1.lblname.Width, 0)
                    Form1.lblnote.Location = New Point(numwid.Value - Form1.lblname.Width - Form1.lblnote.Width, 0)

                ElseIf chkover.Checked = True Then

                    If chklocklabel.Checked = True Then 'タイトルバー消去
                        Form1.lblname.Location = New Point(numwid.Value - Form1.lblname.Width, 0)
                        Form1.lblnote.Location = New Point(numwid.Value - Form1.lblname.Width - Form1.lblnote.Width, 0)

                    ElseIf chklocklabel.Checked = False Then 'タイトルバーの高さを20pxに
                        Form1.lblname.Location = New Point(numwid.Value - Form1.lblname.Width, 20)
                        Form1.lblnote.Location = New Point(numwid.Value - Form1.lblname.Width - Form1.lblnote.Width, 20)

                    End If

                End If


            ElseIf rdo3.Checked = True Then
                'ラベルの位置は(0,ブラウザの高さ-ラベルの高さ + 0 or 20)
                If chkover.Checked = False Then
                    Form1.lblname.Location = New Point(0, numhei.Value - Form1.lblname.Height + 0)
                    Form1.lblnote.Location = New Point(Form1.lblname.Width, numhei.Value - Form1.lblname.Height + 0)

                ElseIf chkover.Checked = True Then

                    If chklocklabel.Checked = True Then 'タイトルバー消去
                        Form1.lblname.Location = New Point(0, numhei.Value - Form1.lblname.Height + 0)
                        Form1.lblnote.Location = New Point(Form1.lblname.Width, numhei.Value - Form1.lblname.Height + 0)

                    ElseIf chklocklabel.Checked = False Then 'タイトルバーの高さを20pxに
                        Form1.lblname.Location = New Point(0, numhei.Value - Form1.lblname.Height + 20)
                        Form1.lblnote.Location = New Point(Form1.lblname.Width, numhei.Value - Form1.lblname.Height + 20)

                    End If

                End If


            ElseIf rdo4.Checked = True Then
                'ラベルの位置は(右端-name.width,ブラウザの高さ-ラベルの高さ + 0 or 20)
                If chkover.Checked = False Then
                    Form1.lblname.Location = New Point(numwid.Value - Form1.lblname.Width, numhei.Value - Form1.lblname.Height + 0)
                    Form1.lblnote.Location = New Point(numwid.Value - Form1.lblname.Width - Form1.lblnote.Width, numhei.Value - Form1.lblname.Height + 0)

                ElseIf chkover.Checked = True Then

                    If chklocklabel.Checked = True Then 'タイトルバー消去
                        Form1.lblname.Location = New Point(numwid.Value - Form1.lblname.Width, numhei.Value - Form1.lblname.Height + 0)
                        Form1.lblnote.Location = New Point(numwid.Value - Form1.lblname.Width - Form1.lblnote.Width, numhei.Value - Form1.lblname.Height + 0)
                    ElseIf chklocklabel.Checked = False Then 'タイトルバーの高さを20pxに
                        Form1.lblname.Location = New Point(numwid.Value - Form1.lblname.Width, numhei.Value - Form1.lblname.Height + 20)
                        Form1.lblnote.Location = New Point(numwid.Value - Form1.lblname.Width - Form1.lblnote.Width, numhei.Value - Form1.lblname.Height + 20)
                    End If

                End If


            Else
                'ラベルの位置は(0,0)or(0,20)

                If chkover.Checked = False Then
                    Form1.lblname.Location = New Point(0, 0)
                    Form1.lblnote.Location = New Point(Form1.lblname.Width, 0)

                ElseIf chkover.Checked = True Then

                    If chklocklabel.Checked = True Then 'タイトルバー消去
                        Form1.lblname.Location = New Point(0, 0)
                        Form1.lblnote.Location = New Point(Form1.lblname.Width, 0)

                    ElseIf chklocklabel.Checked = False Then 'タイトルバーの高さを20pxに
                        Form1.lblname.Location = New Point(0, 20)
                        Form1.lblnote.Location = New Point(Form1.lblname.Width, 20)

                    End If

                End If


            End If


        ElseIf chklabelview.Checked = False Then
            Form1.lblname.Visible = False
            Form1.lblnote.Visible = False

            Form1.txtlabel_height.Text = 20
            Form1.Panel1.Height = 20

        End If

        Form1.Size = New Size(Form1.numwid.Value, Form1.numhei.Value + Form1.txtlabel_height.Text)
        Form1.web1.Size = New Size(Form1.numwid.Value, Form1.numhei.Value)
        Form1.web1.Location = New Point(0, Form1.txtlabel_height.Text)

        Me.Close()


    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click

        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()


    End Sub



    Private Sub selectfont_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblheight.Text = "ラベルの高さ: -- px"

        txtpass.PasswordChar = "*"c
        txtaddress.PasswordChar = "*"c

        fx_login.Navigate("https://account.nicovideo.jp/login")

        Do
        Loop Until fx_login.IsBusy = False

        numwid.Value = Form1.numwid.Value
        numhei.Value = Form1.numhei.Value

        pnlfont_forecolor.BackColor = Color.FromArgb(Form1.numfore_r.Value, Form1.numfore_g.Value, Form1.numfore_b.Value)
        pnlfont_backcolor.BackColor = Color.FromArgb(Form1.numback_r.Value, Form1.numback_g.Value, Form1.numback_b.Value)

        cmbfontsize.SelectedIndex = 11
        cmbstyle.SelectedIndex = 0


        Dim ifc As New System.Drawing.Text.InstalledFontCollection 'InstalledFontCollectionオブジェクトの取得
        Dim ffs As FontFamily() = ifc.Families 'インストールされているすべてのフォントファミリアを取得
        Dim ff As FontFamily

        For Each ff In ffs

            If ff.IsStyleAvailable(FontStyle.Regular) Then 'スタイルにRegularが使用できるフォントのみを表示
                cmbfont.Items.Add(ff.Name.ToString())

            End If

        Next ff


        Try
            cmbfont.SelectedItem = Form1.txtfontname.Text
        Catch '初期はMeiryo UI。ない可能性がなきにしもあらず
            cmbfont.SelectedIndex = 0
        End Try


        '■チェックボックスの管理
        If chklabelview.Checked = False Then
            chkover.Checked = False
            chkover.Enabled = False

            chklocklabel.Checked = False
            chklocklabel.Enabled = False

        ElseIf chklabelview.Checked = True Then
            chkover.Enabled = True

            If chkover.Checked = True Then
                chklocklabel.Enabled = True

            Else
                chklocklabel.Checked = False
                chklocklabel.Enabled = False

            End If

        End If


    End Sub


    Private Sub btnforecolor_Click(sender As Object, e As EventArgs) Handles btnforecolor.Click

        Dim cd As New ColorDialog() 'ColorDialogクラスのインスタンスを作成

        cd.Color = pnlfont_forecolor.BackColor 'はじめに選択されている色を設定
        cd.AllowFullOpen = True '色の作成部分を表示可能にする。デフォルトがTrueのため必要はない
        cd.SolidColorOnly = False '純色だけに制限しない。デフォルトがFalseのため必要はない

        '[作成した色]に指定した色（RGB値）を表示する
        cd.CustomColors = New Integer() {&H33, &H66, &H99,
            &HCC, &H3300, &H3333, &H3366, &H3399, &H33CC,
            &H6600, &H6633, &H6666, &H6699, &H66CC,
            &H9900, &H9933}


        If cd.ShowDialog() = DialogResult.OK Then
            pnlfont_forecolor.BackColor = cd.Color '選択された色の取得

        End If


    End Sub


    Private Sub btnbackcolor_Click(sender As Object, e As EventArgs) Handles btnbackcolor.Click

        Dim cd As New ColorDialog()


        cd.Color = pnlfont_backcolor.BackColor
        cd.AllowFullOpen = True
        cd.SolidColorOnly = False

        cd.CustomColors = New Integer() {&H33, &H66, &H99,
            &HCC, &H3300, &H3333, &H3366, &H3399, &H33CC,
            &H6600, &H6633, &H6666, &H6699, &H66CC,
            &H9900, &H9933}

        If cd.ShowDialog() = DialogResult.OK Then
            pnlfont_backcolor.BackColor = cd.Color

        End If


    End Sub


    Private Sub btnpreview_Click_1(sender As Object, e As EventArgs) Handles btnpreview.Click

        numstyle_index.Value = cmbstyle.SelectedIndex

        Dim _style As FontStyle = FontStyle.Regular

        If numstyle_index.Value = 0 Then
            _style = FontStyle.Regular

        ElseIf numstyle_index.Value = 1 Then
            _style = FontStyle.Bold

        ElseIf numstyle_index.Value = 2 Then
            _style = FontStyle.Italic

        End If

        lbllabel.Font = New Font(cmbfont.SelectedItem.ToString(), CInt(cmbfontsize.SelectedItem), _style)
        lbllabel.ForeColor = pnlfont_forecolor.BackColor
        lbllabel.BackColor = pnlfont_backcolor.BackColor
        lblheight.Text = "ラベルの高さ: " & lbllabel.Height & " px"


    End Sub


    Private Sub btnlogin_browser_Click(sender As Object, e As EventArgs) Handles btnlogin_browser.Click

        Do
            Application.DoEvents()
        Loop Until fx_login.IsBusy = False

        If fx_login.Document.Uri = "https://account.nicovideo.jp/login" Then

            With fx_login
                .Document.GetElementsByName（"mail_tel"）（0）.SetAttribute（"value", txtaddress.Text）
                .Document.GetElementsByName（"password"）（0）.SetAttribute（"value", txtpass.Text）
                Dim forms As GeckoElement = fx_login.Document.GetElementById("login__submit")
                Dim element As GeckoHtmlElement = forms
                element.Click()

            End With

            Do
                Application.DoEvents()
            Loop Until fx_login.IsBusy = False

            Console.WriteLine("トップ画面のはず " & fx_login.Url.ToString())

            If 0 <= fx_login.Url.ToString().IndexOf("login") Then
                Console.WriteLine("ログイン失敗")
                lbllogin.Text = "Login失敗"

            Else
                lbllogin.Text = "Login成功"

            End If

        End If


    End Sub

    Private Sub btnmailview_Click(sender As Object, e As EventArgs) Handles btnmailview.Click

        If txtaddress.PasswordChar = "*"c Then
            txtaddress.PasswordChar = ""

        Else
            txtaddress.PasswordChar = "*"c

        End If

    End Sub
    Private Sub btnpassview_Click(sender As Object, e As EventArgs) Handles btnpassview.Click

        If txtpass.PasswordChar = "*"c Then
            txtpass.PasswordChar = ""

        Else
            txtpass.PasswordChar = "*"c

        End If


    End Sub


    Private Sub btnclearcache_Click(sender As Object, e As EventArgs) Handles btnclearcache.Click

        Dim CookieMan As nsICookieManager

        CookieMan = Xpcom.GetService(Of nsICookieManager)("@mozilla.org/cookiemanager;1")
        CookieMan = Xpcom.QueryInterface(Of nsICookieManager)(CookieMan)
        CookieMan.RemoveAll()


    End Sub


    Private Sub btn2factor_Click(sender As Object, e As EventArgs) Handles btn2factor.Click

        web_2factor.Show()


    End Sub


    Private Sub chklabelview_CheckedChanged(sender As Object, e As EventArgs) Handles chklabelview.CheckedChanged

        If chklabelview.Checked = False Then
            chkover.Checked = False
            chkover.Enabled = False

            chklocklabel.Checked = False
            chklocklabel.Enabled = False

        ElseIf chklabelview.Checked = True Then
            chkover.Enabled = True

            If chkover.Checked = True Then
                chklocklabel.Enabled = True

            Else
                chklocklabel.Checked = False
                chklocklabel.Enabled = False

            End If

        End If


    End Sub


    Private Sub chkover_CheckedChanged(sender As Object, e As EventArgs) Handles chkover.CheckedChanged

        If chkover.Checked = True Then
            chklocklabel.Enabled = True

        Else
            chklocklabel.Checked = False
            chklocklabel.Enabled = False

        End If


    End Sub



End Class
