<?php
// session_start();
// function loginAccount()
// {
//     include '../includes/connection_template.php';
//     try{
//         $conn = new PDO("mysql:host=studmysql01.fhict.local;dbname=dbi459847",$username, $password);
//         $sql = 'SELECT * FROM user WHERE Username = :username AND Password = :password';
//         $sth = $conn->prepare($sql);

//         $sth->execute(
//             array(
//                 ':username' => $_POST["username"],
//                 ':password' => $_POST["password"]
//             )
//         );
//         $users = $sth->fetchAll();
//         $count = $sth->rowCount();

//         if ($count > 0) {
//             $_SESSION['loggedin'] = TRUE;
//             $_SESSION['Password'] = $_POST["password"];
//             $_SESSION['Username'] = $_POST["username"];
//             $message = null;
//             header('Location: mypage.php');
//         } 
//         else {
//             $message = "User not found";
//         }

//     }catch(PDOException $e){
//         echo $e->getMessage();
//     }
// }

// if(isset($_POST['btnLogin']))
// {
//     loginAccount();
//     exit;
// }
?>
<!DOCTYPE html>
<html>
    <head>
        <meta charset="utf-8">
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <meta name="description" content="MediaBazaar Website">
        <title>AM Fitness</title>
        <link rel="stylesheet" type="text/css" href="../LAMN-Website/CSS_FILES/login.css">
    </head>
    <body>
        <!-- contact form -->
        <section class="login-form">
            <div class="row">
                <h2>Login</h2>
            </div>
            <div class="row">
                <form method="post" action="#" class="login-form">
                    <!-- inserting username, password -->
                    <div class="row">
                        <label for="username">Username</label>
                        <input type="text" name="username" id="username" placeholder="Enter username" required>
                    </div>
                    <div class="row">
                        <label for="pwd">Password</label>
                        <input type="password" name="password" id="password" placeholder="Enter password" required>
                    </div>
                    <div class="row">
                        <input type="submit" value="Login" name="btnLogin">
                    </div>
                </form>
            </div>
        </section>
    </body>
</html>
