-- MySQL dump 10.13  Distrib 8.0.33, for Win64 (x86_64)
--
-- Host: localhost    Database: coffeeshop
-- ------------------------------------------------------
-- Server version	8.0.33

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
-- Table structure for table `menu`
--

DROP TABLE IF EXISTS `menu`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `menu` (
  `idx` int NOT NULL AUTO_INCREMENT,
  `name` varchar(45) NOT NULL,
  `price` int NOT NULL,
  `image` varchar(100) DEFAULT NULL,
  `category` varchar(45) DEFAULT NULL,
  `description` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`idx`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `menu`
--

LOCK TABLES `menu` WRITE;
/*!40000 ALTER TABLE `menu` DISABLE KEYS */;
INSERT INTO `menu` VALUES (1,'아메리카노',2500,'img_aa618eecef95.png','coffee',NULL),(2,'카페라떼',3300,'img_0a2935abe540.png','coffee',NULL),(3,'밀크카라멜마키아또',4300,'img_6c4dc6cd3999.png','coffee',NULL);
INSERT INTO `coffeeshop`.`menu` (`name`, `price`, `image`, `category`, `description`) VALUES ('화이트아메리카노', '3000', 'img_94adbb1aff86.png', 'coffee', '아메리카노에 우유를 더했다! 카페라떼보다 가볍고 아메리카노보다는 부드러운, 묘한 매력을 가진 커피');
UPDATE `coffeeshop`.`menu` SET `description` = '견과류 풍미와 초콜릿처럼 달콤 쌉싸름한 맛이 밸런스 있게 어우러진 균형잡힌 바디감의 커피' WHERE (`idx` = '1');
UPDATE `coffeeshop`.`menu` SET `description` = '고소한 우유에 진한 에스프레소를 넣어 부드럽게 즐기는 커피' WHERE (`idx` = '2');
UPDATE `coffeeshop`.`menu` SET `description` = '은은하게 버터풍미가 도는 밀크카라멜 + 진한에스프레소 + 고소한 우유의 앙상블이 매력적인, 달콤한 카라멜 커피' WHERE (`idx` = '3');
INSERT INTO `coffeeshop`.`menu` (`name`, `price`, `image`, `category`, `description`) VALUES ('바닐라라떼', '3800', 'img_cd25547832ba.png', 'coffee', '마다가스카르산 바닐라빈이 들어가 바닐라 맛과 향이 더욱 깊고 풍부해진 바닐라 라떼');
INSERT INTO `coffeeshop`.`menu` (`name`, `price`, `image`, `category`, `description`) VALUES ('카페모카', '4300', 'img_1418e586eccc.png', 'coffee', '초콜릿 풍미에 에스프레소를 더한 달콤하면서도 쌉싸름한 맛의 커피');
INSERT INTO `coffeeshop`.`menu` (`name`, `price`, `image`, `category`, `description`) VALUES ('크리미라떼', '3800', 'img_85b82596d833.png', 'coffee', '부드럽고 달콤한 크림을 더해 깊은 풍미를 느낄 수 있는, 바나프레소만의 스페셜 커피이자 스테디셀러');
INSERT INTO `coffeeshop`.`menu` (`name`, `price`, `image`, `category`, `description`) VALUES ('딸기크리미라떼', '4500', 'img_4bc73221890e.png', 'noncoffee', '크리미한 우유에 딸기를 듬뿍 담아 새콤달콤한 맛과 부드러운 풍미가 조화로운 딸기크리미라떼');
INSERT INTO `coffeeshop`.`menu` (`name`, `price`, `image`, `category`, `description`) VALUES ('리얼초코', '3500', 'img_3becda51fb3a.png', 'noncoffee', '진한 초콜릿의 풍부한 맛과 향이 그대로 살아있는 제대로된 초코라떼. 바나프레소의 변치않는 스테디셀러');
INSERT INTO `coffeeshop`.`menu` (`name`, `price`, `image`, `category`, `description`) VALUES ('녹차라떼', '3800', 'img_ef2fc5c870b5.png', 'noncoffee', '쌉싸름한 녹차에 부드러운 우유를 섞고 달콤함을 추가해 밸런스를 잡았다. 맛있는 녹차라떼');
INSERT INTO `coffeeshop`.`menu` (`name`, `price`, `image`, `category`, `description`) VALUES ('피스타치오라떼', '3800', 'img_015748897080.png', 'noncoffee', '예쁜 비주얼과 고소한 맛이 모두 일품! 피스타치오 풍미를 제대로 느낄 수 있는 피스타치오 라떼');
INSERT INTO `coffeeshop`.`menu` (`name`, `price`, `image`, `category`, `description`) VALUES ('레몬티', '3800', 'img_d072b69b03bf.png', 'tea', '레몬의 상큼한 맛을 살린 비타민C 가득한 과일 티');
INSERT INTO `coffeeshop`.`menu` (`name`, `price`, `image`, `category`, `description`) VALUES ('자몽티', '3800', 'img_fbec2cdf7949.png', 'tea', '자몽 과일 본연의 달콤 쌉싸름한 맛을 즐길 수 있는 과일티');
INSERT INTO `coffeeshop`.`menu` (`name`, `price`, `image`, `category`, `description`) VALUES ('문경오미자티', '3800', 'img_fcb3abb8d6e3.png', 'tea', '5가지 맛 (신맛, 단맛, 매운맛, 쓴맛, 짠맛)을 내는 면역력에 좋은 100% 문경 오미자로 만든 여름철 갈증 해소에 좋은 문경오미자티');
INSERT INTO `coffeeshop`.`menu` (`name`, `price`, `image`, `category`, `description`) VALUES ('자몽허니블랙티', '3800', 'img_015f73efbc1c.png', 'tea', '상큼한 자몽과 달콤한 꿀에 깊은 풍미의 블랙티를 더한 자몽허니블랙티');
INSERT INTO `coffeeshop`.`menu` (`name`, `price`, `image`, `category`, `description`) VALUES ('바닐라쉐이크', '4500', 'img_89e794699475.png', 'smootie', '마다가스카르산 바닐라빈을 넣어 만든 부드럽고 달콤한 바닐라쉐이크');
INSERT INTO `coffeeshop`.`menu` (`name`, `price`, `image`, `category`, `description`) VALUES ('초코쉐이크', '4500', 'img_0f4de72e3327.png', 'smootie', '진한 초콜릿맛이 풍부하게 느껴지는 초코 쉐이크');
INSERT INTO `coffeeshop`.`menu` (`name`, `price`, `image`, `category`, `description`) VALUES ('망고스무디', '4000', 'img_8fe56ebfe9d2.png', 'smootie', '달콤한 망고를 넣어만든 스무디');
INSERT INTO `coffeeshop`.`menu` (`name`, `price`, `image`, `category`, `description`) VALUES ('딸기스무디', '4000', 'img_ed4fb8081923.png', 'smootie', '새콤달콤 딸기가 고소한 우유를 만났다! 부드러운 딸기 스무디');
INSERT INTO `coffeeshop`.`menu` (`name`, `price`, `image`, `category`, `description`) VALUES ('딸기복숭아스무디', '4000', 'img_a07548dac0db.png', 'smootie', '새콤 달콤한 딸기와 향긋한 복숭아가 조화를 이룬 스무디');

/*!40000 ALTER TABLE `menu` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-11-04 23:58:31
