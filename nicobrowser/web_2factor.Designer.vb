<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class web_2factor
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
        Me.fx_2factor = New Gecko.GeckoWebBrowser()
        Me.btngetusersession = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'fx_2factor
        '
        Me.fx_2factor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fx_2factor.FrameEventsPropagateToMainWindow = False
        Me.fx_2factor.Location = New System.Drawing.Point(0, 0)
        Me.fx_2factor.Name = "fx_2factor"
        Me.fx_2factor.Size = New System.Drawing.Size(765, 592)
        Me.fx_2factor.TabIndex = 235
        Me.fx_2factor.UseHttpActivityObserver = False
        '
        'btngetusersession
        '
        Me.btngetusersession.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btngetusersession.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btngetusersession.Font = New System.Drawing.Font("Meiryo UI", 10.0!)
        Me.btngetusersession.Location = New System.Drawing.Point(559, 599)
        Me.btngetusersession.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btngetusersession.Name = "btngetusersession"
        Me.btngetusersession.Size = New System.Drawing.Size(193, 29)
        Me.btngetusersession.TabIndex = 240
        Me.btngetusersession.Text = "user_sessionを表示"
        Me.btngetusersession.UseVisualStyleBackColor = True
        '
        'web_2factor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(764, 641)
        Me.Controls.Add(Me.btngetusersession)
        Me.Controls.Add(Me.fx_2factor)
        Me.Name = "web_2factor"
        Me.Text = "ログイン"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents fx_2factor As Gecko.GeckoWebBrowser
    Friend WithEvents btngetusersession As Button
End Class
