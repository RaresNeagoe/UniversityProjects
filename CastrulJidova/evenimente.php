<!doctype html>

<html>

<head>
	<meta charset="UTF-8">
	<meta name="viewport" content="width=device-width, initial-scale=1.0">
	<title>Evenimente</title>
	<link rel="stylesheet" href="css/style.css" type="text/css">
	<link rel="stylesheet" type="text/css" href="css/mobile.css">
	<script src="js/mobile.js" type="text/javascript"></script>
</head>

<body>

<?php
$emailErr = $passwordErr = "";
$email = $password = "";

if ($_SERVER["REQUEST_METHOD"] == "POST") 
{
	$user=$_POST['email'];
	$pass=$_POST['password'];
	$data = $_POST['data'];
	$ok_user=0;
	$ok_pass=0;
	$ok=0;
	$conectare = mysql_connect("localhost", "root", "");
	if(!$conectare){
        echo "<script type='text/javascript'>alert('Eroare de conexiune la server MySql');</script>";
   	 exit;
	}
	$db = mysql_select_db("userDB");


  	if (empty($_POST["email"])) 
	{
   		$emailErr = "Introduceti email";
  	} 
	else 
	{
    	$email = test_input($_POST["email"]);
    	if (!filter_var($email, FILTER_VALIDATE_EMAIL)) 
		{
      		$emailErr = "Format email invalid";
    	}
		else
		{
			$afis = "SELECT * FROM users";
			$rez = mysql_query($afis);
			while($x = mysql_fetch_array($rez))
			{
    			if($x['user']==$user)
					$ok_user=1;
    			if($x['pass']==$pass)
					$ok_pass=1;
    			if($ok_user==1 && $ok_pass==1)
    			{
      			    $ok=1;
         			break;
    			}
			}  
			if($ok_user==0)
            	echo "<script type='text/javascript'>alert('Utilizatorul nu exista');</script>";
			else
   				if($ok_user==1 && $ok_pass==0)
				   echo "<script type='text/javascript'>alert('Parola nu este corecta');</script>";
			
			$creare_tabel = "CREATE TABLE IF NOT EXISTS date_rezervari (data date primary key)";
			$rez = mysql_query($creare_tabel);
			if(!$rez)
				echo "<script type='text/javascript'>alert('Comanda de creare tabel gresita!');</script>";
			$data = $_POST['data'];
			$introducere = "INSERT INTO date_rezervari VALUES('$data')";
			$rez = mysql_query($introducere);
			if(!$rez)
                echo "<script type='text/javascript'>alert('Data selectata nu este disponibila');</script>";
			else
				echo "<script type='text/javascript'>alert('Data a fost rezervata cu succes');</script>";
		}
    }
}

function test_input($data) {
  $data = trim($data);
  $data = stripslashes($data);
  $data = htmlspecialchars($data);
  return $data;
}
?>


	<div id="page">
		<div id="header">
			<div>
				<a href="index.html" class="logo"><img src="images/logoJidava.jpg" width="200" height="133" alt=""></a>
				<ul id="navigation">
					<li>
						<a href="index.html">Acasă</a>
					</li>
					<li class="menu">
						<a href="istorie.html">Istorie</a>
					</li>
					<li class="menu">
						<a href="locatie.html">Locație</a>
					</li>
					<li class="menu selected">
						<a href="evenimente.php">Evenimente</a>
					</li>
				</ul>
			</div>
		</div>
		<div id="body" class="contact">
			<div class="header">
				<div>
					<h1>Rezervare dată pentru un eveniment</h1>
				</div>
			</div>
			<div class="footer">
				<div class="contact">
					<form method="post" action="<?php echo htmlspecialchars($_SERVER["PHP_SELF"]);?>">
						Email: <input type="text" name="email" value="<?php echo $email;?>" required onblur="this.value=!this.value?'Email':this.value;" onfocus="this.select()" onclick="this.value='';">
						<span class="error"><?php echo $emailErr;?></span>
						Parola: <input type="password" id="password" name="password" required onblur="this.value=!this.value?'Parola':this.value;" onfocus="this.select()" onclick="this.value='';">	
						<label for="start">Data:</label>
						<input type="date" id="data" name="data" value="2024-05-27" min="2024-05-27" max="2025-05-22" />					
						<input type="submit" value="Rezervare" id="submit">
					</form>
					<br>
					<p> Nu ai cont? <a href="creare_cont.php">Creaza-ti unul!</a> </p>
				</div>
			</div>
		</div>
		<div id="footer">
			<div>
				<div class="connect">
					<a href="http://freewebsitetemplates.com/go/facebook/" class="facebook">facebook</a>
					<a href="http://freewebsitetemplates.com/go/twitter/" class="twitter">twitter</a>
					<a href="http://freewebsitetemplates.com/go/googleplus/" class="googleplus">googleplus</a>
					<a href="http://pinterest.com/fwtemplates/" class="pinterest">pinterest</a>
				</div>
				<p>&copy; Copyright 2024 ©Muzeul Județean Argeș All rights reserved</p>
			</div>
		</div>
	</div>
</body>

</html>
