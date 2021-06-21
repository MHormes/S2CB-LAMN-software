<?php
session_start();
include "../DatabaseConn/holidays_template.php";
$weekNmr = 1;

$user = $_SESSION['Username'];
$empBSN = getBSN($user);

if (isset($_POST['btnSave'])) {
    CallAddHolidays($empBSN);
}
if (isset($_POST['btnOverWrite'])) {
    removeHolidays($empBSN);
    CallAddHolidays($empBSN);
    $weekNmr = $_POST['weekSelecter'];
    $_SESSION['startedHoliday'] = 'true';
    $holiday = GetHolidays($empBSN, $weekNmr);
}

if (isset($_POST['btnSelectWeek']) || isset($_POST['btnSave'])) {
    $weekNmr = $_POST['weekSelecter'];
    $_SESSION['startedHoliday'] = 'true';
    $holiday = GetHolidays($empBSN, $weekNmr);
}

function CallAddHolidays($empBSN)
{
    addHolidays($_POST['weekSelecter'], 'MONDAY', $empBSN, $_POST['mondayHolidays']);
    addHolidays($_POST['weekSelecter'], 'TUESDAY',  $empBSN, $_POST['tuesdayHolidays']);
    addHolidays($_POST['weekSelecter'], 'WEDNESDAY',  $empBSN, $_POST['wednesdayHolidays']);
    addHolidays($_POST['weekSelecter'], 'THURDAY',  $empBSN, $_POST['thursdayHolidays']);
    addHolidays($_POST['weekSelecter'], 'FRIDAY',  $empBSN, $_POST['fridayHolidays']);
    addHolidays($_POST['weekSelecter'], 'SATURDAY',  $empBSN, $_POST['saturdayHolidays']);
    addHolidays($_POST['weekSelecter'], 'SUNDAY',  $empBSN, $_POST['sundayHolidays']);
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
    <link rel="stylesheet" type="text/css" href="../CSS_FILES/navigation.css">
    <link rel="stylesheet" type="text/css" href="../CSS_FILES/schedule.css">
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
                <p>Choose the week you want to plan your Holiday and click 'Show' to see your current holiday status</p>
                </br>
                <input class="weekCounter" type="number" name="weekSelecter" min="0" max="52" step="1" value="<?php echo $weekNmr ?>">
                <input class="button" type="submit" name="btnSelectWeek" value="Show">

                <!-- schedule to show holiday status of the chosen week!-->
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
                        if (isset($_SESSION['startedHoliday'])) {

                            $NameUser = "";
                            $Monday = "";
                            $Tuesday = "";
                            $Wednesday = "";
                            $Thursday = "";
                            $Friday = "";
                            $Saturday = "";
                            $Sunday = "";

                            foreach ($holiday as $value) {
                                if ($value->freeDay == "MONDAY") {
                                    if ($value->Holiday == "Holiday") {
                                        if ($value->Approved == "false") {
                                            $Monday = "Request Denied";
                                        } else {
                                            $Monday = $value->Holiday;
                                        }
                                    }
                                    $Monday = $value->Holiday;
                                }
                                if ($value->freeDay == "TUESDAY") {
                                    $Tuesday = $value->Holiday;
                                }
                                if ($value->freeDay == "WEDNESDAY") {
                                    $Wednesday = $value->Holiday;
                                }
                                if ($value->freeDay == "THURDAY") {
                                    $Thursday = $value->Holiday;
                                }
                                if ($value->freeDay == "FRIDAY") {
                                    $Friday = $value->Holiday;
                                }
                                if ($value->freeDay == "SATURDAY") {
                                    $Saturday = $value->Holiday;
                                }
                                if ($value->freeDay == "SUNDAY") {
                                    $Sunday = $value->Holiday;
                                }
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
                        unset($_SESSION['startedHoliday']);

                        ?>
                    </table>
                </div>
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
                    <input type="submit" value="Add chosen holiday to holiday status schedule" name="btnSave">
                </div>
                <div class="row">
                    <input type="submit" value="Overwrite current status with chosen holiday" name="btnOverWrite">
                </div>
            </form>
        </div>
    </section>


</body>