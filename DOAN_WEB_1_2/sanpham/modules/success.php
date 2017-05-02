<div id="quantri">
    <img src="images/login.png"/>
    <div id="username">
        <?php 
            if(isset($_POST["thoat"])) {
                unset($_SESSION['username']);
                header("Location: index.php");
            }
        ?>
        <form method="post">
            <span><?php echo "Chào, ".$_SESSION['username'];?></span>
            <input type="submit" name="thoat" style="margin-left:4px;" value = "Thoát" />
        </form>
    </div>
</div>
