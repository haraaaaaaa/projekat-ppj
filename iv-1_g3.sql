/*
 Navicat Premium Data Transfer

 Source Server         : MySQL
 Source Server Type    : MySQL
 Source Server Version : 80037 (8.0.37)
 Source Host           : localhost:3306
 Source Schema         : gr3-projektni-zadatak

 Target Server Type    : MySQL
 Target Server Version : 80037 (8.0.37)
 File Encoding         : 65001

 Date: 03/05/2024 19:58:38
*/

SET NAMES utf8mb4;
SET FOREIGN_KEY_CHECKS = 0;

-- ----------------------------
-- Table structure for order_items
-- ----------------------------
DROP TABLE IF EXISTS `order_items`;
CREATE TABLE `order_items`  (
  `item_id` int NOT NULL AUTO_INCREMENT,
  `order_id` int NOT NULL,
  `product_id` int NOT NULL,
  `quantity` int NOT NULL,
  PRIMARY KEY (`item_id`) USING BTREE,
  INDEX `order_id`(`order_id` ASC) USING BTREE,
  INDEX `product_id`(`product_id` ASC) USING BTREE,
  CONSTRAINT `order_id` FOREIGN KEY (`order_id`) REFERENCES `orders` (`order_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `product_id` FOREIGN KEY (`product_id`) REFERENCES `products` (`product_id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE = InnoDB AUTO_INCREMENT = 26 CHARACTER SET = ucs2 COLLATE = ucs2_unicode_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of order_items
-- ----------------------------
INSERT INTO `order_items` VALUES (1, 1, 3, 2);
INSERT INTO `order_items` VALUES (2, 1, 5, 1);
INSERT INTO `order_items` VALUES (3, 2, 1, 3);
INSERT INTO `order_items` VALUES (4, 2, 4, 1);
INSERT INTO `order_items` VALUES (5, 3, 2, 2);
INSERT INTO `order_items` VALUES (6, 3, 3, 1);
INSERT INTO `order_items` VALUES (7, 3, 5, 2);
INSERT INTO `order_items` VALUES (8, 4, 4, 2);
INSERT INTO `order_items` VALUES (9, 4, 2, 1);
INSERT INTO `order_items` VALUES (10, 4, 1, 3);
INSERT INTO `order_items` VALUES (11, 5, 3, 1);
INSERT INTO `order_items` VALUES (12, 5, 5, 2);
INSERT INTO `order_items` VALUES (13, 6, 1, 1);
INSERT INTO `order_items` VALUES (14, 6, 4, 2);
INSERT INTO `order_items` VALUES (15, 6, 2, 1);
INSERT INTO `order_items` VALUES (16, 7, 5, 3);
INSERT INTO `order_items` VALUES (17, 7, 2, 1);
INSERT INTO `order_items` VALUES (18, 8, 4, 1);
INSERT INTO `order_items` VALUES (19, 9, 2, 2);
INSERT INTO `order_items` VALUES (20, 9, 1, 2);
INSERT INTO `order_items` VALUES (21, 9, 3, 1);
INSERT INTO `order_items` VALUES (22, 9, 5, 1);
INSERT INTO `order_items` VALUES (23, 10, 1, 2);
INSERT INTO `order_items` VALUES (24, 10, 4, 1);
INSERT INTO `order_items` VALUES (25, 10, 3, 2);

-- ----------------------------
-- Table structure for orders
-- ----------------------------
DROP TABLE IF EXISTS `orders`;
CREATE TABLE `orders`  (
  `order_id` int NOT NULL AUTO_INCREMENT,
  `user_id` int NOT NULL,
  `date` date NOT NULL,
  PRIMARY KEY (`order_id`) USING BTREE,
  INDEX `user_id`(`user_id` ASC) USING BTREE,
  CONSTRAINT `user_id` FOREIGN KEY (`user_id`) REFERENCES `users` (`user_id`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE = InnoDB AUTO_INCREMENT = 11 CHARACTER SET = ucs2 COLLATE = ucs2_unicode_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of orders
-- ----------------------------
INSERT INTO `orders` VALUES (1, 1, '2024-05-01');
INSERT INTO `orders` VALUES (2, 2, '2024-05-02');
INSERT INTO `orders` VALUES (3, 3, '2024-05-03');
INSERT INTO `orders` VALUES (4, 4, '2024-05-04');
INSERT INTO `orders` VALUES (5, 5, '2024-05-05');
INSERT INTO `orders` VALUES (6, 1, '2024-05-06');
INSERT INTO `orders` VALUES (7, 2, '2024-05-07');
INSERT INTO `orders` VALUES (8, 3, '2024-05-08');
INSERT INTO `orders` VALUES (9, 4, '2024-05-09');
INSERT INTO `orders` VALUES (10, 5, '2024-05-10');

-- ----------------------------
-- Table structure for products
-- ----------------------------
DROP TABLE IF EXISTS `products`;
CREATE TABLE `products`  (
  `product_id` int NOT NULL AUTO_INCREMENT,
  `title` varchar(50) CHARACTER SET ucs2 COLLATE ucs2_unicode_ci NOT NULL,
  `type` varchar(50) CHARACTER SET ucs2 COLLATE ucs2_unicode_ci NOT NULL,
  `price` double NOT NULL,
  PRIMARY KEY (`product_id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 11 CHARACTER SET = ucs2 COLLATE = ucs2_unicode_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of products
-- ----------------------------
INSERT INTO `products` VALUES (1, 'Mikrovalna pećnica', 'Kuhinjski aparati', 300);
INSERT INTO `products` VALUES (2, 'Pametni telefon', 'Elektronika', 600);
INSERT INTO `products` VALUES (3, 'Sportska jakna', 'Odjeća', 80);
INSERT INTO `products` VALUES (4, 'Knjiga \"Rat i mir\"', 'Knjige', 25);
INSERT INTO `products` VALUES (5, 'Bluetooth zvučnik', 'Audio oprema', 50);
INSERT INTO `products` VALUES (6, 'Bicikl', 'Sportska oprema', 250);
INSERT INTO `products` VALUES (7, 'Svećnjak od stakla', 'Dekoracija', 15);
INSERT INTO `products` VALUES (8, 'Ručni blender', 'Kuhinjski aparati', 40);
INSERT INTO `products` VALUES (9, 'LED TV', 'Televizori', 700);
INSERT INTO `products` VALUES (10, 'Planinarske cipele', 'Obuća', 120);

-- ----------------------------
-- Table structure for storage
-- ----------------------------
DROP TABLE IF EXISTS `storage`;
CREATE TABLE `storage`  (
  `storage_id` int NOT NULL AUTO_INCREMENT,
  `product_id` int NOT NULL,
  `quantity` int NOT NULL,
  PRIMARY KEY (`storage_id`) USING BTREE,
  INDEX `product`(`product_id` ASC) USING BTREE,
  CONSTRAINT `product` FOREIGN KEY (`product_id`) REFERENCES `products` (`product_id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE = InnoDB AUTO_INCREMENT = 11 CHARACTER SET = ucs2 COLLATE = ucs2_unicode_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of storage
-- ----------------------------
INSERT INTO `storage` VALUES (1, 1, 50);
INSERT INTO `storage` VALUES (2, 2, 100);
INSERT INTO `storage` VALUES (3, 3, 30);
INSERT INTO `storage` VALUES (4, 4, 20);
INSERT INTO `storage` VALUES (5, 5, 80);
INSERT INTO `storage` VALUES (6, 6, 150);
INSERT INTO `storage` VALUES (7, 7, 200);
INSERT INTO `storage` VALUES (8, 8, 50);
INSERT INTO `storage` VALUES (9, 9, 40);
INSERT INTO `storage` VALUES (10, 10, 15);

-- ----------------------------
-- Table structure for users
-- ----------------------------
DROP TABLE IF EXISTS `users`;
CREATE TABLE `users`  (
  `user_id` int NOT NULL AUTO_INCREMENT,
  `name` varchar(25) CHARACTER SET ucs2 COLLATE ucs2_unicode_ci NOT NULL,
  `surname` varchar(25) CHARACTER SET ucs2 COLLATE ucs2_unicode_ci NULL DEFAULT NULL,
  `city` varchar(30) CHARACTER SET ucs2 COLLATE ucs2_unicode_ci NOT NULL,
  `address` varchar(50) CHARACTER SET ucs2 COLLATE ucs2_unicode_ci NULL DEFAULT NULL,
  `phone` varchar(16) CHARACTER SET ucs2 COLLATE ucs2_unicode_ci NULL DEFAULT NULL,
  `username` varchar(25) CHARACTER SET ucs2 COLLATE ucs2_unicode_ci NOT NULL,
  `password` varchar(25) CHARACTER SET ucs2 COLLATE ucs2_unicode_ci NOT NULL,
  PRIMARY KEY (`user_id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 11 CHARACTER SET = ucs2 COLLATE = ucs2_unicode_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of users
-- ----------------------------
INSERT INTO `users` VALUES (1, 'John', 'Doe', 'New York', '123 Main Street', '555-1234', 'johndoe', 'password123');
INSERT INTO `users` VALUES (2, 'Jane', 'Smith', 'Los Angeles', '456 Oak Avenue', '555-5678', 'janesmith', 'pass456');
INSERT INTO `users` VALUES (3, 'Mike', 'Johnson', 'Chicago', '789 Pine Lane', '555-9012', 'mikejohnson', 'mikepass789');
INSERT INTO `users` VALUES (4, 'Emily', 'Davis', 'Houston', '101 Cedar Road', '555-3456', 'emilydavis', 'emily789pass');
INSERT INTO `users` VALUES (5, 'Robert', 'White', 'Miami', '202 Birch Street', '555-6789', 'robertwhite', 'robertpass123');
INSERT INTO `users` VALUES (6, 'Anna', 'Taylor', 'San Francisco', '789 Elm Street', '555-4321', 'annataylor', 'anna432pass');
INSERT INTO `users` VALUES (7, 'David', 'Brown', 'Boston', '456 Maple Avenue', '555-8765', 'davidbrown', 'brownpass789');
INSERT INTO `users` VALUES (8, 'Emma', 'Wilson', 'Seattle', '321 Pine Street', '555-2109', 'emmawilson', 'emma210pass');
INSERT INTO `users` VALUES (9, 'James', 'Anderson', 'Philadelphia', '654 Oak Street', '555-7890', 'jamesanderson', 'james789pass');
INSERT INTO `users` VALUES (10, 'Sophia', 'Martinez', 'Dallas', '987 Elm Avenue', '555-1098', 'sophiamartinez', 'sophia109pass');

SET FOREIGN_KEY_CHECKS = 1;
