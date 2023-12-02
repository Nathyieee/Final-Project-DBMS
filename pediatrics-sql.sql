-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 02, 2023 at 09:43 AM
-- Server version: 10.4.28-MariaDB
-- PHP Version: 8.1.17

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `pediatrics`
--

-- --------------------------------------------------------

--
-- Table structure for table `appointmented`
--

CREATE TABLE `appointmented` (
  `appointment_Id` int(11) NOT NULL,
  `Doctor_Id` int(11) DEFAULT NULL,
  `Patient_Id` int(100) DEFAULT NULL,
  `AppointmentDate` varchar(100) DEFAULT NULL,
  `AppointmentTime` varchar(100) DEFAULT NULL,
  `Purpose` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `appointmented`
--

INSERT INTO `appointmented` (`appointment_Id`, `Doctor_Id`, `Patient_Id`, `AppointmentDate`, `AppointmentTime`, `Purpose`) VALUES
(1, 1, 1, '02/12/2023', '4:31 Pm', 'Check Up'),
(2, 2, 2, '02/12/2023', '4:33 Pm', 'Check Up'),
(3, 3, 3, '02/12/2023', '4:33 Pm', 'Check Up'),
(4, 2, 4, '02/12/2023', '4:34 Pm', 'Check Up'),
(5, 2, 5, '02/12/2023', '4:35 Pm', 'Check Up'),
(6, 1, 6, '02/12/2023', '4:36 Pm', 'Check Up'),
(7, 1, 7, '02/12/2023', '4:37 Pm', 'Check Up'),
(8, 2, 8, '02/12/2023', '4:38 Pm', 'Check Up'),
(9, 3, 9, '12/02/2023', '4:39 Pm', 'Check Up'),
(10, 2, 10, '12/02/2023', '4:41 Pm', 'Check Up');

-- --------------------------------------------------------

--
-- Table structure for table `doctor`
--

CREATE TABLE `doctor` (
  `Doctor_Id` int(11) NOT NULL,
  `firstname` varchar(50) NOT NULL,
  `lastname` varchar(50) NOT NULL,
  `specialty` varchar(100) NOT NULL,
  `contact` varchar(50) NOT NULL,
  `email` varchar(100) NOT NULL,
  `schedule` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `doctor`
--

INSERT INTO `doctor` (`Doctor_Id`, `firstname`, `lastname`, `specialty`, `contact`, `email`, `schedule`) VALUES
(1, 'Nathaniel Hernandez', 'Macalinao', 'Cardiology', '09493345677', 'itsyoboinate11@gmail.com', 'Monday - Friday'),
(2, 'Kylla', 'Paragas', 'Pulmonology', '09218360735', 'kyllamaeparagas@gmail.com', 'Wednesday - Friday'),
(3, 'Alethea', 'Malata', 'Audiologist', '09551420208', 'aletheamalata@gmail.com', 'Saturday - Sunday');

-- --------------------------------------------------------

--
-- Table structure for table `invoices`
--

CREATE TABLE `invoices` (
  `invoiceid` int(11) NOT NULL,
  `patientid` int(11) NOT NULL,
  `doctorid` int(11) NOT NULL,
  `appointmentid` int(11) NOT NULL,
  `date` varchar(255) NOT NULL,
  `totalamount` varchar(155) NOT NULL,
  `paymentstatus` varchar(155) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `invoices`
--

INSERT INTO `invoices` (`invoiceid`, `patientid`, `doctorid`, `appointmentid`, `date`, `totalamount`, `paymentstatus`) VALUES
(1, 1, 1, 1, '02/12/2023', '1500', 'Paid'),
(2, 2, 1, 2, '02/12/2023', '500', 'Paid');

-- --------------------------------------------------------

--
-- Table structure for table `patient`
--

CREATE TABLE `patient` (
  `Patient_Id` int(11) NOT NULL,
  `fname` varchar(100) NOT NULL,
  `lname` varchar(100) NOT NULL,
  `dob` varchar(50) NOT NULL,
  `gender` varchar(50) NOT NULL,
  `ParentsFirstName` varchar(255) NOT NULL,
  `ParentsLastName` varchar(255) NOT NULL,
  `contact` varchar(50) NOT NULL,
  `address` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `patient`
--

INSERT INTO `patient` (`Patient_Id`, `fname`, `lname`, `dob`, `gender`, `ParentsFirstName`, `ParentsLastName`, `contact`, `address`) VALUES
(1, 'Nathaniel', 'Macalinao', 'June 11, 2004', 'Male', 'Maria Cristina', 'Macalinao', '09493345677', 'Galamay-Amo San Jose Batangas'),
(2, 'Kylla Mae', 'Paragas', 'February 25, 2004', 'Female', 'Jose', 'Paragas', '09423112355', 'Calamba, Laguna'),
(3, 'Alethea', 'Malata', 'March 1, 2004', 'Female', 'Lolita', 'Malata', '09123456789', 'Aya, San Jose Batangas'),
(4, 'Rick Andrew', 'Macapagal', 'June 23, 2004', 'Male', 'Ricardo', 'Macapagal', '09123456789', 'Balagtasin San Jose Batangas'),
(5, 'Aerielle ', 'Macalinao', 'May 8, 2008 ', 'Female', 'Maria Cristina', 'Macalinao', '09493345677', 'Galamay-Amo San Jose Batangas'),
(6, 'Safiya Nuriel', 'Macalinao', 'October 7, 2005', 'Female', 'Joseph', 'Macalinao', '09939925443', 'Galamay-Amo San Jose Batangas'),
(7, 'Kyla', 'Andes', 'December 11, 2003', 'Female', 'Shirlie ', 'Andes', '09062332167', 'Muzon Batangas'),
(8, 'Kay Ann', 'Andes', 'November 2, 2004', 'Female', 'Shirlie', 'Andes', '0973423464', 'Muzon Batangas'),
(9, 'Zeph', 'Centeno', 'July 07, 2023', 'Female', 'Grace', 'Macalinao', '09773966713', 'Galamay-Amo San Jose Batangas'),
(10, 'Maqui', 'Frias', 'Septemer 7, 2023', 'Female', 'Julie Anne', 'Frias', '09345872578', 'Galamay-Amo San Jose Batangas');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `appointmented`
--
ALTER TABLE `appointmented`
  ADD PRIMARY KEY (`appointment_Id`),
  ADD UNIQUE KEY `foreign key` (`Patient_Id`),
  ADD KEY `Doctor_Id` (`Doctor_Id`);

--
-- Indexes for table `doctor`
--
ALTER TABLE `doctor`
  ADD PRIMARY KEY (`Doctor_Id`);

--
-- Indexes for table `invoices`
--
ALTER TABLE `invoices`
  ADD PRIMARY KEY (`invoiceid`),
  ADD KEY `patientid` (`patientid`),
  ADD KEY `doctorid` (`doctorid`);

--
-- Indexes for table `patient`
--
ALTER TABLE `patient`
  ADD PRIMARY KEY (`Patient_Id`);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `appointmented`
--
ALTER TABLE `appointmented`
  ADD CONSTRAINT `appointmented_ibfk_1` FOREIGN KEY (`Doctor_Id`) REFERENCES `doctor` (`Doctor_Id`),
  ADD CONSTRAINT `appointmented_ibfk_2` FOREIGN KEY (`Patient_Id`) REFERENCES `patient` (`Patient_Id`);

--
-- Constraints for table `invoices`
--
ALTER TABLE `invoices`
  ADD CONSTRAINT `invoices_ibfk_1` FOREIGN KEY (`patientid`) REFERENCES `patient` (`Patient_Id`),
  ADD CONSTRAINT `invoices_ibfk_2` FOREIGN KEY (`doctorid`) REFERENCES `doctor` (`Doctor_Id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
