<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Setting
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.btnpreview = New System.Windows.Forms.Button()
        Me.cmbfontsize = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbllabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlfont_backcolor = New System.Windows.Forms.Panel()
        Me.pnlfont_forecolor = New System.Windows.Forms.Panel()
        Me.btnbackcolor = New System.Windows.Forms.Button()
        Me.btnforecolor = New System.Windows.Forms.Button()
        Me.cmbfont = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbstyle = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblheight = New System.Windows.Forms.Label()
        Me.numhei = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.numwid = New System.Windows.Forms.NumericUpDown()
        Me.btnpassview = New System.Windows.Forms.Button()
        Me.btnmailview = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnlogin_browser = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.fx_login = New Gecko.GeckoWebBrowser()
        Me.lbllogin = New System.Windows.Forms.Label()
        Me.btnclearcache = New System.Windows.Forms.Button()
        Me.btn2factor = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.numlocation_label = New System.Windows.Forms.NumericUpDown()
        Me.rdo4 = New System.Windows.Forms.RadioButton()
        Me.rdo3 = New System.Windows.Forms.RadioButton()
        Me.rdo2 = New System.Windows.Forms.RadioButton()
        Me.rdo1 = New System.Windows.Forms.RadioButton()
        Me.chklocklabel = New System.Windows.Forms.CheckBox()
        Me.numstyle_index = New System.Windows.Forms.NumericUpDown()
        Me.chkover = New System.Windows.Forms.CheckBox()
        Me.txtaddress = New System.Windows.Forms.TextBox()
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.chkfullscreen = New System.Windows.Forms.CheckBox()
        Me.chklabelview = New System.Windows.Forms.CheckBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.numhei, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numwid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numlocation_label, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numstyle_index, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(553, 388)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(170, 34)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 4)
        Me.OK_Button.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(78, 26)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(88, 4)
        Me.Cancel_Button.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(78, 26)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "キャンセル"
        '
        'btnpreview
        '
        Me.btnpreview.Location = New System.Drawing.Point(23, 222)
        Me.btnpreview.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btnpreview.Name = "btnpreview"
        Me.btnpreview.Size = New System.Drawing.Size(78, 36)
        Me.btnpreview.TabIndex = 218
        Me.btnpreview.Text = "プレビュー"
        Me.btnpreview.UseVisualStyleBackColor = True
        '
        'cmbfontsize
        '
        Me.cmbfontsize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbfontsize.FormattingEnabled = True
        Me.cmbfontsize.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30"})
        Me.cmbfontsize.Location = New System.Drawing.Point(108, 50)
        Me.cmbfontsize.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.cmbfontsize.Name = "cmbfontsize"
        Me.cmbfontsize.Size = New System.Drawing.Size(63, 23)
        Me.cmbfontsize.TabIndex = 217
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(180, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(19, 15)
        Me.Label4.TabIndex = 216
        Me.Label4.Text = "pt"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(28, 54)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 15)
        Me.Label8.TabIndex = 215
        Me.Label8.Text = "サイズ："
        '
        'lbllabel
        '
        Me.lbllabel.AutoSize = True
        Me.lbllabel.Font = New System.Drawing.Font("Meiryo UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbllabel.Location = New System.Drawing.Point(111, 228)
        Me.lbllabel.Name = "lbllabel"
        Me.lbllabel.Size = New System.Drawing.Size(78, 18)
        Me.lbllabel.TabIndex = 214
        Me.lbllabel.Text = "サンプルABC"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 15)
        Me.Label1.TabIndex = 213
        Me.Label1.Text = "フォント："
        '
        'pnlfont_backcolor
        '
        Me.pnlfont_backcolor.Location = New System.Drawing.Point(108, 167)
        Me.pnlfont_backcolor.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.pnlfont_backcolor.Name = "pnlfont_backcolor"
        Me.pnlfont_backcolor.Size = New System.Drawing.Size(211, 36)
        Me.pnlfont_backcolor.TabIndex = 212
        '
        'pnlfont_forecolor
        '
        Me.pnlfont_forecolor.Location = New System.Drawing.Point(108, 121)
        Me.pnlfont_forecolor.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.pnlfont_forecolor.Name = "pnlfont_forecolor"
        Me.pnlfont_forecolor.Size = New System.Drawing.Size(211, 36)
        Me.pnlfont_forecolor.TabIndex = 210
        '
        'btnbackcolor
        '
        Me.btnbackcolor.Location = New System.Drawing.Point(23, 167)
        Me.btnbackcolor.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btnbackcolor.Name = "btnbackcolor"
        Me.btnbackcolor.Size = New System.Drawing.Size(78, 36)
        Me.btnbackcolor.TabIndex = 211
        Me.btnbackcolor.Text = "背景色"
        Me.btnbackcolor.UseVisualStyleBackColor = True
        '
        'btnforecolor
        '
        Me.btnforecolor.Location = New System.Drawing.Point(23, 121)
        Me.btnforecolor.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btnforecolor.Name = "btnforecolor"
        Me.btnforecolor.Size = New System.Drawing.Size(78, 36)
        Me.btnforecolor.TabIndex = 209
        Me.btnforecolor.Text = "文字色"
        Me.btnforecolor.UseVisualStyleBackColor = True
        '
        'cmbfont
        '
        Me.cmbfont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbfont.FormattingEnabled = True
        Me.cmbfont.Location = New System.Drawing.Point(108, 15)
        Me.cmbfont.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.cmbfont.Name = "cmbfont"
        Me.cmbfont.Size = New System.Drawing.Size(211, 23)
        Me.cmbfont.TabIndex = 208
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbstyle)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.lblheight)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnpreview)
        Me.GroupBox1.Controls.Add(Me.cmbfont)
        Me.GroupBox1.Controls.Add(Me.cmbfontsize)
        Me.GroupBox1.Controls.Add(Me.btnforecolor)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.btnbackcolor)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.pnlfont_forecolor)
        Me.GroupBox1.Controls.Add(Me.lbllabel)
        Me.GroupBox1.Controls.Add(Me.pnlfont_backcolor)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 106)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(380, 304)
        Me.GroupBox1.TabIndex = 219
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ラベル設定"
        '
        'cmbstyle
        '
        Me.cmbstyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbstyle.FormattingEnabled = True
        Me.cmbstyle.Items.AddRange(New Object() {"Regular", "Bold", "Italic"})
        Me.cmbstyle.Location = New System.Drawing.Point(108, 85)
        Me.cmbstyle.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.cmbstyle.Name = "cmbstyle"
        Me.cmbstyle.Size = New System.Drawing.Size(91, 23)
        Me.cmbstyle.TabIndex = 221
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(21, 88)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 15)
        Me.Label6.TabIndex = 220
        Me.Label6.Text = "スタイル："
        '
        'lblheight
        '
        Me.lblheight.AutoSize = True
        Me.lblheight.Font = New System.Drawing.Font("Meiryo UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblheight.Location = New System.Drawing.Point(23, 259)
        Me.lblheight.Name = "lblheight"
        Me.lblheight.Size = New System.Drawing.Size(78, 18)
        Me.lblheight.TabIndex = 219
        Me.lblheight.Text = "サンプルABC"
        '
        'numhei
        '
        Me.numhei.Font = New System.Drawing.Font("Meiryo UI", 10.0!)
        Me.numhei.Location = New System.Drawing.Point(509, 125)
        Me.numhei.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.numhei.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.numhei.Name = "numhei"
        Me.numhei.Size = New System.Drawing.Size(49, 24)
        Me.numhei.TabIndex = 225
        Me.numhei.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(491, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(14, 15)
        Me.Label3.TabIndex = 224
        Me.Label3.Text = "x"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(427, 106)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 15)
        Me.Label7.TabIndex = 226
        Me.Label7.Text = "画面サイズ"
        '
        'numwid
        '
        Me.numwid.Font = New System.Drawing.Font("Meiryo UI", 10.0!)
        Me.numwid.Location = New System.Drawing.Point(438, 125)
        Me.numwid.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.numwid.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.numwid.Name = "numwid"
        Me.numwid.Size = New System.Drawing.Size(49, 24)
        Me.numwid.TabIndex = 223
        Me.numwid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnpassview
        '
        Me.btnpassview.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnpassview.Font = New System.Drawing.Font("Meiryo UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnpassview.Location = New System.Drawing.Point(65, 45)
        Me.btnpassview.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnpassview.Name = "btnpassview"
        Me.btnpassview.Size = New System.Drawing.Size(30, 22)
        Me.btnpassview.TabIndex = 233
        Me.btnpassview.Text = "見"
        Me.btnpassview.UseVisualStyleBackColor = True
        '
        'btnmailview
        '
        Me.btnmailview.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnmailview.Font = New System.Drawing.Font("Meiryo UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnmailview.Location = New System.Drawing.Point(65, 13)
        Me.btnmailview.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnmailview.Name = "btnmailview"
        Me.btnmailview.Size = New System.Drawing.Size(30, 22)
        Me.btnmailview.TabIndex = 232
        Me.btnmailview.Text = "見"
        Me.btnmailview.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 15)
        Me.Label2.TabIndex = 230
        Me.Label2.Text = "Mail"
        '
        'btnlogin_browser
        '
        Me.btnlogin_browser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnlogin_browser.Font = New System.Drawing.Font("Meiryo UI", 9.0!)
        Me.btnlogin_browser.Location = New System.Drawing.Point(337, 13)
        Me.btnlogin_browser.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnlogin_browser.Name = "btnlogin_browser"
        Me.btnlogin_browser.Size = New System.Drawing.Size(55, 23)
        Me.btnlogin_browser.TabIndex = 229
        Me.btnlogin_browser.Text = "ログイン"
        Me.btnlogin_browser.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 47)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 15)
        Me.Label5.TabIndex = 231
        Me.Label5.Text = "Pass"
        '
        'fx_login
        '
        Me.fx_login.FrameEventsPropagateToMainWindow = False
        Me.fx_login.Location = New System.Drawing.Point(649, 49)
        Me.fx_login.Name = "fx_login"
        Me.fx_login.Size = New System.Drawing.Size(38, 24)
        Me.fx_login.TabIndex = 234
        Me.fx_login.UseHttpActivityObserver = False
        '
        'lbllogin
        '
        Me.lbllogin.AutoSize = True
        Me.lbllogin.Location = New System.Drawing.Point(337, 49)
        Me.lbllogin.Name = "lbllogin"
        Me.lbllogin.Size = New System.Drawing.Size(27, 15)
        Me.lbllogin.TabIndex = 235
        Me.lbllogin.Text = "----"
        '
        'btnclearcache
        '
        Me.btnclearcache.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnclearcache.Font = New System.Drawing.Font("Meiryo UI", 10.0!)
        Me.btnclearcache.Location = New System.Drawing.Point(430, 13)
        Me.btnclearcache.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnclearcache.Name = "btnclearcache"
        Me.btnclearcache.Size = New System.Drawing.Size(192, 29)
        Me.btnclearcache.TabIndex = 236
        Me.btnclearcache.Text = "ブラウザキャッシュ削除"
        Me.btnclearcache.UseVisualStyleBackColor = True
        '
        'btn2factor
        '
        Me.btn2factor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn2factor.Font = New System.Drawing.Font("Meiryo UI", 10.0!)
        Me.btn2factor.Location = New System.Drawing.Point(429, 59)
        Me.btn2factor.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn2factor.Name = "btn2factor"
        Me.btn2factor.Size = New System.Drawing.Size(193, 29)
        Me.btn2factor.TabIndex = 238
        Me.btn2factor.Text = "ブラウザを開く(for2段階認証)"
        Me.btn2factor.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.Control
        Me.Label9.Font = New System.Drawing.Font("Meiryo UI", 11.0!)
        Me.Label9.Location = New System.Drawing.Point(80, 33)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 19)
        Me.Label9.TabIndex = 222
        Me.Label9.Text = "ラベルの位置"
        '
        'numlocation_label
        '
        Me.numlocation_label.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.nicobrowser.My.MySettings.Default, "numlocation_label", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.numlocation_label.Font = New System.Drawing.Font("Meiryo UI", 10.0!)
        Me.numlocation_label.Location = New System.Drawing.Point(647, 80)
        Me.numlocation_label.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.numlocation_label.Maximum = New Decimal(New Integer() {4, 0, 0, 0})
        Me.numlocation_label.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numlocation_label.Name = "numlocation_label"
        Me.numlocation_label.Size = New System.Drawing.Size(49, 24)
        Me.numlocation_label.TabIndex = 244
        Me.numlocation_label.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numlocation_label.Value = Global.nicobrowser.My.MySettings.Default.numlocation_label
        '
        'rdo4
        '
        Me.rdo4.AutoSize = True
        Me.rdo4.Checked = Global.nicobrowser.My.MySettings.Default.rdo4
        Me.rdo4.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.nicobrowser.My.MySettings.Default, "rdo4", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.rdo4.Location = New System.Drawing.Point(197, 58)
        Me.rdo4.Name = "rdo4"
        Me.rdo4.Size = New System.Drawing.Size(49, 19)
        Me.rdo4.TabIndex = 243
        Me.rdo4.Text = "右下"
        Me.rdo4.UseVisualStyleBackColor = True
        '
        'rdo3
        '
        Me.rdo3.AutoSize = True
        Me.rdo3.Checked = Global.nicobrowser.My.MySettings.Default.rdo3
        Me.rdo3.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.nicobrowser.My.MySettings.Default, "rdo3", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.rdo3.Location = New System.Drawing.Point(8, 58)
        Me.rdo3.Name = "rdo3"
        Me.rdo3.Size = New System.Drawing.Size(49, 19)
        Me.rdo3.TabIndex = 242
        Me.rdo3.Text = "左下"
        Me.rdo3.UseVisualStyleBackColor = True
        '
        'rdo2
        '
        Me.rdo2.AutoSize = True
        Me.rdo2.Checked = Global.nicobrowser.My.MySettings.Default.rdo2
        Me.rdo2.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.nicobrowser.My.MySettings.Default, "rdo2", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.rdo2.Location = New System.Drawing.Point(197, 7)
        Me.rdo2.Name = "rdo2"
        Me.rdo2.Size = New System.Drawing.Size(49, 19)
        Me.rdo2.TabIndex = 241
        Me.rdo2.Text = "右上"
        Me.rdo2.UseVisualStyleBackColor = True
        '
        'rdo1
        '
        Me.rdo1.AutoSize = True
        Me.rdo1.Checked = Global.nicobrowser.My.MySettings.Default.rdo1
        Me.rdo1.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.nicobrowser.My.MySettings.Default, "rdo1", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.rdo1.Location = New System.Drawing.Point(8, 7)
        Me.rdo1.Name = "rdo1"
        Me.rdo1.Size = New System.Drawing.Size(49, 19)
        Me.rdo1.TabIndex = 240
        Me.rdo1.TabStop = True
        Me.rdo1.Text = "左上"
        Me.rdo1.UseVisualStyleBackColor = True
        '
        'chklocklabel
        '
        Me.chklocklabel.AutoSize = True
        Me.chklocklabel.Checked = Global.nicobrowser.My.MySettings.Default.chklocklabel
        Me.chklocklabel.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.nicobrowser.My.MySettings.Default, "chklocklabel", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.chklocklabel.Location = New System.Drawing.Point(438, 251)
        Me.chklocklabel.Name = "chklocklabel"
        Me.chklocklabel.Size = New System.Drawing.Size(247, 19)
        Me.chklocklabel.TabIndex = 239
        Me.chklocklabel.Text = "ラベルを固定する（タイトルバーは消滅します）"
        Me.chklocklabel.UseVisualStyleBackColor = True
        '
        'numstyle_index
        '
        Me.numstyle_index.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.nicobrowser.My.MySettings.Default, "numstyle_index", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.numstyle_index.Font = New System.Drawing.Font("Meiryo UI", 10.0!)
        Me.numstyle_index.Location = New System.Drawing.Point(649, 18)
        Me.numstyle_index.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.numstyle_index.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.numstyle_index.Name = "numstyle_index"
        Me.numstyle_index.Size = New System.Drawing.Size(49, 24)
        Me.numstyle_index.TabIndex = 237
        Me.numstyle_index.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numstyle_index.Value = Global.nicobrowser.My.MySettings.Default.numstyle_index
        '
        'chkover
        '
        Me.chkover.AutoSize = True
        Me.chkover.Checked = Global.nicobrowser.My.MySettings.Default.chkover
        Me.chkover.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.nicobrowser.My.MySettings.Default, "chkover", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.chkover.Location = New System.Drawing.Point(438, 226)
        Me.chkover.Name = "chkover"
        Me.chkover.Size = New System.Drawing.Size(127, 19)
        Me.chkover.TabIndex = 237
        Me.chkover.Text = "ラベルを画面に被せる"
        Me.chkover.UseVisualStyleBackColor = True
        '
        'txtaddress
        '
        Me.txtaddress.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.nicobrowser.My.MySettings.Default, "txtaddress", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtaddress.Location = New System.Drawing.Point(101, 13)
        Me.txtaddress.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(230, 23)
        Me.txtaddress.TabIndex = 227
        Me.txtaddress.Text = Global.nicobrowser.My.MySettings.Default.txtaddress
        '
        'txtpass
        '
        Me.txtpass.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.nicobrowser.My.MySettings.Default, "txtpass", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtpass.Location = New System.Drawing.Point(101, 44)
        Me.txtpass.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.Size = New System.Drawing.Size(230, 23)
        Me.txtpass.TabIndex = 228
        Me.txtpass.Text = Global.nicobrowser.My.MySettings.Default.txtpass
        '
        'chkfullscreen
        '
        Me.chkfullscreen.AutoSize = True
        Me.chkfullscreen.Checked = Global.nicobrowser.My.MySettings.Default.chkfullscreen
        Me.chkfullscreen.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkfullscreen.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.nicobrowser.My.MySettings.Default, "chkfullscreen", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.chkfullscreen.Location = New System.Drawing.Point(438, 166)
        Me.chkfullscreen.Name = "chkfullscreen"
        Me.chkfullscreen.Size = New System.Drawing.Size(138, 19)
        Me.chkfullscreen.TabIndex = 222
        Me.chkfullscreen.Text = "放送画面を最大化する"
        Me.chkfullscreen.UseVisualStyleBackColor = True
        '
        'chklabelview
        '
        Me.chklabelview.AutoSize = True
        Me.chklabelview.Checked = Global.nicobrowser.My.MySettings.Default.chklabelview
        Me.chklabelview.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.nicobrowser.My.MySettings.Default, "chklabelview", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.chklabelview.Location = New System.Drawing.Point(438, 201)
        Me.chklabelview.Name = "chklabelview"
        Me.chklabelview.Size = New System.Drawing.Size(87, 19)
        Me.chklabelview.TabIndex = 220
        Me.chklabelview.Text = "ラベルを表示"
        Me.chklabelview.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Panel1.Controls.Add(Me.rdo1)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.rdo4)
        Me.Panel1.Controls.Add(Me.rdo2)
        Me.Panel1.Controls.Add(Me.rdo3)
        Me.Panel1.Location = New System.Drawing.Point(438, 281)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(249, 84)
        Me.Panel1.TabIndex = 245
        '
        'Setting
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(737, 436)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.numlocation_label)
        Me.Controls.Add(Me.chklocklabel)
        Me.Controls.Add(Me.btn2factor)
        Me.Controls.Add(Me.numstyle_index)
        Me.Controls.Add(Me.chkover)
        Me.Controls.Add(Me.btnclearcache)
        Me.Controls.Add(Me.lbllogin)
        Me.Controls.Add(Me.fx_login)
        Me.Controls.Add(Me.btnpassview)
        Me.Controls.Add(Me.btnmailview)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtaddress)
        Me.Controls.Add(Me.btnlogin_browser)
        Me.Controls.Add(Me.txtpass)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.numhei)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.numwid)
        Me.Controls.Add(Me.chkfullscreen)
        Me.Controls.Add(Me.chklabelview)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Meiryo UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Setting"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Setting"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.numhei, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numwid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numlocation_label, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numstyle_index, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents btnpreview As Button
    Friend WithEvents cmbfontsize As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lbllabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents pnlfont_backcolor As Panel
    Friend WithEvents pnlfont_forecolor As Panel
    Friend WithEvents btnbackcolor As Button
    Friend WithEvents btnforecolor As Button
    Friend WithEvents cmbfont As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chklabelview As CheckBox
    Friend WithEvents chkfullscreen As CheckBox
    Friend WithEvents numhei As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents numwid As NumericUpDown
    Friend WithEvents btnpassview As Button
    Friend WithEvents btnmailview As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtaddress As TextBox
    Friend WithEvents btnlogin_browser As Button
    Friend WithEvents txtpass As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents fx_login As Gecko.GeckoWebBrowser
    Friend WithEvents lbllogin As Label
    Friend WithEvents btnclearcache As Button
    Friend WithEvents lblheight As Label
    Friend WithEvents cmbstyle As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents numstyle_index As NumericUpDown
    Friend WithEvents chkover As CheckBox
    Friend WithEvents btn2factor As Button
    Friend WithEvents chklocklabel As CheckBox
    Friend WithEvents Label9 As Label
    Friend WithEvents rdo1 As RadioButton
    Friend WithEvents rdo2 As RadioButton
    Friend WithEvents rdo4 As RadioButton
    Friend WithEvents rdo3 As RadioButton
    Friend WithEvents numlocation_label As NumericUpDown
    Friend WithEvents Panel1 As Panel
End Class
