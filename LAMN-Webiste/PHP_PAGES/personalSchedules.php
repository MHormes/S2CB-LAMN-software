<?php
session_start();
include "../DatabaseConn/get_schedules_template.php";
$weekNmr = 1;
$schedules = null;

if (isset($_POST['btnSelectWeek'])) {
    $weekNmr = $_POST['weekSelecter'];
    $schedules = GetSchedulesFromWeekForEmployee($_POST['weekSelecter'], $_SESSION['Username']);
    $_SESSION['startedPersonal'] = true;
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
    <link rel="stylesheet" type="text/css" href="../CSS_FILES/schedule.css">

</head>

<body>
    <div class="header">Personal Schedules</div>

    <?php include '../navigationBar.php'; ?>

    <form method="post" action="#">
        <p>Choose the week you want to see and click 'Show'</p>
        </br>
        <input class="weekCounter" type="number" name="weekSelecter" min="0" max="52" step="1" value="<?php echo $weekNmr ?>">
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
                if (isset($_SESSION['startedPersonal'])) {

                    $NameUser = "";
                    $Monday = "";
                    $Tuesday = "";
                    $Wednesday = "";
                    $Thursday = "";
                    $Friday = "";
                    $Saturday = "";
                    $Sunday = "";

                    foreach ($schedules as $value) {
                        if ($value->Day == "MONDAY") {
                            $Monday = $value->TimeSlot;
                        }
                        if ($value->Day == "TUESDAY") {
                            $Tuesday = $value->TimeSlot;
                        }
                        if ($value->Day == "WEDNESDAY") {
                            $Wednesday = $value->TimeSlot;
                        }
                        if ($value->Day == "THURDAY") {
                            $Thursday = $value->TimeSlot;
                        }
                        if ($value->Day == "FRIDAY") {
                            $Friday = $value->TimeSlot;
                        }
                        if ($value->Day == "SATURDAY") {
                            $Saturday = $value->TimeSlot;
                        }
                        if ($value->Day == "SUNDAY") {
                            $Sunday = $value->TimeSlot;
                        }
                        $NameUser = $value->FirstName . " " .  $value->SecondName;
                    }
                ?>
                    <tr>
                        <td><?php echo $NameUser ?></td>
                        <td><?php echo $Monday; ?></td>
                        <td><?php echo $Tuesday; ?></td>
                        <td><?php echo $Wednesday; ?></td>
                        <td><?php echo $Thursday; ?></td>
                        <td><?php echo $Friday; ?></td>
                        <td><?php echo $Saturday; ?></td>
                        <td><?php echo $Sunday; ?></td>
                    </tr>
                <?php
                }
                unset($_SESSION['startedPersonal']);

                ?>


            </table>
        </div>


</body>