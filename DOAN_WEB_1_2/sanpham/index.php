<?php
    ob_start();
    include("function.php");
    error_reporting(E_ALL ^ (E_NOTICE | E_WARNING));
    if($_SESSION['username'] == 'admin') {
        header("Location:admin.php");
    }
?>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8"/>
        <link rel="shortcut icon" href="images/computer.ico" type="image/x-icon" />
        <link rel="stylesheet" type="text/css" href="css/style.css"/>
        <link rel="stylesheet" type="text/css" href="css/product.css"/>
        <link rel="stylesheet" type="text/css" href="css/dangky.css"/>
        <link rel="stylesheet" type="text/css" href="css/giohang.css"/>
        <title>Linh phụ kiện máy tính</title>
        <?php
            include("js/script.php");
        ?>
    </head> 
    <body>
        <!-- BANNER -->
        <?php
            include("modules/banner.php");
        ?>
        <!-- END BANNER -->
            
        <!-- HEADER -->
        <?php
            include("modules/header.php");
        ?>
        <!-- END HEADER -->
        
        <div id="main">
            <!-- MAIN LEFT -->
            <?php
                include("modules/mainleft.php");
            ?>
            <!-- END MAIN LEFT -->
            
            <!-- MAIN RIGHT -->
            <div id="main-right">
                    <!-- PRODUCTS -->
                    <?php
                        switch($_GET["page"]) {
                            case 'cpu' : include_once('modules/cpu.php');
                            break;

                            case 'ram' : include_once('modules/ram.php');
                            break;

                            case 'vga': include_once('modules/card-man-hinh.php');
                            break;

                            case 'usb' : include_once('modules/usb.php');
                            break;

                            case 'speaker' : include_once('modules/loa-may-tinh.php');
                            break;

                            case 'headphone' : include_once('modules/tai-nghe.php');
                            break;
                            
                            case 'timkiem' : include_once('modules/ketqua.php');
                            break;
                            
                            case 'dangky' : include_once('modules/dangky.php');
                            break;
                            
                            case 'giohang' : include_once('modules/giohang.php');
                            break;
                                
                            default : include_once('modules/sanpham.php');
                        }
                
                        include("modules/phantrang.php");
                    ?>

        </div>
        <!-- END MAIN RIGHT -->
        <!-- FOOTER -->
        <?php
            include("modules/footer.php");
        ?>
        <!-- END FOOTER -->
    </body>
</html>