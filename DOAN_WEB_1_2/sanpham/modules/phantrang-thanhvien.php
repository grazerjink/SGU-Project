<?php 
    $next = $_GET['trang'] + 1;
    $prev = $_GET['trang'] - 1;
?>
<div id="page">
                        <pre><a href="<?php echo "admin.php?page=thanhvien&trang=".$prev; ?>">&lt;</a> <a href="<?php echo "admin.php?page=thanhvien&trang=1";?>">1</a> <a href="<?php echo "admin.php?page=thanhvien&trang=2";?>">2</a> <a href="<?php echo "admin.php?page=thanhvien&trang=3";?>">3</a> <a href="<?php echo "admin.php?page=thanhvien&trang=4";?>">4</a> <a href="<?php echo "admin.php?page=thanhvien&trang=5";?>">5</a> <a href="<?php echo "admin.php?page=thanhvien&trang=".$next; ?>">&gt;</a></pre>
</div>