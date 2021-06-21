<?php
function getBSN($usernameLogin)
{
    include '../DatabaseConn/connection.php';
    try{
        $conn = new PDO("mysql:host=studmysql01.fhict.local;dbname=dbi456806",$username, $password);
        $sql = 'SELECT BSN FROM employee WHERE Username = :username';
        $sth = $conn->prepare($sql);
        $sth->execute([':username' => $usernameLogin]);

        $bsn = $sth->fetch();
        $conn = null;
        return $bsn[0];

    }catch(PDOException $e){
        return false;
    }
}

function getShifts($empBSN)
{
    include '../DatabaseConn/connection.php';
    try{
        $conn = new PDO("mysql:host=studmysql01.fhict.local;dbname=dbi456806",$username, $password);
        $sql = 'SELECT TimeSlot FROM employeepreferences WHERE EmpBSN = :BSN';
        $sth = $conn->prepare($sql);
        $sth->execute([':BSN' => $empBSN]);

        $shifts = $sth->fetchAll(PDO::FETCH_OBJ);
        
        return $shifts;
        $conn = null;

    }catch(PDOException $e){
        return false;
    }
}


function GetPreferences($empBSN){
    include '../DatabaseConn/connection.php';
    try{
        $conn = new PDO("mysql:host=studmysql01.fhict.local;dbname=dbi456806",$username, $password);
        $sql = 'SELECT * FROM employeepreferences WHERE EmpBSN = :BSN';
        $sth = $conn->prepare($sql);
        $sth->execute([':BSN' => $empBSN]);

        $preferences = $sth->fetchAll(PDO::FETCH_OBJ);
        return $preferences;
        $conn = null;
    }catch(PDOException $e){
        return false;
    }
}

function preferencesPresent($empBSN)
{
    include '../DatabaseConn/connection.php';
    try{
        $conn = new PDO("mysql:host=studmysql01.fhict.local;dbname=dbi456806",$username, $password);
        $sql = 'SELECT * FROM employeepreferences WHERE EmpBSN = :BSN';
        $sth = $conn->prepare($sql);
        $sth->execute([':BSN' => $empBSN]);

        $count = $sth->rowCount();
        $conn = null;
        if($count > 0){
            return true;
        }
        
        return false;

    }catch(PDOException $e){
        return false;
    }
}

function removePreferences($empBSN)
{
    include '../DatabaseConn/connection.php';
    try{
        $conn = new PDO("mysql:host=studmysql01.fhict.local;dbname=dbi456806",$username, $password);
        $sql = 'DELETE FROM employeepreferences WHERE EmpBSN = :empBSN';
        $sth = $conn->prepare($sql);

        $sth->execute(
            array(
                ':empBSN' => $empBSN
            )
        );
        $conn = null;
    }catch(PDOException $e){
        return false;
    }
}

function addPreference($day, $empBSN, $timeSlot)
{
    if($timeSlot == ""){
        return;
    }
    include '../DatabaseConn/connection.php';
    try{
        $conn = new PDO("mysql:host=studmysql01.fhict.local;dbname=dbi456806",$username, $password);
        $sql = 'INSERT INTO employeepreferences VALUES(:shiftDay, :BSN, :shiftTimeSlot)';
        $sth = $conn->prepare($sql);

        $sth->execute(
            array(
                ':shiftDay' => $day,
                ':BSN' => $empBSN,
                ':shiftTimeSlot' => $timeSlot
            )
        );
        $empBSN = $sth->fetchAll();
        $conn = null;
    }catch(PDOException $e){
        return false;
    }
}