using System;
using Npgsql;

public class TConexion 	{
	
 private int FPuerto;
 private string FClave;
 private string FUsuario;	
 private string FServidor;	
 private string FBaseDatos;		
 private NpgsqlConnection FConector;	
	
 public TConexion(){
  FPuerto = 5432;	
  FServidor = "127.0.0.1";		
  FBaseDatos = "comments_bd";			
  FUsuario = "postgres";
  FClave = "danger8931";
  FConector = null;		
 }
	
 public int Puerto{
  set{
   FPuerto = value;			
  }
  get{
   return FPuerto;			
  }		
 }
	
 public string Usuario{
  set{
   FUsuario = value;			
  }
  get{
   return FUsuario;			
  }		
 }
	
 public string Clave{
  set{
   FClave = value;			
  }
  get{
   return FClave;			
  }		
 }
	
 public string BaseDatos{
  set{
   FBaseDatos = value;			
  }
  get{
   return FBaseDatos;			
  }		
 }	
	
 public string Servidor{
  set{
   FServidor = value;			
  }
  get{
   return FServidor;			
  }		
 }	
	
 public NpgsqlConnection Conector{
  get{
   return FConector;			
  }		
 }	
	
 public void Conectar(){
  FConector = new NpgsqlConnection();		
  string Con = "database=" + FBaseDatos + ";host=" + FServidor;
  Con+= ";user=" + FUsuario + ";password=" + Clave;
  if(FPuerto>0)
   Con+=";port=" + FPuerto;			   
  FConector.ConnectionString=Con;		
  FConector.Open();		 
 }
	
 public void Cerrar(){
  FConector.ClearPool();
  FConector.Close();
  FConector.Dispose();		
  FConector = null;		
 }	
 	
}
