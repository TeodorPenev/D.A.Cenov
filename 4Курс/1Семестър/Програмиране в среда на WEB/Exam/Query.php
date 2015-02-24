<?php 
// usera i pass na samiq izpit shte sa kakto sledva: user: student, pass: test
$local = "localhost";// ime na syrvyra
$user = "root";// potrebitel
$pass = ""; //parola

mysql_connect($local, $user, $pass) or die(mysql_error());// funkciqta chrez koqto se svyrzvame s bazata danni . Tq priema trite parametyra napisani po gore.
mysql_select_db('test') or die(mysql_error());// izbirame si bazata ot danni pri men e test a na izpita shte q vidite ot lischeto
mysql_query("SET NAMES UTF8");// chrez tazi funkciq kazvam che iskam vsichki rezultati polucheni ot tyrseneto da mi izlqat s utf 8 encoding

?>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
	<title>test</title>
	<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
</head>

<body>
	<!-- syzdavam si formata ot koqto shte izprashtam zaqvka kym bazata danni -->
	<form method="post" action="">
		<input type="text" name="search" />
		<input type="submit" name="submit" value="Tyrsi" />	
	</form>
	<table>
	<?php 
	//pyrvo proverqvam dali butona tyrsi e cyknat chrez funkciqta isset, kato tq priema parametyr ot post submit t.e post submit e imeto na butona tyrsi(name="submit")

		if(isset($_POST["submit"])){
			//sled akto sym napravil proverkata vsichki rezultati shte mi izlqzat samo ako butona e natisnat
			//sled tova prisyedinqvam kym promenliva stoinosto ot input poleto t.e poleto se kazva search i vzemam infoto ot nego chrez $_POST['search']
			//dannite se predavat po dva nachina po post i get v nashiq sluchai metoda na formata e post (method="post")
			//zaradi tova informaciqta ot poleto search se dostiga chrez globalnata promenliva $_POST
			$search = $_POST['search'];
			// sled kato veche imam stoinostta ot poleto search e vreme da si napravq zaqvkata
			// tuk edinstvenoto neshto koeto trqbva da promenite na izpita e menu, Name i ako vashtata promenliva e druga ot $serach da q slojite na mqstoto na $search
			// menu -> otgovarq na imeto na tablicata vytre v bazata danni 
			// Name -> otgovarq na poleto ot tablicata po koeto trqbva da tyrsite
			// %% -> tezi procenti pred i zad promenlivata kazva che vie iskate da tyrsite syvpadenie ne samo ot nachaloto i ot kraq na dumata a i ot sredata na dumata
			// t.e ako podadete 'og' a dumata v bazata danni e 'moga' zaqvkata shte vi vyrne moga   
			$query = mysql_query("SELECT * FROM menu WHERE Name LIKE '%$search%' ORDER BY Name DESC") or die(mysql_error());
			//za da vizualizirame informaciqta koqto veche sme namerili ot zaqvkata na gorniq red trqbva da trqbva da q obhodim s cikyl
			// while -> dokato $row e ravno na (mysql_fetch_Array e funkciq koqto okazva na zaqvkata che polucheniqt rezultata iskame da go slojim v masiv) array ot $query
			// ili kazano po drug nachin dokato imame syvpadenie v bazata sloji vsichko v masiv i go prisyedini kym promenlivata $row
			while($row = mysql_fetch_array($query)){
	?>
	<!-- sled kato sme napravili slojnoto e vreme da si izkarame informaciqta -->
		<tr>
			<td><?php echo $row['Name'];// Name otgovarq na poletato vytre v bazata danni pri men e Name pri vas na izpita shte e drugo taka che gledaite kakvo tochno trqbva da izkarate i go izkaraite ?></td>
			<td><?php echo $row['Price'];// t.e sled $row slagate tova ->[''] i pomejdu dvete edinichni kavichki slagate imeto na poleto ot bazata :) ?></td>
		</tr>
	<?php 
			}	
		}
	?>
	</table>

	<!-- nadqvam se da sym go obqsnil dobre :) uspeh na vsichki -->
</body>
</html>