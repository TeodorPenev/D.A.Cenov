<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">

<head>
<meta content="text/html; charset=utf-8" http-equiv="Content-Type" />
<title>Untitled 1</title>
</head>

<body>

<?php

$order_no = 1001;
$qty = 9;
$price = 20.50;
$amount = $qty * 20.50;
$format = "Поръчка %d: количество - %d, цена - %f, обща сума - %f";
echo sprintf($format, $order_no, $qty, $price, $amount);

?>


</body>

</html>
