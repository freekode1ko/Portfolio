<?php require_once 'header.php' ?>

<div class="page-wrap"> <!-- class="page-wrap" -->
    
    <div class="content"> <!-- class="content" -->
        <ul class="breadcrumbs">
            <?=$breadcrumbs_new?>
        </ul>                


<div class="content-page">

     <h1 class="product_title"><?=$get_one_product['title']?></h1>

    <div class="img-product"><img src="<?=PATH . PRODUCTIMG . $get_one_product['image']?>" alt="" /></div>

        <div class="product-txt">

<?php echo $get_one_product['content'] ?>


        </div>

        <div class="clr"></div>

        <div class="product-inf">
            
        </div>

        <div class="clr"></div>

</div> <!-- .content-page -->

    
    </div> <!-- class="content" -->
    
<?php require_once 'sidebar.php' ?>
 
</div> <!-- class="page-wrap" -->

