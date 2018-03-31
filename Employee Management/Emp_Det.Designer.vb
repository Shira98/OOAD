<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Emp_Det
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
        Dim TableLayoutPanel As System.Windows.Forms.TableLayoutPanel
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        TableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        TableLayoutPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel
        '
        TableLayoutPanel.ColumnCount = 5
        TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.46626!))
        TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.53374!))
        TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 166.0!))
        TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 166.0!))
        TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 137.0!))
        TableLayoutPanel.Controls.Add(Me.Label1, 0, 0)
        TableLayoutPanel.Controls.Add(Me.Label3, 3, 0)
        TableLayoutPanel.Controls.Add(Me.Label4, 2, 0)
        TableLayoutPanel.Controls.Add(Me.Label5, 4, 0)
        TableLayoutPanel.Controls.Add(Me.Label6, 0, 1)
        TableLayoutPanel.Controls.Add(Me.Label2, 1, 0)
        TableLayoutPanel.Controls.Add(Me.Label7, 1, 1)
        TableLayoutPanel.Controls.Add(Me.Label9, 3, 1)
        TableLayoutPanel.Controls.Add(Me.Label10, 4, 1)
        TableLayoutPanel.Controls.Add(Me.Label8, 2, 1)
        TableLayoutPanel.ForeColor = System.Drawing.Color.Cyan
        TableLayoutPanel.Location = New System.Drawing.Point(14, 164)
        TableLayoutPanel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        TableLayoutPanel.Name = "TableLayoutPanel"
        TableLayoutPanel.RowCount = 2
        TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 122.0!))
        TableLayoutPanel.Size = New System.Drawing.Size(852, 194)
        TableLayoutPanel.TabIndex = 0
        'AddHandler TableLayoutPanel.Paint, AddressOf Me.TableLayoutPanel1_Paint
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(43, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Branch:"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(580, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 54)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Material Selection"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(386, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(158, 27)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Design (2D/3D)"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(730, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 27)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Handover"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(28, 79)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(129, 108)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "No. of Employees Under Each Branch:"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(190, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(187, 27)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Conceptualization"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(195, 79)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(182, 108)
        Me.Label7.TabIndex = 3
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(398, 87)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(132, 89)
        Me.Label8.TabIndex = 4
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(565, 88)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(132, 89)
        Me.Label9.TabIndex = 5
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(730, 90)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(106, 81)
        Me.Label10.TabIndex = 6
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Emp_Det
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 562)
        Me.Controls.Add(TableLayoutPanel)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Emp_Det"
        Me.Text = "Form4"
        TableLayoutPanel.ResumeLayout(False)
        TableLayoutPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
End Class
