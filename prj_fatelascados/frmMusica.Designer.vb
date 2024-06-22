<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMusica
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMusica))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtGenMusical = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCantor = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDuracao = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtMusica = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.bntMusica = New System.Windows.Forms.Button()
        Me.btnExcluirMusica = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnBuscarMusica = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Window
        Me.Label1.Location = New System.Drawing.Point(85, 193)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(310, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "GERENCIAR MÚSICAS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(52, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ID MÚSICA:"
        '
        'txtId
        '
        Me.txtId.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtId.Location = New System.Drawing.Point(55, 77)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(106, 25)
        Me.txtId.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txtGenMusical)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtCantor)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtDuracao)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtMusica)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtId)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(44, 251)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(419, 317)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'txtGenMusical
        '
        Me.txtGenMusical.Font = New System.Drawing.Font("Arial Narrow", 11.25!)
        Me.txtGenMusical.Location = New System.Drawing.Point(51, 262)
        Me.txtGenMusical.Name = "txtGenMusical"
        Me.txtGenMusical.Size = New System.Drawing.Size(146, 25)
        Me.txtGenMusical.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(48, 221)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(149, 18)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "GÊNERO MUSICAL:"
        '
        'txtCantor
        '
        Me.txtCantor.Font = New System.Drawing.Font("Arial Narrow", 11.25!)
        Me.txtCantor.Location = New System.Drawing.Point(55, 166)
        Me.txtCantor.Name = "txtCantor"
        Me.txtCantor.Size = New System.Drawing.Size(106, 25)
        Me.txtCantor.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(52, 133)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 18)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "CANTOR:"
        '
        'txtDuracao
        '
        Me.txtDuracao.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtDuracao.Font = New System.Drawing.Font("Arial Narrow", 11.25!)
        Me.txtDuracao.Location = New System.Drawing.Point(215, 166)
        Me.txtDuracao.Name = "txtDuracao"
        Me.txtDuracao.Size = New System.Drawing.Size(106, 25)
        Me.txtDuracao.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(213, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 18)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "DURAÇÃO:"
        '
        'txtMusica
        '
        Me.txtMusica.Font = New System.Drawing.Font("Arial Narrow", 11.25!)
        Me.txtMusica.Location = New System.Drawing.Point(215, 77)
        Me.txtMusica.Name = "txtMusica"
        Me.txtMusica.Size = New System.Drawing.Size(186, 25)
        Me.txtMusica.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(213, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 18)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "MÚSICA:"
        '
        'bntMusica
        '
        Me.bntMusica.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.bntMusica.ForeColor = System.Drawing.Color.Indigo
        Me.bntMusica.Location = New System.Drawing.Point(46, 596)
        Me.bntMusica.Name = "bntMusica"
        Me.bntMusica.Size = New System.Drawing.Size(118, 57)
        Me.bntMusica.TabIndex = 7
        Me.bntMusica.Text = "Cadastrar"
        Me.bntMusica.UseVisualStyleBackColor = True
        '
        'btnExcluirMusica
        '
        Me.btnExcluirMusica.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnExcluirMusica.ForeColor = System.Drawing.Color.Indigo
        Me.btnExcluirMusica.Location = New System.Drawing.Point(345, 596)
        Me.btnExcluirMusica.Name = "btnExcluirMusica"
        Me.btnExcluirMusica.Size = New System.Drawing.Size(118, 57)
        Me.btnExcluirMusica.TabIndex = 8
        Me.btnExcluirMusica.Text = "Excluir"
        Me.btnExcluirMusica.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(171, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(152, 161)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'btnBuscarMusica
        '
        Me.btnBuscarMusica.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnBuscarMusica.ForeColor = System.Drawing.Color.Indigo
        Me.btnBuscarMusica.Location = New System.Drawing.Point(195, 596)
        Me.btnBuscarMusica.Name = "btnBuscarMusica"
        Me.btnBuscarMusica.Size = New System.Drawing.Size(118, 57)
        Me.btnBuscarMusica.TabIndex = 10
        Me.btnBuscarMusica.Text = "Buscar"
        Me.btnBuscarMusica.UseVisualStyleBackColor = True
        '
        'frmMusica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(508, 697)
        Me.Controls.Add(Me.btnBuscarMusica)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnExcluirMusica)
        Me.Controls.Add(Me.bntMusica)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMusica"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "KARAOKÊ FATELASCADOS"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtCantor As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtDuracao As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtMusica As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtGenMusical As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents bntMusica As Button
    Friend WithEvents btnExcluirMusica As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnBuscarMusica As Button
End Class
