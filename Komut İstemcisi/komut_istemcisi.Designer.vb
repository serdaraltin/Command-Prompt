<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class komut_istemcisi
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btn_gonder = New System.Windows.Forms.Button()
        Me.tx_girdi = New System.Windows.Forms.TextBox()
        Me.rctx_cikti = New System.Windows.Forms.RichTextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DosyaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.YeniPencereToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.YenidenBaşlatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÇıkışToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HakkındaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_gonder
        '
        Me.btn_gonder.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_gonder.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_gonder.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_gonder.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btn_gonder.Location = New System.Drawing.Point(407, 302)
        Me.btn_gonder.Name = "btn_gonder"
        Me.btn_gonder.Size = New System.Drawing.Size(75, 23)
        Me.btn_gonder.TabIndex = 0
        Me.btn_gonder.Text = "Gönder"
        Me.btn_gonder.UseVisualStyleBackColor = False
        '
        'tx_girdi
        '
        Me.tx_girdi.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tx_girdi.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tx_girdi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tx_girdi.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.tx_girdi.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.tx_girdi.Location = New System.Drawing.Point(9, 302)
        Me.tx_girdi.Name = "tx_girdi"
        Me.tx_girdi.Size = New System.Drawing.Size(392, 23)
        Me.tx_girdi.TabIndex = 1
        '
        'rctx_cikti
        '
        Me.rctx_cikti.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rctx_cikti.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.rctx_cikti.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rctx_cikti.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.rctx_cikti.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.rctx_cikti.ForeColor = System.Drawing.SystemColors.Window
        Me.rctx_cikti.Location = New System.Drawing.Point(9, 37)
        Me.rctx_cikti.Name = "rctx_cikti"
        Me.rctx_cikti.Size = New System.Drawing.Size(473, 251)
        Me.rctx_cikti.TabIndex = 3
        Me.rctx_cikti.Text = ""
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DosyaToolStripMenuItem, Me.HakkındaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(489, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DosyaToolStripMenuItem
        '
        Me.DosyaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DosyaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.YeniPencereToolStripMenuItem, Me.YenidenBaşlatToolStripMenuItem, Me.ÇıkışToolStripMenuItem})
        Me.DosyaToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.DosyaToolStripMenuItem.Name = "DosyaToolStripMenuItem"
        Me.DosyaToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.DosyaToolStripMenuItem.Text = "Dosya"
        '
        'YeniPencereToolStripMenuItem
        '
        Me.YeniPencereToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.YeniPencereToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.YeniPencereToolStripMenuItem.Name = "YeniPencereToolStripMenuItem"
        Me.YeniPencereToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.YeniPencereToolStripMenuItem.Text = "Yeni Pencere"
        '
        'YenidenBaşlatToolStripMenuItem
        '
        Me.YenidenBaşlatToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.YenidenBaşlatToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.YenidenBaşlatToolStripMenuItem.Name = "YenidenBaşlatToolStripMenuItem"
        Me.YenidenBaşlatToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.YenidenBaşlatToolStripMenuItem.Text = "Yeniden Başlat"
        '
        'ÇıkışToolStripMenuItem
        '
        Me.ÇıkışToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ÇıkışToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ÇıkışToolStripMenuItem.Name = "ÇıkışToolStripMenuItem"
        Me.ÇıkışToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.ÇıkışToolStripMenuItem.Text = "Çıkış"
        '
        'HakkındaToolStripMenuItem
        '
        Me.HakkındaToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.HakkındaToolStripMenuItem.Name = "HakkındaToolStripMenuItem"
        Me.HakkındaToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.HakkındaToolStripMenuItem.Text = "Hakkında"
        '
        'komut_istemcisi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(489, 335)
        Me.Controls.Add(Me.rctx_cikti)
        Me.Controls.Add(Me.tx_girdi)
        Me.Controls.Add(Me.btn_gonder)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "komut_istemcisi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Komut İstemcisi"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_gonder As System.Windows.Forms.Button
    Friend WithEvents tx_girdi As System.Windows.Forms.TextBox
    Friend WithEvents rctx_cikti As System.Windows.Forms.RichTextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents DosyaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents YeniPencereToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents YenidenBaşlatToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ÇıkışToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HakkındaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
