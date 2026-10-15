-- MySQL dump 10.13  Distrib 8.0.46, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: fitmaxdb
-- ------------------------------------------------------
-- Server version	8.0.46

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
-- Table structure for table `asistencias`
--

DROP TABLE IF EXISTS `asistencias`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `asistencias` (
  `IdAsistencia` int NOT NULL AUTO_INCREMENT,
  `IdCliente` int NOT NULL,
  `FechaHora` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`IdAsistencia`),
  KEY `IdCliente` (`IdCliente`),
  CONSTRAINT `asistencias_ibfk_1` FOREIGN KEY (`IdCliente`) REFERENCES `clientes` (`IdCliente`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `asistencias`
--

LOCK TABLES `asistencias` WRITE;
/*!40000 ALTER TABLE `asistencias` DISABLE KEYS */;
/*!40000 ALTER TABLE `asistencias` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `clientemembresia`
--

DROP TABLE IF EXISTS `clientemembresia`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `clientemembresia` (
  `IdClienteMembresia` int NOT NULL AUTO_INCREMENT,
  `IdCliente` int NOT NULL,
  `IdMembresia` int NOT NULL,
  `FechaInicio` date NOT NULL,
  `FechaFin` date NOT NULL,
  PRIMARY KEY (`IdClienteMembresia`),
  KEY `IdCliente` (`IdCliente`),
  KEY `IdMembresia` (`IdMembresia`),
  CONSTRAINT `clientemembresia_ibfk_1` FOREIGN KEY (`IdCliente`) REFERENCES `clientes` (`IdCliente`),
  CONSTRAINT `clientemembresia_ibfk_2` FOREIGN KEY (`IdMembresia`) REFERENCES `membresias` (`IdMembresia`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `clientemembresia`
--

LOCK TABLES `clientemembresia` WRITE;
/*!40000 ALTER TABLE `clientemembresia` DISABLE KEYS */;
/*!40000 ALTER TABLE `clientemembresia` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `clientes`
--

DROP TABLE IF EXISTS `clientes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `clientes` (
  `IdCliente` int NOT NULL AUTO_INCREMENT,
  `Nombres` varchar(100) NOT NULL,
  `Apellidos` varchar(100) NOT NULL,
  `Telefono` varchar(20) DEFAULT NULL,
  `Correo` varchar(100) DEFAULT NULL,
  `Peso` decimal(5,2) DEFAULT NULL,
  `Estatura` decimal(5,2) DEFAULT NULL,
  `FechaRegistro` date NOT NULL,
  PRIMARY KEY (`IdCliente`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `clientes`
--

LOCK TABLES `clientes` WRITE;
/*!40000 ALTER TABLE `clientes` DISABLE KEYS */;
/*!40000 ALTER TABLE `clientes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `detalleventa`
--

DROP TABLE IF EXISTS `detalleventa`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `detalleventa` (
  `IdDetalleVenta` int NOT NULL AUTO_INCREMENT,
  `IdVenta` int NOT NULL,
  `IdProducto` int NOT NULL,
  `Cantidad` int NOT NULL,
  `PrecioUnitario` decimal(10,2) NOT NULL,
  PRIMARY KEY (`IdDetalleVenta`),
  KEY `IdVenta` (`IdVenta`),
  KEY `IdProducto` (`IdProducto`),
  CONSTRAINT `detalleventa_ibfk_1` FOREIGN KEY (`IdVenta`) REFERENCES `ventas` (`IdVenta`),
  CONSTRAINT `detalleventa_ibfk_2` FOREIGN KEY (`IdProducto`) REFERENCES `productos` (`IdProducto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `detalleventa`
--

LOCK TABLES `detalleventa` WRITE;
/*!40000 ALTER TABLE `detalleventa` DISABLE KEYS */;
/*!40000 ALTER TABLE `detalleventa` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `membresias`
--

DROP TABLE IF EXISTS `membresias`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `membresias` (
  `IdMembresia` int NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(50) NOT NULL,
  `Precio` decimal(10,2) NOT NULL,
  `DuracionDias` int NOT NULL,
  PRIMARY KEY (`IdMembresia`),
  UNIQUE KEY `Nombre` (`Nombre`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `membresias`
--

LOCK TABLES `membresias` WRITE;
/*!40000 ALTER TABLE `membresias` DISABLE KEYS */;
INSERT INTO `membresias` VALUES (1,'Elite',0.00,30),(2,'Titán',0.00,30),(3,'Leyenda',0.00,30);
/*!40000 ALTER TABLE `membresias` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pagos`
--

DROP TABLE IF EXISTS `pagos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `pagos` (
  `IdPago` int NOT NULL AUTO_INCREMENT,
  `IdCliente` int NOT NULL,
  `Monto` decimal(10,2) NOT NULL,
  `FechaPago` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `MetodoPago` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`IdPago`),
  KEY `IdCliente` (`IdCliente`),
  CONSTRAINT `pagos_ibfk_1` FOREIGN KEY (`IdCliente`) REFERENCES `clientes` (`IdCliente`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pagos`
--

LOCK TABLES `pagos` WRITE;
/*!40000 ALTER TABLE `pagos` DISABLE KEYS */;
/*!40000 ALTER TABLE `pagos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `productos`
--

DROP TABLE IF EXISTS `productos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `productos` (
  `IdProducto` int NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(100) NOT NULL,
  `Precio` decimal(10,2) NOT NULL,
  `Stock` int NOT NULL DEFAULT '0',
  PRIMARY KEY (`IdProducto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `productos`
--

LOCK TABLES `productos` WRITE;
/*!40000 ALTER TABLE `productos` DISABLE KEYS */;
/*!40000 ALTER TABLE `productos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuarios`
--

DROP TABLE IF EXISTS `usuarios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `usuarios` (
  `IdUsuario` int NOT NULL AUTO_INCREMENT,
  `NombreUsuario` varchar(50) NOT NULL,
  `ContrasenaHash` varchar(255) NOT NULL,
  `Rol` varchar(30) NOT NULL,
  `Activo` tinyint(1) DEFAULT '1',
  PRIMARY KEY (`IdUsuario`),
  UNIQUE KEY `NombreUsuario` (`NombreUsuario`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuarios`
--

LOCK TABLES `usuarios` WRITE;
/*!40000 ALTER TABLE `usuarios` DISABLE KEYS */;
/*!40000 ALTER TABLE `usuarios` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ventas`
--

DROP TABLE IF EXISTS `ventas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ventas` (
  `IdVenta` int NOT NULL AUTO_INCREMENT,
  `FechaVenta` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `Total` decimal(10,2) NOT NULL,
  `IdUsuario` int DEFAULT NULL,
  PRIMARY KEY (`IdVenta`),
  KEY `IdUsuario` (`IdUsuario`),
  CONSTRAINT `ventas_ibfk_1` FOREIGN KEY (`IdUsuario`) REFERENCES `usuarios` (`IdUsuario`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ventas`
--

LOCK TABLES `ventas` WRITE;
/*!40000 ALTER TABLE `ventas` DISABLE KEYS */;
/*!40000 ALTER TABLE `ventas` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2026-10-15 12:41:11
