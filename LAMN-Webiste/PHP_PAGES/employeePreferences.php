<?php
session_start();
include "../DatabaseConn/preferences_template.php";

$user = $_SESSION['Username'];
$empBSN = getBSN($user);

$shifts = getShifts($empBSN);
$preferences = GetPreferences($empBSN);

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
    addPreference('THURDAY',  $empBSN, $_POST['thursdayShifts1']);
    addPreference('THURDAY',  $empBSN, $_POST['thursdayShifts2']);
    addPreference('FRIDAY',  $empBSN, $_POST['fridayShifts1']);
    addPreference('FRIDAY',  $empBSN, $_POST['fridayShifts2']);
    addPreference('SATURDAY',  $empBSN, $_POST['saturdayShifts1']);
    addPreference('SATURDAY',  $empBSN, $_POST['saturdayShifts2']);
    addPreference('SUNDAY',  $empBSN, $_POST['sundayShifts1']);
    addPreference('SUNDAY',  $empBSN, $_POST['sundayShifts2']);

    $preferences = GetPreferences($empBSN);
}

if (isset($_POST['btnDelete'])) {
    $isPresent = preferencesPresent($empBSN);

    if ($isPresent == true) {
        removePreferences($empBSN);
    }
    $preferences = GetPreferences($empBSN);
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
    <link rel="stylesheet" type="text/css" href="../CSS_FILES/schedule.css">
    
    <link rel="stylesheet" type="text/css" href="../CSS_FILES/preferences.css">

</head>

<body>
    <div class="header">Personal Schedules</div>

    <?php include '../navigationBar.php'; ?>

    <section class="employeePreferences-form">
        <div class="row">
            <h2>Shift preferences</h2>
        </div>

        <p>Your currently set preferences will be displayed below</p>
        <div class="schedules_table">
                    <table>
                        <tr>
                            <th>Monday</th>
                            <th>Tuesday</th>
                            <th>Wednesday</th>
                            <th>Thursday</th>
                            <th>Friday</th>
                            <th>Saturday</th>
                            <th>Sunday</th>
                        </tr>

                        <?php
                        if ($preferences != null) {

                            $NameUser = "";
                            $Monday = "";
                            $Monday2 = "";
                            $Tuesday = "";
                            $Tuesday2 = "";
                            $Wednesday = "";
                            $Wednesday2 = "";
                            $Thursday = "";
                            $Thursday2 = "";
                            $Friday = "";
                            $Friday2 = "";
                            $Saturday = "";
                            $Saturday2 = "";
                            $Sunday = "";
                            $Sunday2 = "";

                            foreach ($preferences as $value) {
                                if ($value->Day == "MONDAY") {
                                    if($Monday == ""){
                                        $Monday = $value->TimeSlot;
                                    }
                                    else{
                                        $Monday2 = $value->TimeSlot;
                                    }
                                }
                                if ($value->Day == "TUESDAY") {
                                    if($Tuesday == ""){
                                        $Tuesday = $value->TimeSlot;
                                    }
                                    else{
                                        $Tuesday2 = $value->TimeSlot;
                                    }
                                }
                                if ($value->Day == "WEDNESDAY") {
                                    if($Wednesday == ""){
                                        $Wednesday = $value->TimeSlot;
                                    }
                                    else{
                                        $Wednesday2 = $value->TimeSlot;
                                    }
                                }
                                if ($value->Day == "THURDAY") {
                                    if($Thursday == ""){
                                        $Thursday = $value->TimeSlot;
                                    }
                                    else{
                                        $Thursday2 = $value->TimeSlot;
                                    }
                                }
                                if ($value->Day == "FRIDAY") {
                                    if($Friday == ""){
                                        $Friday = $value->TimeSlot;
                                    }
                                    else{
                                        $Friday2 = $value->TimeSlot;
                                    }
                                }
                                if ($value->Day == "SATURDAY") {
                                    if($Saturday == ""){
                                        $Saturday = $value->TimeSlot;    
                                    }
                                    else{
                                        $Saturday2 = $value->TimeSlot;
                                    }
                                }
                                if ($value->Day == "SUNDAY") {
                                    if($Sunday == ""){
                                        $Sunday = $value->TimeSlot;    
                                    }
                                    else{
                                        $Sunday2 = $value->TimeSlot;
                                    }
                                }
                            }
                        ?>
                            <tr>
                                <td><?php echo $Monday; ?></td>
                                <td><?php echo $Tuesday; ?></td>
                                <td><?php echo $Wednesday; ?></td>
                                <td><?php echo $Thursday; ?></td>
                                <td><?php echo $Friday; ?></td>
                                <td><?php echo $Saturday; ?></td>
                                <td><?php echo $Sunday; ?></td>
                            </tr>
                            <tr>
                                <td><?php echo $Monday2; ?></td>
                                <td><?php echo $Tuesday2; ?></td>
                                <td><?php echo $Wednesday2; ?></td>
                                <td><?php echo $Thursday2; ?></td>
                                <td><?php echo $Friday2; ?></td>
                                <td><?php echo $Saturday2; ?></td>
                                <td><?php echo $Sunday2; ?></td>
                            </tr>
                        <?php
                        }
                        ?>
                    </table>
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