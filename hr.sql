-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 30, 2024 at 10:42 AM
-- Server version: 10.4.28-MariaDB
-- PHP Version: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `hr`
--
CREATE DATABASE IF NOT EXISTS `hr` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `hr`;

-- --------------------------------------------------------

--
-- Table structure for table `accounts`
--

CREATE TABLE `accounts` (
  `userid` int(11) NOT NULL,
  `username` varchar(45) NOT NULL,
  `pass` varchar(45) NOT NULL,
  `email` varchar(45) NOT NULL,
  `dept_id` int(11) DEFAULT NULL,
  `sal_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `accounts`
--

INSERT INTO `accounts` (`userid`, `username`, `pass`, `email`, `dept_id`, `sal_id`) VALUES
(1, 'mike', 'mm', 'mikemadb@gmail.com', 1, 1),
(2, 'irish', 'i', 'irish@hotmail.com', 3, 3),
(3, 'kim', 'r', 'kim@bicol-u.edu.ph', 5, 5),
(4, 'aileen', 'a', 'ai@microsoft.com', 1, 1),
(5, 'javan', 'j', 'javan@bicol-u.edu.ph', 3, 3),
(6, 'jarvis', 'b', 'jarvis@gmail.com', 5, 5),
(10, 'vivian', 'v', 'vivian@gmail.com', 3, 3),
(12, 'allana', 'avn', 'allana@gmail.com', 1, 1);

-- --------------------------------------------------------

--
-- Table structure for table `department`
--

CREATE TABLE `department` (
  `dnumber` int(11) NOT NULL,
  `dname` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `department`
--

INSERT INTO `department` (`dnumber`, `dname`) VALUES
(1, 'TechSupport'),
(3, 'Research'),
(5, 'Payroll');

-- --------------------------------------------------------

--
-- Table structure for table `deptsal`
--

CREATE TABLE `deptsal` (
  `dnumber` int(11) NOT NULL DEFAULT 0,
  `totalsalary` int(11) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `deptsal`
--

INSERT INTO `deptsal` (`dnumber`, `totalsalary`) VALUES
(1, 104000),
(3, 228800),
(5, 185900);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `accounts`
--
ALTER TABLE `accounts`
  ADD PRIMARY KEY (`userid`),
  ADD KEY `dept_no` (`dept_id`),
  ADD KEY `sal_no` (`sal_id`);

--
-- Indexes for table `department`
--
ALTER TABLE `department`
  ADD PRIMARY KEY (`dnumber`);

--
-- Indexes for table `deptsal`
--
ALTER TABLE `deptsal`
  ADD PRIMARY KEY (`dnumber`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `accounts`
--
ALTER TABLE `accounts`
  MODIFY `userid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT for table `department`
--
ALTER TABLE `department`
  MODIFY `dnumber` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `accounts`
--
ALTER TABLE `accounts`
  ADD CONSTRAINT `accounts_ibfk_1` FOREIGN KEY (`dept_id`) REFERENCES `department` (`dnumber`),
  ADD CONSTRAINT `accounts_ibfk_2` FOREIGN KEY (`sal_id`) REFERENCES `deptsal` (`dnumber`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
