-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Máy chủ: 127.0.0.1
-- Thời gian đã tạo: Th2 23, 2021 lúc 05:01 AM
-- Phiên bản máy phục vụ: 10.1.38-MariaDB
-- Phiên bản PHP: 7.1.28

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Cơ sở dữ liệu: `dolphin`
--

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `categories`
--

CREATE TABLE `categories` (
  `Id` char(36) NOT NULL,
  `UpdatedDate` datetime(6) DEFAULT NULL,
  `UpdatedById` char(50) NOT NULL,
  `CreatedDate` datetime(6) DEFAULT NULL,
  `CreatedById` char(50) NOT NULL,
  `Name` longtext CHARACTER SET utf8mb4 NOT NULL,
  `Description` longtext CHARACTER SET utf8mb4
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Đang đổ dữ liệu cho bảng `categories`
--

INSERT INTO `categories` (`Id`, `UpdatedDate`, `UpdatedById`, `CreatedDate`, `CreatedById`, `Name`, `Description`) VALUES
('02a6b9f2-956f-4943-b10f-298606107b76', NULL, '85913f7d-7e38-4782-8df1-00122229d04f', '2020-12-11 11:02:32.141767', '85913f7d-7e38-4782-8df1-00122229d04f', 'Váy', 'Váy nữ đẹp'),
('729ab5f5-3230-461a-80ab-4f900dae1455', NULL, '85913f7d-7e38-4782-8df1-00122229d04f', '2020-12-11 11:02:49.299998', '85913f7d-7e38-4782-8df1-00122229d04f', 'Giày', 'Giày đẹp'),
('d0be2ab2-ecd6-44dc-9e35-06161e83382e', NULL, '85913f7d-7e38-4782-8df1-00122229d04f', '2020-12-14 14:54:26.987650', '85913f7d-7e38-4782-8df1-00122229d04f', 'Xu hướng', 'Xu hướng thời trang mới');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `comments`
--

CREATE TABLE `comments` (
  `UserId` char(50) NOT NULL,
  `ProductId` char(36) NOT NULL,
  `Description` longtext CHARACTER SET utf8mb4,
  `CreatedTime` datetime(6) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `news`
--

CREATE TABLE `news` (
  `Id` int(11) NOT NULL,
  `UpdatedDate` datetime(6) DEFAULT NULL,
  `UpdatedById` char(50) NOT NULL,
  `CreatedDate` datetime(6) DEFAULT NULL,
  `CreatedById` char(50) NOT NULL,
  `Titile` longtext CHARACTER SET utf8mb4,
  `Images` longtext CHARACTER SET utf8mb4,
  `Description` longtext CHARACTER SET utf8mb4,
  `Refer` longtext CHARACTER SET utf8mb4
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `orderdetails`
--

CREATE TABLE `orderdetails` (
  `OrderId` char(36) NOT NULL,
  `ProductId` char(36) NOT NULL,
  `Quantity` int(11) NOT NULL,
  `UnitPrice` longtext CHARACTER SET utf8mb4,
  `OrdersId` char(36) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Đang đổ dữ liệu cho bảng `orderdetails`
--

INSERT INTO `orderdetails` (`OrderId`, `ProductId`, `Quantity`, `UnitPrice`, `OrdersId`) VALUES
('013f1ad0-c24d-4dbf-8be0-36416b438f3e', '34f5e36a-e8d0-48aa-88a7-389538dc5fbd', 1, '288000', NULL),
('400e62c8-5aca-45e3-aa37-6de10db9ece2', 'bc93c583-f185-4f03-b1b8-e0f6219c8978', 1, '137000', NULL),
('4528212b-b8ee-4330-8b22-809efb9f4997', '6836c32f-125a-4424-a99e-f771d042f28d', 1, '351000', NULL),
('575809e8-a652-453e-a230-f19d53c828a6', '1d5dc88f-e13d-4373-8e9b-fb133dd64564', 1, '395000', NULL),
('5b0ba855-f85d-46eb-a9f3-37947cddc179', '1d5dc88f-e13d-4373-8e9b-fb133dd64564', 1, '395000', NULL),
('5bed985a-42d3-4295-bc03-3a9b86ba0fa9', '1d5dc88f-e13d-4373-8e9b-fb133dd64564', 1, '395000', NULL),
('78c71d81-d24c-4fb6-ab0a-1565fee0d6b6', '1d5dc88f-e13d-4373-8e9b-fb133dd64564', 1, '395000', NULL),
('946a3392-f4fe-4c41-9c03-54da73e5837d', '2429ba60-916f-4287-b6cc-3e8398e34bdf', 1, '150000', NULL),
('a87d90d8-6c86-44e1-984d-d6695b634caf', 'bc93c583-f185-4f03-b1b8-e0f6219c8978', 3, '137000', NULL),
('b4dc30e8-5318-4cdc-8dc9-2f2c7fba53ff', '2429ba60-916f-4287-b6cc-3e8398e34bdf', 1, '150000', NULL),
('c19464b8-e40a-4b5a-9e5f-102ac5b22dc2', '2429ba60-916f-4287-b6cc-3e8398e34bdf', 2, '150000', NULL),
('e7ea95ca-01bf-4cf4-ad04-0eee10c89d1c', '2429ba60-916f-4287-b6cc-3e8398e34bdf', 1, '150000', NULL);

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `orders`
--

CREATE TABLE `orders` (
  `Id` char(36) NOT NULL,
  `UpdatedDate` datetime(6) DEFAULT NULL,
  `UpdatedById` char(50) NOT NULL,
  `CreatedDate` datetime(6) DEFAULT NULL,
  `CreatedById` char(50) NOT NULL,
  `UserId` longtext CHARACTER SET utf8mb4,
  `Amount` int(11) NOT NULL,
  `Address` longtext CHARACTER SET utf8mb4,
  `Phone` longtext CHARACTER SET utf8mb4,
  `OrderStatusCode` int(11) NOT NULL,
  `GHNRef` longtext CHARACTER SET utf8mb4,
  `CustomerName` longtext CHARACTER SET utf8mb4,
  `ExpectedDeliveryTime` datetime(6) NOT NULL DEFAULT '0001-01-01 00:00:00.000000',
  `OrderCode` longtext CHARACTER SET utf8mb4
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Đang đổ dữ liệu cho bảng `orders`
--

INSERT INTO `orders` (`Id`, `UpdatedDate`, `UpdatedById`, `CreatedDate`, `CreatedById`, `UserId`, `Amount`, `Address`, `Phone`, `OrderStatusCode`, `GHNRef`, `CustomerName`, `ExpectedDeliveryTime`, `OrderCode`) VALUES
('013f1ad0-c24d-4dbf-8be0-36416b438f3e', NULL, '33e23a3f-973a-497f-aa92-5228b04057a3', NULL, '33e23a3f-973a-497f-aa92-5228b04057a3', '33e23a3f-973a-497f-aa92-5228b04057a3', 0, '124 Ngo Quyen, Quang Trung, Ha Dong, Ha Noi', '0988678789', 0, 'fb0cbf00-d4ec-4e77-a27b-25f0472d6b88', 'Minh Ngọc', '2020-12-18 16:00:00.000000', 'ZNXNB'),
('400e62c8-5aca-45e3-aa37-6de10db9ece2', NULL, '33e23a3f-973a-497f-aa92-5228b04057a3', NULL, '33e23a3f-973a-497f-aa92-5228b04057a3', '33e23a3f-973a-497f-aa92-5228b04057a3', 0, '14 Quang Trung, Ha Dong, Ha Noi', '0988765489', 0, 'da36383b-8b1d-4df3-9caa-3661a4b8198f', 'Hoa Hoài', '2020-12-18 16:00:00.000000', 'ZNX64'),
('4528212b-b8ee-4330-8b22-809efb9f4997', NULL, '33e23a3f-973a-497f-aa92-5228b04057a3', NULL, '33e23a3f-973a-497f-aa92-5228b04057a3', '33e23a3f-973a-497f-aa92-5228b04057a3', 0, '243 Nguyễn Trãi, Thanh Xuân, Hà Nội', '0988765489', 0, 'f2647557-b3cb-44ad-aa31-ff78c1ac45df', 'Mai Anh', '2020-12-18 16:00:00.000000', 'ZNX62'),
('575809e8-a652-453e-a230-f19d53c828a6', NULL, '33e23a3f-973a-497f-aa92-5228b04057a3', NULL, '33e23a3f-973a-497f-aa92-5228b04057a3', '33e23a3f-973a-497f-aa92-5228b04057a3', 0, '124 Ngo Quyen, Quang Trung, Ha Dong, Ha Noi', '0988614827', 0, '5cdea158-6ed5-41c5-864f-010df399e424', 'Mai Hà', '2020-12-17 16:00:00.000000', 'ZNXD0'),
('5b0ba855-f85d-46eb-a9f3-37947cddc179', NULL, '33e23a3f-973a-497f-aa92-5228b04057a3', NULL, '33e23a3f-973a-497f-aa92-5228b04057a3', '33e23a3f-973a-497f-aa92-5228b04057a3', 0, '4 Ngo Quyen, Quang Trung, Ha Dong, Ha Noi', '0366765876', 0, 'c4851907-ea06-4282-9327-c97d0bb8c467', 'Nguyen Anh', '2020-12-16 16:00:00.000000', 'ZNXFR'),
('5bed985a-42d3-4295-bc03-3a9b86ba0fa9', NULL, '33e23a3f-973a-497f-aa92-5228b04057a3', NULL, '33e23a3f-973a-497f-aa92-5228b04057a3', '33e23a3f-973a-497f-aa92-5228b04057a3', 0, '124 Ngo Quyen, Quang Trung, Ha Dong, Ha Noi', '0355977774', 0, '16da0657-2ca9-468f-bd12-28b32f09686f', 'Nguyen Quang', '2020-12-18 16:00:00.000000', 'ZN8DO'),
('78c71d81-d24c-4fb6-ab0a-1565fee0d6b6', NULL, '33e23a3f-973a-497f-aa92-5228b04057a3', NULL, '33e23a3f-973a-497f-aa92-5228b04057a3', '33e23a3f-973a-497f-aa92-5228b04057a3', 0, '124 Ngo Quyen, Quang Trung, Ha Dong, Ha Noi', '0988765489', 0, 'cf70a188-b08c-4e2a-8cd3-a78e7aaad4ce', 'Nguyen Quang', '2020-12-16 16:00:00.000000', 'ZNXFE'),
('946a3392-f4fe-4c41-9c03-54da73e5837d', NULL, '33e23a3f-973a-497f-aa92-5228b04057a3', NULL, '33e23a3f-973a-497f-aa92-5228b04057a3', '33e23a3f-973a-497f-aa92-5228b04057a3', 0, 'GoldSilk, 24 Vạn Phúc, Hà Đông, Hà Nội', '0988567547', 0, '751c1b03-45d2-4f50-a85c-347313ad67b2', 'Thái Hoàng Anh', '2020-12-05 16:00:00.000000', 'ZNNB3'),
('a87d90d8-6c86-44e1-984d-d6695b634caf', NULL, '33e23a3f-973a-497f-aa92-5228b04057a3', NULL, '33e23a3f-973a-497f-aa92-5228b04057a3', '33e23a3f-973a-497f-aa92-5228b04057a3', 0, '124 Ngo Quyen, Quang Trung, Ha Dong, Ha Noi', '0355977774', 0, 'af2fecff-130e-47e4-ba55-0353316a3850', 'Nguyen Quang', '2020-12-18 16:00:00.000000', 'ZNXN5'),
('b4dc30e8-5318-4cdc-8dc9-2f2c7fba53ff', NULL, '33e23a3f-973a-497f-aa92-5228b04057a3', NULL, '33e23a3f-973a-497f-aa92-5228b04057a3', '33e23a3f-973a-497f-aa92-5228b04057a3', 0, '275 Nguyễn Trãi, Thanh Xuân, Hà Nội', '0988614827', 0, 'ba89c0eb-9101-4808-9e24-c05fdf69d4a0', 'Ngọc Ánh', '0001-01-01 00:00:00.000000', NULL),
('c19464b8-e40a-4b5a-9e5f-102ac5b22dc2', NULL, '33e23a3f-973a-497f-aa92-5228b04057a3', NULL, '33e23a3f-973a-497f-aa92-5228b04057a3', '33e23a3f-973a-497f-aa92-5228b04057a3', 0, '98 Ngô Quyền, Hoàn Kiếm, Hà Nội', '0988765489', 0, 'b9c6f625-fab9-48ca-b49f-bc147676ba36', 'Minh Nguyên', '0001-01-01 00:00:00.000000', NULL),
('e7ea95ca-01bf-4cf4-ad04-0eee10c89d1c', NULL, '33e23a3f-973a-497f-aa92-5228b04057a3', NULL, '33e23a3f-973a-497f-aa92-5228b04057a3', '33e23a3f-973a-497f-aa92-5228b04057a3', 0, '298 Ngo Quyen, Quang Trung, Ha Dong, Ha Noi', '0988765489', 0, '5c7333e5-9596-4ed1-999e-f3024f280972', 'Giao Phạm', '2020-12-09 16:00:00.000000', 'ZNS6J');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `permissions`
--

CREATE TABLE `permissions` (
  `Id` bigint(20) NOT NULL,
  `Name` longtext CHARACTER SET utf8mb4,
  `Description` longtext CHARACTER SET utf8mb4
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Đang đổ dữ liệu cho bảng `permissions`
--

INSERT INTO `permissions` (`Id`, `Name`, `Description`) VALUES
(1, 'Dashboard View', 'Truy cập trang tổng quan'),
(2, 'Product Edit', NULL),
(3, 'Product Edit', 'Quản lý sản phẩm');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `productdetails`
--

CREATE TABLE `productdetails` (
  `Id` char(36) NOT NULL,
  `ProductId` char(36) NOT NULL,
  `Size` longtext CHARACTER SET utf8mb4,
  `Color` longtext CHARACTER SET utf8mb4
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `products`
--

CREATE TABLE `products` (
  `Id` char(36) NOT NULL,
  `UpdatedDate` datetime(6) DEFAULT NULL,
  `UpdatedById` char(50) NOT NULL,
  `CreatedDate` datetime(6) DEFAULT NULL,
  `CreatedById` char(50) NOT NULL,
  `CategoryId` char(36) NOT NULL,
  `ProductName` longtext CHARACTER SET utf8mb4,
  `Price` longtext CHARACTER SET utf8mb4,
  `Images` longtext CHARACTER SET utf8mb4,
  `Desciption` longtext CHARACTER SET utf8mb4,
  `Status` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Đang đổ dữ liệu cho bảng `products`
--

INSERT INTO `products` (`Id`, `UpdatedDate`, `UpdatedById`, `CreatedDate`, `CreatedById`, `CategoryId`, `ProductName`, `Price`, `Images`, `Desciption`, `Status`) VALUES
('182535d5-c145-44a3-ba5e-2e60a64825d8', NULL, '33e23a3f-973a-497f-aa92-5228b04057a3', '2020-12-14 14:08:18.655962', '33e23a3f-973a-497f-aa92-5228b04057a3', '729ab5f5-3230-461a-80ab-4f900dae1455', 'SANDAL THẮT NƠ 2 QUAI GD212', '288000', 'ed1eb0fe-9976-43a2-83af-f0fee481fa6e_179b140720201416051602.jpg', 'Sandal thắt nơ 2 quai  Mã Sản Phẩm: GD212 - Màu Sắc: Đen - Giá Bán: 480.000vnđ - Chất Liệu: Da PU Tổng Hợp ( Phối Vân Da Cá Sấu) - Chiều Cao: 5CM - Số Size: 35, 36, 37, 38, 39', 0),
('1d5dc88f-e13d-4373-8e9b-fb133dd64564', NULL, '33e23a3f-973a-497f-aa92-5228b04057a3', '2020-12-11 11:06:55.514030', '33e23a3f-973a-497f-aa92-5228b04057a3', '02a6b9f2-956f-4943-b10f-298606107b76', 'CHÂN VÁY XẾP LY VA11287', '395000', '1974bae2-9737-42de-a8f7-e386fa32e833_11286vhai271120201839312165.jpg', 'Chân váy xếp ly  Mã Sản Phẩm: VA11287 - Màu Sắc: Vàng-Xanh - Giá Bán: 395,000vnđ - Số Đo Bụng: 66CM - Chiều Dài Chân Váy: 51CM - Số Đo Mông: 90CM - Chất Liệu Vải: Dạ Lông - Không Giãn - Không Có Túi - Có 2 Lớp', 0),
('2080832a-dd1d-4ecb-8818-4c44750ec176', NULL, '33e23a3f-973a-497f-aa92-5228b04057a3', '2020-12-16 14:27:54.175624', '33e23a3f-973a-497f-aa92-5228b04057a3', 'd0be2ab2-ecd6-44dc-9e35-06161e83382e', 'CHÂN VÁY XẾP LY VA11287', '395000', '8a1e92e5-b49b-4372-83d3-497042dfdc97_616-677m110620200955549092.jpg', 'Chân váy xếp ly  Mã Sản Phẩm: VA11287 - Màu Sắc: Vàng-Xanh - Giá Bán: 395,000vnđ - Số Đo Bụng: 66CM - Chiều Dài Chân Váy: 51CM - Số Đo Mông: 90CM - Chất Liệu Vải: Dạ Lông - Không Giãn - Không Có Túi - Có 2 Lớp', 0),
('32d99b49-cfab-404d-a4df-f2e421ee98c5', NULL, '33e23a3f-973a-497f-aa92-5228b04057a3', '2020-12-14 14:56:31.856972', '33e23a3f-973a-497f-aa92-5228b04057a3', 'd0be2ab2-ecd6-44dc-9e35-06161e83382e', 'ĐẦM TAY LOE PHỐI HOA DA682', '247000', 'ea1a78b5-a5ab-4dc7-87be-73f9123f2911_682m080620200934029349.jpg', 'Đầm tay loe phối hoa  Mã Sản Phẩm: DA682 - Màu Sắc Sản Phẩm: VÀNG - Giá Bán Sản Phẩm: 495.000đ - Số Đo Vòng Ngực: 84CM - Số Đo Vòng Eo: 63CM - Số Đo Ngang Vai: 33CM - Chiều Dài Váy: 104CM - Chiều Dài Tay: 24CM - Thông Tin Sản Phẩm Size: XS - Chất Liệu Vải: LỤA TUYẾT - Số Size: XS - S - M - L - XL - Đầm Có 2 Lớp - Đầm Có Túi', 0),
('34f5e36a-e8d0-48aa-88a7-389538dc5fbd', NULL, '33e23a3f-973a-497f-aa92-5228b04057a3', '2020-12-14 14:01:43.761395', '33e23a3f-973a-497f-aa92-5228b04057a3', '729ab5f5-3230-461a-80ab-4f900dae1455', 'SANDAL THẮT NƠ EO GD213', '288000', '09835a4f-528b-49a3-b41d-e25112ea1c6d_178140720201404568166.jpg', 'Sandal thắt nơ eo  Mã Sản Phẩm: GD213 Tên Sản Phẩm: Sandal Thắt Nơ Eo Màu Sắc: Đen Giá Bán: 480.000vnđ Chất Liệu: Da PU Tổng Hợp ( Bóng ) Độ Cao: 8CM Kích Cỡ: 35-36-37-38-39', 0),
('3e61f509-ad36-4311-bc6e-2157d21cc208', NULL, '33e23a3f-973a-497f-aa92-5228b04057a3', '2020-12-14 17:38:17.652095', '33e23a3f-973a-497f-aa92-5228b04057a3', '729ab5f5-3230-461a-80ab-4f900dae1455', 'GIÀY MŨI NHỌN ', '150000', 'b37ec146-131c-4493-b2f3-0ff0a725b5d8_196den191120201635182523.jpg', 'Giày mũi nhọn phối quai  Mã Sản Phẩm: GD190 - Màu Sắc: TRẮNG, NUDE - Giá Bán: 480.000đ - Chất Liệu: Da PU Tổng Hợp ( Vân Cá Sấu Bóng) - Cao: 6CM - Số Size: 35, 36, 37, 38, 39', 0),
('543d291a-86b6-4031-ac56-5fb3165949b3', NULL, '33e23a3f-973a-497f-aa92-5228b04057a3', '2020-12-14 17:30:13.543550', '33e23a3f-973a-497f-aa92-5228b04057a3', '729ab5f5-3230-461a-80ab-4f900dae1455', 'GIÀY BÍT DÂY KIỂU GD204', '288000', '4043e56a-f2d9-45ac-a478-ebe8083fcdba_199201120201320536470.jpg', 'Giày mũi nhọn phối quai  Mã Sản Phẩm: GD190 - Màu Sắc: TRẮNG, NUDE - Giá Bán: 480.000đ - Chất Liệu: Da PU Tổng Hợp ( Vân Cá Sấu Bóng) - Cao: 6CM - Số Size: 35, 36, 37, 38, 39', 0),
('6836c32f-125a-4424-a99e-f771d042f28d', NULL, '33e23a3f-973a-497f-aa92-5228b04057a3', '2020-12-11 11:04:46.440427', '33e23a3f-973a-497f-aa92-5228b04057a3', '02a6b9f2-956f-4943-b10f-298606107b76', 'ÁO VEST LỬNG AA1267', '351000', '193559ec-b7a4-483f-8b2d-bf5d02b02e33_64101220201517203835.jpg', 'Áo vest lửng  Mã Sản Phẩm: AA1267 - Tên Sản Phẩm: Áo Vest Lửng - Giá Bán: 390.000vnđ - Màu Sắc: Xanh - Số Đo Ngực: 92CM - Số Đo Lai: 78CM - Số Đo Hạ V: 29CM - Số Đo Vai: 38CM - Số Đo Dài Tay: 58CM - Số Đo Cửa Tay: 22CM - Chiều Dài Áo: 44CM - Thông Số Size S - Chất Liệu Vải: Bố Cotton - Áo Có 1 Lớp - Không Có Túi', 0),
('7f57e4d6-ac97-4cd2-adf7-c81527258a77', NULL, '33e23a3f-973a-497f-aa92-5228b04057a3', '2020-12-14 14:09:32.647978', '33e23a3f-973a-497f-aa92-5228b04057a3', '729ab5f5-3230-461a-80ab-4f900dae1455', 'GIÀY BÍT DÂY KIỂU GD204', '288000', 'd1a7047d-54ae-46b4-a92c-99ebfcb96a73_198trang201120201507283422.jpg', 'Sandal thắt nơ eo  Mã Sản Phẩm: GD243 Tên Sản Phẩm: Sandal Thắt Nơ Eo Màu Sắc: Đen Giá Bán: 480.000vnđ Chất Liệu: Da PU Tổng Hợp ( Bóng ) Độ Cao: 8CM Kích Cỡ: 35-36-37-38-39', 0),
('8f47540c-69e8-47df-bd00-14c88347354a', NULL, '33e23a3f-973a-497f-aa92-5228b04057a3', '2020-12-14 17:23:33.855558', '33e23a3f-973a-497f-aa92-5228b04057a3', '729ab5f5-3230-461a-80ab-4f900dae1455', 'GIÀY MŨI NHỌN PHỐI QUAI GD190', '288000', '77ce3c9e-28e1-4ac5-a875-d1d94e984f76_193h171020201426391582.jpg', 'Giày mũi nhọn phối quai  Mã Sản Phẩm: GD190 - Màu Sắc: TRẮNG, NUDE - Giá Bán: 480.000đ - Chất Liệu: Da PU Tổng Hợp ( Vân Cá Sấu Bóng) - Cao: 6CM - Số Size: 35, 36, 37, 38, 39', 0),
('9bdf1fd0-60cb-4882-a6c8-641585424b21', NULL, '33e23a3f-973a-497f-aa92-5228b04057a3', '2020-12-14 17:29:35.770809', '33e23a3f-973a-497f-aa92-5228b04057a3', '729ab5f5-3230-461a-80ab-4f900dae1455', 'SANDAL THẮT NƠ EO GD403', '288000', '32ffc3e7-5366-4996-91d8-7b36abf5fe57_bcc0e321d29a2fc4768b4140720201144449633.jpg', 'Giày mũi nhọn phối quai  Mã Sản Phẩm: GD233 - Màu Sắc: TRẮNG, NUDE - Giá Bán: 480.000đ - Chất Liệu: Da PU Tổng Hợp ( Vân Cá Sấu Bóng) - Cao: 6CM - Số Size: 35, 36, 37, 38, 39', 0),
('c18e6241-af64-4ca3-9971-4e7b0e048092', NULL, '33e23a3f-973a-497f-aa92-5228b04057a3', '2020-12-11 11:08:03.774200', '33e23a3f-973a-497f-aa92-5228b04057a3', '02a6b9f2-956f-4943-b10f-298606107b76', 'VÁY JEAN XẺ LAI VJA9240', '260000', '313e9248-745e-40cf-bdb3-a0c660075f71_11277dau021220201346324685.jpg', 'Váy jean xẻ lai  Mã Sản Phẩm: VJA9240 - Màu Sắc: Xanh - Giá Bán: 520.000vnđ - Chiều Dài Chân Váy: 46CM - Số Đo Rộng Bụng: 33CM - Số Đo Rộng Mông: 42CM - Số Đo Rộng Gấu: 39.5CM - Thông Số Size S - Chất Liệu Vải: Sợi cotton pha spendex', 0),
('d5d2eb67-c2a6-49c8-b250-5ef8b708b5e0', NULL, '33e23a3f-973a-497f-aa92-5228b04057a3', '2020-12-14 14:55:40.266219', '33e23a3f-973a-497f-aa92-5228b04057a3', 'd0be2ab2-ecd6-44dc-9e35-06161e83382e', 'QUẦN SHORT GIẢ VÁY ĐẮP QA683', '142500', 'd414d373-b6aa-4170-a406-be6d57fc956b_683m110620201532248721.jpg', 'Quần short giả váy đắp  Mã Sản Phẩm: QA683 - Màu Sắc Sản Phẩm: CARO - Giá Bán Sản Phẩm: 285.000đ - Số Đo Vòng Eo: 63CM - Số Đo Vòng Mông: 84CM - Chiều Dài Quần: 33CM - Thông Tin Sản Phẩm Size: XS - Chất Liệu Vải: BỐ COTTON - Số Size: XS - S - M - L - XL', 0),
('dd6e9218-c09d-4416-a807-55f43025119b', NULL, '33e23a3f-973a-497f-aa92-5228b04057a3', '2020-12-14 14:47:43.206065', '33e23a3f-973a-497f-aa92-5228b04057a3', '729ab5f5-3230-461a-80ab-4f900dae1455', 'SANDAL MŨI VUÔNG GD201', '288000', '1a33ccb0-3ba3-4404-9096-56f653c07290_201h201120201547489727.jpg', 'THÔNG TIN SẢN PHẨM Sandal mũi vuông  Mã Sản Phẩm: GD201 Tên Sản Phẩm: Sandal Mũi Vuông Màu Sắc: Trắng-Đen Giá Bán: 480.000vnđ Chất Liệu: Da PU Tổng Hợp ( Họa Tiết Vân Sợi Đan ) Độ Cao: 5CM Kích Cỡ: 35-36-37-38-39', 0);

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `rolepermissions`
--

CREATE TABLE `rolepermissions` (
  `PermissionId` bigint(20) NOT NULL,
  `RoleId` char(36) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `roles`
--

CREATE TABLE `roles` (
  `Id` char(36) NOT NULL,
  `UpdatedDate` datetime(6) DEFAULT NULL,
  `UpdatedById` char(50) NOT NULL,
  `CreatedDate` datetime(6) DEFAULT NULL,
  `CreatedById` char(50) NOT NULL,
  `Name` longtext CHARACTER SET utf8mb4,
  `Description` longtext CHARACTER SET utf8mb4
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Đang đổ dữ liệu cho bảng `roles`
--

INSERT INTO `roles` (`Id`, `UpdatedDate`, `UpdatedById`, `CreatedDate`, `CreatedById`, `Name`, `Description`) VALUES
('45525c09-975c-413d-854e-73a5dcfa1eda', NULL, '33e23a3f-973a-497f-aa92-5228b04057a3', '2020-12-14 15:49:13.625559', '33e23a3f-973a-497f-aa92-5228b04057a3', 'Staff', 'Nhân viên hệ thống'),
('69fa7f90-ce84-4282-a8da-bc7473948e96', NULL, '33e23a3f-973a-497f-aa92-5228b04057a3', '2020-12-14 15:48:08.634170', '33e23a3f-973a-497f-aa92-5228b04057a3', 'Admin', 'Quản lý toàn bộ hệ thống'),
('fc251456-1b19-4b5c-8ee1-8f05f3708989', NULL, '33e23a3f-973a-497f-aa92-5228b04057a3', '2020-12-14 15:49:35.675971', '33e23a3f-973a-497f-aa92-5228b04057a3', 'SuperAdmin', 'Chủ hệ thống');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `roleusers`
--

CREATE TABLE `roleusers` (
  `UserId` char(50) NOT NULL,
  `RoleId` char(36) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `users`
--

CREATE TABLE `users` (
  `Id` char(50) NOT NULL,
  `UserName` varchar(100) CHARACTER SET utf8mb4 NOT NULL,
  `Password` varchar(50) CHARACTER SET utf8mb4 NOT NULL,
  `Email` varchar(50) CHARACTER SET utf8mb4 NOT NULL,
  `FullName` longtext CHARACTER SET utf8mb4,
  `JoinDate` datetime(6) NOT NULL,
  `Status` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Đang đổ dữ liệu cho bảng `users`
--

INSERT INTO `users` (`Id`, `UserName`, `Password`, `Email`, `FullName`, `JoinDate`, `Status`) VALUES
('33e23a3f-973a-497f-aa92-5228b04057a3', 'admin', '123', 'nguyenbaquang226@gmail.com', 'Nguyen Quang', '2020-11-13 17:08:02.379892', 0),
('85913f7d-7e38-4782-8df1-00122229d04f', 'ngocanhmkt', '123123', 'ngocanh1998@gmail.com', 'Ngọc Ánh', '2020-12-11 11:01:42.144474', 0);

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `__efmigrationshistory`
--

CREATE TABLE `__efmigrationshistory` (
  `MigrationId` varchar(95) NOT NULL,
  `ProductVersion` varchar(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Đang đổ dữ liệu cho bảng `__efmigrationshistory`
--

INSERT INTO `__efmigrationshistory` (`MigrationId`, `ProductVersion`) VALUES
('20201113085212_CreateDbdolphin', '3.1.9'),
('20201203042215_addfieldcustomername', '3.1.9'),
('20201203081424_addfieldfortableOrders', '3.1.9');

--
-- Chỉ mục cho các bảng đã đổ
--

--
-- Chỉ mục cho bảng `categories`
--
ALTER TABLE `categories`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IX_Categories_CreatedById` (`CreatedById`),
  ADD KEY `IX_Categories_UpdatedById` (`UpdatedById`);

--
-- Chỉ mục cho bảng `comments`
--
ALTER TABLE `comments`
  ADD PRIMARY KEY (`UserId`,`ProductId`),
  ADD KEY `IX_Comments_ProductId` (`ProductId`);

--
-- Chỉ mục cho bảng `news`
--
ALTER TABLE `news`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IX_News_CreatedById` (`CreatedById`),
  ADD KEY `IX_News_UpdatedById` (`UpdatedById`);

--
-- Chỉ mục cho bảng `orderdetails`
--
ALTER TABLE `orderdetails`
  ADD PRIMARY KEY (`OrderId`,`ProductId`),
  ADD KEY `IX_OrderDetails_OrdersId` (`OrdersId`);

--
-- Chỉ mục cho bảng `orders`
--
ALTER TABLE `orders`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IX_Orders_CreatedById` (`CreatedById`),
  ADD KEY `IX_Orders_UpdatedById` (`UpdatedById`);

--
-- Chỉ mục cho bảng `permissions`
--
ALTER TABLE `permissions`
  ADD PRIMARY KEY (`Id`);

--
-- Chỉ mục cho bảng `productdetails`
--
ALTER TABLE `productdetails`
  ADD PRIMARY KEY (`Id`);

--
-- Chỉ mục cho bảng `products`
--
ALTER TABLE `products`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IX_Products_CreatedById` (`CreatedById`),
  ADD KEY `IX_Products_UpdatedById` (`UpdatedById`);

--
-- Chỉ mục cho bảng `rolepermissions`
--
ALTER TABLE `rolepermissions`
  ADD PRIMARY KEY (`RoleId`,`PermissionId`),
  ADD KEY `IX_RolePermissions_PermissionId` (`PermissionId`);

--
-- Chỉ mục cho bảng `roles`
--
ALTER TABLE `roles`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IX_Roles_CreatedById` (`CreatedById`),
  ADD KEY `IX_Roles_UpdatedById` (`UpdatedById`);

--
-- Chỉ mục cho bảng `roleusers`
--
ALTER TABLE `roleusers`
  ADD PRIMARY KEY (`RoleId`,`UserId`),
  ADD KEY `IX_RoleUsers_UserId` (`UserId`);

--
-- Chỉ mục cho bảng `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`Id`),
  ADD UNIQUE KEY `IX_Users_Email` (`Email`),
  ADD UNIQUE KEY `IX_Users_UserName` (`UserName`);

--
-- Chỉ mục cho bảng `__efmigrationshistory`
--
ALTER TABLE `__efmigrationshistory`
  ADD PRIMARY KEY (`MigrationId`);

--
-- AUTO_INCREMENT cho các bảng đã đổ
--

--
-- AUTO_INCREMENT cho bảng `news`
--
ALTER TABLE `news`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT cho bảng `permissions`
--
ALTER TABLE `permissions`
  MODIFY `Id` bigint(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- Các ràng buộc cho các bảng đã đổ
--

--
-- Các ràng buộc cho bảng `categories`
--
ALTER TABLE `categories`
  ADD CONSTRAINT `FK_Categories_Users_CreatedById` FOREIGN KEY (`CreatedById`) REFERENCES `users` (`Id`) ON DELETE CASCADE,
  ADD CONSTRAINT `FK_Categories_Users_UpdatedById` FOREIGN KEY (`UpdatedById`) REFERENCES `users` (`Id`) ON DELETE CASCADE;

--
-- Các ràng buộc cho bảng `comments`
--
ALTER TABLE `comments`
  ADD CONSTRAINT `FK_Comments_Products_ProductId` FOREIGN KEY (`ProductId`) REFERENCES `products` (`Id`) ON DELETE CASCADE,
  ADD CONSTRAINT `FK_Comments_Users_UserId` FOREIGN KEY (`UserId`) REFERENCES `users` (`Id`) ON DELETE CASCADE;

--
-- Các ràng buộc cho bảng `news`
--
ALTER TABLE `news`
  ADD CONSTRAINT `FK_News_Users_CreatedById` FOREIGN KEY (`CreatedById`) REFERENCES `users` (`Id`) ON DELETE CASCADE,
  ADD CONSTRAINT `FK_News_Users_UpdatedById` FOREIGN KEY (`UpdatedById`) REFERENCES `users` (`Id`) ON DELETE CASCADE;

--
-- Các ràng buộc cho bảng `orderdetails`
--
ALTER TABLE `orderdetails`
  ADD CONSTRAINT `FK_OrderDetails_Orders_OrdersId` FOREIGN KEY (`OrdersId`) REFERENCES `orders` (`Id`);

--
-- Các ràng buộc cho bảng `orders`
--
ALTER TABLE `orders`
  ADD CONSTRAINT `FK_Orders_Users_CreatedById` FOREIGN KEY (`CreatedById`) REFERENCES `users` (`Id`) ON DELETE CASCADE,
  ADD CONSTRAINT `FK_Orders_Users_UpdatedById` FOREIGN KEY (`UpdatedById`) REFERENCES `users` (`Id`) ON DELETE CASCADE;

--
-- Các ràng buộc cho bảng `products`
--
ALTER TABLE `products`
  ADD CONSTRAINT `FK_Products_Users_CreatedById` FOREIGN KEY (`CreatedById`) REFERENCES `users` (`Id`) ON DELETE CASCADE,
  ADD CONSTRAINT `FK_Products_Users_UpdatedById` FOREIGN KEY (`UpdatedById`) REFERENCES `users` (`Id`) ON DELETE CASCADE;

--
-- Các ràng buộc cho bảng `rolepermissions`
--
ALTER TABLE `rolepermissions`
  ADD CONSTRAINT `FK_RolePermissions_Permissions_PermissionId` FOREIGN KEY (`PermissionId`) REFERENCES `permissions` (`Id`) ON DELETE CASCADE,
  ADD CONSTRAINT `FK_RolePermissions_Roles_RoleId` FOREIGN KEY (`RoleId`) REFERENCES `roles` (`Id`) ON DELETE CASCADE;

--
-- Các ràng buộc cho bảng `roles`
--
ALTER TABLE `roles`
  ADD CONSTRAINT `FK_Roles_Users_CreatedById` FOREIGN KEY (`CreatedById`) REFERENCES `users` (`Id`) ON DELETE CASCADE,
  ADD CONSTRAINT `FK_Roles_Users_UpdatedById` FOREIGN KEY (`UpdatedById`) REFERENCES `users` (`Id`) ON DELETE CASCADE;

--
-- Các ràng buộc cho bảng `roleusers`
--
ALTER TABLE `roleusers`
  ADD CONSTRAINT `FK_RoleUsers_Roles_RoleId` FOREIGN KEY (`RoleId`) REFERENCES `roles` (`Id`) ON DELETE CASCADE,
  ADD CONSTRAINT `FK_RoleUsers_Users_UserId` FOREIGN KEY (`UserId`) REFERENCES `users` (`Id`) ON DELETE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
