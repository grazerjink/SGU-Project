<?php  
    $masp = $_GET['stt'];
?>
<div id="right-top">
                    <div id="left-head">
                        <b><a style="text-decoration:none; color:black;" href="admin.php">ADMIN</a></b>
                        <img src="images/arrow2.png"/>
                        <b><span style="font-size:18px; color:#3875c6;">CẬP NHẬT THÔNG TIN SẢN PHẨM</span></b>
                        <!-- TÊN MỤC -->    
                    </div>
        </div>
        <div id="right-center2">
            <div id="table-detail" style="clear:both">
                        <form method="post">
                            <table border="3" border-color="white"cellspacing="0px">
                                <tr>
                                    <td class="tieudesp">Hình ảnh</td>
                                    <td class="tieudesp">STT</td>
                                    <td class="tieudesp">Tên sản phẩm</td>
                                    <td class="tieudesp">Loại sản phẩm</td>
                                    <td class="tieudesp">Số lượng</td>
                                    <td class="tieudesp">Giá bán</td>
                                    <td class="tieudesp">Thông số kỹ thuật</td>
                                </tr>
                                <?php
                                        $dbc = mysqli_connect('localhost','root', '', 'sanpham');
                                        mysqli_set_charset($dbc, 'utf8');
                                        $sql = "SELECT * FROM products where masp = '$masp'";
                                        $qry = mysqli_query($dbc, $sql);
                                        $num_rows = mysqli_num_rows($qry);
                                        $rows = mysqli_fetch_array($qry);
                                ?>
                                <tr>
                                    <td class="hinhanh1"><img src='<?php echo $rows['link']; ?>'/></td>
                                    <td class="sanpham"><?php echo $rows['masp']; ?></td>
                                    <td class="sanpham"><?php echo $rows['tensp']; ?></td>
                                    <td class="sanpham"><?php echo $rows['loaisp']; ?></td>
                                    <td class="sanpham"><?php echo $rows['soluong']; ?></td>
                                    <td class="sanpham"><?php echo $rows['giasp']; ?></td>
                                    <td class="sanpham"><?php echo $rows['thongso']; ?></td>
                                </tr>
                            </table>
                        </form>
                    </div>
                        
                    
                    <div id="themsp">
                        <?php 
                         if(isset($_POST['suasp'])) {
                                $sua = array("masp"=>$masp,
                                "tensp"=>$_POST['tensp2'],
                                "loaisp"=>$_POST['loaisp2'],
                                "soluong"=>$_POST['soluong2'],
                                "giasp"=>$_POST['giasp2'],
                                "thongso"=>$_POST['thongso2']);
                                editProducts($sua);
                                sleep(1);
                                header("Location:admin.php");
                            }
                        ?>
                        <div><label>SỬA THÔNG TIN SẢN PHẨM</label></div>
                        <form method="post">
                            <table cellspacing="15px">
                                <tr>
                                    <td class="tenmuc">Tên sản phẩm</td>
                                    <td><input name="tensp2" type="text"/></td>
                                </tr>
                                <tr>
                                    <td class="tenmuc">Loại sản phẩm</td>
                                    <td><input name="loaisp2" type="text"/></td>
                                </tr>
                                <tr>
                                    <td class="tenmuc">Số lượng</td>
                                    <td><input name="soluong2" type="text"/></td>
                                </tr>
                                <tr>
                                    <td class="tenmuc">Giá sản phẩm</td>
                                    <td><input name="giasp2" type="text"/></td>
                                </tr>
                                <tr>
                                    <td class="tenmuc">Thông số sản phẩm</td>
                                    <td><textarea name="thongso2"></textarea></td>
                                </tr>
                                <tr>
                                    <td colspan="2" class="nutbam">
                                        <input name="suasp" type="submit" value="Lưu lại"/>
                                        <input type="reset" value="Nhập lại"/>                                    
                                    </td>
                                </tr>
                            </table>
                        </form>
                    </div>
                </div>