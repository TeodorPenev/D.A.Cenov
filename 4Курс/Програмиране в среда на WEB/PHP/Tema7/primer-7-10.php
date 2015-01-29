<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">

<head>
<meta content="text/html; charset=utf-8" http-equiv="Content-Type" />
<title>Хеширане на парола</title>
</head>

<?php
$password_text = "parola123!";

$result_hash_default = password_hash($password_text, PASSWORD_DEFAULT);
$result_hash_BCRYPT = password_hash($password_text, PASSWORD_BCRYPT);

echo "Хеширане на $password_text, с DEAFAULT и BCRYPT:"."<p>";
echo $result_hash_default;
echo "<br>";
echo $result_hash_BCRYPT;

?>

<body>

</body>

</html>
