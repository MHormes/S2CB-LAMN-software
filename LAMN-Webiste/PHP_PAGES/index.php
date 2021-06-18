<?php
session_start();
include '../DatabaseConn/login_template.php';

if(isset($_POST['btnLogin']))
{
    loginAccount($_POST['username'], $_POST['password']);
    exit;
}
?>
<!DOCTYPE html>
<html>
    <head>
        <meta charset="utf-8">
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <meta name="description" content="MediaBazaar Website">
        <title>Media Bazaar Employee Portal</title>
        <link rel="stylesheet" type="text/css" href="../CSS_FILES/login.css">
    </head>
    <body>
        <div class="css-selector">
        <!-- contact form -->
        <div class="logo">
            <img src="../IMG/MB-logo.png" alt="">
        </div>  
        
        <section class="login-form">
                <h2>Employee Portal</h2>
                
                <br><br>
                <div class="center">

                <form method="post" action="#" class="login-form">
                    <!-- inserting username, password -->
                    <div class="row">
                        <!-- <label for="username">Username</label> -->
                        <input type="text" name="username" id="username" placeholder="Enter username" required>
                    </div><br>
                    <div class="row">
                        <!-- <label for="pwd">Password</label> -->
                        <input type="password" name="password" id="password" placeholder="Enter password" required>
                    </div><br>
                    <div class="row">
                        <input type="submit" class="button" value="Login" name="btnLogin">
                    </div>
                </form>

                </div>
                <?php
                if(isset($_COOKIE["loginMessage"])){
                    echo $_COOKIE["loginMessage"];
                }
                ?>
        </section>
        </div>
    </body>
</html>
