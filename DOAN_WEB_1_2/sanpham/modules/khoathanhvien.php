<?php 
    $id = $_GET['id'];
    bannId($id);
    sleep(1);
    header("Location:admin.php?page=thanhvien"); 
?>