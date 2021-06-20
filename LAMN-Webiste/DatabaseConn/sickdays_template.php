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

function removeSickday($empBSN)
{
    include '../DatabaseConn/connection.php';
    try{
        $conn = new PDO("mysql:host=studmysql01.fhict.local;dbname=dbi456806",$username, $password);
        $sql = 'DELETE FROM sickdays WHERE BSN = :BSN';
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

function addSickDay($bsn, $day, $sick)
{
    if($sick == ""){
        return;
    }
    include '../DatabaseConn/connection.php';
    try{
        $conn = new PDO("mysql:host=studmysql01.fhict.local;dbname=dbi456806",$username, $password);
        $sql = 'INSERT INTO sickdays VALUES(:BSN, :weekDay, :Sick)';
        $sth = $conn->prepare($sql);

        $sth->execute(
            array(
                
                ':BSN' => $bsn,
                ':weekDay' => $day,
                ':Sick' => $sick
            )
        );
        $empBSN = $sth->fetchAll();
        $conn = null;
    }catch(PDOException $e){
        return false;
    }
}
?>