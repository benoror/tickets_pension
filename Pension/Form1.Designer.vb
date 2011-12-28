<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabEntradas = New System.Windows.Forms.TabPage
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.VistaEntradas = New System.Windows.Forms.DataGridView
        Me.EntradaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.VehiculoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PlacasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Cajon = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Llave = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EntradasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AccessDataSet = New Pension.accessDataSet
        Me.nueva_salida_diaria_button = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.cajon_entrada = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.llave_entrada = New System.Windows.Forms.ComboBox
        Me.llave_checkbox_entrada = New System.Windows.Forms.CheckBox
        Me.nueva_entrada_button = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.color_entrada = New System.Windows.Forms.TextBox
        Me.placas_entrada = New System.Windows.Forms.TextBox
        Me.vehiculo_entrada = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TabSalidas = New System.Windows.Forms.TabPage
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.imprimir_button = New System.Windows.Forms.Button
        Me.label_corte = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.corte_button = New System.Windows.Forms.Button
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.VistaSalidas = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Salida = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Tarifa = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TabConf = New System.Windows.Forms.TabPage
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.conf_llaves = New System.Windows.Forms.TextBox
        Me.conf_cajones = New System.Windows.Forms.TextBox
        Me.label_pass = New System.Windows.Forms.Label
        Me.conf_pass = New System.Windows.Forms.TextBox
        Me.save_conf = New System.Windows.Forms.Button
        Me.modify_conf = New System.Windows.Forms.Button
        Me.conf_tarifa_hora = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.conf_tarifa_mes = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.conf_tarifa_dia = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.hora_label = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel
        Me.fecha_label = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.timer = New System.Windows.Forms.Timer(Me.components)
        Me.Label6 = New System.Windows.Forms.Label
        Me.EntradasTableAdapter = New Pension.accessDataSetTableAdapters.EntradasSalidasTableAdapter
        Me.TabControl1.SuspendLayout()
        Me.TabEntradas.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaEntradas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EntradasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccessDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabSalidas.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaSalidas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabConf.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.TabControl1.Controls.Add(Me.TabEntradas)
        Me.TabControl1.Controls.Add(Me.TabSalidas)
        Me.TabControl1.Controls.Add(Me.TabConf)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(716, 495)
        Me.TabControl1.TabIndex = 0
        '
        'TabEntradas
        '
        Me.TabEntradas.Controls.Add(Me.GroupBox2)
        Me.TabEntradas.Controls.Add(Me.GroupBox1)
        Me.TabEntradas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabEntradas.Location = New System.Drawing.Point(4, 25)
        Me.TabEntradas.Name = "TabEntradas"
        Me.TabEntradas.Padding = New System.Windows.Forms.Padding(3)
        Me.TabEntradas.Size = New System.Drawing.Size(708, 466)
        Me.TabEntradas.TabIndex = 0
        Me.TabEntradas.Text = "ENTRADAS"
        Me.TabEntradas.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PictureBox2)
        Me.GroupBox2.Controls.Add(Me.VistaEntradas)
        Me.GroupBox2.Controls.Add(Me.nueva_salida_diaria_button)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GroupBox2.Location = New System.Drawing.Point(6, 109)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(688, 351)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "       Entradas"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(13, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 14
        Me.PictureBox2.TabStop = False
        '
        'VistaEntradas
        '
        Me.VistaEntradas.AllowUserToAddRows = False
        Me.VistaEntradas.AllowUserToDeleteRows = False
        Me.VistaEntradas.AllowUserToResizeRows = False
        Me.VistaEntradas.AutoGenerateColumns = False
        Me.VistaEntradas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.VistaEntradas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.VistaEntradas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.VistaEntradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VistaEntradas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EntradaDataGridViewTextBoxColumn, Me.VehiculoDataGridViewTextBoxColumn, Me.ColorDataGridViewTextBoxColumn, Me.PlacasDataGridViewTextBoxColumn, Me.Cajon, Me.Llave})
        Me.VistaEntradas.DataSource = Me.EntradasBindingSource
        Me.VistaEntradas.Location = New System.Drawing.Point(6, 30)
        Me.VistaEntradas.MultiSelect = False
        Me.VistaEntradas.Name = "VistaEntradas"
        Me.VistaEntradas.ReadOnly = True
        Me.VistaEntradas.RowHeadersVisible = False
        Me.VistaEntradas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.VistaEntradas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.VistaEntradas.Size = New System.Drawing.Size(676, 272)
        Me.VistaEntradas.StandardTab = True
        Me.VistaEntradas.TabIndex = 12
        '
        'EntradaDataGridViewTextBoxColumn
        '
        Me.EntradaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.EntradaDataGridViewTextBoxColumn.DataPropertyName = "Entrada"
        Me.EntradaDataGridViewTextBoxColumn.HeaderText = "Entrada"
        Me.EntradaDataGridViewTextBoxColumn.Name = "EntradaDataGridViewTextBoxColumn"
        Me.EntradaDataGridViewTextBoxColumn.ReadOnly = True
        Me.EntradaDataGridViewTextBoxColumn.Width = 91
        '
        'VehiculoDataGridViewTextBoxColumn
        '
        Me.VehiculoDataGridViewTextBoxColumn.DataPropertyName = "Vehiculo"
        Me.VehiculoDataGridViewTextBoxColumn.HeaderText = "Vehiculo"
        Me.VehiculoDataGridViewTextBoxColumn.Name = "VehiculoDataGridViewTextBoxColumn"
        Me.VehiculoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ColorDataGridViewTextBoxColumn
        '
        Me.ColorDataGridViewTextBoxColumn.DataPropertyName = "Color"
        Me.ColorDataGridViewTextBoxColumn.HeaderText = "Color"
        Me.ColorDataGridViewTextBoxColumn.Name = "ColorDataGridViewTextBoxColumn"
        Me.ColorDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PlacasDataGridViewTextBoxColumn
        '
        Me.PlacasDataGridViewTextBoxColumn.DataPropertyName = "Placas"
        Me.PlacasDataGridViewTextBoxColumn.HeaderText = "Placas"
        Me.PlacasDataGridViewTextBoxColumn.Name = "PlacasDataGridViewTextBoxColumn"
        Me.PlacasDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Cajon
        '
        Me.Cajon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Cajon.DataPropertyName = "Cajon"
        Me.Cajon.HeaderText = "C#"
        Me.Cajon.Name = "Cajon"
        Me.Cajon.ReadOnly = True
        Me.Cajon.Width = 54
        '
        'Llave
        '
        Me.Llave.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Llave.DataPropertyName = "Llave"
        Me.Llave.HeaderText = "L#"
        Me.Llave.Name = "Llave"
        Me.Llave.ReadOnly = True
        Me.Llave.Width = 52
        '
        'EntradasBindingSource
        '
        Me.EntradasBindingSource.DataMember = "EntradasSalidas"
        Me.EntradasBindingSource.DataSource = Me.AccessDataSet
        '
        'AccessDataSet
        '
        Me.AccessDataSet.DataSetName = "accessDataSet"
        Me.AccessDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'nueva_salida_diaria_button
        '
        Me.nueva_salida_diaria_button.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.nueva_salida_diaria_button.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nueva_salida_diaria_button.Location = New System.Drawing.Point(506, 306)
        Me.nueva_salida_diaria_button.Name = "nueva_salida_diaria_button"
        Me.nueva_salida_diaria_button.Size = New System.Drawing.Size(176, 37)
        Me.nueva_salida_diaria_button.TabIndex = 10
        Me.nueva_salida_diaria_button.Text = "Nueva Salida"
        Me.nueva_salida_diaria_button.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.cajon_entrada)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.llave_entrada)
        Me.GroupBox1.Controls.Add(Me.llave_checkbox_entrada)
        Me.GroupBox1.Controls.Add(Me.nueva_entrada_button)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.color_entrada)
        Me.GroupBox1.Controls.Add(Me.placas_entrada)
        Me.GroupBox1.Controls.Add(Me.vehiculo_entrada)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(688, 97)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "      Nueva Entrada"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(10, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'cajon_entrada
        '
        Me.cajon_entrada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cajon_entrada.FormattingEnabled = True
        Me.cajon_entrada.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9"})
        Me.cajon_entrada.Location = New System.Drawing.Point(288, 60)
        Me.cajon_entrada.MaxLength = 255
        Me.cajon_entrada.Name = "cajon_entrada"
        Me.cajon_entrada.Size = New System.Drawing.Size(177, 28)
        Me.cajon_entrada.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label7.Location = New System.Drawing.Point(243, 63)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Cajon"
        '
        'llave_entrada
        '
        Me.llave_entrada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.llave_entrada.Enabled = False
        Me.llave_entrada.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9"})
        Me.llave_entrada.Location = New System.Drawing.Point(533, 25)
        Me.llave_entrada.MaxLength = 255
        Me.llave_entrada.Name = "llave_entrada"
        Me.llave_entrada.Size = New System.Drawing.Size(149, 28)
        Me.llave_entrada.TabIndex = 6
        '
        'llave_checkbox_entrada
        '
        Me.llave_checkbox_entrada.AutoSize = True
        Me.llave_checkbox_entrada.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llave_checkbox_entrada.Location = New System.Drawing.Point(477, 27)
        Me.llave_checkbox_entrada.Name = "llave_checkbox_entrada"
        Me.llave_checkbox_entrada.Size = New System.Drawing.Size(52, 17)
        Me.llave_checkbox_entrada.TabIndex = 5
        Me.llave_checkbox_entrada.Text = "Llave"
        Me.llave_checkbox_entrada.UseVisualStyleBackColor = True
        '
        'nueva_entrada_button
        '
        Me.nueva_entrada_button.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.nueva_entrada_button.FlatAppearance.BorderSize = 2
        Me.nueva_entrada_button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nueva_entrada_button.Location = New System.Drawing.Point(477, 59)
        Me.nueva_entrada_button.Name = "nueva_entrada_button"
        Me.nueva_entrada_button.Size = New System.Drawing.Size(205, 29)
        Me.nueva_entrada_button.TabIndex = 7
        Me.nueva_entrada_button.Text = "Nueva Entrada"
        Me.nueva_entrada_button.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label3.Location = New System.Drawing.Point(243, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Placas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label2.Location = New System.Drawing.Point(6, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Color"
        '
        'color_entrada
        '
        Me.color_entrada.BackColor = System.Drawing.Color.White
        Me.color_entrada.Location = New System.Drawing.Point(60, 60)
        Me.color_entrada.MaxLength = 255
        Me.color_entrada.Name = "color_entrada"
        Me.color_entrada.Size = New System.Drawing.Size(177, 26)
        Me.color_entrada.TabIndex = 2
        '
        'placas_entrada
        '
        Me.placas_entrada.BackColor = System.Drawing.Color.White
        Me.placas_entrada.Location = New System.Drawing.Point(288, 25)
        Me.placas_entrada.MaxLength = 255
        Me.placas_entrada.Name = "placas_entrada"
        Me.placas_entrada.Size = New System.Drawing.Size(177, 26)
        Me.placas_entrada.TabIndex = 3
        '
        'vehiculo_entrada
        '
        Me.vehiculo_entrada.BackColor = System.Drawing.Color.White
        Me.vehiculo_entrada.Location = New System.Drawing.Point(60, 25)
        Me.vehiculo_entrada.MaxLength = 255
        Me.vehiculo_entrada.Name = "vehiculo_entrada"
        Me.vehiculo_entrada.Size = New System.Drawing.Size(177, 26)
        Me.vehiculo_entrada.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label1.Location = New System.Drawing.Point(6, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Vehiculo"
        '
        'TabSalidas
        '
        Me.TabSalidas.Controls.Add(Me.GroupBox3)
        Me.TabSalidas.Location = New System.Drawing.Point(4, 25)
        Me.TabSalidas.Name = "TabSalidas"
        Me.TabSalidas.Padding = New System.Windows.Forms.Padding(3)
        Me.TabSalidas.Size = New System.Drawing.Size(708, 466)
        Me.TabSalidas.TabIndex = 1
        Me.TabSalidas.Text = "SALIDAS"
        Me.TabSalidas.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.imprimir_button)
        Me.GroupBox3.Controls.Add(Me.label_corte)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.corte_button)
        Me.GroupBox3.Controls.Add(Me.PictureBox3)
        Me.GroupBox3.Controls.Add(Me.VistaSalidas)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GroupBox3.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(696, 454)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "       Salidas"
        '
        'imprimir_button
        '
        Me.imprimir_button.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.imprimir_button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.imprimir_button.Location = New System.Drawing.Point(546, 14)
        Me.imprimir_button.Name = "imprimir_button"
        Me.imprimir_button.Size = New System.Drawing.Size(144, 37)
        Me.imprimir_button.TabIndex = 19
        Me.imprimir_button.Text = "Imprimir Ticket"
        Me.imprimir_button.UseVisualStyleBackColor = False
        '
        'label_corte
        '
        Me.label_corte.AutoSize = True
        Me.label_corte.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_corte.Location = New System.Drawing.Point(425, 426)
        Me.label_corte.Name = "label_corte"
        Me.label_corte.Size = New System.Drawing.Size(16, 16)
        Me.label_corte.TabIndex = 18
        Me.label_corte.Text = "_"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(322, 426)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(97, 16)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "Ultimo Corte:"
        '
        'corte_button
        '
        Me.corte_button.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.corte_button.FlatAppearance.BorderSize = 2
        Me.corte_button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.corte_button.Location = New System.Drawing.Point(6, 419)
        Me.corte_button.Name = "corte_button"
        Me.corte_button.Size = New System.Drawing.Size(310, 29)
        Me.corte_button.TabIndex = 16
        Me.corte_button.Text = "Realizar Corte y Generar Reporte"
        Me.corte_button.UseVisualStyleBackColor = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(12, 0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 15
        Me.PictureBox3.TabStop = False
        '
        'VistaSalidas
        '
        Me.VistaSalidas.AllowUserToAddRows = False
        Me.VistaSalidas.AllowUserToDeleteRows = False
        Me.VistaSalidas.AllowUserToResizeRows = False
        Me.VistaSalidas.AutoGenerateColumns = False
        Me.VistaSalidas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.VistaSalidas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.VistaSalidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VistaSalidas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.Salida, Me.Tarifa, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.VistaSalidas.DataSource = Me.EntradasBindingSource
        Me.VistaSalidas.Location = New System.Drawing.Point(6, 57)
        Me.VistaSalidas.MultiSelect = False
        Me.VistaSalidas.Name = "VistaSalidas"
        Me.VistaSalidas.ReadOnly = True
        Me.VistaSalidas.RowHeadersVisible = False
        Me.VistaSalidas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.VistaSalidas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.VistaSalidas.Size = New System.Drawing.Size(684, 356)
        Me.VistaSalidas.StandardTab = True
        Me.VistaSalidas.TabIndex = 13
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Entrada"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Entrada"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 91
        '
        'Salida
        '
        Me.Salida.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Salida.DataPropertyName = "Salida"
        Me.Salida.HeaderText = "Salida"
        Me.Salida.Name = "Salida"
        Me.Salida.ReadOnly = True
        Me.Salida.Width = 78
        '
        'Tarifa
        '
        Me.Tarifa.DataPropertyName = "Tarifa"
        Me.Tarifa.HeaderText = "Tarifa"
        Me.Tarifa.Name = "Tarifa"
        Me.Tarifa.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Vehiculo"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Vehiculo"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Color"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Color"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Placas"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Placas"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'TabConf
        '
        Me.TabConf.Controls.Add(Me.Label11)
        Me.TabConf.Controls.Add(Me.Label10)
        Me.TabConf.Controls.Add(Me.conf_llaves)
        Me.TabConf.Controls.Add(Me.conf_cajones)
        Me.TabConf.Controls.Add(Me.label_pass)
        Me.TabConf.Controls.Add(Me.conf_pass)
        Me.TabConf.Controls.Add(Me.save_conf)
        Me.TabConf.Controls.Add(Me.modify_conf)
        Me.TabConf.Controls.Add(Me.conf_tarifa_hora)
        Me.TabConf.Controls.Add(Me.Label9)
        Me.TabConf.Controls.Add(Me.conf_tarifa_mes)
        Me.TabConf.Controls.Add(Me.Label5)
        Me.TabConf.Controls.Add(Me.conf_tarifa_dia)
        Me.TabConf.Controls.Add(Me.Label4)
        Me.TabConf.Location = New System.Drawing.Point(4, 25)
        Me.TabConf.Name = "TabConf"
        Me.TabConf.Size = New System.Drawing.Size(708, 466)
        Me.TabConf.TabIndex = 2
        Me.TabConf.Text = "CONFIGURACION"
        Me.TabConf.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(166, 147)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(65, 20)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "Llaves:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(152, 115)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(79, 20)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Cajones:"
        '
        'conf_llaves
        '
        Me.conf_llaves.Enabled = False
        Me.conf_llaves.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.conf_llaves.Location = New System.Drawing.Point(237, 144)
        Me.conf_llaves.Name = "conf_llaves"
        Me.conf_llaves.Size = New System.Drawing.Size(177, 26)
        Me.conf_llaves.TabIndex = 15
        Me.conf_llaves.Text = "0"
        '
        'conf_cajones
        '
        Me.conf_cajones.Enabled = False
        Me.conf_cajones.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.conf_cajones.Location = New System.Drawing.Point(237, 112)
        Me.conf_cajones.Name = "conf_cajones"
        Me.conf_cajones.Size = New System.Drawing.Size(177, 26)
        Me.conf_cajones.TabIndex = 14
        Me.conf_cajones.Text = "0"
        '
        'label_pass
        '
        Me.label_pass.AutoSize = True
        Me.label_pass.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_pass.Location = New System.Drawing.Point(125, 179)
        Me.label_pass.Name = "label_pass"
        Me.label_pass.Size = New System.Drawing.Size(107, 20)
        Me.label_pass.TabIndex = 13
        Me.label_pass.Text = "Contraseña:"
        Me.label_pass.Visible = False
        '
        'conf_pass
        '
        Me.conf_pass.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.conf_pass.Location = New System.Drawing.Point(237, 176)
        Me.conf_pass.Name = "conf_pass"
        Me.conf_pass.Size = New System.Drawing.Size(177, 26)
        Me.conf_pass.TabIndex = 12
        Me.conf_pass.Text = "secret"
        Me.conf_pass.Visible = False
        '
        'save_conf
        '
        Me.save_conf.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.save_conf.Location = New System.Drawing.Point(311, 208)
        Me.save_conf.Name = "save_conf"
        Me.save_conf.Size = New System.Drawing.Size(104, 30)
        Me.save_conf.TabIndex = 11
        Me.save_conf.Text = "Guardar"
        Me.save_conf.UseVisualStyleBackColor = True
        '
        'modify_conf
        '
        Me.modify_conf.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.modify_conf.Location = New System.Drawing.Point(201, 208)
        Me.modify_conf.Name = "modify_conf"
        Me.modify_conf.Size = New System.Drawing.Size(104, 30)
        Me.modify_conf.TabIndex = 10
        Me.modify_conf.Text = "Modificar"
        Me.modify_conf.UseVisualStyleBackColor = True
        '
        'conf_tarifa_hora
        '
        Me.conf_tarifa_hora.Enabled = False
        Me.conf_tarifa_hora.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.conf_tarifa_hora.Location = New System.Drawing.Point(238, 16)
        Me.conf_tarifa_hora.Name = "conf_tarifa_hora"
        Me.conf_tarifa_hora.Size = New System.Drawing.Size(177, 26)
        Me.conf_tarifa_hora.TabIndex = 9
        Me.conf_tarifa_hora.Text = "0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(39, 19)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(193, 20)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Tarifa Hora ó Fracción:"
        '
        'conf_tarifa_mes
        '
        Me.conf_tarifa_mes.Enabled = False
        Me.conf_tarifa_mes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.conf_tarifa_mes.Location = New System.Drawing.Point(238, 80)
        Me.conf_tarifa_mes.Name = "conf_tarifa_mes"
        Me.conf_tarifa_mes.Size = New System.Drawing.Size(177, 26)
        Me.conf_tarifa_mes.TabIndex = 7
        Me.conf_tarifa_mes.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(100, 83)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(132, 20)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Tarifa Mensual:"
        '
        'conf_tarifa_dia
        '
        Me.conf_tarifa_dia.Enabled = False
        Me.conf_tarifa_dia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.conf_tarifa_dia.Location = New System.Drawing.Point(238, 48)
        Me.conf_tarifa_dia.Name = "conf_tarifa_dia"
        Me.conf_tarifa_dia.Size = New System.Drawing.Size(177, 26)
        Me.conf_tarifa_dia.TabIndex = 5
        Me.conf_tarifa_dia.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(119, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Tarifa Diaria:"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.hora_label, Me.ToolStripStatusLabel3, Me.fecha_label, Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 517)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StatusStrip1.Size = New System.Drawing.Size(740, 22)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'hora_label
        '
        Me.hora_label.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hora_label.Name = "hora_label"
        Me.hora_label.Size = New System.Drawing.Size(14, 17)
        Me.hora_label.Text = "_"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(34, 17)
        Me.ToolStripStatusLabel3.Text = "Hora:"
        '
        'fecha_label
        '
        Me.fecha_label.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecha_label.Name = "fecha_label"
        Me.fecha_label.Size = New System.Drawing.Size(14, 17)
        Me.fecha_label.Text = "_"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(40, 17)
        Me.ToolStripStatusLabel1.Text = "Fecha:"
        '
        'timer
        '
        Me.timer.Enabled = True
        Me.timer.Interval = 200
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(547, 4)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(179, 24)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Pension Gasomax"
        '
        'EntradasTableAdapter
        '
        Me.EntradasTableAdapter.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(740, 539)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pension"
        Me.TabControl1.ResumeLayout(False)
        Me.TabEntradas.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaEntradas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EntradasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccessDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabSalidas.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaSalidas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabConf.ResumeLayout(False)
        Me.TabConf.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabEntradas As System.Windows.Forms.TabPage
    Friend WithEvents TabSalidas As System.Windows.Forms.TabPage
    Friend WithEvents TabConf As System.Windows.Forms.TabPage
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents fecha_label As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents hora_label As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents timer As System.Windows.Forms.Timer
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents vehiculo_entrada As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents color_entrada As System.Windows.Forms.TextBox
    Friend WithEvents placas_entrada As System.Windows.Forms.TextBox
    Friend WithEvents nueva_entrada_button As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents nueva_salida_diaria_button As System.Windows.Forms.Button
    Friend WithEvents VistaEntradas As System.Windows.Forms.DataGridView
    Friend WithEvents EntradasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents VistaSalidas As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents conf_tarifa_dia As System.Windows.Forms.TextBox
    Friend WithEvents conf_tarifa_mes As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents llave_entrada As System.Windows.Forms.ComboBox
    Friend WithEvents llave_checkbox_entrada As System.Windows.Forms.CheckBox
    Friend WithEvents cajon_entrada As System.Windows.Forms.ComboBox
    Friend WithEvents AccessDataSet As Pension.accessDataSet
    Friend WithEvents EntradasTableAdapter As Pension.accessDataSetTableAdapters.EntradasSalidasTableAdapter
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents conf_tarifa_hora As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents save_conf As System.Windows.Forms.Button
    Friend WithEvents modify_conf As System.Windows.Forms.Button
    Friend WithEvents label_pass As System.Windows.Forms.Label
    Friend WithEvents conf_pass As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents conf_llaves As System.Windows.Forms.TextBox
    Friend WithEvents conf_cajones As System.Windows.Forms.TextBox
    Friend WithEvents label_corte As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents corte_button As System.Windows.Forms.Button
    Friend WithEvents imprimir_button As System.Windows.Forms.Button
    Friend WithEvents EntradaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VehiculoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PlacasDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cajon As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Llave As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Salida As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tarifa As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
