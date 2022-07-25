<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormRegistro
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormRegistro))
        Me.DataGridRegistro = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboTipoMoto = New System.Windows.Forms.ComboBox()
        Me.ButtonVisualizar = New System.Windows.Forms.Button()
        Me.ButtonEliminar = New System.Windows.Forms.Button()
        Me.ButtonGuardar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextNombreMiembro = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Registro_CTMDataSet = New RegistroCTM.Registro_CTMDataSet()
        Me.MiembrosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MiembrosTableAdapter = New RegistroCTM.Registro_CTMDataSetTableAdapters.MiembrosTableAdapter()
        Me.TableAdapterManager = New RegistroCTM.Registro_CTMDataSetTableAdapters.TableAdapterManager()
        CType(Me.DataGridRegistro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Registro_CTMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MiembrosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridRegistro
        '
        Me.DataGridRegistro.AllowUserToAddRows = False
        Me.DataGridRegistro.AllowUserToOrderColumns = True
        Me.DataGridRegistro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridRegistro.BackgroundColor = System.Drawing.SystemColors.InactiveCaption
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridRegistro.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridRegistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridRegistro.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridRegistro.Location = New System.Drawing.Point(17, 195)
        Me.DataGridRegistro.Name = "DataGridRegistro"
        Me.DataGridRegistro.ReadOnly = True
        Me.DataGridRegistro.Size = New System.Drawing.Size(1034, 312)
        Me.DataGridRegistro.TabIndex = 23
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.GroupBox1.Controls.Add(Me.ComboTipoMoto)
        Me.GroupBox1.Controls.Add(Me.ButtonVisualizar)
        Me.GroupBox1.Controls.Add(Me.ButtonEliminar)
        Me.GroupBox1.Controls.Add(Me.ButtonGuardar)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextNombreMiembro)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Location = New System.Drawing.Point(19, 12)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox1.Size = New System.Drawing.Size(1035, 177)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ENTRADA DE DATOS "
        '
        'ComboTipoMoto
        '
        Me.ComboTipoMoto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MiembrosBindingSource, "Moto", True))
        Me.ComboTipoMoto.FormattingEnabled = True
        Me.ComboTipoMoto.Items.AddRange(New Object() {"Combi", "Mamut"})
        Me.ComboTipoMoto.Location = New System.Drawing.Point(332, 72)
        Me.ComboTipoMoto.Name = "ComboTipoMoto"
        Me.ComboTipoMoto.Size = New System.Drawing.Size(514, 23)
        Me.ComboTipoMoto.TabIndex = 22
        '
        'ButtonVisualizar
        '
        Me.ButtonVisualizar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ButtonVisualizar.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButtonVisualizar.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.ButtonVisualizar.FlatAppearance.BorderSize = 2
        Me.ButtonVisualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonVisualizar.ForeColor = System.Drawing.Color.White
        Me.ButtonVisualizar.Location = New System.Drawing.Point(455, 128)
        Me.ButtonVisualizar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ButtonVisualizar.Name = "ButtonVisualizar"
        Me.ButtonVisualizar.Size = New System.Drawing.Size(184, 35)
        Me.ButtonVisualizar.TabIndex = 19
        Me.ButtonVisualizar.Text = "Visualizar Registro"
        Me.ButtonVisualizar.UseVisualStyleBackColor = False
        '
        'ButtonEliminar
        '
        Me.ButtonEliminar.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.ButtonEliminar.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButtonEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.ButtonEliminar.FlatAppearance.BorderSize = 2
        Me.ButtonEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonEliminar.ForeColor = System.Drawing.Color.White
        Me.ButtonEliminar.Location = New System.Drawing.Point(734, 128)
        Me.ButtonEliminar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ButtonEliminar.Name = "ButtonEliminar"
        Me.ButtonEliminar.Size = New System.Drawing.Size(184, 35)
        Me.ButtonEliminar.TabIndex = 20
        Me.ButtonEliminar.Text = "Eliminar Registro"
        Me.ButtonEliminar.UseVisualStyleBackColor = False
        '
        'ButtonGuardar
        '
        Me.ButtonGuardar.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ButtonGuardar.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButtonGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.ButtonGuardar.FlatAppearance.BorderSize = 2
        Me.ButtonGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonGuardar.ForeColor = System.Drawing.Color.White
        Me.ButtonGuardar.Location = New System.Drawing.Point(181, 128)
        Me.ButtonGuardar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ButtonGuardar.Name = "ButtonGuardar"
        Me.ButtonGuardar.Size = New System.Drawing.Size(184, 35)
        Me.ButtonGuardar.TabIndex = 21
        Me.ButtonGuardar.Text = "Guardar Registro"
        Me.ButtonGuardar.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(143, 75)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 15)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Tipo De Moto:"
        '
        'TextNombreMiembro
        '
        Me.TextNombreMiembro.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextNombreMiembro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextNombreMiembro.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextNombreMiembro.Location = New System.Drawing.Point(332, 32)
        Me.TextNombreMiembro.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TextNombreMiembro.Name = "TextNombreMiembro"
        Me.TextNombreMiembro.Size = New System.Drawing.Size(514, 22)
        Me.TextNombreMiembro.TabIndex = 18
        Me.TextNombreMiembro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(101, 37)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 15)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Nombres Del Cliente:"
        '
        'Registro_CTMDataSet
        '
        Me.Registro_CTMDataSet.DataSetName = "Registro_CTMDataSet"
        Me.Registro_CTMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MiembrosBindingSource
        '
        Me.MiembrosBindingSource.DataMember = "Miembros"
        Me.MiembrosBindingSource.DataSource = Me.Registro_CTMDataSet
        '
        'MiembrosTableAdapter
        '
        Me.MiembrosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.MiembrosTableAdapter = Me.MiembrosTableAdapter
        Me.TableAdapterManager.PagosTableAdapter = Nothing
        Me.TableAdapterManager.RetiroTableAdapter = Nothing
        Me.TableAdapterManager.TipoTableAdapter = Nothing
        Me.TableAdapterManager.TotalesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = RegistroCTM.Registro_CTMDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FormRegistro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1067, 519)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridRegistro)
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "FormRegistro"
        Me.Text = "REGISTRO DE MIEMBROS"
        CType(Me.DataGridRegistro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Registro_CTMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MiembrosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridRegistro As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ButtonVisualizar As Button
    Friend WithEvents ButtonEliminar As Button
    Friend WithEvents ButtonGuardar As Button
    Friend WithEvents TextNombreMiembro As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboTipoMoto As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Registro_CTMDataSet As Registro_CTMDataSet
    Friend WithEvents MiembrosBindingSource As BindingSource
    Friend WithEvents MiembrosTableAdapter As Registro_CTMDataSetTableAdapters.MiembrosTableAdapter
    Friend WithEvents TableAdapterManager As Registro_CTMDataSetTableAdapters.TableAdapterManager
End Class
