<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class kasir
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.kode_struk = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.total_harga = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Chartreuse
        Me.Button2.Location = New System.Drawing.Point(12, 6)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(111, 33)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "Generate"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'kode_struk
        '
        Me.kode_struk.Location = New System.Drawing.Point(12, 45)
        Me.kode_struk.Multiline = True
        Me.kode_struk.Name = "kode_struk"
        Me.kode_struk.Size = New System.Drawing.Size(111, 45)
        Me.kode_struk.TabIndex = 11
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(102, 162)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(990, 316)
        Me.DataGridView1.TabIndex = 21
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.DarkCyan
        Me.Button6.Location = New System.Drawing.Point(146, 6)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(169, 33)
        Me.Button6.TabIndex = 23
        Me.Button6.Text = "Pembayaran"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'total_harga
        '
        Me.total_harga.Location = New System.Drawing.Point(146, 45)
        Me.total_harga.Multiline = True
        Me.total_harga.Name = "total_harga"
        Me.total_harga.Size = New System.Drawing.Size(169, 45)
        Me.total_harga.TabIndex = 13
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkCyan
        Me.Button1.Location = New System.Drawing.Point(923, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(169, 33)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "Refresh"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'kasir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1145, 490)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.total_harga)
        Me.Controls.Add(Me.kode_struk)
        Me.Name = "kasir"
        Me.Text = "form2"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents kode_struk As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents total_harga As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
