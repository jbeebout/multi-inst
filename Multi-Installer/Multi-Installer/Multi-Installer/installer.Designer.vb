<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class installer
    Inherits System.Windows.Forms.Form






    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(installer))
        Me.libre = New System.Windows.Forms.CheckBox()
        Me.ghostscript = New System.Windows.Forms.CheckBox()
        Me.reader = New System.Windows.Forms.CheckBox()
        Me.pdffilter = New System.Windows.Forms.CheckBox()
        Me.zan = New System.Windows.Forms.CheckBox()
        Me.begin = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'libre
        '
        Me.libre.AutoSize = True
        Me.libre.Location = New System.Drawing.Point(56, 52)
        Me.libre.Name = "libre"
        Me.libre.Size = New System.Drawing.Size(77, 17)
        Me.libre.TabIndex = 0
        Me.libre.Text = "LibreOffice"
        Me.libre.UseVisualStyleBackColor = True
        '
        'ghostscript
        '
        Me.ghostscript.AutoSize = True
        Me.ghostscript.Location = New System.Drawing.Point(56, 94)
        Me.ghostscript.Name = "ghostscript"
        Me.ghostscript.Size = New System.Drawing.Size(81, 17)
        Me.ghostscript.TabIndex = 1
        Me.ghostscript.Text = "GhostScript"
        Me.ghostscript.UseVisualStyleBackColor = True
        '
        'reader
        '
        Me.reader.AutoSize = True
        Me.reader.Location = New System.Drawing.Point(56, 132)
        Me.reader.Name = "reader"
        Me.reader.Size = New System.Drawing.Size(92, 17)
        Me.reader.TabIndex = 2
        Me.reader.Text = "AdobeReader"
        Me.reader.UseVisualStyleBackColor = True
        '
        'pdffilter
        '
        Me.pdffilter.AutoSize = True
        Me.pdffilter.Location = New System.Drawing.Point(56, 170)
        Me.pdffilter.Name = "pdffilter"
        Me.pdffilter.Size = New System.Drawing.Size(72, 17)
        Me.pdffilter.TabIndex = 3
        Me.pdffilter.Text = "PDF Filter"
        Me.pdffilter.UseVisualStyleBackColor = True
        '
        'zan
        '
        Me.zan.AutoSize = True
        Me.zan.Location = New System.Drawing.Point(56, 203)
        Me.zan.Name = "zan"
        Me.zan.Size = New System.Drawing.Size(107, 17)
        Me.zan.TabIndex = 4
        Me.zan.Text = "Zan ImagePrinter"
        Me.zan.UseVisualStyleBackColor = True
        '
        'begin
        '
        Me.begin.Location = New System.Drawing.Point(56, 297)
        Me.begin.Name = "begin"
        Me.begin.Size = New System.Drawing.Size(75, 23)
        Me.begin.TabIndex = 5
        Me.begin.Text = "Begin"
        Me.begin.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.begin.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(356, 52)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(417, 168)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'installer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.begin)
        Me.Controls.Add(Me.zan)
        Me.Controls.Add(Me.pdffilter)
        Me.Controls.Add(Me.reader)
        Me.Controls.Add(Me.ghostscript)
        Me.Controls.Add(Me.libre)
        Me.Name = "installer"
        Me.Text = "Multi-Installer"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents libre As Windows.Forms.CheckBox
    Friend WithEvents ghostscript As Windows.Forms.CheckBox
    Friend WithEvents reader As Windows.Forms.CheckBox
    Friend WithEvents pdffilter As Windows.Forms.CheckBox
    Friend WithEvents zan As Windows.Forms.CheckBox
    Friend WithEvents begin As Windows.Forms.Button
    Friend WithEvents PictureBox1 As Windows.Forms.PictureBox
End Class
