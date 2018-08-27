/*
Navicat MySQL Data Transfer

Source Server         : storemanagement_pc
Source Server Version : 50719
Source Host           : localhost:3306
Source Database       : cangku_01

Target Server Type    : MYSQL
Target Server Version : 50719
File Encoding         : 65001

Date: 2018-08-23 10:37:27
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for `t_checkdate`
-- ----------------------------
DROP TABLE IF EXISTS `t_checkdate`;
CREATE TABLE `t_checkdate` (
  `ch_id` int(11) NOT NULL AUTO_INCREMENT COMMENT '检查日期id',
  `ch_instrumentid` int(11) NOT NULL COMMENT '仪器数据库ID',
  `ch_date` date NOT NULL COMMENT '检查日期',
  PRIMARY KEY (`ch_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of t_checkdate
-- ----------------------------

-- ----------------------------
-- Table structure for `t_department`
-- ----------------------------
DROP TABLE IF EXISTS `t_department`;
CREATE TABLE `t_department` (
  `de_id` int(11) NOT NULL AUTO_INCREMENT COMMENT '节点ID',
  `de_name` varchar(50) NOT NULL COMMENT '节点名字',
  `de_tier` int(11) NOT NULL COMMENT '节点层级',
  `de_belongId` int(11) NOT NULL COMMENT '父节点id',
  PRIMARY KEY (`de_id`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of t_department
-- ----------------------------
INSERT INTO `t_department` VALUES ('1', '红叶', '0', '0');
INSERT INTO `t_department` VALUES ('2', '人事部', '1', '1');
INSERT INTO `t_department` VALUES ('3', '研发部', '1', '1');
INSERT INTO `t_department` VALUES ('4', '销售部', '1', '1');
INSERT INTO `t_department` VALUES ('5', '阿里巴巴', '0', '0');
INSERT INTO `t_department` VALUES ('6', '腾讯', '0', '0');
INSERT INTO `t_department` VALUES ('7', '人事部', '1', '5');
INSERT INTO `t_department` VALUES ('8', '人事A组', '2', '2');
INSERT INTO `t_department` VALUES ('11', '研发A组', '2', '3');
INSERT INTO `t_department` VALUES ('12', '人事', '2', '0');

-- ----------------------------
-- Table structure for `t_employee`
-- ----------------------------
DROP TABLE IF EXISTS `t_employee`;
CREATE TABLE `t_employee` (
  `em_id` int(11) NOT NULL AUTO_INCREMENT COMMENT '员工ID',
  `em_employeenumber` int(11) NOT NULL COMMENT '员工编号',
  `em_name` varchar(50) NOT NULL COMMENT '员工名字',
  `em_sex` varchar(50) NOT NULL COMMENT '员工性别',
  `em_company` int(50) NOT NULL COMMENT '所属公司ID',
  `em_department` int(50) NOT NULL COMMENT '所属部门ID',
  `em_group` int(50) NOT NULL COMMENT '所属小组ID',
  PRIMARY KEY (`em_id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of t_employee
-- ----------------------------
INSERT INTO `t_employee` VALUES ('1', '1', '马华', '男', '5', '7', '9');
INSERT INTO `t_employee` VALUES ('2', '2', '燕廷', '男', '1', '2', '8');

-- ----------------------------
-- Table structure for `t_insborrow`
-- ----------------------------
DROP TABLE IF EXISTS `t_insborrow`;
CREATE TABLE `t_insborrow` (
  `ins_borrowid` int(11) NOT NULL AUTO_INCREMENT COMMENT '借用仪器表的主键',
  `ins_tagid` varchar(15) NOT NULL COMMENT '借用仪器的id',
  `ins_name` varchar(10) NOT NULL COMMENT '借用仪器的名称',
  `ins_throughtime` varchar(10) NOT NULL COMMENT '借用仪器的时间',
  `ins_throughstate` varchar(10) NOT NULL COMMENT '借用仪器的状态',
  PRIMARY KEY (`ins_borrowid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of t_insborrow
-- ----------------------------

-- ----------------------------
-- Table structure for `t_instrument`
-- ----------------------------
DROP TABLE IF EXISTS `t_instrument`;
CREATE TABLE `t_instrument` (
  `in_id` int(11) NOT NULL AUTO_INCREMENT COMMENT '仪器sqlID',
  `in_tagid` varchar(255) NOT NULL COMMENT '仪器标签ID',
  `in_name` varchar(255) NOT NULL COMMENT '仪器名字',
  `in_model` varchar(255) NOT NULL COMMENT '型号规格',
  `in_manufactor` varchar(255) NOT NULL COMMENT '生产厂商',
  `in_serialnumber` varchar(255) NOT NULL COMMENT '出厂编号',
  `in_productiondate` date NOT NULL COMMENT '生产日期',
  `in_position` varchar(255) NOT NULL COMMENT '货架位置',
  `in_isinwarehouse` varchar(255) NOT NULL COMMENT '在库状态',
  `in_checkcycle` int(11) NOT NULL COMMENT '鉴定周期（日）',
  `in_lastchecktimes` date NOT NULL COMMENT '上一次检查日期',
  `in_duty` varchar(255) NOT NULL COMMENT '责任人',
  PRIMARY KEY (`in_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of t_instrument
-- ----------------------------

-- ----------------------------
-- Table structure for `t_warehouselocation`
-- ----------------------------
DROP TABLE IF EXISTS `t_warehouselocation`;
CREATE TABLE `t_warehouselocation` (
  `wa_id` int(11) NOT NULL AUTO_INCREMENT COMMENT '仓库位置id',
  `wa_name` varchar(255) NOT NULL COMMENT '位置名字',
  `wa_tier` int(11) NOT NULL COMMENT '层级',
  `wa_belongid` int(11) NOT NULL COMMENT '父节点id',
  `wa_instrument` varchar(255) DEFAULT NULL COMMENT '仪器id',
  `wa_ledid` varchar(255) NOT NULL COMMENT '仓库灯id',
  PRIMARY KEY (`wa_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of t_warehouselocation
-- ----------------------------
