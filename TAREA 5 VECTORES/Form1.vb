Public Class Form1
    Public VNombre(10) As String
    Public VNit(10) As String
    Public VSaldo(10) As Double
    Public VConsumo(10) As Double
    Public VServicio(10) As String
    Public VTarifa(10) As String
    Public fila As Byte = 0
    Public total As Double = 0
    Public mora As Double = 0
    Sub limpiar_vectores()
        Me.DataGridView1.Rows.Clear()
        fila = 0
        For I = 0 To 9
            VNombre(I) = Nothing
            VNit(I) = Nothing
            VSaldo(I) = Nothing
            VConsumo(I) = Nothing
            VServicio(I) = Nothing
            VTarifa(I) = Nothing
        Next I
    End Sub
    Sub salir()
        If MsgBox("¿Desea Salir?", vbQuestion + vbYesNo, "Mensaje Salida") = vbYes Then
            Me.Close()
        Else
            limpiar_entradas()
        End If
    End Sub

    Sub limpiar_entradas()
        Me.TextBox1.Clear()
        Me.TextBox2.Clear()
        Me.TextBox3.Clear()
        Me.TextBox4.Clear()
        Me.ComboBox1.Text = ""
        Me.ComboBox2.Text = ""
        Me.TextBox1.Focus()
    End Sub

    Sub mostrar_vectores()
        Me.DataGridView1.Rows.Clear()
        For I = 0 To 9
            If (VNombre(I) <> Nothing) Then
                Me.DataGridView1.Rows.Add(VNombre(I), VNit(I), Str(VSaldo(I)), Str(VConsumo(I)), VServicio(I), VTarifa(I))
            Else
                Exit For
            End If
        Next I
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        If (fila <= 9) Then
            VNombre(fila) = TextBox1.Text
            VNit(fila) = TextBox2.Text
            VSaldo(fila) = Val(TextBox3.Text)
            VConsumo(fila) = Val(TextBox4.Text)
            VServicio(fila) = ComboBox1.Text
            VTarifa(fila) = ComboBox2.Text
            fila = fila + 1
            Debug.Print(ComboBox1.Text)
            MsgBox("Los datos fueron registrados con exito")
            ''-----------------------------------------'''
            If Val(TextBox3.Text) > 0 Then
                mora = Val(TextBox3.Text) * 0.02
            End If

            ''-----------------------------------------'''
            Select Case ComboBox1.Text
                Case "Residencial"
                    If Val(TextBox4.Text) > 0 And Val(TextBox4.Text) < 101 Then
                        total = Val(TextBox4.Text) * 0.99
                    ElseIf Val(TextBox4.Text) >= 101 And Val(TextBox4.Text) < 300 Then
                        total = Val(TextBox4.Text) * 1.2

                    ElseIf Val(TextBox4.Text) >= 301 Then
                        total = Val(TextBox4.Text) * 3
                    End If

                Case "Industrial"
                    If Val(TextBox4.Text) > 0 And Val(TextBox4.Text) < 101 Then
                        total = Val(TextBox4.Text) * 1.99
                    ElseIf Val(TextBox4.Text) >= 101 And Val(TextBox4.Text) < 300 Then
                        total = Val(TextBox4.Text) * 2.2

                    ElseIf Val(TextBox4.Text) >= 301 Then
                        total = Val(TextBox4.Text) * 4
                    End If

            End Select
            ''-----------------------------------------'''
            Select Case ComboBox2.Text
                Case "Social"
                    total = total - (total * 0.2) + mora + Val(TextBox3.Text)
                Case "No Social"
                    total = total - (total * 0.1) + mora + Val(TextBox3.Text)
            End Select

            Me.TxtB_Total.Text = total

        End If
        If (fila = 10) Then
            MsgBox("Vectores llenos")
        End If





    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        mostrar_vectores()
    End Sub

    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click
        limpiar_vectores()
    End Sub

    Private Sub ToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem4.Click
        Call salir()
    End Sub


End Class
