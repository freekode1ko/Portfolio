<?php defined("CATALOG") or die("Access denied"); ?>
<!doctype html>
<html lang="en">
<head>
	<meta charset="UTF-8">
	<title><?=strip_tags($breadcrumbs)?></title>
	<link rel="stylesheet" href="<?=PATH . VIEW?>css/style.css">
	<link rel="stylesheet" href="<?=PATH . VIEW?>css/smoothness/jquery-ui-1.10.3.custom.min.css">
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
<?php if($get_one_product): ?>
	<?php print_arr($get_one_product); ?>
<?php else: ?>
	Такого товара нет
<?php endif; ?>


</ul>


<div id="form-wrap">
	<form action="<?=PATH?>add_comment" method="post" class="form">
	<?php if( isset($_SESSION['auth']['user']) ): ?>
		<p style="display:none;">
			<label for="comment-author">Имя:</label>
			<input type="text" name="comment-author" id="comment-author" value="<?=htmlspecialchars($_SESSION['auth']['user'])?>">
		</p>
	<?php else: ?>
		<p>
			<label for="comment-author">Имя:</label>
			<input type="text" name="comment-author" id="comment-author">
		</p>
	<?php endif; ?>	

		<p>
			<label for="comment-text">Текст:</label>
			<textarea name="comment-text" id="comment-text" cols="30" rows="5"></textarea>
		</p>

		<input type="hidden" id="parent" name="parent" value="0">

		<!-- <p class="submit">
			<input type="submit" value="Добавить отзыв" name="submit">
		</p> -->
	</form>
</div>

<div id="loader"><span></span></div>
<div id="errors"></div>

		</div>
	</div>
	<script src="<?=PATH . VIEW?>js/jquery-1.9.0.min.js"></script>
	<script src="<?=PATH . VIEW?>js/jquery-ui-1.10.3.custom.min.js"></script>
	<script src="<?=PATH . VIEW?>js/jquery.accordion.js"></script>
	<script src="<?=PATH . VIEW?>js/jquery.cookie.js"></script>
	<script>
$(document).ready(function(){
	$(".category").dcAccordion();

$('#errors').dialog({
	autoOpen: false,
	width: 450,
	modal: true,
	title: 'Сообщение об ошибке',
	show: {effect: 'slide', duration: 700},
	hide: {effect: 'explode', duration: 700},
});

$('#form-wrap').dialog({
	autoOpen: false,
	width: 450,
	modal: true,
	title: 'Добавление сообщения',
	resizable: false,
	draggable: false,
	show: {effect: 'slide', duration: 700},
	hide: {effect: 'explode', duration: 700},
	buttons: {
		"Добавить отзыв": function(){
			var commentAuthor = $.trim($('#comment-author').val());
			var commentText = $.trim($('#comment-text').val());
			var parent = $('#parent').val();
			var productId = <?=$product_id?>;
			if(commentText == '' || commentAuthor == ''){
				alert('Все поля обязательны к заполнению');
				return;
			}
			$('#comment-text').val('');
			$(this).dialog('close');
			$.ajax({
				url: '<?=PATH?>add_comment',
				type: 'POST',
				data: {commentAuthor: commentAuthor, commentText: commentText, parent: parent, productId: productId},
				beforeSend: function(){
					$('#loader').fadeIn();
				},
				success: function(res){
					var result = JSON.parse(res);
					if(result.answer == 'Комментарий добавлен!'){
						// если комментарий добавлен
						var showComent = '<li class="new-comment" id="comment-' + result.id + '">' + result.code + '</li>';
						if(parent == 0){
							// если это не ответ
							$('ul.comments').append(showComent);
						}else{
							// если ответ
							// находим родителя li
							var parentComment = $this.closest('li');
							// смотрим, есть ли ответы
							var childs = parentComment.children('ul');
							if(childs.length){
								// если ответы есть
								childs.append(showComent);
							}else{
								// если ответов пока нет
								parentComment.append('<ul>' + showComent + '</ul>');
							}
						}
						$('#comment-' + result.id).delay(1000).show('shake', 1000);
					}else{
						// если комментарий не добавлен
						$('#errors').text(result.answer);
						$('#errors').delay(1000).queue(function(){
							$(this).dialog('open');
							$(this).dequeue();
						});
						/*$('#errors').delay(1000).queue(function(next){
							$(this).dialog('open');
							next();
						});*/
					}
				},
				error: function(){
					alert("Ошибка!");
				},
				complete: function(){
					$('#loader').delay(1000).fadeOut();
				}
			});
		},
		"Отмена": function(){
			$(this).dialog('close');
			$('#comment-text').val('');
		}
	}
});
$('.open-form').click(function(){
	$('#form-wrap').dialog('open');
	var parent = $(this).children().attr('data');
	$this = $(this);
	if(!parseInt(parent)) parent = 0;
	$('input[name="parent"]').val(parent);
});

});
	</script>
	<script src="<?=PATH . VIEW?>js/workscrips.js"></script>
</body>
</html>