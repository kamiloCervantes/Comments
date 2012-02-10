using System;
using System.Web;
using System.Web.UI;
using System.Data;
using Npgsql;


namespace Comments
{
	public partial class Default : System.Web.UI.Page
	{
		private TConexion conn;
		
		public Default() : base(){
			conn = new TConexion();
		}
		
		
		public void guardarComment (object sender, EventArgs args)
		{
			NpgsqlCommand query;
			conn.Conectar();
			query = conn.Conector.CreateCommand();
			query.CommandText = string.Format("INSERT INTO comments(nombre, email, mensaje)  VALUES ('{0}','{1}','{2}')",nombre.Value,email.Value,mensaje.Value);
			query.ExecuteNonQuery();
			query.Dispose();
			conn.Cerrar();
			VerMensaje("Su comentario ha sido guardado.");	
			LimpiarForm();
		}
		
		public void WriteLine(string Line){
   			Response.Write(Line + "\n");						
  		}		
		
 		public void VerMensaje(string Msg){
   			WriteLine("<script type=\"text/javascript\">");			
   			WriteLine(" function Mensaje(){");
   			if(Request.Form.Count>0)			
    		WriteLine("  alert(\"" + Msg + "\");");
   			WriteLine(" }\n");			
   			WriteLine("</script>");						
  		}
		
		private void LimpiarForm(){
			nombre.Value = "";
			email.Value = "";
			mensaje.Value = "";
			nombre.Focus();
		}
		
		/*
		public DataSet leerComments(){
			DataSet data = new DataSet();
			TConexion conn = new TConexion();
			conn.Conectar();
			NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("SELECT * FROM comments",conn.Conector);
			dataAdapter.Fill(data);
			conn.Cerrar();
			return data;
		}	
		*/

	}
}