<?php defined("CATALOG") or die("Access denied"); ?>
<!doctype html>
<html lang="en">
<head>
	<meta charset="UTF-8">
	<title><?=strip_tags($breadcrumbs)?></title>
	<link rel="stylesheet" href="<?=PATH . VIEW?>css/style.css">
</head>
<body>
	<div class="wrapper">
		<div class="sidebar">
			<?php include 'sidebar.php'; ?>
		</div>
		<div class="content">

			<?php include 'menu.php'; ?>

			<p><?=$breadcrumbs;?></p>
			<br>
			<hr>

<?=$page['text']?>

		</div>
	</div>
	<script src="<?=PATH . VIEW?>js/jquery-1.9.0.min.js"></script>
	<script src="<?=PATH . VIEW?>js/jquery.accordion.js"></script>
	<script src="<?=PATH . VIEW?>js/jquery.cookie.js"></script>
	<script>
		$(document).ready(function(){
			$(".category").dcAccordion();
		});
	</script>
	<script src="<?=PATH . VIEW?>js/workscrips.js"></script>
</body>
</html>