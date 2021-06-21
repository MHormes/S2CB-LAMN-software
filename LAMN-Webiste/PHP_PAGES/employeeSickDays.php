<?php
session_start();
include "../DatabaseConn/sickdays_template.php";

$user = $_SESSION['Username'];
$empBSN = getBSN($user);

if (isset($_POST['btnSubmitsickday'])) {
    
        addSickDay($empBSN, $_POST['day'], 'Yes');
}
if (isset($_POST['btnRemovesickday'])) {
   

        removeSickday($empBSN);
    
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
    <link rel="stylesheet" type="text/css" href="../CSS_FILES/sickday.css">

</head>

<body>
    <div class="header">Personal Schedules</div>

    <?php include '../navigationBar.php'; ?>

    <section class="employeeHolidays-form">
        <div class="row">
            <h2>Sick Days</h2>
        </div>

        <div class="row">
            <form method="post" action="#" class="contact-form">
            </br> 
                    <div class="row">
                       
                        <input type="text" name="day" id="day" placeholder="Enter day" >
                    </div><br>
                    
                    <div class="row">
                        <input type="submit" class="button" value="Submit" name="btnSubmitsickday">
                    </div>
                    <div class="row">
                        <input type="submit" class="button" value="Remove " name="btnRemovesickday">
                    </div>
          

        </div> 
    </section>


</body>