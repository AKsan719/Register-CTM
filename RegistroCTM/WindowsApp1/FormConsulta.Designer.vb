﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormConsulta
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormConsulta))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TimeBuscaFecha = New System.Windows.Forms.DateTimePicker()
        Me.ComboBuscaCliente = New System.Windows.Forms.ComboBox()
        Me.ButtonBuscaFecha = New System.Windows.Forms.Button()
        Me.ButtonEliminar = New System.Windows.Forms.Button()
        Me.ButtonHistorial = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BuscaTotalAporte = New System.Windows.Forms.TextBox()
        Me.BuscaTotalCuota = New System.Windows.Forms.TextBox()
        Me.BuscaTotalAhorro = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBuscaTipoMoto = New System.Windows.Forms.TextBox()
        Me.TextBuscaNombreMiembro = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DataGridBusqueda = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox1.Controls.Add(Me.TimeBuscaFecha)
        Me.GroupBox1.Controls.Add(Me.ComboBuscaCliente)
        Me.GroupBox1.Controls.Add(Me.ButtonBuscaFecha)
        Me.GroupBox1.Controls.Add(Me.ButtonEliminar)
        Me.GroupBox1.Controls.Add(Me.ButtonHistorial)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(31, 20)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox1.Size = New System.Drawing.Size(1191, 124)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "BUSCAR MIEMBRO"
        '
        'TimeBuscaFecha
        '
        Me.TimeBuscaFecha.CustomFormat = ""
        Me.TimeBuscaFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.TimeBuscaFecha.Location = New System.Drawing.Point(238, 78)
        Me.TimeBuscaFecha.Name = "TimeBuscaFecha"
        Me.TimeBuscaFecha.Size = New System.Drawing.Size(351, 23)
        Me.TimeBuscaFecha.TabIndex = 24
        '
        'ComboBuscaCliente
        '
        Me.ComboBuscaCliente.FormattingEnabled = True
        Me.ComboBuscaCliente.Location = New System.Drawing.Point(238, 31)
        Me.ComboBuscaCliente.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ComboBuscaCliente.Name = "ComboBuscaCliente"
        Me.ComboBuscaCliente.Size = New System.Drawing.Size(592, 23)
        Me.ComboBuscaCliente.TabIndex = 23
        '
        'ButtonBuscaFecha
        '
        Me.ButtonBuscaFecha.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ButtonBuscaFecha.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButtonBuscaFecha.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.ButtonBuscaFecha.FlatAppearance.BorderSize = 2
        Me.ButtonBuscaFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonBuscaFecha.ForeColor = System.Drawing.Color.White
        Me.ButtonBuscaFecha.Location = New System.Drawing.Point(637, 72)
        Me.ButtonBuscaFecha.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.ButtonBuscaFecha.Name = "ButtonBuscaFecha"
        Me.ButtonBuscaFecha.Size = New System.Drawing.Size(171, 39)
        Me.ButtonBuscaFecha.TabIndex = 22
        Me.ButtonBuscaFecha.Text = "Busqueda Por Fecha"
        Me.ButtonBuscaFecha.UseVisualStyleBackColor = False
        '
        'ButtonEliminar
        '
        Me.ButtonEliminar.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ButtonEliminar.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButtonEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.ButtonEliminar.FlatAppearance.BorderSize = 2
        Me.ButtonEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonEliminar.ForeColor = System.Drawing.Color.White
        Me.ButtonEliminar.Location = New System.Drawing.Point(923, 72)
        Me.ButtonEliminar.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.ButtonEliminar.Name = "ButtonEliminar"
        Me.ButtonEliminar.Size = New System.Drawing.Size(171, 39)
        Me.ButtonEliminar.TabIndex = 22
        Me.ButtonEliminar.Text = "Eliminar Registro"
        Me.ButtonEliminar.UseVisualStyleBackColor = False
        '
        'ButtonHistorial
        '
        Me.ButtonHistorial.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ButtonHistorial.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButtonHistorial.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.ButtonHistorial.FlatAppearance.BorderSize = 2
        Me.ButtonHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonHistorial.ForeColor = System.Drawing.Color.White
        Me.ButtonHistorial.Location = New System.Drawing.Point(923, 22)
        Me.ButtonHistorial.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.ButtonHistorial.Name = "ButtonHistorial"
        Me.ButtonHistorial.Size = New System.Drawing.Size(171, 39)
        Me.ButtonHistorial.TabIndex = 22
        Me.ButtonHistorial.Text = "Buscar Historial"
        Me.ButtonHistorial.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(179, 84)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Fecha:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(117, 34)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre Cliente:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Highlight
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.BuscaTotalAporte)
        Me.GroupBox2.Controls.Add(Me.BuscaTotalCuota)
        Me.GroupBox2.Controls.Add(Me.BuscaTotalAhorro)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.TextBuscaTipoMoto)
        Me.GroupBox2.Controls.Add(Me.TextBuscaNombreMiembro)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(31, 150)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox2.Size = New System.Drawing.Size(1188, 151)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "DATOS DEL MIEMBRO"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(192, 99)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(119, 15)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Total De Aportes:"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(474, 97)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 15)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Total Cuota:"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(735, 97)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 15)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Total Ahorro:"
        '
        'BuscaTotalAporte
        '
        Me.BuscaTotalAporte.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BuscaTotalAporte.Enabled = False
        Me.BuscaTotalAporte.Location = New System.Drawing.Point(338, 94)
        Me.BuscaTotalAporte.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BuscaTotalAporte.Name = "BuscaTotalAporte"
        Me.BuscaTotalAporte.ReadOnly = True
        Me.BuscaTotalAporte.Size = New System.Drawing.Size(122, 23)
        Me.BuscaTotalAporte.TabIndex = 25
        Me.BuscaTotalAporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BuscaTotalCuota
        '
        Me.BuscaTotalCuota.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BuscaTotalCuota.Enabled = False
        Me.BuscaTotalCuota.Location = New System.Drawing.Point(587, 94)
        Me.BuscaTotalCuota.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BuscaTotalCuota.Name = "BuscaTotalCuota"
        Me.BuscaTotalCuota.ReadOnly = True
        Me.BuscaTotalCuota.Size = New System.Drawing.Size(122, 23)
        Me.BuscaTotalCuota.TabIndex = 26
        Me.BuscaTotalCuota.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BuscaTotalAhorro
        '
        Me.BuscaTotalAhorro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BuscaTotalAhorro.Enabled = False
        Me.BuscaTotalAhorro.Location = New System.Drawing.Point(854, 94)
        Me.BuscaTotalAhorro.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BuscaTotalAhorro.Name = "BuscaTotalAhorro"
        Me.BuscaTotalAhorro.ReadOnly = True
        Me.BuscaTotalAhorro.Size = New System.Drawing.Size(122, 23)
        Me.BuscaTotalAhorro.TabIndex = 27
        Me.BuscaTotalAhorro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(213, 68)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 15)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Tipo De Moto:"
        '
        'TextBuscaTipoMoto
        '
        Me.TextBuscaTipoMoto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TextBuscaTipoMoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBuscaTipoMoto.Enabled = False
        Me.TextBuscaTipoMoto.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBuscaTipoMoto.Location = New System.Drawing.Point(338, 65)
        Me.TextBuscaTipoMoto.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TextBuscaTipoMoto.Name = "TextBuscaTipoMoto"
        Me.TextBuscaTipoMoto.ReadOnly = True
        Me.TextBuscaTipoMoto.Size = New System.Drawing.Size(638, 22)
        Me.TextBuscaTipoMoto.TabIndex = 22
        Me.TextBuscaTipoMoto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBuscaNombreMiembro
        '
        Me.TextBuscaNombreMiembro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TextBuscaNombreMiembro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBuscaNombreMiembro.Enabled = False
        Me.TextBuscaNombreMiembro.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBuscaNombreMiembro.Location = New System.Drawing.Point(338, 37)
        Me.TextBuscaNombreMiembro.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TextBuscaNombreMiembro.Name = "TextBuscaNombreMiembro"
        Me.TextBuscaNombreMiembro.ReadOnly = True
        Me.TextBuscaNombreMiembro.Size = New System.Drawing.Size(638, 22)
        Me.TextBuscaNombreMiembro.TabIndex = 24
        Me.TextBuscaNombreMiembro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(163, 40)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(145, 15)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Nombres Del Cliente:"
        '
        'DataGridBusqueda
        '
        Me.DataGridBusqueda.AllowUserToAddRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridBusqueda.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridBusqueda.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridBusqueda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridBusqueda.BackgroundColor = System.Drawing.SystemColors.InactiveCaption
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridBusqueda.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridBusqueda.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridBusqueda.Location = New System.Drawing.Point(31, 307)
        Me.DataGridBusqueda.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DataGridBusqueda.Name = "DataGridBusqueda"
        Me.DataGridBusqueda.ReadOnly = True
        Me.DataGridBusqueda.Size = New System.Drawing.Size(1187, 263)
        Me.DataGridBusqueda.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Black
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(1026, 573)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(222, 14)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "© LOK Corporation. All rights reserved, 2022"
        '
        'FormConsulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(1248, 587)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DataGridBusqueda)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "FormConsulta"
        Me.Text = "CONSULTA DE MIEMBROS"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DataGridBusqueda As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonHistorial As Button
    Friend WithEvents ComboBuscaCliente As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBuscaTipoMoto As TextBox
    Friend WithEvents TextBuscaNombreMiembro As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents BuscaTotalAporte As TextBox
    Friend WithEvents BuscaTotalCuota As TextBox
    Friend WithEvents BuscaTotalAhorro As TextBox
    Friend WithEvents IdPagosDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreMiembroDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NumeroMotoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipoMotoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ConceptoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaDeEmisionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AhorroDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CuotaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RecibidoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ObservacionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EstadoDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents TimeBuscaFecha As DateTimePicker
    Friend WithEvents ButtonBuscaFecha As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents ButtonEliminar As Button
    Friend WithEvents Label5 As Label
End Class
