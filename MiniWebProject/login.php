<?php
$user=$_POST['user'];
$pass=$_POST['password'];
$ok_user=0;
$ok_pass=0;
$ok=0;
$conectare = mysql_connect("localhost", "root", "");
if(!$conectare){
    echo "Eroare de conexiune la server MySql";
    exit;
}
$db = mysql_select_db("DBusers");
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
   echo "Utilizatorul nu exista";
else
   if($ok_user==1 && $ok_pass==0)
      echo "Parola nu este corecta";
   else
      if($ok==1)
      {
         echo "Expanding its EV offerings, Volvo is launching the small EX30 SUV with chic styling to go along with its expected high-tech platform. Single- and Dual-Motor versions are available, the former with a 268-hp rear-wheel-drive setup and the latter with a 422-hp all-wheel-drive arrangement that Volvo says makes the EX30 its quickest-accelerating vehicle to date. No matter which powertrain you choose, you'll get the same 64.0-kWh battery pack that is said to offer up to 275 miles of driving per charge. The EX30 sports cool LED lighting elements and Volvo's justly lauded comfy bucket seats, but its cabin makes sustainability a side dish to its style. Volvo has chosen recycled materials for the SUV's upholstery and partnered with carbon-neutral suppliers to give the EX30 an edge in environmental friendliness. The EX30 fits into the Volvo lineup below the C40 Recharge and XC40 Recharge duo and creates a new entry-level place in the brand's hierarchy.<br> ";
         echo '<img src="/2024.04.09/ex30.jpg" width="400" height="250"/>';
      }
?>