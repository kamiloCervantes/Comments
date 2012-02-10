<%@ Page Language="C#" Inherits="Comments.Default" %>
<!DOCTYPE html>
<html>
<head runat="server">
	<title>Agregar Mensaje</title>
	<style>
		body{
			background: url('images/air.jpg');
			}	
			
		ul {
			list-style: none;
			margin: 0;
			padding: 0;
			}	
			
		#commentform{
			width: 400px;
			height: auto;
			padding: 20px;
			color: #fff;
			background: -moz-linear-gradient(top, rgba(0,0,0,0.65) 0%, rgba(0,0,0,0) 100%); /* FF3.6+ */
			background: -webkit-gradient(linear, left top, left bottom, color-stop(0%,rgba(0,0,0,0.65)), color-stop(100%,rgba(0,0,0,0))); /* Chrome,Safari4+ */
			background: -webkit-linear-gradient(top, rgba(0,0,0,0.65) 0%,rgba(0,0,0,0) 100%); /* Chrome10+,Safari5.1+ */
			background: -o-linear-gradient(top, rgba(0,0,0,0.65) 0%,rgba(0,0,0,0) 100%); /* Opera 11.10+ */
			background: -ms-linear-gradient(top, rgba(0,0,0,0.65) 0%,rgba(0,0,0,0) 100%); /* IE10+ */
			background: linear-gradient(top, rgba(0,0,0,0.65) 0%,rgba(0,0,0,0) 100%); /* W3C */
			filter: progid:DXImageTransform.Microsoft.gradient( startColorstr='#a6000000', endColorstr='#00000000',GradientType=0 ); /* IE6-9 */
			margin: 0;
			}
		
		#commentform input[type="text"]{
			width: 100%;
			}
			
		
		#commentform textarea{
			width: 100%;
			height: 300px;
			}
	</style>
</head>
<body onload="Mensaje()">
	
	<div id="commentform">		
		<h2>Enviar comentarios</h2>	
	<form id="form1" runat="server">
		<ul>
			<li>
				<label for="mailto">Tu nombre:</label>	
				<input id="nombre" runat="server"/>
			</li>
			<li>
				<label for="email">Tu email:</label>	
				<input id="email" runat="server"/>
			</li>
			<li>
				<label for="mensaje">Mensaje:</label>
				<textarea rows="2" cols="20" id="mensaje" runat="server"/>
			</li>
			<li><input type="submit" value="Submit" id="EnviarComment" onserverclick="guardarComment" runat="server"/></li>
		</ul>
	</form>
	</div>
</body>
</html>
