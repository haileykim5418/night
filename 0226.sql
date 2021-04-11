/*INSERT INTO namecard VALUES('0','장재열','01011111111','서울');
INSERT INTO namecard VALUES('0','지해수','01011111112','인천');
INSERT INTO namecard VALUES('0','조동민','01011111113','성남');
INSERT INTO namecard VALUES('0','박수광','01011111114','시흥');
INSERT INTO namecard VALUES('0','이영진','01011111115','안산');
INSERT INTO namecard VALUES('0','오소녀','01011111116','광주');
INSERT INTO namecard VALUES('0','한강우','01011111117','일산');
INSERT INTO namecard VALUES('0','장재범','01011111118','안양');
INSERT INTO namecard VALUES('0','최백호','01011111119','여주');
INSERT INTO namecard VALUES('0','양태용','01011111110','구리');*/
/*INSERT INTO namecard VALUES('0','장재열','01033333333','대구');
INSERT INTO namecard VALUES('0','강태하','01044444444','부산');*/

-- SELECT * FROM namecard WHERE id IN (5);
-- SELECT * FROM namecard WHERE name LIKE '_해_' ORDER BY NAME desc;
-- DELETE FROM namecard WHERE id = '7';
-- UPDATE namecard set phone = '01022222222' WHERE phone = '01011111118';

SELECT * FROM namecard JOIN USERINFO WHERE namecard.NAME = USERINFO.name;

