<?php
    ob_start(); 
?>
<div id="right-top">
                    <div id="left-head">
                        <b><a style="text-decoration:none; color:black;" href="index.php">TRANG CHỦ</a></b>
                        <img src="images/arrow2.png"/>
                        <b><span style="font-size:18px; color:#3875c6;">ĐĂNG KÝ THÀNH VIÊN</span></b>
                        <!-- TÊN MỤC -->    
                    </div>
                    <div id="right-head">
                        <a href="index.php?page=giohang"><img height="20px" src="images/giohang.png"></a>
                    </div>
                </div>
                <div id="right-center">
                    <?php 
                        $username = $_POST["username"];
                        $password = $_POST["password"];
                        $email = $_POST["email"];
                        $cauhoi = $_POST["cauhoi"];
                        $traloi = $_POST["traloi"];
                        $tenhienthi = $_POST["tenhienthi"];
                        $diachi = $_POST["diachi"];
                        $sdt = $_POST["sdt"];
                        
                        $info = array("username"=>$username, "password"=>$password, "email"=>$email,
                                       "cauhoi" =>$cauhoi,"traloi" => $traloi, "tenhienthi" => $tenhienthi, "diachi"=>$diachi, "sdt"=>$sdt);
                        if($_SESSION['username']) {
                            header("Location: index.php");
                        }
                        else if(!$_SESSION['username'] && isset($_POST["submit"])) {
                            register($info);    
                        }    
                    ?> 
                    <form name="myform" method="post" onsubmit="return checkinput();">
                        <table cellspacing="20px">
                            <tr>
                                <td colspan="2" align="center"><h4><i>* Vui lòng điền đầy đủ thông tin để hoàn tất đăng ký *</h4></td>
                            </tr>
                            <tr>
                                <td class="text">Tên đăng nhập: <span>*</span></td>
                                <td><input type="text" placeholder="Từ 8 đến 12 ký tự" class="text" name="username" style="font-size:12px;" /></td>
                            </tr>
                            <tr>
                                <td class="text">Mật khẩu: <span>*</span></td>
                                <td><input type="password" name="password" class="text" /></td>
                            </tr>
                            <tr>
                                <td class="text">Xác nhận mật khẩu: <span>*</span></td>
                                <td><input type="password" name="password1" class="text" /></td>
                            </tr>
                            <tr>
                                <td class="text">Email: <span>*</span></td>
                                <td><input type="email" name="email" class="text" /></td>
                            </tr>
                            <tr>
                                <td class="text">Câu hỏi bảo mật: <span>*</span></td>
                                <td>
                                    <select class="text" name="cauhoi" style="font-size:12px;">
                                        <option>Nơi sinh của bạn ?</option>
                                        <option>Con vật bạn yêu thích ?</option>
                                        <option>Con vật bạn ghét nhất ?</option>
                                        <option>Tên trường THPT của bạn ?</option>
                                        <option>Ca sĩ bạn thần tượng là ai ?</option>
                                        <option>Tên ba của bạn là gì ?</option>
                                        <option>Tên mẹ của bạn là gì ?</option>
                                        <option>Người mà bạn yêu quí nhất là ai ?</option>
                                    </select>
                                </td>
                            </tr>
                            <tr>
                                <td class="text">Trả lời: <span>*</span></td>
                                <td><input type="password" class="text" name="traloi"/></td>
                            </tr>
                            <tr>
                                <td class="text">Tên hiển thị:</td>
                                <td><input type="text" name="tenhienthi" class="text" /></td>
                            </tr>
                            <tr>
                                <td class="text">Địa chỉ:</td>
                                <td><input type="text" name="diachi" class="text" /></td>
                            </tr>
                            <tr>
                                <td class="text">Số điện thoại:</td>
                                <td><input type="text" name="sdt" class="text" /></td>
                            </tr>
                            <tr>
                                <td colspan="2" align="center">
                                    <input type="submit" name ="submit" class="submit" value="Đăng ký">
                                    <input type="reset" class="submit" value="Làm lại">
                                </td>
                            </tr>
                        </table>
                    </form>
                </div>