-- --------------------------------------------------------
-- Host:                         localhost
-- Versión del servidor:         5.7.24 - MySQL Community Server (GPL)
-- SO del servidor:              Win64
-- HeidiSQL Versión:             9.5.0.5332
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


-- Volcando estructura de base de datos para equipos
CREATE DATABASE IF NOT EXISTS `equipos` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `equipos`;

-- Volcando estructura para tabla equipos.componente
CREATE TABLE IF NOT EXISTS `componente` (
  `idComponente` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `Nombre` text NOT NULL,
  `Fecha_Ingreso` date DEFAULT NULL,
  `Costo` float DEFAULT NULL,
  `Descripcion` text,
  PRIMARY KEY (`idComponente`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- La exportación de datos fue deseleccionada.
-- Volcando estructura para tabla equipos.equipo
CREATE TABLE IF NOT EXISTS `equipo` (
  `idEquipo` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `Marca` tinytext,
  `Modelo` tinytext,
  `Estado` tinytext NOT NULL,
  `Tipo` tinytext,
  `Descripcion` tinytext,
  `Area` tinytext,
  `Encargado` tinytext,
  PRIMARY KEY (`idEquipo`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- La exportación de datos fue deseleccionada.
-- Volcando estructura para tabla equipos.inventario
CREATE TABLE IF NOT EXISTS `inventario` (
  `idInventario` int(11) unsigned NOT NULL,
  `idEquipo` int(11) unsigned NOT NULL,
  `idComponente` int(11) unsigned NOT NULL,
  `Estado` tinytext NOT NULL,
  PRIMARY KEY (`idInventario`),
  KEY `FK_inventario_equipo` (`idEquipo`),
  KEY `FK_inventario_componente` (`idComponente`),
  CONSTRAINT `FK_inventario_componente` FOREIGN KEY (`idComponente`) REFERENCES `componente` (`idComponente`),
  CONSTRAINT `FK_inventario_equipo` FOREIGN KEY (`idEquipo`) REFERENCES `equipo` (`idEquipo`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- La exportación de datos fue deseleccionada.
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
