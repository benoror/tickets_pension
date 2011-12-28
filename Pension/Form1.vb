Imports System.IO
Imports System.Net
Imports System.Text

Public Class Form1


    Private Sub updateClock()
        fecha_label.Text = DateTime.Now.Date.ToString("D")
        hora_label.Text = Now.ToLongTimeString
    End Sub



    Private Sub timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timer.Tick
        updateClock()
    End Sub


    Private Sub readSettings()
        Dim oRead As System.IO.StreamReader

        oRead = File.OpenText("settings.conf")

        Dim line = 1
        While oRead.Peek <> -1
            Dim LineIn = oRead.ReadLine()

            If line = 1 Then
                conf_tarifa_hora.Text = LineIn
            ElseIf line = 2 Then
                conf_tarifa_dia.Text = LineIn
            ElseIf line = 3 Then
                conf_tarifa_mes.Text = LineIn
            ElseIf line = 4 Then
                conf_pass.Text = LineIn
            ElseIf line = 5 Then
                conf_cajones.Text = LineIn
            ElseIf line = 6 Then
                conf_llaves.Text = LineIn
            ElseIf line = 7 Then
                label_corte.Text = LineIn
            End If

            line = line + 1
        End While

        oRead.Close()
    End Sub

    Private Sub saveSettings()
        Dim fs As New FileStream("settings.conf", FileMode.Open, FileAccess.Write)
        Dim oWrite As New System.IO.StreamWriter(fs)

        oWrite.WriteLine(conf_tarifa_hora.Text)
        oWrite.WriteLine(conf_tarifa_dia.Text)
        oWrite.WriteLine(conf_tarifa_mes.Text)
        oWrite.WriteLine(conf_pass.Text)
        oWrite.WriteLine(conf_cajones.Text)
        oWrite.WriteLine(conf_llaves.Text)
        oWrite.WriteLine(label_corte.Text)

        oWrite.Close()

        updateMenus()
    End Sub

    Private Sub updateMenus()
        cajon_entrada.Items.Clear()
        Dim c
        For c = 1 To Integer.Parse(conf_cajones.Text)
            cajon_entrada.Items.Add(c)
        Next

        llave_entrada.Items.Clear()
        Dim l
        For l = 1 To Integer.Parse(conf_llaves.Text)
            llave_entrada.Items.Add(l)
        Next
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AccessDataSet.EntradasSalidas' table. You can move, or remove it, as needed.
        'Me.EntradasTableAdapter.Fill(Me.AccessDataSet.EntradasSalidas)
        updateEntradas()
        updateClock()
        readSettings()
        updateMenus()
    End Sub

    Private Sub nueva_entrada_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nueva_entrada_button.Click
        Dim resultado = DialogResult.Cancel
        Dim timestamp = Now.Date.ToShortDateString.Replace("/", "-") + "_" + hora_label.Text.Replace(":", ".")

        If vehiculo_entrada.Text.Trim = "" Or color_entrada.Text.Trim = "" Or placas_entrada.Text.Trim = "" Or cajon_entrada.Text = "" Then
            MsgBox("Existen campos vacios", MsgBoxStyle.Exclamation, "Error")
        Else
            EntradaDialog.vehiculo.Text = vehiculo_entrada.Text
            EntradaDialog.color.Text = color_entrada.Text
            EntradaDialog.placas.Text = placas_entrada.Text
            EntradaDialog.fecha.Text = Now.ToString
            EntradaDialog.cajon.Text = cajon_entrada.Text
            EntradaDialog.llave.Text = llave_entrada.Text
            resultado = EntradaDialog.ShowDialog()
        End If

        If resultado = DialogResult.OK Then
            'Actualiza BD
            EntradasTableAdapter.InsertEntrada(vehiculo_entrada.Text, color_entrada.Text, placas_entrada.Text, Now.ToString, _
                                               cajon_entrada.Text, llave_entrada.Text)

            'Resetea campos
            vehiculo_entrada.Text = ""
            color_entrada.Text = ""
            placas_entrada.Text = ""
            llave_checkbox_entrada.Checked = False
            llave_entrada.SelectedIndex = -1
            cajon_entrada.SelectedIndex = -1

            'Actualiza Vista
            Me.updateEntradas()

        End If

    End Sub

    Private Sub nueva_salida_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nueva_salida_diaria_button.Click

        If VistaEntradas.SelectedCells.Count = 0 Then
            Exit Sub
        End If

        Dim v = VistaEntradas.CurrentRow.Cells.Item(1).Value 'vehiculo
        Dim c = VistaEntradas.CurrentRow.Cells.Item(2).Value 'color
        Dim p = VistaEntradas.CurrentRow.Cells.Item(3).Value 'placas
        Dim h = VistaEntradas.CurrentRow.Cells.Item(0).Value 'entrada
        Dim s = Date.Now 'salida

        'TimeSpan
        Dim ts As TimeSpan = s.Subtract(DateTime.Parse(h))

        'calcular tiempos transcurridos
        'Calcular Horas
        Dim horas = ts.TotalHours
        Dim dias = 0
        Dim meses = 0
        'Calcular dias
        If horas >= 24 Then
            dias += Math.Floor(horas / 24)
            horas -= (dias * 24)
        End If
        'Calcular meses
        If dias >= 30 Then
            meses += Math.Floor(dias / 30)
            dias -= (meses * 30)
        End If
        'Completar fracciones de hora
        horas = Math.Ceiling(horas)
        'Si suman 24 agregarlo como dia
        If horas = 24 Then
            dias += 1
            horas -= 24
        End If

        'Calcular tarifa
        Dim total = (horas * Decimal.Parse(conf_tarifa_hora.Text) + _
                     dias * Decimal.Parse(conf_tarifa_dia.Text) + _
                     meses * Decimal.Parse(conf_tarifa_mes.Text))

        'confirmar salida
        Dim resultado = MsgBoxResult.Cancel
        resultado = MsgBox("Entrada: " + h.ToString + Chr(13) + _
                           "Salida: " + s.ToString + Chr(13) + Chr(13) + _
                           "Meses (30d): " + meses.ToString + Chr(13) + _
                           "Dias (24h): " + dias.ToString + Chr(13) + _
                           "Horas/fr: " + horas.ToString + Chr(13) + Chr(13) + _
                           "Tarifa: " + "$" + total.ToString, _
                           MsgBoxStyle.OkCancel + MsgBoxStyle.DefaultButton2, "Confirmar Salida")
        If resultado = 1 Then
            'actualizar salida en bd
            EntradasTableAdapter.SetSalida(s, Decimal.Parse(total), v, c, p, DateTime.Parse(h))
            Me.updateEntradas()
        End If

    End Sub

    Private Sub updateEntradas()
        Try
            Me.EntradasTableAdapter.FillByEntradas(Me.AccessDataSet.EntradasSalidas)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub



    Private Sub updateSalidas()
        Try
            Me.EntradasTableAdapter.FillBySalidas(Me.AccessDataSet.EntradasSalidas)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub TabEntradas_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabEntradas.Enter
        updateEntradas()
    End Sub

    Private Sub TabSalidas_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabSalidas.Enter
        updateSalidas()
    End Sub


    Private Sub llave_checkbox_entrada_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles llave_checkbox_entrada.CheckedChanged
        Dim this As CheckBox = sender
        If this.Checked Then
            llave_entrada.Enabled = True
        Else
            llave_entrada.Enabled = False
            llave_entrada.SelectedIndex = -1
        End If
    End Sub


    Private Sub modify_conf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles modify_conf.Click

        Dim auth = InputBox("Contraseña: ", "Contraseña")
        If auth <> conf_pass.Text Then
            MsgBox("Contraseña Incorrecta")
            Exit Sub
        End If

        conf_tarifa_dia.Enabled = True
        conf_tarifa_hora.Enabled = True
        conf_tarifa_mes.Enabled = True
        conf_cajones.Enabled = True
        conf_llaves.Enabled = True
        label_pass.Visible = True
        conf_pass.Visible = True
        modify_conf.Enabled = False
    End Sub

    Private Sub save_conf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save_conf.Click

        Dim inte As Integer
        If Not IsValidInteger(inte, conf_tarifa_dia.Text, "Tarifa Dia", 0) _
                Or Not IsValidInteger(inte, conf_tarifa_hora.Text, "Tarifa Hora", 0) _
                Or Not IsValidInteger(inte, conf_tarifa_mes.Text, "Tarifa Mes", 0) _
                Or Not IsValidInteger(inte, conf_cajones.Text, "Cajones", 0) _
                Or Not IsValidInteger(inte, conf_llaves.Text, "Llaves", 0) Then
            Exit Sub
        End If

        saveSettings()

        conf_tarifa_dia.Enabled = False
        conf_tarifa_hora.Enabled = False
        conf_tarifa_mes.Enabled = False
        conf_cajones.Enabled = False
        conf_llaves.Enabled = False
        conf_pass.Visible = False
        label_pass.Visible = False
        modify_conf.Enabled = True
    End Sub

    Private Function IsValidInteger(ByRef result As Integer, _
    ByVal txt As String, ByVal field_name As String, _
    Optional ByVal min_value As Integer = Integer.MinValue, _
    Optional ByVal max_value As Integer = Integer.MaxValue) As Boolean
        ' Check for blank entry.
        If txt.Length < 1 Then
            MsgBox("Falto: " & field_name & ".")
            Return False
        End If
        ' See if it's numeric.
        If Not IsNumeric(txt) Then
            MsgBox(field_name & " debe ser numerico.")
            Return False
        End If
        ' Assign the value.
        Try
            result = Integer.Parse(txt)
        Catch ex As Exception
            MsgBox("Error en " & field_name & "." & _
            vbCrLf & ex.Message)
            Return False
        End Try
        ' Check that the value is between min_value and max_value.
        If result < min_value Or result > max_value Then
            MsgBox(field_name & " debe estar entre " & _
            min_value.ToString & " y " & max_value.ToString & ".")
            Return False
        End If
        ' The value is okay.
        Return True
    End Function


    Private Sub corte_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles corte_button.Click

        Dim auth = InputBox("Contraseña: ", "Contraseña")
        If auth <> conf_pass.Text Then
            MsgBox("Contraseña Incorrecta")
            Exit Sub
        End If

        Dim fecha As Date
        fecha = Date.Parse(label_corte.Text)
        Dim fs As New FileStream("Cortes/Corte " & label_corte.Text.Replace("/", "_").Replace(":", ".") & ".csv", FileMode.OpenOrCreate, FileAccess.Write)
        Dim oWrite As New System.IO.StreamWriter(fs)

        oWrite.WriteLine("ID,Vehiculo,Color,Placas,Entrada,Salida,Tarifa,Cajon,Llave")
        Dim fila As System.Data.DataRow
        Dim countf = 0
        For Each fila In EntradasTableAdapter.GetDataByCorte(fecha).Rows
            Dim campo
            Dim cnt = 1
            For Each campo In fila.ItemArray
                oWrite.Write(campo.ToString)
                If cnt < 9 Then
                    oWrite.Write(",")
                End If
                cnt = cnt + 1
            Next
            oWrite.WriteLine()
            countf = countf + 1
        Next

        oWrite.Close()

        label_corte.Text = Date.Now.ToString
        saveSettings()
        readSettings()

        MsgBox("Se guardaron " + countf.ToString + " registros")

    End Sub

    Private Sub imprimir_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles imprimir_button.Click
        Dim tprinter As New ticketPrinter

        With tprinter
            .UseBanner = True
            .Banner = "Pensión Gasomax"
            .BannerFont = New Font("Courier New", 12, FontStyle.Regular, GraphicsUnit.Point)
            .UseFooter = False
            .FooterFont = New Font("Courier New", 12, FontStyle.Regular, GraphicsUnit.Point)
            .DataFont = New Font("Courier New", 10, FontStyle.Bold, GraphicsUnit.Pixel)
            .MarginTop = 75
            .MarginBottom = 75
            .MarginLeft = 0
            .MarginRight = 0
            'Add data
            .AddLine("Periférico Nte. #1355")
            .AddLine("Sauzalito CP 78116")
            .AddLine("San Luis Potosí, S.L.P.")
            .AddLine(" ")
            .AddLine(" ")
            .AddLine(" ")
            .AddLine("COMPROBANTE DE SALIDA")
            .AddLine(" ")
            .AddLine("Vehículo: " & VistaSalidas.CurrentRow.Cells.Item(3).Value)
            .AddLine("Placas:   " & VistaSalidas.CurrentRow.Cells.Item(5).Value)
            .AddLine("Entrada:  " & VistaSalidas.CurrentRow.Cells.Item(0).Value)
            .AddLine("Salida:   " & VistaSalidas.CurrentRow.Cells.Item(1).Value)
            .AddLine(" ")
            .AddLine("Tarifa:   $" & VistaSalidas.CurrentRow.Cells.Item(2).Value & " M.N.")
            .AddLine(" ")
            .AddLine("Fecha:    " & Now.ToString("dd/M/yyyy"))
            .AddLine("Hora:     " & Now.ToString("HH:mm:ss"))
            .AddLine(" ")
            .AddLine(" ")
            .AddLine(" ")
            .AddLine(" ")
            .AddLine(" ")
            'replace .Preview by .Print if you want a hard copy. Think green.
            .Print()
        End With

    End Sub
End Class
