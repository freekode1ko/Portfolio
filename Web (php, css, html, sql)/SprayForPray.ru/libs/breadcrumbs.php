<?php defined("CATALOG") or die("Access denied");

// return true (array not empty) || return false
$breadcrumbs_array = breadcrumbs($categories, $id);

if($breadcrumbs_array){
	$breadcrumbs = "<li><a href='" .PATH. "'>Главная</a> / </li>";
	foreach($breadcrumbs_array as $id => $title){
		$breadcrumbs .= "<li><a href='" .PATH. "category/{$id}'>{$title}</a> / </li>";
	}
	if( !isset($get_one_product) ){
		$breadcrumbs = rtrim($breadcrumbs, " / ");
		$breadcrumbs = preg_replace("#(.+)?<a.+>(.+)</a>$#", "$1$2", $breadcrumbs);
	}else{
		$breadcrumbs .= $get_one_product['title'];
	}
}else{
	$breadcrumbs = "<li><a href='" .PATH. "'>Главная</a> / Каталог</li>";
}

$breadcrumbs2 = explode(' / ', $breadcrumbs);
$breadcrumbs_new = null;
$end = array_pop($breadcrumbs2);
foreach($breadcrumbs2 as $item){
	$breadcrumbs_new .= "<li>{$item} - </li>";
}
$breadcrumbs_new .= $end;

?>