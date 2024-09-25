-- --------------------------------------------------------
-- Host:                         161.132.40.158
-- Versión del servidor:         10.5.6-MariaDB-1:10.5.6+maria~focal - mariadb.org binary distribution
-- SO del servidor:              debian-linux-gnu
-- HeidiSQL Versión:             12.7.0.6859
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

-- Volcando datos para la tabla bd_jer.Tb_Cargo: ~0 rows (aproximadamente)


-- Volcando datos para la tabla bd_jer.Tb_Distrito: ~1 rows (aproximadamente)

INSERT INTO `Tb_Distrito` (`IdDistrito`, `Distrito`, `IdProvincia`, `Estatus`) VALUES
	(1, 'Ayacucho', 1, 1);

-- Volcando datos para la tabla bd_jer.Tb_EstadoCivil: ~3 rows (aproximadamente)

INSERT INTO `Tb_EstadoCivil` (`IdEstadoCivil`, `EstadoCivil`, `Estatus`) VALUES
	(1, 'Casado(a)', 1),
	(2, 'Soltero(a)', 1),
	(3, 'Viudo(a)', 1);

-- Volcando datos para la tabla bd_jer.Tb_GradoInstruccion: ~6 rows (aproximadamente)

INSERT INTO `Tb_GradoInstruccion` (`IdGradoInstruccion`, `GradoInstruccion`, `Estatus`) VALUES
	(1, 'Primaria', 1),
	(2, 'Secundaria', 1),
	(3, 'Superior tecnico', 1),
	(4, 'Superior Universitario', 1),
	(5, 'Postgrado', 1),
	(6, 'Doctor', 1);

-- Volcando datos para la tabla bd_jer.Tb_GradoMinisterial: ~1 rows (aproximadamente)

INSERT INTO `Tb_GradoMinisterial` (`IdGradoministerial`, `GradoMinisterial`, `Estatus`) VALUES
	(1, 'Obrero', 1);

-- Volcando datos para la tabla bd_jer.Tb_Iglesia: ~1 rows (aproximadamente)

INSERT INTO `Tb_Iglesia` (`IdIglesia`, `NombreIglesia`, `Direccion`, `IdDistrito`, `IdSectorIglesia`, `Estatus`) VALUES
	(1, 'Luz y Vida', 'Direccion', 1, 1, 1);

-- Volcando datos para la tabla bd_jer.Tb_Ministro: ~1 rows (aproximadamente)

INSERT INTO `Tb_Ministro` (`IdMinistro`, `Codigo`, `IdGradoministerial`, `ApPaterno`, `ApMaterno`, `Nombres`, `FechaNacimiento`, `Edad`, `IdSexo`, `IdEstadoCivil`, `IdGradoInstruccion`, `DNI_Pasaporte_Carne`, `IdPais`, `IdIglesia`, `IdConyugue`, `Direccion`, `IdDistrito`, `Telefono`, `Movil01`, `Movil02`, `Correo`, `Pastorea`, `TiempoMinisterial`, `DiagnosticoGeneral`, `NroFundoIglesias`, `Hijos`, `Seguros`, `Estatus`) VALUES
	(1, 7777, 1, 'Anaya', 'Gutierrez', 'Eliu Eliezer', '2002-03-15', 22, 1, 2, 4, '6666', 1, 1, NULL, 'Direccion', 1, '65456546', '456', NULL, 'eliu@gmail.com', 1, NULL, NULL, NULL, NULL, NULL, 1);

-- Volcando datos para la tabla bd_jer.Tb_Pais: ~1 rows (aproximadamente)

INSERT INTO `Tb_Pais` (`IdPais`, `Pais`, `Estatus`) VALUES
	(1, 'Peru', 1);

-- Volcando datos para la tabla bd_jer.Tb_Provincia: ~1 rows (aproximadamente)

INSERT INTO `Tb_Provincia` (`IdProvincia`, `Provincia`, `IdRegion`, `Estatus`) VALUES
	(1, 'Huamanga', 1, 1);

-- Volcando datos para la tabla bd_jer.Tb_Region: ~1 rows (aproximadamente)

INSERT INTO `Tb_Region` (`IdRegion`, `Region`, `IdPais`, `Estatus`) VALUES
	(1, 'Ayacucho', 1, 1);

-- Volcando datos para la tabla bd_jer.Tb_Rol: ~3 rows (aproximadamente)

INSERT INTO `Tb_Rol` (`IdRol`, `Rol`, `Estatus`) VALUES
	(1, 'Administrador', 1),
	(2, 'Colaborador', 1),
	(3, 'Ministro', 1);

-- Volcando datos para la tabla bd_jer.Tb_SectorIglesia: ~1 rows (aproximadamente)

INSERT INTO `Tb_SectorIglesia` (`IdSectorIglesia`, `SectorIglesia`, `Estatus`) VALUES
	(1, 'Huamanga', 1);

-- Volcando datos para la tabla bd_jer.Tb_Sexo: ~2 rows (aproximadamente)

INSERT INTO `Tb_Sexo` (`IdSexo`, `Sexo`, `Estatus`) VALUES
	(1, 'Masculino', 1),
	(2, 'Femenino', 1);

-- Volcando datos para la tabla bd_jer.Tb_Usuario: ~1 rows (aproximadamente)

INSERT INTO `Tb_Usuario` (`IdUsuario`, `Usuario`, `Correo`, `Contraseña`, `IdMinistro`, `IdRol`, `Estatus`) VALUES
	(1, 'admin', 'admin@gmail.com', '123456', 1, 1, 1);

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
