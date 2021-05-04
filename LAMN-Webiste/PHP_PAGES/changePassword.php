<?php
session_start();

require_once "../DatabaseConn/connection.php";

    $username=$_SESSION['Username'];

    if(isset($_REQUEST['btnCancel']))
    {
        header("refresh:1; profile.php");
    }

    if(isset($_REQUEST['btnSavePassword']))
    {

        $OldPassword = strip_tags($_REQUEST['txtOldPassword']);
        $NewPassword = strip_tags($_REQUEST['txtNewPassword']);
        $NewPasswordRepeat = strip_tags($_REQUEST['txtNewPasswordAgain']);

        if(empty($OldPassword)){
            $errorMsg[] = "Please enter old password";
        }
        else if(empty($NewPassword)){
            $errorMsg[] = "Please enter new password";
        }
        else if(empty($NewPasswordRepeat)){
            $errorMsg[] = "Please enter new password again";
        }
        else if (strlen($NewPassword)<6){
            $errorMsg[] = "Password must be at least 8 characters";
        }
        else if ($NewPassword!=$NewPasswordRepeat){
            $errorMsg[] = "Passwords do not match. Please enter again.";
        }
        else
        {
            try
            {
                if(!isset($errorMsg))
                {
                    $select_stmt =$conn->prepare("SELECT * FROM logindetails WHERE Username=:uUsername");
                    $select_stmt->execute(array(':uUsername'=>$username));
                    $row=$select_stmt->fetch(PDO::FETCH_ASSOC);

                    if($select_stmt->rowCount()>0)
                    {
                        if($OldPassword == $row["Password"])
                        {

                            $stmt = $conn->prepare("UPDATE logindetails SET Password=:new_password WHERE Username=:uUsername");
                            $stmt->bindValue(':new_password', $NewPassword);
                            $stmt->bindValue(':uUsername', $username);
                            $result = $stmt->execute();
        
                            if($result)
                            {
                                echo 'Password changed succesfully';
                                header("refresh:1; profile.php");
                            }
                        }
                        else{
                            $errorMsg[] = "Old password is incorrect";
                        }
                    }
                }
            }

            catch(PDOException $e)
            {
                $e->getMessage();
            }
        }
    }
?>

<?php
if(isset($errorMsg)){
    foreach($errorMsg as $error)
    {
        ?>
    <div class="alert alert-danger">
        <?php echo "<script>alert('$error');</script>"; ?>
    </div>
    <?php
    }
}

?>




<!DOCTYPE html>
<html>
    <head>
        <meta charset="utf-8">
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <meta name="description" content="MediaBazaar Website">
        <title>Media Bazaar Employee Portal</title>
        <link rel="stylesheet" type="text/css" href="../CSS_FILES/login_old.css">
        <link rel="stylesheet" type="text/css" href="../CSS_FILES/profile.css">

    </head>
    <body>
    <div class="header">Schedules</div>



    <!-- Change passwor form -->
    <br><br>
    <form method="post">
        <div class="profile">
            <div class="heading"><h1>Change password</h1></div><br><br>
            <label>Old password</label>
            <input id="OldPassword" placeholder="Input old password..."  type="password" name ="txtOldPassword">
            <label>New password</label>
            <input id="NewPassword" placeholder="Input new password..."  type="password" name ="txtNewPassword">
            <label>New password again</label>
            <input id="NewPasswordAgain" placeholder="Input new password again..." type="password"  name ="txtNewPasswordAgain">
            <button type="submit" name="btnSavePassword" class="btnSavePassword">Save</button>
            <button type="submit" name="btnCancel" class="btnCancel">Cancel</button>
        </div>
    </form>


    
    

    
    </body>
