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
        return false;
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
        $sql = 'INSERT INTO holidays VALUES(:weekNumber, :BSN, :freeDay, :Holiday)';
        $sth = $conn->prepare($sql);

        $sth->execute(
            array(
                ':weekNumber' => $week,
                ':BSN' => $empBSN,
                ':freeDay' => $day,
                ':Holiday' => $holiday
            )
        );
        $empBSN = $sth->fetchAll();
        $conn = null;
    }catch(PDOException $e){
        return false;
    }
}
?>