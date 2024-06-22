<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CaixaForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CaixaForm))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ButtonBuscar = New System.Windows.Forms.Button()
        Me.textBoxQtdePessoas = New System.Windows.Forms.TextBox()
        Me.ButtonConfirmarPagamento = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.textBoxTempoReserva = New System.Windows.Forms.TextBox()
        Me.textBoxSalaReservada = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.textBoxValorPagar = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.textBoxNomeCliente = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.ButtonBuscar)
        Me.GroupBox1.Controls.Add(Me.textBoxQtdePessoas)
        Me.GroupBox1.Controls.Add(Me.ButtonConfirmarPagamento)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.textBoxTempoReserva)
        Me.GroupBox1.Controls.Add(Me.textBoxSalaReservada)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.textBoxValorPagar)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.textBoxNomeCliente)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox1.Location = New System.Drawing.Point(45, 71)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(550, 409)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        '
        'ButtonBuscar
        '
        Me.ButtonBuscar.BackColor = System.Drawing.Color.Transparent
        Me.ButtonBuscar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ButtonBuscar.ForeColor = System.Drawing.Color.Indigo
        Me.ButtonBuscar.Location = New System.Drawing.Point(287, 333)
        Me.ButtonBuscar.Name = "ButtonBuscar"
        Me.ButtonBuscar.Size = New System.Drawing.Size(126, 54)
        Me.ButtonBuscar.TabIndex = 15
        Me.ButtonBuscar.Text = "BUSCAR"
        Me.ButtonBuscar.UseVisualStyleBackColor = False
        '
        'textBoxQtdePessoas
        '
        Me.textBoxQtdePessoas.Location = New System.Drawing.Point(299, 179)
        Me.textBoxQtdePessoas.Margin = New System.Windows.Forms.Padding(2)
        Me.textBoxQtdePessoas.Name = "textBoxQtdePessoas"
        Me.textBoxQtdePessoas.Size = New System.Drawing.Size(155, 24)
        Me.textBoxQtdePessoas.TabIndex = 27
        '
        'ButtonConfirmarPagamento
        '
        Me.ButtonConfirmarPagamento.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ButtonConfirmarPagamento.ForeColor = System.Drawing.Color.Indigo
        Me.ButtonConfirmarPagamento.Location = New System.Drawing.Point(99, 333)
        Me.ButtonConfirmarPagamento.Name = "ButtonConfirmarPagamento"
        Me.ButtonConfirmarPagamento.Size = New System.Drawing.Size(126, 54)
        Me.ButtonConfirmarPagamento.TabIndex = 16
        Me.ButtonConfirmarPagamento.Text = "PAGAMENTO"
        Me.ButtonConfirmarPagamento.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.Location = New System.Drawing.Point(295, 141)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(207, 19)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "QUANTIDADE PESSOAS:"
        '
        'textBoxTempoReserva
        '
        Me.textBoxTempoReserva.Location = New System.Drawing.Point(79, 180)
        Me.textBoxTempoReserva.Margin = New System.Windows.Forms.Padding(2)
        Me.textBoxTempoReserva.Name = "textBoxTempoReserva"
        Me.textBoxTempoReserva.Size = New System.Drawing.Size(146, 24)
        Me.textBoxTempoReserva.TabIndex = 26
        '
        'textBoxSalaReservada
        '
        Me.textBoxSalaReservada.Location = New System.Drawing.Point(313, 76)
        Me.textBoxSalaReservada.Margin = New System.Windows.Forms.Padding(2)
        Me.textBoxSalaReservada.Name = "textBoxSalaReservada"
        Me.textBoxSalaReservada.Size = New System.Drawing.Size(102, 24)
        Me.textBoxSalaReservada.TabIndex = 25
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.25!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label7.Location = New System.Drawing.Point(309, 42)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 19)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "SALA:"
        '
        'textBoxValorPagar
        '
        Me.textBoxValorPagar.Location = New System.Drawing.Point(79, 262)
        Me.textBoxValorPagar.Margin = New System.Windows.Forms.Padding(2)
        Me.textBoxValorPagar.Name = "textBoxValorPagar"
        Me.textBoxValorPagar.Size = New System.Drawing.Size(139, 24)
        Me.textBoxValorPagar.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.25!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label6.Location = New System.Drawing.Point(74, 141)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 19)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "TEMPO:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.25!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label5.Location = New System.Drawing.Point(74, 241)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(144, 19)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "TOTAL A PAGAR:"
        '
        'textBoxNomeCliente
        '
        Me.textBoxNomeCliente.Location = New System.Drawing.Point(79, 76)
        Me.textBoxNomeCliente.Margin = New System.Windows.Forms.Padding(2)
        Me.textBoxNomeCliente.Name = "textBoxNomeCliente"
        Me.textBoxNomeCliente.Size = New System.Drawing.Size(199, 24)
        Me.textBoxNomeCliente.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label2.Location = New System.Drawing.Point(75, 42)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "NOME CLIENTE:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Window
        Me.Label3.Location = New System.Drawing.Point(270, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 32)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "CAIXA"
        '
        'CaixaForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(647, 508)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CaixaForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "KARAOKÊ FATELASCADOS"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ButtonBuscar As Button
    Friend WithEvents ButtonConfirmarPagamento As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents textBoxTempoReserva As TextBox
    Friend WithEvents textBoxSalaReservada As TextBox
    Friend WithEvents textBoxQtdePessoas As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents textBoxValorPagar As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents textBoxNomeCliente As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
