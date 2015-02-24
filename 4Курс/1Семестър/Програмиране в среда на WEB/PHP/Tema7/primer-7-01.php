<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">

<head>
<meta content="text/html; charset=utf-8" http-equiv="Content-Type" />
<title>Untitled 1</title>
</head>

<body>

<?php

$mystring = 'abcde';
$findme   = 'ab';
$pos = strpos($mystring, $findme);

// Използва се оператора ===.  Обикновеното сравняване с оператора ==
// няма да работи както се очаква, тъй като позицията на 'a' е нулевият (първи) знак.
if ($pos === false) {
    echo "Низът '$findme' не беше открит в низа '$mystring'";
} else {
    echo "Низът '$findme'  беше открит в низа '$mystring'";
    echo " и започва от позиция $pos";
}


?>


</body>

</html>
