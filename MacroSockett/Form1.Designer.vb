<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txIP = New System.Windows.Forms.TextBox()
        Me.txPorta = New System.Windows.Forms.TextBox()
        Me.txEstado = New System.Windows.Forms.TextBox()
        Me.cbMacro = New System.Windows.Forms.ComboBox()
        Me.btConectar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txIP
        '
        Me.txIP.Location = New System.Drawing.Point(61, 13)
        Me.txIP.Name = "txIP"
        Me.txIP.Size = New System.Drawing.Size(100, 20)
        Me.txIP.TabIndex = 0
        '
        'txPorta
        '
        Me.txPorta.Location = New System.Drawing.Point(61, 52)
        Me.txPorta.Name = "txPorta"
        Me.txPorta.Size = New System.Drawing.Size(100, 20)
        Me.txPorta.TabIndex = 1
        Me.txPorta.Text = "4000"
        '
        'txEstado
        '
        Me.txEstado.ForeColor = System.Drawing.Color.Red
        Me.txEstado.Location = New System.Drawing.Point(61, 135)
        Me.txEstado.Name = "txEstado"
        Me.txEstado.Size = New System.Drawing.Size(100, 20)
        Me.txEstado.TabIndex = 2
        Me.txEstado.Text = "DESCONECTADO"
        '
        'cbMacro
        '
        Me.cbMacro.FormattingEnabled = True
        Me.cbMacro.Items.AddRange(New Object() {"F1", "F2", "F3", "F4", "F5", "F6", "F7", "F8", "F9", "F10", "F11", "F12", "Enter", "Shift", "Ctrl"})
        Me.cbMacro.Location = New System.Drawing.Point(61, 94)
        Me.cbMacro.Name = "cbMacro"
        Me.cbMacro.Size = New System.Drawing.Size(57, 21)
        Me.cbMacro.TabIndex = 3
        Me.cbMacro.Text = "F12"
        '
        'btConectar
        '
        Me.btConectar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btConectar.Location = New System.Drawing.Point(52, 188)
        Me.btConectar.Name = "btConectar"
        Me.btConectar.Size = New System.Drawing.Size(84, 23)
        Me.btConectar.TabIndex = 4
        Me.btConectar.Text = "Conectar"
        Me.btConectar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "IP:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Porta:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Macro:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Estado:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(187, 245)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btConectar)
        Me.Controls.Add(Me.cbMacro)
        Me.Controls.Add(Me.txEstado)
        Me.Controls.Add(Me.txPorta)
        Me.Controls.Add(Me.txIP)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(203, 284)
        Me.MinimumSize = New System.Drawing.Size(203, 284)
        Me.Name = "Form1"
        Me.Text = "MacroSocket"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txIP As TextBox
    Friend WithEvents txPorta As TextBox
    Friend WithEvents txEstado As TextBox
    Friend WithEvents cbMacro As ComboBox
    Friend WithEvents btConectar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
