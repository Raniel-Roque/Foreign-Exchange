<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ForExMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ForExMain))
        Me.FromCurrency = New System.Windows.Forms.ComboBox()
        Me.ToCurrency = New System.Windows.Forms.ComboBox()
        Me.FromInput = New System.Windows.Forms.TextBox()
        Me.ToAnswer = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ForeignExchangeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Switch = New System.Windows.Forms.Button()
        Me.ToPic = New System.Windows.Forms.PictureBox()
        Me.FromPic = New System.Windows.Forms.PictureBox()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.ToPic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FromPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FromCurrency
        '
        Me.FromCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.FromCurrency.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FromCurrency.FormattingEnabled = True
        Me.FromCurrency.Items.AddRange(New Object() {"Australian Dollar (AUD)", "Bahraini Dinar (BHD)", "Chinese Yuan (CNY)", "Euro (EUR)", "Indian Rupee (INR)", "Japanese Yen (JPY)", "Kuwaiti Dinar (KWD)", "Omani Rial (OMR)", "Philippine Peso (PHP)", "US Dollar (USD)"})
        Me.FromCurrency.Location = New System.Drawing.Point(12, 54)
        Me.FromCurrency.Name = "FromCurrency"
        Me.FromCurrency.Size = New System.Drawing.Size(249, 28)
        Me.FromCurrency.TabIndex = 0
        '
        'ToCurrency
        '
        Me.ToCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ToCurrency.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToCurrency.FormattingEnabled = True
        Me.ToCurrency.Items.AddRange(New Object() {"Australian Dollar (AUD)", "Bahraini Dinar (BHD)", "Chinese Yuan (CNY)", "Euro (EUR)", "Indian Rupee (INR)", "Japanese Yen (JPY)", "Kuwaiti Dinar (KWD)", "Omani Rial (OMR)", "Philippine Peso (PHP)", "US Dollar (USD)"})
        Me.ToCurrency.Location = New System.Drawing.Point(330, 55)
        Me.ToCurrency.Name = "ToCurrency"
        Me.ToCurrency.Size = New System.Drawing.Size(249, 28)
        Me.ToCurrency.TabIndex = 1
        '
        'FromInput
        '
        Me.FromInput.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FromInput.Location = New System.Drawing.Point(12, 98)
        Me.FromInput.MaxLength = 20
        Me.FromInput.Name = "FromInput"
        Me.FromInput.Size = New System.Drawing.Size(249, 27)
        Me.FromInput.TabIndex = 2
        '
        'ToAnswer
        '
        Me.ToAnswer.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToAnswer.Location = New System.Drawing.Point(330, 98)
        Me.ToAnswer.Name = "ToAnswer"
        Me.ToAnswer.ReadOnly = True
        Me.ToAnswer.Size = New System.Drawing.Size(249, 27)
        Me.ToAnswer.TabIndex = 3
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem, Me.ForeignExchangeToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Margin = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(6)
        Me.MenuStrip1.Size = New System.Drawing.Size(595, 36)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ForeignExchangeToolStripMenuItem
        '
        Me.ForeignExchangeToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeignExchangeToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ForeignExchangeToolStripMenuItem.Name = "ForeignExchangeToolStripMenuItem"
        Me.ForeignExchangeToolStripMenuItem.Size = New System.Drawing.Size(144, 24)
        Me.ForeignExchangeToolStripMenuItem.Text = "Foreign Exchange"
        '
        'Switch
        '
        Me.Switch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Switch.FlatAppearance.BorderSize = 0
        Me.Switch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Switch.Image = Global.Foreign_Exchange.My.Resources.Resources.Arrow
        Me.Switch.Location = New System.Drawing.Point(267, 64)
        Me.Switch.Name = "Switch"
        Me.Switch.Size = New System.Drawing.Size(57, 50)
        Me.Switch.TabIndex = 7
        Me.Switch.UseVisualStyleBackColor = True
        '
        'ToPic
        '
        Me.ToPic.Location = New System.Drawing.Point(330, 139)
        Me.ToPic.Name = "ToPic"
        Me.ToPic.Size = New System.Drawing.Size(249, 114)
        Me.ToPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ToPic.TabIndex = 6
        Me.ToPic.TabStop = False
        '
        'FromPic
        '
        Me.FromPic.Location = New System.Drawing.Point(12, 139)
        Me.FromPic.Name = "FromPic"
        Me.FromPic.Size = New System.Drawing.Size(249, 114)
        Me.FromPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.FromPic.TabIndex = 5
        Me.FromPic.TabStop = False
        '
        'HomeToolStripMenuItem
        '
        Me.HomeToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.HomeToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.HomeToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.HomeToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.HomeToolStripMenuItem.Image = CType(resources.GetObject("HomeToolStripMenuItem.Image"), System.Drawing.Image)
        Me.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        Me.HomeToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.HomeToolStripMenuItem.Size = New System.Drawing.Size(28, 24)
        '
        'ForExMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(595, 267)
        Me.Controls.Add(Me.Switch)
        Me.Controls.Add(Me.ToPic)
        Me.Controls.Add(Me.FromPic)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.ToAnswer)
        Me.Controls.Add(Me.FromInput)
        Me.Controls.Add(Me.ToCurrency)
        Me.Controls.Add(Me.FromCurrency)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ForExMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Foreign Exchange"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.ToPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FromPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FromCurrency As ComboBox
    Friend WithEvents ToCurrency As ComboBox
    Friend WithEvents FromInput As TextBox
    Friend WithEvents ToAnswer As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ForeignExchangeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FromPic As PictureBox
    Friend WithEvents ToPic As PictureBox
    Friend WithEvents Switch As Button
End Class
