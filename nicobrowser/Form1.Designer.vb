<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.web1 = New Gecko.GeckoWebBrowser()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.設定ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.終了ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtgettitle = New System.Windows.Forms.TextBox()
        Me.lblname = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtlabel_height = New System.Windows.Forms.TextBox()
        Me.timtitlecheck = New System.Windows.Forms.Timer(Me.components)
        Me.numstyle = New System.Windows.Forms.NumericUpDown()
        Me.txtfontname = New System.Windows.Forms.TextBox()
        Me.numfore_b = New System.Windows.Forms.NumericUpDown()
        Me.numfore_r = New System.Windows.Forms.NumericUpDown()
        Me.numback_g = New System.Windows.Forms.NumericUpDown()
        Me.numfontsize = New System.Windows.Forms.NumericUpDown()
        Me.numfore_g = New System.Windows.Forms.NumericUpDown()
        Me.numhei = New System.Windows.Forms.NumericUpDown()
        Me.numback_r = New System.Windows.Forms.NumericUpDown()
        Me.numback_b = New System.Windows.Forms.NumericUpDown()
        Me.numwid = New System.Windows.Forms.NumericUpDown()
        Me.lblnote = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.numstyle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numfore_b, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numfore_r, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numback_g, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numfontsize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numfore_g, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numhei, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numback_r, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numback_b, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numwid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'web1
        '
        Me.web1.FrameEventsPropagateToMainWindow = False
        Me.web1.Location = New System.Drawing.Point(0, 0)
        Me.web1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.web1.Name = "web1"
        Me.web1.Size = New System.Drawing.Size(492, 344)
        Me.web1.TabIndex = 0
        Me.web1.UseHttpActivityObserver = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1199, 20)
        Me.Panel1.TabIndex = 4
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.設定ToolStripMenuItem, Me.終了ToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(99, 48)
        '
        '設定ToolStripMenuItem
        '
        Me.設定ToolStripMenuItem.Name = "設定ToolStripMenuItem"
        Me.設定ToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me.設定ToolStripMenuItem.Text = "設定"
        '
        '終了ToolStripMenuItem
        '
        Me.終了ToolStripMenuItem.Name = "終了ToolStripMenuItem"
        Me.終了ToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me.終了ToolStripMenuItem.Text = "終了"
        '
        'txtgettitle
        '
        Me.txtgettitle.Location = New System.Drawing.Point(14, 207)
        Me.txtgettitle.Name = "txtgettitle"
        Me.txtgettitle.Size = New System.Drawing.Size(116, 23)
        Me.txtgettitle.TabIndex = 5
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.ContextMenuStrip = Me.ContextMenuStrip1
        Me.lblname.Location = New System.Drawing.Point(532, 32)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(42, 15)
        Me.lblname.TabIndex = 7
        Me.lblname.Text = "Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(63, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(14, 15)
        Me.Label3.TabIndex = 219
        Me.Label3.Text = "x"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 128)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 15)
        Me.Label7.TabIndex = 221
        Me.Label7.Text = "画面サイズ"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.numstyle)
        Me.GroupBox1.Controls.Add(Me.txtgettitle)
        Me.GroupBox1.Controls.Add(Me.txtfontname)
        Me.GroupBox1.Controls.Add(Me.numfore_b)
        Me.GroupBox1.Controls.Add(Me.numfore_r)
        Me.GroupBox1.Controls.Add(Me.numback_g)
        Me.GroupBox1.Controls.Add(Me.numfontsize)
        Me.GroupBox1.Controls.Add(Me.txtlabel_height)
        Me.GroupBox1.Controls.Add(Me.numfore_g)
        Me.GroupBox1.Controls.Add(Me.numhei)
        Me.GroupBox1.Controls.Add(Me.numback_r)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.numback_b)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.numwid)
        Me.GroupBox1.Location = New System.Drawing.Point(525, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(175, 257)
        Me.GroupBox1.TabIndex = 223
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "設定保存用"
        '
        'txtlabel_height
        '
        Me.txtlabel_height.Location = New System.Drawing.Point(14, 178)
        Me.txtlabel_height.Name = "txtlabel_height"
        Me.txtlabel_height.Size = New System.Drawing.Size(45, 23)
        Me.txtlabel_height.TabIndex = 222
        Me.txtlabel_height.Text = "0"
        '
        'timtitlecheck
        '
        Me.timtitlecheck.Enabled = True
        Me.timtitlecheck.Interval = 200
        '
        'numstyle
        '
        Me.numstyle.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.nicobrowser.My.MySettings.Default, "numstyle", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.numstyle.Font = New System.Drawing.Font("Meiryo UI", 10.0!)
        Me.numstyle.Location = New System.Drawing.Point(81, 178)
        Me.numstyle.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.numstyle.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.numstyle.Name = "numstyle"
        Me.numstyle.Size = New System.Drawing.Size(49, 24)
        Me.numstyle.TabIndex = 223
        Me.numstyle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numstyle.Value = Global.nicobrowser.My.MySettings.Default.numstyle
        '
        'txtfontname
        '
        Me.txtfontname.BackColor = System.Drawing.Color.LavenderBlush
        Me.txtfontname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtfontname.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.nicobrowser.My.MySettings.Default, "txtfontname", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtfontname.Location = New System.Drawing.Point(6, 30)
        Me.txtfontname.Name = "txtfontname"
        Me.txtfontname.Size = New System.Drawing.Size(99, 16)
        Me.txtfontname.TabIndex = 217
        Me.txtfontname.Text = Global.nicobrowser.My.MySettings.Default.txtfontname
        '
        'numfore_b
        '
        Me.numfore_b.BackColor = System.Drawing.Color.LavenderBlush
        Me.numfore_b.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.numfore_b.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.nicobrowser.My.MySettings.Default, "numfore_b", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.numfore_b.Font = New System.Drawing.Font("Meiryo UI", 10.0!)
        Me.numfore_b.Location = New System.Drawing.Point(115, 60)
        Me.numfore_b.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.numfore_b.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.numfore_b.Name = "numfore_b"
        Me.numfore_b.Size = New System.Drawing.Size(49, 20)
        Me.numfore_b.TabIndex = 214
        Me.numfore_b.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numfore_b.Value = Global.nicobrowser.My.MySettings.Default.numfore_b
        '
        'numfore_r
        '
        Me.numfore_r.BackColor = System.Drawing.Color.LavenderBlush
        Me.numfore_r.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.numfore_r.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.nicobrowser.My.MySettings.Default, "numfore_r", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.numfore_r.Font = New System.Drawing.Font("Meiryo UI", 10.0!)
        Me.numfore_r.Location = New System.Drawing.Point(6, 60)
        Me.numfore_r.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.numfore_r.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.numfore_r.Name = "numfore_r"
        Me.numfore_r.Size = New System.Drawing.Size(49, 20)
        Me.numfore_r.TabIndex = 212
        Me.numfore_r.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numfore_r.Value = Global.nicobrowser.My.MySettings.Default.numfore_r
        '
        'numback_g
        '
        Me.numback_g.BackColor = System.Drawing.Color.LavenderBlush
        Me.numback_g.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.numback_g.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.nicobrowser.My.MySettings.Default, "numback_g", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.numback_g.Font = New System.Drawing.Font("Meiryo UI", 10.0!)
        Me.numback_g.Location = New System.Drawing.Point(61, 83)
        Me.numback_g.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.numback_g.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.numback_g.Name = "numback_g"
        Me.numback_g.Size = New System.Drawing.Size(49, 20)
        Me.numback_g.TabIndex = 210
        Me.numback_g.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numback_g.Value = Global.nicobrowser.My.MySettings.Default.numback_g
        '
        'numfontsize
        '
        Me.numfontsize.BackColor = System.Drawing.Color.LavenderBlush
        Me.numfontsize.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.numfontsize.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.nicobrowser.My.MySettings.Default, "numfontsize", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.numfontsize.Font = New System.Drawing.Font("Meiryo UI", 10.0!)
        Me.numfontsize.Location = New System.Drawing.Point(115, 28)
        Me.numfontsize.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.numfontsize.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numfontsize.Name = "numfontsize"
        Me.numfontsize.Size = New System.Drawing.Size(49, 20)
        Me.numfontsize.TabIndex = 211
        Me.numfontsize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numfontsize.Value = Global.nicobrowser.My.MySettings.Default.numfontsize
        '
        'numfore_g
        '
        Me.numfore_g.BackColor = System.Drawing.Color.LavenderBlush
        Me.numfore_g.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.numfore_g.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.nicobrowser.My.MySettings.Default, "numfore_g", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.numfore_g.Font = New System.Drawing.Font("Meiryo UI", 10.0!)
        Me.numfore_g.Location = New System.Drawing.Point(61, 60)
        Me.numfore_g.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.numfore_g.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.numfore_g.Name = "numfore_g"
        Me.numfore_g.Size = New System.Drawing.Size(49, 20)
        Me.numfore_g.TabIndex = 215
        Me.numfore_g.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numfore_g.Value = Global.nicobrowser.My.MySettings.Default.numfore_g
        '
        'numhei
        '
        Me.numhei.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.nicobrowser.My.MySettings.Default, "numhei", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.numhei.Font = New System.Drawing.Font("Meiryo UI", 10.0!)
        Me.numhei.Location = New System.Drawing.Point(81, 147)
        Me.numhei.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.numhei.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.numhei.Name = "numhei"
        Me.numhei.Size = New System.Drawing.Size(49, 24)
        Me.numhei.TabIndex = 220
        Me.numhei.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numhei.Value = Global.nicobrowser.My.MySettings.Default.numhei
        '
        'numback_r
        '
        Me.numback_r.BackColor = System.Drawing.Color.LavenderBlush
        Me.numback_r.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.numback_r.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.nicobrowser.My.MySettings.Default, "numback_r", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.numback_r.Font = New System.Drawing.Font("Meiryo UI", 10.0!)
        Me.numback_r.Location = New System.Drawing.Point(6, 83)
        Me.numback_r.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.numback_r.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.numback_r.Name = "numback_r"
        Me.numback_r.Size = New System.Drawing.Size(49, 20)
        Me.numback_r.TabIndex = 213
        Me.numback_r.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numback_r.Value = Global.nicobrowser.My.MySettings.Default.numback_r
        '
        'numback_b
        '
        Me.numback_b.BackColor = System.Drawing.Color.LavenderBlush
        Me.numback_b.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.numback_b.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.nicobrowser.My.MySettings.Default, "numback_b", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.numback_b.Font = New System.Drawing.Font("Meiryo UI", 10.0!)
        Me.numback_b.Location = New System.Drawing.Point(115, 83)
        Me.numback_b.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.numback_b.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.numback_b.Name = "numback_b"
        Me.numback_b.Size = New System.Drawing.Size(49, 20)
        Me.numback_b.TabIndex = 216
        Me.numback_b.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numback_b.Value = Global.nicobrowser.My.MySettings.Default.numback_b
        '
        'numwid
        '
        Me.numwid.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.nicobrowser.My.MySettings.Default, "numwid", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.numwid.Font = New System.Drawing.Font("Meiryo UI", 10.0!)
        Me.numwid.Location = New System.Drawing.Point(10, 147)
        Me.numwid.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.numwid.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.numwid.Name = "numwid"
        Me.numwid.Size = New System.Drawing.Size(49, 24)
        Me.numwid.TabIndex = 218
        Me.numwid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numwid.Value = Global.nicobrowser.My.MySettings.Default.numwid
        '
        'lblnote
        '
        Me.lblnote.AutoSize = True
        Me.lblnote.ContextMenuStrip = Me.ContextMenuStrip1
        Me.lblnote.Location = New System.Drawing.Point(588, 32)
        Me.lblnote.Name = "lblnote"
        Me.lblnote.Size = New System.Drawing.Size(19, 15)
        Me.lblnote.TabIndex = 224
        Me.lblnote.Text = "♪"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(708, 344)
        Me.Controls.Add(Me.lblnote)
        Me.Controls.Add(Me.lblname)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.web1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Meiryo UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form1"
        Me.Text = "browser"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.numstyle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numfore_b, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numfore_r, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numback_g, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numfontsize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numfore_g, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numhei, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numback_r, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numback_b, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numwid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents web1 As Gecko.GeckoWebBrowser
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtgettitle As TextBox
    Friend WithEvents lblname As Label
    Friend WithEvents txtfontname As TextBox
    Friend WithEvents numback_b As NumericUpDown
    Friend WithEvents numback_r As NumericUpDown
    Friend WithEvents numfore_g As NumericUpDown
    Friend WithEvents numfontsize As NumericUpDown
    Friend WithEvents numback_g As NumericUpDown
    Friend WithEvents numfore_r As NumericUpDown
    Friend WithEvents numfore_b As NumericUpDown
    Friend WithEvents numhei As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents numwid As NumericUpDown
    Friend WithEvents txtlabel_height As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents timtitlecheck As Timer
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents 設定ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 終了ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents numstyle As NumericUpDown
    Friend WithEvents lblnote As Label
End Class
