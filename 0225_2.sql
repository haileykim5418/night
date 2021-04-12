/*DELETE FROM k_user WHERE user_nm = '이순규';*/

/*UPDATE k_user SET user_nm = '홍길동' WHERE user_nm = '김순규';*/

-- SELECT user_nm, user_age, r_dt FROM k_user;

-- SELECT * FROM k_user;

-- INSERT INTO k_user VALUES (0,'홍길동',100,'hong@naver.com','01012341234','조선 한양 홍대감댁',NOW());
-- 나익 50보다 크고 102보다 작은 
/*SELECT i_user, user_nm, user_age FROM k_user WHERE user_age > 20 AND user_age < 102
ORDER BY user_age DESC;
-- 내림차순으로 검색
SELECT i_user, user_nm, user_age AS "나이(세)" FROM k_user WHERE user_age >= 20 AND user_age <= 102
ORDER BY user_age ASC;
-- ASC 오름차순 DESC 내림차순  오름차순은 default값*/

-- in 안에 명시된 정보가 있을 경우 정렬
/*SELECT i_user, user_nm, user_age FROM k_user WHERE user_age IN (20,22,100)
ORDER BY i_user;
-- 나이가 in 안에 있는 값을 찾아서 id값으로 오름정렬

SELECT i_user, user_nm, user_age FROM k_user WHERE user_age IN (20,22,100)
ORDER BY user_age DESC, user_nm ASC;
-- 나이는 내림차순 이름은 오름차순으로 정렬

SELECT user_nm AS "성명",user_age AS "나이" FROM t_user WHERE user_age IN (20,22,100) ORDER BY i_user DESC;

SELECT user_nm AS "성명",user_age AS "나이" FROM t_user WHERE user_age BETWEEN 20 AND 100 ORDER BY i_user DESC;
-- 최신 데이터부터

SELECT user_nm AS "성명",user_age AS "나이" FROM t_user WHERE user_age >= 20 AND user_age <= 10 ORDER BY i_user DESC;*/

-- %동 = 동이 들어간 이름 / 홍-- = 홍으로 시작하는 이름 / -길- = 중간에 길 들어가는 이름

SELECT user_nm AS "성명",user_age AS "나이" FROM k_user WHERE user_nm LIKE '김__' ORDER BY i_user DESC;

SELECT SUM (user_age) AS '나이의 총 합계' FROM t_user;
SELECT max (user_age) AS '가장 나이가 많은 사람' FROM t_user;
SELECT avg (user_age) AS '평균 나이' FROM t_user;
SELECT count (user_age) AS '데이터 갯수' FROM t_user;t_user