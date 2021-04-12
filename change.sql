-- --------------------------------------------------------
-- 호스트:                          127.0.0.1
-- 서버 버전:                        8.0.22 - MySQL Community Server - GPL
-- 서버 OS:                        Win64
-- HeidiSQL 버전:                  11.2.0.6213
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- exam0324 데이터베이스 구조 내보내기
CREATE DATABASE IF NOT EXISTS `exam0324` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `exam0324`;

-- 테이블 exam0324.namecard 구조 내보내기
CREATE TABLE IF NOT EXISTS `namecard` (
  `id` int NOT NULL AUTO_INCREMENT,
  `name` varchar(10) NOT NULL DEFAULT '0',
  `tel` varchar(20) NOT NULL DEFAULT '0',
  `email` varchar(30) DEFAULT '0',
  `address` varchar(50) NOT NULL DEFAULT '0',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- 테이블 데이터 exam0324.namecard:~0 rows (대략적) 내보내기
DELETE FROM `namecard`;
/*!40000 ALTER TABLE `namecard` DISABLE KEYS */;
INSERT INTO `namecard` (`id`, `name`, `tel`, `email`, `address`) VALUES
	(1, '홍길동', '1011111111', 'hong@naver.com', '서울 성동구 행당동'),
	(3, '박길동', '1033333333', 'park@naver.com', '부산 북구 화명동');
/*!40000 ALTER TABLE `namecard` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
