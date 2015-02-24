<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">

<head>
<meta content="text/html; charset=utf-8" http-equiv="Content-Type" />
<title>Проверка на парола</title>
</head>

<?php
$password_text = "parola123!";
$password_hash_result = password_hash($password_text, PASSWORD_DEFAULT);

$password_user = "parola12345";

if (password_verify($password_user, $password_hash_result)) {
    echo 'Валидна парола!';
} else {
    echo 'Невалидна парола!';
}



?>

<body>

</body>

</html>
