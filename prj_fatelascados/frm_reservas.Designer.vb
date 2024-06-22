<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_reservas
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_reservas))
        Me.dtpSaida = New System.Windows.Forms.DateTimePicker()
        Me.dtpEntrada = New System.Windows.Forms.DateTimePicker()
        Me.txtNomeCliente = New System.Windows.Forms.TextBox()
        Me.cmbQuantidadePessoas = New System.Windows.Forms.ComboBox()
        Me.btnReservar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtpDataReserva = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbSalas = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtpSaida
        '
        Me.dtpSaida.Location = New System.Drawing.Point(329, 300)
        Me.dtpSaida.Name = "dtpSaida"
        Me.dtpSaida.Size = New System.Drawing.Size(200, 24)
        Me.dtpSaida.TabIndex = 14
        '
        'dtpEntrada
        '
        Me.dtpEntrada.Location = New System.Drawing.Point(66, 300)
        Me.dtpEntrada.Name = "dtpEntrada"
        Me.dtpEntrada.Size = New System.Drawing.Size(200, 24)
        Me.dtpEntrada.TabIndex = 15
        '
        'txtNomeCliente
        '
        Me.txtNomeCliente.Location = New System.Drawing.Point(328, 119)
        Me.txtNomeCliente.Name = "txtNomeCliente"
        Me.txtNomeCliente.Size = New System.Drawing.Size(261, 24)
        Me.txtNomeCliente.TabIndex = 16
        '
        'cmbQuantidadePessoas
        '
        Me.cmbQuantidadePessoas.FormattingEnabled = True
        Me.cmbQuantidadePessoas.Items.AddRange(New Object() {"10", "20", "30", "40", "50"})
        Me.cmbQuantidadePessoas.Location = New System.Drawing.Point(66, 212)
        Me.cmbQuantidadePessoas.Name = "cmbQuantidadePessoas"
        Me.cmbQuantidadePessoas.Size = New System.Drawing.Size(184, 24)
        Me.cmbQuantidadePessoas.TabIndex = 17
        '
        'btnReservar
        '
        Me.btnReservar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnReservar.ForeColor = System.Drawing.Color.Indigo
        Me.btnReservar.Location = New System.Drawing.Point(209, 393)
        Me.btnReservar.Name = "btnReservar"
        Me.btnReservar.Size = New System.Drawing.Size(154, 51)
        Me.btnReservar.TabIndex = 18
        Me.btnReservar.Text = "RESERVA"
        Me.btnReservar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.dtpDataReserva)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cmbSalas)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtNomeCliente)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmbQuantidadePessoas)
        Me.GroupBox1.Controls.Add(Me.btnReservar)
        Me.GroupBox1.Controls.Add(Me.dtpEntrada)
        Me.GroupBox1.Controls.Add(Me.dtpSaida)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Location = New System.Drawing.Point(45, 51)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(608, 465)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.25!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(62, 81)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(166, 19)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "DATA DA RESERVA:"
        '
        'dtpDataReserva
        '
        Me.dtpDataReserva.Location = New System.Drawing.Point(65, 119)
        Me.dtpDataReserva.Name = "dtpDataReserva"
        Me.dtpDataReserva.Size = New System.Drawing.Size(222, 24)
        Me.dtpDataReserva.TabIndex = 25
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.25!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(335, 178)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 19)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "SALA:"
        '
        'cmbSalas
        '
        Me.cmbSalas.FormattingEnabled = True
        Me.cmbSalas.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30"})
        Me.cmbSalas.Location = New System.Drawing.Point(329, 212)
        Me.cmbSalas.Name = "cmbSalas"
        Me.cmbSalas.Size = New System.Drawing.Size(184, 24)
        Me.cmbSalas.TabIndex = 23
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.25!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(63, 178)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(207, 19)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "QUANTIDADE PESSOAS:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(334, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(169, 19)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "NOME DO CLIENTE:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(336, 260)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 19)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "SAÍDA:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(64, 260)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ENTRADA:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label7.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(198, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(324, 32)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "CADASTRAR RESERVA"
        '
        'frm_reservas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(706, 556)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.SystemColors.Control
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_reservas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "KARAOKÊ FATELASCADOS"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtpSaida As DateTimePicker
    Friend WithEvents dtpEntrada As DateTimePicker
    Friend WithEvents txtNomeCliente As TextBox
    Friend WithEvents cmbQuantidadePessoas As ComboBox
    Friend WithEvents btnReservar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbSalas As ComboBox
    Friend WithEvents dtpDataReserva As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
End Class
