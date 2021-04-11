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


-- mydb 데이터베이스 구조 내보내기
CREATE DATABASE IF NOT EXISTS `mydb` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `mydb`;

-- 테이블 mydb.k_user 구조 내보내기
CREATE TABLE IF NOT EXISTS `k_user` (
  `i_user` int NOT NULL AUTO_INCREMENT,
  `user_nm` varchar(10) NOT NULL DEFAULT '',
  `user_age` int DEFAULT NULL,
  `email` varchar(20) NOT NULL DEFAULT '0',
  `user_phone` varchar(20) NOT NULL DEFAULT '0',
  `user_addr` varchar(50) NOT NULL DEFAULT '0',
  `r_dt` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`i_user`)
) ENGINE=InnoDB AUTO_INCREMENT=19 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- 테이블 데이터 mydb.k_user:~0 rows (대략적) 내보내기
DELETE FROM `k_user`;
/*!40000 ALTER TABLE `k_user` DISABLE KEYS */;
INSERT INTO `k_user` (`i_user`, `user_nm`, `user_age`, `email`, `user_phone`, `user_addr`, `r_dt`) VALUES
	(1, '이순규', 31, 'lee@naver.com', '01011112222', '서울 동구 신암동', '2021-02-25 10:42:15'),
	(2, '이순규', 31, 'lee@naver.com', '01011112222', '서울 동구 신암동', '2021-02-25 10:40:28'),
	(4, '이순규', 31, 'lee@naver.com', '01011112222', '서울 동구 신암동', '2021-02-25 10:44:26'),
	(5, '이순규', 31, 'lee@naver.com', '01011112222', '서울 동구 신암동', '2021-02-25 10:44:30'),
	(6, '이순규', 31, 'lee@naver.com', '01011112222', '서울 동구 신암동', '2021-02-25 10:44:38'),
	(7, '이순규', 31, 'lee@naver.com', '01011112222', '서울 동구 신암동', '2021-02-25 10:44:40'),
	(8, '이순규', 31, 'lee@naver.com', '01011112222', '서울 동구 신암동', '2021-02-25 10:44:41'),
	(9, '이순규', 31, 'lee@naver.com', '01011112222', '서울 동구 신암동', '2021-02-25 10:45:22'),
	(10, '이순규', 31, 'lee@naver.com', '01011112222', '서울 동구 신암동', '2021-02-25 10:45:26'),
	(15, '이순규', 0, '0', '0', '0', '2021-02-25 10:48:46'),
	(16, '이순규', NULL, '0', '0', '0', '2021-02-25 10:50:32'),
	(17, '이순규', 22, '0', '0', '0', '2021-02-25 10:53:04'),
	(18, '이순규', 22, '0', '0', '0', '2021-02-25 10:54:24');
/*!40000 ALTER TABLE `k_user` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
