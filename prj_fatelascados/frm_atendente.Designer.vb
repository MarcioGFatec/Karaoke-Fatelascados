<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_atendente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_atendente))
        Me.btn_reserva = New System.Windows.Forms.Button()
        Me.btn_consulta = New System.Windows.Forms.Button()
        Me.btn_caixa = New System.Windows.Forms.Button()
        Me.lbl_sair = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'btn_reserva
        '
        Me.btn_reserva.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_reserva.ForeColor = System.Drawing.Color.Indigo
        Me.btn_reserva.Location = New System.Drawing.Point(92, 38)
        Me.btn_reserva.Name = "btn_reserva"
        Me.btn_reserva.Size = New System.Drawing.Size(200, 57)
        Me.btn_reserva.TabIndex = 1
        Me.btn_reserva.Text = "Cadastrar Reserva"
        Me.btn_reserva.UseVisualStyleBackColor = True
        '
        'btn_consulta
        '
        Me.btn_consulta.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_consulta.ForeColor = System.Drawing.Color.Indigo
        Me.btn_consulta.Location = New System.Drawing.Point(92, 145)
        Me.btn_consulta.Name = "btn_consulta"
        Me.btn_consulta.Size = New System.Drawing.Size(200, 57)
        Me.btn_consulta.TabIndex = 2
        Me.btn_consulta.Text = "Consultar Reservas"
        Me.btn_consulta.UseVisualStyleBackColor = True
        '
        'btn_caixa
        '
        Me.btn_caixa.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_caixa.ForeColor = System.Drawing.Color.Indigo
        Me.btn_caixa.Location = New System.Drawing.Point(92, 261)
        Me.btn_caixa.Name = "btn_caixa"
        Me.btn_caixa.Size = New System.Drawing.Size(200, 57)
        Me.btn_caixa.TabIndex = 3
        Me.btn_caixa.Text = "Caixa"
        Me.btn_caixa.UseVisualStyleBackColor = True
        '
        'lbl_sair
        '
        Me.lbl_sair.AutoSize = True
        Me.lbl_sair.BackColor = System.Drawing.Color.Transparent
        Me.lbl_sair.Font = New System.Drawing.Font("Arial", 9.25!)
        Me.lbl_sair.LinkColor = System.Drawing.Color.WhiteSmoke
        Me.lbl_sair.Location = New System.Drawing.Point(128, 350)
        Me.lbl_sair.Name = "lbl_sair"
        Me.lbl_sair.Size = New System.Drawing.Size(104, 16)
        Me.lbl_sair.TabIndex = 4
        Me.lbl_sair.TabStop = True
        Me.lbl_sair.Text = "Encerrar Sessão"
        '
        'frm_atendente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(370, 403)
        Me.Controls.Add(Me.lbl_sair)
        Me.Controls.Add(Me.btn_caixa)
        Me.Controls.Add(Me.btn_consulta)
        Me.Controls.Add(Me.btn_reserva)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_atendente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "KARAOKÊ FATELASCADOS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_reserva As Button
    Friend WithEvents btn_consulta As Button
    Friend WithEvents btn_caixa As Button
    Friend WithEvents lbl_sair As LinkLabel
End Class
