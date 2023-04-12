CREATE DATABASE  IF NOT EXISTS `trade1` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `trade1`;
-- MySQL dump 10.13  Distrib 8.0.28, for Win64 (x86_64)
--
-- Host: localhost    Database: trade1
-- ------------------------------------------------------
-- Server version	8.0.28

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `order`
--

DROP TABLE IF EXISTS `order`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `order` (
  `OrderID` int NOT NULL AUTO_INCREMENT,
  `OrderDeliveryDate` date NOT NULL,
  `OrderDate` date NOT NULL,
  `OrderCode` int NOT NULL,
  `OrderPickupPoint` int NOT NULL,
  `OrderClient` int NOT NULL,
  `OrderStatus` int NOT NULL,
  PRIMARY KEY (`OrderID`),
  KEY `OrderStatus_idx` (`OrderStatus`),
  KEY `OrderClient_idx` (`OrderClient`),
  KEY `OrderPickupPoint_idx` (`OrderPickupPoint`),
  CONSTRAINT `OrderClient` FOREIGN KEY (`OrderClient`) REFERENCES `user` (`UserID`),
  CONSTRAINT `OrderPickupPoint` FOREIGN KEY (`OrderPickupPoint`) REFERENCES `orderpickuppoint` (`idPickupPoint`),
  CONSTRAINT `OrderStatus` FOREIGN KEY (`OrderStatus`) REFERENCES `orderstatus` (`idStatus`)
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `order`
--

LOCK TABLES `order` WRITE;
/*!40000 ALTER TABLE `order` DISABLE KEYS */;
INSERT INTO `order` VALUES (1,'2015-05-20','2009-05-20',611,25,22,1),(2,'2016-05-20','2010-05-20',612,26,20,2),(3,'2017-05-20','2011-05-20',613,27,33,1),(4,'2018-05-20','2012-05-20',614,28,10,1),(5,'2019-05-20','2013-05-20',615,29,25,2),(6,'2020-05-20','2014-05-20',616,30,16,1),(7,'2021-05-20','2015-05-20',617,31,7,1),(8,'2022-05-20','2016-05-20',618,32,18,1),(9,'2023-05-20','2017-05-20',619,33,38,1),(10,'2024-05-20','2018-05-20',620,34,5,1),(11,'2025-05-20','2019-05-20',621,24,33,1),(12,'2026-05-20','2020-05-20',622,21,7,2),(13,'2027-05-20','2021-05-20',623,23,18,1),(14,'2028-05-20','2022-05-20',624,12,38,1),(15,'2029-05-20','2023-05-20',625,16,10,2),(16,'2030-05-20','2024-05-20',626,6,25,1),(17,'2031-05-20','2025-05-20',627,23,16,1),(18,'2001-06-20','2026-05-20',628,1,5,1),(19,'2002-06-20','2027-05-20',629,4,22,1),(20,'2003-06-20','2028-05-20',630,7,20,1);
/*!40000 ALTER TABLE `order` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `orderpickuppoint`
--

DROP TABLE IF EXISTS `orderpickuppoint`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `orderpickuppoint` (
  `idPickupPoint` int NOT NULL AUTO_INCREMENT,
  `PostCode` int NOT NULL,
  `PickupPoint` text NOT NULL,
  PRIMARY KEY (`idPickupPoint`)
) ENGINE=InnoDB AUTO_INCREMENT=37 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `orderpickuppoint`
--

LOCK TABLES `orderpickuppoint` WRITE;
/*!40000 ALTER TABLE `orderpickuppoint` DISABLE KEYS */;
INSERT INTO `orderpickuppoint` VALUES (1,344288,'г. Саров, ул. Октябрьская, 19'),(2,614164,'г. Саров,  ул. Степная, 30'),(3,394242,'г. Саров, ул. Коммунистическая, 43'),(4,660540,'г. Саров, ул. Солнечная, 25'),(5,125837,'г. Саров, ул. Шоссейная, 40'),(6,125703,'г. Саров, ул. Партизанская, 49'),(7,625283,'г. Саров, ул. Победы, 46'),(8,614611,'г. Саров, ул. Молодежная, 50'),(9,454311,'г. Саров, ул. Новая, 19'),(10,660007,'г. Саров, ул. Октябрьская, 19'),(11,603036,'г. Саров, ул. Садовая, 4'),(12,450983,'г. Саров, ул. Комсомольская, 26'),(13,394782,'г. Саров, ул. Чехова, 3'),(14,603002,'г. Саров, ул. Дзержинского, 28'),(15,450558,'г. Саров, ул. Набережная, 30'),(16,394060,'г. Саров, ул. Фрунзе, 43'),(17,410661,'г. Саров, ул. Школьная, 50'),(18,625590,'г. Саров, ул. Коммунистическая, 20'),(19,625683,'г. Саров, ул. 8 Марта'),(20,400562,'г. Саров, ул. Зеленая, 32'),(21,614510,'г. Саров, ул. Маяковского, 47'),(22,410542,'г. Саров, ул. Светлая, 46'),(23,620839,'г. Саров, ул. Цветочная, 8'),(24,443890,'г. Саров, ул. Коммунистическая, 1'),(25,603379,'г. Саров, ул. Спортивная, 46'),(26,603721,'г. Саров, ул. Гоголя, 41'),(27,410172,'г. Саров, ул. Северная, 13'),(28,420151,'г. Саров, ул. Вишневая, 32'),(29,125061,'г. Саров, ул. Подгорная, 8'),(30,630370,'г. Саров, ул. Шоссейная, 24'),(31,614753,'г. Саров, ул. Полевая, 35'),(32,426030,'г. Саров, ул. Маяковского, 44'),(33,450375,'г. Саров ул. Клубная, 44'),(34,625560,'г. Саров, ул. Некрасова, 12'),(35,630201,'г. Саров, ул. Комсомольская, 17'),(36,190949,'г. Саров, ул. Мичурина, 26');
/*!40000 ALTER TABLE `orderpickuppoint` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `orderproduct`
--

DROP TABLE IF EXISTS `orderproduct`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `orderproduct` (
  `OrderID` int NOT NULL,
  `ProductArticleNumber` varchar(100) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `OrderCount` int NOT NULL,
  PRIMARY KEY (`OrderID`,`ProductArticleNumber`),
  KEY `ProductArticleNumber` (`ProductArticleNumber`),
  CONSTRAINT `orderproduct_ibfk_1` FOREIGN KEY (`OrderID`) REFERENCES `order` (`OrderID`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `orderproduct_ibfk_2` FOREIGN KEY (`ProductArticleNumber`) REFERENCES `product` (`ProductArticleNumber`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `orderproduct`
--

LOCK TABLES `orderproduct` WRITE;
/*!40000 ALTER TABLE `orderproduct` DISABLE KEYS */;
INSERT INTO `orderproduct` VALUES (1,'А112Т4',3),(4,'H792T5',3),(5,'K782T5',2),(6,'D682R2',1),(7,'B782T5',1),(8,'K963R5',2),(9,'S672R5',2),(10,'N725R4',2),(11,'U933T6',5),(12,'L726D4',1),(13,'N826F5',1),(14,'L902F5',1),(15,'G729T5',1),(17,'H782R4',2),(18,'V627S4',1),(19,'G892T6',3),(20,'F683T5',1);
/*!40000 ALTER TABLE `orderproduct` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `orderstatus`
--

DROP TABLE IF EXISTS `orderstatus`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `orderstatus` (
  `idStatus` int NOT NULL AUTO_INCREMENT,
  `Status` varchar(60) NOT NULL,
  PRIMARY KEY (`idStatus`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `orderstatus`
--

LOCK TABLES `orderstatus` WRITE;
/*!40000 ALTER TABLE `orderstatus` DISABLE KEYS */;
INSERT INTO `orderstatus` VALUES (1,'Новый'),(2,'Завершен');
/*!40000 ALTER TABLE `orderstatus` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `product`
--

DROP TABLE IF EXISTS `product`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `product` (
  `ProductArticleNumber` varchar(100) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `ProductName` text NOT NULL,
  `ProductDescription` text NOT NULL,
  `ProductCategory` int NOT NULL,
  `ProductPhoto` text NOT NULL,
  `ProductManufacturer` int NOT NULL,
  `ProductCost` decimal(19,4) NOT NULL,
  `ProductDiscountAmount` tinyint DEFAULT NULL,
  `ProductQuantityInStock` int NOT NULL,
  `ProductUnit` int NOT NULL,
  `ProductSupplier` int NOT NULL,
  `ProductMaxDiscount` int NOT NULL,
  PRIMARY KEY (`ProductArticleNumber`),
  KEY `ProductUnit_idx` (`ProductUnit`),
  KEY `ProductCategory_idx` (`ProductCategory`),
  KEY `ProductSupplier_idx` (`ProductSupplier`),
  KEY `ProductManufacturer_idx` (`ProductManufacturer`),
  CONSTRAINT `ProductCategory` FOREIGN KEY (`ProductCategory`) REFERENCES `productcategory` (`idCategory`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `ProductManufacturer` FOREIGN KEY (`ProductManufacturer`) REFERENCES `productmanufacturer` (`idManufacturer`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `ProductSupplier` FOREIGN KEY (`ProductSupplier`) REFERENCES `productsupplier` (`idSupplier`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `ProductUnit` FOREIGN KEY (`ProductUnit`) REFERENCES `productunit` (`idUnit`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `product`
--

LOCK TABLES `product` WRITE;
/*!40000 ALTER TABLE `product` DISABLE KEYS */;
INSERT INTO `product` VALUES ('A283F5','Пудра','Пудра для лица, MAC studio fix powder plus foundation',11,'img_holder.png',10,3200.0000,3,17,1,1,25),('B782T5','Пудра','Компактная пудра с эффектом сияния, MAC extra dimension skinfinish',11,'img_holder.png',10,3200.0000,3,15,1,2,15),('C672R4','Палетка','Палетка для сияния лица, DIOR BACKSTAGE glow face palette',9,'img_holder.png',7,3200.0000,3,12,1,1,10),('D672R5','Тушь для ресниц','Тушь для ресниц влагостойкая,VIVIENNE SABO cabaret latex',1,'img_holder.png',1,500.0000,2,17,1,1,15),('D682R2','Скульптор лица','Скульптор для лица, ESTRADE mon secret',8,'img_holder.png',6,250.0000,4,14,1,2,5),('F683T5','Гель для бровей','VIVIENNE SABO EYEBROW EXTRA STRONG FIXING GEL',2,'F683T5.jpg',1,149.0000,2,6,1,1,5),('G729T5','Тушь для ресниц','Тушь для ресниц со сценическим эффектом, VIVIENNE SABO cabaret premiere',1,'G729T5.jpg',1,400.0000,2,14,1,2,15),('G892T6','Гель для бровей','VIVIENNE SABO HAUTE COUTURE FIXATEUR BROW&LASH FIXING GEL',2,'G892T6.jpg',1,384.0000,2,14,1,2,15),('H198T5','Карандаш для губ','Карандаш для губ, PUPA true lips',7,'H198T5.jpg',5,500.0000,2,16,1,1,15),('H782R4','Тушь для ресниц','Суперобъемная тушь для ресниц, ART-VISAGE chicago',1,'img_holder.png',4,300.0000,2,5,1,1,15),('H792T5','Помада','Жидкая губная помада, SIGMA BEAUTY liquid lipstick',5,'H792T5.jpg',1,1500.0000,3,16,1,1,25),('J892T5','Крем','BB 10, ERBORIAN bb creme',10,'img_holder.png',8,4000.0000,4,7,1,2,5),('K782T5','Подводка','Подводка-фломастер для глаз, ART-VISAGE cat eyes',6,'K782T5.jpg',4,3255.0000,3,7,1,2,30),('K902R5','Пудра','Пудра-компакт, DARLING* plush air',11,'img_holder.png',11,1215.0000,4,13,1,2,15),('K921G6','Скульптор лица','Тройная палетка для скульптурирования, NYX PROFESSIONAL MAKEUP 3 steps to sculpt face sculpting palette',8,'img_holder.png',9,700.0000,4,6,1,1,40),('K963R5','Масло для губ','Масло для губ, ESTRADE treatment lip oil',5,'img_holder.png',6,180.0000,2,6,1,2,5),('L726D4','Румяна','Румяна для лица, MAC sheertone blush',12,'img_holder.png',10,2300.0000,2,9,1,2,15),('L902F5','Румяна','Кремовые румяна, ART-VISAGE cream blush',12,'img_holder.png',4,324.0000,3,9,1,2,5),('M788G5','Румяна','Румяна для лица, MAC mineralize blush',12,'img_holder.png',10,2790.0000,2,23,1,1,30),('N725R4','13','Устойчивый 13, MAC kajal crayon',13,'img_holder.png',10,1990.0000,3,7,1,2,15),('N826F5','Минеральная пудра','Минеральная прозрачная пудра для фиксации макияжа, NYX PROFESSIONAL MAKEUP studio finishing powder shade',11,'img_holder.png',9,1000.0000,4,15,1,1,10),('S672R5','Масло для губ','Масло-тинт для губ, DARLING* lava lamp',5,'пр03.png',11,2000.0000,5,19,1,1,15),('U933T6','Кисть для макияжа','УНИВЕРСАЛЬНАЯ КИСТЬ КАБУКИ, SIGMA BEAUTY 3dhd® kabuki',4,'U933T6.jpg',1,1900.0000,2,15,1,2,30),('V627S4','Крем','CC крем \"Абсолютное совершенство\"\", cc color correcting cream\"',10,'img_holder.png',8,1237.0000,2,18,1,2,5),('Y276S4','Пудра','Перламутровая пудра, MAC mineralize skinfinish',11,'img_holder.png',10,3190.0000,2,15,1,1,10),('А112Т4','Тушь для ресниц','SIGMA BEAUTY sinuosity lash',1,'А112Т4.jpg',1,1400.0000,4,6,1,1,30);
/*!40000 ALTER TABLE `product` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `productcategory`
--

DROP TABLE IF EXISTS `productcategory`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `productcategory` (
  `idCategory` int NOT NULL AUTO_INCREMENT,
  `Category` varchar(150) NOT NULL,
  PRIMARY KEY (`idCategory`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `productcategory`
--

LOCK TABLES `productcategory` WRITE;
/*!40000 ALTER TABLE `productcategory` DISABLE KEYS */;
INSERT INTO `productcategory` VALUES (1,'Тушь'),(2,'Гель для бровей'),(3,'Тени'),(4,'Кисть для макияжа'),(5,'Для губ'),(6,'Подводка для глаз'),(7,'Карандаш для губ'),(8,'Скульптор'),(9,'Палетка для лица'),(10,'Крем для лица'),(11,'Пудра'),(12,'Румяна для лица'),(13,'Карандаш для глаз');
/*!40000 ALTER TABLE `productcategory` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `productmanufacturer`
--

DROP TABLE IF EXISTS `productmanufacturer`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `productmanufacturer` (
  `idManufacturer` int NOT NULL AUTO_INCREMENT,
  `Manufacturer` varchar(150) NOT NULL,
  PRIMARY KEY (`idManufacturer`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `productmanufacturer`
--

LOCK TABLES `productmanufacturer` WRITE;
/*!40000 ALTER TABLE `productmanufacturer` DISABLE KEYS */;
INSERT INTO `productmanufacturer` VALUES (1,'SIGMA'),(2,'VIVIENNE SABO'),(3,'CHANEL'),(4,'Art-Visage'),(5,'PUPA'),(6,'Estrade'),(7,'DIOR'),(8,'ERBORIAN'),(9,'NYX'),(10,'MAC'),(11,'Darling');
/*!40000 ALTER TABLE `productmanufacturer` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `productsupplier`
--

DROP TABLE IF EXISTS `productsupplier`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `productsupplier` (
  `idSupplier` int NOT NULL,
  `Supplier` varchar(150) NOT NULL,
  PRIMARY KEY (`idSupplier`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `productsupplier`
--

LOCK TABLES `productsupplier` WRITE;
/*!40000 ALTER TABLE `productsupplier` DISABLE KEYS */;
INSERT INTO `productsupplier` VALUES (1,'Золотое яблоко'),(2,'Рив Гош');
/*!40000 ALTER TABLE `productsupplier` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `productunit`
--

DROP TABLE IF EXISTS `productunit`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `productunit` (
  `idUnit` int NOT NULL AUTO_INCREMENT,
  `Unit` varchar(150) NOT NULL,
  PRIMARY KEY (`idUnit`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `productunit`
--

LOCK TABLES `productunit` WRITE;
/*!40000 ALTER TABLE `productunit` DISABLE KEYS */;
INSERT INTO `productunit` VALUES (1,'шт.');
/*!40000 ALTER TABLE `productunit` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `role`
--

DROP TABLE IF EXISTS `role`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `role` (
  `RoleID` int NOT NULL AUTO_INCREMENT,
  `RoleName` varchar(100) NOT NULL,
  PRIMARY KEY (`RoleID`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `role`
--

LOCK TABLES `role` WRITE;
/*!40000 ALTER TABLE `role` DISABLE KEYS */;
INSERT INTO `role` VALUES (1,'Клиент'),(2,'Менеджер'),(3,'Администратор');
/*!40000 ALTER TABLE `role` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `user`
--

DROP TABLE IF EXISTS `user`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `user` (
  `UserID` int NOT NULL AUTO_INCREMENT,
  `UserSurname` varchar(100) NOT NULL,
  `UserName` varchar(100) NOT NULL,
  `UserPatronymic` varchar(100) NOT NULL,
  `UserLogin` text NOT NULL,
  `UserPassword` text NOT NULL,
  `UserRole` int NOT NULL,
  PRIMARY KEY (`UserID`),
  KEY `UserRole` (`UserRole`),
  CONSTRAINT `user_ibfk_1` FOREIGN KEY (`UserRole`) REFERENCES `role` (`RoleID`)
) ENGINE=InnoDB AUTO_INCREMENT=51 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user`
--

LOCK TABLES `user` WRITE;
/*!40000 ALTER TABLE `user` DISABLE KEYS */;
INSERT INTO `user` VALUES (1,'Алексеев ','Владислав','Аркадьевич','loginDEbct2018','Qg3gff',1),(2,'Савельева ','Евфросиния','Арсеньевна','loginDEvtg2018','ETMNzL',3),(3,'Никонов ','Мэлс','Лукьевич','loginDEuro2018','a1MIcO',1),(4,'Горшкова ','Агафья','Онисимовна','loginDEpst2018','0CyGnX',1),(5,'Горбачёв ','Пантелеймон','Германович','loginDEpsu2018','Vx9cQ{',2),(6,'Ершова ','Иванна','Максимовна','loginDEzqs2018','qM9p7i',2),(7,'Туров ','Денис','Геласьевич','loginDEioe2018','yMPu&2',2),(8,'Носова ','Наина','Эдуардовна','loginDEcmk2018','3f+b0+',3),(9,'Куликов ','Андрей','Святославович','loginDEfsp2018','&dtlI+',1),(10,'Нестеров ','Агафон','Георгьевич','loginDExcd2018','SZXZNL',1),(11,'Козлов ','Геласий','Христофорович','loginDEvlf2018','O5mXc2',2),(12,'Борисова ','Анжелика','Анатольевна','loginDEanv2018','Xiq}M3',3),(13,'Суханов ','Станислав','Фролович','loginDEzde2018','tlO3x&',2),(14,'Тетерина ','Феврония','Эдуардовна','loginDEriv2018','GJ2mHL',2),(15,'Муравьёва ','Александра','Ростиславовна','loginDEhcp2018','n2nfRl',2),(16,'Новикова ','Лукия','Ярославовна','loginDEwjv2018','ZfseKA',2),(17,'Агафонова ','Лариса','Михаиловна','loginDEiry2018','5zu7+}',2),(18,'Сергеева ','Агата','Юрьевна','loginDEgbr2018','}+Ex1*',2),(19,'Колобова ','Елена','Евгеньевна','loginDExxv2018','+daE|T',2),(20,'Ситников ','Николай','Филатович','loginDEbto2018','b1iYMI',1),(21,'Белов ','Роман','Иринеевич','loginDEfbs2018','v90Rep',2),(22,'Волкова ','Алла','Лукьевна','loginDEple2018','WlW+l8',3),(23,'Кудрявцева ','Таисия','Игоревна','loginDEhhx2018','hmCHeQ',2),(24,'Семёнова ','Октябрина','Христофоровна','loginDEayn2018','Ka2Fok',2),(25,'Смирнов ','Сергей','Яковович','loginDEwld2018','y9HStF',2),(26,'Брагина ','Алина','Валерьевна','loginDEhuu2018','X31OEf',1),(27,'Евсеев ','Игорь','Донатович','loginDEmjb2018','5mm{ch',2),(28,'Суворов ','Илья','Евсеевич','loginDEdgp2018','1WfJjo',2),(29,'Котов ','Денис','Мартынович','loginDEgyi2018','|7nYPc',3),(30,'Бобылёва ','Юлия','Егоровна','loginDEmvn2018','Mrr9e0',1),(31,'Брагин ','Бронислав','Георгьевич','loginDEfoj2018','nhGc+D',3),(32,'Александров ','Владимир','Дамирович','loginDEuuo2018','42XmH1',1),(33,'Фокин ','Ириней','Ростиславович','loginDEhsj2018','s+jrMW',1),(34,'Воронов ','Митрофан','Антонович','loginDEvht2018','zMyS8Z',1),(35,'Маслов ','Мстислав','Антонинович','loginDEeqo2018','l5CBqA',1),(36,'Щербаков ','Георгий','Богданович','loginDExrf2018','mhpRIT',1),(37,'Кириллова ','Эмилия','Федосеевна','loginDEfku2018','a1m+8c',2),(38,'Васильев ','Серапион','Макарович','loginDExix2018','hzxtnn',3),(39,'Галкина ','Олимпиада','Владленовна','loginDEqrf2018','mI8n58',2),(40,'Яковлева ','Ксения','Онисимовна','loginDEhlk2018','g0jSed',1),(41,'Калашникова ','Александра','Владимировна','loginDEwoe2018','yOtw2F',3),(42,'Медведьева ','Таисия','Тихоновна','loginDExyu2018','7Fg}9p',1),(43,'Карпова ','Ольга','Лукьевна','loginDEcor2018','2cIrC8',1),(44,'Герасимов ','Мстислав','Дамирович','loginDEqon2018','YeFbh6',2),(45,'Тимофеева ','Ксения','Валерьевна','loginDEyfd2018','8aKdb0',1),(46,'Горбунов ','Вячеслав','Станиславович','loginDEtto2018','qXYDuu',2),(47,'Кошелева ','Кира','Владиславовна','loginDEdal2018','cJWXL0',2),(48,'Панфилова ','Марина','Борисовна','loginDEbjs2018','Xap2ct',2),(49,'Кудрявцев ','Матвей','Игоревич','loginDEdof2018','kD|LRU',2),(50,'Зуев ','Эдуард','Пантелеймонович','loginDEsnh2018','#ИМЯ?',2);
/*!40000 ALTER TABLE `user` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'trade1'
--

--
-- Dumping routines for database 'trade1'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-04-12 13:34:33
