<?php require_once 'header.php' ?>

<div class="page-wrap"> <!-- class="page-wrap" -->
    
    <div class="content"> <!-- class="content" -->
        <ul class="breadcrumbs">
            <?=$breadcrumbs_new?>
        </ul>                


<div class="content-page">

     <h1 class="product_title"><?=$page['title']?></h1>

        <div class="product-txt">

<?php echo $page['text'] ?>

        </div>

        <div class="clr"></div>

</div> <!-- .content-page -->

    
    </div> <!-- class="content" -->
    
<?php require_once 'sidebar.php' ?>
    
</div> <!-- class="page-wrap" -->

<?php require_once 'footer.php' ?>