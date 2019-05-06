<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NetflixCheckerForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NetflixCheckerForm))
        Me.FormSkin1 = New FlatUI.FormSkin()
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown()
        Me.TextBoxResult = New System.Windows.Forms.RichTextBox()
        Me.TopMostToggle = New FlatUI.FlatCheckBox()
        Me.InvalidAccounts = New FlatUI.FlatLabel()
        Me.ValidAmount = New FlatUI.FlatLabel()
        Me.CheckedAmount = New FlatUI.FlatLabel()
        Me.FlatLabel3 = New FlatUI.FlatLabel()
        Me.GoodAccounts = New FlatUI.FlatLabel()
        Me.CheckedLabel = New FlatUI.FlatLabel()
        Me.AmountOfProxies = New FlatUI.FlatLabel()
        Me.AmountOfAccounts = New FlatUI.FlatLabel()
        Me.StartChecking = New FlatUI.FlatButton()
        Me.StatusBar = New FlatUI.FlatStatusBar()
        Me.TypeProxyLabel = New FlatUI.FlatLabel()
        Me.TypeOfProxy = New FlatUI.FlatComboBox()
        Me.ThreadsLabel = New FlatUI.FlatLabel()
        Me.AmountOfThreads = New FlatUI.FlatTextBox()
        Me.ProxiesLabel = New FlatUI.FlatLabel()
        Me.AccountsLabel = New FlatUI.FlatLabel()
        Me.LoadProxiesButton = New FlatUI.FlatButton()
        Me.FlatButton1 = New FlatUI.FlatButton()
        Me.Minimize = New FlatUI.FlatMini()
        Me.Close = New FlatUI.FlatClose()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.FormSkin1.SuspendLayout()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FormSkin1
        '
        Me.FormSkin1.BackColor = System.Drawing.Color.White
        Me.FormSkin1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.FormSkin1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.FormSkin1.Controls.Add(Me.NumericUpDown2)
        Me.FormSkin1.Controls.Add(Me.TextBoxResult)
        Me.FormSkin1.Controls.Add(Me.TopMostToggle)
        Me.FormSkin1.Controls.Add(Me.InvalidAccounts)
        Me.FormSkin1.Controls.Add(Me.ValidAmount)
        Me.FormSkin1.Controls.Add(Me.CheckedAmount)
        Me.FormSkin1.Controls.Add(Me.FlatLabel3)
        Me.FormSkin1.Controls.Add(Me.GoodAccounts)
        Me.FormSkin1.Controls.Add(Me.CheckedLabel)
        Me.FormSkin1.Controls.Add(Me.AmountOfProxies)
        Me.FormSkin1.Controls.Add(Me.AmountOfAccounts)
        Me.FormSkin1.Controls.Add(Me.StartChecking)
        Me.FormSkin1.Controls.Add(Me.StatusBar)
        Me.FormSkin1.Controls.Add(Me.TypeProxyLabel)
        Me.FormSkin1.Controls.Add(Me.TypeOfProxy)
        Me.FormSkin1.Controls.Add(Me.ThreadsLabel)
        Me.FormSkin1.Controls.Add(Me.AmountOfThreads)
        Me.FormSkin1.Controls.Add(Me.ProxiesLabel)
        Me.FormSkin1.Controls.Add(Me.AccountsLabel)
        Me.FormSkin1.Controls.Add(Me.LoadProxiesButton)
        Me.FormSkin1.Controls.Add(Me.FlatButton1)
        Me.FormSkin1.Controls.Add(Me.Minimize)
        Me.FormSkin1.Controls.Add(Me.Close)
        Me.FormSkin1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormSkin1.FlatColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.FormSkin1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FormSkin1.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FormSkin1.HeaderMaximize = False
        Me.FormSkin1.Location = New System.Drawing.Point(0, 0)
        Me.FormSkin1.Name = "FormSkin1"
        Me.FormSkin1.Size = New System.Drawing.Size(700, 379)
        Me.FormSkin1.TabIndex = 0
        Me.FormSkin1.Text = "Netflix Checker"
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.Location = New System.Drawing.Point(743, 10)
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(120, 29)
        Me.NumericUpDown2.TabIndex = 24
        '
        'TextBoxResult
        '
        Me.TextBoxResult.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.TextBoxResult.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxResult.ForeColor = System.Drawing.Color.White
        Me.TextBoxResult.Location = New System.Drawing.Point(288, 57)
        Me.TextBoxResult.Name = "TextBoxResult"
        Me.TextBoxResult.ReadOnly = True
        Me.TextBoxResult.Size = New System.Drawing.Size(400, 291)
        Me.TextBoxResult.TabIndex = 23
        Me.TextBoxResult.Text = ""
        '
        'TopMostToggle
        '
        Me.TopMostToggle.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.TopMostToggle.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.TopMostToggle.BorderColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TopMostToggle.Checked = False
        Me.TopMostToggle.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TopMostToggle.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TopMostToggle.Location = New System.Drawing.Point(558, 14)
        Me.TopMostToggle.Name = "TopMostToggle"
        Me.TopMostToggle.Options = FlatUI.FlatCheckBox._Options.Style1
        Me.TopMostToggle.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TopMostToggle.Size = New System.Drawing.Size(87, 22)
        Me.TopMostToggle.TabIndex = 22
        Me.TopMostToggle.Text = "TopMost"
        '
        'InvalidAccounts
        '
        Me.InvalidAccounts.AutoSize = True
        Me.InvalidAccounts.BackColor = System.Drawing.Color.Transparent
        Me.InvalidAccounts.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InvalidAccounts.ForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.InvalidAccounts.Location = New System.Drawing.Point(237, 294)
        Me.InvalidAccounts.Name = "InvalidAccounts"
        Me.InvalidAccounts.Size = New System.Drawing.Size(17, 20)
        Me.InvalidAccounts.TabIndex = 20
        Me.InvalidAccounts.Text = "0"
        '
        'ValidAmount
        '
        Me.ValidAmount.AutoSize = True
        Me.ValidAmount.BackColor = System.Drawing.Color.Transparent
        Me.ValidAmount.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ValidAmount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.ValidAmount.Location = New System.Drawing.Point(237, 251)
        Me.ValidAmount.Name = "ValidAmount"
        Me.ValidAmount.Size = New System.Drawing.Size(17, 20)
        Me.ValidAmount.TabIndex = 19
        Me.ValidAmount.Text = "0"
        '
        'CheckedAmount
        '
        Me.CheckedAmount.AutoSize = True
        Me.CheckedAmount.BackColor = System.Drawing.Color.Transparent
        Me.CheckedAmount.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckedAmount.ForeColor = System.Drawing.Color.White
        Me.CheckedAmount.Location = New System.Drawing.Point(237, 204)
        Me.CheckedAmount.Name = "CheckedAmount"
        Me.CheckedAmount.Size = New System.Drawing.Size(17, 20)
        Me.CheckedAmount.TabIndex = 18
        Me.CheckedAmount.Text = "0"
        '
        'FlatLabel3
        '
        Me.FlatLabel3.AutoSize = True
        Me.FlatLabel3.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel3.ForeColor = System.Drawing.Color.White
        Me.FlatLabel3.Location = New System.Drawing.Point(162, 294)
        Me.FlatLabel3.Name = "FlatLabel3"
        Me.FlatLabel3.Size = New System.Drawing.Size(56, 20)
        Me.FlatLabel3.TabIndex = 17
        Me.FlatLabel3.Text = "Invalid:"
        '
        'GoodAccounts
        '
        Me.GoodAccounts.AutoSize = True
        Me.GoodAccounts.BackColor = System.Drawing.Color.Transparent
        Me.GoodAccounts.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GoodAccounts.ForeColor = System.Drawing.Color.White
        Me.GoodAccounts.Location = New System.Drawing.Point(162, 251)
        Me.GoodAccounts.Name = "GoodAccounts"
        Me.GoodAccounts.Size = New System.Drawing.Size(45, 20)
        Me.GoodAccounts.TabIndex = 16
        Me.GoodAccounts.Text = "Valid:"
        '
        'CheckedLabel
        '
        Me.CheckedLabel.AutoSize = True
        Me.CheckedLabel.BackColor = System.Drawing.Color.Transparent
        Me.CheckedLabel.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckedLabel.ForeColor = System.Drawing.Color.White
        Me.CheckedLabel.Location = New System.Drawing.Point(162, 204)
        Me.CheckedLabel.Name = "CheckedLabel"
        Me.CheckedLabel.Size = New System.Drawing.Size(68, 20)
        Me.CheckedLabel.TabIndex = 15
        Me.CheckedLabel.Text = "Checked:"
        '
        'AmountOfProxies
        '
        Me.AmountOfProxies.AutoSize = True
        Me.AmountOfProxies.BackColor = System.Drawing.Color.Transparent
        Me.AmountOfProxies.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AmountOfProxies.ForeColor = System.Drawing.Color.White
        Me.AmountOfProxies.Location = New System.Drawing.Point(237, 135)
        Me.AmountOfProxies.Name = "AmountOfProxies"
        Me.AmountOfProxies.Size = New System.Drawing.Size(17, 20)
        Me.AmountOfProxies.TabIndex = 14
        Me.AmountOfProxies.Text = "0"
        '
        'AmountOfAccounts
        '
        Me.AmountOfAccounts.AutoSize = True
        Me.AmountOfAccounts.BackColor = System.Drawing.Color.Transparent
        Me.AmountOfAccounts.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AmountOfAccounts.ForeColor = System.Drawing.Color.White
        Me.AmountOfAccounts.Location = New System.Drawing.Point(237, 85)
        Me.AmountOfAccounts.Name = "AmountOfAccounts"
        Me.AmountOfAccounts.Size = New System.Drawing.Size(17, 20)
        Me.AmountOfAccounts.TabIndex = 13
        Me.AmountOfAccounts.Text = "0"
        '
        'StartChecking
        '
        Me.StartChecking.BackColor = System.Drawing.Color.Transparent
        Me.StartChecking.BaseColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StartChecking.Cursor = System.Windows.Forms.Cursors.Hand
        Me.StartChecking.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.StartChecking.Location = New System.Drawing.Point(22, 308)
        Me.StartChecking.Name = "StartChecking"
        Me.StartChecking.Rounded = False
        Me.StartChecking.Size = New System.Drawing.Size(126, 32)
        Me.StartChecking.TabIndex = 12
        Me.StartChecking.Text = "Start"
        Me.StartChecking.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'StatusBar
        '
        Me.StatusBar.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.StatusBar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.StatusBar.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.StatusBar.ForeColor = System.Drawing.Color.White
        Me.StatusBar.Location = New System.Drawing.Point(0, 356)
        Me.StatusBar.Name = "StatusBar"
        Me.StatusBar.RectColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StatusBar.ShowTimeDate = False
        Me.StatusBar.Size = New System.Drawing.Size(700, 23)
        Me.StatusBar.TabIndex = 11
        Me.StatusBar.Text = "Created By Salt"
        Me.StatusBar.TextColor = System.Drawing.Color.White
        '
        'TypeProxyLabel
        '
        Me.TypeProxyLabel.AutoSize = True
        Me.TypeProxyLabel.BackColor = System.Drawing.Color.Transparent
        Me.TypeProxyLabel.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TypeProxyLabel.ForeColor = System.Drawing.Color.White
        Me.TypeProxyLabel.Location = New System.Drawing.Point(48, 237)
        Me.TypeProxyLabel.Name = "TypeProxyLabel"
        Me.TypeProxyLabel.Size = New System.Drawing.Size(83, 20)
        Me.TypeProxyLabel.TabIndex = 10
        Me.TypeProxyLabel.Text = "Proxy Type:"
        '
        'TypeOfProxy
        '
        Me.TypeOfProxy.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.TypeOfProxy.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TypeOfProxy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.TypeOfProxy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TypeOfProxy.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.TypeOfProxy.ForeColor = System.Drawing.Color.White
        Me.TypeOfProxy.FormattingEnabled = True
        Me.TypeOfProxy.HoverColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TypeOfProxy.ItemHeight = 18
        Me.TypeOfProxy.Items.AddRange(New Object() {"HTTP/S", "SOCKS4", "SOCKS5", "NO PROXY"})
        Me.TypeOfProxy.Location = New System.Drawing.Point(22, 267)
        Me.TypeOfProxy.Name = "TypeOfProxy"
        Me.TypeOfProxy.Size = New System.Drawing.Size(126, 24)
        Me.TypeOfProxy.TabIndex = 9
        '
        'ThreadsLabel
        '
        Me.ThreadsLabel.AutoSize = True
        Me.ThreadsLabel.BackColor = System.Drawing.Color.Transparent
        Me.ThreadsLabel.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ThreadsLabel.ForeColor = System.Drawing.Color.White
        Me.ThreadsLabel.Location = New System.Drawing.Point(53, 173)
        Me.ThreadsLabel.Name = "ThreadsLabel"
        Me.ThreadsLabel.Size = New System.Drawing.Size(64, 20)
        Me.ThreadsLabel.TabIndex = 8
        Me.ThreadsLabel.Text = "Threads:"
        '
        'AmountOfThreads
        '
        Me.AmountOfThreads.BackColor = System.Drawing.Color.Transparent
        Me.AmountOfThreads.FocusOnHover = False
        Me.AmountOfThreads.Location = New System.Drawing.Point(22, 198)
        Me.AmountOfThreads.MaxLength = 32767
        Me.AmountOfThreads.Multiline = False
        Me.AmountOfThreads.Name = "AmountOfThreads"
        Me.AmountOfThreads.ReadOnly = False
        Me.AmountOfThreads.Size = New System.Drawing.Size(126, 29)
        Me.AmountOfThreads.TabIndex = 7
        Me.AmountOfThreads.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.AmountOfThreads.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.AmountOfThreads.UseSystemPasswordChar = False
        '
        'ProxiesLabel
        '
        Me.ProxiesLabel.AutoSize = True
        Me.ProxiesLabel.BackColor = System.Drawing.Color.Transparent
        Me.ProxiesLabel.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProxiesLabel.ForeColor = System.Drawing.Color.White
        Me.ProxiesLabel.Location = New System.Drawing.Point(162, 135)
        Me.ProxiesLabel.Name = "ProxiesLabel"
        Me.ProxiesLabel.Size = New System.Drawing.Size(59, 20)
        Me.ProxiesLabel.TabIndex = 6
        Me.ProxiesLabel.Text = "Proxies:"
        '
        'AccountsLabel
        '
        Me.AccountsLabel.AutoSize = True
        Me.AccountsLabel.BackColor = System.Drawing.Color.Transparent
        Me.AccountsLabel.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AccountsLabel.ForeColor = System.Drawing.Color.White
        Me.AccountsLabel.Location = New System.Drawing.Point(162, 85)
        Me.AccountsLabel.Name = "AccountsLabel"
        Me.AccountsLabel.Size = New System.Drawing.Size(72, 20)
        Me.AccountsLabel.TabIndex = 5
        Me.AccountsLabel.Text = "Accounts:"
        '
        'LoadProxiesButton
        '
        Me.LoadProxiesButton.BackColor = System.Drawing.Color.Transparent
        Me.LoadProxiesButton.BaseColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LoadProxiesButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LoadProxiesButton.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.LoadProxiesButton.Location = New System.Drawing.Point(22, 127)
        Me.LoadProxiesButton.Name = "LoadProxiesButton"
        Me.LoadProxiesButton.Rounded = False
        Me.LoadProxiesButton.Size = New System.Drawing.Size(126, 32)
        Me.LoadProxiesButton.TabIndex = 4
        Me.LoadProxiesButton.Text = "Load Proxies"
        Me.LoadProxiesButton.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatButton1
        '
        Me.FlatButton1.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.FlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton1.Location = New System.Drawing.Point(22, 80)
        Me.FlatButton1.Name = "FlatButton1"
        Me.FlatButton1.Rounded = False
        Me.FlatButton1.Size = New System.Drawing.Size(126, 32)
        Me.FlatButton1.TabIndex = 3
        Me.FlatButton1.Text = "Load Accounts"
        Me.FlatButton1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'Minimize
        '
        Me.Minimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Minimize.BackColor = System.Drawing.Color.White
        Me.Minimize.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Minimize.Font = New System.Drawing.Font("Marlett", 12.0!)
        Me.Minimize.Location = New System.Drawing.Point(645, 12)
        Me.Minimize.Name = "Minimize"
        Me.Minimize.Size = New System.Drawing.Size(18, 18)
        Me.Minimize.TabIndex = 2
        Me.Minimize.Text = "MinimizeWindow"
        Me.Minimize.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'Close
        '
        Me.Close.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Close.BackColor = System.Drawing.Color.White
        Me.Close.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Close.Font = New System.Drawing.Font("Marlett", 10.0!)
        Me.Close.Location = New System.Drawing.Point(669, 17)
        Me.Close.Name = "Close"
        Me.Close.Size = New System.Drawing.Size(18, 18)
        Me.Close.TabIndex = 1
        Me.Close.Text = "CloseWindow"
        Me.Close.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'Timer1
        '
        '
        'NetflixCheckerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 379)
        Me.Controls.Add(Me.FormSkin1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "NetflixCheckerForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Netflix Checker"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.FormSkin1.ResumeLayout(False)
        Me.FormSkin1.PerformLayout()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FormSkin1 As FlatUI.FormSkin
    Friend WithEvents Close As FlatUI.FlatClose
    Friend WithEvents Minimize As FlatUI.FlatMini
    Friend WithEvents TypeProxyLabel As FlatUI.FlatLabel
    Friend WithEvents TypeOfProxy As FlatUI.FlatComboBox
    Friend WithEvents ThreadsLabel As FlatUI.FlatLabel
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents AmountOfThreads As FlatUI.FlatTextBox
    Friend WithEvents ProxiesLabel As FlatUI.FlatLabel
    Friend WithEvents AccountsLabel As FlatUI.FlatLabel
    Friend WithEvents LoadProxiesButton As FlatUI.FlatButton
    Friend WithEvents FlatButton1 As FlatUI.FlatButton
    Friend WithEvents InvalidAccounts As FlatUI.FlatLabel
    Friend WithEvents ValidAmount As FlatUI.FlatLabel
    Friend WithEvents CheckedAmount As FlatUI.FlatLabel
    Friend WithEvents FlatLabel3 As FlatUI.FlatLabel
    Friend WithEvents GoodAccounts As FlatUI.FlatLabel
    Friend WithEvents CheckedLabel As FlatUI.FlatLabel
    Friend WithEvents AmountOfProxies As FlatUI.FlatLabel
    Friend WithEvents AmountOfAccounts As FlatUI.FlatLabel
    Friend WithEvents StartChecking As FlatUI.FlatButton
    Friend WithEvents StatusBar As FlatUI.FlatStatusBar
    Friend WithEvents TopMostToggle As FlatUI.FlatCheckBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents TextBoxResult As RichTextBox
    Friend WithEvents NumericUpDown2 As NumericUpDown
End Class
