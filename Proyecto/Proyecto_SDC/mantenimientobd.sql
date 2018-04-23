-- phpMyAdmin SQL Dump
-- version 4.7.4
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1:3306
-- Tiempo de generación: 22-04-2018 a las 20:55:42
-- Versión del servidor: 5.7.19
-- Versión de PHP: 5.6.31

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `mantenimientobd`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cliente`
--

DROP TABLE IF EXISTS `cliente`;
CREATE TABLE IF NOT EXISTS `cliente` (
  `id_cliente` int(50) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(50) NOT NULL,
  `direccion` varchar(50) NOT NULL,
  `telefono` varchar(50) NOT NULL,
  PRIMARY KEY (`id_cliente`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `cliente`
--

INSERT INTO `cliente` (`id_cliente`, `nombre`, `direccion`, `telefono`) VALUES
(1, 'luis', 'flamin', '6554678'),
(2, 'Marisol Galvan', 'Mirador #5', '9821145'),
(3, 'martin Castillo', 'lopez mateo', '77113455'),
(4, 'Alejandro Robles', 'Anastacio V. y Nojosa', '498-121-51-50'),
(5, 'luis', 'faisan', '12345678'),
(6, 'luis', 'faisan', '12345678'),
(7, 'luis', 'faisan', '12345678'),
(8, 'luis', 'faisan', '12345678'),
(9, 'luis', 'faisan', '12345678'),
(10, 'luis', 'faisan', '12345678'),
(11, 'Pancho Barraza', 'Insurgentes #3', '4559784561'),
(12, 'Mauricio Avila', 'Inde #15', '4984169');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `equipo`
--

DROP TABLE IF EXISTS `equipo`;
CREATE TABLE IF NOT EXISTS `equipo` (
  `no_orden` int(11) NOT NULL AUTO_INCREMENT,
  `id_cliente` int(11) NOT NULL,
  `marca` varchar(50) NOT NULL,
  `modelo` varchar(50) NOT NULL,
  `funcionalidad` tinytext NOT NULL,
  `tipo` varchar(50) NOT NULL,
  PRIMARY KEY (`no_orden`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `equipo`
--

INSERT INTO `equipo` (`no_orden`, `id_cliente`, `marca`, `modelo`, `funcionalidad`, `tipo`) VALUES
(1, 1, '1', '1', 'Si', '1'),
(2, 2, '1', '1', 'Si', '1'),
(3, 2, '2', '2', 'No', '2'),
(4, 3, '3', '3', 'Si', '3'),
(5, 5, 'dell', 'asus', 'No', 'laptop'),
(6, 12, 'hp', 'enterprise', 'Si', 'escritorio'),
(7, 4, 'toshiba', 'satellite', 'No', 'laptop');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
