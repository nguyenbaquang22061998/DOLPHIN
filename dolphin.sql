-- phpMyAdmin SQL Dump
-- version 5.0.3
-- https://www.phpmyadmin.net/
--
-- Máy chủ: 127.0.0.1
-- Thời gian đã tạo: Th10 28, 2020 lúc 01:46 AM
-- Phiên bản máy phục vụ: 10.4.14-MariaDB
-- Phiên bản PHP: 7.4.11

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
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
-- Cấu trúc bảng cho bảng `comments`
--

CREATE TABLE `comments` (
  `UserId` varchar(255) NOT NULL,
  `ProductId` char(36) NOT NULL,
  `Description` longtext DEFAULT NULL,
  `CreatedTime` datetime(6) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `dolphin`
--

CREATE TABLE `dolphin` (
  `Id` char(36) NOT NULL,
  `UpdatedDate` datetime(6) DEFAULT NULL,
  `UpdatedById` varchar(255) DEFAULT NULL,
  `CreatedDate` datetime(6) DEFAULT NULL,
  `CreatedById` varchar(255) DEFAULT NULL,
  `ProductName` longtext NOT NULL,
  `Price` longtext DEFAULT NULL,
  `Color` longtext DEFAULT NULL,
  `Size` longtext DEFAULT NULL,
  `Desciption` longtext DEFAULT NULL,
  `Status` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `permissions`
--

CREATE TABLE `permissions` (
  `Id` bigint(20) NOT NULL,
  `Name` longtext DEFAULT NULL,
  `Description` longtext DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `rolepermission`
--

CREATE TABLE `rolepermission` (
  `PermissionId` bigint(20) NOT NULL,
  `RoleId` char(36) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `roles`
--

CREATE TABLE `roles` (
  `Id` char(36) NOT NULL,
  `UpdatedDate` datetime(6) DEFAULT NULL,
  `UpdatedById` varchar(255) DEFAULT NULL,
  `CreatedDate` datetime(6) DEFAULT NULL,
  `CreatedById` varchar(255) DEFAULT NULL,
  `Name` longtext DEFAULT NULL,
  `Description` longtext DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `roleuser`
--

CREATE TABLE `roleuser` (
  `UserId` varchar(255) NOT NULL,
  `RoleId` char(36) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `users`
--

CREATE TABLE `users` (
  `Id` varchar(255) NOT NULL,
  `UserName` varchar(100) NOT NULL,
  `Password` longtext NOT NULL,
  `Email` varchar(255) NOT NULL,
  `FullName` longtext DEFAULT NULL,
  `JoinDate` datetime(6) NOT NULL,
  `Status` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `__efmigrationshistory`
--

CREATE TABLE `__efmigrationshistory` (
  `MigrationId` varchar(95) NOT NULL,
  `ProductVersion` varchar(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Đang đổ dữ liệu cho bảng `__efmigrationshistory`
--

INSERT INTO `__efmigrationshistory` (`MigrationId`, `ProductVersion`) VALUES
('20201026132742_InitCreated', '3.1.9');

--
-- Chỉ mục cho các bảng đã đổ
--

--
-- Chỉ mục cho bảng `comments`
--
ALTER TABLE `comments`
  ADD PRIMARY KEY (`UserId`,`ProductId`),
  ADD KEY `IX_Comments_ProductId` (`ProductId`);

--
-- Chỉ mục cho bảng `dolphin`
--
ALTER TABLE `dolphin`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IX_Dolphin_CreatedById` (`CreatedById`),
  ADD KEY `IX_Dolphin_UpdatedById` (`UpdatedById`);

--
-- Chỉ mục cho bảng `permissions`
--
ALTER TABLE `permissions`
  ADD PRIMARY KEY (`Id`);

--
-- Chỉ mục cho bảng `rolepermission`
--
ALTER TABLE `rolepermission`
  ADD PRIMARY KEY (`RoleId`,`PermissionId`),
  ADD KEY `IX_RolePermission_PermissionId` (`PermissionId`);

--
-- Chỉ mục cho bảng `roles`
--
ALTER TABLE `roles`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IX_Roles_CreatedById` (`CreatedById`),
  ADD KEY `IX_Roles_UpdatedById` (`UpdatedById`);

--
-- Chỉ mục cho bảng `roleuser`
--
ALTER TABLE `roleuser`
  ADD PRIMARY KEY (`RoleId`,`UserId`),
  ADD KEY `IX_RoleUser_UserId` (`UserId`);

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
-- AUTO_INCREMENT cho bảng `permissions`
--
ALTER TABLE `permissions`
  MODIFY `Id` bigint(20) NOT NULL AUTO_INCREMENT;

--
-- Các ràng buộc cho các bảng đã đổ
--

--
-- Các ràng buộc cho bảng `comments`
--
ALTER TABLE `comments`
  ADD CONSTRAINT `FK_Comments_Dolphin_ProductId` FOREIGN KEY (`ProductId`) REFERENCES `dolphin` (`Id`) ON DELETE CASCADE,
  ADD CONSTRAINT `FK_Comments_Users_UserId` FOREIGN KEY (`UserId`) REFERENCES `users` (`Id`) ON DELETE CASCADE;

--
-- Các ràng buộc cho bảng `dolphin`
--
ALTER TABLE `dolphin`
  ADD CONSTRAINT `FK_Dolphin_Users_CreatedById` FOREIGN KEY (`CreatedById`) REFERENCES `users` (`Id`),
  ADD CONSTRAINT `FK_Dolphin_Users_UpdatedById` FOREIGN KEY (`UpdatedById`) REFERENCES `users` (`Id`);

--
-- Các ràng buộc cho bảng `rolepermission`
--
ALTER TABLE `rolepermission`
  ADD CONSTRAINT `FK_RolePermission_Permissions_PermissionId` FOREIGN KEY (`PermissionId`) REFERENCES `permissions` (`Id`) ON DELETE CASCADE,
  ADD CONSTRAINT `FK_RolePermission_Roles_RoleId` FOREIGN KEY (`RoleId`) REFERENCES `roles` (`Id`) ON DELETE CASCADE;

--
-- Các ràng buộc cho bảng `roles`
--
ALTER TABLE `roles`
  ADD CONSTRAINT `FK_Roles_Users_CreatedById` FOREIGN KEY (`CreatedById`) REFERENCES `users` (`Id`),
  ADD CONSTRAINT `FK_Roles_Users_UpdatedById` FOREIGN KEY (`UpdatedById`) REFERENCES `users` (`Id`);

--
-- Các ràng buộc cho bảng `roleuser`
--
ALTER TABLE `roleuser`
  ADD CONSTRAINT `FK_RoleUser_Roles_RoleId` FOREIGN KEY (`RoleId`) REFERENCES `roles` (`Id`) ON DELETE CASCADE,
  ADD CONSTRAINT `FK_RoleUser_Users_UserId` FOREIGN KEY (`UserId`) REFERENCES `users` (`Id`) ON DELETE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
