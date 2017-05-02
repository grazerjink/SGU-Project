<?php 
    $next = $_GET['trang'] + 1;
    $prev = $_GET['trang'] - 1;
?>
<div id="page">
                        <pre><a href="<?php echo $_SERVER['PHP_SELF']."?trang=".$prev; ?>">&lt;</a> <a href="<?php echo $_SERVER['PHP_SELF']."?trang=1";?>">1</a> <a href="<?php echo $_SERVER['PHP_SELF']."?trang=2";?>">2</a> <a href="<?php echo $_SERVER['PHP_SELF']."?trang=3";?>">3</a> <a href="<?php echo $_SERVER['PHP_SELF']."?trang=4";?>">4</a> <a href="<?php echo $_SERVER['PHP_SELF']."?trang=5";?>">5</a> <a href="<?php echo $_SERVER['PHP_SELF']."?trang=".$next; ?>">&gt;</a></pre>
</div>