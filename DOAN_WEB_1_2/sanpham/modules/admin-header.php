<div id="banner">   
            <a name="TOP">
            <a href="admin.php"><img src="images/banner2.png"/></a>
        </div>
        <div id="header">
            <div id="home">
                <a href="admin.php"><img height="35px" width="35px" src="images/home.png"/></a>
            </div>
            <div id="tieude">
                <ul>
                    <li class="them"><a href="admin.php?page=sanpham">Sản phẩm</a></li>
                    <li class="donhang"><a href="admin.php?page=donhang">Đơn hàng</a></li>
                    <li class="thongke"><a href="admin.php?page=thongke">Thống kê</a></li>
                    <li class="thanhvien"><a href="admin.php?page=thanhvien">Thành viên</a></li>
                </ul>
            </div>
                    <div id="quantri">
            <img src="images/login.png"/>
            <div id="username">
                <?php 
                    if(isset($_POST["thoat"])) {
                        unset($_SESSION['username']);
                        header("Location: index.php");
                    }
                ?>
                <form method="post">
                    <span><?php echo "Chào, ".$_SESSION['username'];?></span>
                    <input type="submit" name="thoat" style="margin-left:4px;" value = "Thoát" />
                </form>
            </div>
        </div>
        </div>