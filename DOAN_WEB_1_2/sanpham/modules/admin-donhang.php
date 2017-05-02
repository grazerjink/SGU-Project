
                <div id="right-top">
                    <div id="left-head">
                        <b><a style="text-decoration:none; color:black;" href="admin.php">ADMIN</a></b>
                        <img src="images/arrow2.png"/>
                        <b><span style="font-size:18px; color:#3875c6;">ĐƠN HÀNG</span></b>
                        <!-- TÊN MỤC -->    
                    </div>
                </div>
                <div id="right-center2">
                    <div id="table-detail">
                        <form method="post" action="">
                            <table border="3" border-color="white"cellspacing="0px">
                                <tr>
                                    <td class="checkbox"><input type="checkbox" class="tickall" onclick="checkall('tick', this)"/></td>
                                    <td class="tieudesp">Mã đơn hàng</td>
                                    <td class="tieudesp">Tên khách hàng</td>
                                    <td class="tieudesp">Mã sản phẩm</td>
                                    <td class="tieudesp">Số lượng</td>
                                    <td class="tieudesp">Thời gian</td>
                                    <td class="tieudesp">Tình trạng</td>
                                </tr>
                                <?php
                                        $dbc = mysqli_connect('localhost','root', '', 'sanpham');
                                        mysqli_set_charset($dbc, 'utf8');
                                        $sql = "SELECT * FROM products orders limit 1, 5 ";
                                        $qry = mysqli_query($dbc, $sql);
                                        $num_rows = mysqli_num_rows($qry);
                                        if($num_rows > 0) {
                                            while($rows = mysqli_fetch_assoc($qry)) {      
                                ?>
                                <tr>
                                    <td class="checkbox1"><input type="checkbox" class="tick"/></td>
                                    <td class="noidung">DH001</td>
                                    <td class="noidung">Nguyễn Văn Dũng</td>
                                    <td class="noidung">CPU015</td>
                                    <td class="noidung">2</td>
                                    <td class="noidung">04/12/15 - 10:45</td>
                                    <td class="noidung">Đã xử lý</td>
                                </tr>
                                <tr>
                                    <td class="checkbox1"><input type="checkbox" class="tick"/></td>
                                    <td class="noidung">DH002</td>
                                    <td class="noidung">Bành Thị Thuý</td>
                                    <td class="noidung">USB012</td>
                                    <td class="noidung">2</td>
                                    <td class="noidung">04/12/15 - 17:15</td>
                                    <td class="noidung">Đã xử lý</td>
                                </tr>
                                <tr>
                                    <td class="checkbox1"><input type="checkbox" class="tick"/></td>
                                    <td class="noidung">DH003</td>
                                    <td class="noidung">Lý Dai</td>
                                    <td class="noidung">LOA008</td>
                                    <td class="noidung">2</td>
                                    <td class="noidung">05/12/15 - 15:05</td>
                                    <td class="noidung">Chưa xử lý</td>
                                </tr>
                                <tr>
                                    <td class="checkbox1"><input type="checkbox" class="tick"/></td>
                                    <td class="noidung">DH004</td>
                                    <td class="noidung">Trần Thanh Thản</td>
                                    <td class="noidung">RAM011</td>
                                    <td class="noidung">3</td>
                                    <td class="noidung">06/12/15 - 14:10</td>
                                    <td class="noidung">Chưa xử lý</td>
                                </tr>
                                <?php 
                                            }             
                                        } else {
                                            echo "<script>alert(\" Hiện tại chưa có dữ liệu trong bảng ! \")</script>";
                                        }
                                ?>
                            </table>
                            <div id="chucnang" class="submit">
                                <select style="padding: 3px;">
                                    <option>Chọn</option>
                                    <option>Xóa đơn hàng</option>
                                    <option>Chưa xử lý</option>
                                    <option>Đã xử lý</option>
                                </select>
                                <input type="submit" name="xoa" value="Xác nhận"/>
                            </div>
                        </form>
                    </div>
                </div>