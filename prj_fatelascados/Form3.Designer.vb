<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.btn_cadastro_funcionario = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_cadastro_funcionario
        '
        Me.btn_cadastro_funcionario.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btn_cadastro_funcionario.ForeColor = System.Drawing.Color.Indigo
        Me.btn_cadastro_funcionario.Location = New System.Drawing.Point(73, 37)
        Me.btn_cadastro_funcionario.Name = "btn_cadastro_funcionario"
        Me.btn_cadastro_funcionario.Size = New System.Drawing.Size(200, 57)
        Me.btn_cadastro_funcionario.TabIndex = 0
        Me.btn_cadastro_funcionario.Text = "Cadastrar Funcionário"
        Me.btn_cadastro_funcionario.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Button2.ForeColor = System.Drawing.Color.Indigo
        Me.Button2.Location = New System.Drawing.Point(73, 131)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(200, 57)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Relatório de Movimento"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Button3.ForeColor = System.Drawing.Color.Indigo
        Me.Button3.Location = New System.Drawing.Point(73, 240)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(200, 57)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Gerenciar Músicas"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(323, 356)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btn_cadastro_funcionario)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_cadastro_funcionario As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
