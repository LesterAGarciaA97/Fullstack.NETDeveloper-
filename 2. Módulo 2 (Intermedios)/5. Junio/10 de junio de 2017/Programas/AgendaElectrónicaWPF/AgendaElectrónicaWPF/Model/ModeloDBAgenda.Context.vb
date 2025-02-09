﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Este código se generó a partir de una plantilla.
'
'     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
'     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Data.Entity
Imports System.Data.Entity.Infrastructure
Imports System.Data.Entity.Core.Objects
Imports System.Linq

Partial Public Class Agenda2017I013HEntities
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=Agenda2017I013HEntities")
    End Sub

    Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
        Throw New UnintentionalCodeFirstException()
    End Sub

    Public Overridable Property Contacto_Direcciones() As DbSet(Of Contacto_Direcciones)
    Public Overridable Property Contacto_Email() As DbSet(Of Contacto_Email)
    Public Overridable Property Contacto_Telefonos() As DbSet(Of Contacto_Telefonos)
    Public Overridable Property Contactos() As DbSet(Of Contactos)
    Public Overridable Property Roles() As DbSet(Of Roles)
    Public Overridable Property Usuarios() As DbSet(Of Usuarios)

    Public Overridable Function sp_AgregarContacto(nombres As String, apellidos As String, codigoUsuario As Nullable(Of Integer)) As Integer
        Dim nombresParameter As ObjectParameter = If(nombres IsNot Nothing, New ObjectParameter("Nombres", nombres), New ObjectParameter("Nombres", GetType(String)))

        Dim apellidosParameter As ObjectParameter = If(apellidos IsNot Nothing, New ObjectParameter("Apellidos", apellidos), New ObjectParameter("Apellidos", GetType(String)))

        Dim codigoUsuarioParameter As ObjectParameter = If(codigoUsuario.HasValue, New ObjectParameter("CodigoUsuario", codigoUsuario), New ObjectParameter("CodigoUsuario", GetType(Integer)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction("sp_AgregarContacto", nombresParameter, apellidosParameter, codigoUsuarioParameter)
    End Function

    Public Overridable Function sp_AgregarUsuario(nombre As String, login As String, password As String, email As String, codigoRol As Nullable(Of Integer)) As Integer
        Dim nombreParameter As ObjectParameter = If(nombre IsNot Nothing, New ObjectParameter("nombre", nombre), New ObjectParameter("nombre", GetType(String)))

        Dim loginParameter As ObjectParameter = If(login IsNot Nothing, New ObjectParameter("login", login), New ObjectParameter("login", GetType(String)))

        Dim passwordParameter As ObjectParameter = If(password IsNot Nothing, New ObjectParameter("password", password), New ObjectParameter("password", GetType(String)))

        Dim emailParameter As ObjectParameter = If(email IsNot Nothing, New ObjectParameter("email", email), New ObjectParameter("email", GetType(String)))

        Dim codigoRolParameter As ObjectParameter = If(codigoRol.HasValue, New ObjectParameter("codigoRol", codigoRol), New ObjectParameter("codigoRol", GetType(Integer)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction("sp_AgregarUsuario", nombreParameter, loginParameter, passwordParameter, emailParameter, codigoRolParameter)
    End Function

    Public Overridable Function sp_ConsultarContactosPorUsuario(codigoUsuario As Nullable(Of Integer)) As ObjectResult(Of sp_ConsultarContactosPorUsuario_Result)
        Dim codigoUsuarioParameter As ObjectParameter = If(codigoUsuario.HasValue, New ObjectParameter("CodigoUsuario", codigoUsuario), New ObjectParameter("CodigoUsuario", GetType(Integer)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of sp_ConsultarContactosPorUsuario_Result)("sp_ConsultarContactosPorUsuario", codigoUsuarioParameter)
    End Function

    Public Overridable Function sp_ConsultarUsuarios() As ObjectResult(Of sp_ConsultarUsuarios_Result)
        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of sp_ConsultarUsuarios_Result)("sp_ConsultarUsuarios")
    End Function

    Public Overridable Function sp_EliminarContacto(codigoContacto As Nullable(Of Integer)) As Integer
        Dim codigoContactoParameter As ObjectParameter = If(codigoContacto.HasValue, New ObjectParameter("CodigoContacto", codigoContacto), New ObjectParameter("CodigoContacto", GetType(Integer)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction("sp_EliminarContacto", codigoContactoParameter)
    End Function

    Public Overridable Function sp_EliminarUsuario(codigoUsuario As Nullable(Of Integer)) As Integer
        Dim codigoUsuarioParameter As ObjectParameter = If(codigoUsuario.HasValue, New ObjectParameter("CodigoUsuario", codigoUsuario), New ObjectParameter("CodigoUsuario", GetType(Integer)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction("sp_EliminarUsuario", codigoUsuarioParameter)
    End Function

    Public Overridable Function sp_ModificarUsuario(codigoUsuario As Nullable(Of Integer), nombre As String, login As String, password As String, email As String, rol As Nullable(Of Integer)) As Integer
        Dim codigoUsuarioParameter As ObjectParameter = If(codigoUsuario.HasValue, New ObjectParameter("CodigoUsuario", codigoUsuario), New ObjectParameter("CodigoUsuario", GetType(Integer)))

        Dim nombreParameter As ObjectParameter = If(nombre IsNot Nothing, New ObjectParameter("nombre", nombre), New ObjectParameter("nombre", GetType(String)))

        Dim loginParameter As ObjectParameter = If(login IsNot Nothing, New ObjectParameter("login", login), New ObjectParameter("login", GetType(String)))

        Dim passwordParameter As ObjectParameter = If(password IsNot Nothing, New ObjectParameter("password", password), New ObjectParameter("password", GetType(String)))

        Dim emailParameter As ObjectParameter = If(email IsNot Nothing, New ObjectParameter("email", email), New ObjectParameter("email", GetType(String)))

        Dim rolParameter As ObjectParameter = If(rol.HasValue, New ObjectParameter("rol", rol), New ObjectParameter("rol", GetType(Integer)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction("sp_ModificarUsuario", codigoUsuarioParameter, nombreParameter, loginParameter, passwordParameter, emailParameter, rolParameter)
    End Function

End Class
