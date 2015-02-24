<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">

<head>
<meta content="text/html; charset=utf-8" http-equiv="Content-Type" />
<title>Проверка на въведените данни</title>
</head>

<body>
<?php
if($_POST['formSubmit'] == "Submit") 
{
  $errorMessage = "";
 
  if(empty($_POST['formMovie'])) 
  {
    $errorMessage .= "<li>Не сте въвели филм!</li>";
  }
  if(empty($_POST['formName'])) 
  {
    $errorMessage .= "<li>Не сте въвели вашето име!</li>";
  }
 
  $varMovie = $_POST['formMovie'];
  $varName = $_POST['formName'];
 
  if(!empty($errorMessage)) 
  {
    echo("<p>Има грешки във вашата форма:</p>\n");
    echo("<ul>" . $errorMessage . "</ul>\n");
  } 
  else {
  	echo "Здравейте $varName"."<br>";
  	echo "Вашият любим филм е $varMovie";
  }
} 
?>
</body>

</html>
