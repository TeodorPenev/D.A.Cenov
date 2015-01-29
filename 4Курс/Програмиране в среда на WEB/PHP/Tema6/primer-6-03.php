<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">

<head>
<meta content="text/html; charset=utf-8" http-equiv="Content-Type" />
<title>Untitled 1</title>
</head>

<body>

<?php

new_car("Иванов","Рено","Меган"); 

function new_car()
{
    $num_args = func_num_args();
    echo "Брой аргументи: $num_args"."<br>";			//3		
    
    $second_arg = func_get_arg(1);
	echo "Втoрият аргумент е:  $second_arg"."<br>";		// Рено
	
	$arg_list = func_get_args();
    for ($i = 0; $i < $num_args; $i++) {
        echo "Аргумент $i е: " . $arg_list[$i] . "<br />";
    }

}


?>


</body>

</html>
