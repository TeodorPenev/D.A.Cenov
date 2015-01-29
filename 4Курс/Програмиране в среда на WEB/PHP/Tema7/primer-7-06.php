<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">

<head>
<meta content="text/html; charset=utf-8" http-equiv="Content-Type" />
<title>Untitled 1</title>
</head>

<body>

<?php


$str2010 = "Word 2010, Excel 2010, PowerPoint 2010, OneNote 2010";

// замяна на всички срещания на 2010 с 2013
$str2013 = str_replace('2010','2013', $str2010);
echo $str2013;

$str2013_2010 = str_replace('2010','2013', $str2010,2);
echo $str2013_2010;

 
?>


</body>

</html>
