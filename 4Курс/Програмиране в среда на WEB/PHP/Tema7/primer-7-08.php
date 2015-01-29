<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">

<head>
<meta content="text/html; charset=utf-8" http-equiv="Content-Type" />
<title>Untitled 1</title>
</head>

<body>

<?php

echo "Проверка на аргументитте за дата: 12, 31, 2014";
if (checkdate(12, 31, 2014))
	echo " - ВЕРНИ!";
else
	echo " - ГРЕШНИ!";
echo "<br>";
echo "Проверка на аргументитте за дата: 13, 31, 2014";
if (checkdate(13, 31, 2014))
	echo " - ВЕРНИ!";
else
	echo " - ГРЕШНИ!";

?>


</body>

</html>
