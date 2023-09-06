Imports System.Security.Authentication.ExtendedProtection

Public Class Form1

    'declarar vector de Cine en ambito global

    Dim Cine() As Boolean
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        For i As Integer = 0 To 3 Step 1
            cboSalas.Items.Add(i + 1)
        Next


        'estilos
        lblTitle.Font = New Font("Arial", 16, FontStyle.Bold Or FontStyle.Italic)
        lblTitle.ForeColor = Color.Navy

        cboButacas.Enabled = False

    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        cboButacas.Enabled = True

        crearCine()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub


    Sub crearCine()
        'definir dimensión del vector según lo seleccionado en ComboBox
        If cboSalas.SelectedIndex = 0 Then

            ReDim Cine(29)
            Butacas()

        ElseIf cboSalas.SelectedIndex = 1 Then

            ReDim Cine(59)
            Butacas()

        ElseIf cboSalas.SelectedIndex = 2 Then

            ReDim Cine(84)
            Butacas()

        Else

            ReDim Cine(99)
            Butacas()

        End If
    End Sub

    Sub Butacas()
        txtCapacidad.Text = Cine.Length

        'cargar cantidad de butacas a un ComboBox según capacidad
        For i As Integer = 0 To Cine.Length - 1 Step 1
            cboButacas.Items.Add(i + 1)
        Next


        'cargar vector Cine con valores booleanos

        For i As Integer = 0 To Cine.Length - 1 Step 1
            If i Mod 2 = 0 Then
                Cine(i) = False
            Else
                Cine(i) = True
            End If
        Next


        'determinar butacas libres

        Dim butacasLibres As Integer = 0

        For i As Integer = 0 To Cine.Length - 1 Step 1
            If Cine(i) = False Then
                butacasLibres += 1
            End If
        Next

        'mostrar cantidad de butacas libres
        txtButacasLibres.Text = butacasLibres


        'Mostrar si la butaca está disponible

        If cboButacas.SelectedIndex = -1 Then
            txtEstado.Text = " "
            txtSeleccionada.Text = "No Seleccionado"
        ElseIf Cine(cboButacas.SelectedIndex + 1) = False Then
            txtEstado.Text = "Disponible"
            txtSeleccionada.Text = cboButacas.SelectedIndex + 1
        Else
            txtEstado.Text = "Ocupado"
            txtSeleccionada.Text = cboButacas.SelectedIndex + 1
        End If
    End Sub
End Class



