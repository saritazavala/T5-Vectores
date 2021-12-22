<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LB_Nombre = New System.Windows.Forms.Label()
        Me.LB_Nit = New System.Windows.Forms.Label()
        Me.LB_SaldAnt = New System.Windows.Forms.Label()
        Me.LB_Consumo = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.LB_TTAri = New System.Windows.Forms.Label()
        Me.LB_TServ = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NIT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Saldo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Consumo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Servicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tarifa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LB_Total = New System.Windows.Forms.Label()
        Me.TxtB_Total = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LB_Nombre
        '
        Me.LB_Nombre.AutoSize = True
        Me.LB_Nombre.Location = New System.Drawing.Point(18, 38)
        Me.LB_Nombre.Name = "LB_Nombre"
        Me.LB_Nombre.Size = New System.Drawing.Size(64, 20)
        Me.LB_Nombre.TabIndex = 0
        Me.LB_Nombre.Text = "Nombre"
        '
        'LB_Nit
        '
        Me.LB_Nit.AutoSize = True
        Me.LB_Nit.Location = New System.Drawing.Point(24, 78)
        Me.LB_Nit.Name = "LB_Nit"
        Me.LB_Nit.Size = New System.Drawing.Size(32, 20)
        Me.LB_Nit.TabIndex = 1
        Me.LB_Nit.Text = "NIT"
        '
        'LB_SaldAnt
        '
        Me.LB_SaldAnt.AutoSize = True
        Me.LB_SaldAnt.Location = New System.Drawing.Point(18, 136)
        Me.LB_SaldAnt.Name = "LB_SaldAnt"
        Me.LB_SaldAnt.Size = New System.Drawing.Size(105, 20)
        Me.LB_SaldAnt.TabIndex = 2
        Me.LB_SaldAnt.Text = "Saldo Anterior"
        '
        'LB_Consumo
        '
        Me.LB_Consumo.AutoSize = True
        Me.LB_Consumo.Location = New System.Drawing.Point(18, 179)
        Me.LB_Consumo.Name = "LB_Consumo"
        Me.LB_Consumo.Size = New System.Drawing.Size(143, 40)
        Me.LB_Consumo.TabIndex = 3
        Me.LB_Consumo.Text = "Consumo de " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "kilowatts de energía"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(88, 38)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(177, 27)
        Me.TextBox1.TabIndex = 4
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(77, 82)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(188, 27)
        Me.TextBox2.TabIndex = 5
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(129, 133)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(136, 27)
        Me.TextBox3.TabIndex = 6
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(167, 189)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(98, 27)
        Me.TextBox4.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBox2)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.LB_TTAri)
        Me.GroupBox1.Controls.Add(Me.LB_TServ)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.LB_Consumo)
        Me.GroupBox1.Controls.Add(Me.LB_SaldAnt)
        Me.GroupBox1.Controls.Add(Me.LB_Nit)
        Me.GroupBox1.Controls.Add(Me.LB_Nombre)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 47)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(302, 379)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DATOS CONSUMIDOR"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Social", "No Social"})
        Me.ComboBox2.Location = New System.Drawing.Point(140, 282)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(125, 28)
        Me.ComboBox2.TabIndex = 11
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Residencial", "Industrial"})
        Me.ComboBox1.Location = New System.Drawing.Point(140, 239)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(125, 28)
        Me.ComboBox1.TabIndex = 10
        '
        'LB_TTAri
        '
        Me.LB_TTAri.AutoSize = True
        Me.LB_TTAri.Location = New System.Drawing.Point(18, 282)
        Me.LB_TTAri.Name = "LB_TTAri"
        Me.LB_TTAri.Size = New System.Drawing.Size(100, 20)
        Me.LB_TTAri.TabIndex = 9
        Me.LB_TTAri.Text = "Tipo de Tarifa"
        '
        'LB_TServ
        '
        Me.LB_TServ.AutoSize = True
        Me.LB_TServ.Location = New System.Drawing.Point(18, 242)
        Me.LB_TServ.Name = "LB_TServ"
        Me.LB_TServ.Size = New System.Drawing.Size(116, 20)
        Me.LB_TServ.TabIndex = 8
        Me.LB_TServ.Text = "Tipo de Servicio"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nombre, Me.NIT, Me.Saldo, Me.Consumo, Me.Servicio, Me.Tarifa})
        Me.DataGridView1.Location = New System.Drawing.Point(337, 47)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 29
        Me.DataGridView1.Size = New System.Drawing.Size(824, 320)
        Me.DataGridView1.TabIndex = 9
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.MinimumWidth = 6
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Width = 125
        '
        'NIT
        '
        Me.NIT.HeaderText = "NIT"
        Me.NIT.MinimumWidth = 6
        Me.NIT.Name = "NIT"
        Me.NIT.Width = 125
        '
        'Saldo
        '
        Me.Saldo.HeaderText = "Saldo Anterior"
        Me.Saldo.MinimumWidth = 6
        Me.Saldo.Name = "Saldo"
        Me.Saldo.Width = 125
        '
        'Consumo
        '
        Me.Consumo.HeaderText = "Consumo de Energia"
        Me.Consumo.MinimumWidth = 6
        Me.Consumo.Name = "Consumo"
        Me.Consumo.Width = 125
        '
        'Servicio
        '
        Me.Servicio.HeaderText = "Tipo de Servicio"
        Me.Servicio.MinimumWidth = 6
        Me.Servicio.Name = "Servicio"
        Me.Servicio.Width = 125
        '
        'Tarifa
        '
        Me.Tarifa.HeaderText = "Tipo de Tarifa"
        Me.Tarifa.MinimumWidth = 6
        Me.Tarifa.Name = "Tarifa"
        Me.Tarifa.Width = 125
        '
        'LB_Total
        '
        Me.LB_Total.AutoSize = True
        Me.LB_Total.Location = New System.Drawing.Point(348, 402)
        Me.LB_Total.Name = "LB_Total"
        Me.LB_Total.Size = New System.Drawing.Size(95, 20)
        Me.LB_Total.TabIndex = 11
        Me.LB_Total.Text = "Total a Pagar"
        '
        'TxtB_Total
        '
        Me.TxtB_Total.Enabled = False
        Me.TxtB_Total.Location = New System.Drawing.Point(449, 399)
        Me.TxtB_Total.Name = "TxtB_Total"
        Me.TxtB_Total.Size = New System.Drawing.Size(180, 27)
        Me.TxtB_Total.TabIndex = 12
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem2, Me.ToolStripMenuItem3, Me.ToolStripMenuItem4})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1195, 28)
        Me.MenuStrip1.TabIndex = 13
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(76, 24)
        Me.ToolStripMenuItem1.Text = "Calcular"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(74, 24)
        Me.ToolStripMenuItem2.Text = "Mostrar"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(133, 24)
        Me.ToolStripMenuItem3.Text = "Limpiar Vectores"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(52, 24)
        Me.ToolStripMenuItem4.Text = "Salir"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1195, 458)
        Me.Controls.Add(Me.TxtB_Total)
        Me.Controls.Add(Me.LB_Total)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LB_Nombre As Label
    Friend WithEvents LB_Nit As Label
    Friend WithEvents LB_SaldAnt As Label
    Friend WithEvents LB_Consumo As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents LB_TTAri As Label
    Friend WithEvents LB_TServ As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Menu_Co As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LB_Total As Label
    Friend WithEvents TxtB_Total As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents NIT As DataGridViewTextBoxColumn
    Friend WithEvents Saldo As DataGridViewTextBoxColumn
    Friend WithEvents Consumo As DataGridViewTextBoxColumn
    Friend WithEvents Servicio As DataGridViewTextBoxColumn
    Friend WithEvents Tarifa As DataGridViewTextBoxColumn
End Class
