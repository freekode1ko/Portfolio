<?php defined("CATALOG") or die("Access denied");

include 'main_controller.php';
include "models/{$view}_model.php";

if( !isset($id) ) $id = null;

include 'libs/breadcrumbs.php';

$ids = cats_id($categories, $id);
$ids = !$ids ? $id : rtrim($ids, ",");

/*=========Пагинация==========*/

$perpage = ( isset($_COOKIE['per_page']) && (int)$_COOKIE['per_page'] ) ? $_COOKIE['per_page'] : PERPAGE;
$count_goods = count_goods($ids);
$count_pages = ceil($count_goods / $perpage);
if( !$count_pages ) $count_pages = 1;

if( isset($_GET['page']) ){
	$page = (int)$_GET['page'];
	if( $page < 1 ) $page = 1;
}else{
	$page = 1;
}

if( $page > $count_pages ) $page = $count_pages;

$start_pos = ($page - 1) * $perpage;

$pagination = pagination($page, $count_pages);

/*=========Пагинация==========*/

$products = get_products($ids, $start_pos, $perpage);

include VIEW . "{$view}.php";

?>