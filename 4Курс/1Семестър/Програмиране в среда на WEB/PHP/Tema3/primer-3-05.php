<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">

<head>
<meta content="text/html; charset=utf-8" http-equiv="Content-Type" />
<title>Обработка на резултата с mysql_fetch_array() с MYSQL_ASSOC</title>
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

// Стойностите могат да се въведат от потребителя
$customer_ID = 200;
$sub_total = 1000;

// Формулиране на заявката
// Това е най-добрият начин да се изпълни SQL заявка
// mysql_real_escape_string() освобождавастринга на SQL заявкта от специалните символи; sprintf - връща форматиран низ
$sql= sprintf("SELECT SalesOrderID, OrderDate, DueDate, ShipDate, CustomerID, SubTotal FROM salesorderheader WHERE CustomerID = '%s' AND SubTotal > '%s'",
    mysql_real_escape_string($customer_ID),
    mysql_real_escape_string($sub_total));



$result = mysql_query($sql);
if (!$result) {
    $message  = 'Невалидна заявка: ' . mysql_error();
}
else {
echo "Брой редове в заявката: ". mysql_num_rows ($result);
}

while ($row = mysql_fetch_array($result, MYSQL_NUM)) {
	printf("<br>");
    printf("поръчка ID: %s  Поръчка дата: %s  Клиент ID: %s  Общо: %s"   , $row[0], $row[1], $row[4], $row[5]);
}

mysql_free_result($result);


?> 

</body>

</html>
