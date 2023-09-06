<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        txtButacasLibres = New TextBox()
        Label1 = New Label()
        lblTitle = New Label()
        Button1 = New Button()
        cboButacas = New ComboBox()
        Button2 = New Button()
        lblButacas = New Label()
        Label4 = New Label()
        txtEstado = New TextBox()
        Label5 = New Label()
        cboSalas = New ComboBox()
        Label7 = New Label()
        txtCapacidad = New TextBox()
        txtSeleccionada = New TextBox()
        Label8 = New Label()
        SuspendLayout()
        ' 
        ' txtButacasLibres
        ' 
        txtButacasLibres.Location = New Point(359, 297)
        txtButacasLibres.Name = "txtButacasLibres"
        txtButacasLibres.Size = New Size(121, 27)
        txtButacasLibres.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(85, 300)
        Label1.Name = "Label1"
        Label1.Size = New Size(188, 20)
        Label1.TabIndex = 1
        Label1.Text = "Cantidad de butacas libres:"
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        lblTitle.Location = New Point(155, 58)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(237, 37)
        lblTitle.TabIndex = 2
        lblTitle.Text = "Bienvenido al Cine"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(386, 601)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 3
        Button1.Text = "Salir"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' cboButacas
        ' 
        cboButacas.FormattingEnabled = True
        cboButacas.Location = New Point(359, 356)
        cboButacas.Name = "cboButacas"
        cboButacas.Size = New Size(121, 28)
        cboButacas.TabIndex = 4
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(201, 601)
        Button2.Name = "Button2"
        Button2.Size = New Size(170, 29)
        Button2.TabIndex = 5
        Button2.Text = "Buscar Butacas Libres"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' lblButacas
        ' 
        lblButacas.AutoSize = True
        lblButacas.Location = New Point(85, 364)
        lblButacas.Name = "lblButacas"
        lblButacas.Size = New Size(137, 20)
        lblButacas.TabIndex = 6
        lblButacas.Text = "Seleccionar butaca:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(85, 484)
        Label4.Name = "Label4"
        Label4.Size = New Size(106, 20)
        Label4.TabIndex = 7
        Label4.Text = "Estado butaca:"
        ' 
        ' txtEstado
        ' 
        txtEstado.Location = New Point(359, 484)
        txtEstado.Name = "txtEstado"
        txtEstado.Size = New Size(121, 27)
        txtEstado.TabIndex = 8
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(85, 182)
        Label5.Name = "Label5"
        Label5.Size = New Size(170, 20)
        Label5.TabIndex = 10
        Label5.Text = "Seleccionar sala de cine:"
        ' 
        ' cboSalas
        ' 
        cboSalas.FormattingEnabled = True
        cboSalas.Location = New Point(359, 174)
        cboSalas.Name = "cboSalas"
        cboSalas.Size = New Size(121, 28)
        cboSalas.TabIndex = 9
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(85, 242)
        Label7.Name = "Label7"
        Label7.Size = New Size(150, 20)
        Label7.TabIndex = 14
        Label7.Text = "Capacidad de la sala:"
        ' 
        ' txtCapacidad
        ' 
        txtCapacidad.Location = New Point(359, 239)
        txtCapacidad.Name = "txtCapacidad"
        txtCapacidad.Size = New Size(121, 27)
        txtCapacidad.TabIndex = 13
        ' 
        ' txtSeleccionada
        ' 
        txtSeleccionada.Location = New Point(359, 425)
        txtSeleccionada.Name = "txtSeleccionada"
        txtSeleccionada.Size = New Size(121, 27)
        txtSeleccionada.TabIndex = 16
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(85, 425)
        Label8.Name = "Label8"
        Label8.Size = New Size(147, 20)
        Label8.TabIndex = 15
        Label8.Text = "Butaca seleccionada:"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(580, 720)
        Controls.Add(txtSeleccionada)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(txtCapacidad)
        Controls.Add(Label5)
        Controls.Add(cboSalas)
        Controls.Add(txtEstado)
        Controls.Add(Label4)
        Controls.Add(lblButacas)
        Controls.Add(Button2)
        Controls.Add(cboButacas)
        Controls.Add(Button1)
        Controls.Add(lblTitle)
        Controls.Add(Label1)
        Controls.Add(txtButacasLibres)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtButacasLibres As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents cboButacas As ComboBox
    Friend WithEvents Button2 As Button
    Friend WithEvents lblButacas As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtEstado As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cboSalas As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCapacidad As TextBox
    Friend WithEvents txtSeleccionada As TextBox
    Friend WithEvents Label8 As Label
End Class
