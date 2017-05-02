
            <div id="right-top">
                    <div id="left-head">
                        <b><a style="text-decoration:none; color:black;" href="admin.php">ADMIN</a></b>
                        <img src="images/arrow2.png"/>
                        <b><span style="font-size:18px; color:#3875c6;">SẢN PHẨM MỚI CẬP NHẬT</span></b>
                        <!-- TÊN MỤC -->    
                    </div>
                </div>
                <div id="right-center2">
                    <div id="table-detail">
                        <form method="post" action="">
                            <table border="3" border-color="white"cellspacing="0px">
                                <tr>
                                    <td class="tieudesp">ID</td>
                                    <td class="tieudesp">Tên tài khoản</td>
                                    <td class="tieudesp">Mật khẩu</td>
                                    <td class="tieudesp">Email</td>
                                    <td class="tieudesp">Số điện thoại</td>
                                    <td class="tieudesp">Trạng thái</td>
                                    <td class="tieudesp">Khóa</td>
                                    <td class="tieudesp">Mở</td>
                                    <td class="tieudesp">Xóa</td>
                                </tr>
                                <?php
                                    $dbc = mysqli_connect('localhost','root', '', 'sanpham');
                                    mysqli_set_charset($dbc, 'utf8');
                                    if(!$_GET['trang']) {
                                        $page=1;
                                    } else {
                                        $page= $_GET['trang'];
                                    }

                                    //Hien thi toi da so luong san pham
                                    $max_result = 20;
                                    //Tinh vi tri san pham trong csdl
                                    $index_row= $page*$max_result - $max_result;
                                    //Liet ke du lieu
                                    $dbc = mysqli_connect('localhost','root', '', 'sanpham');
                                    mysqli_set_charset($dbc, 'utf8');
                                    $sql = "SELECT * FROM members where state in(1,3) limit $index_row, $max_result";
                                    $qry = mysqli_query($dbc, $sql);
                                    $num_rows = mysqli_num_rows($qry);
                                    if($num_rows > 0) {
                                        while($rows = mysqli_fetch_assoc($qry)) {      
                                ?>
                                <tr>
                                    <td class="sanpham"><?php echo $rows['id']; ?></td>
                                    <td class="sanpham"><?php echo $rows['username']; ?></td>
                                    <td class="sanpham"><?php echo $rows['password']; ?></td>
                                    <td class="sanpham"><?php echo $rows['email']; ?></td>
                                    <td class="sanpham"><?php echo $rows['sdt']; ?>td>
                                    <td class="sanpham"><?php echo $rows['state']; ?></td>
                                    <td class="sanpham"><a href="admin.php?page=khoathanhvien&id=<?php echo $rows['id']; ?>">Khóa</a></td>
                                    <td class="sanpham"><a href="admin.php?page=mokhoathanhvien&id=<?php echo $rows['id']; ?>">Mở</a></td>
                                    <td class="sanpham"><a href="admin.php?page=xoathanhvien&id=<?php echo $rows['id']; ?>">Xóa</a></td>
                                </tr>
                                    <?php 
                                            }             
                                        } else {
                                            echo "<script>alert(\" Hiện tại chưa có dữ liệu trong bảng ! \")</script>";
                                        }
                                    ?>
                            </table>
                        </form>
                        <?php 
                            include("modules/phantrang-thanhvien.php");
                        ?>
                    </div>
                </div>