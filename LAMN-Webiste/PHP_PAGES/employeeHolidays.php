<?php
session_start();
include "../DatabaseConn/holidays_template.php";

$user = $_SESSION['Username'];
$empBSN = getBSN($user);

if (isset($_POST['btnSave'])) {
    

    

    addHolidays($_POST['weekSelecter'],'MONDAY', $empBSN, $_POST['mondayHolidays']);
    addHolidays($_POST['weekSelecter'],'TUESDAY',  $empBSN, $_POST['tuesdayHolidays']);
    addHolidays($_POST['weekSelecter'],'WEDNESDAY',  $empBSN, $_POST['wednesdayHolidays']);
    addHolidays($_POST['weekSelecter'],'THURSDAY',  $empBSN, $_POST['thursdayHolidays']);
    addHolidays($_POST['weekSelecter'],'FRIDAY',  $empBSN, $_POST['fridayHolidays']);
    addHolidays($_POST['weekSelecter'],'SATURDAY',  $empBSN, $_POST['saturdayHolidays']);
    addHolidays($_POST['weekSelecter'],'SUNDAY',  $empBSN, $_POST['sundayHolidays']);
}

if (isset($_POST['btnDelete'])) {
   

        removeHolidays($empBSN);
    
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
    <link rel="stylesheet" type="text/css" href="../CSS_FILES/holidays.css">

</head>

<body>
    <div class="header">Personal Schedules</div>

    <?php include '../navigationBar.php'; ?>

    <section class="employeeHolidays-form">
        <div class="row">
            <h2>Holidays</h2>
        </div>

        <div class="row">
            <form method="post" action="#" class="contact-form">
            </br>
        <p>Choose the week you want to plan your Holiday and click 'Show'</p>
        </br>
        <input class="weekCounter" type="number" name="weekSelecter" min="0" max="52" step="1" value="<?php echo $weekNmr ?>">
        <input class="button" type="submit" name="btnSelectWeek" value="Show">
        </br>
                <div class="row">
                    <label for="monday">Monday</label>
                    <select name="mondayHolidays" id="mondayHolidays">
                    <?php include '../comboboxHoliday.php'; ?>    
                    </select>
                   
                </div>
                <div class="row">
                    <label for="tuesday">Tuesday</label>
                    <select name="tuesdayHolidays" id="tuesdayHolidays">
                    <?php include '../comboboxHoliday.php'; ?> 
                    </select>
                    
                </div>
                <div class="row">
                    <label for="wednesday">Wednesday</label>
                    <select name="wednesdayHolidays" id="wednesdayHolidays">
                    <?php include '../comboboxHoliday.php'; ?> 
                    </select>
                   
                </div>
                <div class="row">
                    <label for="thursday">Thursday</label>
                    <select name="thursdayHolidays" id="thursdayHolidays">
                    <?php include '../comboboxHoliday.php'; ?> 
                    </select>
                    
                </div>
                <div class="row">
                    <label for="friday">Friday</label>
                    <select name="fridayHolidays" id="fridayHolidays">
                    <?php include '../comboboxHoliday.php'; ?> 
                    </select>
                    
                </div>
                <div class="row">
                    <label for="saturday">Saturday</label>
                    <select name="saturdayHolidays" id="saturdayHolidays">
                    <?php include '../comboboxHoliday.php'; ?> 
                    </select>
                   
                </div>
                <div class="row">
                    <label for="sunday">Sunday</label>
                    <select name="sundayHolidays" id="sundayHolidays">
                    <?php include '../comboboxHoliday.php'; ?> 
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