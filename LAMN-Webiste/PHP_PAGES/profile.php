<?php
session_start();

// require_once "../DatabaseConn/connection.php";
include_once "../DatabaseConn/profile_template.php";

$user = $_SESSION['Username'];
$row=GetUserInfo($user);

$FirstName = $row["FirstName"];
$SecondName = $row["SecondName"];
$PhoneNumber = $row["PhoneNumber"];
$IceRelationship = $row["ICErelation"];
$IceRelationship = strtolower($IceRelationship);
$IceRelationship = ucfirst($IceRelationship);
$IceNumber = $row["ICEnumber"];
$BSN = $row["BSN"];
$Address = $row["Adress"];

$relationships = array("Partner", "Father", "Mother", "Brother", "Sister", "Uncle", "Aunt", "Cousin", "Friend", "Other");


if (isset($_REQUEST['btnRequestChanges'])) {

    include_once "../DatabaseConn/profile_template.php";

    $firstName = strip_tags($_REQUEST["first_name"]);
    $secondName = strip_tags($_REQUEST["last_name"]);
    $phoneNumber = strip_tags($_REQUEST["phone_number"]);
    $iceRelationship = $_POST['ICE_relationship'];
    $iceNumber = strip_tags($_REQUEST["ICE_number"]);
    $address = strip_tags($_REQUEST["address"]);
    $user = $_SESSION['Username'];

    $result = RequestChangeOfInfo($BSN, $user, $firstName, $secondName, $phoneNumber, $iceRelationship, $iceNumber, $address);

    if ($result == null)
    {
        echo 'Seccusfully changed';
        header("refresh:0; personalSchedules.php");    }
    else{
        if(isset($result)){
            foreach($result as $error)
            {
            ?>
                <div class="alert alert-danger">
                <?php echo "<script>alert('$error');</script>"; ?>
            </div>
            <?php
            }
        }
    }
}

if (isset($_REQUEST['btnChangePassword'])) {
    header("location: changePassword.php");
}
?>




<!DOCTYPE html>
<html>

<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta name="description" content="MediaBazaar Website">
    <title>Media Bazaar Employee Portal</title>
    <link rel="stylesheet" type="text/css" href="../CSS_FILES/main.css">
    <link rel="stylesheet" type="text/css" href="../CSS_FILES/profile.css">
    <!-- <script src="<https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js>"></script>  -->
</head>

<body>
    <div class="header">Profile</div>

    <?php include '../navigationBar.php'; ?>

    <!-- User profile -->
    <form method="post">
        <div class="profile">
            <div class="heading">
                <h1>Change info</h1>
            </div><br><br>

            <label>First name</label>
            <input id="first_name" placeholder="" value="<?php echo $FirstName ?>" type="text" name="first_name">
            <label>Last name</label>
            <input id="last_name" placeholder="" value="<?php echo $SecondName ?>" type="text" name="last_name">
            <label>Phone number</label>
            <input id="phone_number" placeholder="" type="text" value="<?php echo $PhoneNumber ?>" name="phone_number">
            <label>ICE relationship</label>

            <select name="ICE_relationship" id="ICE_relationship">
                <option value=<?php echo $IceRelationship ?>><?php echo $IceRelationship ?></option>
                <?php
                foreach ($relationships as $value) {
                    if ($value != $IceRelationship) {
                ?><option value=<?php echo $value ?>><?php echo $value ?></option><?php
                    }
                }
                ?>
            </select>

            <label>ICE number</label>
            <input id="ICE_number" placeholder="" type="text" value="<?php echo $IceNumber ?>" name="ICE_number">
            <label>Address</label>
            <input id="address" placeholder="" type="text" value="<?php echo $Address ?>" name="address">
            <button type="submit" name="btnRequestChanges" class="btnRequestChanges">Request changes</button>
            <button type="submit" name="btnChangePassword" class="btnChangePassword">Change password</button>
        </div>
    </form>

    <?php
    include_once "../DatabaseConn/profile_template.php";
    $user = $_SESSION['Username'];
    $message = GetMessage($user);
    if($message != null)
    {?>
        <div class='modal' id='modal'>
            <div class='content'>
                <span class="close" id='close'>&times;</span>
                <div class="popUpText">
                    <h1>Your request has been declined</h1>
                    <h2>Reason of decline:</h2>
                    <p><?php echo $message["Message"] ?></p>
                </div>
            </div>
        </div>  
        <?php
    }
    ?>


<script src="../script.js"></script> 


</body>
</html>