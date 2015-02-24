<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">

<head>
<meta content="text/html; charset=utf-8" http-equiv="Content-Type" />
<title>Работа с твърди връзки</title>
</head>

<body>

<?php

$username = "Иван Петров";
$link_to_username = "username";

echo $link_to_username;		
echo $$link_to_username;

$$link_to_username = "Петър Иванов";
echo $username;		

?>

</body>

</html>
