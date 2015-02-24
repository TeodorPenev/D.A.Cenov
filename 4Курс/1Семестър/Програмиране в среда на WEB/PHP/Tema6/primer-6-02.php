<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">

<head>
<meta content="text/html; charset=utf-8" http-equiv="Content-Type" />
<title>Untitled 1</title>
</head>

<body>

<?php

$new_price = 10.20;

function calc_new_price(&$new_price)
{
	$new_price = $new_price + 1;
	echo 'Новата цена е '.$new_price."<br>";
}

calc_new_price($new_price);

echo 'Стойността на $new_price e '."$new_price";

?>


</body>

</html>
