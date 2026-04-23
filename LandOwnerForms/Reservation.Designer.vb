<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class reservationLForm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.LbtnUpcoming = New System.Windows.Forms.Button()
        Me.LbtnCompleted = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LbtnUpcoming
        '
        Me.LbtnUpcoming.BackColor = System.Drawing.Color.Red
        Me.LbtnUpcoming.FlatAppearance.BorderSize = 0
        Me.LbtnUpcoming.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
        Me.LbtnUpcoming.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LbtnUpcoming.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LbtnUpcoming.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LbtnUpcoming.Location = New System.Drawing.Point(416, 42)
        Me.LbtnUpcoming.Name = "LbtnUpcoming"
        Me.LbtnUpcoming.Size = New System.Drawing.Size(106, 39)
        Me.LbtnUpcoming.TabIndex = 81
        Me.LbtnUpcoming.Text = "Upcoming"
        Me.LbtnUpcoming.UseVisualStyleBackColor = False
        '
        'LbtnCompleted
        '
        Me.LbtnCompleted.BackColor = System.Drawing.Color.LimeGreen
        Me.LbtnCompleted.FlatAppearance.BorderSize = 0
        Me.LbtnCompleted.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
        Me.LbtnCompleted.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LbtnCompleted.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LbtnCompleted.ForeColor = System.Drawing.Color.White
        Me.LbtnCompleted.Location = New System.Drawing.Point(537, 42)
        Me.LbtnCompleted.Name = "LbtnCompleted"
        Me.LbtnCompleted.Size = New System.Drawing.Size(106, 39)
        Me.LbtnCompleted.TabIndex = 82
        Me.LbtnCompleted.Text = "Completed"
        Me.LbtnCompleted.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.Location = New System.Drawing.Point(44, 119)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(580, 244)
        Me.DataGridView1.TabIndex = 86
        '
        'btnConfirm
        '
        Me.btnConfirm.BackColor = System.Drawing.Color.LimeGreen
        Me.btnConfirm.FlatAppearance.BorderSize = 0
        Me.btnConfirm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
        Me.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirm.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnConfirm.ForeColor = System.Drawing.Color.White
        Me.btnConfirm.Location = New System.Drawing.Point(379, 292)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(218, 39)
        Me.btnConfirm.TabIndex = 87
        Me.btnConfirm.Text = "CONFIRM RESERVATION"
        Me.btnConfirm.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnConfirm)
        Me.Panel1.Location = New System.Drawing.Point(27, 97)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(616, 350)
        Me.Panel1.TabIndex = 88
        '
        'reservationLForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = Global.FinalProjectOOP.My.Resources.Resource1.DarkerGradient_Background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(673, 490)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LbtnCompleted)
        Me.Controls.Add(Me.LbtnUpcoming)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimumSize = New System.Drawing.Size(673, 490)
        Me.Name = "reservationLForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reservation"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LbtnUpcoming As Button
    Friend WithEvents LbtnCompleted As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnConfirm As Button
    Friend WithEvents Panel1 As Panel
End Class
