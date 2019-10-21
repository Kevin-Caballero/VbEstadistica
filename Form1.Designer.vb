<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.topWrapper = New System.Windows.Forms.Panel()
        Me.menuSidebar = New Bunifu.Framework.UI.BunifuImageButton()
        Me.maximize = New System.Windows.Forms.PictureBox()
        Me.minimize = New System.Windows.Forms.PictureBox()
        Me.restore = New System.Windows.Forms.PictureBox()
        Me.close = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.sidebarWrapper = New System.Windows.Forms.Panel()
        Me.sidebar = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.BunifuFlatButton4 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton3 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton2 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton1 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.sidebarLine = New Bunifu.Framework.UI.BunifuSeparator()
        Me.wrapper = New System.Windows.Forms.Panel()
        Me.newDataScreen = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNota = New System.Windows.Forms.TextBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.mainScreen = New System.Windows.Forms.Panel()
        Me.txtTamDeMuestra = New System.Windows.Forms.TextBox()
        Me.btnMedia = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnMaximo = New System.Windows.Forms.Button()
        Me.txtMaximo = New System.Windows.Forms.TextBox()
        Me.txtMedia = New System.Windows.Forms.TextBox()
        Me.changeDataScreen = New System.Windows.Forms.Panel()
        Me.txtNotaChange = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNombreChange = New System.Windows.Forms.TextBox()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.txtPosicion = New System.Windows.Forms.TextBox()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.topWrapper.SuspendLayout()
        CType(Me.menuSidebar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.maximize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.minimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.restore, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.close, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.sidebarWrapper.SuspendLayout()
        Me.sidebar.SuspendLayout()
        Me.wrapper.SuspendLayout()
        Me.newDataScreen.SuspendLayout()
        Me.mainScreen.SuspendLayout()
        Me.changeDataScreen.SuspendLayout()
        Me.SuspendLayout()
        '
        'topWrapper
        '
        Me.topWrapper.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.topWrapper.Controls.Add(Me.menuSidebar)
        Me.topWrapper.Controls.Add(Me.maximize)
        Me.topWrapper.Controls.Add(Me.minimize)
        Me.topWrapper.Controls.Add(Me.restore)
        Me.topWrapper.Controls.Add(Me.close)
        Me.topWrapper.Controls.Add(Me.Label1)
        Me.topWrapper.Dock = System.Windows.Forms.DockStyle.Top
        Me.topWrapper.Location = New System.Drawing.Point(0, 0)
        Me.topWrapper.Name = "topWrapper"
        Me.topWrapper.Size = New System.Drawing.Size(820, 47)
        Me.topWrapper.TabIndex = 0
        '
        'menuSidebar
        '
        Me.menuSidebar.BackColor = System.Drawing.Color.Transparent
        Me.menuSidebar.Image = CType(resources.GetObject("menuSidebar.Image"), System.Drawing.Image)
        Me.menuSidebar.ImageActive = Nothing
        Me.menuSidebar.Location = New System.Drawing.Point(11, 11)
        Me.menuSidebar.Name = "menuSidebar"
        Me.menuSidebar.Size = New System.Drawing.Size(29, 25)
        Me.menuSidebar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.menuSidebar.TabIndex = 5
        Me.menuSidebar.TabStop = False
        Me.menuSidebar.Zoom = 10
        '
        'maximize
        '
        Me.maximize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.maximize.Image = CType(resources.GetObject("maximize.Image"), System.Drawing.Image)
        Me.maximize.Location = New System.Drawing.Point(744, 11)
        Me.maximize.Name = "maximize"
        Me.maximize.Size = New System.Drawing.Size(29, 25)
        Me.maximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.maximize.TabIndex = 4
        Me.maximize.TabStop = False
        '
        'minimize
        '
        Me.minimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.minimize.Image = CType(resources.GetObject("minimize.Image"), System.Drawing.Image)
        Me.minimize.Location = New System.Drawing.Point(709, 12)
        Me.minimize.Name = "minimize"
        Me.minimize.Size = New System.Drawing.Size(29, 25)
        Me.minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.minimize.TabIndex = 1
        Me.minimize.TabStop = False
        '
        'restore
        '
        Me.restore.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.restore.Image = CType(resources.GetObject("restore.Image"), System.Drawing.Image)
        Me.restore.Location = New System.Drawing.Point(744, 11)
        Me.restore.Name = "restore"
        Me.restore.Size = New System.Drawing.Size(29, 25)
        Me.restore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.restore.TabIndex = 3
        Me.restore.TabStop = False
        Me.restore.Visible = False
        '
        'close
        '
        Me.close.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.close.Image = CType(resources.GetObject("close.Image"), System.Drawing.Image)
        Me.close.Location = New System.Drawing.Point(779, 12)
        Me.close.Name = "close"
        Me.close.Size = New System.Drawing.Size(29, 25)
        Me.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.close.TabIndex = 2
        Me.close.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(46, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 26)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ESTADISTICA"
        '
        'sidebarWrapper
        '
        Me.sidebarWrapper.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.sidebarWrapper.Controls.Add(Me.sidebar)
        Me.sidebarWrapper.Dock = System.Windows.Forms.DockStyle.Left
        Me.sidebarWrapper.Location = New System.Drawing.Point(0, 47)
        Me.sidebarWrapper.Name = "sidebarWrapper"
        Me.sidebarWrapper.Size = New System.Drawing.Size(208, 405)
        Me.sidebarWrapper.TabIndex = 1
        '
        'sidebar
        '
        Me.sidebar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.sidebar.BackgroundImage = CType(resources.GetObject("sidebar.BackgroundImage"), System.Drawing.Image)
        Me.sidebar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.sidebar.Controls.Add(Me.BunifuFlatButton4)
        Me.sidebar.Controls.Add(Me.BunifuFlatButton3)
        Me.sidebar.Controls.Add(Me.BunifuFlatButton2)
        Me.sidebar.Controls.Add(Me.BunifuFlatButton1)
        Me.sidebar.Controls.Add(Me.sidebarLine)
        Me.sidebar.GradientBottomLeft = System.Drawing.Color.DarkSlateBlue
        Me.sidebar.GradientBottomRight = System.Drawing.Color.HotPink
        Me.sidebar.GradientTopLeft = System.Drawing.Color.Plum
        Me.sidebar.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.sidebar.Location = New System.Drawing.Point(11, 9)
        Me.sidebar.Name = "sidebar"
        Me.sidebar.Quality = 10
        Me.sidebar.Size = New System.Drawing.Size(188, 387)
        Me.sidebar.TabIndex = 0
        '
        'BunifuFlatButton4
        '
        Me.BunifuFlatButton4.Activecolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton4.BackColor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton4.BorderRadius = 0
        Me.BunifuFlatButton4.ButtonText = "      Home"
        Me.BunifuFlatButton4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton4.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton4.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton4.Iconimage = CType(resources.GetObject("BunifuFlatButton4.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton4.Iconimage_right = Nothing
        Me.BunifuFlatButton4.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton4.Iconimage_Selected = Nothing
        Me.BunifuFlatButton4.IconMarginLeft = 0
        Me.BunifuFlatButton4.IconMarginRight = 0
        Me.BunifuFlatButton4.IconRightVisible = True
        Me.BunifuFlatButton4.IconRightZoom = 0R
        Me.BunifuFlatButton4.IconVisible = True
        Me.BunifuFlatButton4.IconZoom = 60.0R
        Me.BunifuFlatButton4.IsTab = False
        Me.BunifuFlatButton4.Location = New System.Drawing.Point(16, 50)
        Me.BunifuFlatButton4.Name = "BunifuFlatButton4"
        Me.BunifuFlatButton4.Normalcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton4.OnHovercolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton4.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton4.selected = False
        Me.BunifuFlatButton4.Size = New System.Drawing.Size(167, 48)
        Me.BunifuFlatButton4.TabIndex = 4
        Me.BunifuFlatButton4.Text = "      Home"
        Me.BunifuFlatButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton4.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton4.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuFlatButton3
        '
        Me.BunifuFlatButton3.Activecolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton3.BackColor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton3.BorderRadius = 0
        Me.BunifuFlatButton3.ButtonText = "      Informe"
        Me.BunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton3.Iconimage = CType(resources.GetObject("BunifuFlatButton3.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton3.Iconimage_right = Nothing
        Me.BunifuFlatButton3.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton3.Iconimage_Selected = Nothing
        Me.BunifuFlatButton3.IconMarginLeft = 0
        Me.BunifuFlatButton3.IconMarginRight = 0
        Me.BunifuFlatButton3.IconRightVisible = True
        Me.BunifuFlatButton3.IconRightZoom = 0R
        Me.BunifuFlatButton3.IconVisible = True
        Me.BunifuFlatButton3.IconZoom = 50.0R
        Me.BunifuFlatButton3.IsTab = False
        Me.BunifuFlatButton3.Location = New System.Drawing.Point(16, 212)
        Me.BunifuFlatButton3.Name = "BunifuFlatButton3"
        Me.BunifuFlatButton3.Normalcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton3.OnHovercolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton3.selected = False
        Me.BunifuFlatButton3.Size = New System.Drawing.Size(167, 48)
        Me.BunifuFlatButton3.TabIndex = 3
        Me.BunifuFlatButton3.Text = "      Informe"
        Me.BunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton3.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton3.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuFlatButton2
        '
        Me.BunifuFlatButton2.Activecolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton2.BorderRadius = 0
        Me.BunifuFlatButton2.ButtonText = "      Cambiar Dato"
        Me.BunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton2.Iconimage = CType(resources.GetObject("BunifuFlatButton2.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton2.Iconimage_right = Nothing
        Me.BunifuFlatButton2.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton2.Iconimage_Selected = Nothing
        Me.BunifuFlatButton2.IconMarginLeft = 0
        Me.BunifuFlatButton2.IconMarginRight = 0
        Me.BunifuFlatButton2.IconRightVisible = True
        Me.BunifuFlatButton2.IconRightZoom = 0R
        Me.BunifuFlatButton2.IconVisible = True
        Me.BunifuFlatButton2.IconZoom = 50.0R
        Me.BunifuFlatButton2.IsTab = False
        Me.BunifuFlatButton2.Location = New System.Drawing.Point(16, 158)
        Me.BunifuFlatButton2.Name = "BunifuFlatButton2"
        Me.BunifuFlatButton2.Normalcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton2.OnHovercolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton2.selected = False
        Me.BunifuFlatButton2.Size = New System.Drawing.Size(167, 48)
        Me.BunifuFlatButton2.TabIndex = 2
        Me.BunifuFlatButton2.Text = "      Cambiar Dato"
        Me.BunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton2.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton2.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuFlatButton1
        '
        Me.BunifuFlatButton1.Activecolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton1.BorderRadius = 0
        Me.BunifuFlatButton1.ButtonText = "      Nuevo Dato"
        Me.BunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.Iconimage = CType(resources.GetObject("BunifuFlatButton1.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton1.Iconimage_right = Nothing
        Me.BunifuFlatButton1.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton1.Iconimage_Selected = Nothing
        Me.BunifuFlatButton1.IconMarginLeft = 0
        Me.BunifuFlatButton1.IconMarginRight = 0
        Me.BunifuFlatButton1.IconRightVisible = True
        Me.BunifuFlatButton1.IconRightZoom = 0R
        Me.BunifuFlatButton1.IconVisible = True
        Me.BunifuFlatButton1.IconZoom = 50.0R
        Me.BunifuFlatButton1.IsTab = False
        Me.BunifuFlatButton1.Location = New System.Drawing.Point(16, 104)
        Me.BunifuFlatButton1.Name = "BunifuFlatButton1"
        Me.BunifuFlatButton1.Normalcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.OnHovercolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton1.selected = False
        Me.BunifuFlatButton1.Size = New System.Drawing.Size(167, 48)
        Me.BunifuFlatButton1.TabIndex = 1
        Me.BunifuFlatButton1.Text = "      Nuevo Dato"
        Me.BunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton1.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton1.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'sidebarLine
        '
        Me.sidebarLine.BackColor = System.Drawing.Color.Transparent
        Me.sidebarLine.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.sidebarLine.LineThickness = 1
        Me.sidebarLine.Location = New System.Drawing.Point(9, 35)
        Me.sidebarLine.Name = "sidebarLine"
        Me.sidebarLine.Size = New System.Drawing.Size(171, 10)
        Me.sidebarLine.TabIndex = 0
        Me.sidebarLine.Transparency = 255
        Me.sidebarLine.Vertical = False
        '
        'wrapper
        '
        Me.wrapper.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.wrapper.Controls.Add(Me.newDataScreen)
        Me.wrapper.Controls.Add(Me.mainScreen)
        Me.wrapper.Controls.Add(Me.changeDataScreen)
        Me.wrapper.Dock = System.Windows.Forms.DockStyle.Fill
        Me.wrapper.Location = New System.Drawing.Point(208, 47)
        Me.wrapper.Name = "wrapper"
        Me.wrapper.Size = New System.Drawing.Size(612, 405)
        Me.wrapper.TabIndex = 2
        '
        'newDataScreen
        '
        Me.newDataScreen.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.newDataScreen.Controls.Add(Me.Label4)
        Me.newDataScreen.Controls.Add(Me.Label3)
        Me.newDataScreen.Controls.Add(Me.txtNota)
        Me.newDataScreen.Controls.Add(Me.btnAgregar)
        Me.newDataScreen.Controls.Add(Me.txtNombre)
        Me.newDataScreen.Location = New System.Drawing.Point(70, 77)
        Me.newDataScreen.Name = "newDataScreen"
        Me.newDataScreen.Size = New System.Drawing.Size(423, 252)
        Me.newDataScreen.TabIndex = 7
        Me.newDataScreen.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(127, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 19)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(131, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 19)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Nota"
        '
        'txtNota
        '
        Me.txtNota.Location = New System.Drawing.Point(135, 121)
        Me.txtNota.Name = "txtNota"
        Me.txtNota.Size = New System.Drawing.Size(145, 20)
        Me.txtNota.TabIndex = 11
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(134, 190)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(149, 23)
        Me.btnAgregar.TabIndex = 10
        Me.btnAgregar.Text = "AGREGAR"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(135, 54)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(145, 20)
        Me.txtNombre.TabIndex = 9
        '
        'mainScreen
        '
        Me.mainScreen.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.mainScreen.Controls.Add(Me.txtTamDeMuestra)
        Me.mainScreen.Controls.Add(Me.btnMedia)
        Me.mainScreen.Controls.Add(Me.Label2)
        Me.mainScreen.Controls.Add(Me.btnMaximo)
        Me.mainScreen.Controls.Add(Me.txtMaximo)
        Me.mainScreen.Controls.Add(Me.txtMedia)
        Me.mainScreen.Location = New System.Drawing.Point(96, 87)
        Me.mainScreen.Name = "mainScreen"
        Me.mainScreen.Size = New System.Drawing.Size(420, 232)
        Me.mainScreen.TabIndex = 6
        '
        'txtTamDeMuestra
        '
        Me.txtTamDeMuestra.Location = New System.Drawing.Point(148, 183)
        Me.txtTamDeMuestra.Name = "txtTamDeMuestra"
        Me.txtTamDeMuestra.Size = New System.Drawing.Size(132, 20)
        Me.txtTamDeMuestra.TabIndex = 0
        '
        'btnMedia
        '
        Me.btnMedia.Location = New System.Drawing.Point(226, 101)
        Me.btnMedia.Name = "btnMedia"
        Me.btnMedia.Size = New System.Drawing.Size(149, 23)
        Me.btnMedia.TabIndex = 5
        Me.btnMedia.Text = "MEDIA"
        Me.btnMedia.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(137, 161)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(153, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Tamaño de la muestra"
        '
        'btnMaximo
        '
        Me.btnMaximo.Location = New System.Drawing.Point(226, 49)
        Me.btnMaximo.Name = "btnMaximo"
        Me.btnMaximo.Size = New System.Drawing.Size(149, 23)
        Me.btnMaximo.TabIndex = 4
        Me.btnMaximo.Text = "MAXIMO"
        Me.btnMaximo.UseVisualStyleBackColor = True
        '
        'txtMaximo
        '
        Me.txtMaximo.Location = New System.Drawing.Point(34, 49)
        Me.txtMaximo.Name = "txtMaximo"
        Me.txtMaximo.Size = New System.Drawing.Size(145, 20)
        Me.txtMaximo.TabIndex = 1
        '
        'txtMedia
        '
        Me.txtMedia.Location = New System.Drawing.Point(34, 101)
        Me.txtMedia.Name = "txtMedia"
        Me.txtMedia.Size = New System.Drawing.Size(145, 20)
        Me.txtMedia.TabIndex = 2
        '
        'changeDataScreen
        '
        Me.changeDataScreen.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.changeDataScreen.Controls.Add(Me.txtNotaChange)
        Me.changeDataScreen.Controls.Add(Me.Label7)
        Me.changeDataScreen.Controls.Add(Me.Label5)
        Me.changeDataScreen.Controls.Add(Me.Label6)
        Me.changeDataScreen.Controls.Add(Me.txtNombreChange)
        Me.changeDataScreen.Controls.Add(Me.btnModificar)
        Me.changeDataScreen.Controls.Add(Me.txtPosicion)
        Me.changeDataScreen.Location = New System.Drawing.Point(81, 59)
        Me.changeDataScreen.Name = "changeDataScreen"
        Me.changeDataScreen.Size = New System.Drawing.Size(371, 312)
        Me.changeDataScreen.TabIndex = 8
        Me.changeDataScreen.Visible = False
        '
        'txtNotaChange
        '
        Me.txtNotaChange.Location = New System.Drawing.Point(142, 178)
        Me.txtNotaChange.Name = "txtNotaChange"
        Me.txtNotaChange.Size = New System.Drawing.Size(145, 20)
        Me.txtNotaChange.TabIndex = 20
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(138, 153)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 19)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Nota"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(134, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 19)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Posicion"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(138, 84)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 19)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Nombre"
        '
        'txtNombreChange
        '
        Me.txtNombreChange.Location = New System.Drawing.Point(142, 110)
        Me.txtNombreChange.Name = "txtNombreChange"
        Me.txtNombreChange.Size = New System.Drawing.Size(145, 20)
        Me.txtNombreChange.TabIndex = 16
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(142, 263)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(149, 23)
        Me.btnModificar.TabIndex = 15
        Me.btnModificar.Text = "MODIFICAR"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'txtPosicion
        '
        Me.txtPosicion.Location = New System.Drawing.Point(142, 43)
        Me.txtPosicion.Name = "txtPosicion"
        Me.txtPosicion.Size = New System.Drawing.Size(145, 20)
        Me.txtPosicion.TabIndex = 14
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 15
        Me.BunifuElipse1.TargetControl = Me.sidebar
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(820, 452)
        Me.Controls.Add(Me.wrapper)
        Me.Controls.Add(Me.sidebarWrapper)
        Me.Controls.Add(Me.topWrapper)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.topWrapper.ResumeLayout(False)
        Me.topWrapper.PerformLayout()
        CType(Me.menuSidebar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.maximize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.minimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.restore, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.close, System.ComponentModel.ISupportInitialize).EndInit()
        Me.sidebarWrapper.ResumeLayout(False)
        Me.sidebar.ResumeLayout(False)
        Me.wrapper.ResumeLayout(False)
        Me.newDataScreen.ResumeLayout(False)
        Me.newDataScreen.PerformLayout()
        Me.mainScreen.ResumeLayout(False)
        Me.mainScreen.PerformLayout()
        Me.changeDataScreen.ResumeLayout(False)
        Me.changeDataScreen.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents topWrapper As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents sidebarWrapper As Panel
    Friend WithEvents wrapper As Panel
    Friend WithEvents maximize As PictureBox
    Friend WithEvents minimize As PictureBox
    Friend WithEvents restore As PictureBox
    Friend WithEvents close As PictureBox
    Friend WithEvents sidebar As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents BunifuFlatButton3 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton2 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton1 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents sidebarLine As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents menuSidebar As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents txtTamDeMuestra As TextBox
    Friend WithEvents btnMedia As Button
    Friend WithEvents btnMaximo As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtMedia As TextBox
    Friend WithEvents txtMaximo As TextBox
    Friend WithEvents newDataScreen As Panel
    Friend WithEvents mainScreen As Panel
    Friend WithEvents changeDataScreen As Panel
    Friend WithEvents txtNota As TextBox
    Friend WithEvents btnAgregar As Button
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNotaChange As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtNombreChange As TextBox
    Friend WithEvents btnModificar As Button
    Friend WithEvents txtPosicion As TextBox
    Friend WithEvents BunifuFlatButton4 As Bunifu.Framework.UI.BunifuFlatButton
End Class
