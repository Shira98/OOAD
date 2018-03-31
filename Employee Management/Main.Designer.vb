<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Dim BEmpDeets As System.Windows.Forms.Button
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.LDateTime = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BLogin = New System.Windows.Forms.Button()
        BEmpDeets = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BEmpDeets
        '
        BEmpDeets.Anchor = System.Windows.Forms.AnchorStyles.None
        BEmpDeets.BackColor = System.Drawing.Color.Transparent
        BEmpDeets.Cursor = System.Windows.Forms.Cursors.Hand
        BEmpDeets.DialogResult = System.Windows.Forms.DialogResult.Yes
        BEmpDeets.FlatAppearance.BorderSize = 0
        BEmpDeets.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        BEmpDeets.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BEmpDeets.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        BEmpDeets.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        BEmpDeets.Location = New System.Drawing.Point(90, 321)
        BEmpDeets.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        BEmpDeets.Name = "BEmpDeets"
        BEmpDeets.Size = New System.Drawing.Size(202, 65)
        BEmpDeets.TabIndex = 0
        BEmpDeets.Text = "Employee Details"
        BEmpDeets.UseVisualStyleBackColor = False
        AddHandler BEmpDeets.Click, AddressOf Me.Button1_Click
        '
        'LDateTime
        '
        Me.LDateTime.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LDateTime.AutoSize = True
        Me.LDateTime.BackColor = System.Drawing.Color.Transparent
        Me.LDateTime.Font = New System.Drawing.Font("Comic Sans MS", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LDateTime.Location = New System.Drawing.Point(14, 149)
        Me.LDateTime.Name = "LDateTime"
        Me.LDateTime.Size = New System.Drawing.Size(186, 45)
        Me.LDateTime.TabIndex = 2
        Me.LDateTime.Text = "Date Time"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'BLogin
        '
        Me.BLogin.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BLogin.AutoEllipsis = True
        Me.BLogin.BackColor = System.Drawing.Color.Transparent
        Me.BLogin.BackgroundImage = CType(resources.GetObject("BLogin.BackgroundImage"), System.Drawing.Image)
        Me.BLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BLogin.FlatAppearance.BorderSize = 0
        Me.BLogin.Location = New System.Drawing.Point(390, 321)
        Me.BLogin.Margin = New System.Windows.Forms.Padding(0)
        Me.BLogin.Name = "BLogin"
        Me.BLogin.Size = New System.Drawing.Size(66, 65)
        Me.BLogin.TabIndex = 1
        Me.BLogin.Text = "\"
        Me.BLogin.UseVisualStyleBackColor = False
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(626, 495)
        Me.Controls.Add(Me.LDateTime)
        Me.Controls.Add(Me.BLogin)
        Me.Controls.Add(BEmpDeets)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Main"
        Me.Text = "Company Page"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LDateTime As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents BLogin As Button
End Class
