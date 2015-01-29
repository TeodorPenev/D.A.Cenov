<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">

<head>
<meta content="text/html; charset=utf-8" http-equiv="Content-Type" />
<title>Конкатенация на низове. Обръщение към символи от низа.</title>
</head>

<body>

<?php

$user_first_name = "John";
$user_last_name = "Smith";

echo "Hello ".$user_first_name." ".$user_last_name;
echo "<br>";
 echo "Your initials are: ".$user_first_name[0].$user_last_name[0];


?>

</body>

</html>
