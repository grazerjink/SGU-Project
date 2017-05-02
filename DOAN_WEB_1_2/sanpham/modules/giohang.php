                <div id="right-top">
                    <div id="left-head">
                        <b><a style="text-decoration:none; color:black;" href="index.php">TRANG CHỦ</a></b>
                        <img src="images/arrow2.png"/>
                        <b><span style="font-size:18px; color:#3875c6;">GIỎ HÀNG CỦA BẠN</span></b>
                        <!-- TÊN MỤC -->    
                    </div>
                    <div id="right-head">
                        <a href="index.php?page=giohang"><img height="20px" src="images/giohang.png"></a>
                    </div>
                </div>
                <div id="right-center">             
                    <div class="tt-ctgh">
                            <ul>
                                <li class="sothutu"><p>STT</p></li>
                                <li class="tensp"><p>Tên sản phẩm</p></li>
                                <li class="sluong"><p>Số lượng</p></li>
                                <li class="gtien"><p>Giá tiền</p></li>
                                <li class="ttien"><p>Tổng tiền</p></li>
                                <li class="xoasp"><p>Xóa</p></li>
                            </ul>
                    </div>
                    <div class="cc-ctgh">
                            <?php 
                                if(!isset($_SESSION['username'])) {
                            ?>
                            <div class="yeucau">
                                Vui lòng đăng nhập để mua sản phẩm --!
                            </div>
                            <?php 
                                } else {
                            ?>
                            <form method = "post" name = "giohang">
                            <div class="dong-chitiet">
                                <ul>
                                    <li class="sothutu "><p>1</p></li>
                                    <li class="tensp "><p>VGA Asus 2GB GT730-2GD3</p></li>
                                    <li class="sluong " style="text-align:center;">
                                        <input type="text" name="quantity" value="2" style="width:30px; height:20px; margin-top:10px;">
                                    </li>
                                    <li class="gtien "><span>1.540.000 VNĐ</span></li>
                                    <li class="ttien "><span>1.540.000 VNĐ</span></li>
                                    <li class="xoasp " style="text-align:center;">
                                        <input type="checkbox" name="dIds[]" value="1" style="margin-top:10px;">
                                    </li>
                                </ul>
                            </div>
                            <div class="tongtientinh">
                                <ul>
                                    <li class="tttt"><p>Tổng tiền cần thanh toán:</p></li>
                                    <li class="cccc">
                                        <span>1.540.000 VNĐ</span>
                                        (Giá đã bao gồm VAT)<br>
                                        (Bằng chữ: Một triệu Năm trăm bốn mươi nghìn đồng)
                                    </li>
                                </ul>
                            </div>
                            <?php
                                }
                            ?>
                            <div class="nutnut">
                                <ul>
                                    <li class="l_in">
                                        <input type="submit" name="capnhat" value="Cập nhật"/>
                                    </li>                                    
                                    <li class="l_in">
                                        <input type="submit" name="tieptuc" value="Tiếp tục mua hàng"/>
                                    </li>
                                    <li class="r_in">
                                        <input type="submit" name="muahang" value="Thanh toán"/>
                                    </li>
                                    <li class="r_in">
                                        <input type="submit" name="huy" value="Hủy đơn hàng"/>
                                    </li>
                                </ul>
                            </div>
                        </form>
                    </div>
                </div>