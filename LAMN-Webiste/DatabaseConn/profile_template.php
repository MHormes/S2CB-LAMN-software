<?php

function GetMessage($user)
{
    include "../DatabaseConn/connection.php";

    $select_stmt = $conn->prepare("SELECT Message, ChangeID FROM employeechange WHERE UserName=:uUsername AND Handled=:uHandled AND MessageSeen=:uMessageSeen");
    $select_stmt->execute(array(':uUsername' => $user, ':uHandled' => 1, ':uMessageSeen' => 0));
    $row = $select_stmt->fetch(PDO::FETCH_ASSOC);

    if($select_stmt->rowCount() < 1)
    {
        return null;
    }
    else
    { 
        $stmt = $conn->prepare("UPDATE employeechange SET MessageSeen=:uMessageSeen WHERE UserName=:uUserName AND Handled=:uHandled AND ChangeID=:uChangeID");
        $stmt->bindValue(':uMessageSeen', 1);
        $stmt->bindValue(':uUserName', $user);
        $stmt->bindValue(':uHandled', 1);
        $stmt->bindValue(':uChangeID', $row["ChangeID"]);
        $result = $stmt->execute();

        return $row;
    }
}


function GetUserInfo($user)
{
    include "../DatabaseConn/connection.php";

    $select_stmt = $conn->prepare("SELECT * FROM employee WHERE UserName=:uUsername");
    $select_stmt->execute(array(':uUsername' => $user));
    $row = $select_stmt->fetch(PDO::FETCH_ASSOC);

    return $row;
}


function RequestChangeOfInfo($BSN, $user, $firstName, $secondName, $phoneNumber, $iceRelationship, $iceNumber, $address)
{
    include "../DatabaseConn/connection.php";

    if (empty($firstName)) {
        $errorMsg[] = "Please enter first name";
        return $errorMsg;
    }
    if (empty($secondName)) {
        $errorMsg[] = "Please enter last name";
        return $errorMsg;
    }
    if (empty($phoneNumber)) {
        $errorMsg[] = "Please enter phone number";
        return $errorMsg;
    }
    if (empty($iceRelationship)) {
        $errorMsg[] = "Please enter ICE relationship";
        return $errorMsg;
    }
    if (empty($iceNumber)) {
        $errorMsg[] = "Please enter ICE number";
        return $errorMsg;
    } else if (strlen($phoneNumber) != 10) {
        $errorMsg[] = "Phone number must be 10 digits long";
        return $errorMsg;
    } else {
        try {

            if (!isset($errorMsg)) {
                $select_stmt = $conn->prepare("SELECT * FROM employeechange WHERE UserName=:uUserName AND Handled=:uHandled");
                $select_stmt->execute(array(':uUserName' => $user, ':uHandled' => 0));
                //$row=$select_stmt->execute(array(':uHandled' => 0));
                $select_stmt->fetch(PDO::FETCH_ASSOC);

                if ($select_stmt->rowCount() < 1) {
                    $sql = "INSERT INTO employeechange (BSN, UserName, FirstName, SecondName, PhoneNumber, ICEnumber, ICErelation, Address) VALUES (:uBSN, :uUserName, :uFirstName, :uSecondName, :uPhoneNumber, :uICEnumber, :uICErelation, :uAddress)";
                    $stmt = $conn->prepare($sql);
                    $stmt->bindValue(':uBSN', $BSN);
                    $stmt->bindValue(':uUserName', $user);
                    $stmt->bindValue(':uFirstName', $firstName);
                    $stmt->bindValue(':uSecondName', $secondName);
                    $stmt->bindValue(':uPhoneNumber', $phoneNumber);
                    $stmt->bindValue(':uICEnumber', $iceNumber);
                    $stmt->bindValue(':uICErelation', $iceRelationship);
                    $stmt->bindValue(':uAddress', $address);

                    $result = $stmt->execute();

                    if ($result) {
                        return null;
                    }
                } 
                else 
                {
                    $stmt = $conn->prepare("UPDATE employeechange SET FirstName=:uFirstName, SecondName=:uSecondName, PhoneNumber=:uPhoneNumber, ICEnumber=:uICEnumber, ICErelation=:uICErelation, Address=:uAddress WHERE UserName=:uUserName AND Handled=:uHandled");
                    //$stmt->bindValue(':uChangeID', $row["ChangeID"]);
                    $stmt->bindValue(':uUserName', $user);
                    $stmt->bindValue(':uFirstName', $firstName);
                    $stmt->bindValue(':uSecondName', $secondName);
                    $stmt->bindValue(':uPhoneNumber', $phoneNumber);
                    $stmt->bindValue(':uICEnumber', $iceNumber);
                    $stmt->bindValue(':uICErelation', $iceRelationship);
                    $stmt->bindValue(':uAddress', $address);
                    $stmt->bindValue(':uHandled', 0);

                
                    $result = $stmt->execute();

                    if ($result) {
                        return null;
                    }
                    else{
                        return $errorMsg;
                    }
                }
            }
        } catch (PDOException $e) {
            $e->getMessage();
        }
    }
}