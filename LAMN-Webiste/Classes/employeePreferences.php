<?php
session_start();
include "../DatabaseConn/get_schedules_template.php";

if (isset($_POST['btnSelectWeek'])) {
    $user = $_SESSION['Username']);
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

    <section class="employeePreferences-form">
            <div class="row">
                <h2>Shift preferences</h2>
            </div>
            <div class="row">
                <form method="post" action="#" class="contact-form">
                    <!-- inserting name, email, message -->
                    <div class="row">
                        <label for="monday">Monday</label>
                            <select name="shifts" id="shifts">
                            <option value="morning">Morning</option>
                            <option value="afternoon">Afternoon</option>
                            <option value="evening">Evening</option>
                        </select>
                    </div>
                    <div class="row">
                        <label for="tuesday">Tuesday</label>
                            <select name="shifts" id="shifts">
                            <option value="morning">Morning</option>
                            <option value="afternoon">Afternoon</option>
                            <option value="evening">Evening</option>
                        </select>
                    </div>
                    <div class="row">
                        <label for="wednesday">Wednesday</label>
                            <select name="shifts" id="shifts">
                            <option value="morning">Morning</option>
                            <option value="afternoon">Afternoon</option>
                            <option value="evening">Evening</option>
                        </select>
                    </div>
                    <div class="row">
                        <label for="thursday">Thursday</label>
                            <select name="shifts" id="shifts">
                            <option value="morning">Morning</option>
                            <option value="afternoon">Afternoon</option>
                            <option value="evening">Evening</option>
                        </select>
                    </div>
                    <div class="row">
                        <label for="friday">Friday</label>
                            <select name="shifts" id="shifts">
                            <option value="morning">Morning</option>
                            <option value="afternoon">Afternoon</option>
                            <option value="evening">Evening</option>
                        </select>
                    </div>
                    <div class="row">
                        <label for="saturday">Saturday</label>
                            <select name="shifts" id="shifts">
                            <option value="morning">Morning</option>
                            <option value="afternoon">Afternoon</option>
                            <option value="evening">Evening</option>
                        </select>
                    </div>
                    <div class="row">
                        <label for="sunday">Sunday</label>
                            <select name="shifts" id="shifts">
                            <option value="morning">Morning</option>
                            <option value="afternoon">Afternoon</option>
                            <option value="evening">Evening</option>
                        </select>
                    </div>
                    <div class="row">
                        <input type="submit" value="Send" name="btnSend">
                    </div>
                </form>
            </div>
        </section>


</body>