Public Class Form1
    Public VNombre(10) As String
    Public VNit(10) As String
    Public VSaldo(10) As Double
    Public VConsumo(10) As Double
    Public VServicio(10) As String
    Public VTarifa(10) As String
    Public fila As Byte = 0
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
            limpiar_entradas()
            MsgBox("Los datos fueron registrados con exito")
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
