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
  CONSTRAINT `fk_tbl_citas_tbl_ticket1` FOREIGN KEY (`correlativo_ticket`) REFERENCES `tbl_ticket` (`correlativo_ticket`)
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
-- Table structure for table `tbl_ciudadanos_mayores`
--

DROP TABLE IF EXISTS `tbl_ciudadanos_mayores`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_ciudadanos_mayores` (
  `CUI` varchar(15) NOT NULL,
  `Nombre` varchar(45) DEFAULT NULL,
  `Apellido` varchar(45) DEFAULT NULL,
  `Nacionalidad` varchar(45) DEFAULT NULL,
  `Pais_Nacimiento` varchar(45) DEFAULT NULL,
  `Sexo` varchar(45) DEFAULT NULL,
  `Fecha_Nac` date DEFAULT NULL,
  `boleto_ornato` int(11) DEFAULT NULL,
  `boleta_banco` int(11) DEFAULT NULL,
  `estado` tinyint(2) DEFAULT NULL,
  PRIMARY KEY (`CUI`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_ciudadanos_mayores`
--

LOCK TABLES `tbl_ciudadanos_mayores` WRITE;
/*!40000 ALTER TABLE `tbl_ciudadanos_mayores` DISABLE KEYS */;
INSERT INTO `tbl_ciudadanos_mayores` VALUES ('3001370360101','Angel','Solares','guatemalteco','Guatemala','M','1997-06-13',1,23,1);
/*!40000 ALTER TABLE `tbl_ciudadanos_mayores` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_ciudadanos_menores`
--

DROP TABLE IF EXISTS `tbl_ciudadanos_menores`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_ciudadanos_menores` (
  `CUI` varchar(15) NOT NULL,
  `Nombre` varchar(45) DEFAULT NULL,
  `Apellidos` varchar(45) DEFAULT NULL,
  `Nacionalidad` varchar(45) DEFAULT NULL,
  `Pais_Nacimiento` varchar(45) DEFAULT NULL,
  `Sexo` varchar(45) DEFAULT NULL,
  `Fecha_Nacimiento` date DEFAULT NULL,
  `cui_padre` int(13) DEFAULT NULL,
  `cui_madre` int(13) DEFAULT NULL,
  `documento_legal` blob,
  `boleta_banco` int(11) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`CUI`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_ciudadanos_menores`
--

LOCK TABLES `tbl_ciudadanos_menores` WRITE;
/*!40000 ALTER TABLE `tbl_ciudadanos_menores` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_ciudadanos_menores` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_login`
--

DROP TABLE IF EXISTS `tbl_login`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_login` (
  `cod_usu` int(11) NOT NULL AUTO_INCREMENT,
  `usuario_login` varchar(45) DEFAULT NULL,
  `pass_login` varchar(45) DEFAULT NULL,
  `tipo_user` int(11) DEFAULT NULL,
  `estado` tinyint(2) DEFAULT NULL,
  PRIMARY KEY (`cod_usu`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_login`
--

LOCK TABLES `tbl_login` WRITE;
/*!40000 ALTER TABLE `tbl_login` DISABLE KEYS */;
INSERT INTO `tbl_login` VALUES (1,'adm','202cb962ac59075b964b07152d234b70',1,1),(2,'jose','202cb962ac59075b964b07152d234b70',1,1);
/*!40000 ALTER TABLE `tbl_login` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_pasaport_ciudadano`
--

DROP TABLE IF EXISTS `tbl_pasaport_ciudadano`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_pasaport_ciudadano` (
  `numerodepasaporte` int(11) NOT NULL,
  `cui` varchar(15) NOT NULL,
  `estado` tinyint(2) DEFAULT NULL,
  PRIMARY KEY (`numerodepasaporte`,`cui`),
  KEY `fk_tbl_ciudadanos_mayores_tbl_pasaporte1_idx` (`cui`),
  CONSTRAINT `fk_tbl_pasaport_ciudadano_tbl_ciudadanos_mayores1` FOREIGN KEY (`cui`) REFERENCES `tbl_ciudadanos_mayores` (`CUI`),
  CONSTRAINT `fk_tbl_pasaport_ciudadano_tbl_ciudadanos_menores1` FOREIGN KEY (`cui`) REFERENCES `tbl_ciudadanos_menores` (`CUI`),
  CONSTRAINT `fk_tbl_pasaport_ciudadano_tbl_pasaporte1` FOREIGN KEY (`numerodepasaporte`) REFERENCES `tbl_pasaporte` (`numerodepasaporte`)
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
  CONSTRAINT `fk_tbl_stock_pasaportes_tbl_proveedores` FOREIGN KEY (`cod_proveedor`) REFERENCES `tbl_proveedores` (`cod_proveedor`)
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
  `correlativo_ticket` int(11) NOT NULL AUTO_INCREMENT,
  `cui_solicitante` varchar(15) DEFAULT NULL,
  `numerodeturno_citas` int(11) DEFAULT NULL,
  `fechayhora` datetime DEFAULT NULL,
  `estado` tinyint(2) DEFAULT NULL,
  PRIMARY KEY (`correlativo_ticket`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_ticket`
--

LOCK TABLES `tbl_ticket` WRITE;
/*!40000 ALTER TABLE `tbl_ticket` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_ticket` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_wsbanco`
--

DROP TABLE IF EXISTS `tbl_wsbanco`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_wsbanco` (
  `doc_numero` int(11) NOT NULL,
  `estado` tinyint(4) DEFAULT NULL,
  PRIMARY KEY (`doc_numero`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_wsbanco`
--

LOCK TABLES `tbl_wsbanco` WRITE;
/*!40000 ALTER TABLE `tbl_wsbanco` DISABLE KEYS */;
INSERT INTO `tbl_wsbanco` VALUES (23,1);
/*!40000 ALTER TABLE `tbl_wsbanco` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_wsmunicipalidad`
--

DROP TABLE IF EXISTS `tbl_wsmunicipalidad`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_wsmunicipalidad` (
  `doc_numero` int(11) NOT NULL,
  `estado` tinyint(4) DEFAULT NULL,
  PRIMARY KEY (`doc_numero`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_wsmunicipalidad`
--

LOCK TABLES `tbl_wsmunicipalidad` WRITE;
/*!40000 ALTER TABLE `tbl_wsmunicipalidad` DISABLE KEYS */;
INSERT INTO `tbl_wsmunicipalidad` VALUES (1,1);
/*!40000 ALTER TABLE `tbl_wsmunicipalidad` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_wsrenap`
--

DROP TABLE IF EXISTS `tbl_wsrenap`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_wsrenap` (
  `CUI` varchar(14) NOT NULL,
  `Nombres` varchar(45) DEFAULT NULL,
  `apellidos` varchar(45) DEFAULT NULL,
  `nacionalidad` varchar(45) DEFAULT NULL,
  `sexo` varchar(45) DEFAULT NULL,
  `fecha_nacimiento` date DEFAULT NULL,
  `pais_nacimiento` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`CUI`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_wsrenap`
--

LOCK TABLES `tbl_wsrenap` WRITE;
/*!40000 ALTER TABLE `tbl_wsrenap` DISABLE KEYS */;
INSERT INTO `tbl_wsrenap` VALUES ('3001370360101','Angel','Solares','guatemalteco','M','1997-06-13','Guatemala');
/*!40000 ALTER TABLE `tbl_wsrenap` ENABLE KEYS */;
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

-- Dump completed on 2020-02-18 22:40:31
