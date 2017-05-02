-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: May 11, 2016 at 02:50 PM
-- Server version: 10.1.10-MariaDB
-- PHP Version: 7.0.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `sanpham`
--

-- --------------------------------------------------------

--
-- Table structure for table `members`
--

CREATE TABLE `members` (
  `id` int(11) NOT NULL,
  `username` varchar(20) COLLATE utf8_unicode_ci NOT NULL,
  `password` varchar(20) COLLATE utf8_unicode_ci NOT NULL,
  `email` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `cauhoi` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `traloi` varchar(20) COLLATE utf8_unicode_ci NOT NULL,
  `tenhienthi` varchar(12) COLLATE utf8_unicode_ci NOT NULL,
  `diachi` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `sdt` int(11) NOT NULL,
  `state` int(11) NOT NULL DEFAULT '1'
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `members`
--

INSERT INTO `members` (`id`, `username`, `password`, `email`, `cauhoi`, `traloi`, `tenhienthi`, `diachi`, `sdt`, `state`) VALUES
(1, 'admin', 'admin', '', '', '', '', '', 0, 2),
(2, 'kaijun', 'kaijun', '', '', '', '', '', 0, 1),
(3, 'jink', 'jink', 'jink@gmail.com', 'Nơi sinh của bạn ?', 'tphcm', 'Jin', 'TP HCM', 90520, 1),
(4, 'test2', '123456', '123456@gmail.com', 'Nơi sinh của bạn ?', 'tphcm', 'Tester', '41fushahhf', 2147483647, 1),
(6, 'test1', '123456', 'test1@gmail.com', 'Nơi sinh của bạn ?', 'tphcm', 'Jinnnn', '4y2873hfdj', 49236482, 1),
(9, '432423', '123', '123124@gmail.com', 'Nơi sinh của bạn ?', '56786876', '8678', '78979789', 78978987, 1),
(10, '123', '123', '123124@gmail.com', 'Nơi sinh của bạn ?', '123', '123', '123', 123, 1),
(11, '12345', '12345', '123124@gmail.com', 'Nơi sinh của bạn ?', '123', '123', '12312', 123, 1),
(12, 'ththth', 'thth', 'thth@gmail.com', 'Nơi sinh của bạn ?', 'th', 'th', 'th', 0, 1),
(13, '3r', '123', 'fsefsef@gmail.com', 'Nơi sinh của bạn ?', '213', '1231', '231123', 124, 1),
(16, '1234234235345', '123', '123124@gmail.com', 'Con vật bạn ghét nhất ?', '123123123123', '123123123', '1212312312', 1212321312, 1),
(18, '324dasdasdawaw', '123', '123456@gmail.com', 'Con vật bạn yêu thích ?', '213123123123123', '123123123123', '123123123', 2147483647, 1),
(19, '41234rdfsaedfsa', '123', '123456@gmail.com', 'Nơi sinh của bạn ?', '12312312', '3123213', '213213', 21321321, 1),
(21, 'fasfsdg231', '123', '123124@gmail.com', 'Nơi sinh của bạn ?', 'sadasd', 'dasdas', 'dsadasdsad', 542342, 1),
(24, '123424rawdaw', '123', 'macdinhdinh@yahoo.com', 'Nơi sinh của bạn ?', '123421423', '41323123123', '123123123', 2342342, 1),
(39, '12421dad', '123', '123456@gmail.com', 'Nơi sinh của bạn ?', '1231231', '2321312', '312321321', 12312, 1),
(41, '432141243', '123', '123124@gmail.com', 'Nơi sinh của bạn ?', '4123', '312312', '3213123', 12321321, 1),
(43, '42fsad12231', '123', '341234@gmail.com', 'Nơi sinh của bạn ?', '4213423', '2131231', '312312312', 321321, 1),
(44, '1dasda', '123', '123124@gmail.com', 'Nơi sinh của bạn ?', '3123', '4324', '43241', 123123, 1),
(45, '12edwqd', '123', '123124@gmail.com', 'Nơi sinh của bạn ?', '3124321423', '12312', '423453', 12312123, 1),
(46, 'q12dw1', '123', '123456@gmail.com', 'Con vật bạn ghét nhất ?', '123123', '123123213', '123123213', 312321, 1),
(47, '231423', '123', '123456@gmail.com', 'Nơi sinh của bạn ?', '12312', '3123123', '12312312', 312321, 1),
(48, '21ed1', '123', '123124@gmail.com', 'Con vật bạn yêu thích ?', '12312', '34123123', '321312', 312321, 1),
(49, '123123', '123', '123124@gmail.com', 'Nơi sinh của bạn ?', '12312', '3123123213', '21312312', 31232132, 1),
(50, '41234123', '123', '123124@gmail.com', 'Nơi sinh của bạn ?', '3412', '123123123123', '3123123', 1231231, 1),
(51, '12312', '123', '123124@gmail.com', 'Nơi sinh của bạn ?', '21321321321', '3123123123', '21321321', 312312312, 1),
(52, '123432432asdas', 'asd', '123124@gmail.com', 'Nơi sinh của bạn ?', 'dsad', 'asdfds', 'asdsada', 0, 1),
(54, '21341sadas', '123', '123124@gmail.com', 'Nơi sinh của bạn ?', '3241324', '2423', '4324234', 234324, 1),
(55, '2dasdfsdg12', '123', '123124@gmail.com', 'Nơi sinh của bạn ?', '23423', '4234', '423423423', 423423, 1),
(57, '213fase', '123', '123124@gmail.com', 'Nơi sinh của bạn ?', '213123', '21321', '312312321', 321312, 1),
(59, '13dfsada', '123', '123124@gmail.com', 'Nơi sinh của bạn ?', '123123', '123123123123', '12312321312312312', 312312321, 1),
(62, '123123432', 'asdf', '123124@gmail.com', 'Nơi sinh của bạn ?', '12313', '123123123123', '321321', 32131231, 1),
(65, 'qeds', '123a', '123456@gmail.com', 'Nơi sinh của bạn ?', '543524', '2343214', '325345', 34534534, 1);

-- --------------------------------------------------------

--
-- Table structure for table `products`
--

CREATE TABLE `products` (
  `masp` int(11) NOT NULL,
  `tensp` varchar(100) COLLATE utf8_unicode_ci DEFAULT NULL,
  `loaisp` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `soluong` int(11) DEFAULT NULL,
  `giasp` int(10) UNSIGNED DEFAULT NULL,
  `thongso` varchar(500) COLLATE utf8_unicode_ci DEFAULT NULL,
  `link` varchar(150) COLLATE utf8_unicode_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `products`
--

INSERT INTO `products` (`masp`, `tensp`, `loaisp`, `soluong`, `giasp`, `thongso`, `link`) VALUES
(1, 'CPU Core I3 - 3240 (3.4GHz)', 'CPU', 10, 2650000, 'Series: Intel - Core i3\r\nCodename (Tên mã): Intel - Ivy Bridge\r\nSocket type (Loại Socket): Intel - Socket 1155\r\nManufacturing Technology (Công nghệ sản xuất): 22 nm\r\nCPU Speed (Tốc độ CPU): 3.40 GHz\r\nGraphics Frequency (MHz): 0\r\nMax Thermal Design Power (Công suất tiêu thụ tối đa): 55 W', 'link/CPU_i3_3.jpg'),
(2, 'CPU Pentium G4400 (3.3GHz)', 'CPU', 10, 1560000, 'Series: Intel - Pentium\r\nCodename (Tên mã): Intel - Skylake\r\nSocket type (Loại Socket): Intel - Socket LGA 1151\r\nManufacturing Technology (Công nghệ sản xuất): 14 nm\r\nCPU Speed (Tốc độ CPU): 3.30 GHz\r\nBus Speed / HyperTransport: 5.0 GT/s (5000 MT/s - 2.5Gb/s)\r\nGraphics Frequency (MHz): 350\r\nMax Thermal Design Power (Công suất tiêu thụ tối đa): 51 W', 'link/CPU_pentium.jpg'),
(3, 'CPU Core I3-4160 (3.6GHz)', 'CPU', 10, 2625000, 'Series: Intel - Core i3\r\nCodename (Tên mã): Intel - Haswell\r\nSocket type (Loại Socket): Intel - Socket LGA 1150\r\nManufacturing Technology (Công nghệ sản xuất): 22 nm\r\nCPU Speed (Tốc độ CPU): 3.60 GHz\r\nBus Speed / HyperTransport: 5.0 GT/s (5000MT/s - 2.5Gb/s)\r\nGraphics Frequency (MHz): 350\r\nMax Thermal Design Power (Công suất tiêu thụ tối đa): 65 W', 'link/CPU_i3.jpg'),
(4, 'CPU Core I3-6100 (3.7GHz)', 'CPU', 10, 2700000, 'Series: Intel - Core i3\r\nCodename (Tên mã): Intel - Skylake\r\nSocket type (Loại Socket): Intel - Socket LGA 1151\r\nManufacturing Technology (Công nghệ sản xuất): 14 nm\r\nCPU Speed (Tốc độ CPU): 3.70 GHz\r\nBus Speed / HyperTransport: 8 GT/s\r\nGraphics Frequency (MHz): 350\r\nMax Thermal Design Power (Công suất tiêu thụ tối đa): 51 W', 'link/CPU_i3_2.jpg'),
(5, 'CPU Pentium Dual-G3250 (3.2GHz)', 'CPU', 10, 1260000, 'Series: Intel - Pentium\r\nCodename (Tên mã): Intel - Haswell\r\nSocket type (Loại Socket): Intel - Socket LGA 1150\r\nManufacturing Technology (Công nghệ sản xuất): 22 nm\r\nCPU Speed (Tốc độ CPU): 3.20 GHz\r\nBus Speed / HyperTransport: 5.0 GT/s (5000 MT/s - 2.5Gb/s)\r\nGraphics Frequency (MHz): 350\r\nMax Thermal Design Power (Công suất tiêu thụ tối đa): 53 W', 'link/CPU_pentium2.jpg'),
(6, 'CPU Pentium Dual-G3258 (3.2GHz)', 'CPU', 10, 1580000, 'Series: Intel - Pentium Dual-Core\r\nCodename (Tên mã): Intel - Haswell\r\nSocket type (Loại Socket): Intel - Socket LGA 1150\r\nManufacturing Technology (Công nghệ sản xuất): 22 nm\r\nCPU Speed (Tốc độ CPU): 3.20 GHz\r\nBus Speed / HyperTransport: 5.0 GT/s (5000 MT/s - 2.5Gb/s)\r\nGraphics Frequency (MHz): 350\r\nMax Thermal Design Power (Công suất tiêu thụ tối đa): 53 W', 'link/CPU_pentium.jpg'),
(7, 'CPU Core I5-6600K (3.5GHz)', 'CPU', 10, 5880000, 'Series: Intel - Core i5\r\nCodename (Tên mã): Intel - Skylake\r\nSocket type (Loại Socket): Intel - Socket LGA 1151\r\nManufacturing Technology (Công nghệ sản xuất): 14 nm\r\nCPU Speed (Tốc độ CPU): 3.50 GHz\r\nBus Speed / HyperTransport: 8 GT/s\r\nGraphics Frequency (MHz): 350\r\nMax Thermal Design Power (Công suất tiêu thụ tối đa): 95 W', 'link/CPU_i5.jpg'),
(8, 'CPU Core I5-6500 (3.2GHz)', 'CPU', 10, 4880000, 'Series: Intel - Core i5\r\nCodename (Tên mã): Intel - Skylake\r\nSocket type (Loại Socket): Intel - Socket LGA 1151\r\nManufacturing Technology (Công nghệ sản xuất): 14 nm\r\nCPU Speed (Tốc độ CPU): 3.20 GHz\r\nBus Speed / HyperTransport: 8 GT/s\r\nGraphics Frequency (MHz): 350\r\nMax Thermal Design Power (Công suất tiêu thụ tối đa): 65 W', 'link/CPU_i5.jpg'),
(9, 'CPU Core I7-6700 (3.4GHz)', 'CPU', 10, 7550000, 'Series: Intel - Core i7\r\nCodename (Tên mã): Intel - Skylake\r\nSocket type (Loại Socket): Intel - Socket LGA 1151\r\nManufacturing Technology (Công nghệ sản xuất): 14 nm\r\nCPU Speed (Tốc độ CPU): 3.40 GHz\r\nBus Speed / HyperTransport: 8 GT/s\r\nGraphics Frequency (MHz): 350\r\nMax Thermal Design Power (Công suất tiêu thụ tối đa): 65 W', 'link/CPU_i7.jpg'),
(10, 'CPU Core I7-4790K (4.0GHz)', 'CPU', 10, 8440000, 'Series: Intel - Core i7\r\nCodename (Tên mã): Intel - Haswell\r\nSocket type (Loại Socket): Intel - Socket LGA 1150\r\nManufacturing Technology (Công nghệ sản xuất): 22 nm\r\nCPU Speed (Tốc độ CPU): 4.00 GHz\r\nBus Speed / HyperTransport: 5.0 GT/s (5000 MT/s - 2.5Gb/s)\r\nGraphics Frequency (MHz): 350\r\nMax Thermal Design Power (Công suất tiêu thụ tối đa): 88 W', 'link/CPU_i7_2.jpg'),
(11, 'CPU Xeon Quad-CoreE3-1220V3 (3.1GHz)', 'CPU', 10, 4900000, 'Series: Intel\r\nCodename (Tên mã): Intel - Haswell\r\nSocket type (Loại Socket): Intel - Socket LGA 1150\r\nManufacturing Technology (Công nghệ sản xuất): 22 nm\r\nCPU Speed (Tốc độ CPU): 3.10 GHz\r\nBus Speed / HyperTransport: 5 GT/s\r\nGraphics Frequency (MHz): 350\r\nMax Thermal Design Power (Công suất tiêu thụ tối đa): 80 W', 'link/CPU_xeon.jpg'),
(12, 'Ram G.Skill RipjawsX 8GB DDR3 Bus 2400MHz', 'RAM', 10, 1254000, 'Hãng sản xuất: G.SKILL\r\nDòng Memory: DDR3 PC3-19200\r\nDung lượng: 8GB (2x4GB)\r\nSerial: RipjawsX', 'link/ramddr3.jpg'),
(13, 'Ram Kingston Hyper X Fury 8GB DDR3 Bus 1600MHz', 'RAM', 10, 1070000, 'Hãng sản xuất: KINGMOST\r\nDòng Memory: DDR3 PC3-12800\r\nDung lượng: 8GB\r\nSerial: HyperX Fury Black', 'link/ramddr3_2.jpg'),
(14, 'Ram Kingston Hyper X Fury 4GB DDR3 Bus 1600MHz', 'RAM', 10, 570000, 'Hãng sản xuất: KINGMOST\r\nDòng Memory: DDR3 PC3-12800\r\nDung lượng: 4GB\r\nSerial: HyperX Fury Blue\r\n', 'link/ramddr3_3.png'),
(15, 'Ram G.Skill Kit 4GB (2x2GB) DDR3 Bus 1866MHz', 'RAM', 10, 820000, 'Hãng sản xuất: G.SKILL\r\nDòng Memory: DDR3 PC3-14900\r\nDung lượng: 4GB (2x2GB)\r\nSerial: RipjawsX', 'link/ramddr3_5.png'),
(16, 'Ram Kingston Hyper X Fury 8GB DDR3 Bus 1600MHz', 'RAM', 10, 1140000, 'Hãng sản xuất: KINGMOST\r\nDòng Memory: DDR3 PC3-12800\r\nDung lượng: 8GB (2x4GB)\r\nSerial: HyperX Fury Black', 'link/ramddr3_6.png'),
(17, 'Ram G.Skill 2GB DDR3 Bus 1600MHz', 'RAM', 10, 296000, 'Hãng sản xuất: G.SKILL\r\nDòng Memory: DDR3 PC3-12800\r\nDung lượng: 2GB\r\nSerial: RipjawsX', 'link/ramddr3_7.jpg'),
(18, 'Ram Corsair 4GB DDR3 Bus 1333MHz', 'RAM', 10, 570000, 'Hãng sản xuất: CORSAIR\r\nDòng Memory: DDR3 PC3-10600\r\nDung lượng: 4GB', 'link/ramddr3_8.jpg'),
(19, 'Ram Corsair 8GB DDR3 Bus 1600MHz', 'RAM', 10, 1270000, 'Hãng sản xuất: CORSAIR\r\nDòng Memory: DDR3 PC3-12800\r\nDung lượng: 8GB\r\nSerial: Vengeance LPX', 'link/ramddr3_9.jpg'),
(20, 'Ram Corsair DDR4 8GB (2x4GB) Bus 2400MHz', 'RAM', 10, 1580000, 'Hãng sản xuất: CORSAIR\r\nDòng Memory: DDR4 PC4-19200\r\nDung lượng: 8GB (2x4GB)\r\nSerial: Vengeance LPX', 'link/ramddr4.jpg'),
(21, 'Ram Kingston 2GB DDR3 Bus 1600MHz (8 chip)', 'RAM', 10, 290000, 'Hãng sản xuất: KINGSTON\r\nDòng Memory: DDR3 PC3-12800\r\nDung lượng: 2GB', 'link/ramddr3_10.jpg'),
(22, 'Ram Kingston 4GB DDR3 Bus 1600MHz (8 chip)', 'RAM', 10, 480000, 'Hãng sản xuất: KINGSTON\r\nDòng Memory: DDR3 PC3-12800\r\nDung lượng: 4GB', 'link/ramddr3_11.jpg'),
(23, 'VGA Zotac 2GB GeForce GTX960', 'VGA', 5, 4650000, 'Manufacture (Hãng sản xuất): ZOTAC\r\nChipset: NVIDIA - GeForce GTX 960\r\nMemory Type (Kiểu bộ nhớ): GDDR5\r\nMemory Size (Dung lượng bộ nhớ): 2048MB\r\nMemory Interface (Giao tiếp bộ nhớ): 128-bit\r\nMax Resolution (Độ phân giải tối đa): 4096 x 2160\r\nConnectors (Cổng giao tiếp): HDMI, VGA (D-sub), DVI, Display Port (Mini DP), DVI-D, DVI-I\r\nTechnologies Support (Công nghệ hỗ trợ): SLI, PhysX, Adaptive VSync', 'link/vga.jpg'),
(24, 'VGA Gigabyte 2GB GeForce GTX950', 'VGA', 5, 4440000, 'Manufacture (Hãng sản xuất): GIGABYTE\r\nChipset: NVIDIA - GeForce GTX 950\r\nMemory Type (Kiểu bộ nhớ): GDDR5\r\nMemory Size (Dung lượng bộ nhớ): 2048MB\r\nMemory Interface (Giao tiếp bộ nhớ): 128-bit\r\nMax Resolution (Độ phân giải tối đa): 4096 x 2160\r\nConnectors (Cổng giao tiếp): HDMI, DVI-I, Display Port (Mini DP), DVI-D\r\nTechnologies Support (Công nghệ hỗ trợ): SLI, PhysX, CUDA, Adaptive VSync, DirectX 12', 'link/vga_2.jpg'),
(25, 'VGA Gigabyte 1GB GeForce 210 GPU', 'VGA', 5, 836000, 'Manufacture (Hãng sản xuất): GIGABYTE\r\nChipset: NVIDIA - GeForce 210\r\nMemory Type (Kiểu bộ nhớ): GDDR3\r\nMemory Size (Dung lượng bộ nhớ): 1024MB\r\nMemory Interface (Giao tiếp bộ nhớ): 64-bit\r\nMax Resolution (Độ phân giải tối đa): 2560 x 1600\r\nConnectors (Cổng giao tiếp): HDMI, VGA (D-sub), DVI, HDCP\r\nTechnologies Support (Công nghệ hỗ trợ): HDCP, PureVideo HD, CUDA', 'link/vga_3.jpg'),
(26, 'VGA Msi 1GB N750 1GD5/OCV1', 'VGA', 5, 27590000, 'Manufacture (Hãng sản xuất): MSI\r\nChipset: NVIDIA - GeForce GTX 750\r\nMemory Type (Kiểu bộ nhớ): GDDR5\r\nMemory Size (Dung lượng bộ nhớ): 1024MB\r\nMemory Interface (Giao tiếp bộ nhớ): 128-bit\r\nMax Resolution (Độ phân giải tối đa): 2560 x 1600\r\nConnectors (Cổng giao tiếp): HDMI, VGA (D-sub), DVI-D\r\nTechnologies Support (Công nghệ hỗ trợ): SLI, 3D Vision Surround', 'link/vga_4.jpg'),
(27, 'VGA Galaxy 1GB GTX750-OC PCI-E', 'VGA', 5, 2500000, 'Manufacture (Hãng sản xuất): GALAXY\r\nChipset: NVIDIA - GeForce GTX 750 Ti\r\nMemory Type (Kiểu bộ nhớ): GDDR5\r\nMemory Size (Dung lượng bộ nhớ): 1024MB\r\nMemory Interface (Giao tiếp bộ nhớ): 128-bit\r\nMax Resolution (Độ phân giải tối đa): 2560 x 1600\r\nConnectors (Cổng giao tiếp): HDMI, VGA (D-sub), DVI, HDCP\r\nTechnologies Support (Công nghệ hỗ trợ): HDCP, PhysX, CUDA, 3D Vision Surround', 'link/vga_5.jpg'),
(28, 'VGA Zotac 1GB GTX730', 'VGA', 5, 1490000, 'Manufacture (Hãng sản xuất): ZOTAC\r\nChipset: NVIDIA - GeForce GTX 730\r\nMemory Type (Kiểu bộ nhớ): GDDR5\r\nMemory Size (Dung lượng bộ nhớ): 1024MB\r\nMemory Interface (Giao tiếp bộ nhớ): 64-bit\r\nMax Resolution (Độ phân giải tối đa): 1920 x 1080\r\nConnectors (Cổng giao tiếp): HDMI, VGA (D-sub), Mini-HDMI\r\nTechnologies Support (Công nghệ hỗ trợ): -', 'link/vga_6.jpg'),
(29, 'VGA Zotac 2GB GTX950 OC', 'VGA', 5, 4250000, 'Manufacture (Hãng sản xuất): ZOTAC\r\nChipset: NVIDIA - GeForce GTX 950 Ti\r\nMemory Type (Kiểu bộ nhớ): GDDR5\r\nMemory Size (Dung lượng bộ nhớ): 2048MB\r\nMemory Interface (Giao tiếp bộ nhớ): 128-bit\r\nMax Resolution (Độ phân giải tối đa): 2560 x 1600\r\nConnectors (Cổng giao tiếp): DVI x 2, Mini-HDMI\r\nTechnologies Support (Công nghệ hỗ trợ): CrossfireX, PhysX, PureVideo HD, CUDA, 3D Vision Surround', 'link/vga_8.jpg'),
(30, 'VGA Msi 2GB N750 Ti TF2GD5/OCV1', 'VGA', 5, 37990000, 'Manufacture (Hãng sản xuất): MSI\r\nChipset: NVIDIA - GeForce GTX 750 Ti\r\nMemory Type (Kiểu bộ nhớ): DDR5\r\nMemory Size (Dung lượng bộ nhớ): 2048MB\r\nMemory Interface (Giao tiếp bộ nhớ): 128-bit\r\nMax Resolution (Độ phân giải tối đa): 2048 x 1536\r\nConnectors (Cổng giao tiếp): DVI\r\nTechnologies Support (Công nghệ hỗ trợ): Crossfire', 'link/vga_9.jpg'),
(31, 'VGA Asus 2GB GT730-2GD3', 'VGA', 5, 1540000, 'Manufacture (Hãng sản xuất): ASUS\r\nChipset: NVIDIA - GeForce GT 730\r\nMemory Type (Kiểu bộ nhớ): DDR3\r\nMemory Size (Dung lượng bộ nhớ): 2048MB\r\nMemory Interface (Giao tiếp bộ nhớ): 128-bit\r\nMax Resolution (Độ phân giải tối đa): 2560 x 1600\r\nConnectors (Cổng giao tiếp): HDMI, VGA (D-sub), DVI\r\nTechnologies Support (Công nghệ hỗ trợ): -', 'link/vga_7.jpg'),
(32, 'USB Kingmax 8GB UDrive PD07', 'USB', 10, 83000, 'Dung lượng bộ nhớ: 8GB\r\nChuẩn USB: 2.0\r\nTốc độ đọc (MB/s): 21\r\nTốc độ ghi (MB/s): 10', 'link/usb1.jpg'),
(33, 'USB Kingmax 8GB UDrive UI01', 'USB', 10, 125000, 'Dung lượng bộ nhớ: 8GB\r\nChuẩn USB: 2.0\r\nTốc độ đọc (MB/s): 21\r\nTốc độ ghi (MB/s): 10', 'link/usb2.jpg'),
(34, 'USB Apacer 8GB AH223', 'USB', 10, 80000, 'Dung lượng bộ nhớ: 8GB\r\nChuẩn USB: 2.0\r\nTốc độ đọc (MB/s): 21\r\nTốc độ ghi (MB/s): 10', 'link/usb3.jpg'),
(35, 'USB 8GB HP V210W', 'USB', 10, 120000, 'Dung lượng bộ nhớ: 8GB\r\nChuẩn USB: 2.0\r\nTốc độ đọc (MB/s): 31\r\nTốc độ ghi (MB/s): 10', 'link/usb4.jpg'),
(36, 'USB 8GB HP V165W', 'USB', 10, 93000, 'Dung lượng bộ nhớ: 8GB\r\nChuẩn USB: 2.0\r\nTốc độ đọc (MB/s): 31\r\nTốc độ ghi (MB/s): 10', 'link/usb5.jpg'),
(37, 'USB Kingmax 8GB UDrive PD03', 'USB', 10, 83000, 'Dung lượng bộ nhớ: 8GB\r\nChuẩn USB: 2.0\r\nTốc độ đọc (MB/s): 21\r\nTốc độ ghi (MB/s): 10', 'link/usb6.jpg'),
(38, 'USB Addlink 8GB U10B2 (Xanh)', 'USB', 10, 69000, 'Dung lượng bộ nhớ: 8GB\r\nChuẩn USB: 2.0\r\nTốc độ đọc (MB/s): 21\r\nTốc độ ghi (MB/s): 10', 'link/usb7.jpg'),
(39, 'USB Addlink 8GB U10G2 (Xám)', 'USB', 10, 69000, 'Dung lượng bộ nhớ: 8GB\r\nChuẩn USB: 2.0\r\nTốc độ đọc (MB/s): 21\r\nTốc độ ghi (MB/s): 10', 'link/usb8.jpg'),
(40, 'USB 8GB Kingston DT100G3', 'USB', 10, 100000, 'Dung lượng bộ nhớ: 8GB\r\nChuẩn USB: 3.0\r\nTốc độ đọc (MB/s): 25\r\nTốc độ ghi (MB/s): 10', 'link/usb9.jpg'),
(41, 'Loa Soundmax A130/2.0 (Đỏ)', 'Loa máy tính', 10, 127000, 'Công suất: 6W\r\nĐáp ứng tần số: 50Hz ~ 20KHz\r\nTỷ số nén nhiễu: >70 dB\r\nNguồn: USB 5V DC', 'link/loa1.jpg'),
(42, 'Loa Soundmax C11 (Đen)', 'Loa máy tính', 10, 380000, 'Công suất: 18W\r\nChống nhiễm từ : Có\r\nTỷ số nén nhiễu: >75 dB\r\nNguồn: 220V AC ~ 50Hz', 'link/loa2.jpg'),
(43, 'Loa Soundmax A120/2.0 (Trắng)', 'Loa máy tính', 10, 156000, 'Công suất: 10W\r\nĐáp ứng tần số: 20Hz - 20KHz\r\nTỷ số nén nhiễu: >40dB\r\nNguồn: USB 5V DC', 'link/loa3.jpg'),
(44, 'Loa Soundmax AW 100', 'Loa máy tính', 10, 140000, 'Công suất: 80W\r\nĐáp ứng tần số: 20Hz - 20KHz\r\nTỷ số nén nhiễu: >75dB\r\nNguồn: 220V AC ~ 50Hz\r\nChống nhiễm từ : Có', 'link/loa4.jpg'),
(45, 'Loa Soundmax A150/2.0', 'Loa máy tính', 10, 224000, 'Công suất: 10W\r\nĐáp ứng tần số: 90Hz ~ 16kHz\r\nTỷ số nén nhiễu: >70 dB\r\nNguồn: 220V ~ 50Hz\r\nChống nhiễm từ : Có', 'link/loa5.jpg'),
(46, 'Loa Soundmax A8800/4.1', 'Loa máy tính', 10, 1087000, 'Công suất: 90W\r\nĐáp ứng tần số: 30Hz ~ 18kHz\r\nTỷ số nén nhiễu: >75 dB\r\nNguồn: 220V AC ~ 50Hz\r\nChống nhiễm từ : Có\r\nChức năng karaoke: Có', 'link/loa6.jpg'),
(47, 'Loa Soundmax A820/2.1', 'Loa máy tính', 10, 500000, 'Công suất: 25W\r\nĐáp ứng tần số: 45Hz ~ 18kHz\r\nTỷ số nén nhiễu: >75 dB\r\n220V AC ~ 50Hz\r\nChống nhiễm từ : Có', 'link/loa7.jpg'),
(48, 'Loa Genius SP Q120 (Vàng)', 'Loa máy tính', 10, 99000, 'Công suất: 3W\r\nĐáp ứng tần số: 200Hz ~ 18kHz\r\nĐiều chỉnh âm lượng: Có\r\nSạc nguồn qua: Cổng USB\r\nHệ điều hành tương thích: Windows 7 / Vista / 2000 / XP', 'link/loa8.jpg'),
(49, 'Loa Microlab M109 (2.1)', 'Loa máy tính', 10, 470000, 'Công suất: 16W\r\nĐáp ứng tần số: 50Hz ~ 20KHz\r\nTỷ số nén nhiễu: >60 dB\r\nNguồn: 220V AC ~ 50Hz', 'link/loa9.jpg'),
(50, 'Loa Soundmax A2100/2.1', 'Loa máy tính', 10, 915000, 'Công suất: 60W\r\nChống nhiễm từ : Có\r\nTỷ số nén nhiễu: >75 dB\r\nNguồn: 220V AC ~ 50Hz\r\nĐiều chỉnh âm thanh: Echo, Mic.Vol, Bass, Treble, Volume', 'link/loa10.jpg'),
(51, 'Tai nghe Ovann X1', 'Tai nghe', 10, 130000, 'Hãng sản xuất: OVANN\r\nKiểu tai nghe: Kiểu chụp đầu\r\nDùng cho loại máy: Máy nghe nhạc Mp3 , Mp4, Máy tính, Tivi, DVD\r\nDải tần số: 20Hz - 20kHz\r\nĐộ nhạy: 101dB\r\nNguồn: 30mW', 'link/hp.jpg'),
(52, 'Tai nghe Logitech H150 Trắng', 'Tai nghe', 10, 295000, 'Kiểu tai nghe: Kiểu chụp đầu\r\nDùng cho loại máy: Máy tính, Laptop\r\nDải tần số: 20Hz - 20kHz\r\nĐộ nhạy: 122dB\r\nNguồn: 30mW', 'link/hp1.jpg'),
(53, 'Tai nghe Microlab E130', 'Tai nghe', 10, 205000, 'Kiểu tai nghe: Kiểu chụp đầu\r\nDùng cho loại máy: Máy tính, Laptop\r\nDải tần số: 20Hz - 20kHz\r\nĐộ nhạy: 122dB\r\nNguồn: 30mW', 'link/hp2.jpg'),
(54, 'Tai nghe Ovann 5004', 'Tai nghe', 10, 135000, 'Hãng sản xuất: OVANN\r\nKiểu tai nghe: Kiểu chụp đầu\r\nDùng cho loại máy: Máy tính, Laptop\r\nDải tần số: 20Hz - 20kHz\r\nĐộ nhạy: 101dB\r\nNguồn: 30mW', 'link/hp3.jpg'),
(55, 'Tai nghe Microlab K290', 'Tai nghe', 10, 270000, 'Kiểu tai nghe: Kiểu chụp đầu\r\nDùng cho loại máy: Máy tính, Laptop\r\nDải tần số: 20Hz - 20kHz\r\nĐộ nhạy: 122dB\r\nNguồn: 30mW', 'link/hp4.jpg'),
(56, 'Tai nghe Microlab K280', 'Tai nghe', 10, 260000, 'Kiểu tai nghe: Kiểu chụp đầu\r\nDùng cho loại máy: Máy tính, Laptop\r\nDải tần số: 20Hz - 20kHz\r\nĐộ nhạy: 122dB\r\nNguồn: 30mW', 'link/hp5.jpg'),
(57, 'Tai nghe Microlab K270', 'Tai nghe', 10, 230000, 'Kiểu tai nghe: Kiểu chụp đầu\r\nDùng cho loại máy: Máy tính, Laptop\r\nDải tần số: 20Hz - 20kHz\r\nĐộ nhạy: 122dB\r\nNguồn: 30mW', 'link/hp6.jpg'),
(58, 'Tai nghe Microlab K260', 'Tai nghe', 10, 180000, 'Kiểu tai nghe: Kiểu chụp đầu\r\nDùng cho loại máy: Máy tính, Laptop\r\nDải tần số: 20Hz - 20kHz\r\nĐộ nhạy: 122dB\r\nNguồn: 30mW', 'link/hp7.jpg'),
(59, 'Tai nghe Ovann X4', 'Tai nghe', 10, 190000, 'Hãng sản xuất: OVANN\r\nKiểu tai nghe: Kiểu chụp đầu\r\nDùng cho loại máy: Máy tính, Laptop\r\nDải tần số: 20Hz - 20kHz\r\nĐộ nhạy: 101dB\r\nNguồn: 30mW', 'link/hp8.jpg');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `members`
--
ALTER TABLE `members`
  ADD PRIMARY KEY (`id`,`username`),
  ADD UNIQUE KEY `username` (`username`);

--
-- Indexes for table `products`
--
ALTER TABLE `products`
  ADD PRIMARY KEY (`masp`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `members`
--
ALTER TABLE `members`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=66;
--
-- AUTO_INCREMENT for table `products`
--
ALTER TABLE `products`
  MODIFY `masp` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=60;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
