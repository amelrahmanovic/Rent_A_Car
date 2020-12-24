<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxUsername = New System.Windows.Forms.TextBox()
        Me.TextBoxPassword = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ButtonLogin = New System.Windows.Forms.Button()
        Me.ButtonRegistracija = New System.Windows.Forms.Button()
        Me.TextBoxPrezime = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxIme = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxUsernameRegister = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LabelPoruka = New System.Windows.Forms.Label()
        Me.TextBoxPasswordRegister = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username:"
        '
        'TextBoxUsername
        '
        Me.TextBoxUsername.Location = New System.Drawing.Point(80, 12)
        Me.TextBoxUsername.Name = "TextBoxUsername"
        Me.TextBoxUsername.Size = New System.Drawing.Size(133, 23)
        Me.TextBoxUsername.TabIndex = 1
        '
        'TextBoxPassword
        '
        Me.TextBoxPassword.Location = New System.Drawing.Point(80, 41)
        Me.TextBoxPassword.Name = "TextBoxPassword"
        Me.TextBoxPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxPassword.Size = New System.Drawing.Size(133, 23)
        Me.TextBoxPassword.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Password:"
        '
        'ButtonLogin
        '
        Me.ButtonLogin.Location = New System.Drawing.Point(138, 70)
        Me.ButtonLogin.Name = "ButtonLogin"
        Me.ButtonLogin.Size = New System.Drawing.Size(75, 23)
        Me.ButtonLogin.TabIndex = 4
        Me.ButtonLogin.Text = "Login"
        Me.ButtonLogin.UseVisualStyleBackColor = True
        '
        'ButtonRegistracija
        '
        Me.ButtonRegistracija.Location = New System.Drawing.Point(368, 127)
        Me.ButtonRegistracija.Name = "ButtonRegistracija"
        Me.ButtonRegistracija.Size = New System.Drawing.Size(75, 23)
        Me.ButtonRegistracija.TabIndex = 5
        Me.ButtonRegistracija.Text = "Registracija"
        Me.ButtonRegistracija.UseVisualStyleBackColor = True
        '
        'TextBoxPrezime
        '
        Me.TextBoxPrezime.Location = New System.Drawing.Point(310, 40)
        Me.TextBoxPrezime.Name = "TextBoxPrezime"
        Me.TextBoxPrezime.Size = New System.Drawing.Size(133, 23)
        Me.TextBoxPrezime.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(241, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 15)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Prezime:"
        '
        'TextBoxIme
        '
        Me.TextBoxIme.Location = New System.Drawing.Point(310, 12)
        Me.TextBoxIme.Name = "TextBoxIme"
        Me.TextBoxIme.Size = New System.Drawing.Size(133, 23)
        Me.TextBoxIme.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(241, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Ime:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(241, 101)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 15)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Password:"
        '
        'TextBoxUsernameRegister
        '
        Me.TextBoxUsernameRegister.Location = New System.Drawing.Point(310, 69)
        Me.TextBoxUsernameRegister.Name = "TextBoxUsernameRegister"
        Me.TextBoxUsernameRegister.Size = New System.Drawing.Size(133, 23)
        Me.TextBoxUsernameRegister.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(241, 72)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 15)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Username:"
        '
        'LabelPoruka
        '
        Me.LabelPoruka.AutoSize = True
        Me.LabelPoruka.Location = New System.Drawing.Point(11, 164)
        Me.LabelPoruka.Name = "LabelPoruka"
        Me.LabelPoruka.Size = New System.Drawing.Size(0, 15)
        Me.LabelPoruka.TabIndex = 14
        '
        'TextBoxPasswordRegister
        '
        Me.TextBoxPasswordRegister.Location = New System.Drawing.Point(310, 98)
        Me.TextBoxPasswordRegister.Name = "TextBoxPasswordRegister"
        Me.TextBoxPasswordRegister.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxPasswordRegister.Size = New System.Drawing.Size(133, 23)
        Me.TextBoxPasswordRegister.TabIndex = 15
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(11, 137)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 30)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "O nama..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(463, 179)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBoxPasswordRegister)
        Me.Controls.Add(Me.LabelPoruka)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBoxUsernameRegister)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBoxPrezime)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBoxIme)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ButtonRegistracija)
        Me.Controls.Add(Me.ButtonLogin)
        Me.Controls.Add(Me.TextBoxPassword)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxUsername)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxUsername As TextBox
    Friend WithEvents TextBoxPassword As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ButtonLogin As Button
    Friend WithEvents ButtonRegistracija As Button
    Friend WithEvents TextBoxPrezime As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxIme As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxUsernameRegister As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents LabelPoruka As Label
    Friend WithEvents TextBoxPasswordRegister As TextBox
    Friend WithEvents Button1 As Button
End Class
