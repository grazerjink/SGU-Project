<?php 
    $id = $_GET['id'];
    unBannId($id);
    sleep(1);
    header("Location:admin.php?page=thanhvien"); 
?>