<?php
session_start();
include "../DatabaseConn/preferences_template.php";

$user = $_SESSION['Username'];
$empBSN = getBSN($user);

$shifts = getShifts($empBSN);
var_dump($shifts);

if (isset($_POST['btnSave'])) {
    $isPresent = preferencesPresent($empBSN);

    if ($isPresent == true) {
        removePreferences($empBSN);
    }

    addPreference('MONDAY', $empBSN, $_POST['mondayShifts']);
    addPreference('TUESDAY',  $empBSN, $_POST['tuesdayShifts']);
    addPreference('WEDNESDAY',  $empBSN, $_POST['wednesdayShifts']);
    addPreference('THURSDAY',  $empBSN, $_POST['thursdayShifts']);
    addPreference('FRIDAY',  $empBSN, $_POST['fridayShifts']);
    addPreference('SATURDAY',  $empBSN, $_POST['saturdayShifts']);
    addPreference('SUNDAY',  $empBSN, $_POST['sundayShifts']);
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
                    <select name="mondayShifts" id="mondayShifts">
                        <option value=""></option>
                        <option value="MORNING">MORNING</option>
                        <option value="AFTERNOON">AFTERNOON</option>
                        <option value="EVENING">EVENING</option>
                    </select>
                </div>
                <div class="row">
                    <label for="tuesday">Tuesday</label>
                    <select name="tuesdayShifts" id="tuesdayShifts">
                        <option value=""></option>
                        <option value="MORNING">MORNING</option>
                        <option value="AFTERNOON">AFTERNOON</option>
                        <option value="EVENING">EVENING</option>
                    </select>
                </div>
                <div class="row">
                    <label for="wednesday">Wednesday</label>
                    <select name="wednesdayShifts" id="wednesdayShifts">
                        <option value=""></option>
                        <option value="MORNING">MORNING</option>
                        <option value="AFTERNOON">AFTERNOON</option>
                        <option value="EVENING">EVENING</option>
                    </select>
                </div>
                <div class="row">
                    <label for="thursday">Thursday</label>
                    <select name="thursdayShifts" id="thursdayShifts">
                        <option value=""></option>
                        <option value="MORNING">MORNING</option>
                        <option value="AFTERNOON">AFTERNOON</option>
                        <option value="EVENING">EVENING</option>
                    </select>
                </div>
                <div class="row">
                    <label for="friday">Friday</label>
                    <select name="fridayShifts" id="fridayShifts">
                        <option value=""></option>
                        <option value="MORNING">MORNING</option>
                        <option value="AFTERNOON">AFTERNOON</option>
                        <option value="EVENING">EVENING</option>
                    </select>
                </div>
                <div class="row">
                    <label for="saturday">Saturday</label>
                    <select name="saturdayShifts" id="saturdayShifts">
                        <option value=""></option>
                        <option value="MORNING">MORNING</option>
                        <option value="AFTERNOON">AFTERNOON</option>
                        <option value="EVENING">EVENING</option>
                    </select>
                </div>
                <div class="row">
                    <label for="sunday">Sunday</label>
                    <select name="sundayShifts" id="sundayShifts">
                        <option value=""></option>
                        <option value="MORNING">MORNING</option>
                        <option value="AFTERNOON">AFTERNOON</option>
                        <option value="EVENING">EVENING</option>
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