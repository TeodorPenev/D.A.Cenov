<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">

<head>
<meta content="text/html; charset=utf-8" http-equiv="Content-Type" />
<title>Проверка на парола</title>
</head>

<?php

$fruits = array (
    "fruits"  => array("a" => "orange", "b" => "banana", "c" => "apple"));

echo "Масивът преди сериализацията"."<br>";
print_r($fruits);
echo "<p>";
	
$fruits_str_serialize = serialize($fruits);
echo "Стрингът след сериализацията"."<br>";
echo $fruits_str_serialize;
echo "<p>";

$fruits_normal =  unserialize($fruits_str_serialize);	
echo "Масивът след десериализацията"."<br>";	
print_r($fruits_normal);	




?>

<body>

</body>

</html>
