<?php 
    $masp = $_GET['stt'];
    deleteProducts($masp);
    sleep(1);
    header("location:admin.php?page=sanpham");
?>