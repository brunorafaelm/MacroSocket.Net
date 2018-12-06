Imports System.ComponentModel
Imports System.Net
Imports System.Net.Sockets
Imports System.Text
Imports System.Threading
Imports WindowsInput

Public Class Form1
    Dim tcpListener As New TcpListener(4400)
    Dim estado As Boolean = False

    'Private Sub New()

    '    ' Esta chamada é requerida pelo designer.
    '    InitializeComponent()

    '    ' Adicione qualquer inicialização após a chamada InitializeComponent().

    'End 

    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().

    End Sub

    Private Sub TelaPrin_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Dim localIPs As New List(Of IPAddress)
        localIPs.AddRange(Dns.GetHostAddresses(Dns.GetHostName()))

        For Each ip As IPAddress In localIPs

            If ip.AddressFamily = AddressFamily.InterNetwork Then
                txIP.Text = ip.MapToIPv4.ToString
            End If
        Next
    End Sub

    Private Function ValidaCampos() As Boolean
        If txIP.Text = Nothing Then
            Return False
        End If

        If txPorta.Text = Nothing Then
            Return False
        End If

        Return True
    End Function

    Private Sub ConectaCliente(tcpClient As TcpClient, tcpListener As TcpListener)
        Try
            tcpClient = tcpListener.AcceptTcpClient()

            Dim ultimoDadoRecbido As String = Nothing

            While tcpClient.Connected
                tcpClient = tcpListener.AcceptTcpClient()

                ' obtem o stream
                Dim networkStream As NetworkStream = tcpClient.GetStream()

                If Not networkStream.CanRead Then
                    Continue While
                End If

                ' le o stream em um array de bytes
                Dim bytes(tcpClient.ReceiveBufferSize) As Byte
                networkStream.Read(bytes, 0, CInt(tcpClient.ReceiveBufferSize))

                ' Retorna os dados recebidos do cliente para o console
                Dim clientdata As String = Encoding.ASCII.GetString(bytes)

                If clientdata.Substring(0, 1) = "1" And ultimoDadoRecbido <> "1" Then
                    EmulaPressionamentoTecla()
                End If
            End While

            tcpListener.Stop()
            tcpClient.Close()
        Catch ex As Exception
            Console.WriteLine(ex.ToString())
            Console.ReadLine()
            Throw
        End Try

    End Sub

    Private Sub EmulaPressionamentoTecla()

        Dim teste As New InputSimulator

        If cbMacro.SelectedText Is "F1" Then
            teste.Keyboard.KeyDown(Native.VirtualKeyCode.F1)
            teste.Keyboard.Sleep(100)
            teste.Keyboard.KeyUp(Native.VirtualKeyCode.F1)
        End If

        If cbMacro.SelectedItem Is "F2" Then
            teste.Keyboard.KeyDown(Native.VirtualKeyCode.F2)
            teste.Keyboard.Sleep(100)
            teste.Keyboard.KeyUp(Native.VirtualKeyCode.F2)
        End If

        If cbMacro.SelectedItem Is "F3" Then
            teste.Keyboard.KeyDown(Native.VirtualKeyCode.F3)
            teste.Keyboard.Sleep(100)
            teste.Keyboard.KeyUp(Native.VirtualKeyCode.F3)
        End If

        If cbMacro.SelectedItem Is "F4" Then
            teste.Keyboard.KeyDown(Native.VirtualKeyCode.F4)
            teste.Keyboard.Sleep(100)
            teste.Keyboard.KeyUp(Native.VirtualKeyCode.F4)
        End If

        If cbMacro.SelectedItem Is "F5" Then
            teste.Keyboard.KeyDown(Native.VirtualKeyCode.F5)
            teste.Keyboard.Sleep(100)
            teste.Keyboard.KeyUp(Native.VirtualKeyCode.F5)
        End If

        If cbMacro.SelectedItem Is "F6" Then
            teste.Keyboard.KeyDown(Native.VirtualKeyCode.F6)
            teste.Keyboard.Sleep(100)
            teste.Keyboard.KeyUp(Native.VirtualKeyCode.F6)
        End If

        If cbMacro.SelectedItem Is "F7" Then
            teste.Keyboard.KeyDown(Native.VirtualKeyCode.F7)
            teste.Keyboard.Sleep(100)
            teste.Keyboard.KeyUp(Native.VirtualKeyCode.F7)
        End If

        If cbMacro.SelectedItem Is "F8" Then
            teste.Keyboard.KeyDown(Native.VirtualKeyCode.F8)
            teste.Keyboard.Sleep(100)
            teste.Keyboard.KeyUp(Native.VirtualKeyCode.F8)
        End If

        If cbMacro.SelectedItem Is "F9" Then
            teste.Keyboard.KeyDown(Native.VirtualKeyCode.F9)
            teste.Keyboard.Sleep(100)
            teste.Keyboard.KeyUp(Native.VirtualKeyCode.F9)
        End If

        If cbMacro.SelectedItem Is "F10" Then
            teste.Keyboard.KeyDown(Native.VirtualKeyCode.F10)
            teste.Keyboard.Sleep(100)
            teste.Keyboard.KeyUp(Native.VirtualKeyCode.F10)
        End If

        If cbMacro.SelectedItem Is "F11" Then
            teste.Keyboard.KeyDown(Native.VirtualKeyCode.F11)
            teste.Keyboard.Sleep(100)
            teste.Keyboard.KeyUp(Native.VirtualKeyCode.F11)
        End If

        If cbMacro.SelectedItem Is "F12" Then
            teste.Keyboard.KeyDown(Native.VirtualKeyCode.F12)
            teste.Keyboard.Sleep(100)
            teste.Keyboard.KeyUp(Native.VirtualKeyCode.F12)
        End If


        If cbMacro.SelectedItem Is "Enter" Then
            teste.Keyboard.KeyDown(Native.VirtualKeyCode.RETURN)
            teste.Keyboard.Sleep(100)
            teste.Keyboard.KeyUp(Native.VirtualKeyCode.RETURN)
        End If

        If cbMacro.SelectedItem Is "Ctrl" Then
            teste.Keyboard.KeyDown(Native.VirtualKeyCode.LCONTROL)
            teste.Keyboard.Sleep(100)
            teste.Keyboard.KeyUp(Native.VirtualKeyCode.LCONTROL)
        End If

        If cbMacro.SelectedItem Is "Shift" Then
            teste.Keyboard.KeyDown(Native.VirtualKeyCode.LSHIFT)
            teste.Keyboard.Sleep(100)
            teste.Keyboard.KeyUp(Native.VirtualKeyCode.LSHIFT)
        End If



    End Sub

    Private Sub btConectar_Click(sender As Object, e As EventArgs) Handles btConectar.Click
        If Not ValidaCampos() Then
            MessageBox.Show("Algum dos campos de textos estão vazios ou invalidos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim tcpClient As New TcpClient
        Dim numeroPorta As Integer = CInt(txPorta.Text)
        tcpListener = New TcpListener(numeroPorta)
        'Dim t1 As New Thread(Sub() Me.ConectaCliente(tcpClient, tcpListener))

        If btConectar.Text = "Desconectar" Then
            Try
                't1.Abort()
                tcpClient.Close()
                tcpListener.Stop()
                MessageBox.Show("Encerrado conexão com o servidor", "Encerrado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.txEstado.Text = "DESCONECTADO"
                Me.btConectar.Text = "Conectar"
                Me.txEstado.ForeColor = Color.Red
                Exit Sub
            Catch ex As Exception
                Throw
            End Try
        Else
            Try
                tcpListener.Start()
                Me.txEstado.Text = "CONECTADO"
                Me.btConectar.Text = "Desconectar"
                Me.txEstado.ForeColor = Color.Green
                Me.ConectaCliente(tcpClient, tcpListener)
                't1.Start()
            Catch ex As Exception
                Throw
            End Try
        End If
    End Sub

    Private Sub TelaPrin_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        tcpListener.Stop()
    End Sub
End Class
