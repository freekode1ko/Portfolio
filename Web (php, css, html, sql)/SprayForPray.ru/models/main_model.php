<?php defined("CATALOG") or die("Access denied");

function print_arr($array){
	echo "<pre>" . print_r($array, true) . "</pre>";
}

function redirect($http = false){
	if($http) $redirect = $http;
	else $redirect = isset($_SERVER['HTTP_REFERER']) ? $_SERVER['HTTP_REFERER'] : PATH;
	header("Location: $redirect");
	exit;
}


function get_pages(){
	global $connection;
	$query = "SELECT title, alias FROM pages ORDER BY position";
	$res = mysqli_query($connection, $query);

	$pages = array();
	while($row = mysqli_fetch_assoc($res)){
		$pages[$row['alias']] = $row['title'];
	}
	return $pages;
}


function get_cat(){
	global $connection;
	$query = "SELECT * FROM categories";
	$res = mysqli_query($connection, $query);

	$arr_cat = array();
	while($row = mysqli_fetch_assoc($res)){
		$arr_cat[$row['id']] = $row;
	}
	return $arr_cat;
}


function map_tree($dataset) {
	$tree = array();

	foreach ($dataset as $id=>&$node) {    
		if (!$node['parent']){
			$tree[$id] = &$node;
		}else{ 
            $dataset[$node['parent']]['childs'][$id] = &$node;
		}
	}

	return $tree;
}


function categories_to_string($data, $template = 'category_template.php'){
	$string = null;
	foreach($data as $item){
		$string .= categories_to_template($item, $template);
	}
	return $string;
}

function categories_to_template($category, $template){
	ob_start();
	include VIEW . "{$template}";
	return ob_get_clean();
}


function pagination($page, $count_pages, $modrew = true){
	
	$back = null; 
	$forward = null; 
	$startpage = null;
	$endpage = null;
	$page2left = null;
	$page1left = null; 
	$page2right = null; 
	$page1right = null;

	$uri = "?";
	if(!$modrew){
	
		if( $_SERVER['QUERY_STRING'] ){
			foreach ($_GET as $key => $value) {
				if( $key != 'page' ) $uri .= "{$key}=$value&amp;";
			}
		}
	}else{
		$url = $_SERVER['REQUEST_URI'];
		$url = explode("?", $url);
		if(isset($url[1]) && $url[1] != ''){
			$params = explode("&", $url[1]);
			foreach($params as $param){
				if(!preg_match("#page=#", $param)) $uri .= "{$param}&amp;";
			}
		}
	}

	if( $page > 1 ){
		$back = "<li><a class='nav-link' href='{$uri}page=" .($page-1). "'>&larr;</a></li>";
	}
	if( $page < $count_pages ){
		$forward = "<li><a class='nav-link' href='{$uri}page=" .($page+1). "'>&rarr;</a></li>";
	}
	if( $page > 2 ){
		$startpage = "<li><a class='nav-link' href='{$uri}page=1'>&laquo;</a></li>";
	}
	if( $page < ($count_pages - 1) ){
		$endpage = "<li><a class='nav-link' href='{$uri}page={$count_pages}'>&raquo;</a></li>";
	}
	if( $page - 2 > 0 ){
		$page2left = "<li><a class='nav-link' href='{$uri}page=" .($page-2). "'>" .($page-2). "</a></li>";
	}
	if( $page - 1 > 0 ){
		$page1left = "<li><a class='nav-link' href='{$uri}page=" .($page-1). "'>" .($page-1). "</a></li>";
	}
	if( $page + 1 <= $count_pages ){
		$page1right = "<li><a class='nav-link' href='{$uri}page=" .($page+1). "'>" .($page+1). "</a></li>";
	}
	if( $page + 2 <= $count_pages ){
		$page2right = "<li><a class='nav-link' href='{$uri}page=" .($page+2). "'>" .($page+2). "</a></li>";
	}

	return $startpage.$back.$page2left.$page1left.'<li><a class="active-page">'.$page.'</li>'.$page1right.$page2right.$forward.$endpage;
}

function breadcrumbs($array, $id){
	if(!$id) return false;

	$count = count($array);
	$breadcrumbs_array = array();
	for($i = 0; $i < $count; $i++){
		if(isset($array[$id])){
			$breadcrumbs_array[$array[$id]['id']] = $array[$id]['title'];
			$id = $array[$id]['parent'];
		}else break;
	}
	return array_reverse($breadcrumbs_array, true);
}

?>