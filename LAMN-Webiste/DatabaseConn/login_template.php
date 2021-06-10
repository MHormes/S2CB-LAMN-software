<?php
function loginAccount($usernameLogin, $passwordLogin)
{
    //include '../DatabaseConn/connection.php';
    require_once "../DatabaseConn/connection.php";
    try{
        //$conn = new PDO("mysql:host=studmysql01.fhict.local;dbname=dbi456806",$username, $password);
        $sql = 'SELECT * FROM logindetails WHERE Username = :username AND Password = :password';
        $sth = $conn->prepare($sql);

        $sth->execute(
            array(
                ':username' => $usernameLogin,
                ':password' => $passwordLogin
            )
        );
        $users = $sth->fetchAll();
        $count = $sth->rowCount();

        if ($count > 0) {
            $_SESSION['loggedin'] = TRUE;
            $_SESSION['Password'] = $_POST["password"];
            $_SESSION['Username'] = $_POST["username"];
            setcookie('loginMessage', "", 1);
            header('Location: personalSchedules.php');
        } 
        else {
            setcookie('loginMessage', "User not found");
            header('Location: index.php');
        }

    }catch(PDOException $e){
        return false;
    }
}