<div id="right-top">
                    <div id="left-head">
                        <b><a style="text-decoration:none; color:black;" href="index.php">TRANG CHỦ</a></b>
                        <img src="images/arrow2.png"/>
                        <b><span style="font-size:18px; color:#3875c6;">KẾT QUẢ TÌM KIẾM</span></b>
                        <!-- TÊN MỤC -->    
                    </div>
                    <div id="right-head">
                        <a href="index.php?page=giohang"><img height="20px" src="images/giohang.png"></a>
                    </div>
                </div>
<div id="right-center">
<div id="products">
<ul>
    <?php
        $dbc = mysqli_connect('localhost','root', '', 'sanpham');
        mysqli_set_charset($dbc, 'utf8');
        if($_POST['tensp'] != "") {
            $sql = "SELECT * FROM products where tensp like  '%".$_POST['tensp']."%'";
            $qry = mysqli_query($dbc, $sql);
            $num_rows = mysqli_num_rows($qry);
            if($num_rows > 0) {
                while($rows = mysqli_fetch_assoc($qry)) {        
    ?>
                    <li>
                        <div class="content">
                            <a href=""><img src="<?php echo $rows['link']; ?>"/></a>
                            <p class="title"><?php echo $rows['tensp']; ?></p>
                            <p class="price"><?php echo $rows['giasp']; ?> VNĐ</p>
                        </div>
                    </li>
    <?php 
                }             
            } else {
                echo "<script>alert(\" Sản phẩm bạn tìm không có ! \")</script>";
            }
        } else {
            header("Location: index.php");
        }
    ?>
</ul>
</div>
</div>
                              