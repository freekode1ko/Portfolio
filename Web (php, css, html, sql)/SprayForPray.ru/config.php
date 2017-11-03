<?php defined("CATALOG") or die("Access denied");

define("DBHOST", "localhost");
define("DBUSER", "root");
define("DBPASS", "");
define("DB", "Spray");
define("PATH", "http://sprayforpray.ru/");
define("VIEW", "views/spray/");
define("PRODUCTIMG", "UserFiles/products/");
define("PERPAGE", 6);
$option_perpage = array(6, 12, 18);

$connection = @mysqli_connect(DBHOST, DBUSER, DBPASS, DB) or die("Нет соединения с БД");
mysqli_set_charset($connection, "utf8") or die("Не установлена кодировка соединения");