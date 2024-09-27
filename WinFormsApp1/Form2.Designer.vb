<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        TextBox6 = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        btnCadastar = New Button()
        btnCancelar = New Button()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(136, 63)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(585, 27)
        TextBox1.TabIndex = 0
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(136, 122)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(585, 27)
        TextBox2.TabIndex = 1
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(136, 181)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(585, 27)
        TextBox3.TabIndex = 2
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(136, 235)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(585, 27)
        TextBox4.TabIndex = 3
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(136, 301)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(585, 27)
        TextBox5.TabIndex = 4
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(136, 372)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(585, 27)
        TextBox6.TabIndex = 5
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 66)
        Label1.Name = "Label1"
        Label1.Size = New Size(121, 20)
        Label1.TabIndex = 6
        Label1.Text = "Nome completo:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(84, 129)
        Label2.Name = "Label2"
        Label2.Size = New Size(49, 20)
        Label2.TabIndex = 7
        Label2.Text = "email:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(70, 188)
        Label3.Name = "Label3"
        Label3.Size = New Size(60, 20)
        Label3.TabIndex = 8
        Label3.Text = "usuário:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(78, 238)
        Label4.Name = "Label4"
        Label4.Size = New Size(52, 20)
        Label4.TabIndex = 9
        Label4.Text = "Senha:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(6, 308)
        Label5.Name = "Label5"
        Label5.Size = New Size(124, 20)
        Label5.TabIndex = 10
        Label5.Text = "Confirme a senha"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(59, 379)
        Label6.Name = "Label6"
        Label6.Size = New Size(71, 20)
        Label6.TabIndex = 11
        Label6.Text = "endereço"
        ' 
        ' btnCadastar
        ' 
        btnCadastar.Location = New Point(687, 408)
        btnCadastar.Name = "btnCadastar"
        btnCadastar.Size = New Size(94, 29)
        btnCadastar.TabIndex = 12
        btnCadastar.Text = "Cadastrar"
        btnCadastar.UseVisualStyleBackColor = True
        ' 
        ' btnCancelar
        ' 
        btnCancelar.Location = New Point(574, 409)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(94, 29)
        btnCancelar.TabIndex = 13
        btnCancelar.Text = "Cancelar"
        btnCancelar.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnCancelar)
        Controls.Add(btnCadastar)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(TextBox6)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Name = "Form2"
        Text = "frmCadastro"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnCadastar As Button
    Friend WithEvents btnCancelar As Button
End Class
