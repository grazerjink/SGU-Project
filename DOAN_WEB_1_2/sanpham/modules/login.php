<div id="log">
        <ul>
            <li><button onclick="loginbox()" class="login">Đăng nhập</button></li>
            <li>
                <div id="formmenu" style="display:none;">
                    <?php 
                        error_reporting(E_ALL ^ (E_NOTICE | E_WARNING));  
                        logIn($_POST['username'], $_POST['password'], $_POST['login']);
                    ?>
                    <form method="post"/>
                        <table cellspacing="15px">
                            <tr>
                                <td colspan="2">
                                    <input type="text" name="username" class="textbox" placeholder="Tên đăng nhập"/>
                                    <img id="icon" src="images/login.png"/>
                                </td>
                            </tr>
                            <tr>
                                <td colspan="2">
                                    <input type="password" name="password" class="textbox" placeholder="Mật khẩu"/>
                                    <img id="icon2" src="images/password.png"/>
                                </td>
                            </tr>
                            <tr>
                                <td><input type="submit" name="login" id="logbutton" value="Đăng nhập"></td>
                                <td><a href="index.php?page=dangky" style="color:blue;">Đăng ký ?</a></td>
                            </tr>
                        </table>
                    </form>
                </div>
            </li>
        </ul>
    </div>