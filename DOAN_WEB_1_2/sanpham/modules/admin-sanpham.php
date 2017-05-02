
            <div id="right-top">
                    <div id="left-head">
                        <b><a style="text-decoration:none; color:black;" href="admin.php">ADMIN</a></b>
                        <img src="images/arrow2.png"/>
                        <b><span style="font-size:18px; color:#3875c6;">SẢN PHẨM MỚI CẬP NHẬT</span></b>
                        <!-- TÊN MỤC -->    
                    </div>
                </div>
                <div id="right-center2">
                    <div id="table-detail" style ="padding-left:25px;">
                        <form method="post" action="admin.php?page=suasanpham">
                            <table border="3" border-color="white"cellspacing="0px">
                                <tr>
                                    <td class="tieudesp">STT</td>
                                    <td class="tieudesp">Hình ảnh</td>
                                    <td class="tieudesp">Tên sản phẩm</td>
                                    <td class="tieudesp">Loại sản phẩm</td>
                                    <td class="tieudesp">Số lượng</td>
                                    <td class="tieudesp">Giá bán</td>
                                    <td class="tieudesp">Sửa</td>
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
                                    $max_result = 8;
                                    //Tinh vi tri san pham trong csdl
                                    $index_row= $page*$max_result - $max_result;
                                    //Liet ke du lieu
                                    $sql = "select * from products limit $index_row, $max_result";
                                    $qry = mysqli_query($dbc, $sql);
                                    $num_rows = mysqli_num_rows($qry);
                                    if($num_rows > 0) {
                                        while($rows = mysqli_fetch_assoc($qry)) {      
                                ?>
                                <tr>
                                    <td class="sanpham"><?php echo $rows['masp']; ?></td>
                                    <td class="hinhanh1"><img src='<?php echo $rows['link']; ?>'/></td>
                                    <td class="sanpham"><?php echo $rows['tensp']; ?></td>
                                    <td class="sanpham"><?php echo $rows['loaisp']; ?></td>
                                    <td class="sanpham"><?php echo $rows['soluong']; ?></td>
                                    <td class="sanpham"><?php echo $rows['giasp']; ?></td>
                                    <td class="sanpham"><a href="admin.php?page=suasanpham&stt=<?php echo $rows['masp']; ?>">Sửa</a></td>
                                    <td class="sanpham"><a href="admin.php?page=xoasanpham&stt=<?php echo $rows['masp']; ?>">Xóa</a></td>
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
                            include("modules/phantrang-sanpham.php");
                        ?>
                    </div>
                    <div id="themsp">
                        <div><label>THÊM NHANH SẢN PHẨM</label></div>
                        <form method="post">
                            <table cellspacing="15px">
                                <tr>
                                    <td class="tenmuc">Loại sản phẩm</td>
                                    <td>
                                        <select name="loaisp" style="height:25px; width:150px; padding-left:10px;">
                                            <option>CPU</option>
                                            <option>RAM</option>
                                            <option>VGA</option>
                                            <option>USB</option>
                                            <option>Loa máy tính</option>
                                            <option>Tai nghe</option>
                                        </select>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="tenmuc">Tên sản phẩm</td>
                                    <td><input name="tensp" type="text" placeholder="Tên sản phẩm"/></td>
                                </tr>
                                <tr>
                                    <td class="tenmuc">Số lượng</td>
                                    <td><input name="soluong" type="text" placeholder="Số lượng sản phẩm"/></td>
                                </tr>
                                <tr>
                                    <td class="tenmuc">Giá bán</td>
                                    <td><input name="giasp" type="text" placeholder="Giá bán" /></td>
                                </tr>
                                <tr>
                                    <td class="tenmuc">Thông số sản phẩm</td>
                                    <td><textarea name="thongso" placeholder="Thông số kỹ thuật"></textarea></td>
                                </tr>
                                <tr>
                                    <td class="tenmuc">Hình ảnh</td>
                                    <td><input name="link" type="file"/></td>
                                </tr>
                                <tr>
                                    <td colspan="2" class="nutbam">
                                        <input name="submit" type="submit" value="Thêm sản phẩm"/>
                                        <input type="reset" value="Nhập lại"/>
                                    </td>
                                </tr>
                            </table>  
                        </form>
                    </div>
                </div>