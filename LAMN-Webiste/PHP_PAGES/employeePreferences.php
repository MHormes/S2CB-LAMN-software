<?php
session_start();
include "../DatabaseConn/preferences_template.php";

$user = $_SESSION['Username'];
$empBSN = getBSN($user);

$shifts = getShifts($empBSN);

if (isset($_POST['btnSave'])) {
    $isPresent = preferencesPresent($empBSN);

    if ($isPresent == true) {
        removePreferences($empBSN);
    }

    addPreference('MONDAY', $empBSN, $_POST['mondayShifts1']);
    addPreference('MONDAY', $empBSN, $_POST['mondayShifts2']);
    addPreference('TUESDAY',  $empBSN, $_POST['tuesdayShifts1']);
    addPreference('TUESDAY',  $empBSN, $_POST['tuesdayShifts2']);
    addPreference('WEDNESDAY',  $empBSN, $_POST['wednesdayShifts1']);
    addPreference('WEDNESDAY',  $empBSN, $_POST['wednesdayShifts2']);
    addPreference('THURSDAY',  $empBSN, $_POST['thursdayShifts1']);
    addPreference('THURSDAY',  $empBSN, $_POST['thursdayShifts2']);
    addPreference('FRIDAY',  $empBSN, $_POST['fridayShifts1']);
    addPreference('FRIDAY',  $empBSN, $_POST['fridayShifts2']);
    addPreference('SATURDAY',  $empBSN, $_POST['saturdayShifts1']);
    addPreference('SATURDAY',  $empBSN, $_POST['saturdayShifts2']);
    addPreference('SUNDAY',  $empBSN, $_POST['sundayShifts1']);
    addPreference('SUNDAY',  $empBSN, $_POST['sundayShifts2']);
}

if (isset($_POST['btnDelete'])) {
    $isPresent = preferencesPresent($empBSN);

    if ($isPresent == true) {
        removePreferences($empBSN);
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
    <link rel="stylesheet" type="text/css" href="../CSS_FILES/preferences.css">

</head>

<body>
    <div class="header">Personal Schedules</div>

    <?php include '../navigationBar.php'; ?>

    <section class="employeePreferences-form">
        <div class="row">
            <h2>Shift preferences</h2>
        </div>

        <div class="row">
            <form method="post" action="#" class="contact-form">
                <div class="row">
                    <label for="monday">Monday</label>
                    <select name="mondayShifts1" id="mondayShifts1">
                    <?php include '../combobox.php'; ?>    
                    </select>
                    <select name="mondayShifts2" id="mondayShifts2">
                    <?php include '../combobox.php'; ?>    
                    </select>
                </div>
                <div class="row">
                    <label for="tuesday">Tuesday</label>
                    <select name="tuesdayShifts1" id="tuesdayShifts1">
                    <?php include '../combobox.php'; ?> 
                    </select>
                    <select name="tuesdayShifts2" id="tuesdayShifts2">
                    <?php include '../combobox.php'; ?> 
                    </select>
                </div>
                <div class="row">
                    <label for="wednesday">Wednesday</label>
                    <select name="wednesdayShifts1" id="wednesdayShifts1">
                    <?php include '../combobox.php'; ?> 
                    </select>
                    <select name="wednesdayShifts2" id="wednesdayShifts2">
                    <?php include '../combobox.php'; ?> 
                    </select>
                </div>
                <div class="row">
                    <label for="thursday">Thursday</label>
                    <select name="thursdayShifts1" id="thursdayShifts1">
                    <?php include '../combobox.php'; ?> 
                    </select>
                    <select name="thursdayShifts2" id="thursdayShifts2">
                    <?php include '../combobox.php'; ?> 
                    </select>
                </div>
                <div class="row">
                    <label for="friday">Friday</label>
                    <select name="fridayShifts1" id="fridayShifts1">
                    <?php include '../combobox.php'; ?> 
                    </select>
                    <select name="fridayShifts2" id="fridayShifts2">
                    <?php include '../combobox.php'; ?> 
                    </select>
                </div>
                <div class="row">
                    <label for="saturday">Saturday</label>
                    <select name="saturdayShifts1" id="saturdayShifts1">
                    <?php include '../combobox.php'; ?> 
                    </select>
                    <select name="saturdayShifts2" id="saturdayShifts2">
                    <?php include '../combobox.php'; ?> 
                    </select>
                </div>
                <div class="row">
                    <label for="sunday">Sunday</label>
                    <select name="sundayShifts1" id="sundayShifts1">
                    <?php include '../combobox.php'; ?> 
                    </select>
                    <select name="sundayShifts2" id="sundayShifts2">
                    <?php include '../combobox.php'; ?> 
                    </select>
                </div>
                <div class="row">
                    <input type="submit" value="Save" name="btnSave">
                </div>
                <div class="row">
                    <input type="submit" value="Delete" name="btnDelete">
                </div>
            </form>
        </div>
    </section>


</body>