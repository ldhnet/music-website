/*
 Navicat Premium Data Transfer

 Source Server         : music
 Source Server Type    : SQLite
 Source Server Version : 3017000
 Source Schema         : music_sqlite

 Target Server Type    : SQLite
 Target Server Version : 3017000
 File Encoding         : 65001

 Date: 26/01/2024 17:19:22
*/

PRAGMA foreign_keys = false;

-- ----------------------------
-- Table structure for Biz_Admin
-- ----------------------------
DROP TABLE IF EXISTS "Biz_Admin";
CREATE TABLE "Biz_Admin" (
  "Id" INTEGER PRIMARY KEY AUTOINCREMENT,
  "UserName" varchar(45) NOT NULL,
  "Password" varchar(45) NOT NULL,
  "Create_Time" datetime DEFAULT NULL,
  "Create_By" varchar(255) DEFAULT NULL,
  "Update_Time" datetime DEFAULT NULL,
  "Update_By" varchar(255) DEFAULT NULL
);

-- ----------------------------
-- Records of "Biz_Admin"
-- ----------------------------
INSERT INTO "Biz_Admin" VALUES (1, 'admin', 123, '2022-11-21 17:33:47', 'admin', NULL, NULL);
INSERT INTO "Biz_Admin" VALUES (2, 'admin1', 565, '2022-11-21 17:33:47', 'admin', NULL, NULL);

-- ----------------------------
-- Table structure for Biz_Banner
-- ----------------------------
DROP TABLE IF EXISTS "Biz_Banner";
CREATE TABLE "Biz_Banner" (
  "Id" INTEGER PRIMARY KEY AUTOINCREMENT,
  "Pic" varchar(255) NOT NULL,
  "Create_Time" datetime DEFAULT NULL,
  "Create_By" varchar(255) DEFAULT NULL,
  "Update_Time" datetime DEFAULT NULL,
  "Update_By" varchar(255) DEFAULT NULL
);

-- ----------------------------
-- Records of "Biz_Banner"
-- ----------------------------
INSERT INTO "Biz_Banner" VALUES (1, '/img/swiper/1.jpg', '2022-11-21 17:33:47', 'admin', NULL, NULL);
INSERT INTO "Biz_Banner" VALUES (2, '/img/swiper/2.jpg', '2022-11-21 17:33:47', 'admin', NULL, NULL);
INSERT INTO "Biz_Banner" VALUES (3, '/img/swiper/3.jpg', '2022-11-21 17:33:47', 'admin', NULL, NULL);
INSERT INTO "Biz_Banner" VALUES (4, '/img/swiper/4.jpg', '2022-11-21 17:33:47', 'admin', NULL, NULL);
INSERT INTO "Biz_Banner" VALUES (5, '/img/swiper/5.jpg', '2022-11-21 17:33:47', 'admin', NULL, NULL);
INSERT INTO "Biz_Banner" VALUES (6, '/img/swiper/6.jpg', '2022-11-21 17:33:47', 'admin', NULL, NULL);
INSERT INTO "Biz_Banner" VALUES (7, '/img/swiper/7.jpg', '2022-11-21 17:33:47', 'admin', NULL, NULL);
INSERT INTO "Biz_Banner" VALUES (8, '/img/swiper/8.jpeg', '2022-11-21 17:33:47', 'admin', NULL, NULL);

-- ----------------------------
-- Table structure for Biz_Collect
-- ----------------------------
DROP TABLE IF EXISTS "Biz_Collect";
CREATE TABLE "Biz_Collect" (
  "Id" INTEGER PRIMARY KEY AUTOINCREMENT,
  "User_Id" int NOT NULL,
  "Type" tinyint NOT NULL,
  "Song_Id" int,
  "Song_List_Id" int,
  "Create_Time" datetime DEFAULT NULL,
  "Create_By" varchar(255) DEFAULT NULL,
  "Update_Time" datetime DEFAULT NULL,
  "Update_By" varchar(255) DEFAULT NULL
);

-- ----------------------------
-- Records of "Biz_Collect"
-- ----------------------------
INSERT INTO "Biz_Collect" VALUES (4, 94, 0, 23, NULL, '2019-01-07 16:41:44', 'admin', NULL, NULL);
INSERT INTO "Biz_Collect" VALUES (10, 94, 0, 3, NULL, '2019-01-07 16:58:59', 'admin', NULL, NULL);
INSERT INTO "Biz_Collect" VALUES (16, 94, 0, 24, NULL, '2019-01-07 17:34:07', 'admin', NULL, NULL);
INSERT INTO "Biz_Collect" VALUES (21, 5, 0, 24, NULL, '2019-01-08 15:18:33', 'admin', NULL, NULL);
INSERT INTO "Biz_Collect" VALUES (24, 5, 0, 8, NULL, '2019-01-08 16:07:57', 'admin', NULL, NULL);
INSERT INTO "Biz_Collect" VALUES (43, 5, 0, 7, NULL, '2019-04-26 01:06:20', 'admin', NULL, NULL);
INSERT INTO "Biz_Collect" VALUES (45, 26, 0, 44, NULL, '2020-03-21 22:26:37', 'admin', NULL, NULL);
INSERT INTO "Biz_Collect" VALUES (46, 26, 0, 36, NULL, '2020-03-21 22:28:24', 'admin', NULL, NULL);
INSERT INTO "Biz_Collect" VALUES (47, 26, 0, 69, NULL, '2020-03-22 01:56:54', 'admin', NULL, NULL);
INSERT INTO "Biz_Collect" VALUES (48, 26, 0, 45, NULL, '2020-03-22 02:08:36', 'admin', NULL, NULL);
INSERT INTO "Biz_Collect" VALUES (54, 12, 0, 9, NULL, '2020-04-26 21:47:45', 'admin', NULL, NULL);
INSERT INTO "Biz_Collect" VALUES (62, 1, 0, 7, NULL, '2022-01-21 17:33:01', 'admin', NULL, NULL);
INSERT INTO "Biz_Collect" VALUES (63, 1, 0, 11, NULL, '2022-01-21 17:33:47', 'admin', NULL, NULL);
INSERT INTO "Biz_Collect" VALUES (64, 1, 0, 5, NULL, '2022-01-21 17:34:12', 'admin', NULL, NULL);

-- ----------------------------
-- Table structure for Biz_Comment
-- ----------------------------
DROP TABLE IF EXISTS "Biz_Comment";
CREATE TABLE "Biz_Comment" (
  "Id" INTEGER PRIMARY KEY AUTOINCREMENT,
  "User_Id" int unsigned NOT NULL,
  "Song_Id" int unsigned,
  "Song_List_Id" int unsigned,
  "Content" varchar(255) DEFAULT NULL,
  "Type" tinyint NOT NULL,
  "Up" int unsigned NOT NULL,
  "Create_Time" datetime DEFAULT NULL,
  "Create_By" varchar(255) DEFAULT NULL,
  "Update_Time" datetime DEFAULT NULL,
  "Update_By" varchar(255) DEFAULT NULL
);

-- ----------------------------
-- Records of "Biz_Comment"
-- ----------------------------
INSERT INTO "Biz_Comment" VALUES (3, 1, 0, 1, '里面乱乱糟糟\n我们别再闹了\n这个冬天已然很冷了\n我们靠在一起。好吗', 1, 9, '2022-04-21 21:37:06', 'admin', '2024-01-20 14:11:51.245691', NULL);
INSERT INTO "Biz_Comment" VALUES (5, 1, 21, NULL, '允儿牵动我的心!!!', 0, 0, '2022-04-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Comment" VALUES (9, 1, 22, NULL, '林允儿这个人，饭她真的很骄傲。韩国人说汉语总会带着地域性极强的泡菜味，可是林允儿真的很用心在把准每一个汉字，从咬字到发音，再加上轻柔干净的嗓音加持，将柔美与舒缓表达到极致，将歌里想诉说的那种感情娓娓道来。', 0, 0, '2022-04-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Comment" VALUES (10, 1, 21, NULL, '像我们之间一段长久未诉的告白，被你这样娓娓道来，你问我爱你有多深，我爱你有几分，我的情不移我的爱不变，月亮代表我的心。', 0, 4, '2022-04-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Comment" VALUES (11, 1, 21, NULL, '当听这首歌曲的时候，看看天上的月亮。美爆了！', 0, 2, '2022-04-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Comment" VALUES (12, 1, 23, NULL, '太尼马好听了！堂堂正正的林歌手！！', 0, 0, '2022-04-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Comment" VALUES (13, 1, 23, NULL, '林允儿啊，真的唱的很标准，很动人，我的同学都没想到是林允儿唱的，呜呜呜，爱死你了林允儿', 0, 0, '2022-04-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Comment" VALUES (14, 1, 22, NULL, '真的好棒，我只听她这个版本的', 0, 0, '2022-04-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Comment" VALUES (16, 1, 5, NULL, '好听啊', 0, 0, '2022-04-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Comment" VALUES (17, 1, 22, NULL, '我的允宝啊，努力演戏想让我们看到一样的你，努力学中文唱给我们听越来越爱你了', 0, 0, '2022-04-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Comment" VALUES (18, 1, 22, NULL, '好听啊', 0, 0, '2022-04-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Comment" VALUES (19, 1, 23, NULL, '好听啊', 0, 0, '2022-04-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Comment" VALUES (23, 1, NULL, 5, '赞！！', 1, 2, '2022-04-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Comment" VALUES (24, 5, NULL, 1, '超喜欢！', 1, 4, '2022-04-21 21:37:06', 'admin', '2024-01-20 14:11:51.9134237', NULL);
INSERT INTO "Biz_Comment" VALUES (25, 5, NULL, 5, '大爱我林！', 1, 1, '2022-04-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Comment" VALUES (26, 5, NULL, 2, 'nice', 1, 2, '2022-04-21 21:37:06', 'admin', '2024-01-20 14:11:44.6722273', NULL);
INSERT INTO "Biz_Comment" VALUES (27, 1, NULL, 0, '很有感觉', 1, 2, '2022-04-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Comment" VALUES (28, 5, 26, NULL, '好听', 0, 0, '2022-04-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Comment" VALUES (30, 5, 15, NULL, '好听！', 0, 0, '2022-04-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Comment" VALUES (31, 1, 13, NULL, 'rrrr', 0, 0, '2022-04-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Comment" VALUES (32, 1, 19, NULL, '赞', 0, 0, '2022-04-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Comment" VALUES (33, 1, 6, NULL, '赞', 0, 0, '2022-04-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Comment" VALUES (34, 1, NULL, 1, 'hao', 1, 4, '2022-04-21 21:37:06', 'admin', '2024-01-20 14:11:52.3730254', NULL);
INSERT INTO "Biz_Comment" VALUES (35, 1, NULL, 38, 'hao', 1, 0, '2022-04-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Comment" VALUES (36, 1, NULL, 0, '妙！', 1, 1, '2022-04-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Comment" VALUES (37, 1, NULL, 80, '好听', 1, 0, '2022-04-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Comment" VALUES (38, 1, NULL, 80, '好听！！！', 1, 0, '2022-04-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Comment" VALUES (39, 1, NULL, 80, '好听', 1, 0, '2022-04-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Comment" VALUES (40, 1, NULL, 80, 'good', 1, 0, '2022-04-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Comment" VALUES (41, 1, NULL, 80, 'nice', 1, 0, '2022-04-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Comment" VALUES (42, 1, NULL, 80, 'nice', 1, 0, '2022-04-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Comment" VALUES (43, 1, NULL, 82, 'success', 1, 0, '2022-04-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Comment" VALUES (45, 1, NULL, 1, '啦啦啦(*≧∀≦)ﾉ', 1, 1, '2022-04-21 21:37:06', 'admin', '2024-01-20 14:11:53.1279755', NULL);
INSERT INTO "Biz_Comment" VALUES (47, 1, NULL, 1, 222, 1, 1, '2022-04-21 21:37:06', 'admin', '2024-01-20 14:11:53.7863194', NULL);
INSERT INTO "Biz_Comment" VALUES (48, 5, NULL, 10, '我喜欢你', 1, 0, '2022-04-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Comment" VALUES (49, 1, NULL, 0, '', 1, 0, '2022-04-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Comment" VALUES (50, 1, NULL, 51, '好听', 1, 0, '2022-04-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Comment" VALUES (51, 1, NULL, 5, '好听', 1, 0, '2022-04-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Comment" VALUES (52, 1, NULL, 5, '好听', 1, 0, '2022-04-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Comment" VALUES (53, 1, 107, NULL, 'I love you！！！', 0, 0, '2022-04-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Comment" VALUES (54, 1, 95, NULL, '好听', 0, 0, '2022-04-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Comment" VALUES (55, 1, 28, NULL, '?', 0, 0, '2022-04-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Comment" VALUES (56, 26, 69, NULL, 'good!', 0, 0, '2022-04-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Comment" VALUES (57, 26, 10, NULL, 'good', 0, 5, '2022-04-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Comment" VALUES (58, 1, NULL, 3, 1111111, 1, 1, '2022-04-21 21:37:06', 'admin', '2024-01-20 14:15:25.4660346', NULL);
INSERT INTO "Biz_Comment" VALUES (59, 1, 28, NULL, 11111, 0, 0, '2022-04-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Comment" VALUES (60, 1, NULL, 15, 111, 1, 0, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Comment" VALUES (61, 1, NULL, 15, 222, 1, 0, '2022-04-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Comment" VALUES (62, 1, NULL, 15, 33, 1, 0, '2022-04-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Comment" VALUES (63, 1, NULL, 15, '里面乱乱糟糟 我们别再闹了 这个冬天已然很冷了 我们靠在一起。好吗.里面乱乱糟糟 我们别再闹了 这个冬天已然很冷了 我们靠在一起。好吗.里面乱乱糟糟 我们别再闹了 这个冬天已然很冷了 我们靠在一起。好吗.里面乱乱糟糟 我们别再闹了 这个冬天已然很冷了 我们靠在一起。好吗', 1, 0, '2022-04-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Comment" VALUES (64, 1, NULL, 1, 456, 1, 1, '2022-04-21 21:37:06', 'admin', '2024-01-20 14:11:55.1183034', NULL);
INSERT INTO "Biz_Comment" VALUES (69, 1, 0, 8, 'wewewe', 1, 0, '1970-01-01 00:00:00', '', '1970-01-01 00:00:00', '');
INSERT INTO "Biz_Comment" VALUES (70, 1, 0, 10, '', 1, 0, '1970-01-01 00:00:00', '', '1970-01-01 00:00:00', '');
INSERT INTO "Biz_Comment" VALUES (71, 1, 0, 3, '撒大大', 1, 1, '2024-01-20 12:58:26.3218964', '', '2024-01-20 14:17:34.1555626', '');
INSERT INTO "Biz_Comment" VALUES (72, 1, 0, 4, '硕大的', 1, 2, '2024-01-20 12:59:28.5686293', '', '2024-01-20 14:11:33.9985507', '');
INSERT INTO "Biz_Comment" VALUES (73, 63, 0, 6, 'dddddddddddddd', 1, 1, '2024-01-20 14:22:53.4752084', '', '2024-01-20 14:22:54.6405742', '');

-- ----------------------------
-- Table structure for Biz_CommentUp
-- ----------------------------
DROP TABLE IF EXISTS "Biz_CommentUp";
CREATE TABLE "Biz_CommentUp" (
  "Id" INTEGER PRIMARY KEY AUTOINCREMENT,
  "UserId" int NOT NULL DEFAULT 0,
  "CommentId" int NOT NULL DEFAULT 0,
  "Create_Time" datetime DEFAULT NULL,
  "Create_By" varchar(255) DEFAULT NULL,
  "Update_Time" datetime DEFAULT NULL,
  "Update_By" varchar(255) DEFAULT NULL
);

-- ----------------------------
-- Records of "Biz_CommentUp"
-- ----------------------------
INSERT INTO "Biz_CommentUp" VALUES (1, 1, 3, '2023-11-21 17:33:47', 'user', NULL, NULL);
INSERT INTO "Biz_CommentUp" VALUES (2, 1, 3, '2024-01-20 17:33:47', 'user', NULL, NULL);
INSERT INTO "Biz_CommentUp" VALUES (15, 1, 72, '2024-01-20 14:11:16.0318248', '', '1970-01-01 00:00:00', '');
INSERT INTO "Biz_CommentUp" VALUES (16, 63, 72, '2024-01-20 14:11:33.9763911', '', '1970-01-01 00:00:00', '');
INSERT INTO "Biz_CommentUp" VALUES (17, 63, 26, '2024-01-20 14:11:44.6535789', '', '1970-01-01 00:00:00', '');
INSERT INTO "Biz_CommentUp" VALUES (19, 63, 3, '2024-01-20 14:11:51.2371888', '', '1970-01-01 00:00:00', '');
INSERT INTO "Biz_CommentUp" VALUES (20, 63, 24, '2024-01-20 14:11:51.8957472', '', '1970-01-01 00:00:00', '');
INSERT INTO "Biz_CommentUp" VALUES (21, 63, 34, '2024-01-20 14:11:52.3544283', '', '1970-01-01 00:00:00', '');
INSERT INTO "Biz_CommentUp" VALUES (22, 63, 45, '2024-01-20 14:11:53.106155', '', '1970-01-01 00:00:00', '');
INSERT INTO "Biz_CommentUp" VALUES (23, 63, 47, '2024-01-20 14:11:53.7699628', '', '1970-01-01 00:00:00', '');
INSERT INTO "Biz_CommentUp" VALUES (24, 63, 64, '2024-01-20 14:11:55.0992492', '', '1970-01-01 00:00:00', '');
INSERT INTO "Biz_CommentUp" VALUES (25, 63, 58, '2024-01-20 14:15:25.4521651', '', '1970-01-01 00:00:00', '');
INSERT INTO "Biz_CommentUp" VALUES (27, 63, 71, '2024-01-20 14:17:34.1374705', '', '1970-01-01 00:00:00', '');
INSERT INTO "Biz_CommentUp" VALUES (28, 63, 73, '2024-01-20 14:22:54.6235342', '', '1970-01-01 00:00:00', '');
INSERT INTO "Biz_CommentUp" VALUES (29, 63, 74, '2024-01-20 14:26:41.1458128', '', '1970-01-01 00:00:00', '');

-- ----------------------------
-- Table structure for Biz_Consumer
-- ----------------------------
DROP TABLE IF EXISTS "Biz_Consumer";
CREATE TABLE "Biz_Consumer" (
  "Id" INTEGER PRIMARY KEY AUTOINCREMENT,
  "UserName" varchar(255) NOT NULL,
  "Password" varchar(100) NOT NULL,
  "Sex" tinyint DEFAULT NULL,
  "Phone_Num" char(15) DEFAULT NULL,
  "Email" char(30) DEFAULT NULL,
  "Birth" datetime DEFAULT NULL,
  "Introduction" varchar(255) DEFAULT NULL,
  "Location" varchar(45) DEFAULT NULL,
  "Avator" varchar(255) DEFAULT NULL,
  "Create_Time" datetime DEFAULT NULL,
  "Create_By" varchar(255) DEFAULT NULL,
  "Update_Time" datetime DEFAULT NULL,
  "Update_By" varchar(255) DEFAULT NULL
);

-- ----------------------------
-- Records of "Biz_Consumer"
-- ----------------------------
INSERT INTO "Biz_Consumer" VALUES (1, 'user', 123, 0, 13776412237, 'yoona@qq.com', '2019-05-21 00:00:00', '好好吃饭', '山西', '/img/avatorImages/86c38cfa57ed49a6b604877b45747baf.jpg', '2019-01-04 21:42:24', NULL, '2022-04-18 01:19:12', NULL);
INSERT INTO "Biz_Consumer" VALUES (2, '012', '012', 0, 13754803255, 'love@gmail.com', '2019-04-24 00:00:00', '我就喜欢吃', '北京', '/img/avatorImages/1649527868607author.jpg', '2019-01-05 15:02:45', NULL, '2020-03-23 01:24:59', NULL);
INSERT INTO "Biz_Consumer" VALUES (5, 789, 789, 0, 13634377258, '666@126.com', '2019-01-08 00:00:00', '今天很开心啊', '山西', '/img/avatorImages/1646506637695IMG_4801.jpg', '2019-01-07 16:16:42', NULL, '2022-04-10 01:59:13', NULL);
INSERT INTO "Biz_Consumer" VALUES (8, 'tawuhen', 123, 0, '', '192673541@qq.com', '2019-04-25 18:58:39', '你好', '北京', '/img/avatorImages/user.jpg', '2019-04-25 00:28:58', NULL, '2019-04-25 18:58:39', NULL);
INSERT INTO "Biz_Consumer" VALUES (12, 'yoona', 123, 0, 13854173655, '1236795@qq.com', '2019-04-25 00:00:00', '好好吃饭', '北京', '/img/avatorImages/1588094989449L1.jpg', '2019-04-25 10:56:54', NULL, '2020-04-29 01:28:37', NULL);
INSERT INTO "Biz_Consumer" VALUES (16, 1234321, 123, 1, 13754803257, '123@qq.com', '2020-03-08 17:25:45', '', '', '/img/avatorImages/user.jpg', '2020-03-08 17:25:45', NULL, '2020-03-08 17:25:45', NULL);
INSERT INTO "Biz_Consumer" VALUES (20, 234321, 123, 0, 15754801257, '12987@qq.com', '2020-03-08 23:41:22', '', '', '/img/avatorImages/user.jpg', '2020-03-08 23:41:22', NULL, '2020-03-08 23:41:22', NULL);
INSERT INTO "Biz_Consumer" VALUES (24, 'yoonaAA', 123, 1, NULL, NULL, '2020-03-04 00:00:00', '', '', '/img/avatorImages/user.jpg', '2020-03-21 22:20:27', NULL, '2020-03-21 22:20:27', NULL);
INSERT INTO "Biz_Consumer" VALUES (25, 'yoonaAB', 123, 1, NULL, NULL, '2020-03-02 00:00:00', '', '', '/img/avatorImages/user.jpg', '2020-03-21 22:21:50', NULL, '2020-03-21 22:21:50', NULL);
INSERT INTO "Biz_Consumer" VALUES (26, 'yoonaAC', 123, 1, 'null', 'null', '2020-03-11 00:00:00', '', '', '/img/avatorImages/user.jpg', '2020-03-21 22:23:43', NULL, '2020-05-14 21:12:56', NULL);
INSERT INTO "Biz_Consumer" VALUES (27, 'yoonaAD', 123, 1, NULL, NULL, '2020-03-11 00:00:00', '', '', '/img/avatorImages/user.jpg', '2020-03-21 22:24:47', NULL, '2020-03-21 22:24:47', NULL);
INSERT INTO "Biz_Consumer" VALUES (28, 'yoona90', 123, 0, NULL, NULL, '2020-04-28 00:00:00', '', '', '/img/avatorImages/user.jpg', '2020-04-02 22:10:34', NULL, '2020-04-02 22:10:34', NULL);
INSERT INTO "Biz_Consumer" VALUES (29, 'test', 123, 0, 15666412237, '1239679@qq.com', '2020-04-16 11:29:43', '', '', '/img/avatorImages/user.jpg', '2020-04-16 11:29:43', NULL, '2020-04-16 11:29:43', NULL);
INSERT INTO "Biz_Consumer" VALUES (30, 'Yoona001', 123, 0, NULL, NULL, '2020-07-27 00:00:00', '', '', '/img/avatorImages/user.jpg', '2020-07-01 19:54:44', NULL, '2020-07-01 19:54:44', NULL);
INSERT INTO "Biz_Consumer" VALUES (31, 'yuner', 123, 0, NULL, NULL, '2015-02-10 00:00:00', '', '', '/img/avatorImages/user.jpg', '2021-07-17 18:18:40', NULL, '2021-07-17 18:18:40', NULL);
INSERT INTO "Biz_Consumer" VALUES (32, 'YinH', 123, 1, NULL, NULL, '2021-02-08 00:00:00', '', '', '/img/user.jpg', '2022-02-04 16:09:45', NULL, '2022-02-04 16:09:45', NULL);
INSERT INTO "Biz_Consumer" VALUES (34, 'qwe', 123, 0, NULL, NULL, '2022-04-05 00:00:00', '', '', '/img/avatorImages/user.jpg', '2022-04-05 22:56:00', NULL, '2022-04-05 22:56:00', NULL);
INSERT INTO "Biz_Consumer" VALUES (35, 1234, '', 1, NULL, NULL, '2022-04-12 00:00:00', '', '', '/img/avatorImages/user.jpg', '2022-04-12 23:05:52', NULL, '2022-04-12 23:05:52', NULL);
INSERT INTO "Biz_Consumer" VALUES (57, '1234d', 123, 1, NULL, NULL, '2022-04-14 00:00:00', '', '', '/img/avatorImages/user.jpg', '2022-04-14 00:57:21', NULL, '2022-04-14 00:57:21', NULL);
INSERT INTO "Biz_Consumer" VALUES (59, 'zxc', 123, 1, NULL, NULL, '2022-04-21 00:00:00', '', '', '/img/avatorImages/user.jpg', '2022-04-21 22:54:19', NULL, '2022-04-21 22:54:19', NULL);
INSERT INTO "Biz_Consumer" VALUES (60, 'xcv', 123, 1, NULL, NULL, '2022-04-22 00:00:00', '', '', '/img/avatorImages/user.jpg', '2022-04-22 00:22:16', NULL, '2022-04-22 00:22:16', NULL);
INSERT INTO "Biz_Consumer" VALUES (61, 'zhangsan', 123, 0, 15222222222, '', '2024-01-18 04:47:21.742', 123, 122, 1222, '1970-01-01 00:00:00', '', '1970-01-01 00:00:00', '');
INSERT INTO "Biz_Consumer" VALUES (62, 'zhangsan2', 123, 1, 15222222222, '', '2024-01-18 04:27:19.709', '', '', '', '1970-01-01 00:00:00', '', '1970-01-01 00:00:00', '');
INSERT INTO "Biz_Consumer" VALUES (63, 'wangwu', 123, 2, '', '', '2024-01-18 04:54:12.22', '', '', '/img/avatorImages/8713c5b616744967b94ee5c01171da92.jpg', '1970-01-01 00:00:00', '', '1970-01-01 00:00:00', '');
INSERT INTO "Biz_Consumer" VALUES (64, 'zhang6', 123, 0, '', '', '2024-01-18 05:51:19.104', '', '', '', '1970-01-01 00:00:00', '', '1970-01-01 00:00:00', '');

-- ----------------------------
-- Table structure for Biz_List_Song
-- ----------------------------
DROP TABLE IF EXISTS "Biz_List_Song";
CREATE TABLE "Biz_List_Song" (
  "Id" INTEGER PRIMARY KEY AUTOINCREMENT,
  "Song_Id" int unsigned NOT NULL,
  "Song_List_Id" int unsigned NOT NULL,
  "Create_Time" datetime DEFAULT NULL,
  "Create_By" varchar(255) DEFAULT NULL,
  "Update_Time" datetime DEFAULT NULL,
  "Update_By" varchar(255) DEFAULT NULL
);

-- ----------------------------
-- Records of "Biz_List_Song"
-- ----------------------------
INSERT INTO "Biz_List_Song" VALUES (1, 36, 1, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (4, 7, 2, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (5, 11, 2, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (6, 38, 6, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (7, 39, 6, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (8, 44, 1, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (9, 22, 2, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (10, 22, 12, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (11, 38, 5, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (12, 39, 5, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (13, 38, 5, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (14, 39, 5, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (15, 45, 4, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (16, 45, 12, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (17, 10, 13, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (18, 10, 2, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (19, 28, 3, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (20, 10, 3, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (21, 30, 10, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (22, 31, 10, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (23, 82, 6, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (24, 83, 6, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (25, 84, 6, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (26, 85, 6, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (27, 99, 7, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (28, 100, 8, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (29, 78, 9, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (30, 79, 9, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (31, 80, 9, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (32, 86, 7, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (33, 87, 7, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (34, 88, 8, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (35, 100, 7, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (36, 82, 11, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (37, 65, 11, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (38, 50, 11, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (39, 67, 14, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (40, 78, 14, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (41, 26, 14, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (42, 4, 15, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (43, 7, 15, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (44, 21, 15, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (45, 24, 16, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (46, 40, 16, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (47, 50, 16, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (48, 70, 16, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (49, 72, 17, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (50, 73, 17, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (51, 51, 18, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (52, 52, 18, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (53, 65, 18, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (54, 67, 18, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (55, 2, 19, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (56, 7, 19, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (57, 55, 19, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (58, 53, 19, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (59, 54, 19, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (60, 4, 20, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (61, 7, 20, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (62, 11, 20, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (63, 26, 20, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (64, 99, 21, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (65, 100, 21, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (66, 86, 21, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (67, 91, 22, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (68, 94, 22, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (69, 77, 22, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (70, 68, 22, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (71, 50, 22, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (72, 76, 17, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (73, 93, 15, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (74, 92, 15, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (75, 78, 72, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (76, 79, 72, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (77, 80, 72, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (78, 64, 71, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (79, 65, 71, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (80, 50, 71, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (81, 51, 71, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (82, 51, 70, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (83, 50, 70, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (84, 64, 62, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (85, 65, 62, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (86, 66, 62, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (87, 67, 62, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (88, 25, 63, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (89, 26, 63, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (90, 79, 63, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (91, 65, 64, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (92, 64, 64, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (93, 80, 64, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (94, 25, 65, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (95, 64, 65, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (96, 67, 67, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (97, 64, 67, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (98, 25, 67, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (99, 25, 69, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (100, 24, 69, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (101, 25, 69, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (102, 26, 69, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (103, 48, 69, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (104, 80, 68, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (105, 64, 68, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (108, 64, 66, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (109, 80, 66, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (110, 102, 23, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (112, 101, 25, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (113, 102, 30, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (114, 102, 32, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (115, 101, 34, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (116, 42, 36, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (117, 43, 36, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (118, 41, 36, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (119, 36, 38, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (120, 37, 38, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (121, 101, 38, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (122, 101, 37, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (123, 102, 39, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (124, 37, 40, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (125, 108, 40, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (126, 102, 40, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (127, 112, 41, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (128, 102, 41, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (129, 102, 42, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (130, 41, 24, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (131, 100, 23, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (132, 98, 47, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (133, 61, 47, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (134, 62, 47, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (135, 33, 49, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (136, 68, 49, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (137, 33, 49, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (138, 23, 49, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (139, 33, 50, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (140, 21, 50, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (141, 61, 52, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (142, 62, 52, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (143, 21, 60, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (144, 22, 60, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (145, 23, 60, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (146, 63, 58, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (147, 98, 58, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (148, 63, 53, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (149, 30, 54, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (150, 61, 56, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (151, 63, 56, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (152, 98, 57, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (153, 32, 54, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (154, 22, 57, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (155, 98, 59, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (156, 63, 59, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (157, 62, 61, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (158, 22, 61, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (159, 68, 51, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (160, 35, 51, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (161, 32, 51, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (162, 33, 61, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (163, 86, 43, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (164, 100, 44, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (165, 87, 45, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (166, 86, 45, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (167, 100, 44, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (168, 88, 46, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (169, 99, 73, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (170, 88, 74, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (171, 99, 74, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (172, 88, 73, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (173, 103, 78, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (174, 103, 84, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (175, 103, 75, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (176, 103, 76, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (177, 103, 77, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (178, 103, 79, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (179, 88, 80, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (180, 99, 80, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (181, 103, 80, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (182, 104, 80, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (183, 104, 81, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (184, 88, 82, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (185, 99, 82, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (186, 105, 83, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (187, 99, 48, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (188, 95, 26, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (189, 96, 27, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (190, 97, 26, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (191, 95, 28, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (192, 98, 29, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (193, 62, 29, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (194, 87, 31, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (195, 61, 31, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (196, 63, 31, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (197, 87, 55, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (198, 96, 55, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (199, 98, 33, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (200, 63, 33, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (201, 105, 83, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (202, 106, 83, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (203, 107, 53, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (204, 107, 60, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (205, 108, 8, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (206, 112, 24, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (207, 113, 40, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (208, 109, 8, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_List_Song" VALUES (209, 107, 23, '2022-11-21 21:37:06', 'admin', NULL, NULL);

-- ----------------------------
-- Table structure for Biz_Rank_List
-- ----------------------------
DROP TABLE IF EXISTS "Biz_Rank_List";
CREATE TABLE "Biz_Rank_List" (
  "Id" INTEGER PRIMARY KEY AUTOINCREMENT,
  "SongListId" bigint unsigned NOT NULL,
  "ConsumerId" bigint unsigned NOT NULL,
  "Score" int unsigned NOT NULL,
  "Create_Time" datetime DEFAULT NULL,
  "Create_By" varchar(255) DEFAULT NULL,
  "Update_Time" datetime DEFAULT NULL,
  "Update_By" varchar(255) DEFAULT NULL
);

-- ----------------------------
-- Records of "Biz_Rank_List"
-- ----------------------------
INSERT INTO "Biz_Rank_List" VALUES (1, 2, 1, 7, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Rank_List" VALUES (2, 2, 2, 3, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Rank_List" VALUES (3, 1, 1, 4, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Rank_List" VALUES (7, 13, 1, 5, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Rank_List" VALUES (19, 21, 1, 5, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Rank_List" VALUES (20, 31, 1, 5, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Rank_List" VALUES (21, 5, 1, 0, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Rank_List" VALUES (24, 11, 1, 4, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Rank_List" VALUES (25, 10, 1, 10, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Rank_List" VALUES (27, 6, 1, 6, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Rank_List" VALUES (28, 7, 1, 10, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Rank_List" VALUES (29, 1, 26, 4, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Rank_List" VALUES (30, 7, 26, 2, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Rank_List" VALUES (32, 3, 26, 5, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Rank_List" VALUES (33, 14, 26, 9, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Rank_List" VALUES (34, 49, 12, 3, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Rank_List" VALUES (35, 3, 1, 3, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Rank_List" VALUES (46, 67, 1, 7, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Rank_List" VALUES (56, 4, 1, 5, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Rank_List" VALUES (62, 8, 1, 6, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Rank_List" VALUES (63, 15, 1, 7, '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Rank_List" VALUES (64, 9, 1, 8, '2022-11-21 21:37:06', 'admin', NULL, NULL);

-- ----------------------------
-- Table structure for Biz_Singer
-- ----------------------------
DROP TABLE IF EXISTS "Biz_Singer";
CREATE TABLE "Biz_Singer" (
  "Id" INTEGER PRIMARY KEY AUTOINCREMENT,
  "Name" varchar(45) NOT NULL,
  "Sex" tinyint DEFAULT NULL,
  "Pic" varchar(255) DEFAULT NULL,
  "Birth" datetime DEFAULT NULL,
  "Location" varchar(45) DEFAULT NULL,
  "Introduction" varchar(255) DEFAULT NULL,
  "Create_Time" datetime DEFAULT NULL,
  "Create_By" varchar(255) DEFAULT NULL,
  "Update_Time" datetime DEFAULT NULL,
  "Update_By" varchar(255) DEFAULT NULL
);

-- ----------------------------
-- Records of "Biz_Singer"
-- ----------------------------
INSERT INTO "Biz_Singer" VALUES (1, '张杰', 1, '/img/singerPic/d874abb1138f44b6be199fa51cd511c1.png', '1982-12-20 00:00:00', '中国四川', '华语歌坛新生代领军人物，偶像与实力兼具的超人气天王。2004年出道至今，已发行9张高品质唱片，唱片销量称冠内地群雄。2008年以来举办过9场爆满的个人演唱会，在各大权威音乐奖项中先后21次获得“最受欢迎男歌手”称号，2012年度中国TOP排行榜内地最佳男歌手，2010年在韩国M-net亚洲音乐大赏(MAMA)上获得“亚洲之星”（Best Asian Artist）大奖，影响力触及海外。', '2022-11-21 21:37:06', 'admin', '2022-11-25 17:00:04', 'system');
INSERT INTO "Biz_Singer" VALUES (2, '周杰伦', 1, '/img/singerPic/14fabc0a3dec4c8bb578bf54a25f3664.png', '1979-01-08 17:29:15', '中国台湾', '著名歌手，音乐人，词曲创作人，编曲及制作人，MV及电影导演。新世纪华语歌坛领军人物，中国风歌曲始祖，被时代周刊誉为“亚洲猫王”，是2000年后亚洲流行乐坛最具革命性与指标性的创作歌手，亚洲销量超过3100万张，有“亚洲流行天王”之称，开启华语乐坛“R&B时代”与“流行乐中国风”的先河，周杰伦的出现打破了亚洲流行乐坛长年停滞不前的局面，为亚洲流行乐坛翻开了新的一页，是华语乐坛真正把R&B提升到主流高度的人物，引领华语乐坛革命整十年，改写了华语乐坛的流行方向。', '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Singer" VALUES (3, '林允儿', 0, '/img/singerPic/5b4a270622324e5e9b59cf2d2b6082e6.jpg', '1990-05-30 00:00:00', '韩国', '1990年5月30日出生于韩国首尔永登浦区，韩国女歌手、演员、主持人，女子演唱团体少女时代成员之一。2002年，林允儿参加韩国SM娱乐有限公司的选秀而进入SM公司成为旗下练习生。2007年8月5日，以演唱团体少女时代成员身份正式出道。2008年主演情感剧《你是我的命运》获得第45届韩国百想艺术大赏电视剧类最佳新人女演员奖和人气女演员奖。2009年主演励志爱情剧《乞丐变王子》...', '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Singer" VALUES (5, 'G.E.M.邓紫棋', 0, '/img/singerPic/be478051abdc4563ba3735bcff689a6a.png', '1974-07-27 00:00:00', '中国上海1', '成长于一个音乐世家，其母亲为上海音乐学院声乐系毕业生，外婆教唱歌，舅父拉小提琴，外公在乐团吹色士风。在家人的熏陶下，自小便热爱音乐，喜爱唱歌，与音乐结下不解之缘。G.E.M.在5岁的时候已经开始尝试作曲及填词，13岁完成了8级钢琴。G.E.M.在小学时期就读位于太子道西的中华基督教会协和小学上午校，为2003年的毕业生，同时亦为校内诗歌班成员。其英文名G.E.M.是Get Everybody Moving的缩写，象徵著她希望透过音乐让大家动起来的梦想。', '2022-11-21 21:37:06', 'admin', '2022-11-25 17:00:08', 'system');
INSERT INTO "Biz_Singer" VALUES (7, '艺声', 1, '/img/singerPic/yisheng.jpg', '1984-08-24 00:00:00', '韩国', '韩国著名男子团体Super Junior成员之一。2001年参加Starlight Casting System Casting，获得SM BEST选拔大赛歌唱赛第一名。经过长达5年的练习生训练，于2005年11月6日以Super Junior的身份正式出道。有着“艺术般声音”的他，被冠以“艺声”这个名号，是队中公认唱功最好的成员之一，因深沉、富有磁性且感情丰富的嗓音而在队里担当主唱。曾表演音乐剧、为多部电视剧演唱OST。值得一提的是，他也是朱一丹女士的疯狂追求者之一。', '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Singer" VALUES (8, 'Ennio Morricone', 1, '/img/singerPic/fee66c3c28c744968a417aec59d4cdd2.jpg', '1928-11-10 00:00:00', '意大利', '埃尼欧·莫里科内，意大利作曲家，生于罗马，曾为超过500部的电影电视写过配乐。2007年他获得奥斯卡终身成就奖，成为第二位获此殊荣的作曲家。他获得两次格莱美奖，两次金球奖，五次英国电影和电视艺术学院奖等多项音乐奖项。', '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Singer" VALUES (9, '林俊杰', 1, '/img/singerPic/1646507266498IMG_4801.jpg', '1981-03-27 00:00:00', '新加坡', '著名男歌手，作曲人、作词人、音乐制作人，偶像与实力兼具。林俊杰出生于新加坡的一个音乐世家。在父母的引导下，4岁就开始学习古典钢琴，不善言辞的他由此发现了另一种与人沟通的语言。小时候的林俊杰把哥哥林俊峰当作偶像，跟随哥哥的步伐做任何事，直到接触流行音乐后，便爱上创作这一条路。2003年以专辑《乐行者》出道，2004年一曲《江南》红遍两岸三地，凭借其健康的形象，迷人的声线，出众的唱功，卓越的才华，迅速成为华语流行乐坛的领军人物之一，迄今为止共创作数百首音乐作品，唱片销量在全亚洲逾1000万张。', '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Singer" VALUES (10, '王力宏', 1, '/img/singerPic/wanglihong.jpg', '1976-05-17 14:00:30', '美国', '中国著名流行歌手、词曲创作音乐人；亚洲华语流行乐坛最具代表性的创作、偶像、实力派音乐偶像巨星。1995年发行首张专辑《情敌贝多芬》在台湾出道，亦是金曲奖中最年轻的封王者，其唱片总销量在全亚洲已超过2500万张。从改编歌曲《龙的传人》融合西方电子节奏和东方旋律的华人中式嘻哈风，再到为华语流行乐注入新元素，进一步将其推向全世界。超高唱片销量便可以证明力宏的影响力毋庸置疑的强。况且身为金曲奖常客，3次接受CNN电视台访问。首创Chinked-out曲风，将中国风推向世界。', '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Singer" VALUES (11, 'Eminem', 1, '/img/singerPic/Eminem.jpg', '1972-10-17 15:35:23', '美国', '埃米纳姆（Eminem）是美国的一名说唱歌手。其风格类型为：Hardcore Rap（硬核说唱）。埃米纳姆最大的突破就是证明白人也能介入到黑人一统天下的说唱（RAP）界中，而且获得巨大的成功。同时他的叛逆不仅长期以来深受美国青少年喜爱，也让他在舆论中始终遭到抨击。Eminem获得的奖杯总数窜至历史第三位，居麦当娜和皮特-加布里埃尔之后。', '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Singer" VALUES (12, '李荣浩', 1, '/img/singerPic/2754172d71204a728f5a15da4c35aece.jpg', '1985-07-11 21:52:23', '中国安徽', '李荣浩，1985年7月11日生于蚌埠，中国流行音乐制作人、歌手、吉他手。曾为众多艺人创作歌曲以及担任制作人，也曾为多部电影与多款电子游戏制作音乐。2013年9月17日发行个人首张原创专辑《模特》，凭借这张专辑入围第25届金曲奖最佳国语男歌手奖、最佳新人奖、最佳专辑制作人、最佳国语专辑、最佳作词奖等五项大奖提名，成为最大黑马，实现了从制作人到歌手的华丽转身。', '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Singer" VALUES (14, '许嵩', 1, '/img/singerPic/xusong.jpg', '1986-05-14 21:58:45', '中国安徽', '著名作词人、作曲人、唱片制作人、歌手。内地独立音乐之标杆人物，有音乐鬼才之称。2009年独立出版首张词曲全创作专辑《自定义》，2010年独立出版第二张词曲全创作专辑《寻雾启示》，两度掀起讨论热潮，一跃成为内地互联网讨论度最高的独立音乐人。2011年加盟海蝶音乐，推出第三张词曲全创作专辑《苏格拉没有底》，发行首月即在大陆地区摘下唱片销量榜冠军，轰动全国媒体，并拉开全国巡回签售及歌迷见面会。', '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Singer" VALUES (15, '张国荣', 1, '/img/singerPic/e37465874f584842be26b3fe6910c7de.jpg', '1956-09-12 22:02:38', '中国香港', '张国荣是一位在全球华人社会和亚洲地区具有影响力的著名歌手、演员和音乐人；大中华区乐坛和影坛巨星；演艺圈多栖发展最成功的代表之一。张国荣是香港乐坛的殿堂级歌手之一，曾获得香港乐坛最高荣誉金针奖；他是第一位享誉韩国乐坛的华人歌手，亦是华语唱片在韩国销量纪录保持者。他通晓词曲创作，曾担任过MTV导演、唱片监制、电影编剧、电影监制。他于1991年当选香港电影金像奖影帝。。。', '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Singer" VALUES (16, '杨宗纬', 1, '/img/singerPic/a8ae67ae94d644ed8afc9469d5930648.jpg', '1978-04-04 22:04:47', '中国台湾', '大学时期参加台湾歌唱选秀节目《超级星光大道》获选为第一届“人气王”。比赛的时候，杨宗纬歌声阳刚而细腻，富含感情，辨识度高，感染力强，以演唱抒情歌曲见长，选曲跨越性别界线，无论是男女歌手的抒情歌曲，经过他重新诠释之后，常常都可以得到不输原唱或甚至超越原唱的评价。出道后屡创多项记录，包括发行首张专辑，便以新人之姿登上台北小巨蛋举办个人演唱会。。。', '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Singer" VALUES (17, '朴树', 1, '/img/singerPic/pushu.jpg', '1973-11-08 22:07:08', '中国江苏', '中国大陆歌手，音乐人。1996年10月正式成为“麦田音乐”签约歌手，为简略笔划而定艺名朴树。首支单曲《火车开往冬天》，96年底推出后成绩斐然。99年1月，推出首张个人专辑《我去两千年》。99年12月与华纳唱片正式签订唱片合约，成为其亚太区旗下的第一位内地歌手，其首张专辑《我去两千年》将由华纳重新混录和拍摄最新单曲录影带后，于2000年上半年在海外隆重上市。代表作品：《那些花儿》，《白桦林》，《生如夏花》。主要成就：中歌榜最佳新人奖，最受欢迎男歌手，年度最佳制作人奖。', '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Singer" VALUES (18, '李克勤', 1, '/img/singerPic/eadaac6879ea48faa300e5850b7cbe83.jpg', '1967-12-06 22:10:04', '中国香港', '中国香港很有影响力的粤语流行曲歌手与演员。1985年凭《雾之恋》夺得“十九区业余歌唱大赛”冠军而晋身乐坛。曾于2002、2003和2005年度《十大劲歌金曲颁奖典礼》中三度夺得「最受欢迎男歌手」，于2003年度《叱吒乐坛流行榜颁奖典礼》上获得「叱吒乐坛我最喜爱的男歌手」，并于《第二十七届十大中文金曲颁奖典礼》(2004年度)上夺得「最优秀流行男歌手大奖」，2010年度音乐先锋榜颁奖礼 ── 20家电台联颁亚太歌手奖。', '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Singer" VALUES (19, '张碧晨', 0, '/img/singerPic/30dc2cfa9f06414797bd2f886961ef10.jpg', '1989-09-10 22:15:16', '中国天津', '1989年9月10日出生于中国天津，中国女歌手。 2013年，张碧晨以韩国女子组合“Sunny days ”出道，并获得“K-POP ”世界庆典“最优秀奖”。2014年7月，张碧晨参加第三季《中国好声音》，以一首《她说》进入那英组，并于10月7日以一首《时间去哪儿了》荣获第三季《中国好声音》全国总冠军，成为《中国好声音》首位女冠军。', '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Singer" VALUES (20, 'IU', 0, '/img/singerPic/4d6ede8cd0e94688b01562be09921a68.jpg', '1993-05-16 22:22:00', '韩国', '李知恩 (IU)，1993年5月16日出生于韩国首尔特别市，韩国女歌手、演员、主持人。2008年以一首《迷儿》正式出道，历经一年的练习生生涯。2011年以一首《好日子》在韩国走红，随后于2011年末推出正规二辑《Last Fantasy》 PK记录74次，AK约90次。2013年IU发行正规三辑《MODERN TIMES》再次获得关注。2012年~2015年分别位列韩国福布斯名人榜第三、第八、第十和第十四位。2015年，发行迷你专辑《CHAT-SHIRE》', '2022-11-21 21:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Singer" VALUES (21, '金泰妍', 0, '/img/singerPic/984abf1bce1d40ad8a447766069dd869.jpg', '1989-03-09 00:33:15', '韩国', '金泰妍(김태연/ Kim Tae-yeon/金泰耎)，艺名太妍(태연/TaeYeon)，1989年3月9日出生于韩国全罗北道全州市，韩国女歌手、主持人，女子演唱团体少女时代成员之一。2004年在第八届SM青少年选拔大赛歌王中夺得第一名，进入韩国SM娱乐有限公司开始练习生生涯。2007年8月以演唱团体少女时代成员身份正式出道。2008年为韩国KBS电视台电视剧《快刀洪吉童》演唱主题曲《如果》；同年12月凭借歌曲《听得见吗》获得第23届韩国金唱片大奖人气奖 。', '2022-11-21 21:37:06', 'admin', NULL, NULL);

-- ----------------------------
-- Table structure for Biz_Song
-- ----------------------------
DROP TABLE IF EXISTS "Biz_Song";
CREATE TABLE "Biz_Song" (
  "Id" INTEGER PRIMARY KEY AUTOINCREMENT,
  "Singer_Id" int unsigned NOT NULL,
  "Name" varchar(45) NOT NULL,
  "Introduction" varchar(255) DEFAULT NULL,
  "Pic" varchar(255) DEFAULT NULL,
  "Lyric" text,
  "Url" varchar(255) NOT NULL,
  "Create_By" varchar(50) DEFAULT NULL,
  "Create_Time" datetime NOT NULL,
  "Update_By" varchar(50) DEFAULT NULL,
  "Update_Time" datetime DEFAULT NULL
);

-- ----------------------------
-- Records of "Biz_Song"
-- ----------------------------
INSERT INTO "Biz_Song" VALUES (1, 1, '张杰-仰望星空', '明天过后', '/img/songPic/056960045dc04f2ba8847c4272a4332f.jpg', '[ti:仰望星空]\n[ar:张杰]\n[00:00.266]\n[00:00.570]作曲：曾明维（Taiwan）\n[00:00.670]作词 : 邹振东\n[00:00.770]这一天我开始仰望星空发现\n[00:07.238]星并不远梦并不远只要你踮起脚尖\n[00:17.11]我相信有一双手把我轻轻牵到你的跟前\n[00:29.233]我相信有一根线将梦想与现实相连\n[00:45.389]我相信有一种缘会把所有的偶然都实现\n[00:57.346]我相信就是这一天命运开始改变\n[01:08.85]这一天我开始仰望星空发现\n[01:14.559]星并不远梦并不远只要你踮起脚尖\n[01:22.154]我从此不再彷徨也不再腼腆\n[01:28.621]张开双臂和你一起飞的更高看的更远\n[01:41.286]Music\n[01:52.845]我相信有一种缘会把所有的偶然都实现\n[02:04.543]我相信就是这一天命运开始改变\n[02:15.135]这一天我开始仰望星空发现\n[02:21.668]星并不远梦并不远只要你踮起脚尖\n[02:29.235]我从此不再彷徨也不再腼腆\n[02:35.717]张开双臂和你一起飞的更高看的更远\n[02:48.45]开始仰望星空感觉爱的时间空间\n[02:55.353]寻找生命中最灿烂的亮点\n[03:01.278]这一天我开始仰望星空发现\n[03:07.439]星并不远梦并不远只要你踮起脚尖\n[03:14.888]我从此不再彷徨也不再腼腆\n[03:21.630]张开双臂和你一起飞的更高看的更远\n[03:29.404]这一天我开始仰望星空发现\n[03:35.634]星并不远梦并不远只要你踮起脚尖\n[03:43.477]我从此不再彷徨也不再腼腆\n[03:49.834]张开双臂和你一起飞的更高看的更远\n[04:02.854]', '/song/张杰-仰望星空.mp3', 'system', '2018-12-26 08:40:14', 'system', '2022-11-25 16:08:23');
INSERT INTO "Biz_Song" VALUES (2, 1, '张杰-他不懂', '爱，不解释', '/img/songPic/674d6816b97f4842b53396948fab5c7b.png', '[00:00.00] 作曲 : 周振霆/代岳东\n[00:01.00] 作词 : 唐湘智\n[00:19.410]他留给你是背影\n[00:25.060]关于爱情只字不提\n[00:29.850]害你哭红了眼睛\n[00:34.780]他把谎言说的竟然那么动听\n[00:40.750]他不止一次骗了你\n[00:44.710]不值得你再为他伤心\n[00:48.380]他不懂你的心假装冷静\n[00:53.180]他不懂爱情把它当游戏\n[00:56.170]他不懂表明相爱这件事\n[01:00.060]除了对不起就只剩叹息\n[01:04.060]他不懂你的心为何哭泣\n[01:08.950]窒息到快要不能呼吸\n[01:16.700]喔喔\n[01:18.880]他不懂你的心\n[01:23.230]\n[01:36.550]他把回忆留给你\n[01:43.640]连同忧伤强加给你\n[01:48.300]对你说来不公平\n[01:54.610]他的谎言句句说的那么动听\n[01:58.750]他不止一次骗了你\n[02:03.640]不值得你再为他伤心\n[02:07.980]他不懂你的心假装冷静\n[02:11.880]他不懂爱情把它当游戏\n[02:15.720]他不懂表明相爱这件事\n[02:19.630]除了对不起就只剩叹息\n[02:23.960]他不懂你的心为何哭泣\n[02:27.970]窒息到快要不能呼吸\n[02:36.070]喔喔\n[02:38.630]他不懂你的心\n[02:42.630]\n[02:56.250]他不懂你的心假装冷静\n[02:59.990]他不懂爱情把它当游戏\n[03:03.860]他不懂表明相爱这件事\n[03:07.720]除了对不起就只剩叹息\n[03:11.570]他不懂你的心为何哭泣\n[03:15.640]窒息到快要不能呼吸\n[03:23.800]喔喔\n[03:26.320]他不懂你的心\n[03:49.834]张开双臂和你一起飞的更高看的更远\n[04:02.854]', '/song/张杰-他不懂.mp3', 'system', '2018-12-26 11:24:13', NULL, '2019-05-24 00:15:25');
INSERT INTO "Biz_Song" VALUES (3, 1, '张杰-天下', '明天过后', '/img/songPic/80a0f1f7ead542d18bc5f57abf6c4859.png', '[00:00.00] 作曲 : 刘吉宁\n[00:01.00] 作词 : 周毅\n[00:26.800]烽烟起寻爱似浪淘沙\n[00:33.700]遇见她如春水映梨花\n[00:40.400]挥剑断天涯相思轻放下\n[00:46.900]梦中我痴痴牵挂\n[00:53.900]顾不顾将相王侯\n[00:55.800]管不管万世千秋\n[00:57.800]求只求爱化解\n[00:58.900]这万丈红尘纷乱永无休\n[01:01.400]爱更爱天长地久\n[01:02.800]要更要似水温柔\n[01:04.800]谁在乎谁主春秋\n[01:06.900]一生有爱何惧风飞沙\n[01:10.100]悲白发留不住芳华\n[01:13.900]抛去江山如画换她笑面如花\n[01:17.100]抵过这一生空牵挂\n[01:20.100]心若无怨爱恨也随他\n[01:23.300]天地大情路永无涯\n[01:27.100]只为她袖手天下\n[01:32.900]\n[02:00.900]顾不顾将相王侯\n[02:02.700]管不管万世千秋\n[02:03.900]求只求爱化解\n[02:05.800]这万丈红尘纷乱永无休\n[02:07.900]爱更爱天长地久\n[02:09.900]要更要似水温柔\n[02:11.800]谁在乎谁主春秋\n[02:13.400]一生有爱何惧风飞沙\n[02:16.700]悲白发留不住芳华\n[02:20.900]抛去江山如画换她笑面如花\n[02:24.600]抵过这一生空牵挂\n[02:26.900]心若无怨爱恨也随他\n[02:30.700]天地大情路永无涯\n[02:33.900]只为她袖手天下\n[02:39.900]\n[02:40.300]一生有爱何惧风飞沙\n[02:43.700]悲白发留不住芳华\n[02:47.400]抛去江山如画换她笑面如花\n[02:50.900]抵过这一生空牵挂\n[02:53.900]心若无怨爱恨也随他\n[02:56.900]天地大情路永无涯\n[02:59.900]只为她袖手天下\n[03:05.900]\n[03:06.900]烽烟起寻爱似浪淘沙\n[03:13.300]遇见她如春水映梨花\n[03:20.100]挥剑断天涯相思轻放下\n[03:26.900]梦中我痴痴牵挂\n[03:32.900]', '/song/张杰-天下.mp3', 'system', '2018-12-26 11:34:31', NULL, '2018-12-26 11:34:31');
INSERT INTO "Biz_Song" VALUES (4, 1, '张杰-如果爱', '再爱我一回', '/img/songPic/haikuotiankong.jpg', '[00:00.00] 作曲 : 黎沸辉\n[00:01.00] 作词 : 黎沸辉\n[00:04.16]如果爱\n[00:16.77]ah~~~ah~~\n[00:34.50]我的心从没有搬到另一个地址\n[00:40.57]还是和你用同样一室的钥匙\n[00:48.19]你的眼泪一滴一滴将回忆淋湿\n[00:54.64]你的拥抱却让呼吸变得真实\n[01:02.40]相爱的人 我能如何选择\n[01:09.29]伤痛和快乐全都是重复的规则\n[01:16.22]如果爱只是拉拉扯扯\n[01:19.65]两个人都动弹不得\n[01:23.10]如果爱已经少了快乐\n[01:26.68]为何心痛不能割舍\n[01:30.25]如果爱已经慢慢褪色\n[01:33.83]两颗心都失去颜色\n[01:37.25]如果爱已是非爱不可\n[01:40.79]又何必问他是否值得\n[01:44.54]可爱情在猜疑下渐渐冰冷\n[02:01.08]我的心从没有搬到另一个地址\n[02:12.48]还是和你用同样一室的钥匙\n[02:20.14]你的眼泪一滴一滴将回忆淋湿\n[02:26.32]你的拥抱却让呼吸变得真实\n[02:34.11]相爱的人 我能如何选择\n[02:41.14]伤痛和快乐全都是重复的规则\n[02:45.35]如果爱只是拉拉扯扯\n[02:51.65]两个人都动弹不得\n[02:54.99]如果爱已经少了快乐\n[02:58.80]为何心痛不能割舍\n[03:02.11]如果爱已经慢慢褪色\n[03:05.67]两颗心都失去颜色\n[03:09.14]如果爱已是非爱不可\n[03:12.70]又何必问他是否值得\n[03:16.50]看爱情在猜疑下～\n[03:20.04]如果爱只是拉拉扯扯\n[03:23.02]两个人都动弹不得\n[03:25.41]如果爱已经少了快乐\n[03:30.42]为何心痛不能割舍\n[03:33.76]如果爱已经慢慢褪色\n[03:37.30]两颗心都失去颜色\n[03:40.74]如果爱已是非爱不可\n[03:44.17]又何必问他是否值得\n[03:48.39]看爱情在猜疑下渐渐冰冷\n[03:52.17]又何必问他是否值得\n[03:55.76]如果爱已是非爱 非爱不可～\n[03:59.28]两颗心都失去了颜色\n[04:03.00]看爱情在猜疑下渐渐冰冷\n[04:06.58]又何必问他是否值得\n[04:09.79]如果爱已是非爱 非爱不可～\n[04:13.49]两颗心都失去了颜色', '/song/张杰-如果爱.mp3', 'system', '2018-12-26 11:47:15', NULL, '2022-04-10 11:59:14');
INSERT INTO "Biz_Song" VALUES (6, 1, '张杰-逆态度', '中国新声代第二季 第十三期', '/img/songPic/nizhan.jpg', '[00:00.00] 作曲 : 唐湘智\n[00:01.00] 作词 : 李焯雄\n[00:23.100]要战出我的逆态度\n[00:26.330]谁说人是习惯动物\n[00:29.160]不敢颠覆这世俗又算什么人物yeah\n[00:35.290]沉默会被错误解读\n[00:38.170]进攻是最好的防护\n[00:40.940]不被污染这质朴戴上谁的脸谱yeah\n[00:46.750]成功不只一种配方\n[00:49.360]谁要一模一样\n[00:51.990]足够梦想足够疯狂\n[00:55.060]也许情况就不一样\n[00:57.730]自我燃烧不是狂妄\n[01:00.820]谁要一模一样\n[01:03.460]突破平凡突破框框\n[01:06.590]也许有我就不一样\n[01:09.390]光逆风飞翔的凤凰\n[01:12.140]光逆境之中逆生长\n[01:14.710]光逆态度的自信光芒\n[01:20.770]光逆风飞翔的凤凰\n[01:23.710]光逆境之中逆生长\n[01:26.560]光逆战一切自信光芒\n[01:30.500]敢于和天再较量\n[01:32.760]勇敢说不的逆态度\n[01:35.700]谁说人是习惯动物\n[01:38.550]不敢颠覆这世俗又算什么人物yeah\n[01:45.320]沉默会被错误解读\n[01:48.750]进攻是最好的防护\n[01:51.130]不被污染这质朴戴上谁的脸谱yeah\n[01:56.850]成功不只一种配方\n[01:59.650]谁要一模一样\n[02:02.320]足够梦想足够疯狂\n[02:05.360]也许情况就不一样\n[02:08.130]自我燃烧不是狂妄\n[02:11.210]谁要一模一样\n[02:13.890]突破平凡突破框框\n[02:17.200]也许有我就不一样\n[02:19.820]光逆风飞翔的凤凰\n[02:22.630]光逆境之中逆生长\n[02:25.620]光逆态度的自信光芒\n[02:31.670]光逆风飞翔的凤凰\n[02:34.610]光逆境之中逆生长\n[02:37.370]光逆战一切自信光芒\n[02:41.500]敢于和天再较量\n[02:43.510]\n[02:55.160]自我否定就等于投降\n[02:57.650]就算被指指点点不卑不亢\n[03:00.270]全部自己扛当仁不让\n[03:03.330]逆转形势要再打一仗\n[03:06.170]没有理由要轻易投降\n[03:09.230]就算被指指点点不卑不亢\n[03:12.290]坚持自己证明是谁在说谎\n[03:15.090]逆转这形势拒绝被谁驯养\n[03:18.270]光逆向飞翔的凤凰\n[03:21.100]光逆境之中逆生长\n[03:24.230]光逆态度的自信光芒\n[03:29.790]光逆向飞翔的凤凰\n[03:32.700]光逆境之中逆生长\n[03:35.880]光逆战一切自信光芒\n[03:39.530]敢于和天再较量\n[03:42.850]', '/song/张杰-逆态度.mp3', 'system', '2018-12-26 12:02:57', NULL, '2018-12-26 12:02:57');
INSERT INTO "Biz_Song" VALUES (7, 1, '张杰-何必在一起', '穿越三部曲', '/img/songPic/hebiyaozaiyiqi.jpg', '[00:00.00] 作曲 : 梁晓雪　\n [00:01.00] 作词 : 梁晓雪/赵阳\n[00:33.728]夜夜的那么美丽\n[00:39.127]有人欢笑有人却在哭泣\n[00:46.180]尘封的记忆残留着邂逅的美丽\n[00:52.198]辗转反侧的我失眠在夜里\n[01:00.989]你你带走的呼吸\n[01:06.137]吻不到你那感觉多委屈\n[01:12.687]分岔的爱情让眼泪隔出银河的距离\n[01:20.980]轻轻关上门\n[01:22.980]让眼泪不逃避\n[01:29.928]何必要在一起\n[01:35.190]让我爱上你\n[01:37.598]至少自己过得不必太压抑\n[01:43.617]何必要在一起\n[01:47.937]逃出生命里\n[01:51.187]才让这个夜显得那么空虚\n[01:57.988]何必要在一起\n[02:01.587]让我爱上你\n[02:05.970]感觉你的呼吸是那么清晰\n[02:11.790]何必要在一起\n[02:15.399]让我没勇气\n[02:19.600]让我独自在这寒冷的夜里\n[02:24.799]何必要在一起\n[02:55.959]\n[02:59.519]何必要在一起\n[03:04.619]让我爱上你\n[03:08.140]至少自己过得不必太压抑\n[03:14.140]何必要在一起\n[03:18.799]逃出生命里\n[03:21.820]才让这个夜显得那么空虚\n[03:27.820]何必要在一起\n[03:32.790]让我爱上你\n[03:35.579]感觉你的呼吸是那么清晰\n[03:41.500]何必要在一起\n[03:45.880]让我没勇气\n[03:49.899]让我独自在着寒冷的夜里\n[03:54.820]何必要在一起\n[04:01.980]何必要在一起\n[04:07.440]让我爱上你\n[04:17.470]', '/song/张杰-何必在一起.mp3', 'system', '2018-12-27 07:49:53', NULL, '2018-12-27 07:49:53');
INSERT INTO "Biz_Song" VALUES (8, 1, '张杰-剑心', '拾', '/img/songPic/jianxin.jpg', '[00:00.00] 作曲 : 谭旋\n[00:01.00] 作词 : 段思思\n[00:20.120]编曲：王文颖\n[00:22.120]录混：马涛（上海谭旋音乐工作室）\n[00:26.120]尘封在星蕴重明的魂魄\n[00:32.130]叫醒了恍惚梦魇的无措\n[00:38.320]揭开这宿命的脉络\n[00:42.410]\n[00:44.220]逃不开 这一世的寂寞\n[00:50.000]往后是阴霾\n[00:51.300]往前是山隘\n[00:52.870]想逃也逃不开\n[00:55.890]命运再主宰\n[00:57.380]执着的心也不会更改\n[01:01.650]哪管桑田\n[01:04.340]哪管沧海\n[01:11.370]听琴声潇潇\n[01:14.290]该忘的忘不掉\n[01:17.380]红尘 困住我年少\n[01:23.500]原谅我藏在心里燎燎的狂傲\n[01:29.610]去战 面对天地荡浩\n[01:35.820]人生也潇潇 魂牵梦绕\n[01:39.070]像烈焰燃烧\n[01:41.840]前尘 看浮沉走一遭\n[01:48.020]用冷的锋刃琴的寂寥\n[01:51.270]写往事今朝\n[01:54.430]孤剑 指尖 谈笑\n[02:13.640]人心间有没有一种解药\n[02:19.670]能覆盖是非恩仇的喧嚣\n[02:25.830]屠俘了焚寂的剑鞘\n[02:31.870]斩不断 这一生的桀骜\n[02:38.140]往后是阴霾\n[02:39.720]往前是山隘\n[02:42.070]想逃也逃不开\n[02:44.780]命运再主宰\n[02:46.350]执着的心也不会更改\n[02:50.950]哪管桑田\n[02:53.250]哪管沧海\n[03:00.230]听琴声潇潇\n[03:03.200]该忘的忘不掉\n[03:06.390]红尘 困住我年少\n[03:12.390]原谅我藏在心里燎燎的狂傲\n[03:18.490]去战 面对天地荡浩\n[03:24.710]人生也潇潇 魂牵梦绕\n[03:28.090]像烈焰燃烧\n[03:30.890]前尘 看浮沉走一遭\n[03:36.930]用冷的锋刃琴的寂寥\n[03:40.580]写往事今朝\n[03:44.590]孤剑 指尖 谈笑\n[03:48.150]', '/song/张杰-剑心.mp3', 'system', '2018-12-27 08:04:42', NULL, '2018-12-27 08:04:42');
INSERT INTO "Biz_Song" VALUES (9, 2, '周杰伦-稻香', '魔杰座', '/img/songPic/daoxiang.jpg', '[by:橘子大宝宝]\n[ti:稻香]\n[ar:周杰伦]\n[00:31.00]对这个世界如果你有太多的抱怨\n[00:34.05]跌倒了就不敢继续往前走\n[00:37.02]为什麽人要这麽的脆弱 堕落\n[00:41.55]请你打开电视看看\n[00:43.14]多少人为生命在努力勇敢的走下去\n[00:46.89]我们是不是该知足\n[00:49.43]珍惜一切 就算没有拥有\n[00:54.24]还记得你说家是唯一的城堡\n[00:57.49]随着稻香河流继续奔跑\n[01:00.42]微微笑 小时候的梦我知道\n[01:05.51]不要哭让萤火虫带着你逃跑\n[01:09.21]乡间的歌谣永远的依靠\n[01:12.12]回家吧 回到最初的美好\n[01:41.14]不要这麽容易就想放弃 就像我说的\n[01:44.59]追不到的梦想 换个梦不就得了\n[01:47.55]为自己的人生鲜艳上色 先把爱涂上喜欢的颜色\n[01:51.80]笑一个吧 功成名就不是目的\n[01:55.62]让自己快乐快乐这才叫做意义\n[01:58.51]童年的纸飞机 现在终於飞回我手里\n[02:04.41]所谓的那快乐 赤脚在田里追蜻蜓追到累了\n[02:08.62]偷摘水果被蜜蜂给叮到怕了 谁在偷笑呢\n[02:13.16]我靠着稻草人吹着风唱着歌睡着了\n[02:16.72]哦 哦 午后吉它在虫鸣中更清脆\n[02:19.58]哦 哦 阳光洒在路上就不怕心碎\n[02:22.53]珍惜一切 就算没有拥有\n[02:27.36]还记得你说家是唯一的城堡\n[02:31.24]随着稻香河流继续奔跑\n[02:34.18]微微笑 小时候的梦我知道\n[02:39.35]不要哭让萤火虫带着你逃跑\n[02:42.94]乡间的歌谣永远的依靠\n[02:45.91]回家吧 回到最初的美好\n[02:51.03]还记得你说家是唯一的城堡\n[02:54.55]随着稻香河流继续奔跑\n[02:57.62]微微笑 小时候的梦我知道\n[03:02.67]不要哭让萤火虫带着你逃跑\n[03:06.35]乡间的歌谣永远的依靠\n[03:09.23]回家吧 回到最初的美好', '/song/周杰伦-稻香.mp3', 'system', '2018-12-27 08:17:12', NULL, '2018-12-27 08:17:12');
INSERT INTO "Biz_Song" VALUES (10, 2, '周杰伦&潘儿-夜的第七章', '依然范特西', '/img/songPic/yedediqizhang.jpg', '[00:00.00] 作曲 : 周杰伦\n[00:01.00] 作词 : 黄俊郎\n[00:31.55]编曲：钟兴民，林迈可\n[00:42.99]1983年小巷12月晴朗\n[00:45.69]夜的第7章\n[00:46.84]打字机继续推向接近事实的那下一行\n[00:49.59]石楠烟斗的雾\n[00:51.00]飘向枯萎的树沉默的对我哭诉\n[00:54.18]贝克街旁的的圆形广场\n[00:56.43]盔甲战士臂上\n[00:57.87]鸢尾花的徽章微亮\n[01:00.15]无人马车声响深夜的拜访\n[01:02.39]邪恶在维多利亚的月光下血色的开场\n[01:05.45]消失的手枪焦黑的手杖\n[01:07.48]融化的蜡像谁不在场\n[01:09.26]珠宝箱上符号的假象\n[01:11.04]矛盾通往他堆砌的死巷\n[01:12.76]证据被完美埋葬\n[01:14.22]那嘲弄苏格兰警场的嘴角上扬\n[01:16.28]如果邪恶是华丽残酷的乐章（那么正义 是深沉无奈的惆怅）\n[01:21.95]他的终场我会亲手写上（那我就点亮 在灰烬中的微光）\n[01:27.45]晨曦的光风干最后一行忧伤（那么雨滴 会洗净黑暗的高墙）\n[01:33.03]黑色的墨染上安祥（散场灯关上 红色的布幕下降）\n[01:42.87]\n[02:04.82]事实只能穿向没有脚印的土壤\n[02:07.47]突兀的细微花香刻意显眼的服装\n[02:10.26]每个人为不同的理由戴着面具说谎\n[02:13.15]动机也只有一种名字那叫做欲望\n[02:16.00]far  farther  farther  far  far\n[02:17.37]the  father  father  far  far\n[02:18.80]越过人性的沼泽谁真的可以不被弄脏\n[02:21.57]我们可以遗忘原谅但必须\n[02:23.75]知道真相被移动\n[02:24.98]过的铁床那最后一块图终于拼上\n[02:27.28]我听见脚步声预料的软皮鞋跟\n[02:30.04]他推开门晚风晃了煤油灯一阵\n[02:32.77]打字机停在凶手的名称我转身\n[02:36.08]西敏寺的夜空开始沸腾\n[02:39.02]在胸口绽放艳丽的死亡\n[02:41.41]我品尝这最后一口甜美的真相\n[02:44.13]微笑回想正义只是安静的伸张\n[02:47.46]提琴在泰晤士\n[02:49.23]如果邪恶（我听见脚步声 预料的软皮鞋跟）\n[02:51.51]是华丽残酷的乐章（他推开门晚风晃了煤油灯一阵）\n[02:55.15]他的终场我会亲手写上（打字机停在凶手的名称我转身）\n[02:58.99]（西敏寺的夜空开始沸腾）\n[03:06.25]黑色的墨染上安祥\n[03:12.04]如果邪恶是华丽残酷的乐章\n[03:17.50]他的终场我会亲手写上\n[03:23.10]晨曦的光风干最后一行忧伤\n[03:28.68]黑色的墨染上安祥', '/song/周杰伦&潘儿-夜的第七章.mp3', 'system', '2018-12-27 08:26:27', 'system', '2022-11-25 16:21:37');
INSERT INTO "Biz_Song" VALUES (11, 2, '周杰伦-告白气球', '床边故事', '/img/songPic/gaobaiqiqui.jpg', '[00:00.00] 作曲 : 周杰伦\n[00:01.00] 作词 : 方文山\n[00:32.840] 塞纳河畔 左岸的咖啡\n[00:35.438] 我手一杯 品尝你的美\n[00:38.655] 留下唇印的嘴\n[00:43.273] 花店玫瑰 名字写错谁\n[00:46.159] 告白气球 风吹到对街\n[00:49.225] 微笑在天上飞\n[00:53.503] 你说你有点难追 想让我知难而退\n[00:58.374] 礼物不需挑最贵 只要香榭的落叶\n[01:04.141] 喔 营造浪漫的约会 不害怕搞砸一切\n[01:09.205] 拥有你就拥有 全世界\n[01:14.289] 亲爱的 爱上你 从那天起\n[01:20.520] 甜蜜的很轻易\n[01:25.040] 亲爱的 别任性 你的眼睛\n[01:31.189] 在说我愿意\n[01:57.772] 塞纳河畔 左岸的咖啡\n[02:00.373] 我手一杯 品尝你的美\n[02:03.323] 留下唇印的嘴\n[02:08.304] 花店玫瑰 名字写错谁\n[02:10.954] 告白气球 风吹到对街\n[02:14.125] 微笑在天上飞\n[02:18.302] 你说你有点难追 想让我知难而退\n[02:23.187] 礼物不需挑最贵 只要香榭的落叶\n[02:28.500] 喔 营造浪漫的约会 不害怕搞砸一切\n[02:33.745] 拥有你就拥有 全世界\n[02:39.115] 亲爱的 爱上你 从那天起\n[02:45.012] 甜蜜的很轻易\n[02:49.827] 亲爱的 别任性 你的眼睛\n[02:55.829] 在说我愿意\n[03:00.627] 亲爱的 爱上你 恋爱日记\n[03:06.656] 飘香水的回忆\n[03:11.150] 一整瓶 的梦境 全都有你\n[03:17.249] 搅拌在一起\n[03:21.813] 亲爱的别任性 你的眼睛\n[03:31.562] 在说我愿意', '/song/周杰伦-告白气球.mp3', 'system', '2018-12-27 08:45:24', NULL, '2018-12-27 08:45:24');
INSERT INTO "Biz_Song" VALUES (12, 2, '周杰伦-夜曲', '床边故事', '/img/songPic/gaobaiqiqui.jpg', '[00:23.310]一群嗜血的蚂蚁 被腐肉所吸引\n[00:27.490]我面无表情 看孤独的风景\n[00:30.540]失去你 爱恨开始分明\n[00:33.030]失去你 还有什N事好关心\n[00:35.770]当鸽子不再象徵和平\n[00:37.550]我终于被提醒\n[00:38.910]广场上喂食的是秃鹰\n[00:41.580]我用漂亮的押韵\n[00:43.030]形容被掠夺一空的爱情\n[00:46.720]啊 乌云开始遮蔽 夜色不干净\n[00:49.520]公园里 葬礼的回音 在漫天飞行\n[00:52.380]送你的 白色玫瑰\n[00:53.820]在纯黑的环境凋零\n[00:55.520]乌鸦在树枝上诡异的很安静\n[00:57.880]静静听 我黑色的大衣\n[00:59.870]想温暖你 日渐冰冷的回忆\n[01:02.220]走过的 走过的 生命\n[01:03.650]啊 四周弥漫雾气\n[01:05.070]我在空旷的墓地\n[01:06.340]老去后还爱你\n[01:07.430]为你弹奏萧邦的夜曲\n[01:11.550]纪念我死去的爱情\n[01:14.300]跟夜风一样的声音\n[01:17.030]心碎的很好听\n[01:19.830]手在键盘敲很轻\n[01:22.570]我给的思念很小心\n[01:25.300]你埋葬的地方叫幽冥\n[01:29.990]为你弹奏萧邦的夜曲\n[01:33.570]纪念我死去的爱情\n[01:36.340]而我为你隐姓埋名\n[01:39.150]在月光下弹琴\n[01:41.900]对你心跳的感应\n[01:44.670]还是如此温热亲近\n[01:47.410]怀念你那鲜红的唇印\n[01:53.270]\n[02:14.540]那些断翅的蜻蜓 散落在这森林\n[02:17.600]而我的眼睛 没有丝毫同情\n[02:20.450]失去你 泪水混浊不清\n[02:22.950]失去你 我连笑容都有阴影\n[02:25.680]风在长满青苔的屋顶\n[02:27.310]嘲笑我的伤心\n[02:29.170]像一口没有水的枯井\n[02:31.510]我用凄美的字型\n[02:33.030]描绘后悔莫及的那爱情\n[02:36.590]为你弹奏萧邦的夜曲\n[02:39.380]纪念我死去的爱情\n[02:42.100]跟夜风一样的声音\n[02:44.890]心碎的很好听\n[02:47.640]手在键盘敲很轻\n[02:50.370]我给的思念很小心\n[02:53.150]你埋葬的地方叫幽冥\n[02:57.700]为你弹奏萧邦的夜曲\n[03:01.360]纪念我死去的爱情\n[03:04.220]而我为你隐姓埋名 在月光下弹琴\n[03:09.620]对你心跳的感应 还是如此温热亲近\n[03:15.170]怀念你那鲜红的唇印\n[03:20.810]一群嗜血的蚂蚁 被腐肉所吸引\n[03:23.630]我面无表情 看孤独的风景\n[03:26.660]失去你 爱恨开始分明\n[03:29.070]失去你 还有什N事好关心\n[03:31.860]当鸽子不再象徵和平\n[03:33.560]我终于被提醒\n[03:35.320]广场上喂食的是秃鹰\n[03:37.670]我用漂亮的押韵\n[03:38.970]形容被掠夺一空的爱情', '/song/周杰伦-夜曲.mp3', 'system', '2018-12-30 02:11:23', NULL, '2018-12-30 02:11:23');
INSERT INTO "Biz_Song" VALUES (13, 2, '周杰伦-红尘客栈', '十二新作', '/img/songPic/hongchengkezhan.jpg', '[by:青蒿素]\n[00:00.00] 作曲 : 周杰伦\n[00:01.00] 作词 : 方文山\n[00:04.803] 编曲：黄雨勋\n[00:07.032]\n[00:22.628] 天涯的尽头是风沙\n[00:28.000] 红尘的故事叫牵挂\n[00:33.282] 封刀隐没在寻常人家 东篱下\n[00:38.902] 闲云野鹤古刹\n[00:44.099] 快马在江湖里厮杀\n[00:49.339] 无非是名跟利放不下\n[00:54.603] 心中有江山的人岂能快意潇洒\n[01:00.090] 我只求与你共华发\n[01:07.466] 剑出鞘恩怨了 谁笑\n[01:12.296] 我只求今朝拥你入怀抱\n[01:17.706] 红尘客栈风似刀\n[01:21.615] 骤雨落宿命敲\n[01:26.716] 任武林谁领风骚\n[01:29.107] 我却只为你折腰\n[01:33.619] 过荒村野桥寻世外古道\n[01:38.999] 远离人间尘嚣\n[01:41.553] 柳絮飘 执子之手逍遥\n[01:51.203]\n[02:06.759] 檐下窗棂斜映枝桠\n[02:11.979] 与你席地对座饮茶\n[02:17.305] 我以工笔画将你牢牢地记下\n[02:23.039] 提笔不为风雅\n[02:27.989] 灯下叹红颜近晚霞\n[02:32.946] 我说缘份一如参禅不说话\n[02:38.756] 你泪如梨花洒满了纸上的天下\n[02:44.245] 爱恨如写意山水画\n[02:51.637] 剑出鞘恩怨了 谁笑\n[02:56.249] 我只求今朝拥你入怀抱\n[03:01.516] 红尘客栈风似刀\n[03:05.653] 骤雨落宿命敲\n[03:10.799] 任武林谁领风骚\n[03:13.186] 我却只为你折腰\n[03:17.523] 过荒村野桥寻世外古道\n[03:22.758] 远离人间尘嚣\n[03:25.467] 柳絮飘 执子之手逍遥\n[03:30.838]\n[03:48.576] 任武林谁领风骚\n[03:50.734] 我却只为你折腰\n[03:54.926] 你回眸多娇我泪中带笑\n[04:00.316] 酒招旗风中萧萧\n[04:04.376] 剑出鞘恩怨了', '/song/周杰伦-红尘客栈.mp3', 'system', '2018-12-30 02:23:53', NULL, '2018-12-30 02:23:53');
INSERT INTO "Biz_Song" VALUES (14, 2, '周杰伦-开不了口', '范特西', '/img/songPic/kaibulkou.jpg', '[00:00.00] 作曲 : 周杰伦\n[00:01.00] 作词 : 徐若瑄\n[00:27.330]才离开没多久就开始  担心今天的你过得好不好\n[00:34.140]整个画面是你  想你想的睡不着\n[00:39.040]\n[00:40.920]嘴嘟嘟那可爱的模样  还有在你身上香香的味道\n[00:47.600]我的快乐是你  想你想的都会笑\n[00:53.790]\n[00:56.820]没有你在我有多难熬（没有你在我有多难熬多烦恼）\n[01:04.260]没有你烦我有多烦恼（没有你烦我有多烦恼多难熬）\n[01:07.850]\n[01:08.580]穿过云层  我试着努力向你奔跑\n[01:14.580]爱才送到  你却已在别人怀抱\n[01:20.190]\n[01:21.640]就是开不了口  让她知道\n[01:26.780]我一定会呵护着你  也逗你笑\n[01:34.180]你对我有多重要  我后悔没  让你知道\n[01:41.140]安静的听你撒娇  看你睡着  一直到老\n[01:47.270]\n[01:48.600]就是开不了口  让她知道\n[01:54.360]就是那么简单几句  我办不到\n[02:01.640]整颗心悬在半空  我只能够  远远看着\n[02:08.580]这些我都做得到  但那个人已经不是我\n[02:15.910]\n[02:44.140]没有你在我有多难熬（没有你在我有多难熬多烦恼）\n[02:50.940]没有你烦我有多烦恼（没有你烦我有多烦恼多难熬）\n[02:57.350]\n[02:57.930]穿过云层  我试着努力向你奔跑\n[03:04.270]爱才送到  你却已在别人怀抱\n[03:10.060]\n[03:11.460]就是开不了口  让她知道\n[03:16.800]我一定会呵护着你  也逗你笑\n[03:23.910]你对我有多重要  我后悔没  让你知道\n[03:30.980]安静的听你撒娇  看你睡着  一直到老\n[03:37.480]\n[03:39.700]就是开不了口  让她知道\n[03:44.380]就是那么简单几句  我办不到\n[03:51.450]整颗心悬在半空  我只能够  远远看着\n[03:58.410]这些我都做得到  但那个人已经不是我\n[04:20.750]\n[04:21.340]我总是开不了口 我总是开不了口\n[04:27.390]我只能够远远地看着你 开不了口', '/song/周杰伦-开不了口.mp3', 'system', '2018-12-30 02:36:08', NULL, '2018-12-30 02:36:08');
INSERT INTO "Biz_Song" VALUES (15, 2, '周杰伦-菊花台', '依然范特西', '/img/songPic/juhuatai.jpg', '[by:立酱]\n[00:00.00] 作曲 : 周杰伦\n[00:00.200] 作词 : 方文山\n[00:00.600]编曲：钟兴民\n[00:01.600]制作人：周杰伦\n[00:02.600]吉他：蔡科俊Again\n[00:03.600]弦乐编写：钟兴民\n[00:04.600]Programmer：魏百谦\n[00:05.600]弦乐团：中国爱乐\n[00:06.600]录音工程：杨瑞代\n[00:07.600]录音室：ALFA STUDIO\n[00:08.600]混音工程：杨大纬\n[00:09.600]混音录音室：杨大纬录音工作室\n[00:10.600]弦乐录音师：李岳松(北京)/魏百谦(台北)\n[00:11.600]弦乐录音室：计划生育录音室(北京)/Room19 Studio (台北)\n[00:35.900]你的泪光\n[00:39.400]柔弱中带伤\n[00:42.850]惨白的月弯弯\n[00:46.350]勾住过往\n[00:49.860]夜 太漫长\n[00:53.360]凝结成了霜\n[00:56.720]是谁在阁楼上冰冷地绝望\n[01:03.820]雨 轻轻弹\n[01:07.370]朱红色的窗\n[01:10.780]我一生在纸上被风吹乱\n[01:17.730]梦 在远方\n[01:21.290]化成一缕香\n[01:24.690]随风飘散\n[01:27.250]你的模样\n[01:34.510]菊花残 满地伤\n[01:37.770]你的笑容已泛黄\n[01:42.190]花落人断肠\n[01:44.640]我心事静静淌\n[01:48.200]北风乱 夜未央\n[01:51.550]你的影子剪不断\n[01:56.000]徒留我孤单在湖面成双\n[02:30.900]花 已向晚\n[02:34.360]飘落了灿烂\n[02:37.810]凋谢的世道上\n[02:41.270]命运不堪\n[02:44.820]愁 莫渡江\n[02:48.440]秋心拆两半\n[02:51.640]怕你上不了岸\n[02:55.000]一辈子摇晃\n[02:58.850]谁 的江山\n[03:02.310]马蹄声狂乱\n[03:05.760]我一身的戎装\n[03:09.220]呼啸沧桑\n[03:12.720]天 微微亮\n[03:16.170]你轻声地叹\n[03:19.730]一夜惆怅 如此委婉\n[03:29.430]菊花残 满地伤\n[03:32.640]你的笑容已泛黄\n[03:37.160]花落人断肠\n[03:39.610]我心事静静淌\n[03:43.110]北风乱 夜未央\n[03:46.520]你的影子剪不断\n[03:50.970]徒留我孤单在湖面成双\n[04:00.700]菊花残 满地伤\n[04:03.950]你的笑容已泛黄\n[04:08.400]花落人断肠\n[04:10.900]我心事静静淌\n[04:14.410]北风乱 夜未央\n[04:17.910]你的影子剪不断\n[04:25.100]徒留我孤单在湖面成双', '/song/周杰伦-菊花台.mp3', 'system', '2018-12-30 02:42:47', NULL, '2018-12-30 02:42:47');
INSERT INTO "Biz_Song" VALUES (16, 2, '周杰伦-牛仔很忙', '我很忙', '/img/songPic/nuizaihenmang.jpg', '[by:立酱]\n[00:00.00] 作曲 : 周杰伦\n[00:01.00] 作词 : 黄俊郎\n[00:03.00]编曲：钟兴民\n[00:04.00]制作人：周杰伦\n[00:05.00]吉他：蔡科俊Again\n[00:06.00]弦乐编写：周杰伦\n[00:07.00]小提琴：王宜桢\n[00:08.00]合声编写：周杰伦\n[00:09.00]合声：周杰伦\n[00:10.00]录音师：杨瑞代\n[00:11.00]录音室：JVR STUDIO\n[00:12.00]混音师：杨大纬\n[00:13.00]混音录音室：杨大纬录音工作室\n[00:16.35]呜啦啦啦火车笛\n[00:18.16]随着奔腾的马蹄\n[00:20.26]小妹妹吹着口琴\n[00:22.20]夕阳下美了剪影\n[00:24.05]我用子弹写日记\n[00:25.95]介绍完了风景\n[00:27.75]接下来换介绍我自己\n[00:31.91]我虽然是个牛仔\n[00:33.71]在酒吧只点牛奶\n[00:35.72]为什么不喝啤酒\n[00:37.57]因为啤酒伤身体\n[00:39.52]很多人不长眼睛\n[00:41.47]嚣张都靠武器\n[00:43.42]赤手空拳就缩成蚂蚁\n[00:47.60]不用麻烦了 不用麻烦了\n[00:48.95]不用麻烦 不用麻烦了\n[00:50.35]不用麻烦了\n[00:51.45]你们一起上 我在赶时间\n[00:52.80]每天决斗 观众都累了\n[00:53.96]英雄也累了\n[00:55.10]不用麻烦了 不用麻烦了\n[00:56.66]副歌不长 你们有几个\n[00:57.96]一起上好了\n[00:59.11]正义呼唤我 美女需要我\n[01:00.52]牛仔很忙的\n[01:26.24]我啦啦啦骑毛驴\n[01:27.94]因为马跨不上去\n[01:29.86]洗澡都洗泡泡浴\n[01:31.72]因为可以玩玩具\n[01:33.62]我有颗善良的心\n[01:35.53]都只穿假牛皮\n[01:37.68]喔跌倒时尽量不压草皮\n[01:41.64]枪口它没长眼睛\n[01:43.39]我曾经答应上帝\n[01:45.34]除非是万不得已\n[01:47.19]我尽量射橡皮筋\n[01:49.29]老板先来杯奶昔\n[01:50.99]要逃命前请你\n[01:53.15]顺便喂喂我那只小毛驴\n[01:57.41]不用麻烦了 不用麻烦了\n[01:58.73]不用麻烦 不用麻烦了\n[01:59.98]不用麻烦了\n[02:00.68]你们一起上 我在赶时间\n[02:02.53]每天决斗 观众都累了\n[02:03.93]英雄也累了\n[02:04.63]不用麻烦了 不用麻烦了\n[02:06.14]副歌不长 你们有几个\n[02:07.44]一起上好了\n[02:08.67]正义呼唤我 美女需要我\n[02:10.28]牛仔很忙的\n[02:28.18]不用麻烦了 不用麻烦了\n[02:29.58]不用麻烦 不用麻烦了\n[02:30.78]不用麻烦了\n[02:32.07]你们一起上 我在赶时间\n[02:33.62]每天决斗 观众都累了\n[02:34.88]英雄也累了\n[02:35.58]不用麻烦了 不用麻烦了\n[02:37.18]副歌不长 你们有几个\n[02:38.43]一起上好了\n[02:39.87]正义呼唤我 美女需要我\n[02:41.37]牛仔很忙的', '/song/周杰伦-牛仔很忙.mp3', 'system', '2018-12-30 02:48:47', NULL, '2018-12-30 02:48:47');
INSERT INTO "Biz_Song" VALUES (17, 2, '周杰伦-烟花易冷', '跨时代', '/img/songPic/yanhuayileng.jpg', '[by:立酱]\n[00:00.00] 作曲 : 周杰伦\n[00:01.00] 作词 : 方文山\n[00:03.00]编曲：黄雨勋\n[00:04.00]制作人：周杰伦\n[00:05.00]录音师：杨瑞代Gary\n[00:06.00]录音室：JVR Studio\n[00:07.00]混音工程：杨大纬录音工作室\n[00:12.09]繁华声 遁入空门 折煞了世人\n[00:18.01]梦偏冷 辗转一生 情债又几本\n[00:24.32]如你默认 生死枯等\n[00:30.55]枯等一圈 又一圈的 年轮\n[00:36.99]浮图塔 断了几层 断了谁的魂\n[00:43.28]痛直奔 一盏残灯 倾塌的山门\n[00:49.26]容我再等 历史转身\n[00:55.74]等酒香醇 等你弹 一曲古筝\n[01:02.17]雨纷纷 旧故里草木深\n[01:08.58]我听闻 你始终一个人\n[01:14.35]斑驳的城门 盘踞着老树根\n[01:20.65]石板上回荡的是 再等\n[01:26.93]雨纷纷 旧故里草木深\n[01:32.97]我听闻 你仍守着孤城\n[01:39.40]城郊牧笛声 落在那座野村\n[01:45.76]缘份落地生根是 我们\n[01:54.98]听青春 迎来笑声 羡煞许多人\n[02:01.37]那史册 温柔不肯 下笔都太狠\n[02:07.39]烟花易冷 人事易分\n[02:13.51]而你在问 我是否还 认真\n[02:19.70]千年后 累世情深 还有谁在等\n[02:25.80]而青史 岂能不真 魏书洛阳城\n[02:32.08]如你在跟 前世过门\n[02:39.02]跟着红尘 跟随我 浪迹一生\n[02:44.97]雨纷纷 旧故里草木深\n[02:50.96]我听闻 你始终一个人\n[02:57.47]斑驳的城门 盘踞着老树根\n[03:03.61]石板上回荡的是 再等\n[03:09.78]雨纷纷 旧故里草木深\n[03:15.95]我听闻 你仍守着孤城\n[03:22.40]城郊牧笛声 落在那座野村\n[03:28.68]缘份落地生根是 我们\n[03:35.34]雨纷纷 旧故里草木深\n[03:37.64]我听闻 你始终一个人\n[03:39.60]斑驳的城门 盘踞着老树根\n[03:41.47]石板上回荡的是 再等\n[03:42.89]雨纷纷 雨纷纷 旧故里草木深\n[03:44.77]我听闻 我听闻 你仍守着孤城\n[03:47.48]城郊牧笛声 落在那座野村\n[03:52.16]缘份落地生根是 我们\n[03:59.91]缘份落地生根是 我们\n[04:05.74]伽蓝寺听雨声盼 永恒', '/song/周杰伦-烟花易冷.mp3', 'system', '2018-12-30 02:57:23', NULL, '2018-12-30 02:57:23');
INSERT INTO "Biz_Song" VALUES (18, 2, '周杰伦-听妈妈的话', '依然范特西', '/img/songPic/yanhuayileng.jpg', '[00:08.619]小朋友你是否有很多问号\n[00:12.049]为什么 别人在那看漫画 我却在学画画 对着钢琴说话\n[00:17.100]别人在玩游戏 我却靠在墙壁背我的ABC\n[00:20.359]我说我要一个大大的飞机 但却得到一台旧旧录音机\n[00:25.319]为什么要听妈妈的话 长大后你就会开始懂了这段话\n[00:30.278]长大后我开始明白\n[00:32.948]为什么我跑得比别人快 飞得比别人高\n[00:35.728]将来大家看的都是我画的漫画 大家唱的都是我写的歌\n[00:40.868]妈妈的辛苦不让你看见 温暖的食谱在她心里面\n[00:46.048]有空就多多握握她的手 把手牵着一起梦游\n[00:50.988]听妈妈的话 别让她受伤 想快快长大 才能保护她\n[01:10.300]美丽的白发 幸福中发芽 天使的魔法 温暖中慈祥\n[01:30.219]在你的未来 音乐是你的王牌 拿王牌谈个恋爱\n[01:36.180]唉!我不想把你教坏 还是听妈妈的话吧 晚点再恋爱吧\n[01:40.109]我知道你未来的路 但妈比我更清楚\n[01:42.997]你会开始学其他同学在书包写东写西\n[01:46.658]但我建议最好写妈妈我会用功读书\n[01:48.219]用功读书 怎么会从我嘴巴说出\n[01:50.348]不想你输 所以要叫你用功读书\n[01:52.988]妈妈织给你的毛衣 你要好好的收着\n[01:56.180]因为母亲节到时 我要告诉她我还留着\n[01:57.988]对了 我会遇到周润发\n[01:59.949]所以你可以跟同学炫耀赌神未来是你爸爸\n[02:02.798]我找不到童年写的情书 你写完不要送人\n[02:06.349]因为过两天你会在操场上捡到\n[02:08.999]你会开始喜欢上流行歌 因为张学友开始准备唱吻别\n[02:13.009]听妈妈的话 别让她受伤 想快快长大 才能保护她\n[02:32.299]美丽的白发 幸福中发芽 天使的魔法 温暖中慈祥\n[02:52.727]听妈妈的话 别让她受伤 想快快长大 才能保护她\n[03:13.699]长大后我开始明白\n[03:18.199]为什么我跑得比别人快 飞得比别人高\n[03:20.929]将来大家看的都是我画的漫画 大家唱的都是我写的歌\n[03:26.099]妈妈的辛苦不让你看见 温暖的食谱在她心里面\n[03:31.227]有空就多多握握她的手 把手牵着一起梦游\n[03:36.239]听妈妈的话 别让她受伤 想快快长大 才能保护她\n[03:54.939]美丽的白发 幸福中发芽 天使的魔法 温暖中慈祥', '/song/周杰伦-听妈妈的话.mp3', 'system', '2018-12-30 03:08:45', NULL, '2018-12-30 03:08:45');
INSERT INTO "Biz_Song" VALUES (19, 2, '周杰伦-七里香', '七里香', '/img/songPic/qilixiang.jpg', '[00:00.00] 作曲 : 周杰伦\n[00:01.00] 作词 : 方文山\n[00:27.430]窗外的麻雀 在电线杆上多嘴\n[00:34.330]你说这一句 很有夏天的感觉\n[00:40.980]手中的铅笔 在纸上来来回回\n[00:47.300]我用几行字形容你是我的谁\n[00:54.030]秋刀鱼的滋味 猫跟你都想了解\n[01:01.100]初恋的香味就这样被我们寻回\n[01:07.400]那温暖的阳光 像刚摘的鲜艳草莓\n[01:14.140]你说你舍不得吃掉这一种感觉\n[01:20.450]雨下整夜 我的爱溢出就像雨水\n[01:27.240]院子落叶 跟我的思念厚厚一叠\n[01:33.920]几句是非 也无法将我的热情冷却\n[01:41.510]你出现在我诗的每一页\n[01:47.470]雨下整夜 我的爱溢出就像雨水\n[01:54.120]窗台蝴蝶 像诗里纷飞的美丽章节\n[02:00.840]我接着写 把永远爱你写进诗的结尾\n[02:08.350]你是我唯一想要的了解\n[02:14.660]\n[02:41.250]雨下整夜 我的爱溢出就像雨水\n[02:47.850]院子落叶 跟我的思念厚厚一叠\n[02:54.550]几句是非 也无法将我的热情冷却\n[03:02.150]你出现在我诗的每一页\n[03:07.790]\n[03:08.510]那饱满的稻穗 幸福了这个季节\n[03:15.850]而你的脸颊像田里熟透的蕃茄\n[03:21.870]你突然对我说 七里香的名字很美\n[03:28.560]我此刻却只想亲吻你倔强的嘴\n[03:35.010]雨下整夜 我的爱溢出就像雨水\n[03:41.680]院子落叶 跟我的思念厚厚一叠\n[03:48.300]几句是非 也无法将我的热情冷却\n[03:55.900]你出现在我诗的每一页\n[04:02.360]整夜 我的爱溢出就像雨水\n[04:08.520]窗台蝴蝶 像诗里纷飞的美丽章节\n[04:15.470]我接着写 把永远爱你写进诗的结尾\n[04:22.770]你是我唯一想要的了解\n[04:29.280]', '/song/周杰伦-七里香.mp3', 'system', '2018-12-30 03:13:15', NULL, '2018-12-30 03:13:15');
INSERT INTO "Biz_Song" VALUES (20, 2, '周杰伦-晴天', '叶惠美', '/img/songPic/qingtian.jpg', '[00:00.00] 作曲 : 周杰伦\n[00:01.00] 作词 : 周杰伦\n[00:28.950]故事的小黄花\n[00:32.380]从出生那年就飘着\n[00:35.870]童年的荡秋千\n[00:39.370]随记忆一直晃到现在\n[00:42.440]ㄖㄨㄟ ㄙㄡ ㄙㄡ ㄒ一 ㄉㄡ ㄒ一ㄌㄚ\n[00:45.530]ㄙㄡ ㄌㄚ ㄒ一 ㄒ一 ㄒ一 ㄒ一 ㄌㄚ ㄒ一 ㄌㄚ ㄙㄡ\n[00:49.570]吹着前奏望着天空\n[00:52.870]我想起花瓣试着掉落\n[00:56.410]为你翘课的那一天\n[00:58.550]花落的那一天\n[01:00.190]教室的那一间\n[01:01.990]我怎么看不见\n[01:03.880]消失的下雨天\n[01:05.410]我好想再淋一遍\n[01:09.750]没想到失去的勇气我还留着\n[01:15.530]好想再问一遍\n[01:17.520]你会等待还是离开\n[01:24.500]刮风这天我试过握着你手\n[01:30.080]但偏偏雨渐渐大到我看你不见\n[01:38.450]还要多久我才能在你身边\n[01:44.870]等到放晴的那天也许我会比较好一点\n[01:52.330]从前从前有个人爱你很久\n[01:57.960]但偏偏风渐渐把距离吹得好远\n[02:06.240]好不容易又能再多爱一天\n[02:12.910]但故事的最后你好像还是说了拜拜\n[02:21.990]\n[02:34.660]为你翘课的那一天\n[02:36.500]花落的那一天\n[02:38.300]教室的那一间\n[02:40.040]我怎么看不见\n[02:41.780]消失的下雨天\n[02:43.680]我好想再淋一遍\n[02:47.610]没想到失去的勇气我还留着\n[02:54.090]好想再问一遍\n[02:55.650]你会等待还是离开\n[03:02.470]刮风这天我试过握着你手\n[03:07.900]但偏偏雨渐渐大到我看你不见\n[03:16.420]还要多久我才能在你身边\n[03:22.900]等到放晴的那天也许我会比较好一点\n[03:30.310]从前从前有个人爱你很久\n[03:36.440]偏偏风渐渐把距离吹得好远\n[03:44.290]好不容易又能再多爱一天\n[03:50.770]但故事的最后你好像还是说了拜拜\n[03:58.010]刮风这天我试过握着你手\n[04:01.760]但偏偏雨渐渐大到我看你不见\n[04:05.050]还要多久我才能够在你身边\n[04:08.630]等到放晴那天也许我会比较好一点\n[04:12.570]从前从前有个人爱你很久\n[04:15.510]但偏偏雨渐渐把距离吹得好远\n[04:18.950]好不容易又能再多爱一天\n[04:22.430]但故事的最后你好像还是说了拜', '/song/周杰伦-晴天.mp3', 'system', '2018-12-30 03:17:20', NULL, '2018-12-30 03:17:20');
INSERT INTO "Biz_Song" VALUES (21, 3, '林允儿-月亮代表我的心', 'Blossom', '/img/songPic/264ee69608b543ba935097544946f9c3.jpg', '[00:00.00] 作曲 : 翁清溪\n[00:01.00] 作词 : 孙仪\n[00:09.54]编曲 : 이재명\n[00:11.67]你问我爱你有多深　\n[00:17.32]我爱你有几分\n[00:22.72]我的情也真　\n[00:25.49]我的爱也真　\n[00:28.39]月亮代表我的心\n[00:34.02]\n[00:34.46]你问我爱你有多深　\n[00:40.13]我爱你有几分\n[00:45.51]我的情不移　\n[00:48.56]我的爱不变　\n[00:51.26]月亮代表我的心\n[00:56.25]\n[00:56.92]轻轻的一个吻\n[01:02.74]已经打动我的心\n[01:08.43]深深的一段情　\n[01:14.13]叫我思念到如今\n[01:19.23]\n[01:20.11]你问我爱你有多深　\n[01:25.81]我爱你有几分\n[01:31.23]你去想一想\n[01:34.11]你去看一看　\n[01:36.92]月亮代表我的心\n[01:42.08]\n[01:54.15]轻轻的一个吻\n[01:59.83]已经打动我的心\n[02:05.59]深深的一段情　\n[02:11.21]叫我思念到如今\n[02:16.62]\n[02:17.27]你问我爱你有多深　\n[02:23.10]我爱你有几分\n[02:28.40]你去想一想\n[02:31.25]你去看一看　\n[02:34.16]月亮代表我的心\n[02:38.92]\n[02:39.76]你去想一想\n[02:42.66]你去看一看　\n[02:45.56]月亮代表我的心\n[03:03.30]', '/song/林允儿-月亮代表我的心.mp3', 'system', '2018-12-30 03:26:32', NULL, '2022-04-10 15:45:53');
INSERT INTO "Biz_Song" VALUES (22, 3, '林允儿-小幸运', 'Blossom', '/img/songPic/8fe963a70b1541d1b5a1e5a21de19a41.jpg', '[00:00.00] 作曲 : JerryC\n[00:01.00] 作词 : 徐世珍/吴辉福\n[00:12.97]编曲 : 추대관\n[00:13.18]我听见雨滴落在青青草地\n[00:19.45]我听见远方下课钟声响起\n[00:25.38]可是我没有听见你的声音\n[00:30.36]认真 呼唤 我姓名\n[00:35.69]\n[00:37.68]爱上你的时候还不懂感情\n[00:43.87]离别了才觉得刻骨铭心\n[00:50.00]为什么没有发现遇见了你\n[00:54.60]是生命最好的事情\n[00:59.72]\n[01:00.39]也许当时忙着 微笑和哭泣\n[01:06.50]忙着追逐天空中的流星\n[01:12.30]人理所当然的忘记\n[01:16.87]是谁风里雨里一直 默默守护在原地\n[01:24.26]\n[01:24.68]原来你是我 最想留住的幸运\n[01:30.07]原来我们和爱情 曾经靠得那么近\n[01:36.10]那为我对抗世界的决定\n[01:40.79]那陪我淋的雨\n[01:43.86]一幕幕都是你 一尘不染的真心\n[01:51.20]与你相遇 好幸运\n[01:54.58]可我已失去为你 泪流满面的权利\n[02:00.75]但愿在我看不到的天际\n[02:05.38]你张开了双翼\n[02:08.53]遇见你的注定\n[02:13.27]她会有多幸运\n[02:17.64]\n[02:26.73]原来你是我 最想留住的幸运\n[02:31.54]原来我们和爱情 曾经靠得那么近\n[02:37.69]但愿在我看不到的天际\n[02:42.32]你张开了双翼\n[02:45.48]遇见你的注定\n[02:53.18]她会有多幸运\n[02:58.15]', '/song/林允儿-小幸运.mp3', 'system', '2018-12-30 03:31:39', NULL, '2018-12-30 03:31:39');
INSERT INTO "Biz_Song" VALUES (23, 3, '林允儿-红豆', 'Blossom', '/img/songPic/ef144cfbbd0f4706bd483412ab997ee9.jpg', '[00:00.00] 作曲 : 柳重言\n[00:01.00] 作词 : 林夕\n[00:15.28]编曲 : 추대관\n[00:16.70]还没好好的感受 雪花绽放的气候\n[00:25.13]我们一起颤抖 会更明白 什么是温柔\n[00:33.74]还没跟你牵着手 走过荒芜的沙丘\n[00:42.21]可能从此以后 学会珍惜 天长和地久\n[00:50.95]有时候 有时候 我会相信一切有尽头\n[00:59.40]相聚离开 都有时候 没有什么会永垂不朽\n[01:07.97]可是我 有时候 宁愿选择留恋不放手\n[01:16.55]等到风景都看透\n[01:20.78]也许你会陪我看 细水长流\n[01:42.38]还没为你把红豆 熬成缠绵的伤口\n[01:50.94]然后一起分享 会更明白 相思的哀愁\n[01:59.46]还没好好的感受 醒着亲吻的温柔\n[02:08.02]可能在我左右 你才追求 孤独的自由\n[02:18.78]有时候 有时候 我会相信一切有尽头\n[02:27.29]相聚离开 都有时候 没有什么会永垂不朽\n[02:35.87]可是我 有时候 宁愿选择留恋不放手\n[02:44.47]等到风景都看透\n[02:48.65]也许你会陪我看 细水长流\n[03:08.22]有时候 有时候 我会相信一切有尽头\n[03:16.52]相聚离开 都有时候 没有什么会永垂不朽\n[03:25.15]可是我 有时候 宁愿选择留恋不放手\n[03:33.73]等到风景都看透\n[03:38.01]也许你会陪我看 细水长流\n[03:46.33]', '/song/林允儿-红豆.mp3', 'system', '2018-12-30 04:00:19', NULL, '2018-12-30 04:00:19');
INSERT INTO "Biz_Song" VALUES (24, 4, '陈奕迅-红玫瑰', 'The 1st Eleven Years 然后呢?', '/img/songPic/hongmeigui.jpg', '[ar:陈奕迅]\n[00:00.00] 作曲 : 梁翘柏\n[00:01.00] 作词 : 李焯雄\n[00:16.32]梦里梦到醒不来的梦\n[00:18.92]红线里被软禁的红\n[00:23.62]所有刺激剩下疲乏的痛\n[00:26.82]再无动于衷\n[00:30.12]从背后抱你的时候\n[00:34.02]期待的却是她的面容\n[00:37.75]说来实在嘲讽我不太懂\n[00:41.35]偏渴望你懂\n[00:44.75]是否幸福轻得太沉重\n[00:48.50]过度使用不痒不痛\n[00:52.31]烂熟透红空洞了的瞳孔\n[00:56.56]终于掏空终于有始无终\n[00:59.81]得不到的永远在骚动\n[01:03.41]被偏爱的都有恃无恐\n[01:07.11]玫瑰的红容易受伤的梦\n[01:11.46]握在手中却流失于指缝\n[01:14.96]又落空\n[01:31.02]红是朱砂痣烙印心口\n[01:33.82]红是蚊子血般平庸\n[01:38.73]时间美化那仅有的悸动\n[01:41.82]也磨平激动\n[01:45.12]从背后抱你的时候\n[01:48.98]期待的却是她的面容\n[01:52.82]说来实在嘲讽\n[01:55.15]我不太懂偏渴望你懂\n[01:59.85]是否幸福轻得太沉重\n[02:03.60]过度使用不痒不痛\n[02:07.10]烂熟透红空洞了的瞳孔\n[02:11.45]终于掏空终于有始无终\n[02:14.70]得不到的永远在骚动\n[02:18.50]被偏爱的都有恃无恐\n[02:22.35]玫瑰的红容易受伤的梦\n[02:26.35]握在手中却流失于指缝\n[02:29.75]又落空\n[02:44.99]是否说爱都太过沉重\n[02:48.54]过度使用不痒不痛\n[02:52.24]烧得火红蛇行缠绕心中\n[02:56.34]终于冷冻终于有始无终\n[02:59.74]得不到的永远在骚动\n[03:03.49]被偏爱的都有恃无恐\n[03:07.24]玫瑰的红容易受伤的梦\n[03:11.39]握在手中却流失于指缝\n[03:14.84]得不到的永远在骚动\n[03:18.49]被偏爱的都有恃无恐\n[03:22.34]玫瑰的红伤口绽放的梦\n[03:26.44]握在手中却流失于指缝\n[03:29.79]再落空', '/song/陈奕迅-红玫瑰.mp3', 'system', '2018-12-30 04:21:48', NULL, '2018-12-30 04:21:48');
INSERT INTO "Biz_Song" VALUES (25, 4, '陈奕迅 + 王菲-因为爱情', 'Stranger Under My Skin', '/img/songPic/yinweiaiqing.jpg', '[00:00.00] 作曲 : 小柯\n[00:01.00] 作词 : 小柯\n[00:11.739]给你一张过去的CD\n[00:16.299]听听那时我们的爱情\n[00:21.340]有时会突然忘了我还在爱着你\n[00:30.990]\n[00:33.390]再唱不出那样的歌曲\n[00:37.690]听到都会红着脸躲避\n[00:43.140]虽然会经常忘了我依然爱着你\n[00:52.110]\n[00:53.790]因为爱情 不会轻易悲伤\n[00:59.540]所以一切都是幸福的模样\n[01:05.129]因为爱情 简单的生长\n[01:10.730]依然随时可以为你疯狂\n[01:15.200]\n[01:16.000]因为爱情 怎么会有沧桑\n[01:21.350]所以我们还是年轻的模样\n[01:26.890]因为爱情 在那个地方\n[01:32.530]依然还有人在那里游荡人来人往\n[01:42.128]\n[02:00.730]再唱不出那样的歌曲\n[02:05.300]听到都会红着脸躲避\n[02:10.509]虽然会经常忘了我依然爱着你\n[02:20.510]\n[02:20.779]因为爱情 不会轻易悲伤\n[02:26.820]所以一切都是幸福的模样\n[02:32.399]因为爱情 简单的生长\n[02:38.100]依然随时可以为你疯狂\n[02:42.140]\n[02:42.589]因为爱情 怎么会有沧桑\n[02:48.499]所以我们还是年轻的模样\n[02:54.700]因为爱情 在那个地方\n[02:59.909]依然还有人在那里游荡人来人往\n[03:09.279]\n[03:11.629]给你一张过去的CD\n[03:16.279]听听那时我们的爱情\n[03:21.640]有时会突然忘了我还在爱着你', '/song/陈奕迅 + 王菲-因为爱情.mp3', 'system', '2018-12-30 08:22:41', NULL, '2018-12-30 08:22:41');
INSERT INTO "Biz_Song" VALUES (26, 4, '陈奕迅-不要说话', '不想放手', '/img/songPic/buyaoshuohua.jpg', '[ti:不要说话]\n[ar:陈奕迅]\n[al:博儿Lrc试练]\n[by:博儿]\n[00:00.00] 作曲 : 小柯\n[00:01.00] 作词 : 小柯\n[00:18.77]深色的海面布满白色的月光\n[00:24.51]\n[00:25.11]我出神望着海 心不知飞哪去\n[00:31.64]听到她在告诉你\n[00:35.28]说她真的喜欢你\n[00:39.48]我不知该 躲哪里\n[00:47.17]爱一个人是不是应该有默契\n[00:54.15]我以为你懂得每当我看着你\n[01:00.07]我藏起来的秘密\n[01:03.67]在每一天清晨里\n[01:07.60]暖成咖啡 安静的拿给你\n[01:14.33]愿意 用一支黑色的铅笔\n[01:18.81]画一出沉默舞台剧\n[01:22.95]灯光再亮 也抱住你\n[01:28.53]愿意 在角落唱沙哑的歌\n[01:33.06]再大声也都是给你\n[01:37.24]请用心听 不要说话\n[01:51.54]爱一个人是不是应该要默契\n[01:58.36]我以为你懂得每当我看着你\n[02:04.34]我藏起来的秘密\n[02:08.22]在每一天清晨里\n[02:11.47]暖成咖啡 安静的拿给你\n[02:18.49]愿意 用一支黑色的铅笔\n[02:22.92]画一出沉默舞台剧\n[02:27.31]灯光再亮 也抱住你\n[02:33.04]愿意 在角落唱沙哑的歌\n[02:37.33]再大声也都是给你\n[02:41.46]请用心听 不要说话\n[03:15.81]愿意 用一支黑色的铅笔\n[03:19.95]画一出沉默舞台剧\n[03:24.43]灯光再亮 也抱住你\n[03:29.82]愿意 在角落唱沙哑的歌\n[03:34.19]再大声也都是给你\n[03:38.48]请原谅我 不会说话\n[03:44.11]愿意 用一支黑色的铅笔\n[03:48.55]画一出沉默舞台剧\n[03:52.68]灯光再亮 也抱住你\n[03:58.35]愿意 在角落唱沙哑的歌\n[04:02.84]再大声也都是给你\n[04:06.97]爱是用心吗 不要说话', '/song/陈奕迅-不要说话.mp3', 'system', '2018-12-30 08:30:03', NULL, '2018-12-30 08:30:03');
INSERT INTO "Biz_Song" VALUES (27, 5, 'G.E.M.邓紫棋-泡沫', 'Xposed', '/img/songPic/paomo.jpg', '[00:00.00] 作曲 : G.E.M.\n[00:00.169] 作词 : G.E.M.\n[00:00.509]阳光下的泡沫 是彩色的 就像被骗的我 是幸福的\n[00:14.940]追究什么对错 你的谎言 基于你还爱我\n[00:27.819]美丽的泡沫 虽然一刹花火 你所有承诺 虽然都太脆弱\n[00:41.780]但爱像泡沫 如果能够看破 有什么难过\n[00:53.750]\n[00:57.230]早该知道泡沫 一触就破 就像已伤的心 不胜折磨\n[01:11.040]也不是谁的错 谎言再多 基于你还爱我\n[01:24.200]美丽的泡沫 虽然一刹花火 你所有承诺 虽然都太脆弱\n[01:38.800]爱本是泡沫 如果能够看破 有什么难过\n[01:50.560]\n[01:52.629]再美的花朵 盛开过就凋落 再亮眼的星 一闪过就坠落\n[02:06.650]爱本是泡沫 如果能够看破 有什么难过\n[02:20.889]为什么难过 有什么难过 为什么难过\n[02:41.650]\n[02:45.799]全都是泡沫 只一刹的花火 你所有承诺 全部都太脆弱\n[02:59.560]而你的轮廓 怪我没有看破 才如此难过\n[03:13.769]相爱的把握 要如何再搜索 相拥着寂寞 难道就不寂寞\n[03:28.820]爱本是泡沫 怪我没有看破 才如此难过\n[03:39.980]\n[03:43.829]在雨下的泡沫 一触就破 当初炽热的心 早已沉没\n[03:57.940]说什么你爱我 如果骗我 我宁愿你沉默\n[04:10.000]\n[04:10.209]\n[59:59.700]', '/song/G.E.M.邓紫棋-泡沫.mp3', 'system', '2018-12-30 08:42:26', NULL, '2018-12-30 08:42:26');
INSERT INTO "Biz_Song" VALUES (28, 5, 'G.E.M.邓紫棋-龙卷风', '龙卷风', '/img/songPic/longjuanfeng.jpg', '[00:00.00] 作曲 : 周杰伦\n[00:01.00] 作词 : 徐若瑄/周杰伦\n[00:20.05]爱像一阵风吹完它就走\n[00:26.54]这样的节奏谁都无可奈何\n[00:33.34]没有你以后我灵魂失控\n[00:39.81]黑云在降落我被它拖着走\n[00:46.30]静静悄悄默默离开\n[00:49.57]陷入了危险边缘Baby\n[00:53.74]我的世界已狂风暴雨\n[01:00.37]爱情来的太快就像龙卷风\n[01:03.29]离不开暴风圈来不及逃\n[01:06.32]我不能再想我不能再想\n[01:09.89]我不我不我不能\n[01:13.35]爱情走的太快就像龙卷风\n[01:16.58]不能承受我已无处可躲\n[01:19.51]我不要再想我不要再想\n[01:23.13]我不我不我不要再想你\n[01:26.97]不知不觉你已经离开我\n[01:30.00]不知不觉我跟了这节奏\n[01:33.31]后知后觉又过了一个秋\n[01:36.90]后知后觉我该好好生活\n[01:39.87]静静悄悄默默离开\n[01:42.86]陷入了危险边缘Baby\n[01:47.24]我的世界已狂风暴雨\n[01:53.64]爱情来的太快就像龙卷风\n[01:56.92]离不开暴风圈来不及逃\n[01:59.55]我不能再想我不能再想\n[02:02.83]我不我不我不能\n[02:06.61]爱情走的太快就像龙卷风\n[02:09.93]不能承受我已无处可躲\n[02:12.85]我不要再想我不要再想\n[02:16.19]我不我不我不要再想你\n[02:32.89]现在你要我说多难堪\n[02:35.43]我根本就不想分开\n[02:37.13]为什么还要我用用微笑来带过\n[02:40.56]没有我没有没有这种天分\n[02:43.31]包容你也接受他\n[02:44.64]但不用担心太多\n[02:45.90]我会一直好好过\n[02:47.25]我看着你已经远远离开\n[02:49.90]我也会慢慢的走开\n[02:51.50]为什么我连分开都迁就着你\n[02:54.01]我真的没有天分安静的没那么快\n[02:56.49]and i will learn to give up because\n[02:58.93]我爱你\n[03:00.27]爱情来的太快就像龙卷风\n[03:03.30]离不开暴风圈来不及逃\n[03:06.26]我不能再想我不能再想\n[03:09.59]我不我不我不能\n[03:13.61]爱情走的太快就像龙卷风\n[03:16.58]不能承受我已无处可躲\n[03:19.53]我不要再想我不要再想\n[03:22.82]我不我不我不要再想你\n[03:27.16]不知不觉你已经离开我\n[03:29.99]不知不觉我跟了这节奏\n[03:33.25]后知后觉又过了一个秋\n[03:36.62]后知后觉我该好好生活\n[03:41.62]你已经离开我\n[03:44.82]你已经留下我\n[03:47.91]我应该好好地生活\n[03:53.73]不知不觉你已经离开我\n[03:56.67]不知不觉我跟了这节奏\n[03:59.96]后知后觉又过了一个秋\n[04:03.31]后知后觉后知后觉', '/song/G.E.M.邓紫棋-龙卷风.mp3', 'system', '2018-12-30 08:48:44', NULL, '2018-12-30 08:48:44');
INSERT INTO "Biz_Song" VALUES (29, 5, 'G.E.M.邓紫棋-夜空中最亮的星', '龙卷风', '/img/songPic/yekongzhongzuiliangdexing.jpg', '[00:00.00] 作曲 : 逃跑计划\n[00:01.00] 作词 : 逃跑计划\n[00:07.87]编曲 : Lupo Groinig\n[00:08.87]夜空中最亮的星 能否听清\n[00:17.23]那仰望的人 心底的孤独和叹息\n[00:26.09]夜空中最亮的星 能否记起\n[00:34.58]曾与我同行 消失在风里的身影\n[00:42.35]我祈祷拥有一颗透明的心灵\n[00:47.41]和会流泪的眼睛\n[00:52.91]给我再去相信的勇气\n[00:56.23]越过谎言去拥抱你\n[01:00.01]每当我找不到存在的意义\n[01:04.69]每当我迷失在黑夜里\n[01:10.36]夜空中最亮的星\n[01:13.71]请照亮我前行\n[01:22.91]夜空中最亮的星 是否知道\n[01:31.30]曾与我同行的身影 如今在哪里\n[01:40.43]夜空中最亮的星 是否在意\n[01:48.71]是太阳先升起 还是意外先来临\n[01:56.55]我祈祷拥有一颗透明的心灵\n[02:01.62]和会流泪的眼睛\n[02:07.07]给我再去相信的勇气\n[02:10.31]越过谎言去拥抱你\n[02:14.25]每当我找不到存在的意义\n[02:18.89]每当我迷失在黑夜里\n[02:24.53]夜空中最亮的星\n[02:27.91]请照亮我前行\n[02:33.63]夜空中最亮的星  请照亮我前行\n[02:41.98]夜空中最亮的星  请照亮我前行\n[02:50.76]夜空中最亮的星  请照亮我前行\n[02:59.46]夜空中最亮的星  请照亮我前行\n[03:11.62]我不愿忘记你的眼睛\n[03:16.81]给我再去相信的勇气\n[03:22.00]去拥抱你\n[03:25.74]我找不到存在的意义\n[03:28.90]我迷失在黑夜里\n[03:34.47]夜空中最亮的星 请照亮我前行', '/song/G.E.M.邓紫棋-夜空中最亮的星.mp3', 'system', '2018-12-30 08:53:52', NULL, '2018-12-30 08:53:52');
INSERT INTO "Biz_Song" VALUES (30, 6, '梁耀燮-Shadow (그림자)', 'The First Collage', '/img/songPic/Shadow.jpg', '[00:00.00] 作曲 : 龙俊亨/金泰洙\n[00:01.00] 作词 : 龙俊亨/金泰洙\n[00:03.990]Shadow Shadow\n[00:11.950]Because I"m a Shadow\n[00:13.450]Shadow Shadow\n[00:16.750]Rainy Cloudy No light Darkness Day N Night\n[00:19.890]너 떠나버린\n[00:20.820]그 때부터 어쩌면 Maybe 내 존재 자체가 없어졌지\n[00:25.200]Back in the day\n[00:25.700]화창한 날씨 화려한 불빛\n[00:27.970]항상 네 곁에 있었지 내가 있었지 내가\n[00:30.450]Cause I"m Shadow Shadow Shadow\n[00:32.570]Give me the light light light\n[00:34.860]You are ma ma ma sunrise\n[00:38.470]너 없는 난 아무것도 아냐\n[00:41.110]넌 내 마지막 You"re my last\n[00:43.440]언제까지나 You"re my last\n[00:45.570]네가 불길이라도 난 뛰어들게\n[00:49.210]너와 나의 저 하늘을 검게 물들인 저 이별을 어서 지워줘\n[00:57.210]더 이상 내가 다가갈 수 없게\n[01:00.000]너를 바라볼 수 없게\n[01:02.250]네 곁에 머물고 싶어\n[01:03.909]Because I"m a Shadow Shadow Shadow\n[01:05.700]간절하게 원하고 있는데\n[01:09.130]눈부셨던 그때로 나 돌아갈래\n[01:13.980]그림자처럼 항상 함께였던\n[01:16.820]아름다운 네 미소가 날 비추던\n[01:20.660]Because I"m a Shadow Shadow Shadow\n[01:24.300]Early in the morning\n[01:26.310]오늘도 역시\n[01:28.500]The sun is hiding\n[01:32.740]빛은 사라졌지 널 데리고서 저 저 멀리로\n[01:37.539]Cause I"m a Shadow Shadow Shadow\n[01:39.300]Give me the light light light\n[01:41.920]You are ma ma ma sunrise\n[01:45.240]너 없는 난 아무것도 아냐\n[01:47.929]넌 내 마지막 You"re my last\n[01:50.270]언제까지나 You"re my last\n[01:52.300]네가 불길이라도 난 뛰어들게\n[01:56.000]너와 나의 저 하늘을 검게 물들인 저 이별을 어서 지워줘\n[02:04.000]더 이상 내가 다가갈 수 없게\n[02:06.880]너를 바라볼 수 없게\n[02:09.000]네 곁에 머물고 싶어\n[02:10.788]Because I"m a Shadow Shadow Shadow\n[02:12.459]간절하게 원하고 있는데\n[02:16.270]눈부셨던 그때로 나 돌아갈래\n[02:20.640]그림자처럼 항상 함께였던\n[02:23.570]아름다운 네 미소가 날 비추던\n[02:27.340]Because I"m a Shadow Shadow Shadow\n[02:30.420]Erase erase 잊어 지워\n[02:32.239]이젠 이젠 싫어 미워\n[02:34.640]Fall fall falln"down.Faded faded faded\n[02:38.000]I"m not a vampire，Not a night ghost\n[02:40.179]어둠 속에 흐느껴 네 이름 부르고\n[02:42.579]우리가 다시 함께 하기를 기다려\n[02:45.529]Cause a Shadow Shadow Shadow\n[02:47.630]Oh 너를 잊는다는 건 나 역시 지워진다는 걸\n[02:54.460]너와 나의 저 하늘을 검게 물들인 저 이별을 어서 지워줘\n[03:02.310]더 이상 내가 다가갈 수 없게\n[03:05.340]너를 바라볼 수 없게\n[03:07.420]네 곁에 머물고 싶어\n[03:09.119]Because I"m a Shadow Shadow Shadow\n[03:11.140]간절하게 원하고 있는데\n[03:14.660]눈부셨던 그때로 나 돌아갈래\n[03:19.260]그림자처럼 항상 함께였던\n[03:21.999]아름다운 네 미소가 날 비추던\n[03:26.000]Because I"m a Shadow Shadow Shadow\n[03:30.210]Because I"m a Shadow Shadow Shadow', '/song/梁耀燮-Shadow (그림자).mp3', 'system', '2018-12-30 09:08:58', NULL, '2018-12-30 09:08:58');
INSERT INTO "Biz_Song" VALUES (31, 6, '梁耀燮-리본(Ribbon)', 'Highlight', '/img/songPic/Ribbon.jpg', '[by:Jensen48_]\n[00:00.00] 作曲 : Good Life\n[00:01.00] 作词 : 龙俊亨\n[00:29.02]단단했던 매듭이 결국엔\n[00:31.61]풀려버리고 마네요\n[00:35.66]설마 했던 이별이 가까이\n[00:38.65]다가와 버렸네요 정말로\n[00:42.98]아마도 지금 이 순간이\n[00:45.59]가장 힘든 순간이에요 내겐\n[00:50.23]걱정 말아요 그래도\n[00:52.36]그대 원망하진 않아요\n[00:56.96]모든 걸 잃어도 돌릴 수 없고\n[01:00.68]소중한 걸 지킬 수조차 없는\n[01:04.58]초라한 내 모습 뗄 수 없는 입술이\n[01:08.69]그댈 잡을 수 없게 하죠\n[01:11.50]난 다시 한 번 풀려버린\n[01:15.23]우리를 예쁘게 묶고 싶어\n[01:19.20]있는 힘껏 서로를 당기며\n[01:22.75]사랑을 매듭지을 수 있게\n[01:26.31]Tie up a ribbon 절대 풀리지 않게\n[01:29.93]Tie up a ribbon 서로를 놓을 수 없게\n[01:33.75]아직 늦은 게 아니라면\n[01:36.74]너도 나와 같을 수 있다면\n[01:41.29]받아들이는 게 아냐\n[01:42.96]내 뜻대로 할 수 있는 건\n[01:44.67]지금처럼 질질 짜거나\n[01:46.47]취한 채로 널 향해 걷는 거\n[01:48.43]아주 가끔씩 꿈에 찾아온\n[01:50.14]널 반갑게 맞아주는 거\n[01:51.87]아무렇지 않은 척 괜찮다며\n[01:54.05]웃어주는 것뿐이야 Baby\n[01:56.78]맞아 좋은 남잔 아니었어\n[01:58.47]나는 너에게\n[02:00.28]언제나 부족한 사람이었기에\n[02:03.86]지금처럼 노래 부르는 것도\n[02:06.32]부담이라면 미안해\n[02:08.89]전부를 버려도 바꿀 수 없고\n[02:12.64]싫어도 빼앗길 수밖에 없는\n[02:16.53]초라한 내 모습 뗄 수 없는 입술이\n[02:20.63]그댈 잡을 수 없게 하죠\n[02:23.44]난 다시 한 번 풀려버린\n[02:27.28]우리를 예쁘게 묶고 싶어\n[02:31.24]있는 힘껏 서로를 당기며\n[02:34.76]사랑을 매듭지을 수 있게\n[02:38.26]Tie up a ribbon 절대 풀리지 않게\n[02:41.83]Tie up a ribbon 서로를 놓을 수 없게\n[02:45.74]아직 늦은 게 아니라면\n[02:48.71]너도 나와 같을 수 있다면\n[02:52.93]너무 아름답게 또 당연한 듯이\n[02:56.72]내 곁에 머물러준 너\n[02:59.93]그래서 가까이 와버린 이별조차\n[03:03.89]알아채지 못한 걸까\n[03:07.27]이렇게 쉽게 끝나버린 만큼\n[03:11.11]그리움도 쉽게 지울 순 없을까\n[03:15.12]언제쯤이면 나는 널 웃으며\n[03:18.57]떠올릴 수 있을까\n[03:21.36]난 다시 한 번 풀려버린\n[03:24.89]우리를 예쁘게 묶고 싶어\n[03:28.82]있는 힘껏 서로를 당기며\n[03:32.40]다시 널 사랑할 수 있게\n[03:35.74]Tie up a ribbon 절대 풀리지 않게\n[03:39.46]Tie up a ribbon 서로를 놓을 수 없게\n[03:43.34]아직 늦은 게 아니라면\n[03:46.36]너도 나와 같을 수 있다면\n[03:50.57]Tie up a ribbon', '/song/梁耀燮-리본(Ribbon).mp3', 'system', '2018-12-30 09:59:49', NULL, '2018-12-30 09:59:49');
INSERT INTO "Biz_Song" VALUES (33, 7, '艺声-문 열어봐 (Here I am)', 'Here I am', '/img/songPic/HereIam.jpg', '[00:00.00] 作曲 : 艺声/BrotherSu\n[00:01.00] 作词 : 艺声/BrotherSu\n[00:17.39]핑계가 필요 했었나 봐\n[00:24.44]편의점 앞에서 술을 조금 마셨어\n[00:32.90]정말 조금 인데도\n[00:36.07]세상이 흐려지는 게\n[00:39.13]좀 취한 것 같아 나\n[00:45.11]시계를 잃어 버렸나 봐\n[00:52.24]한쪽 팔이 허전해\n[00:55.87]바라보다 알았어\n[01:00.82]시계 탓도 아니고 내 팔 위에 있던\n[01:06.30]네 손 하나 느낄 수 없단 걸\n[01:12.85]매일 가던 길인데\n[01:16.55]어떻게 이렇게 네가\n[01:21.44]좋아하는 게 많았는지\n[01:26.84]손에 잡히는 데로\n[01:29.79]술기운에 사긴 샀는데\n[01:33.96]넌 아직 그 곳에 사는지\n[01:40.33]문 열어봐 내가 여기 왔잖아\n[01:45.78]왜 몰라 네가 좋아하던 화분에\n[01:51.05]꽃도 조금 샀는데\n[01:54.14]이것 봐 네가 사준 셔츠에\n[01:59.72]네 향기 빼고 모든 게 돌아왔는데\n[02:05.39]너만 없네 문 열어봐\n[02:15.76]그리 쉬운 말인데 그 땐 왜 그렇게\n[02:22.56]사랑한단 말이 어려웠는지\n[02:29.19]우리 헤어진 후에\n[02:32.43]네 모습 보이지 않아도\n[02:36.49]넌 아직 내 맘에 사는 지\n[02:42.51]문 열어봐 내가 여기 왔잖아\n[02:48.25]왜 몰라 네가 좋아하던 화분에\n[02:53.60]꽃도 조금 샀는데\n[02:56.70]이것 봐 네가 사준 셔츠에\n[03:02.32]네 향기 빼고 모든 게 돌아왔는데\n[03:07.83]너만 없네 문 열어봐\n[03:12.72]불 켜진 네 방 창가에\n[03:16.58]흐릿하게 보여\n[03:19.64]이름을 불러보지만\n[03:24.56]내 목소리 닿을 것만 같아\n[03:27.90]내 마음도 닿을 것만 같아\n[03:32.34]제발 닫힌 이 문 좀 열어봐\n[03:38.45]내게 돌아와\n[03:44.57]문 열어봐 내가 여기 왔잖아\n[03:50.18]왜 몰라 네가 좋아하던 화분에\n[03:55.45]꽃도 조금 샀는데\n[03:58.58]이것 봐 네가 사준 셔츠에\n[04:04.12]네 향기 빼고 모든 게 돌아왔는데\n[04:09.72]너만 없네 문 열어봐\n[04:19.82]문 열어봐', '/song/艺声-문 열어봐 (Here I am).mp3', 'system', '2018-12-30 10:31:30', NULL, '2018-12-30 10:31:30');
INSERT INTO "Biz_Song" VALUES (34, 7, '艺声-春天的阵雨 (Paper Umbrella)', '봄날의 소나기', '/img/songPic/Umbrella.jpg', '[00:00.00] 作曲 : 1601\n[00:00.789] 作词 : 徐智恩\n[00:02.367]编曲：1601\n[00:16.785]네가 떠난 그 순간\n[00:20.411]온 세상이 내게서 등을 돌리더라\n[00:27.508]미친 사람같이 보고 싶어 헤매이는데\n[00:35.684]너는 지금 어디니\n[00:42.177]서투르게 사랑한 것처럼\n[00:49.283]헤어짐까지 또 서툴러서 미안해\n[00:56.639]아무것도 모르고 널 보낸 나라서\n[01:03.491]온다 떨어진다\n[01:06.158]내 찢어진 하늘 사이로\n[01:10.546]한 방울 두 방울 봄날의 소나기\n[01:17.698]너를 그려보다 불러보다\n[01:21.775]기억이 비처럼 내린 새벽\n[01:26.358]밤새 난 그 빗속에\n[01:29.686]종이로 된 우산을 쓰고 있네\n[01:39.305]괜찮다곤 했지만\n[01:42.883]버텨낼 수 있을까\n[01:45.452]나도 모르겠어\n[01:49.940]네가 없는 이 거리\n[01:53.816]그럼에도 꽃은 피는데\n[01:58.000]하염없는 기다림\n[02:04.642]미련하게 사랑한 것처럼\n[02:11.744]헤어짐까지\n[02:14.410]또 미련해서 미안해\n[02:18.999]못해준 게\n[02:20.661]이렇게 발목을 잡는 걸\n[02:25.948]온다 떨어진다\n[02:28.465]내 찢어진 하늘 사이로\n[02:32.989]한 방울 두 방울\n[02:36.560]봄날의 소나기\n[02:40.188]너를 그려보다 불러보다\n[02:44.166]기억이 비처럼 내린 새벽\n[02:48.602]밤새 난 그 빗속에\n[02:52.178]널 보내던 그날과 같은 하루\n[02:57.372]온몸이 굳어버린 난\n[03:00.946]그때처럼\n[03:02.309]단 한 발도 움직일 수 없는데\n[03:12.430]간다 사라진다\n[03:15.105]내 흐려진 시선 너머로\n[03:19.540]한 방울 두 방울 그리고 여전히\n[03:26.702]슬피 떨어지던 꽃잎 위에\n[03:30.834]기억이 비처럼 내린 새벽\n[03:35.217]밤새 난 그 빗속에 종이로\n[03:39.452]된 우산을 쓰고 있네', '/song/艺声-春天的阵雨 (Paper Umbrella).mp3', 'system', '2018-12-30 10:37:22', NULL, '2018-12-30 10:37:22');
INSERT INTO "Biz_Song" VALUES (35, 7, '艺声 + 灿烈-어떤 말로도 (Confession)', '봄날의 소나기', '/img/songPic/Confession.jpg', '[00:00.00] 作曲 : 艺声/BrotherSu\n[00:01.00] 作词 : 艺声/BrotherSu\n[00:08.89]생각나 잊을 수 없어 그 미소\n[00:13.32]난 말이야 온통 네 생각뿐인 걸\n[00:19.14]대체 무슨 마법을 건 거야\n[00:22.65]내 마음의 꽃이 피고 있는 걸\n[00:27.19]있잖아 들리니 내 심장소리\n[00:31.65]Only you 내 생애 가장 아름다운 별\n[00:37.68]너 하나로 빛나고 있는\n[00:40.84]이 세상 우리 함께라면\n[00:45.36]어떤 말로도 어떤 표현도\n[00:49.65]내 마음 다 전할 수 없지만 괜찮아\n[00:56.47]사랑이란 쉽지 만은 않을 거야\n[01:03.44]꽃을 들고서 다가가 볼까\n[01:07.97]허전한 네 손 꼭 잡으며\n[01:12.07]이렇게 용기를 내어 내 사랑을\n[01:20.62]고백하고 싶어\n[01:31.71]요즘 나 이유 없이 웃음이나\n[01:33.78]또 너의 꿈을 꾸는 것도 일상이야\n[01:36.49]처음 주고 받은 메시지\n[01:38.04]보고 또 다시 보는 것도\n[01:39.82]벌써 몇 번째인지\n[01:41.10]기분 좋은 향기 같은 너\n[01:42.88]조금씩 서로를 닮아가고 있는 걸\n[01:45.00]오늘은 손을 잡고 걷고 싶어\n[01:47.34]한발씩 가까워지는\n[01:48.59]하루 하루가 꿈만 같아\n[01:50.03]난 그냥 가만히 잘 있다가도\n[01:54.13]문득 떠오르는 네 생각에\n[01:56.35]자꾸 바보처럼 실없이 웃게 돼\n[01:59.69]날 바라보고 웃던 미소가 좋아\n[02:03.08]매일 볼 수 있다면\n[02:07.40]어떤 말로도 어떤 표현도\n[02:11.91]내 마음 다 전할 수 없지만 괜찮아\n[02:18.74]사랑이란 쉽지 만은 않을 거야\n[02:25.61]꽃을 들고서 다가가 볼까\n[02:30.25]허전한 네 손 꼭 잡으며\n[02:34.27]이렇게 용기를 내어 내 사랑을\n[02:42.87]고백하고 싶어\n[02:45.56]스쳐 지나간 흔한 인연이라 해도\n[02:54.34]난 평생 너를 잊지 못할 것 같은데\n[03:02.59]어떤 말로도 어떤 표현도\n[03:06.80]내 마음 다 전할 수 없지만 괜찮아\n[03:13.64]사랑이란 쉽지 만은 않더라도\n[03:20.57]꽃을 들고서 다가가 볼게\n[03:25.16]허전한 네 손 꼭 잡으며\n[03:29.06]이렇게 용기를 내어 내 사랑을\n[03:37.67]고백하고 싶어', '/song/艺声 + 灿烈-어떤 말로도 (Confession).mp3', 'system', '2018-12-30 17:00:27', NULL, '2018-12-30 17:00:27');
INSERT INTO "Biz_Song" VALUES (36, 8, 'Ennio Morricone-Once Upon a Time in the West', 'Once Upon a Time in the West', '/img/songPic/OnceUponaTimeintheWest.jpg', '[00:00:00]纯音乐', '/song/Ennio Morricone-Once Upon a Time in the West.mp3', 'system', '2019-03-19 15:57:07', NULL, '2019-03-19 15:57:07');
INSERT INTO "Biz_Song" VALUES (37, 8, 'Ennio Morricone-Titoli', 'Per un Pugno di Dollari', '/img/songPic/Titoli.jpg', '[00:00:00]纯音乐', '/song/Ennio Morricone-Titoli.mp3', 'system', '2019-03-19 15:50:47', NULL, '2019-03-19 15:50:47');
INSERT INTO "Biz_Song" VALUES (38, 9, '林俊杰-关键词', '和自己对话 From M.E. To Myself', '/img/songPic/guanjianci.jpg', '[00:00.000] 作曲 : 林俊杰\n[00:01.000] 作词 : 林怡凤\n[00:14.12]好好爱自己 就有人会爱你\n[00:17.43]这乐观的说词\n[00:21.05]幸福的样子 我感觉好真实\n[00:24.31]找不到形容词\n[00:27.72]沉默在掩饰 快泛滥的激情\n[00:31.43]只剩下语助词\n[00:35.05]有一种踏实 当你口中喊我名字\n[00:40.49]落叶的位置 谱出一首诗\n[00:47.67]时间在消逝 我们的故事开始\n[00:54.34]这是第一次\n[00:58.13]让我见识爱情 可以慷慨又自私\n[01:04.67]你是我的关键词\n[01:10.22]\n[01:21.26]我不太确定 爱最好的方式\n[01:24.45]是动词或名词\n[01:28.09]很想告诉你 最赤裸的感情\n[01:31.46]却又忘词\n[01:35.35]聚散总有时 而哭笑也有时\n[01:38.49]我不怕潜台词\n[01:41.55]有一种踏实 是你心中有我名字\n[01:47.63]落叶的位置 谱出一首诗\n[01:54.41]时间在消逝 我们的故事开始\n[02:01.62]这是第一次\n[02:05.35]让我见识爱情 可以慷慨又自私\n[02:11.86]你是我的关键词\n[02:17.66]你藏在歌词\n[02:20.94]代表的意思\n[02:24.50]是专有名词\n[02:30.18]落叶的位置\n[02:33.55]谱出一首诗\n[02:37.05]我们的故事\n[02:40.51]才正要开始\n[02:44.35]这是第一次\n[02:47.33]爱一个人爱得如此慷慨又自私\n[02:54.33]你是我的关键词', '/song/林俊杰-关键词.mp3', 'system', '2019-03-19 13:38:54', NULL, '2019-03-19 13:38:54');
INSERT INTO "Biz_Song" VALUES (39, 9, '林俊杰-期待爱', 'JJ陆', '/img/songPic/guanjianci.jpg', '[00:33.790]My Life 一直在等待\n[00:38.790]空荡的口袋\n[00:41.490]想在里面放 一份爱\n[00:45.860]Why 总是被打败\n[00:49.850]真的好无奈\n[00:53.760]其实我 实实在在\n[00:55.750]不管帅不帅\n[01:00.030]想要找回来 自己的节拍\n[01:05.380]所以这一次\n[01:08.130]我要勇敢 大声说出来\n[01:13.220]\n[01:13.680]期待 期待你发现我的爱\n[01:18.790]无所不在 我自然而然的关怀\n[01:24.230]你的存在 心灵感应的方向\n[01:29.570]我一眼就看出来\n[01:33.780]是因为爱\n[01:36.160]我猜 你早已发现我的爱\n[01:41.080]绕几个弯 越靠近越明白\n[01:46.850]不要走开\n[01:49.580]幸福的开始 就是放手去爱\n[02:22.620]想要找回来 自己的节拍\n[02:27.790]所以这一次\n[02:30.700]我要勇敢 大声说出来\n[02:36.420]\n[02:37.030]期待 期待你发现我的爱\n[02:41.920]无所不在 我自然而然的关怀\n[02:47.510]你的存在 心灵感应的方向\n[02:52.870]我一眼就看出来\n[02:57.080]是因为爱\n[02:59.520]我猜 你早已发现我的爱\n[03:04.380]绕几个弯 越靠近越明白\n[03:09.930]不要走开\n[03:12.580]幸福的开始 就是放手去爱\n[03:21.140]\n[03:22.020]幸福的开始 就是放手去爱', '/song/林俊杰-期待爱.mp3', 'system', '2019-03-19 13:44:19', NULL, '2019-04-24 22:35:28');
INSERT INTO "Biz_Song" VALUES (40, 10, '王力宏-需要人陪', '十八般武艺', '/img/songPic/1650171596575FOhRf48VEAIKXZv.jpeg', '[00:00.000] 作曲 : 王力宏\n[00:01.000] 作词 : 王力宏\n[00:12.330]打开窗户让孤单透气\n[00:17.130]这一间屋子 如此密闭\n[00:23.970]欢呼声仍飘在空气里\n[00:28.950]像空无一人一样华丽\n[00:33.780]\n[00:35.190]我 渐渐失去知觉\n[00:40.860]就当做是种自我逃避\n[00:47.170]你 飞到天的边缘\n[00:52.540]我也不猜落在何地\n[00:57.230]\n[00:58.020]一个我 需要梦想 需要方向 需要眼泪\n[01:03.850]更需要 一个人来 点亮天的黑\n[01:09.830]我已经 无能为力 无法抗拒 无路可退\n[01:16.000]这无声的夜 现在的我 需要人陪\n[01:25.300]\n[01:34.990]闭上眼睛 就看不清\n[01:39.909]这双人床 欠缺的 温馨\n[01:46.960]谁能 陪我 直到天明\n[01:52.080]穿透这片 迷蒙寂静\n[01:56.830]\n[01:57.909]我 渐渐失去知觉\n[02:03.640]就当做是种自我逃避\n[02:09.909]你 飞到天的边缘\n[02:15.740]我已不猜落在何地\n[02:20.200]\n[02:20.840]一个我 需要梦想 需要方向 需要眼泪\n[02:26.800]更需要 一个人来 点亮天的黑\n[02:32.600]我已经 无能为力 无法抗拒 无路可退\n[02:38.970]这无声的夜 现在的我 需要人陪\n[02:47.890]\n[03:08.230]一个我 需要梦想 需要方向 需要眼泪\n[03:14.000]更需要 一个人来 点亮天的黑\n[03:20.010]我已经 无能为力 无法抗拒 无路可退\n[03:26.360]这无声的夜 现在的我 需要人陪\n[03:36.240]', '/song/周杰伦 - 说好不哭.mp3', 'system', '2019-03-19 13:52:02', NULL, '2019-03-19 13:52:02');

-- ----------------------------
-- Table structure for Biz_Song_List
-- ----------------------------
DROP TABLE IF EXISTS "Biz_Song_List";
CREATE TABLE "Biz_Song_List" (
  "Id" INTEGER PRIMARY KEY AUTOINCREMENT,
  "Title" varchar(255) NOT NULL,
  "Pic" varchar(255) DEFAULT NULL,
  "Introduction" text DEFAULT NULL,
  "Style" varchar(10) DEFAULT '无',
  "Create_Time" datetime DEFAULT NULL,
  "Create_By" varchar(50) DEFAULT NULL,
  "Update_Time" datetime DEFAULT NULL,
  "Update_By" varchar(50) DEFAULT NULL
);

-- ----------------------------
-- Records of "Biz_Song_List"
-- ----------------------------
INSERT INTO "Biz_Song_List" VALUES (1, 'The Good, the Bad and the Ugly', '/img/songListPic/e7ea5d1be5214ba5827f31d2ee834a2a.jpg', 'he Good, the Bad and the Ugly: Original Motion Picture Soundtrack was released in 1966 alongside the Western film, The Good, the Bad and the Ugly, directed by Sergio Leone. The score is composed by frequent Leone collaborator Ennio Morricone, whose distinctive original compositions, containing gunfire, whistling, and yodeling permeate the film. The main theme, resembling the howling of a coyote, is a two-note melody that is a frequent motif, and is used for the three main characters, with a different instrument used for each one: flute for Blondie (Man With No Name), Arghilofono (Ocarina) for Angel Eyes, and human voices for Tuco.', '欧美-轻音乐', '2022-11-25 16:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Song_List" VALUES (2, '华语', '/img/songListPic/f0ddd965e7454661ab9422143e3dfbcc.jpg', '那些喜欢到会循环播放的歌', '流行', '2022-11-25 16:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Song_List" VALUES (3, '希望十八岁你爱的人是八十岁在你身边的人', '/img/songListPic/557c8fec7f85430fa6c8f5bf0ab7dd03.jpg', '让你怦然心动', '华语', '2022-11-25 16:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Song_List" VALUES (4, '你的青春里有没有属于你的一首歌？', '/img/songListPic/09a641e49da943d9bb4dee7304faad4b.jpg', '关于青春里的那首歌，唱的是你和谁的回忆呢？那年你们有什么故事？\n\n总是有许多的记忆，是关于青春的。\n\n青春时埋下的那份躁动，总会在多年后，装饰着笑容。\n\n总是有许多的遗憾，是关于青春的。\n\n青春时还没来得及表达的情感，总会在多年以后，偶尔的左右着悲欢。\n\n那些最美年华里的相遇，那些青春里的不知所措，都被勾勒成了一幅幅画。\n\n而这些画，只在心情最愉悦时，只在心情最低落时，悄悄的，在内心深处闪过。', '华语', '2022-11-25 16:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Song_List" VALUES (5, '那些喜欢到循环播放的歌', '/img/songListPic/109951163609743240.jpg', '那些喜欢到会循环播放的歌\n\n感谢收听', '华语', '2022-11-25 16:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Song_List" VALUES (6, '林俊杰的正确打开方式【路人请参考简介】', '/img/songListPic/e25ed734602b40ccb5b6107a534cbbe3.jpg', '这是一个一定要顺序播放并且不切歌才能发现其中奥妙的歌单。\n这是一个可以完美呈现林俊杰音乐态度的歌单。\n这是一个林俊杰的立体化打开方式。', '华语', '2022-11-25 16:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Song_List" VALUES (7, '高 级 感 vlog 纯音乐 BGM', '/img/songListPic/bf60dad76e574f4982d49028dab1e23f.jpg', '歌单', '轻音乐', '2022-11-25 16:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Song_List" VALUES (8, '世界上很好听的纯音乐(经典不朽)', '/img/songListPic/25c8b97bb82042b889376e79bd3dd3bf.png', '歌单', '轻音乐', '2022-11-25 16:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Song_List" VALUES (9, '『粤语』好听到爆的粤语歌单', '/img/songListPic/5e283556d6424a849550d6f71aacf394.jpg', '歌单', '粤语', '2022-11-25 16:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Song_List" VALUES (10, '韩剧OST｜祝你走过半生，仍有颗少女心', '/img/songListPic/zhunizouguobansheng.jpg', '歌单', '日韩', '2022-11-25 16:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Song_List" VALUES (11, '我喜欢你，喜欢没用，没用也喜欢', '/img/songListPic/109951163919069037.jpg', '情不知所起，一往而情深。\n伤不知所因，痛彻心扉\n\n从前你是我心上的一束光，倾世温暖。\n现在你是我心里的一根刺，刻骨铭心。\n以后你是我心底的一粒尘，无关痛痒。\n\n我喜欢你，喜欢没用，没用也喜欢', '华语', '2022-11-25 16:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Song_List" VALUES (12, '生活感到疲惫的话就听这些歌吧', '/img/songListPic/109951163936991203.jpg', '当你感到疲惫的时候\n睡一个沉稳的觉醒来\n和陌生人对视互笑\n买一杯刚好温度的奶茶\n吃到合口味的菜\n遇见喜欢人的时候自己是最美的状态\n下雨 清晨 初雪 深夜 亲吻 拥抱 牵手 大笑\n快乐总被说很难\n但我希望你顶...', '华语', '2022-11-25 16:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Song_List" VALUES (13, '熬夜和想你，我都该戒掉了', '/img/songListPic/109951163216834301.jpg', '命运似乎是一个轮回，在一次次的偶然下，平行线交叉，再平行，故事始终有\"然后\"，可后来的我们，都学会如何去爱了吗？\n\n如果当时你没走，后来的我们会不会不一样。或许，我们每个人都想回到故事最开始的地方。', '华语', '2022-11-25 16:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Song_List" VALUES (14, '怀旧向||时光流转从前，人生如寄', '/img/songListPic/109951163443093546.jpg', '岁月悠扬，娓娓动听\n在流失了的记忆之中\n听到属于我们这一代人的歌\n想起属于我们这一代人的路\n愿\n星辰大海\n春暖花开', '华语', '2022-11-25 16:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Song_List" VALUES (15, '不曾刻骨铭心，为何念念不忘？', '/img/songListPic/109951163887710551.jpg', '“所爱隔山海 山海皆可平”\n你拒绝的 不珍惜的 不代表别人也不喜欢\n人生都是向前走的 我们都一样\n\n谁先认真谁先输，我只能说我输了\n再忙碌还是会想你 真的不明白\n都说未曾刻骨铭心，又为何总是念念不忘', '华语', '2022-11-25 16:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Song_List" VALUES (16, '社会语录！土嗨', '/img/songListPic/109951163858422257.jpg', '社会！', '华语', '2022-11-25 16:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Song_List" VALUES (17, '听青春ost，心悸的时光里有你', '/img/songListPic/109951163826485303.jpg', '我们青春就像是被大雨淋湿的自己，即使是感冒了，也愿意再淋一次。只有爱过了，伤过了，痛过了，这才叫青春。', '华语', '2022-11-25 16:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Song_List" VALUES (18, '【经典】聼一首老歌，想念一段时光', '/img/songListPic/109951163311246502.jpg', '寂静的黄昏，总让人怀念，总是深深沦陷...\n那些个细数光阴在手中沉淀的日子，一去不复返...\n偶尔，我一个人站在黄昏的角落，代替你主持夕阳的葬礼...\n想着想着，痛凝重了时间，曳落了容颜...\n青春的羽翼...', '华语', '2022-11-25 16:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Song_List" VALUES (19, '华语百首｜好听的才是耳朵最想要的', '/img/songListPic/109951163597665130.jpg', '好听的音乐才是耳朵最想要的', '华语', '2022-11-25 16:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Song_List" VALUES (20, '【华语抒情-林俊杰】—孤独，是我的享受', '/img/songListPic/109951163826685601.jpg', '我喜欢孤独，不与任何人说话，在一份静谧中安然地做自己喜欢的事。任身心徜徉，暂时忘却“柴米油盐酱醋茶”的烦琐，去体验“琴棋书画诗酒花”的高雅；暂时抛开追名逐利的忙碌奔波，去感受心无杂念的宁静淡泊；暂时摆脱困扰你的喜怒哀乐，去体味生活中的充实祥和。', '华语', '2022-11-25 16:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Song_List" VALUES (21, '睡觉必备心灵鸡汤', '/img/songListPic/109951163879964479.jpg', '缓缓的声音，流进心里的枯井', '轻音乐', '2022-11-25 16:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Song_List" VALUES (22, '愿山野浓雾都有路灯 风雨漂泊都有归舟', '/img/songListPic/109951163594594622.jpg', '你慢慢走\n回忆暗涌\n悲喜翻滚', '华语', '2022-11-25 16:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Song_List" VALUES (23, '「女声控」音色沁人心 旋律美如画', '/img/songListPic/109951163098238240.jpg', '女声控福利来啦-=≡Σ((( つ•̀ω•́)つ', '欧美', '2022-11-25 16:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Song_List" VALUES (24, 'Moombahton 丨电流律动的异域风', '/img/songListPic/109951163500933771.jpg', 'Moombahton融合了Dutch House和Reggaeton，常常带有Trap的元素，特别是在Bulid Up部分，厚实的Bass与密集的打击鼓点，节拍丰富，加上旋律和音色比较异域，一般都有人声部分，其BPM多数基于110，更突出在Drop高潮，让人不禁联想抖动的节奏。', '欧美', '2022-11-25 16:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Song_List" VALUES (25, '【励志电音】愿你身披星芒 执笔为剑', '/img/songListPic/109951163321304060.jpg', '为了父母期待的目光\n为了那深藏于你心底的梦想\n为了你朝思暮想的那个可望而不可及...', '欧美', '2022-11-25 16:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Song_List" VALUES (26, '史诗 • 神级BGM丨灵魂的震颤&心灵的洗涤', '/img/songListPic/109951163692248020.jpg', '随着一声怒吼，千军万马进行着一场浩荡的战争，马的嘶吼声与兵器碰撞的金属声谱写着一部史前的震撼。\n欢迎来到此歌单，晚上睡觉别点开！\n别点开！\n别点开！', 'BGM', '2022-11-25 16:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Song_List" VALUES (27, '全球超大气势磅礴背景音乐精选100首合集', '/img/songListPic/109951163579465390.jpg', '熟悉的感觉，你值得拥有', 'BGM', '2022-11-25 16:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Song_List" VALUES (28, '史诗级震撼人心大气磅礴超燃BGM', '/img/songListPic/109951163618525359.jpg', '史诗级震撼人心超燃BGM,每首都是本人精心挑选和最喜欢的，歌单歌曲是按我个人喜欢排序，持续更新中……', 'BGM', '2022-11-25 16:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Song_List" VALUES (29, '肾上腺素飙升（赛车必备）', '/img/songListPic/109951163578540101.jpg', '赛车运动，自吸为王，涡轮必胜.', 'BGM', '2022-11-25 16:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Song_List" VALUES (30, '『欧美神曲』让你怦然心动', '/img/songListPic/109951163621168769.jpg', '让你怦然心动', '欧美', '2022-11-25 16:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Song_List" VALUES (31, '健身丨做自己平凡世界的超级英雄', '/img/songListPic/109951163670223947.jpg', '热爱健身的朋友们一起嗨！', 'BGM', '2022-11-25 16:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Song_List" VALUES (32, '『空灵欧美』论◎怎样唱出星辰大海', '/img/songListPic/109951163921593479.jpg', '“我们在哪里？”\n\n“星空，是星空！美丽而触手可及！”\n\n“这里，是星辰大海，是你小时候的幻想……”', '欧美', '2022-11-25 16:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Song_List" VALUES (33, 'Space Club 蹦迪', '/img/songListPic/109951163738160487.jpg', 'Sapce Clup全球百大DJ丨Urumqi', 'BGM', '2022-11-25 16:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Song_List" VALUES (34, '那些超带感的英文歌曲~『一秒沦陷』', '/img/songListPic/109951163736178562.jpg', '每天，都要去去做一些枯燥的事\n一些让人心烦的事\n可是又不得不去做\n一切都在重复\n都在复制、粘贴，复制、粘贴……\n何必不去做那些让人愉快的事呢\n比如说\n听歌\n它能让生活有趣起来\n有意义起来\n那么就去欣赏...', '欧美', '2022-11-25 16:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Song_List" VALUES (35, '【游戏原声】屏幕之后，更是另一个世界', '/img/songListPic/109951163408189924.jpg', '我们曾与白狼一起踏上寻找女儿的征途\n走遍大陆与史凯利杰群岛，寻遍北方诸国与尼弗迦德 甘当布尔维坎的屠夫\n只为那因意外率而与自己命运相连的辛特拉幼狮\n只为那曾在布洛克莱昂森林惊慌失措的小女孩\n重回自...', 'BGM', '2022-11-25 16:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Song_List" VALUES (36, '极致旋律&空灵飘纱', '/img/songListPic/109951163672593019.jpg', '心在寂静之中冒着烟 寻找安寄所', '欧美', '2022-11-25 16:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Song_List" VALUES (37, '我们的心如此自由 思绪辽远无边', '/img/songListPic/109951163932838310.jpg', '我想每个人的心底，都潜藏着一个向往远方的梦，此处已无再多风景，熟悉的地方也不再有惊喜。人心思动，都渴望去流浪天涯，无论以哪种方式。', '欧美', '2022-11-25 16:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Song_List" VALUES (38, '欧美精选 | 嗨 伙计 要来首10w+吗？', '/img/songListPic/109951163414509421.jpg', '个别曲目未收录很可能是由于我没买人家的专辑 emmmm.... \n没买就是没买。没兴趣，不想买，买不起，这答案您满意吗？', '欧美', '2022-11-25 16:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Song_List" VALUES (39, '「高质量英文歌」让你单曲循环的英文歌', '/img/songListPic/18814842976746273.jpg', 'I love the endless sea, I love the rain softly, I love flying snow, I love bringing a bright full moon, but I love the starry night sky.', '欧美', '2022-11-25 16:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Song_List" VALUES (40, '稀 | 奇 | 古 | 怪 | 音 | 效 | 工 | 厂', '/img/songListPic/109951163462173993.jpg', '不好意思 在我耳朵化掉之前是能数清的\n\n麻烦大家帮黑哥数数\n\n这些里面藏了多少个稀奇古怪的音效\n\n听归听 收藏某首歌之后我也不知道明天你的日推怎么作妖哈', '欧美', '2022-11-25 16:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Song_List" VALUES (41, '〖欧美女声〗 倾城一刻，我似乎更懂你', '/img/songListPic/18591642116274551.jpg', '个性，风格，颜值，行为，年龄段……差不多的人，听歌的兴趣差不多哦', '欧美', '2022-11-25 16:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Song_List" VALUES (42, '『电影配乐』当优雅华尔兹遇上激情探戈', '/img/songListPic/109951163904955394.jpg', '华尔兹有着与生俱来的华贵与优雅。简约却不简单的舞步透出的是舞者相互心灵的体会与传达……', '欧美', '2022-11-25 16:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Song_List" VALUES (43, '妄想去流浪，独自陶醉在自己的世界里。', '/img/songListPic/109951163543366840.jpg', '生活乏味 ，学习一直倒退，工作失意。\n害怕失去，想像和现实的差距将我打败。\n我想要远离这里。', '轻音乐', '2022-11-25 16:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Song_List" VALUES (44, '晚安曲丨我温柔而通透的小宇宙', '/img/songListPic/109951163646671507.jpg', '晚安～今夜好梦啊！', '轻音乐', '2022-11-25 16:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Song_List" VALUES (45, '晚安曲丨我温柔而通透的小宇宙', '/img/songListPic/109951163808060526.jpg', '你别怕，总有人熬夜陪你，下雨接你，说我爱你，好的总是压箱底\n当一个人能够影响你心情的时候，说明你在乎了；\n当一个人能赚到你眼泪的时候，说明你投入了；\n当一个人能驾驭你情绪的时候，说明你沦陷...', '轻音乐', '2022-11-25 16:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Song_List" VALUES (46, '性欲与孤独，容易让人误解爱情', '/img/songListPic/109951163924312766.jpg', '平常拍片子时，我喜欢在拍摄现场放一些有画面感的音乐让模特找感觉，抽空整理了一下近期的播放列表，做了这套新歌单，或许适合姑娘们在以下一些场景聆听', '轻音乐', '2022-11-25 16:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Song_List" VALUES (47, '人生就要嗨', '/img/songListPic/109951163938242029.jpg', '我命由我不由天', '日韩-BGM', '2022-11-25 16:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Song_List" VALUES (48, '吃鸡必备BGM', '/img/songListPic/109951163776201870.jpg', '大吉大利 今晚吃鸡\n此歌单适合在素质广场，飞机上，杀完人后，轰炸区天选之人的情况下播放，并不是让你全程听音乐玩游戏。', 'BGM', '2022-11-25 16:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Song_List" VALUES (49, '伤感日语 · 芳华少女的孤独内心', '/img/songListPic/109951163942747948.jpg', 'お母さん', '日韩', '2022-11-25 16:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Song_List" VALUES (50, '「予你情书」明年一起去看樱花吧', '/img/songListPic/19079825277149145.jpg', '想和你去看樱花\n看夏日的烟火大会\n看秋日京都岚山的枫叶\n和冬日落雪的小樽\n\n想和你一起去看一场樱花\n看漫天的飞舞的樱花在我们周围\n就这样安静地待着也好彼此交换心事\n\n想予你一封情书\n写尽关于我们的一切...', '日韩', '2022-11-25 16:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Song_List" VALUES (51, '那些年我们听过的韩国歌', '/img/songListPic/18804947371714354.jpg', 'J.Fla，原名Kim Jung Hwa，韩国歌手,歌曲制作人。2013年正式出道并发行首张原创EP《바보 같은 Story》出道后不久就迅速在日本和韩国成为热门话题\n2016年，J.Fla的翻唱作品在国内转载而得到关注，因其甜美声线和惊艳侧颜得到许多人的喜爱。', '日韩', '2022-11-25 16:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Song_List" VALUES (52, '小众而惊艳 ·韩国独立音乐精选集', '/img/songListPic/109951163833244126.jpg', '在无数的灰色版权中找到了它们。\n宝藏一般的旋律，它们不应该被如此埋没。', '日韩', '2022-11-25 16:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Song_List" VALUES (53, '一秒就会中毒的韩语歌单~', '/img/songListPic/109951163515798929.jpg', '愿对这世界温柔以待的人 被温柔以待.', '日韩', '2022-11-25 16:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Song_List" VALUES (54, '［韩语］少女情怀总是诗~', '/img/songListPic/109951162839104712.jpg', '希望所有的少女心事都能梦想成真', '日韩', '2022-11-25 16:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Song_List" VALUES (55, '【燃向】 精选燃曲', '/img/songListPic/19085322835476516.jpg', '封面画师 bilibili Wlop', 'BGM', '2022-11-25 16:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Song_List" VALUES (56, '日系燃向丨此刻光辉 将引领着我们', '/img/songListPic/109951163097151464.jpg', '天空燃尽如灰，\n繁星烧毁似尘，\n那些音乐所带来的力量，化作为光，将引领着我们前行！', '日韩-BGM', '2022-11-25 16:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Song_List" VALUES (57, '日系』有一种调皮叫小清新~', '/img/songListPic/19152393044479439.jpg', '阳光明媚的日子\n心情好到爆炸\n总想要找支歌来抒发一下感情，分享自己的喜悦。\n虽然我听不懂日语，但是并不影响我喜欢它的调皮与清新，舒服的日系小调，让人心情变好~\n\n阳光灿烂，微风拂面，大概就是这个歌单给人的感觉吧~', '日韩', '2022-11-25 16:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Song_List" VALUES (58, '【日系抒情】早晚终相会 忧思情愈深', '/img/songListPic/109951163802235324.jpg', '瀬を早み 岩にせかるる 滝川の\nわれても末に 逢はむとぞ思ふ', '日韩-轻音乐', '2022-11-25 16:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Song_List" VALUES (59, '日系沙哑女声| 愿这份歌声融化你的心', '/img/songListPic/109951163862683663.jpg', '相信大家都听过沙哑的歌吧，majiko，aimer大家都很熟悉了吧。\n\n这种嗓音真的超温柔呀，这个单选出了些沙哑声线歌手的歌，希望大家喜欢。\n\n愿这温柔的声音可以用听觉的方式带给你一场现实上和想象上的一种迷离感，同时陷入一种与女声错觉般的邂逅。\n\np站id:73189154 画师:gomzi', '日韩', '2022-11-25 16:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Song_List" VALUES (60, '『韩语』 感性伴秋风渐起 随秋意渐浓', '/img/songListPic/109951163606909947.jpg', '走过林荫道\n落叶从眼前划过\n才晓得秋天已经降临了一段时间\n我静静看着你的日子\n似乎还是昨天\n你回头看向别处的那个瞬间\n却已经成为今天\n\n若我们离别\n不要说Good bye\n说See you吧\n如同再次光临的秋天一样\n总...', '日韩', '2022-11-25 16:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Song_List" VALUES (61, '韩‖轻柔小调，治愈系旋律', '/img/songListPic/19053436998325469.jpg', '我爬上全世界的屋顶，\n带着全部的清醒和一只酒瓶。\n— — 张艾嘉《我站在全世界的屋顶》', '日韩-轻音乐', '2022-11-25 16:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Song_List" VALUES (62, '听首老歌 回味永不褪色的华语经典', '/img/songListPic/109951163203287436.jpg', '回味光辉岁月三十年\n\n岁月是一场充满告别的旅程\n\n怀旧\n不是因为那个时代多美好\n而是那时\n你正年轻\n\n百许流年忆往事\n千几往事暖流年', '粤语', '2022-11-25 16:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Song_List" VALUES (63, '【粤语】要有多坚强，才敢念念不忘', '/img/songListPic/18878614648960788.jpg', '你说\n你不愿意种花\n我不愿看见它\n一点点的凋落\n是的\n为了避免结束\n你避免了一切\n也避免了所有\n\n开始\n你说你喜欢雨滴\n但是你在下雨的时候打伞\n你说你喜欢太阳\n但是你在阳光明媚的时候\n躲在阴凉的地方 \n你说...', '粤语', '2022-11-25 16:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Song_List" VALUES (64, '初听不知曲中意 再听已是曲中人', '/img/songListPic/19101815510024256.jpg', '有时候听到一首歌，觉得旋律很好，歌词很好。但怎么也不能体会到，歌里唱的感情。后来有一天，你遇到了一个人，发生了一段故事。当你再听到那首歌时，就会觉得歌里唱的，都是你的故事。\n每一首你喜欢的歌曲，都附有非一般的意义，因为都唱出了你内心的声音和过往经历，其实你听到的都是你自己，那些年你累积在心里的所有欢乐悲伤，所有故事过往。', '粤语', '2022-11-25 16:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Song_List" VALUES (65, '粤语男声：我爱你依旧如初，不曾改变。', '/img/songListPic/18612532836990988.jpg', '记得曾经看过一段话：爱情不是抱一抱，亲一亲，改个情侣网名，换个情侣头像，就是情侣了...', '粤语', '2022-11-25 16:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Song_List" VALUES (66, '『粤语』虐到心痛的曲 听到泪落的词', '/img/songListPic/3434874325869351.jpg', '此歌单多为小众粤语，听过太多评论999+的人人传颂的经典歌曲，每次淘到一首鲜为人知人的歌曲，都会非常的惊喜，听歌嘛，最重要的就是自己听着觉得舒服就对啦，不一定非要高热度的啦。此歌单内歌曲不仅旋律打动人心，每首歌词都超虐心，痴情人的爱有时候那么卑微，低到尘埃里，爱到不死不休.....有时候看着歌词听着这些歌情不自禁泪奔，烦请听歌的人，千万不要对号入座，伤害指数超高! 绝对不容错过的小众粤语!', '粤语', '2022-11-25 16:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Song_List" VALUES (67, '富士山下钟无艳 吴哥窟内我本人', '/img/songListPic/109951162869937004.jpg', '男不听七友 女不听钟无艳', '粤语', '2022-11-25 16:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Song_List" VALUES (68, '流行男声||谦谦君子，情浓粤语', '/img/songListPic/109951163193554791.jpg', '慧极必伤，情深不寿，强极则辱，谦谦君子，温润如玉！细数那些唯美男声', '粤语', '2022-11-25 16:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Song_List" VALUES (69, '粤语live||赛赢录音棚流行live', '/img/songListPic/109951163196627760.jpg', '听腻了录影棚里的无杂音歌声？也许换成live会是心的开始', '粤语', '2022-11-25 16:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Song_List" VALUES (70, '从未跟你饮过冰 零度天气看风景', '/img/songListPic/109951163933917463.jpg', '这个世界烂透了 坏透了 我都接受\n\n所有人都习惯于流于表面的热情和爱意 我也接受\n\n但你不行 你得是那个例外才行', '粤语', '2022-11-25 16:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Song_List" VALUES (71, '「致青春」粤语带你回忆', '/img/songListPic/109951163024198570.jpg', '歌听多了 粤语也熟了 \n越听越有感觉', '粤语', '2022-11-25 16:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Song_List" VALUES (72, 'Beyond的辉煌岁月是人生旅途的伴奏', '/img/songListPic/109951163278666363.jpg', 'Beyond是那种有自己独特的风格，有自己的精神，能象征一个时代，也能映射一类人的组合。他们的歌带入感很强，总有共鸣产生，因为他们没有无病呻吟的悲情，也不爱写迎合大众的爱情故事，而是用自己的歌词和声音在诠释着生活，激励着人生', '粤语', '2022-11-25 16:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Song_List" VALUES (73, '听说，钢琴和民谣也很搭配', '/img/songListPic/109951163503924397.jpg', '我们始终会远行，也可能，在最遥远最陌生的地方感知另一个自己，最后发现丢失了好久的钥匙就藏在自己的口袋里', '乐器-轻音乐', '2022-11-25 16:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Song_List" VALUES (74, '新古典钢琴 散落的时光', '/img/songListPic/109951163401615779.jpg', '当时间走过 其风猎猎\n\n覆灭仅存的模糊记忆使昨日土崩瓦解\n\n其实没有什么好担忧的\n\n在生命的内里 不是还有许多\n\n继续延展着的细微线索\n\n以祖先的容颜 来将你形塑\n\n当时间走过 其声簌簌\n\n如狼群之迅疾穿越秋...', '乐器-轻音乐', '2022-11-25 16:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Song_List" VALUES (75, '流行歌曲钢琴演奏', '/img/songListPic/18577348464819001.jpg', '大都是一些华语流行歌曲的钢琴版，也含有少部分这些弹奏者自己创造的钢琴曲与一些他们翻奏的世界较为有名的钢琴曲，希望你们喜欢～\n前50首为精选，请不要错过哦～', '乐器', '2022-11-25 16:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Song_List" VALUES (76, '『钢琴』与流行歌曲的完美邂逅', '/img/songListPic/5832909185359651.jpg', '选集是华语流行音乐的钢琴版，或许你会更喜欢钢琴演奏的故事', '乐器', '2022-11-25 16:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Song_List" VALUES (77, '治愈钢琴｜伟大的时光和伟大的我们', '/img/songListPic/109951162895796021.jpg', '从钢琴的旋律和节奏中慢慢释怀、也许还有所领悟\n钢琴的世界里还有很多很多让人驻足停歇的地方\n如同我们在生活经历中面对的许许多多的小挫折之后\n也要找个角...', '乐器', '2022-11-25 16:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Song_List" VALUES (78, '写作业专用BGM（钢琴向）', '/img/songListPic/1390882211100783.jpg', '暂时停更啦 我来排排顺序', '乐器-轻音乐', '2022-11-25 16:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Song_List" VALUES (79, '钢琴的故事', '/img/songListPic/18731280092485571.jpg', '你一定和我一样有烦恼和故事吧', '乐器', '2022-11-25 16:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Song_List" VALUES (80, '各种乐器演绎流行曲', '/img/songListPic/3416182643161526.jpg', '乐器成精系列之用各种成精乐器重新演绎这些流行歌曲，让你耳目一新', '乐器', '2022-11-25 16:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Song_List" VALUES (82, '还不快去练琴？', '/img/songListPic/19169985230816413.jpg', '都是自己很喜欢的吉他指弹', '乐器', '2022-11-25 16:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Song_List" VALUES (83, '国风传统器乐赏~~♪', '/img/songListPic/18907201951803673.jpg', '中国音乐是光辉灿烂的中国文化的一个重要组成部分。当古典音乐流泻而出的一刹那间，你可以清楚的看到，在空气中流动的是高山、是流水、是丝竹、是冬雪、是千古的生命，那份说不出、道不尽的感动，就是中国古典音乐之美。', '乐器', '2022-11-25 16:37:06', 'admin', NULL, NULL);
INSERT INTO "Biz_Song_List" VALUES (84, '『钢琴纯音』八十八个黑白键勾勒出的美', '/img/songListPic/109951162873752063.jpg', '钢琴如生活，是一首永远弹不完的小曲', '轻音乐-乐器', '2022-11-25 16:37:06', 'admin', NULL, NULL);

-- ----------------------------
-- Table structure for sqlite_sequence
-- ----------------------------
DROP TABLE IF EXISTS "sqlite_sequence";
CREATE TABLE "sqlite_sequence" (
  "name",
  "seq"
);

-- ----------------------------
-- Records of "sqlite_sequence"
-- ----------------------------
INSERT INTO "sqlite_sequence" VALUES ('Biz_Admin', 2);
INSERT INTO "sqlite_sequence" VALUES ('Biz_Banner', 8);
INSERT INTO "sqlite_sequence" VALUES ('Biz_Collect', 98);
INSERT INTO "sqlite_sequence" VALUES ('Biz_Comment', 74);
INSERT INTO "sqlite_sequence" VALUES ('Biz_Consumer', 64);
INSERT INTO "sqlite_sequence" VALUES ('Biz_List_Song', 209);
INSERT INTO "sqlite_sequence" VALUES ('Biz_Rank_List', 64);
INSERT INTO "sqlite_sequence" VALUES ('Biz_Singer', 21);
INSERT INTO "sqlite_sequence" VALUES ('Biz_Song', 40);
INSERT INTO "sqlite_sequence" VALUES ('Biz_Song_List', 86);
INSERT INTO "sqlite_sequence" VALUES ('Biz_CommentUp', 29);

-- ----------------------------
-- Auto increment value for Biz_Admin
-- ----------------------------
UPDATE "sqlite_sequence" SET seq = 2 WHERE name = 'Biz_Admin';

-- ----------------------------
-- Auto increment value for Biz_Banner
-- ----------------------------
UPDATE "sqlite_sequence" SET seq = 8 WHERE name = 'Biz_Banner';

-- ----------------------------
-- Auto increment value for Biz_Collect
-- ----------------------------
UPDATE "sqlite_sequence" SET seq = 98 WHERE name = 'Biz_Collect';

-- ----------------------------
-- Auto increment value for Biz_Comment
-- ----------------------------
UPDATE "sqlite_sequence" SET seq = 74 WHERE name = 'Biz_Comment';

-- ----------------------------
-- Auto increment value for Biz_CommentUp
-- ----------------------------
UPDATE "sqlite_sequence" SET seq = 29 WHERE name = 'Biz_CommentUp';

-- ----------------------------
-- Auto increment value for Biz_Consumer
-- ----------------------------
UPDATE "sqlite_sequence" SET seq = 64 WHERE name = 'Biz_Consumer';

-- ----------------------------
-- Auto increment value for Biz_List_Song
-- ----------------------------
UPDATE "sqlite_sequence" SET seq = 209 WHERE name = 'Biz_List_Song';

-- ----------------------------
-- Auto increment value for Biz_Rank_List
-- ----------------------------
UPDATE "sqlite_sequence" SET seq = 64 WHERE name = 'Biz_Rank_List';

-- ----------------------------
-- Auto increment value for Biz_Singer
-- ----------------------------
UPDATE "sqlite_sequence" SET seq = 21 WHERE name = 'Biz_Singer';

-- ----------------------------
-- Auto increment value for Biz_Song
-- ----------------------------
UPDATE "sqlite_sequence" SET seq = 40 WHERE name = 'Biz_Song';

-- ----------------------------
-- Auto increment value for Biz_Song_List
-- ----------------------------
UPDATE "sqlite_sequence" SET seq = 86 WHERE name = 'Biz_Song_List';

PRAGMA foreign_keys = true;
