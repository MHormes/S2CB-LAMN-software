<?php

class Schedule{

    private $bsn;
    private $week;
    private $day;
    private $timeSlot;

    public function __construct($bsn, $week, $day, $timeSlot)
    {
        $this->bsn=$bsn;
        $this->$week=$week;
        $this->$day=$day;
        $this->$timeSlot=$timeSlot;
    }

    
}