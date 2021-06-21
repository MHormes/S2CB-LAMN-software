<?php

$username = "dbi456806";
$password = "LAMNSoftware";

try{
    $conn = new PDO("mysql:host=studmysql01.fhict.local;dbname=dbi456806",$username, $password);
    $conn -> setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION); ?>
    <script>console.log(<?php echo "Connected succesfully"; ?> ) </script> <?php
}
catch(PDOException $e){ ?>
    <script>console.log(<?php echo "Connection failed: " . $e->getMessage(); ?> ) </script> <?php
}