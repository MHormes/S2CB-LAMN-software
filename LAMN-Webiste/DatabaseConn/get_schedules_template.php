<?php
function GetSchedulesFromWeek($weekNmr)
{
    include '../DatabaseConn/connection.php';
    try{
        $conn = new PDO("mysql:host=studmysql01.fhict.local;dbname=dbi456806",$username, $password);
        $sql = 'SELECT S.* , E.FirstName , E.SecondName FROM schedules as S INNER JOIN employee as E on S.EmpBSN = E.BSN WHERE Week = :weekNmr';
        $sth = $conn->prepare($sql);

        $sth->execute([':weekNmr' => $weekNmr]);
        $schedules = $sth->fetchAll(PDO::FETCH_OBJ);

        return $schedules;
    }catch(PDOException $e){
        echo $e->getMessage();
    }
}
?>