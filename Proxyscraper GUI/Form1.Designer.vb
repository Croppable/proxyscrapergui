<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.HuraForm1 = New Proxyscraper_GUI.HuraForm()
        Me.HuraControlBox1 = New Proxyscraper_GUI.HuraControlBox()
        Me.proxyType = New System.Windows.Forms.Label()
        Me.HuraTabControl1 = New Proxyscraper_GUI.HuraTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.saveProxies = New Proxyscraper_GUI.HuraButton()
        Me.scrapedProxiesTxt = New Proxyscraper_GUI.HuraTextBox()
        Me.startScrape = New Proxyscraper_GUI.HuraButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.proxySelect = New Proxyscraper_GUI.HuraComboBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.HuraButton1 = New Proxyscraper_GUI.HuraButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.HuraForm1.SuspendLayout()
        Me.HuraTabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'HuraForm1
        '
        Me.HuraForm1.AccentColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HuraForm1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HuraForm1.ColorScheme = Proxyscraper_GUI.HuraForm.ColorSchemes.Dark
        Me.HuraForm1.Controls.Add(Me.HuraControlBox1)
        Me.HuraForm1.Controls.Add(Me.proxyType)
        Me.HuraForm1.Controls.Add(Me.HuraTabControl1)
        Me.HuraForm1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HuraForm1.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.HuraForm1.ForeColor = System.Drawing.Color.Gray
        Me.HuraForm1.Location = New System.Drawing.Point(0, 0)
        Me.HuraForm1.Name = "HuraForm1"
        Me.HuraForm1.Size = New System.Drawing.Size(427, 227)
        Me.HuraForm1.TabIndex = 0
        Me.HuraForm1.Text = "Proxyscraper G.U.I"
        '
        'HuraControlBox1
        '
        Me.HuraControlBox1.AccentColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HuraControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HuraControlBox1.BackColor = System.Drawing.Color.White
        Me.HuraControlBox1.ColorScheme = Proxyscraper_GUI.HuraControlBox.ColorSchemes.Dark
        Me.HuraControlBox1.ForeColor = System.Drawing.Color.White
        Me.HuraControlBox1.Location = New System.Drawing.Point(324, 3)
        Me.HuraControlBox1.Name = "HuraControlBox1"
        Me.HuraControlBox1.Size = New System.Drawing.Size(100, 25)
        Me.HuraControlBox1.TabIndex = 6
        Me.HuraControlBox1.Text = "HuraControlBox1"
        '
        'proxyType
        '
        Me.proxyType.AutoSize = True
        Me.proxyType.Location = New System.Drawing.Point(268, 9)
        Me.proxyType.Name = "proxyType"
        Me.proxyType.Size = New System.Drawing.Size(31, 17)
        Me.proxyType.TabIndex = 5
        Me.proxyType.Text = "http"
        '
        'HuraTabControl1
        '
        Me.HuraTabControl1.Controls.Add(Me.TabPage1)
        Me.HuraTabControl1.Controls.Add(Me.TabPage2)
        Me.HuraTabControl1.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.HuraTabControl1.ItemSize = New System.Drawing.Size(0, 30)
        Me.HuraTabControl1.Location = New System.Drawing.Point(12, 28)
        Me.HuraTabControl1.Name = "HuraTabControl1"
        Me.HuraTabControl1.SelectedIndex = 0
        Me.HuraTabControl1.Size = New System.Drawing.Size(403, 187)
        Me.HuraTabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.saveProxies)
        Me.TabPage1.Controls.Add(Me.scrapedProxiesTxt)
        Me.TabPage1.Controls.Add(Me.startScrape)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.proxySelect)
        Me.TabPage1.Location = New System.Drawing.Point(4, 34)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(395, 149)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Scraper"
        '
        'saveProxies
        '
        Me.saveProxies.BackColor = System.Drawing.Color.Transparent
        Me.saveProxies.BaseColour = System.Drawing.Color.White
        Me.saveProxies.BorderColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.saveProxies.FontColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.saveProxies.HoverColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.saveProxies.Location = New System.Drawing.Point(196, 99)
        Me.saveProxies.Name = "saveProxies"
        Me.saveProxies.PressedColour = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.saveProxies.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.saveProxies.Size = New System.Drawing.Size(193, 30)
        Me.saveProxies.TabIndex = 4
        Me.saveProxies.Text = "Save Results"
        '
        'scrapedProxiesTxt
        '
        Me.scrapedProxiesTxt.BackColor = System.Drawing.Color.Transparent
        Me.scrapedProxiesTxt.BackgroundColour = System.Drawing.Color.White
        Me.scrapedProxiesTxt.BorderColour = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.scrapedProxiesTxt.Location = New System.Drawing.Point(196, 3)
        Me.scrapedProxiesTxt.MaxLength = 32767
        Me.scrapedProxiesTxt.Multiline = True
        Me.scrapedProxiesTxt.Name = "scrapedProxiesTxt"
        Me.scrapedProxiesTxt.ReadOnly = True
        Me.scrapedProxiesTxt.Size = New System.Drawing.Size(193, 90)
        Me.scrapedProxiesTxt.Style = Proxyscraper_GUI.HuraTextBox.Styles.Normal
        Me.scrapedProxiesTxt.TabIndex = 3
        Me.scrapedProxiesTxt.Text = "Proxies Grabbed!"
        Me.scrapedProxiesTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.scrapedProxiesTxt.TextColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.scrapedProxiesTxt.UseSystemPasswordChar = False
        '
        'startScrape
        '
        Me.startScrape.BackColor = System.Drawing.Color.Transparent
        Me.startScrape.BaseColour = System.Drawing.Color.White
        Me.startScrape.BorderColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.startScrape.FontColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.startScrape.HoverColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.startScrape.Location = New System.Drawing.Point(6, 65)
        Me.startScrape.Name = "startScrape"
        Me.startScrape.PressedColour = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.startScrape.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.startScrape.Size = New System.Drawing.Size(184, 30)
        Me.startScrape.TabIndex = 2
        Me.startScrape.Text = "Start Scraping"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Proxy Type"
        '
        'proxySelect
        '
        Me.proxySelect.AccentColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.proxySelect.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.proxySelect.ColorScheme = Proxyscraper_GUI.HuraComboBox.ColorSchemes.Dark
        Me.proxySelect.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.proxySelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.proxySelect.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.proxySelect.ForeColor = System.Drawing.Color.White
        Me.proxySelect.FormattingEnabled = True
        Me.proxySelect.Items.AddRange(New Object() {"HTTP / HTTPS", "SOCKS4", "SOCKS5"})
        Me.proxySelect.Location = New System.Drawing.Point(6, 34)
        Me.proxySelect.Name = "proxySelect"
        Me.proxySelect.Size = New System.Drawing.Size(184, 25)
        Me.proxySelect.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.HuraButton1)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 34)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(395, 149)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Credits"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(191, 17)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = ">> PROXYSCRAPE WEBSITE <<"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(273, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Thanks @Proxyscrape Team For The Free API!"
        '
        'HuraButton1
        '
        Me.HuraButton1.BackColor = System.Drawing.Color.Transparent
        Me.HuraButton1.BaseColour = System.Drawing.Color.White
        Me.HuraButton1.BorderColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.HuraButton1.FontColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.HuraButton1.HoverColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HuraButton1.Location = New System.Drawing.Point(9, 113)
        Me.HuraButton1.Name = "HuraButton1"
        Me.HuraButton1.PressedColour = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.HuraButton1.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HuraButton1.Size = New System.Drawing.Size(380, 30)
        Me.HuraButton1.TabIndex = 3
        Me.HuraButton1.Text = "Check Out Repo Here!"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(252, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Simple Tool Made By: Croppable (GitHub)"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(427, 227)
        Me.Controls.Add(Me.HuraForm1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Proxyscraper G.U.I"
        Me.HuraForm1.ResumeLayout(False)
        Me.HuraForm1.PerformLayout()
        Me.HuraTabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents HuraForm1 As Proxyscraper_GUI.HuraForm
    Friend WithEvents HuraTabControl1 As Proxyscraper_GUI.HuraTabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents saveProxies As Proxyscraper_GUI.HuraButton
    Friend WithEvents scrapedProxiesTxt As Proxyscraper_GUI.HuraTextBox
    Friend WithEvents startScrape As Proxyscraper_GUI.HuraButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents proxySelect As Proxyscraper_GUI.HuraComboBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents proxyType As System.Windows.Forms.Label
    Friend WithEvents HuraControlBox1 As Proxyscraper_GUI.HuraControlBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents HuraButton1 As Proxyscraper_GUI.HuraButton
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
