<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_consulta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_consulta))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnExcluirReserva = New System.Windows.Forms.Button()
        Me.btnEditarReserva = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnBuscarReserva = New System.Windows.Forms.Button()
        Me.txtQtdePessoas = New System.Windows.Forms.TextBox()
        Me.txtSala = New System.Windows.Forms.TextBox()
        Me.txtEntrada = New System.Windows.Forms.TextBox()
        Me.txtData = New System.Windows.Forms.TextBox()
        Me.txtValorTotal = New System.Windows.Forms.TextBox()
        Me.txtNomeCliente = New System.Windows.Forms.TextBox()
        Me.txtSaida = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtQtdePessoas)
        Me.GroupBox2.Controls.Add(Me.txtSala)
        Me.GroupBox2.Controls.Add(Me.txtEntrada)
        Me.GroupBox2.Controls.Add(Me.txtData)
        Me.GroupBox2.Controls.Add(Me.txtValorTotal)
        Me.GroupBox2.Controls.Add(Me.txtNomeCliente)
        Me.GroupBox2.Controls.Add(Me.txtSaida)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox2.Location = New System.Drawing.Point(57, 114)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(577, 396)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        '
        'btnExcluirReserva
        '
        Me.btnExcluirReserva.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnExcluirReserva.ForeColor = System.Drawing.Color.Indigo
        Me.btnExcluirReserva.Location = New System.Drawing.Point(490, 562)
        Me.btnExcluirReserva.Name = "btnExcluirReserva"
        Me.btnExcluirReserva.Size = New System.Drawing.Size(136, 58)
        Me.btnExcluirReserva.TabIndex = 34
        Me.btnExcluirReserva.Text = "EXCLUIR"
        Me.btnExcluirReserva.UseVisualStyleBackColor = True
        '
        'btnEditarReserva
        '
        Me.btnEditarReserva.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnEditarReserva.ForeColor = System.Drawing.Color.Indigo
        Me.btnEditarReserva.Location = New System.Drawing.Point(276, 562)
        Me.btnEditarReserva.Name = "btnEditarReserva"
        Me.btnEditarReserva.Size = New System.Drawing.Size(136, 62)
        Me.btnEditarReserva.TabIndex = 33
        Me.btnEditarReserva.Text = "EDITAR"
        Me.btnEditarReserva.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.25!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(307, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 19)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Data"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.25!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(66, 278)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 19)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Total"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.25!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(307, 173)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 19)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Saída"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(65, 173)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 19)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Entrada"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(307, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 19)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Sala"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(65, 109)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(194, 19)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Quantidade de Pessoas"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.25!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(65, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(113, 19)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Nome Cliente"
        '
        'btnBuscarReserva
        '
        Me.btnBuscarReserva.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnBuscarReserva.ForeColor = System.Drawing.Color.Indigo
        Me.btnBuscarReserva.Location = New System.Drawing.Point(57, 562)
        Me.btnBuscarReserva.Name = "btnBuscarReserva"
        Me.btnBuscarReserva.Size = New System.Drawing.Size(136, 62)
        Me.btnBuscarReserva.TabIndex = 19
        Me.btnBuscarReserva.Text = "BUSCAR"
        Me.btnBuscarReserva.UseVisualStyleBackColor = True
        '
        'txtQtdePessoas
        '
        Me.txtQtdePessoas.Location = New System.Drawing.Point(70, 130)
        Me.txtQtdePessoas.Margin = New System.Windows.Forms.Padding(2)
        Me.txtQtdePessoas.Name = "txtQtdePessoas"
        Me.txtQtdePessoas.Size = New System.Drawing.Size(199, 25)
        Me.txtQtdePessoas.TabIndex = 11
        '
        'txtSala
        '
        Me.txtSala.Location = New System.Drawing.Point(311, 130)
        Me.txtSala.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSala.Name = "txtSala"
        Me.txtSala.Size = New System.Drawing.Size(199, 25)
        Me.txtSala.TabIndex = 10
        '
        'txtEntrada
        '
        Me.txtEntrada.Location = New System.Drawing.Point(69, 211)
        Me.txtEntrada.Margin = New System.Windows.Forms.Padding(2)
        Me.txtEntrada.Name = "txtEntrada"
        Me.txtEntrada.Size = New System.Drawing.Size(199, 25)
        Me.txtEntrada.TabIndex = 9
        '
        'txtData
        '
        Me.txtData.Location = New System.Drawing.Point(311, 61)
        Me.txtData.Margin = New System.Windows.Forms.Padding(2)
        Me.txtData.Name = "txtData"
        Me.txtData.Size = New System.Drawing.Size(199, 25)
        Me.txtData.TabIndex = 8
        '
        'txtValorTotal
        '
        Me.txtValorTotal.Location = New System.Drawing.Point(70, 299)
        Me.txtValorTotal.Margin = New System.Windows.Forms.Padding(2)
        Me.txtValorTotal.Name = "txtValorTotal"
        Me.txtValorTotal.Size = New System.Drawing.Size(199, 25)
        Me.txtValorTotal.TabIndex = 7
        '
        'txtNomeCliente
        '
        Me.txtNomeCliente.Location = New System.Drawing.Point(69, 61)
        Me.txtNomeCliente.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNomeCliente.Name = "txtNomeCliente"
        Me.txtNomeCliente.Size = New System.Drawing.Size(199, 25)
        Me.txtNomeCliente.TabIndex = 6
        '
        'txtSaida
        '
        Me.txtSaida.Location = New System.Drawing.Point(311, 211)
        Me.txtSaida.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSaida.Name = "txtSaida"
        Me.txtSaida.Size = New System.Drawing.Size(199, 25)
        Me.txtSaida.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.Window
        Me.Label8.Location = New System.Drawing.Point(188, 52)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(300, 29)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "CONSULTA DE RESERVA"
        '
        'frm_consulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(665, 667)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnExcluirReserva)
        Me.Controls.Add(Me.btnEditarReserva)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnBuscarReserva)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_consulta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "KARAOKÊ FATELASCADOS"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtQtdePessoas As TextBox
    Friend WithEvents txtSala As TextBox
    Friend WithEvents txtEntrada As TextBox
    Friend WithEvents txtData As TextBox
    Friend WithEvents txtValorTotal As TextBox
    Friend WithEvents txtNomeCliente As TextBox
    Friend WithEvents txtSaida As TextBox
    Friend WithEvents btnBuscarReserva As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnExcluirReserva As Button
    Friend WithEvents btnEditarReserva As Button
    Friend WithEvents Label8 As Label
End Class
