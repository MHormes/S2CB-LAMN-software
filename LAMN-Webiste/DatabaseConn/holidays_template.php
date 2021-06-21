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


function GetHolidays($empBSN, $weekNmr){
    include '../DatabaseConn/connection.php';
    try{
        $conn = new PDO("mysql:host=studmysql01.fhict.local;dbname=dbi456806",$username, $password);
        $sql = 'SELECT * FROM holidays WHERE BSN = :BSN AND weekNumber = :weekNmr';
        $sth = $conn->prepare($sql);

        $sth->execute(
            array(
                ':BSN' => $empBSN,
                ':weekNmr' => $weekNmr
            )
        );
        $holidays = $sth->fetchAll(PDO::FETCH_OBJ);
        return $holidays;
        $conn = null;
    }catch(PDOException $e){
        return false;
    }
}

function removeHolidays($empBSN)
{
    include '../DatabaseConn/connection.php';
    try{
        $conn = new PDO("mysql:host=studmysql01.fhict.local;dbname=dbi456806",$username, $password);
        $sql = 'DELETE FROM holidays WHERE BSN = :BSN';
        $sth = $conn->prepare($sql);

        $sth->execute(
            array(
                ':BSN' => $empBSN
            )
        );
        $conn = null;
    }catch(PDOException $e){
        echo $e;
    }
}

function addHolidays($week,$day, $empBSN, $holiday)
{
    if($holiday == ""){
        return;
    }
    include '../DatabaseConn/connection.php';
    try{
        $conn = new PDO("mysql:host=studmysql01.fhict.local;dbname=dbi456806",$username, $password);
        $sql = 'INSERT INTO holidays VALUES(:weekNumber, :BSN, :freeDay, :holiday, :approved)';
        $sth = $conn->prepare($sql);

        $sth->execute(
            array(
                ':weekNumber' => $week,
                ':BSN' => $empBSN,
                ':freeDay' => $day,
                ':holiday' => $holiday,
                ':approved' => 'false',
            )
        );
        $conn = null;
    }catch(PDOException $e){
        return false;
    }
}
?>