-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 22, 2023 at 03:45 PM
-- Server version: 10.4.25-MariaDB
-- PHP Version: 8.1.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `dbulib`
--

-- --------------------------------------------------------

--
-- Table structure for table `buku`
--

CREATE TABLE `buku` (
  `id_buku` bigint(15) NOT NULL,
  `judul_buku` varchar(100) NOT NULL,
  `penulis_buku` char(70) NOT NULL,
  `thn_terbit` int(5) NOT NULL,
  `kategori_buku` varchar(20) NOT NULL,
  `harga_buku` int(8) NOT NULL,
  `stok` int(3) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `buku`
--

INSERT INTO `buku` (`id_buku`, `judul_buku`, `penulis_buku`, `thn_terbit`, `kategori_buku`, `harga_buku`, `stok`) VALUES
(100000083376, 'Modern Compiler Design', 'David Galles', 2005, 'Technology', 178000, 6),
(100000118825, 'Ilmu Agama', 'Dr. A.G. Honig Jr.', 1988, 'Philosophy', 30000, 5),
(100000121955, 'Christianity and World Religions', 'E. Luther Copeland', 1963, 'Philosophy', 59000, 7),
(100000227329, 'Ethical Dimension in the Health Professions', 'Ruth B. Purtilo & Regina F. Doherty', 2011, 'General', 154000, 10),
(100000228623, 'Nursing Ethics Communities in Dialogue', 'Rose Mary Volbrecht', 2002, 'General', 576000, 2),
(100000260036, 'Microsoft Excel 2019 VBA and Macros', 'Bill jellen & Tracy Syrstad', 2020, 'Technology', 845000, 5),
(100000289142, 'NAMA DAN KONFLIK PALESTINA', 'John Tambingon', 2000, '', 500000, 1);

-- --------------------------------------------------------

--
-- Table structure for table `peminjaman`
--

CREATE TABLE `peminjaman` (
  `id_pinjam` int(10) NOT NULL,
  `id_buku` bigint(15) NOT NULL,
  `tgl_pinjam` date NOT NULL,
  `tgl_kembali` date NOT NULL,
  `student_nim` bigint(15) NOT NULL,
  `jumlah_buku` int(2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `pengembalian`
--

CREATE TABLE `pengembalian` (
  `id_kembali` int(10) NOT NULL,
  `id_pinjam` int(10) NOT NULL,
  `id_buku` bigint(15) NOT NULL,
  `tgl_pinjam` date NOT NULL,
  `tgl_kembali` date NOT NULL,
  `student_nim` bigint(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `staff`
--

CREATE TABLE `staff` (
  `staff_id` varchar(7) NOT NULL,
  `staff_name` char(50) NOT NULL,
  `staff_pass` varchar(6) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `staff`
--

INSERT INTO `staff` (`staff_id`, `staff_name`, `staff_pass`) VALUES
('ST001', 'Shellyne Natasha Salainti', 'admin1'),
('ST002', 'Jacky Karongkong', 'admin2'),
('ST003', 'Juanri Dwight Tambalean', 'admin2'),
('ST004', 'Falentino Marky Tombeng', 'admin3');

-- --------------------------------------------------------

--
-- Table structure for table `student`
--

CREATE TABLE `student` (
  `student_nim` bigint(15) NOT NULL,
  `student_name` char(50) NOT NULL,
  `student_email` varchar(50) NOT NULL,
  `faculty` varchar(50) NOT NULL,
  `pass` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `student`
--

INSERT INTO `student` (`student_nim`, `student_name`, `student_email`, `faculty`, `pass`) VALUES
(105012110025, 'Benedict Jonathan Tumewu', 'S22110261@student.unklab.ac.id', 'Fakultas Ilmu Komputer', '12345'),
(105012110043, 'Juan Michael Salainti', 'S22110366@student.unklab.ac.id', 'Fakultas Ilmu Komputer', '12345'),
(105012110061, 'Jhellytha Putri Kalantow', 'S22110531@student.unklab.ac.id', 'Fakultas Ilmu Komputer', '12345'),
(105022110058, 'William Goeyana', 'S22110335@student.unklab.ac.id', 'Fakultas Ilmu Komputer', '12345'),
(105022110077, 'Andreas Jeno Figo Topuh', 'S22110405@student.unklab.ac.id', 'Fakultas Ilmu Komputer', '12345'),
(105022110094, 'Richard John Jong', 'S22110503@student.unklab.ac.id', 'Fakultas Ilmu Komputer', '12345');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `buku`
--
ALTER TABLE `buku`
  ADD PRIMARY KEY (`id_buku`);

--
-- Indexes for table `peminjaman`
--
ALTER TABLE `peminjaman`
  ADD PRIMARY KEY (`id_pinjam`),
  ADD KEY `FK_peminjaman` (`student_nim`),
  ADD KEY `FK_peminjaman2` (`id_buku`);

--
-- Indexes for table `pengembalian`
--
ALTER TABLE `pengembalian`
  ADD PRIMARY KEY (`id_kembali`),
  ADD KEY `FK_pengembalian` (`id_pinjam`),
  ADD KEY `FK_pengembalian2` (`id_buku`),
  ADD KEY `FK_pengembalian3` (`student_nim`);

--
-- Indexes for table `staff`
--
ALTER TABLE `staff`
  ADD PRIMARY KEY (`staff_id`);

--
-- Indexes for table `student`
--
ALTER TABLE `student`
  ADD PRIMARY KEY (`student_nim`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `peminjaman`
--
ALTER TABLE `peminjaman`
  MODIFY `id_pinjam` int(10) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `pengembalian`
--
ALTER TABLE `pengembalian`
  MODIFY `id_kembali` int(10) NOT NULL AUTO_INCREMENT;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `peminjaman`
--
ALTER TABLE `peminjaman`
  ADD CONSTRAINT `FK_peminjaman` FOREIGN KEY (`student_nim`) REFERENCES `student` (`student_nim`) ON UPDATE CASCADE,
  ADD CONSTRAINT `FK_peminjaman2` FOREIGN KEY (`id_buku`) REFERENCES `buku` (`id_buku`) ON UPDATE CASCADE;

--
-- Constraints for table `pengembalian`
--
ALTER TABLE `pengembalian`
  ADD CONSTRAINT `FK_pengembalian` FOREIGN KEY (`id_pinjam`) REFERENCES `peminjaman` (`id_pinjam`) ON UPDATE CASCADE,
  ADD CONSTRAINT `FK_pengembalian2` FOREIGN KEY (`id_buku`) REFERENCES `buku` (`id_buku`) ON UPDATE CASCADE,
  ADD CONSTRAINT `FK_pengembalian3` FOREIGN KEY (`student_nim`) REFERENCES `student` (`student_nim`) ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
