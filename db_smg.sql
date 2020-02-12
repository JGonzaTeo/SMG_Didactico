CREATE DATABASE  IF NOT EXISTS `mydb` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `mydb`;
-- MySQL dump 10.13  Distrib 5.7.17, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: mydb
-- ------------------------------------------------------
-- Server version	5.5.5-10.1.34-MariaDB

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `tbl_citas`
--

DROP TABLE IF EXISTS `tbl_citas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_citas` (
  `correlativo_cita` int(11) NOT NULL,
  `correlativo_ticket` int(11) DEFAULT NULL,
  `completado` tinyint(2) DEFAULT NULL,
  PRIMARY KEY (`correlativo_cita`),
  KEY `fk_tbl_citas_tbl_ticket1_idx` (`correlativo_ticket`),
  CONSTRAINT `fk_tbl_citas_tbl_ticket1` FOREIGN KEY (`correlativo_ticket`) REFERENCES `tbl_ticket` (`correlativo_ticket`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_citas`
--

LOCK TABLES `tbl_citas` WRITE;
/*!40000 ALTER TABLE `tbl_citas` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_citas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_ciudadanos`
--

DROP TABLE IF EXISTS `tbl_ciudadanos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_ciudadanos` (
  `dpi` int(11) NOT NULL,
  `entrega_de_doc` tinyint(2) DEFAULT NULL,
  `primer_nombre` varchar(45) DEFAULT NULL,
  `primer_apellido` varchar(45) DEFAULT NULL,
  `telefono` varchar(45) DEFAULT NULL,
  `residente_o_extranjero` tinyint(2) DEFAULT NULL,
  `foto` blob,
  `estado` tinyint(2) DEFAULT NULL,
  PRIMARY KEY (`dpi`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_ciudadanos`
--

LOCK TABLES `tbl_ciudadanos` WRITE;
/*!40000 ALTER TABLE `tbl_ciudadanos` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_ciudadanos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_pasaport_ciudadano`
--

DROP TABLE IF EXISTS `tbl_pasaport_ciudadano`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_pasaport_ciudadano` (
  `numerodepasaporte` int(11) NOT NULL,
  `dpi` int(11) NOT NULL,
  `estado` tinyint(2) DEFAULT NULL,
  PRIMARY KEY (`numerodepasaporte`,`dpi`),
  KEY `fk_tbl_pasaport_ciudadano_tbl_ciudadanos1_idx` (`dpi`),
  CONSTRAINT `fk_tbl_pasaport_ciudadano_tbl_ciudadanos1` FOREIGN KEY (`dpi`) REFERENCES `tbl_ciudadanos` (`dpi`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_tbl_pasaport_ciudadano_tbl_pasaporte1` FOREIGN KEY (`numerodepasaporte`) REFERENCES `tbl_pasaporte` (`numerodepasaporte`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_pasaport_ciudadano`
--

LOCK TABLES `tbl_pasaport_ciudadano` WRITE;
/*!40000 ALTER TABLE `tbl_pasaport_ciudadano` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_pasaport_ciudadano` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_pasaporte`
--

DROP TABLE IF EXISTS `tbl_pasaporte`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_pasaporte` (
  `numerodepasaporte` int(11) NOT NULL,
  `tipodepasaporte` varchar(45) DEFAULT NULL,
  `codigoiso3166` int(11) DEFAULT NULL,
  `autoridadexpositora` varchar(45) DEFAULT NULL,
  `codigocan` varchar(45) DEFAULT NULL,
  `fecha_de_emision` date DEFAULT NULL,
  `fecha_de_expedicion` date DEFAULT NULL,
  `codigo_ocr` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`numerodepasaporte`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_pasaporte`
--

LOCK TABLES `tbl_pasaporte` WRITE;
/*!40000 ALTER TABLE `tbl_pasaporte` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_pasaporte` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_proveedores`
--

DROP TABLE IF EXISTS `tbl_proveedores`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_proveedores` (
  `cod_proveedor` int(11) NOT NULL,
  `nombre_proveedor` varchar(45) DEFAULT NULL,
  `numerodetelefono` int(11) DEFAULT NULL,
  `ubicacion` varchar(45) DEFAULT NULL,
  `estado` tinyint(2) DEFAULT NULL,
  PRIMARY KEY (`cod_proveedor`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_proveedores`
--

LOCK TABLES `tbl_proveedores` WRITE;
/*!40000 ALTER TABLE `tbl_proveedores` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_proveedores` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_stock_pasaportes`
--

DROP TABLE IF EXISTS `tbl_stock_pasaportes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_stock_pasaportes` (
  `cod_proveedor` int(11) NOT NULL,
  `cod_pedido` int(11) NOT NULL,
  `cantidad` int(11) DEFAULT NULL,
  `fecha_de_entrega` date DEFAULT NULL,
  `estado` tinyint(2) DEFAULT NULL,
  PRIMARY KEY (`cod_proveedor`,`cod_pedido`),
  CONSTRAINT `fk_tbl_stock_pasaportes_tbl_proveedores` FOREIGN KEY (`cod_proveedor`) REFERENCES `tbl_proveedores` (`cod_proveedor`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_stock_pasaportes`
--

LOCK TABLES `tbl_stock_pasaportes` WRITE;
/*!40000 ALTER TABLE `tbl_stock_pasaportes` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_stock_pasaportes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_ticket`
--

DROP TABLE IF EXISTS `tbl_ticket`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_ticket` (
  `correlativo_ticket` int(11) NOT NULL,
  `zona_de_emision` int(11) DEFAULT NULL,
  `numerodeturno_citas` int(11) DEFAULT NULL,
  `fechayhora` datetime DEFAULT NULL,
  `estado` tinyint(2) DEFAULT NULL,
  PRIMARY KEY (`correlativo_ticket`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_ticket`
--

LOCK TABLES `tbl_ticket` WRITE;
/*!40000 ALTER TABLE `tbl_ticket` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_ticket` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'mydb'
--

--
-- Dumping routines for database 'mydb'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-02-08 15:21:40
