<?php
session_start();
function loginAccount()
{
    //include '../DatabaseConn/connection.php';
    require_once "../DatabaseConn/connection.php";
    try{
        //$conn = new PDO("mysql:host=studmysql01.fhict.local;dbname=dbi456806",$username, $password);
        $sql = 'SELECT * FROM logindetails WHERE Username = :username AND Password = :password';
        $sth = $conn->prepare($sql);

        $sth->execute(
            array(
                ':username' => $_POST["username"],
                ':password' => $_POST["password"]
            )
        );
        $users = $sth->fetchAll();
        $count = $sth->rowCount();

        if ($count > 0) {
            $_SESSION['loggedin'] = TRUE;
            $_SESSION['Password'] = $_POST["password"];
            $_SESSION['Username'] = $_POST["username"];
            setcookie('loginMessage', "", 1);
            header('Location: schedules.php');
        } 
        else {
            setcookie('loginMessage', "User not found");
            header('Location: index.php');
        }

    }catch(PDOException $e){
        echo $e->getMessage();
    }
}

if(isset($_POST['btnLogin']))
{
    loginAccount();
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
                        <input type="submit" value="Login" name="btnLogin">
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
