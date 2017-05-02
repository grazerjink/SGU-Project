<?php 
    ob_start();
?>
<link rel="stylesheet" type="text/css" href="css/admin.css"/>
<div id="header">
    <div id="home">
        <a href="index.php"><img height="35px" width="35px" src="images/home.png"/></a>
    </div>
    <!-- QUICKSEARCH FORM -->
    <div id="quicksearch">
        
        <!-- SEARCH THÔNG THƯỜNG -->
        <div id="search-1">
            <form method="POST" action="index.php?page=timkiem" style=" float:left; margin-top:4px;">
                    <input name="tensp" style="width:350px; height:30px; border-radius:2px; border:0px; padding-left:4px;" type="text" placeholder="Tìm kiếm tại đây...">
                    <button name="timkiem" id="search-button"><img src="images/search.png"/></button>
            </form>
        </div>
        <!-- HẾT SEARCH THÔNG THƯỜNG -->
        
        <!-- SEARCH NÂNG CAO-->
        <!-- <div id="search-2">
            <ul>
                <li>
                    <button id="search-button2" onclick="openlist()">Tìm kiếm nâng cao</button>
                </li>
                <li style="list-style:none;">
                    <div id="submenu" style="display:none;">
                        <form action="index.php?page=timkiem" method="post">
                            <table cellspacing="8px">
                                <tr>
                                    <td class="head">Danh mục</td>
                                    <td>
                                        <select class="contain">
                                            <option>RAM</option>
                                            <option>CPU</option>
                                            <option>VGA</option>
                                            <option>USB</option>
                                            <option>Tai nghe</option>
                                            <option>Loa máy tính</option>
                                        </select>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="head">Giá từ</td>
                                    <td><input class="contain" type="text"/></td>
                                </tr>
                                <tr>
                                    <td class="head">Giá đích</td>
                                    <td><input class="contain" type="text"/></td>
                                </tr>
                                <tr>
                                    <td colspan="2" align="center"><input id="search-button3" type="submit" value="Tìm kiếm"/></td>
                                </tr>
                            </table>
                        </form>
                    </div>
                </li>
            </ul>
        </div> -->
        <!-- HẾT SEARCH NÂNG CAO-->
        
    </div>
    <!-- END QUICK SEARCH FORM -->
    <!-- LOGIN FORM -->
    <?php
        if($_SESSION["username"]) {
            include("modules/success.php");
        } else {
            include("modules/login.php");
        }
    ?>
    <!-- END LOGIN FORM -->
</div>