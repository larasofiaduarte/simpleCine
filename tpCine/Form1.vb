Imports System.Security.Authentication.ExtendedProtection

Public Class Form1

    'declarar vector de Cine en ambito global

    Dim Cine() As Boolean
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For i As Integer = 0 To 3 Step 1
            cboSalas.Items.Add(i + 1)
        Next


        'estilos
        lblTitle.Font = New Font("Arial", 24, FontStyle.Bold Or FontStyle.Italic)
        lblTitle.ForeColor = Color.Navy

        Dim backColor As Color = Color.FromArgb(192, 192, 255)
        Me.BackColor = backColor




        cboButacas.Enabled = False
        txtCapacidad.Enabled = False
        txtButacasLibres.Enabled = False
        txtEstado.Enabled = False


    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        cboButacas.Enabled = True

        Butacas()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub


    Sub crearCine()
        'definir dimensión del vector según lo seleccionado en ComboBox
        Dim tamaño As Integer
        If cboSalas.SelectedIndex = 0 Then

            tamaño = 30

        ElseIf cboSalas.SelectedIndex = 1 Then

            tamaño = 60

        ElseIf cboSalas.SelectedIndex = 2 Then

            tamaño = 85

        Else

            tamaño = 100

        End If

        ReDim Cine(tamaño - 1)

        cargarArray()

    End Sub

    Sub cargarArray()

        cboButacas.Items.Clear()

        'cargar vector Cine con valores booleanos

        Dim random As New Random()


        For i As Integer = 0 To Cine.Length - 1 Step 1
            Dim randomNumber As Integer = random.Next(2)
            Cine(i) = (randomNumber = 1)
        Next

    End Sub

    Sub cargarButacas()
        'cargar cantidad de butacas a un ComboBox según capacidad
        For i As Integer = 0 To Cine.Length - 1 Step 1
            cboButacas.Items.Add(i + 1)
        Next
    End Sub

    Sub Butacas()
        txtCapacidad.Text = Cine.Length


        'determinar butacas libres

        Dim butacasLibres As Integer = 0

        For i As Integer = 0 To Cine.Length - 1 Step 1
            If Cine(i) = False Then
                butacasLibres += 1
            End If
        Next

        'mostrar cantidad de butacas libres
        txtButacasLibres.Text = butacasLibres



    End Sub

    Private Sub cboSalas_Leave(sender As Object, e As EventArgs) Handles cboSalas.Leave

        crearCine()
        cargarArray()
        cargarButacas()

        txtCapacidad.Enabled = True
        txtButacasLibres.Enabled = True
        txtEstado.Enabled = True

    End Sub

    Private Sub cboButacas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboButacas.SelectedIndexChanged

        'Mostrar si la butaca está disponible

        If cboButacas.SelectedIndex = -1 Then
            txtEstado.Text = " "
        ElseIf Cine(cboButacas.SelectedIndex + 1) = False Then
            txtEstado.Text = "Disponible"
        Else
            txtEstado.Text = "Ocupado"
        End If
    End Sub

    Private Sub lblTitle_Click(sender As Object, e As EventArgs) Handles lblTitle.Click

    End Sub
End Class



