Imports System
Imports System.Management
Imports System.Text
Imports System.Security.Cryptography
Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox1.Text = GetHash(GetMACAddress)
        Clipboard.SetText(TextBox1.Text)
    End Sub
    Function GetMACAddress() As String

        Dim mc As ManagementClass = New ManagementClass("Win32_NetworkAdapterConfiguration")
        Dim moc As ManagementObjectCollection = mc.GetInstances()
        Dim MACAddress As String = String.Empty
        For Each mo As ManagementObject In moc

            If (MACAddress.Equals(String.Empty)) Then
                If CBool(mo("IPEnabled")) Then MACAddress = mo("MacAddress").ToString()
                mo.Dispose()
            End If
            MACAddress = MACAddress.Replace(":", String.Empty)
        Next
        Return MACAddress
    End Function
    Private Function GetHash(ByVal text As String)
        Dim shad512 As New SHA1Managed
        Dim textByte As Byte() = Encoding.UTF8.GetBytes(text)
        Return Convert.ToBase64String(shad512.ComputeHash(textByte))
    End Function
End Class
