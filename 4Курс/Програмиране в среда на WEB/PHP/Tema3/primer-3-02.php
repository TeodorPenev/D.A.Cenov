<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">

<head>
<meta content="text/html; charset=utf-8" http-equiv="Content-Type" />
<title>Избиране на БД от установена връзка</title>
</head>

<body>


<?php
$host_name = "localhost";
$user_name="student";
$user_password="test";

@$link1=mysql_connect($host_name,$user_name,$user_password);
if (!$link1) {
    die('Връзката не може да бъде установена: ' . mysql_error());
}
else
{
$db_name="adventureworks";
$db_selected = mysql_select_db($db_name, $link1);
if (!$db_selected) {
    die ('Не може да се свърже към БД : ' . mysql_error());
}

}
?> 

</body>

</html>
