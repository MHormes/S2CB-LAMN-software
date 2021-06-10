<?php


function GetSchedulesFromWeek($weekNmr, $userName)
{
    include '../DatabaseConn/connection.php';
    try
    {
        $conn = new PDO("mysql:host=studmysql01.fhict.local;dbname=dbi456806",$username, $password);

        $select_stmt =$conn->prepare("SELECT Position FROM employee WHERE UserName=:uUsername");
        $select_stmt->execute(array(':uUsername'=>$userName));
        $row=$select_stmt->fetch(PDO::FETCH_ASSOC);
        $position = $row["Position"];
        
        $sth = $conn->prepare("SELECT S.* , E.FirstName , E.SecondName FROM schedules as S INNER JOIN employee as E on S.EmpBSN = E.BSN WHERE S.Week = :weekNmr AND E.Position = :position");
        $sth->execute(array(':weekNmr' => $weekNmr, ':position'=> $position));
        $schedules = $sth->fetchAll(PDO::FETCH_OBJ);
        return $schedules;

    }
    catch(PDOException $e)
    {
        echo $e->getMessage();
    }
}

function GetSchedulesFromWeekForEmployee($weekNmr, $empUserName){
    include '../DatabaseConn/connection.php';
    try{
        $conn = new PDO("mysql:host=studmysql01.fhict.local;dbname=dbi456806",$username, $password);
        $sql = 'SELECT S.* , E.FirstName , E.SecondName, E.UserName FROM schedules as S INNER JOIN employee as E on S.EmpBSN = E.BSN WHERE Week = :weekNmr AND E.UserName = :empUserName';
        $sth = $conn->prepare($sql);

        $sth->execute([':weekNmr' => $weekNmr, ':empUserName' => $empUserName]);
        $schedules = $sth->fetchAll(PDO::FETCH_OBJ);
        return $schedules;
    }catch(PDOException $e){
        echo $e->getMessage();
    }
}
?>