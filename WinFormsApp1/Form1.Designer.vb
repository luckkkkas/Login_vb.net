<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class telaLogin
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
        ProgressBar1 = New ProgressBar()
        btnLogin = New Button()
        btnCadastrar = New Button()
        Label1 = New Label()
        Label2 = New Label()
        CheckBox1 = New CheckBox()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        SuspendLayout()
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Location = New Point(45, 397)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(696, 29)
        ProgressBar1.TabIndex = 0
        ' 
        ' btnLogin
        ' 
        btnLogin.Location = New Point(505, 275)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(178, 50)
        btnLogin.TabIndex = 1
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' btnCadastrar
        ' 
        btnCadastrar.Location = New Point(170, 275)
        btnCadastrar.Name = "btnCadastrar"
        btnCadastrar.Size = New Size(177, 50)
        btnCadastrar.TabIndex = 2
        btnCadastrar.Text = "Cadastrar"
        btnCadastrar.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(59, 70)
        Label1.Name = "Label1"
        Label1.Size = New Size(122, 20)
        Label1.TabIndex = 3
        Label1.Text = "usuário ou email:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(129, 133)
        Label2.Name = "Label2"
        Label2.Size = New Size(52, 20)
        Label2.TabIndex = 4
        Label2.Text = "Senha:"
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(369, 198)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(86, 24)
        CheckBox1.TabIndex = 5
        CheckBox1.Text = "Lembrar"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.BorderStyle = BorderStyle.FixedSingle
        TextBox1.Location = New Point(212, 67)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(471, 27)
        TextBox1.TabIndex = 6
        ' 
        ' TextBox2
        ' 
        TextBox2.AutoCompleteMode = AutoCompleteMode.Suggest
        TextBox2.BorderStyle = BorderStyle.FixedSingle
        TextBox2.HideSelection = False
        TextBox2.ImeMode = ImeMode.Disable
        TextBox2.Location = New Point(212, 133)
        TextBox2.Name = "TextBox2"
        TextBox2.PasswordChar = "*"c
        TextBox2.Size = New Size(471, 27)
        TextBox2.TabIndex = 7
        ' 
        ' telaLogin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(792, 484)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(CheckBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnCadastrar)
        Controls.Add(btnLogin)
        Controls.Add(ProgressBar1)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "telaLogin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnCadastrar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox

End Class
