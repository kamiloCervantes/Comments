<%@ WebService Language="C#" Class="Comments.readcomments" %>
<%@ Assembly name="Npgsql" %>

using System;
using System.Web.Services;
using System.Data;
using Npgsql;


namespace Comments
{
	
	[WebService(Namespace="Comments", Description="Leer comentarios")]
	internal class readcomments
	{
		[WebMethod(Description="Devuelve la cadena Hola")]
		public string Saludar(){
			return "Hola";
		}
		
		[WebMethod(Description="Devuelve los comments")]
		public DataSet leerComments(){
			DataSet data = new DataSet();
			TConexion conn = new TConexion();
			conn.Conectar();
			NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("SELECT * FROM comments",conn.Conector);
			dataAdapter.Fill(data);
			conn.Cerrar();
			return data;
		}			
	}
}



