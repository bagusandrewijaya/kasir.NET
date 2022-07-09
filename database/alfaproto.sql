-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3309
-- Generation Time: Jul 09, 2022 at 12:34 PM
-- Server version: 5.7.31
-- PHP Version: 7.3.21

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `alfaproto`
--

DELIMITER $$
--
-- Procedures
--
DROP PROCEDURE IF EXISTS `add_jenis`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `add_jenis` (`nama_jns` VARCHAR(25))  BEGIN
   insert into jenis_produk(nama_jenis) values (nama_jns);
END$$

DROP PROCEDURE IF EXISTS `delete_produk`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `delete_produk` (`kd_brg` VARCHAR(25))  BEGIN
   delete from produk where id_produk = kd_brg;
END$$

DROP PROCEDURE IF EXISTS `generate_kd_brg`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `generate_kd_brg` ()  BEGIN
   Select COUNT(id_produk)+1 as id_produk from produk;
END$$

DROP PROCEDURE IF EXISTS `genereate_Strk`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `genereate_Strk` ()  BEGIN
  Select count(struk)+1 as struk from header_transaksi;
END$$

DROP PROCEDURE IF EXISTS `get_data`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `get_data` (`nostrk` VARCHAR(25))  BEGIN
 Select a.id_transaksi,b.nama_produk,b.harga,a.jumlah_beli from header_transaksi a,produk b where a.struk=nostrk and a.id_produk=b.id_produk order by id_transaksi desc;

END$$

DROP PROCEDURE IF EXISTS `insert_trxheader`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_trxheader` (`strk` VARCHAR(25), `idprdk` VARCHAR(25), `jumlahbli` INT)  BEGIN
insert into header_transaksi(struk,id_produk,jumlah_beli) values(strk,idprdk,jumlahbli);

END$$

DROP PROCEDURE IF EXISTS `jenis_prod`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `jenis_prod` ()  BEGIN
   SELECT nama_jenis
    FROM jenis_produk;
END$$

DROP PROCEDURE IF EXISTS `loginAdmin`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `loginAdmin` (`uname` VARCHAR(25), `pword` VARCHAR(25))  BEGIN
    SELECT *
    FROM ADMIN
    WHERE username = uname and password = pword;

END$$

DROP PROCEDURE IF EXISTS `selesaikan_trx`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `selesaikan_trx` (`strk` VARCHAR(25), `ttlblnja` INT, `pmbyr` INT, `pyment` VARCHAR(25))  BEGIN
insert into transaksi_final( struk, total_belanja, payment,pembayaran, kembalian) values(strk,ttlblnja,pyment,pmbyr,(pembayaran-total_belanja));

END$$

DROP PROCEDURE IF EXISTS `tambah_payment`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `tambah_payment` (`py` VARCHAR(25))  BEGIN
   insert into method_payment values (py);

END$$

DROP PROCEDURE IF EXISTS `tambah_product`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `tambah_product` (`id_prod` VARCHAR(100), `nm_product` VARCHAR(50), `nm_jenis` VARCHAR(25), `stk` INT, `harga_brg` INT)  BEGIN
   insert into produk(id_produk,nama_produk, nama_jenis, stok,harga) values (id_prod,nm_product,nm_jenis,stk,harga_brg);
END$$

DROP PROCEDURE IF EXISTS `tambah_Stok`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `tambah_Stok` (`up_Stok` INT, `idprdk` VARCHAR(100))  BEGIN
insert into update_Stok(id_produk, stok_tambah) values(idprdk,up_Stok);

END$$

DROP PROCEDURE IF EXISTS `tampil_jumlah_produk`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `tampil_jumlah_produk` ()  BEGIN
   Select COUNT(id_produk) as id_produk from produk;
END$$

DROP PROCEDURE IF EXISTS `tampil_jumlah_Trx`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `tampil_jumlah_Trx` ()  BEGIN
 select * from transaksi_final;

END$$

DROP PROCEDURE IF EXISTS `tampil_payment`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `tampil_payment` ()  BEGIN
 select * from method_payment;

END$$

DROP PROCEDURE IF EXISTS `tampil_product`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `tampil_product` ()  BEGIN
   SELECT *
    FROM produk;
END$$

DROP PROCEDURE IF EXISTS `total_pemasukan`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `total_pemasukan` ()  BEGIN
 select sum(total_belanja) as total  from transaksi_final;

END$$

DROP PROCEDURE IF EXISTS `update_product`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `update_product` (`nm_product` VARCHAR(50), `nm_jenis` VARCHAR(25), `stk` INT, `harga_brg` INT, `id_prod` VARCHAR(100))  BEGIN
   UPDATE produk
SET nama_produk = nm_product, nama_jenis = nm_jenis,stok = stk,harga = harga_brg WHERE id_produk = id_prod;
END$$

DROP PROCEDURE IF EXISTS `update_trx`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `update_trx` (`nm_product` VARCHAR(50), `jmlbli` INT, `idtrx` INT)  BEGIN
   UPDATE header_transaksi
SET id_produk = nm_product , jumlah_beli=jmlbli
    where id_transaksi = idtrx;
END$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `admin`
--

DROP TABLE IF EXISTS `admin`;
CREATE TABLE IF NOT EXISTS `admin` (
  `id_admin` int(11) NOT NULL AUTO_INCREMENT,
  `username` varchar(25) NOT NULL,
  `password` varchar(25) NOT NULL,
  `gender` set('P','L') NOT NULL,
  `alamat` varchar(100) NOT NULL,
  PRIMARY KEY (`id_admin`)
) ENGINE=MyISAM AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `admin`
--

INSERT INTO `admin` (`id_admin`, `username`, `password`, `gender`, `alamat`) VALUES
(1, 'andre', 'wijaya', 'P', 'kab bogor kampung salak jalan condet rt01/02');

-- --------------------------------------------------------

--
-- Table structure for table `header_transaksi`
--

DROP TABLE IF EXISTS `header_transaksi`;
CREATE TABLE IF NOT EXISTS `header_transaksi` (
  `id_transaksi` int(11) NOT NULL AUTO_INCREMENT,
  `struk` varchar(500) NOT NULL,
  `id_produk` varchar(100) DEFAULT NULL,
  `jumlah_beli` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_transaksi`),
  KEY `id_produk` (`id_produk`)
) ENGINE=InnoDB AUTO_INCREMENT=40 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `header_transaksi`
--

INSERT INTO `header_transaksi` (`id_transaksi`, `struk`, `id_produk`, `jumlah_beli`) VALUES
(1, 'INV', 'BRG-1', 2),
(2, 'INV-2', 'BRG-1', 10),
(3, 'INV-3', 'BRG-1', 2),
(5, 'INV-4', 'BRG-1', 2),
(6, 'INV-4', 'BRG-2', 5),
(7, 'INV-6', 'BRG-2', 1),
(8, 'INV-7', 'BRG-1', 2),
(9, 'INV-8', 'BRG-1', 2),
(10, 'INV-8', 'BRG-2', 5),
(11, 'INV-8', 'BRG-3', 1),
(12, 'INV-11', 'BRG-1', 2),
(13, 'INV-12', 'BRG-1', 2),
(14, 'INV-13', 'BRG-3', 3),
(15, 'INV-14', 'BRG-1', 2),
(16, 'INV-14', 'BRG-3', 1),
(17, 'INV-16', 'BRG-1', 2),
(18, 'INV-17', 'BRG-2', 1),
(19, 'INV-18', 'BRG-2', 2),
(20, 'INV-19', 'BRG-1', 1),
(21, 'INV-20', 'BRG-1', 2),
(22, 'INV-21', 'BRG-1', 2),
(23, 'INV-21', 'BRG-2', 1),
(24, 'INV-23', 'BRG-1', 2),
(25, 'INV-23', 'BRG-2', 1),
(26, 'INV-25', 'BRG-2', 2),
(27, 'INV-25', 'BRG-3', 1),
(28, 'INV-27', 'BRG-1', 2),
(29, 'INV-27', 'BRG-3', 1),
(30, 'INV-29', 'BRG-1', 2),
(31, 'INV-30', 'BRG-1', 1),
(32, 'INV-31', 'BRG-1', 2),
(33, 'INV-31', 'BRG-3', 1),
(34, 'INV-33', 'BRG-1', 2),
(35, 'INV-33', 'BRG-3', 1),
(36, 'INV-33', 'BRG-4', 2),
(37, 'INV-36', 'BRG-1', 2),
(38, 'INV-36', 'BRG-3', 1),
(39, 'INV-36', 'BRG-4', 1);

--
-- Triggers `header_transaksi`
--
DROP TRIGGER IF EXISTS `update_Stok`;
DELIMITER $$
CREATE TRIGGER `update_Stok` BEFORE INSERT ON `header_transaksi` FOR EACH ROW BEGIN
	update produk set stok=stok-New.jumlah_beli where id_produk=New.id_produk;
    END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `jenis_produk`
--

DROP TABLE IF EXISTS `jenis_produk`;
CREATE TABLE IF NOT EXISTS `jenis_produk` (
  `id_jenis` int(11) NOT NULL AUTO_INCREMENT,
  `nama_jenis` varchar(25) NOT NULL,
  PRIMARY KEY (`id_jenis`),
  UNIQUE KEY `nama_jenis` (`nama_jenis`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `jenis_produk`
--

INSERT INTO `jenis_produk` (`id_jenis`, `nama_jenis`) VALUES
(1, 'Bahan Masakan'),
(2, 'kecantikan'),
(4, 'Peralatan Rumah');

-- --------------------------------------------------------

--
-- Table structure for table `method_payment`
--

DROP TABLE IF EXISTS `method_payment`;
CREATE TABLE IF NOT EXISTS `method_payment` (
  `payment` varchar(25) NOT NULL,
  PRIMARY KEY (`payment`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `method_payment`
--

INSERT INTO `method_payment` (`payment`) VALUES
('Cash'),
('E-wallet'),
('Kartu Debit');

-- --------------------------------------------------------

--
-- Table structure for table `produk`
--

DROP TABLE IF EXISTS `produk`;
CREATE TABLE IF NOT EXISTS `produk` (
  `id_produk` varchar(100) NOT NULL,
  `nama_produk` varchar(50) NOT NULL,
  `nama_jenis` varchar(25) DEFAULT NULL,
  `stok` int(11) NOT NULL,
  `harga` int(11) NOT NULL,
  PRIMARY KEY (`id_produk`),
  KEY `nama_jenis` (`nama_jenis`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `produk`
--

INSERT INTO `produk` (`id_produk`, `nama_produk`, `nama_jenis`, `stok`, `harga`) VALUES
('BRG-1', 'Bawang Merah FP', 'Bahan Masakan', 92, 32000),
('BRG-2', 'Tepung Segitiga Biru', 'Bahan Masakan', 103, 15000),
('BRG-3', 'Bawang Putih', 'Bahan Masakan', 200, 31000),
('BRG-4', 'Gula Merah', 'Bahan Masakan', 117, 6000);

-- --------------------------------------------------------

--
-- Table structure for table `transaksi_final`
--

DROP TABLE IF EXISTS `transaksi_final`;
CREATE TABLE IF NOT EXISTS `transaksi_final` (
  `id_transaki_final` int(11) NOT NULL AUTO_INCREMENT,
  `payment` varchar(25) DEFAULT NULL,
  `struk` varchar(100) DEFAULT NULL,
  `total_belanja` int(11) DEFAULT NULL,
  `pembayaran` int(11) DEFAULT NULL,
  `kembalian` int(11) DEFAULT NULL,
  `data_transaksi` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id_transaki_final`),
  KEY `payment` (`payment`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `transaksi_final`
--

INSERT INTO `transaksi_final` (`id_transaki_final`, `payment`, `struk`, `total_belanja`, `pembayaran`, `kembalian`, `data_transaksi`) VALUES
(1, 'E-wallet', 'INV-8', 25000, 50000, 25000, '2022-07-09 09:27:36'),
(2, 'E-wallet', 'INV-20', 64000, 100000, 36000, '2022-07-09 09:27:36'),
(3, 'E-wallet', 'INV-21', 79000, 100000, 21000, '2022-07-09 09:27:36'),
(4, 'E-wallet', 'INV-23', 79000, 100000, 21000, '2022-07-09 09:27:36'),
(5, 'E-wallet', 'INV-25', 61000, 100000, 39000, '2022-07-09 09:27:36'),
(6, 'E-wallet', 'INV-27', 95000, 100000, 5000, '2022-07-09 09:27:36'),
(7, 'E-wallet', 'INV-29', 64000, 100000, 36000, '2022-07-09 09:27:36'),
(8, 'E-wallet', 'INV-30', 32000, 50000, 18000, '2022-07-09 09:27:36'),
(9, 'E-wallet', 'INV-31', 95000, 100000, 5000, '2022-07-09 09:27:36'),
(10, 'Cash', 'INV-33', 107000, 150000, 43000, '2022-07-09 11:03:05'),
(11, 'Cash', 'INV-33', 107000, 150000, 43000, '2022-07-09 11:05:40'),
(12, 'Cash', 'INV-33', 107000, 150000, 43000, '2022-07-09 11:06:10'),
(13, 'E-wallet', 'INV-36', 101000, 120000, 19000, '2022-07-09 11:07:37');

-- --------------------------------------------------------

--
-- Table structure for table `update_stok`
--

DROP TABLE IF EXISTS `update_stok`;
CREATE TABLE IF NOT EXISTS `update_stok` (
  `id_produk` varchar(100) DEFAULT NULL,
  `stok_tambah` int(11) DEFAULT NULL,
  `tanggal_tambah` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  KEY `id_produk` (`id_produk`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `update_stok`
--

INSERT INTO `update_stok` (`id_produk`, `stok_tambah`, `tanggal_tambah`) VALUES
('BRG-2', 10, '2022-07-09 09:30:13'),
('BRG-2', 10, '2022-07-09 09:30:13'),
('BRG-1', 12, '2022-07-09 09:30:13'),
('BRG-3', 5, '2022-07-09 09:30:13');

--
-- Triggers `update_stok`
--
DROP TRIGGER IF EXISTS `tamba_Stok`;
DELIMITER $$
CREATE TRIGGER `tamba_Stok` BEFORE INSERT ON `update_stok` FOR EACH ROW BEGIN
	UPDATE produk SET stok=stok+new.stok_tambah
    WHERE id_produk=New.id_produk;
    END
$$
DELIMITER ;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `header_transaksi`
--
ALTER TABLE `header_transaksi`
  ADD CONSTRAINT `header_transaksi_ibfk_1` FOREIGN KEY (`id_produk`) REFERENCES `produk` (`id_produk`);

--
-- Constraints for table `produk`
--
ALTER TABLE `produk`
  ADD CONSTRAINT `produk_ibfk_1` FOREIGN KEY (`nama_jenis`) REFERENCES `jenis_produk` (`nama_jenis`);

--
-- Constraints for table `transaksi_final`
--
ALTER TABLE `transaksi_final`
  ADD CONSTRAINT `transaksi_final_ibfk_1` FOREIGN KEY (`payment`) REFERENCES `method_payment` (`payment`);

--
-- Constraints for table `update_stok`
--
ALTER TABLE `update_stok`
  ADD CONSTRAINT `update_stok_ibfk_1` FOREIGN KEY (`id_produk`) REFERENCES `produk` (`id_produk`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
