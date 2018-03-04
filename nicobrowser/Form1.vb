Imports System.IO
Imports Gecko

Public Class Form1

    Private x01 As Integer, y01 As Integer
    Private cx_first As Integer, cy_first As Integer
    Private cx_move As Integer, cy_move As Integer
    Private mouse_state As Integer = 0

    '■準備中の画像のパス
    Private image_pass As String

    Private _name As String


    Sub New()
        MyBase.New()
        ' この呼び出しは Windows フォーム デザイナで必要です。
        'InitializeComponent()
        Xpcom.Initialize("Firefox")
        InitializeComponent() '呼び出しの後に初期化を追加します。

        Gecko.GeckoPreferences.User("browser.tabs.remote.autostart.2") = False
        Gecko.GeckoPreferences.User("browser.tabs.remote.autostart") = False
        Gecko.GeckoPreferences.User("extensions.e10sBlocksEnabling") = True
        Gecko.GeckoPreferences.User("extensions.e10sBlockedByAddons") = True

        Gecko.GeckoPreferences.User("permissions.default.image") = 2
        Gecko.GeckoPreferences.User("permissions.default.camera") = 2
        Gecko.GeckoPreferences.User("permissions.default.desktop-notification") = 2
        Gecko.GeckoPreferences.User("general.useragent.locale") = "ja-JP"
        Gecko.GeckoPreferences.User("browser.cache.memory.capacity") = 98304
        Gecko.GeckoPreferences.User("browser.cache.disk.enable") = False


        'Gecko.GeckoPreferences.User("browser.tabs.remote.autostart.2") = False
        'Gecko.GeckoPreferences.User("browser.tabs.remote.autostart") = False
        'Gecko.GeckoPreferences.User("extensions.e10sBlocksEnabling") = True
        'Gecko.GeckoPreferences.User("extensions.e10sBlockedByAddons") = True
        'Gecko.GeckoPreferences.User("dom.ipc.plugins.asyncdrawing.enabled") = False
        'Gecko.GeckoPreferences.User("html5.offmainthread") = False
        'Gecko.GeckoPreferences.User("network.http.max-persistent-connections-per-server") = 20
        'Gecko.GeckoPreferences.User("network.predictor.enable-prefetch") = False
        'Gecko.GeckoPreferences.User("network.prefetch-next") = False

        'Gecko.GeckoPreferences.User("network.http.speculative-parallel-limit") = 0 '先読み
        'Gecko.GeckoPreferences.User("network.dns.disablePrefetch") = True
        'Gecko.GeckoPreferences.User("network.dns.disablePrefetchFromHTTPS") = True
        'Gecko.GeckoPreferences.User("network.predictor.enabled") = False

        'Gecko.GeckoPreferences.User("network.captive-portal-service.enabled") = False
        'Gecko.GeckoPreferences.User("network.http.spdy.enabled") = False
        'Gecko.GeckoPreferences.User("network.http.spdy.enabled.deps") = False
        'Gecko.GeckoPreferences.User("network.http.spdy.enabled.http2") = False
        'Gecko.GeckoPreferences.User("javascript.options.mem.max") = 56636
        'Gecko.GeckoPreferences.User("javascript.options.mem.high_water_mark") = 32

        'Gecko.GeckoPreferences.User("permissions.default.image") = 2
        'Gecko.GeckoPreferences.User("permissions.default.camera") = 2
        'Gecko.GeckoPreferences.User("permissions.default.desktop-notification") = 2
        'Gecko.GeckoPreferences.User("general.useragent.locale") = "ja-JP"
        'Gecko.GeckoPreferences.User("browser.cache.memory.capacity") = 98304
        'Gecko.GeckoPreferences.User("browser.cache.disk.enable") = False
        'Gecko.GeckoPreferences.User("webgl.enable-webgl2") = False
        'Gecko.GeckoPreferences.User("webgl.dxgl.enabled") = False
        'Gecko.GeckoPreferences.User("webgl.disabled") = True
        'Gecko.GeckoPreferences.User("webgl.disable-wgl") = True
        'Gecko.GeckoPreferences.User("network.dns.disableIPv6") = True


        '以下不要_______________________________________________________________________________


        'Gecko.GeckoPreferences.User("media.autoplay.enabled") = True
        'Gecko.GeckoPreferences.User("media.play-stand-alone") = False
        'Gecko.GeckoPreferences.User("media.seamless-looping") = True
        'Gecko.GeckoPreferences.User("media.use-blank-decoder") = False

        'Gecko.GeckoPreferences.User("dom.ipc.processCount.web") = 1 'マルチプロセス
        'Gecko.GeckoPreferences.User("dom.ipc.processCount") = 1

        'Gecko.GeckoPreferences.User("browser.sessionstore.interval") = 1800000
        'Gecko.GeckoPreferences.User("dom.ipc.plugins.flash.disable-protected-modebrowser.sessionstore.interval") = True

        'Gecko.GeckoPreferences.User("network.tcp.tcp_fastopen_enable") = False
        'Gecko.GeckoPreferences.User("network.tcp.keepalive.idle_time") = 50
        'Gecko.GeckoPreferences.User("network.http.tcp_keepalive.long_lived_idle_time") = 50
        'Gecko.GeckoPreferences.User("captivedetect.canonicalURL") = """"


        'Gecko.GeckoPreferences.User("media.suspend-bkgnd-video.enabled") = True 'バックグラウンドのタブにおいて動画のデコードを停止する機能
        'Gecko.GeckoPreferences.User("dom.max_script_run_time") = 960000000

        'Gecko.GeckoPreferences.User("gfx.direct2d.disabled") = True 'ハードウェアアクセラレーション
        'Gecko.GeckoPreferences.User("layers.acceleration.disabled") = True        
        'Gecko.GeckoPreferences.User("layers.acceleration.disabled") = True
        'Gecko.GeckoPreferences.User("media.hardware-video-decoding.force-enabled") = True


        'Gecko.GeckoPreferences.User("media.navigator.video.h264.max_mbps") = -1
        'Gecko.GeckoPreferences.User("media.navigator.video.h264.level") = 42
        'Gecko.GeckoPreferences.User("browser.cache.check_doc_frequency") = 0 'ページ更新確認頻度
        'Gecko.GeckoPreferences.User("network.websocket.extensions.permessage-deflate") = False
        'Gecko.GeckoPreferences.User("media.wmf.enabled") = True '必ずON
        'Gecko.GeckoPreferences.User("media.wmf.skip-blacklist") = True        
        'Gecko.GeckoPreferences.User("network.http.keep-alive.timeout") = 6000000

    End Sub

    Private Sub GeckoWebBrowser1_ConsoleMessage(sender As Object, e As ConsoleMessageEventArgs) Handles web1.ConsoleMessage

        '■特定のエラーメッセージを捕捉時、更新ボタンを押す。
        If e.Message.Contains("called on an object that does not implement interface Console") Then

            '■更新ボタンを押す
            Console.WriteLine("受信エラー。更新ボタンを探す")
            Dim forms As GeckoElementCollection = web1.Document.GetElementsByTagName("button")

            For Each element As GeckoHtmlElement In forms
                If (element.GetAttribute("class") = "___reload-button___abF8m ___button___P4VSB ___button-base___2v_kF ___button-skin___39Jyb ___local-tooltip___12dLk") Then
                    element.Click()
                    Console.WriteLine("映像を更新しました。")
                    Exit Sub

                End If

            Next

        End If

    End Sub



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        Me.KeyPreview = True ' フォームでもキーイベントを受け取る

        Dim hProcess As Process = Process.GetCurrentProcess() ' 現在のプロセスを取得する

        lblname.Text = hProcess.Id

        hProcess.Close()
        hProcess.Dispose() ' 不要になった時点で破棄する 


        '■画像ファイルのパスを決める。（jpg,gif,png）
        If File.Exists(My.Application.Info.DirectoryPath & "\準備中.gif") Then
            image_pass = My.Application.Info.DirectoryPath & "\準備中.gif"
            Console.WriteLine(DateTime.Now & "  準備中.gifの存在を確認。" & vbCrLf)

        ElseIf File.Exists(My.Application.Info.DirectoryPath & "\準備中.png") Then
            image_pass = My.Application.Info.DirectoryPath & "\準備中.png"
            Console.WriteLine(DateTime.Now & "  準備中.pngの存在を確認。" & vbCrLf)

        ElseIf File.Exists(My.Application.Info.DirectoryPath & "\準備中.jpg") Then
            image_pass = My.Application.Info.DirectoryPath & "\準備中.jpg"
            Console.WriteLine(DateTime.Now & "  準備中.jpgの存在を確認。" & vbCrLf)

        ElseIf File.Exists(My.Application.Info.DirectoryPath & "\準備中.jpeg") Then
            image_pass = My.Application.Info.DirectoryPath & "\準備中.jpeg"
            Console.WriteLine(DateTime.Now & "  準備中.jpegの存在を確認。" & vbCrLf)

        Else
            Console.WriteLine(DateTime.Now & "  画像ファイル""準備中.[jpg, png, gif]""が存在しません。画像ファイルをこのアプリケーションのあるフォルダ内に置き、起動し直して下さい。" & vbCrLf)
            image_pass = ""

        End If

        Console.WriteLine(image_pass)



        '■gif以外であればリサイズし、ブラウザのサイズに合わせる。
        If 0 > image_pass.IndexOf(".gif") And Not image_pass = "" Then
            Dim canvas As New Bitmap(CInt(numwid.Value), CInt(numhei.Value)) '描画先のImageオブジェクトを作成
            Dim g As Graphics = Graphics.FromImage(canvas) 'ImageオブジェクトのGraphicsオブジェクトを作成
            Dim image = New Bitmap(image_pass)   'Bitmapオブジェクトの作成

            g.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic '高品質双三次補間
            g.DrawImage(image, 0, 0, CInt(numwid.Value), CInt(numhei.Value))

            image.Dispose()
            g.Dispose()

            canvas.Save("./temp_preparation.png")
            image_pass = My.Application.Info.DirectoryPath & "\temp_preparation.png"

        End If


        '■画像をブラウザに表示
        If Not image_pass = "" Then
            web1.Navigate(image_pass)
        End If






        '■フォントの設定
        Dim _style As FontStyle = FontStyle.Regular

        If numstyle.Value = 0 Then
            _style = FontStyle.Regular

        ElseIf numstyle.Value = 1 Then
            _style = FontStyle.Bold

        ElseIf numstyle.Value = 2 Then
            _style = FontStyle.Italic

        End If

        lblname.Font = New Font(txtfontname.Text, numfontsize.Value, _style)
        lblname.ForeColor = Color.FromArgb(numfore_r.Value, numfore_g.Value, numfore_b.Value)
        lblname.BackColor = Color.FromArgb(numback_r.Value, numback_g.Value, numback_b.Value)

        lblnote.Font = New Font(txtfontname.Text, numfontsize.Value, _style)
        lblnote.ForeColor = Color.FromArgb(numfore_r.Value, numfore_g.Value, numfore_b.Value)
        lblnote.BackColor = Color.FromArgb(numback_r.Value, numback_g.Value, numback_b.Value)

        Panel1.BackColor = Color.FromArgb(numback_r.Value, numback_g.Value, numback_b.Value)




        If Setting.chklabelview.Checked = True Then
            lblname.Visible = True



            If Setting.chkover.Checked = False Then
                txtlabel_height.Text = lblname.Height
                Panel1.Height = lblname.Height

            ElseIf Setting.chkover.Checked = True Then

                If Setting.chklocklabel.Checked = True Then 'タイトルバー消去
                    txtlabel_height.Text = 0
                    Panel1.Height = 0

                ElseIf Setting.chklocklabel.Checked = False Then 'タイトルバーの高さを20pxに
                    txtlabel_height.Text = 20
                    Panel1.Height = 20

                End If

            End If


            lblnote.Visible = False
            '■ラベルの位置設定（nameのみ。noteはこの時点では必要ない）
            If Setting.rdo1.Checked = True Then
                'ラベルの位置は(0,0)or(0,20)

                If Setting.chkover.Checked = False Then
                    lblname.Location = New Point(0, 0)

                ElseIf Setting.chkover.Checked = True Then

                    If Setting.chklocklabel.Checked = True Then 'タイトルバー消去
                        lblname.Location = New Point(0, 0)

                    ElseIf Setting.chklocklabel.Checked = False Then 'タイトルバーの高さを20pxに
                        lblname.Location = New Point(0, 20)
                    End If

                End If


            ElseIf Setting.rdo2.Checked = True Then
                'ラベルの位置は(右端-name.width,0 or 20)
                If Setting.chkover.Checked = False Then
                    lblname.Location = New Point(numwid.Value - lblname.Width, 0)

                ElseIf Setting.chkover.Checked = True Then

                    If Setting.chklocklabel.Checked = True Then 'タイトルバー消去
                        lblname.Location = New Point(numwid.Value - lblname.Width, 0)

                    ElseIf Setting.chklocklabel.Checked = False Then 'タイトルバーの高さを20pxに
                        lblname.Location = New Point(numwid.Value - lblname.Width, 20)

                    End If

                End If


            ElseIf Setting.rdo3.Checked = True Then
                'ラベルの位置は(0,ブラウザの高さ-ラベルの高さ + 0 or 20)
                If Setting.chkover.Checked = False Then
                    lblname.Location = New Point(0, numhei.Value - lblname.Height + 0)

                ElseIf Setting.chkover.Checked = True Then

                    If Setting.chklocklabel.Checked = True Then 'タイトルバー消去
                        lblname.Location = New Point(0, numhei.Value - lblname.Height + 0)

                    ElseIf Setting.chklocklabel.Checked = False Then 'タイトルバーの高さを20pxに
                        lblname.Location = New Point(0, numhei.Value - lblname.Height + 20)

                    End If

                End If


            ElseIf Setting.rdo4.Checked = True Then
                'ラベルの位置は(右端-name.width,ブラウザの高さ-ラベルの高さ + 0 or 20)
                If Setting.chkover.Checked = False Then
                    lblname.Location = New Point(numwid.Value - lblname.Width, numhei.Value - lblname.Height + 0)

                ElseIf Setting.chkover.Checked = True Then

                    If Setting.chklocklabel.Checked = True Then 'タイトルバー消去
                        lblname.Location = New Point(numwid.Value - lblname.Width, numhei.Value - lblname.Height + 0)

                    ElseIf Setting.chklocklabel.Checked = False Then 'タイトルバーの高さを20pxに
                        lblname.Location = New Point(numwid.Value - lblname.Width, numhei.Value - lblname.Height + 20)

                    End If

                End If

            Else
                'ラベルの位置は(0,0)or(0,20)

                If Setting.chkover.Checked = False Then
                    lblname.Location = New Point(0, 0)

                ElseIf Setting.chkover.Checked = True Then

                    If Setting.chklocklabel.Checked = True Then 'タイトルバー消去
                        lblname.Location = New Point(0, 0)

                    ElseIf Setting.chklocklabel.Checked = False Then 'タイトルバーの高さを20pxに
                        lblname.Location = New Point(0, 20)

                    End If

                End If

            End If


        ElseIf Setting.chklabelview.Checked = False Then
            lblname.Visible = False

            txtlabel_height.Text = 20
            Panel1.Height = 20

        End If





        Me.Size = New Size(numwid.Value, numhei.Value + txtlabel_height.Text)
        web1.Size = New Size(numwid.Value, numhei.Value)
        web1.Location = New Point(0, txtlabel_height.Text)

    End Sub


    '■ラベルのドラッグでウィンドウを動かす
    Private mousePoint As Point

    Private Sub Panel1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Panel1.MouseDown

        If (e.Button And MouseButtons.Left) = MouseButtons.Left Then
            '位置を記憶する
            mousePoint = New Point(e.X, e.Y)

        End If


    End Sub

    Private Sub Panel1_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Panel1.MouseMove

        If (e.Button And MouseButtons.Left) = MouseButtons.Left Then
            Me.Left += e.X - mousePoint.X
            Me.Top += e.Y - mousePoint.Y

        End If


    End Sub


    Private Sub lbl1_MouseDown(sender As Object, e As MouseEventArgs) Handles lblname.MouseDown

        If Setting.chklocklabel.Checked = False Then
            mouse_state = 1
            cx_first = Cursor.Position.X.ToString()
            cy_first = Cursor.Position.Y.ToString()

            x01 = lblname.Location.X
            y01 = lblname.Location.Y

        Else
            If (e.Button And MouseButtons.Left) = MouseButtons.Left Then
                '位置を記憶する
                mousePoint = New Point(e.X, e.Y)

            End If

        End If


    End Sub

    Private Sub lbl1_MouseMove(sender As Object, e As MouseEventArgs) Handles lblname.MouseMove

        If Setting.chklocklabel.Checked = False Then

            If mouse_state = 1 Then

                cx_move = x01 + (Cursor.Position.X.ToString() - cx_first)
                cy_move = y01 + (Cursor.Position.Y.ToString() - cy_first)

                lblname.Location = New Point(cx_move, cy_move)

                If lblname.Location.X < numwid.Value / 2 Then
                    lblnote.Location = New Point(cx_move + lblname.Width, cy_move)

                Else
                    lblnote.Location = New Point(cx_move - lblnote.Width, cy_move)

                End If

            End If


        ElseIf Setting.chklocklabel.Checked = True Then

            If (e.Button And MouseButtons.Left) = MouseButtons.Left Then
                Me.Left += e.X - mousePoint.X
                Me.Top += e.Y - mousePoint.Y

            End If

        End If


    End Sub


    Private Sub lbl1_MouseUp(sender As Object, e As MouseEventArgs) Handles lblname.MouseUp

        If Setting.chklocklabel.Checked = False Then
            mouse_state = 0

        End If


    End Sub





    Private temp_title1 As String
    Private temp_name As String

    Private Sub timtitlecheck_Tick(sender As Object, e As EventArgs) Handles timtitlecheck.Tick

        If Not Me.Text = temp_title1 Then
            Console.WriteLine("ウィンドウタイトルの変更を確認")
            txtgettitle.Text = Me.Text
            temp_title1 = Me.Text

        End If


    End Sub

    Private Sub adjFontloc_noteon()
        If lblname.Location.X < numwid.Value / 2 Then
            lblnote.Location = New Point(lblname.Location.X + lblname.Width, lblname.Location.Y)
        Else
            lblnote.Location = New Point(lblname.Location.X - lblnote.Width, lblname.Location.Y)

        End If

        lblnote.Visible = True

    End Sub


    Private Sub adjFontloc_noteoff()
        If lblname.Location.X < numwid.Value / 2 Then
            lblnote.Location = New Point(lblname.Location.X + lblname.Width, lblname.Location.Y)
        Else
            lblnote.Location = New Point(lblname.Location.X - lblnote.Width, lblname.Location.Y)

        End If

        lblnote.Visible = False


    End Sub

    Private Sub txtgettitle_TextChanged(sender As Object, e As EventArgs) Handles txtgettitle.TextChanged

        If 0 <= txtgettitle.Text.IndexOf("name_") Then
            lblname.Text = txtgettitle.Text.Replace("name_", "")
            temp_name = txtgettitle.Text.Replace("name_", "")

        ElseIf 0 <= txtgettitle.Text.IndexOf("lv_nico_") Then
            web1.Navigate("http://live2.nicovideo.jp/watch/" & txtgettitle.Text.Replace("lv_nico_", ""))

            Do
                Application.DoEvents()
            Loop Until web1.IsBusy = False And web1.IsAjaxBusy = False
            Application.DoEvents()

            If Setting.chkfullscreen.Checked = True Then
                fullscreen()

            End If

        ElseIf 0 <= txtgettitle.Text.IndexOf("lv_twitch_") Then
            web1.Navigate(txtgettitle.Text.Replace("lv_twitch_", ""))

        ElseIf 0 <= txtgettitle.Text.IndexOf("lv_youtube_") Then
            web1.Navigate(txtgettitle.Text.Replace("lv_youtube_", ""))

        ElseIf 0 <= txtgettitle.Text.IndexOf("lv_mixer_") Then
            web1.Navigate(txtgettitle.Text.Replace("lv_mixer_", ""))

        ElseIf 0 <= txtgettitle.Text.IndexOf("lv_config_") Then
            web1.Navigate("about:config")

        ElseIf 0 <= txtgettitle.Text.IndexOf("lv_blank_") Then

            If Not image_pass = "" Then
                web1.Navigate(image_pass)
            End If

        ElseIf 0 <= txtgettitle.Text.IndexOf("chksound_on") Then
            adjFontloc_noteon()

        ElseIf 0 <= txtgettitle.Text.IndexOf("chksound_off") Then
            adjFontloc_noteoff()

        ElseIf 0 <= txtgettitle.Text.IndexOf("sound_") Then
            sound_change()

        ElseIf 0 <= txtgettitle.Text.IndexOf("reload_screen_") Then
            reload_screen()

        ElseIf 0 <= txtgettitle.Text.IndexOf("reload_browser_") Then
            reload_browser()

        End If

        txtgettitle.Text = "temp"
        temp_title1 = temp_name
        Me.Text = temp_name


    End Sub

    Private Sub fullscreen()

        Dim forms As GeckoElementCollection = web1.Document.GetElementsByTagName("button")

        For Each element As GeckoHtmlElement In forms

            If (element.GetAttribute("class") = "___fullscreen-button___1kqMN ___button___P4VSB ___button-base___2v_kF ___button-skin___39Jyb ___local-tooltip___12dLk") Then
                element.Click()
                Exit Sub
                Console.WriteLine("最大化しました。")

            End If

        Next


    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs)

        Me.Close()


    End Sub

    Private Sub btnsetting_Click(sender As Object, e As EventArgs)

        Setting.Show()


    End Sub

    Private Sub 設定ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 設定ToolStripMenuItem.Click

        Setting.Show()


    End Sub

    Private Sub 終了ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 終了ToolStripMenuItem.Click

        Me.Close()


    End Sub

    '■更新ボタンを押す
    Private Sub reload_screen()

        Console.WriteLine("更新ボタンを探す")

        Dim forms As GeckoElementCollection = web1.Document.GetElementsByTagName("button")

        For Each element As GeckoHtmlElement In forms

            If (element.GetAttribute("class") = "___reload-button___abF8m ___button___P4VSB ___button-base___2v_kF ___button-skin___39Jyb ___local-tooltip___12dLk") Then
                element.Click()

                Console.WriteLine("映像を更新しました。")

            End If

        Next


    End Sub


    Private Sub reload_browser()

        web1.Reload()

        Do
            Application.DoEvents()
        Loop Until web1.IsBusy = False And web1.IsAjaxBusy = False
        Application.DoEvents()

        fullscreen()


    End Sub

    '■音声切り替え
    Private Sub sound_change()

        If 0 <= txtgettitle.Text.IndexOf("nico") Then
            Console.WriteLine("ボタンを探す_nico")
            Dim forms As GeckoElementCollection = web1.Document.GetElementsByTagName("button")

            For Each element As GeckoHtmlElement In forms
                If (element.GetAttribute("class") = "___button___P4VSB ___button-base___2v_kF ___button-skin___39Jyb ___local-tooltip___12dLk") Then
                    element.Click()
                    Console.WriteLine("音声のON/OFFを切り替えました。")
                End If
            Next

            If 0 <= txtgettitle.Text.IndexOf("on") Then
                adjFontloc_noteon()

            Else
                adjFontloc_noteoff()

            End If


        ElseIf 0 <= txtgettitle.Text.IndexOf("twitch") Then
            Console.WriteLine("ボタンを探す_twitch")

            Dim forms As GeckoElementCollection = web1.Document.GetElementsByTagName("button")

            For Each element As GeckoHtmlElement In forms

                If (element.GetAttribute("class") = "player-button player-button--volume qa-control-volume") Then
                    element.Click()
                    Console.WriteLine("音声のON/OFFを切り替えました。")

                End If

            Next

            If 0 <= txtgettitle.Text.IndexOf("on") Then
                adjFontloc_noteon()
            Else
                adjFontloc_noteoff()

            End If



        ElseIf 0 <= txtgettitle.Text.IndexOf("youtube") Then
            Console.WriteLine("ボタンを探す_youtube")
            Dim forms As GeckoElementCollection = web1.Document.GetElementsByTagName("button")

            For Each element As GeckoHtmlElement In forms
                If (element.GetAttribute("class") = "ytp-mute-button ytp-button") Then
                    element.Click()
                    Console.WriteLine("音声のON/OFFを切り替えました。")

                End If
            Next

            If 0 <= txtgettitle.Text.IndexOf("on") Then
                adjFontloc_noteon()

            Else
                adjFontloc_noteoff()

            End If


        ElseIf 0 <= txtgettitle.Text.IndexOf("mixer") Then

            If 0 <= txtgettitle.Text.IndexOf("on") Then
                adjFontloc_noteon()

            Else
                adjFontloc_noteoff()

            End If

        End If


    End Sub


End Class
