﻿Public Class CourseView
    Public Sub New()
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Dim Modelo As New CourseViewModel()
        Me.DataContext = Modelo
    End Sub
End Class
