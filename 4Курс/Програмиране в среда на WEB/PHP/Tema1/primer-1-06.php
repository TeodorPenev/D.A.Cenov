<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">

<head>
<meta content="text/html; charset=utf-8" http-equiv="Content-Type" />
<title>Инициализиране и проверка на типа данни на променливи</title>
</head>

<body>

<?php

$quantity = 0;
$price = 0.00;
$price2 = 0;
settype($price2, "double");


echo "Типът данни на \$quantity е: ";
echo gettype($quantity);
echo "<br>";
echo "Типът данни на \$price е: ";
echo gettype($price);
echo "<br>";
echo "Типът данни на \$price2 е: ";
echo gettype($price2);

 
?>



</body>

</html>
