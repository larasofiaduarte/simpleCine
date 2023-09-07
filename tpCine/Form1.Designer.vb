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
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' txtButacasLibres
        ' 
        txtButacasLibres.Location = New Point(359, 310)
        txtButacasLibres.Name = "txtButacasLibres"
        txtButacasLibres.Size = New Size(121, 27)
        txtButacasLibres.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(85, 313)
        Label1.Name = "Label1"
        Label1.Size = New Size(188, 20)
        Label1.TabIndex = 1
        Label1.Text = "Cantidad de butacas libres:"
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point)
        lblTitle.Location = New Point(223, 67)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(102, 54)
        lblTitle.TabIndex = 2
        lblTitle.Text = "Cine"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(386, 562)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 43)
        Button1.TabIndex = 3
        Button1.Text = "Salir"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' cboButacas
        ' 
        cboButacas.FormattingEnabled = True
        cboButacas.Location = New Point(359, 369)
        cboButacas.Name = "cboButacas"
        cboButacas.Size = New Size(121, 28)
        cboButacas.TabIndex = 4
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(201, 562)
        Button2.Name = "Button2"
        Button2.Size = New Size(170, 43)
        Button2.TabIndex = 5
        Button2.Text = "Buscar Butacas Libres"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' lblButacas
        ' 
        lblButacas.AutoSize = True
        lblButacas.Location = New Point(85, 377)
        lblButacas.Name = "lblButacas"
        lblButacas.Size = New Size(137, 20)
        lblButacas.TabIndex = 6
        lblButacas.Text = "Seleccionar butaca:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(85, 437)
        Label4.Name = "Label4"
        Label4.Size = New Size(106, 20)
        Label4.TabIndex = 7
        Label4.Text = "Estado butaca:"
        ' 
        ' txtEstado
        ' 
        txtEstado.Location = New Point(359, 437)
        txtEstado.Name = "txtEstado"
        txtEstado.Size = New Size(121, 27)
        txtEstado.TabIndex = 8
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(85, 195)
        Label5.Name = "Label5"
        Label5.Size = New Size(170, 20)
        Label5.TabIndex = 10
        Label5.Text = "Seleccionar sala de cine:"
        ' 
        ' cboSalas
        ' 
        cboSalas.FormattingEnabled = True
        cboSalas.Location = New Point(359, 187)
        cboSalas.Name = "cboSalas"
        cboSalas.Size = New Size(121, 28)
        cboSalas.TabIndex = 9
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(85, 255)
        Label7.Name = "Label7"
        Label7.Size = New Size(150, 20)
        Label7.TabIndex = 14
        Label7.Text = "Capacidad de la sala:"
        ' 
        ' txtCapacidad
        ' 
        txtCapacidad.Location = New Point(359, 252)
        txtCapacidad.Name = "txtCapacidad"
        txtCapacidad.Size = New Size(121, 27)
        txtCapacidad.TabIndex = 13
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(236, 121)
        Label2.Name = "Label2"
        Label2.Size = New Size(76, 19)
        Label2.TabIndex = 17
        Label2.Text = "Bienvenido"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(580, 707)
        Controls.Add(Label2)
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
    Friend WithEvents Label2 As Label
End Class
