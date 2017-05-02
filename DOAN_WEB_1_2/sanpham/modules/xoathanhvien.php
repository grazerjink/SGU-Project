<?php 
    $id = $_GET['id'];
    deleteMembers($id);
    sleep(1);
    header("Location:admin.php?page=thanhvien"); 
?>