<?php defined("CATALOG") or die("Access denied");

include 'main_controller.php';
include "models/{$view}_model.php";

$get_one_product = get_one_product($product_alias);
$id = $get_one_product['parent'];

$product_id = $get_one_product['id'];


include 'libs/breadcrumbs.php';

include VIEW . "{$view}.php";

?>