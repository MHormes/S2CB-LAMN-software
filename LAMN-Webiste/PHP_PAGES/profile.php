<?php
session_start();

require_once "../DatabaseConn/connection.php";

$username=$_SESSION['Username'];

$select_stmt =$conn->prepare("SELECT * FROM employee WHERE UserName=:uUsername");
$select_stmt->execute(array(':uUsername'=>$username));
$row=$select_stmt->fetch(PDO::FETCH_ASSOC);

$FirstName=$row["FirstName"];
$SecondName=$row["SecondName"];
$PhoneNumber=$row["PhoneNumber"];
$IceRelationship=$row["ICErelation"];
$IceRelationship=strtolower($IceRelationship);
$IceRelationship=ucfirst($IceRelationship);
$IceNumber=$row["ICEnumber"];
$BSN=$row["BSN"];
$Address=$row["Adress"];

$relationships=array("Partner", "Father", "Mother", "Brother", "Sister", "Uncle", "Aunt", "Cousin", "Friend", "Other");

if(isset($_REQUEST['btnRequestChanges']))
{
    
    $firstName = strip_tags($_REQUEST["first_name"]);
    $secondName=strip_tags($_REQUEST["last_name"]);
    $phoneNumber=strip_tags($_REQUEST["phone_number"]);
    $iceRelationship=$_POST['ICE_relationship'];
    $iceNumber=strip_tags($_REQUEST["ICE_number"]);
    $address=strip_tags($_REQUEST["address"]);

    if(empty($firstName))
    {
        $errorMsg[] = "Please enter first name";
    }
    if(empty($secondName))
    {
        $errorMsg[] = "Please enter last name";
    }
    if(empty($phoneNumber))
    {
        $errorMsg[] = "Please enter phone number";
    }
    if(empty($iceRelationship))
    {
        $errorMsg[] = "Please enter ICE relationship";
    }
    if(empty($iceNumber))
    {
        $errorMsg[] = "Please enter ICE number";
    }
    else if(strlen($phoneNumber)!=10)
    {
        $errorMsg[] = "Phone number must be 10 digits long";
    }
    else
    {
        try
        {
             
            if(!isset($errorMsg))
            {
                $select_stmt =$conn->prepare("SELECT * FROM employeechange WHERE UserName=:uUserName");
                $select_stmt->execute(array(':uUserName'=>$username));
                $row=$select_stmt->fetch(PDO::FETCH_ASSOC);

                if($select_stmt->rowCount()<1)
                {
                    $sql = "INSERT INTO employeechange (BSN, UserName, FirstName, SecondName, PhoneNumber, ICEnumber, ICErelation, Address) VALUES (:uBSN, :uUserName, :uFirstName, :uSecondName, :uPhoneNumber, :uICEnumber, :uICErelation, :uAddress)";
                    $stmt = $conn->prepare($sql);
                    $stmt->bindValue(':uBSN', $BSN);
                    $stmt->bindValue(':uUserName', $username);
                    $stmt->bindValue(':uFirstName', $firstName);
                    $stmt->bindValue(':uSecondName', $secondName);
                    $stmt->bindValue(':uPhoneNumber', $phoneNumber);
                    $stmt->bindValue(':uICEnumber', $iceNumber);
                    $stmt->bindValue(':uICErelation', $iceRelationship);
                    $stmt->bindValue(':uAddress', $address);
                
                    $result = $stmt->execute();
    
                    if($result){
                        echo 'Change requested successfully';
                        header("refresh:1; personalSchedules.php");
                    }
                }
                else
                {
                    $stmt = $conn->prepare("UPDATE employeechange SET FirstName=:uFirstName, SecondName=:uSecondName, PhoneNumber=:uPhoneNumber, ICEnumber=:uICEnumber, ICErelation=:uICErelation, Address=:uAddress WHERE UserName=:uUserName");
                    //$stmt->bindValue(':uBSN', $BSN);
                    $stmt->bindValue(':uUserName', $username);
                    $stmt->bindValue(':uFirstName', $firstName);
                    $stmt->bindValue(':uSecondName', $secondName);
                    $stmt->bindValue(':uPhoneNumber', $phoneNumber);
                    $stmt->bindValue(':uICEnumber', $iceNumber);
                    $stmt->bindValue(':uICErelation', $iceRelationship);
                    $stmt->bindValue(':uAddress', $address);
                
                    $result = $stmt->execute();
    
                    if($result){
                        echo 'Change requested successfully';
                        header("refresh:1; personalSchedules.php");
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

if(isset($_REQUEST['btnChangePassword']))
{
    header("location: changePassword.php");
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



         <!-- User profile -->
         <form method="post">
        <div class="profile">
            <div class="heading"><h1>Change info</h1></div><br><br>

            <label>First name</label>
            <input id="first_name" placeholder="" value="<?php echo $FirstName ?>" type="text" name ="first_name" >
            <label>Last name</label>
            <input id="last_name" placeholder="" value="<?php echo $SecondName ?>" type="text" name ="last_name" >
            <label>Phone number</label>
            <input id="phone_number" placeholder="" type="text" value="<?php echo $PhoneNumber?>" name ="phone_number">
            <label>ICE relationship</label>

            <select name="ICE_relationship" id="ICE_relationship">
            <option value=<?php echo $IceRelationship ?>><?php echo $IceRelationship ?></option>
            <?php
                foreach($relationships as $value)
                {
                    if ($value!=$IceRelationship)
                    {
                        ?><option value=<?php echo $value?>><?php echo $value?></option><?php                    
                    }
                }
            ?>
            </select>

            <label>ICE number</label>
            <input id="ICE_number" placeholder="" type="text" value="<?php echo $IceNumber ?>" name ="ICE_number">
            <label>Address</label>
            <input id="address" placeholder="" type="text" value="<?php echo $Address ?>" name ="address">
            <button type="submit" name="btnRequestChanges" class="btnRequestChanges">Request changes</button>
            <button type="submit" name="btnChangePassword" class="btnChangePassword">Change password</button>
        </div>
    </form>


    
    

    
    </body>