<?php
    ob_start();
    include("function.php");
    error_reporting(E_ALL ^ (E_NOTICE | E_WARNING));
?>
<html>
    <head>
        <link rel="shortcut icon" href="images/computer.ico" type="image/x-icon" />
        <link rel="stylesheet" type="text/css" href="css/style.css"/>
        <link rel="stylesheet" type="text/css" href="css/admin.css"/>
        <link rel="stylesheet" type="text/css" href="css/product.css"/>
        <link rel="stylesheet" type="text/css" href="css/admin-product.css"/>
        <link rel="stylesheet" type="text/css" href="css/thongke.css"/>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8"/>
        <title>Linh phụ kiện máy tính</title>
        <?php 
            include("js/script.php");
        ?>
    </head> 
    <body>
        <?php 
            include("modules/admin-header.php");
        ?>
        <div id="main">
            <?php 
                include("modules/admin-mainleft.php");
            ?>
            <div id="main-right">
                <?php
                    $data = array("tensp"=>$_POST['tensp'],"loaisp"=>$_POST['loaisp'],"soluong"=>$_POST['soluong'],
                                         "giasp"=>$_POST['giasp'],"thongso"=>$_POST['thongso'],"link"=>"link/".$_FILES['link']['name']);
                    if(isset($_POST['submit'])) {
                        if($_FILES["link"]['type'] != "image/jpeg" && $_FILES["link"]['type'] != "image/png") {
                            echo "<script>
                                    alert(\"Chỉ cho phép upload ảnh đuôi .jpg, .jpeg, .png !\")
                                    </script>";
                        } else if($_FILES["link"]['size'] > 3*1024*1024) {
                            echo "<script>
                                    alert(\"Chỉ cho phép upload ảnh có dung lượng nhỏ hơn 3MB !\")
                                    </script>";
                        } else {
                            move_uploaded_file($_FILES['link']['tmp_name'],"link/".$_FILES['link']['name']);
                            insertData($data);
                        }
                    }
                
                    if(isset($_POST['xoa'])) {
                        if(!isset($_REQUEST['checkbox'])) {
                            echo "<script>
                                    alert(\"Xin vui lòng chọn đối tượng muốn thực thi !\")
                                    </script>";
                        } else {
                            $masp = $_REQUEST['checkbox'];
                            deleteProducts($masp);
                        }
                    }
                    
                    if(isset($_POST['xoathanhvien'])) {
                        if(!isset($_REQUEST['id'])) {
                            echo "<script>
                                    alert(\"Xin vui lòng chọn đối tượng muốn thực thi !\")
                                    </script>";
                        } else {
                            $id = $_REQUEST['id'];
                            deleteMembers($id); 
                        }
                    }
                
                    if(isset($_POST['khoathanhvien'])) {
                        if(!isset($_REQUEST['id'])) {
                            echo "<script>
                                    alert(\"Xin vui lòng chọn đối tượng muốn thực thi !\")
                                    </script>";
                        } else {
                            $id = $_REQUEST['id'];
                            bannId($id); 
                        }
                    }
                
                
                        switch($_GET["page"]) {
                            case 'cpu' : include_once('modules/admin-cpu.php');
                            break;

                            case 'ram' : include_once('modules/admin-ram.php');
                            break;

                            case 'vga': include_once('modules/admin-vga.php');
                            break;

                            case 'usb' : include_once('modules/admin-usb.php');
                            break;

                            case 'speaker' : include_once('modules/admin-speaker.php');
                            break;

                            case 'headphone' : include_once('modules/admin-headphone.php');
                            break;
                            
                            case 'thanhvien' : include_once('modules/admin-thanhvien.php');
                            break;
                            
                            case 'thongke' : include_once('modules/admin-thongke.php');
                            break;
                        
                            case 'bangthongke' : include_once('modules/admin-bangthongke.php');
                            break;
                                
                            case 'donhang' : include_once('modules/admin-donhang.php');
                            break;
                                
                            case 'suasanpham' : include_once('modules/admin-sua-san-pham.php');
                            break;
                                
                            case 'xoasanpham' : include_once('modules/xoasanpham.php');
                            break;
                                
                            case 'xoathanhvien' : include_once('modules/xoathanhvien.php');
                            break;
                                
                            case 'khoathanhvien' : include_once('modules/khoathanhvien.php');
                            break;
                                
                            case 'mokhoathanhvien' : include_once('modules/mokhoathanhvien.php');
                            break;
                                
                            default : include_once('modules/admin-sanpham.php');
                        }
                    ?>
            </div>
        </div>
        <?php 
            include("modules/footer.php");
        ?>
    </body>
</html>