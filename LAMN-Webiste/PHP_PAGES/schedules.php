<?php
session_start();
include "../DatabaseConn/get_schedules_template.php";
$weekNmr = 1;

if(isset($_POST['btnSelectWeek']))
{
    $weekNmr = $_POST['weekSelecter'];
    $schedules = GetSchedulesFromWeek($_POST['weekSelecter']);
    $_SESSION['started'] = true;
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
        <link rel="stylesheet" type="text/css" href="../CSS_FILES/schedule.css">

    </head>
    <body>

    
    <div class="header">Schedules</div>
    <form method="post" action="#">
    <input class="weekCounter" type="number" name="weekSelecter" min="0" max="52" step="1" value="<?php echo $weekNmr?>">
    <input class="button" type="submit" name="btnSelectWeek" value="Show">
    </div>
    <div class="schedules_table">
    <table>
    <tr>
    <th></th>
    <th>Monday</th>
    <th>Tuesday</th>
    <th>Wednesday</th>
    <th>Thursday</th>
    <th>Friday</th>
    <th>Saturday</th>
    <th>Sunday</th>
    </tr>
    <?php
    if(isset($_SESSION['started'])){
        foreach($schedules as $value){ ?>
            <tr>
            <td><?php echo $value->FirstName ." " .  $value->SecondName?></td>
            <td><?php if($value->Day == "MONDAY"){ echo $value->TimeSlot;}?></td>
            <td><?php if($value->Day == "TUESDAY"){ echo $value->TimeSlot;}?></td>
            <td><?php if($value->Day == "WEDNESDAY"){ echo $value->TimeSlot;}?></td>
            <td><?php if($value->Day == "THURDAY"){ echo $value->TimeSlot;}?></td>
            <td><?php if($value->Day == "FRIDAY"){ echo $value->TimeSlot;}?></td>
            <td><?php if($value->Day == "SATURDAY"){ echo $value->TimeSlot;}?></td>
            <td><?php if($value->Day == "SUNDAY"){ echo $value->TimeSlot;}?></td>
            </tr>
        <?php } }
        ?>
    </table>
    </div>
    
    
    </body>