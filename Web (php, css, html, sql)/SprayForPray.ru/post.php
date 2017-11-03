<? 

$adminemail="spraysforpray@gmail.com";
 
$date=date("d.m.y");
 
$time=date("H:i");
 
$backurl="http://sprayforpray.ru";  
 

$name=$_POST['name']; 
 
$email=$_POST['email']; 
 
$msg=$_POST['message']; 
 
if (!preg_match("|^([a-z0-9_\.\-]{1,20})@([a-z0-9\.\-]{1,20})\.([a-z]{2,4})|is", 
strtolower($email))) 
 
 { 
 
  echo 
"<center>Внимание! <a 
href='javascript:history.back(1)'><B>Вернитесь назад</B></a>. Вы допустили ошибку при вводе данных! Пожалуйста, вернитесь назад, и проверьте всё ещё раз."; 
 
  } 
 
 else 
 
 { 
 
$msg=""; 
 
mail("$adminemail", "$date $time Message from $name", "$msg"); 

print "<script language='Javascript'><!-- 
function reload() {location = \"$backurl\"}; setTimeout('reload()', 6000); 
//--></script> 
 
$msg 
 
<p>Ваш заказ отправился на обработку. Мы свяжемся с вами по её окончанию. Спасибо за заказ!</p>";  
exit; 
 
 } 
 
?>