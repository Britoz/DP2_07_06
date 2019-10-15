-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Oct 14, 2019 at 02:35 AM
-- Server version: 10.1.39-MariaDB
-- PHP Version: 7.3.5

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
-- Table structure for table `productsales`
--

CREATE TABLE `productsales` (
  `id` int(11) NOT NULL,
  `salesid` int(11) NOT NULL,
  `productname` varchar(255) NOT NULL,
  `quantity` varchar(255) NOT NULL,
  `price` int(11) NOT NULL,
  `grosstotal` int(11) NOT NULL,
  `datetime` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `productsales`
--

INSERT INTO `productsales` (`id`, `salesid`, `productname`, `quantity`, `price`, `grosstotal`, `datetime`) VALUES
(1, 1, 'Liver Detox', '5', 25, 125, '2019-06-11'),
(2, 2, 'Liver Detox', '3', 25, 75, '2019-10-01'),
(3, 1, 'Liver Detox', '5', 25, 125, '2019-09-05'),
(4, 2, 'Swisse Hibicus Anti Ageing Night Cream', '5', 13, 65, '2019-05-10'),
(5, 3, 'Liver Detox', '5', 25, 125, '2019-05-15'),
(6, 4, 'Liver Detox', '1', 25, 25, '2019-06-12'),
(7, 5, 'Liver Detox', '4', 25, 100, '2019-07-17'),
(8, 6, 'Liver Detox', '2', 25, 50, '2019-08-07');

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
  `time` time NOT NULL,
  `totalitems` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `salesrecord`
--

INSERT INTO `salesrecord` (`id`, `salesid`, `totalprice`, `staffname`, `date`, `time`, `totalitems`) VALUES
(10, 10, 12, 'Dinh', '24/09/2019', '07:47:00', 0),
(11, 11, 43, 'Dinh', '24/09/2019', '07:47:00', 0),
(12, 12, 25, 'Dinh', '24/09/2019', '08:48:00', 0),
(13, 13, 10, 'Dinh', '25/09/2019', '03:04:00', 0),
(14, 14, 175, 'Dinh', '28/09/2019', '01:24:00', 0),
(15, 15, 52, 'Dinh', '28/09/2019', '01:31:00', 0),
(16, 16, 52, 'dih', '28/09/2019', '01:34:00', 0),
(17, 17, 24, 'd', '28/09/2019', '01:37:00', 0),
(18, 18, 12, 'dinh', '28/09/2019', '01:38:00', 0),
(19, 19, 93, 'dinh', '28/09/2019', '01:47:00', 3),
(20, 20, 115, 'Dinh', '10/10/2019', '04:18:00', 7),
(21, 21, 155, 'DInh', '10/10/2019', '04:28:00', 10),
(22, 22, 54, 'DInh', '10/10/2019', '04:30:00', 9),
(23, 23, 30, 'd', '10/10/2019', '04:33:00', 5),
(24, 24, 125, 'd', '10/10/2019', '04:45:00', 5),
(25, 25, 65, 'd', '10/10/2019', '04:47:00', 5);

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
-- Indexes for table `productsales`
--
ALTER TABLE `productsales`
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
-- AUTO_INCREMENT for table `productsales`
--
ALTER TABLE `productsales`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `salesrecord`
--
ALTER TABLE `salesrecord`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=26;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
