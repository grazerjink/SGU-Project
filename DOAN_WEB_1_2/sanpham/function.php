<?php
    session_start();
    function logIn($user, $pass, $submit) {
        $dbc = mysqli_connect('localhost','root', '', 'sanpham');
        mysqli_set_charset($dbc, 'utf8');
        $username = $user;
        $password = $pass;
        $sql = "select * from members where username='".$username."' and password ='".$password."'";
        $result = mysqli_query($dbc, $sql);
        $num_rows = mysqli_num_rows($result);
        if(isset($submit)) {
            if($num_rows > 0) {
                while($rows = mysqli_fetch_assoc($result)) {
                    $_SESSION['username'] = $username;
                    if($rows['state'] == 1) {
                        echo "<script>location.reload(); alert(\"Đăng nhập thành công !\")</script>";
                    } else if ($rows['state'] == 2) {
                        header("Location:admin.php");
                    } else if ($rows['state'] == 3) {
                        echo "<script>location.reload(); alert(\"Tài khoản của bạn bị khóa vì vi phạm!\")</script>";
                    }
                }
            } else {
                echo "<script>
                        alert(\"Đăng nhập thất bại !\")</script>";
            }
        }
    }
    
    function register($array) {
        $dbc = mysqli_connect('localhost','root', '', 'sanpham');
        mysqli_set_charset($dbc, 'utf8');
        $sql = "insert into members(username,password,email,cauhoi,traloi,tenhienthi,diachi,sdt)
                values('".$array['username']."','".$array['password']."','".$array['email']."','"
                .$array['cauhoi']."','".$array['traloi']."','".$array['tenhienthi']."','".$array['diachi']."','".$array['sdt']."')"; 
        $result = mysqli_query($dbc, $sql) or die('<script>alert(\"Lỗi truy vấn, kiểm tra lại !\")</script>');  
        if(mysqli_affected_rows($dbc) == 1) {
            echo "<script>
                        alert(\"Đăng ký thành công !\")
                    </script>";
        } else {
            echo "<script>
                        alert(\"Đăng ký không thành công !\")
                    </script>";
        }
    }
    
    function insertData($array) {
        $dbc = mysqli_connect('localhost','root', '', 'sanpham');
        mysqli_set_charset($dbc, 'utf8');
        $sql = "insert into products(tensp,loaisp,soluong,giasp,thongso,link)
                values('".$array['tensp']."','".$array['loaisp']."','".$array['soluong']."','"
                .$array['giasp']."','".$array['thongso']."','".$array['link']."')"; 
        $result = mysqli_query($dbc, $sql) or die('<script>alert(\"Lỗi truy vấn, kiểm tra lại !\")</script>');  
        if(mysqli_affected_rows($dbc) == 1) {
            echo "<script>
                        alert(\"Đã thêm sản phẩm thành công !\")
                    </script>";
        } else {
            echo "<script>
                        alert(\"Thêm sản phẩm không thành công !\")
                    </script>";
        }
    }

    function deleteProducts($masp) {
        $dbc = mysqli_connect('localhost','root', '', 'sanpham');
        mysqli_set_charset($dbc, 'utf8');
        $sql = "delete from products WHERE masp= $masp";
        $result = mysqli_query($dbc, $sql);
    } 
    
    function deleteMembers($id) {
        $dbc = mysqli_connect('localhost','root', '', 'sanpham');
        mysqli_set_charset($dbc, 'utf8');
        $sql = "delete from members WHERE id='$id'";
        $result = mysqli_query($dbc, $sql);  
        header("Location:admin.php?page=thanhvien");  
    }

    function bannId($id) {
        $dbc = mysqli_connect('localhost','root', '', 'sanpham');
        mysqli_set_charset($dbc, 'utf8');
        $sql = "UPDATE members SET state = '3' WHERE id = '$id'";
        $result = mysqli_query($dbc, $sql);
    }

    function unBannId($id) {
        $dbc = mysqli_connect('localhost','root', '', 'sanpham');
        mysqli_set_charset($dbc, 'utf8');
        $sql = "UPDATE members SET state = '1' WHERE id = '$id'";
        $result = mysqli_query($dbc, $sql);  
    }

    function editProducts($array) {
        $dbc = mysqli_connect('localhost','root', '', 'sanpham');
        mysqli_set_charset($dbc, 'utf8');
        $sql = "update products set tensp='".$array['tensp']."',loaisp='".$array['loaisp']."',soluong ='".$array['soluong']."',giasp                                        ='".$array['giasp']."',thongso ='".$array['thongso']."' WHERE masp='".$array['masp']."'";
        $result = mysqli_query($dbc, $sql);
    }

    function getPage(){
        if(!$_GET['page']) {
            $page=1;
        } else {
            $page= $_GET['page'];
        }

        //Hien thi toi da so luong san pham
        $max_result = 12;
        //Tinh vi tri san pham trong csdl
        $index_row= $page*$max_result - $max_result;
        //Liet ke du lieu
        $sql = "select * from sanpham limit $index_row, $max_result";
        $result = mysqli_query($dbc,$sql);
    }
?>