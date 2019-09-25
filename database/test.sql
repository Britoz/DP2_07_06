-- phpMyAdmin SQL Dump
-- version 4.9.0.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Sep 25, 2019 at 07:06 AM
-- Server version: 10.4.6-MariaDB
-- PHP Version: 7.1.32

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `test`
--

-- --------------------------------------------------------

--
-- Table structure for table `login`
--

CREATE TABLE `login` (
  `id` int(11) NOT NULL,
  `username` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `login`
--

INSERT INTO `login` (`id`, `username`, `password`) VALUES
(1, 'caitlin', 'caitlin'),
(2, 'dinh', 'dinh'),
(3, 'lee', 'lee');

-- --------------------------------------------------------

--
-- Table structure for table `product`
--

CREATE TABLE `product` (
  `id` int(11) NOT NULL,
  `name` text NOT NULL,
  `serialnumber` int(11) NOT NULL,
  `description` text NOT NULL,
  `quantity` int(11) NOT NULL,
  `priceperunit` int(11) NOT NULL,
  `dateimport` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `product`
--

INSERT INTO `product` (`id`, `name`, `serialnumber`, `description`, `quantity`, `priceperunit`, `dateimport`) VALUES
(1, 'Liver Detox', 11010, 'Swisse Ultiboost Liver Detox 200 Tablets', 10, 25, '2019-09-12'),
(2, 'Swisse Hibicus Anti Ageing Night Cream', 111110, 'Swisse Hibicus Anti Ageing Night Cream 50ml', 20, 13, '2019-09-12'),
(3, 'Swisse Face Micellar Water Make Up Remover', 10001, 'Swisse Face Micellar Water Make Up Remover 300ml', 30, 6, '2019-09-12'),
(4, 'A2 Premium Toddler Stage 3', 10102, 'A2 Premium Toddler Stage 3 900g', 10, 31, '2019-09-12');

-- --------------------------------------------------------

--
-- Table structure for table `salesproduct`
--

CREATE TABLE `salesproduct` (
  `id` int(11) NOT NULL,
  `salesid` int(11) NOT NULL,
  `productname` varchar(255) NOT NULL,
  `quantity` int(11) NOT NULL,
  `price` int(11) NOT NULL,
  `grosstotal` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `salesrecord`
--

CREATE TABLE `salesrecord` (
  `id` int(11) NOT NULL,
  `salesid` int(11) NOT NULL,
  `totalprice` int(11) NOT NULL,
  `staffname` text NOT NULL,
  `date` varchar(255) NOT NULL,
  `time` time NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `salesrecord`
--

INSERT INTO `salesrecord` (`id`, `salesid`, `totalprice`, `staffname`, `date`, `time`) VALUES
(10, 10, 12, 'Dinh', '24/09/2019', '07:47:00'),
(11, 11, 43, 'Dinh', '24/09/2019', '07:47:00'),
(12, 12, 25, 'Dinh', '24/09/2019', '08:48:00'),
(13, 13, 10, 'Dinh', '25/09/2019', '03:04:00');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `login`
--
ALTER TABLE `login`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `product`
--
ALTER TABLE `product`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `salesproduct`
--
ALTER TABLE `salesproduct`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `salesrecord`
--
ALTER TABLE `salesrecord`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `login`
--
ALTER TABLE `login`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `product`
--
ALTER TABLE `product`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `salesproduct`
--
ALTER TABLE `salesproduct`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `salesrecord`
--
ALTER TABLE `salesrecord`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
