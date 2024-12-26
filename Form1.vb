Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Imports MySql.Data.MySqlClient

Public Class fix
    Public connection As MySqlConnection
    Dim Rb As Double
    Dim Rc As Double
    Dim VCC As Double
    Dim B As Double
    Dim Ib As Double
    Dim Ic As Double
    Dim Ie As Double
    Dim VRb As Double
    Dim VRc As Double
    Dim Vbe As Double
    Dim Vce As Double


    Private Sub Guna2CircleButton1_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton1.Click
        Me.Hide()
        HOME.Show()
    End Sub

    Private Sub fix_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.Enabled = False

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            Rb = Val(TextBox1.Text)
            CheckBox2.Enabled = False
            CheckBox3.Enabled = False
        Else
            CheckBox2.Enabled = True
            CheckBox3.Enabled = True
        End If
    End Sub


    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            Rb = Val(TextBox1.Text) * 1000
            CheckBox1.Enabled = False
            CheckBox3.Enabled = False
        Else
            CheckBox1.Enabled = True
            CheckBox3.Enabled = True
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked Then
            Rb = Val(TextBox1.Text) * 1000000
            CheckBox1.Enabled = False
            CheckBox2.Enabled = False
        Else
            CheckBox1.Enabled = True
            CheckBox2.Enabled = True
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked Then
            Rc = Val(TextBox2.Text)
            CheckBox5.Enabled = False
            CheckBox6.Enabled = False
        Else
            CheckBox5.Enabled = True
            CheckBox6.Enabled = True
        End If
    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        If CheckBox5.Checked Then
            Rc = Val(TextBox2.Text) * 1000
            CheckBox4.Enabled = False
            CheckBox6.Enabled = False
        Else
            CheckBox4.Enabled = True
            CheckBox6.Enabled = True
        End If
    End Sub

    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox6.CheckedChanged
        If CheckBox6.Checked Then
            Rc = Val(TextBox2.Text) * 1000000
            CheckBox4.Enabled = False
            CheckBox5.Enabled = False
        Else
            CheckBox4.Enabled = True
            CheckBox5.Enabled = True
        End If
    End Sub

    Private Sub CheckBox10_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox10.CheckedChanged
        If CheckBox10.Checked Then
            VCC = Val(TextBox3.Text)
            CheckBox11.Enabled = False
            CheckBox12.Enabled = False
        Else
            CheckBox11.Enabled = True
            CheckBox12.Enabled = True
        End If
    End Sub

    Private Sub CheckBox11_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox11.CheckedChanged
        If CheckBox11.Checked Then
            VCC = Val(TextBox3.Text) / 1000
            CheckBox10.Enabled = False
            CheckBox12.Enabled = False
        Else
            CheckBox10.Enabled = True
            CheckBox12.Enabled = True
        End If
    End Sub

    Private Sub CheckBox12_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox12.CheckedChanged
        If CheckBox12.Checked Then
            VCC = Val(TextBox3.Text) / 1000000
            CheckBox10.Enabled = False
            CheckBox11.Enabled = False
        Else
            CheckBox10.Enabled = True
            CheckBox11.Enabled = True
        End If
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If String.IsNullOrWhiteSpace(TextBox1.Text) Then
            MsgBox("Data Incomplete. Fill up all boxes.")
            Exit Sub

        ElseIf String.IsNullOrWhiteSpace(TextBox2.Text) Then
            MsgBox("Data Incomplete. Fill up all boxes.")
            Exit Sub

        ElseIf String.IsNullOrWhiteSpace(TextBox3.Text) Then
            MsgBox("Data Incomplete. Fill up all boxes.")
            Exit Sub

        ElseIf String.IsNullOrWhiteSpace(TextBox4.Text) Then
            MsgBox("Data Incomplete. Fill up all boxes.")
            Exit Sub
        End If

        Button1.Enabled = True

        B = Val(TextBox4.Text)

        Try
            Dim Resb As Double = Rb
            Dim Resc As Double = Rc
            Dim Vin1 As Double = VCC

            Vbe = 0.7
            Ib = (VCC - Vbe) / Rb
            Ic = B * Ib
            Ie = Ic + Ib
            VRb = Ib * Rb
            VRc = Ic * Rc
            Vce = VCC - VRc


            Dim formattedResb As String = FormatResistance(Rb)
            Dim formattedResc As String = FormatResistance(Rc)

            Label6.Text = "Rb = " + formattedResb
            Label8.Text = "Rc = " + formattedResc
            Label7.Text = "Beta = " + B.ToString("F2")
            Label9.Text = "VCC = " + VCC.ToString("F2") + " V"

            Label5.Text = "700 mV"

            Select Case Ib
                Case Is >= 1
                    Label1.Text = " " + Ib.ToString("F4") + " A"
                Case Is >= 0.001
                    Label1.Text = " " + (Ib * 1000).ToString("F4") + " mA"
                Case Else
                    Label1.Text = " " + (Ib * 1000000).ToString("F4") + " uA"
            End Select

            Select Case Ic
                Case Is >= 1
                    Label2.Text = " " + Ic.ToString("F4") + " A"
                Case Is >= 0.001
                    Label2.Text = " " + (Ic * 1000).ToString("F4") + " mA"
                Case Else
                    Label2.Text = " " + (Ic * 1000000).ToString("F4") + " uA"
            End Select

            Select Case Ie
                Case Is >= 1
                    Label3.Text = " " + Ie.ToString("F4") + " A"
                Case Is >= 0.001
                    Label3.Text = " " + (Ie * 1000).ToString("F4") + " mA"
                Case Else
                    Label3.Text = " " + (Ie * 1000000).ToString("F4") + " uA"
            End Select

            Select Case VRb
                Case Is >= 1
                    Label4.Text = " " + VRb.ToString("F4") + " V"
                Case Is >= 0.001
                    Label4.Text = " " + (VRb * 1000).ToString("F4") + " mV"
                Case Else
                    Label4.Text = " " + (VRb * 1000000).ToString("F4") + " uV"
            End Select

            Select Case VRc
                Case Is >= 1
                    Label10.Text = " " + VRc.ToString("F4") + " V"
                Case Is >= 0.001
                    Label10.Text = " " + (VRc * 1000).ToString("F4") + " mV"
                Case Else
                    Label10.Text = " " + (VRc * 1000000).ToString("F4") + " uV"
            End Select

            Select Case Vce
                Case Is >= 1
                    Label11.Text = " " + Vce.ToString("F4") + " V"
                Case Is >= 0.001
                    Label11.Text = " " + (Vce * 1000).ToString("F4") + " mV"
                Case Else
                    Label11.Text = " " + (Vce * 1000000).ToString("F4") + " uV"
            End Select

        Catch ex As Exception
            MsgBox("Error in calculation: " & ex.Message)
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Try
            connection = New MySqlConnection
            connection.ConnectionString = "server=localhost;username=root;password=;database=experiment3"
            connection.Open()

            Dim Vbed As String = "700 mV"

            Dim VCCd As String
            Dim Bd As String = B.ToString("F4") + ""
            Dim Ibd As String
            Dim Icd As String
            Dim Ied As String
            Dim VRbd As String
            Dim VRcd As String
            Dim Vced As String

            Select Case VCC
                Case Is >= 1
                    VCCd = VCC.ToString("F4") + " V"
                Case Is >= 0.001
                    VCCd = (VCC * 1000).ToString("F4") + " mV"
                Case Else
                    VCCd = (VCC * 1000000).ToString("F4") + " uV"
            End Select

            Select Case Ib
                Case Is >= 1
                    Ibd = Ib.ToString("F4") + " A"
                Case Is >= 0.001
                    Ibd = (Ib * 1000).ToString("F4") + " mA"
                Case Else
                    Ibd = (Ib * 1000000).ToString("F4") + " uA"
            End Select

            Select Case Ic
                Case Is >= 1
                    Icd = Ic.ToString("F4") + " A"
                Case Is >= 0.001
                    Icd = (Ic * 1000).ToString("F4") + " mA"
                Case Else
                    Icd = (Ic * 1000000).ToString("F4") + " uA"
            End Select

            Select Case Ie
                Case Is >= 1
                    Ied = Ie.ToString("F4") + " A"
                Case Is >= 0.001
                    Ied = (Ie * 1000).ToString("F4") + " mA"
                Case Else
                    Ied = (Ie * 1000000).ToString("F4") + " uA"
            End Select


            Select Case VRb
                Case Is >= 1
                    VRbd = VRb.ToString("F4") + " V"
                Case Is >= 0.001
                    VRbd = (VRb * 1000).ToString("F4") + " mV"
                Case Else
                    VRbd = (VRb * 1000000).ToString("F4") + " uV"
            End Select

            Select Case VRc
                Case Is >= 1
                    VRcd = VRc.ToString("F4") + " V"
                Case Is >= 0.001
                    VRcd = (VRc * 1000).ToString("F4") + " mV"
                Case Else
                    VRcd = (VRc * 1000000).ToString("F4") + " uV"
            End Select

            Select Case Vce
                Case Is >= 1
                    Vced = Vce.ToString("F4") + " V"
                Case Is >= 0.001
                    Vced = (Vce * 1000).ToString("F4") + " mV"
                Case Else
                    Vced = (Vce * 1000000).ToString("F4") + " uV"
            End Select

            Dim command As New MySqlCommand("INSERT INTO fix (VCC, B, Rb, Rc, Ib, Ic, Ie, VRb, VRc, Vce, Vbe) VALUES (@VCC, @B, @Rb, @Rc, @Ib, @Ic, @Ie, @VRb, @VRc, @Vce, @Vbe)", connection)


            command.Parameters.AddWithValue("@VCC", VCCd)
            command.Parameters.AddWithValue("@B", Bd)
            command.Parameters.AddWithValue("@Rb", FormatResistanced(Rb))
            command.Parameters.AddWithValue("@Rc", FormatResistanced(Rc))
            command.Parameters.AddWithValue("@Ib", Ibd)
            command.Parameters.AddWithValue("@Ic", Icd)
            command.Parameters.AddWithValue("@Ie", Ied)
            command.Parameters.AddWithValue("@VRb", VRbd)
            command.Parameters.AddWithValue("@VRc", VRcd)
            command.Parameters.AddWithValue("@Vce", Vced)
            command.Parameters.AddWithValue("@Vbe", Vbed)

            command.ExecuteNonQuery()
            MsgBox("Successfully Added Record!")
            connection.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Button1.Enabled = False

        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()

        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False
        CheckBox5.Checked = False
        CheckBox6.Checked = False
        CheckBox10.Checked = False
        CheckBox11.Checked = False
        CheckBox12.Checked = False

        Label1.Text = "Rb"
        Label2.Text = "Rc"
        Label4.Text = "β"
        Label3.Text = "VCC"

        Label1.Text = ""
        Label2.Text = ""
        Label3.Text = ""
        Label4.Text = ""
        Label10.Text = ""
        Label5.Text = ""
        Label11.Text = ""
    End Sub

    Private Function FormatResistance(resistance As Double) As String

        If resistance >= 1000000 Then
            Return (resistance / 1000000).ToString("F2") + "MΩ"
        ElseIf resistance >= 1000 Then
            Return (resistance / 1000).ToString("F2") + "kΩ"
        Else
            Return resistance.ToString("F2") + "Ω"
        End If
    End Function

    Private Function FormatResistanced(resistance As Double) As String
        If resistance >= 1000000 Then
            Return (resistance / 1000000).ToString("F2") + "MOhms"
        ElseIf resistance >= 1000 Then
            Return (resistance / 1000).ToString("F2") + "kOhms"
        Else
            Return resistance.ToString("F2") + "Ohms"
        End If
    End Function


End Class