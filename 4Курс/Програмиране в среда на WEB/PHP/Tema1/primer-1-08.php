<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">

<head>
<meta content="text/html; charset=utf-8" http-equiv="Content-Type" />
<title>Работа с твърди връзки</title>
</head>

<body>

<?php

$var1 = 10;
$link_to_var1 = &$var1;

$link_to_var1 = 20;
echo $var1;		

unset ($link_to_var1);
	

?>

</body>

</html>
