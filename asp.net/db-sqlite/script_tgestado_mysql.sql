/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

CREATE TABLE `tgestado` (
  `Id` int(11) NOT NULL,
  `Nome` varchar(50) NOT NULL,
  `Sigla` varchar(2) NOT NULL,
  `PaisId` int(11) NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_Estado_Nome` (`Nome`),
  KEY `IX_Estado_Sigla` (`Sigla`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

INSERT INTO `tgestado` (`Id`, `Nome`, `Sigla`, `PaisId`) VALUES
(11, 'Rondônia', 'RO', 1058);
INSERT INTO `tgestado` (`Id`, `Nome`, `Sigla`, `PaisId`) VALUES
(12, 'Acre', 'AC', 1058);
INSERT INTO `tgestado` (`Id`, `Nome`, `Sigla`, `PaisId`) VALUES
(13, 'Amazonas', 'AM', 1058);
INSERT INTO `tgestado` (`Id`, `Nome`, `Sigla`, `PaisId`) VALUES
(14, 'Roraima', 'RR', 1058),
(15, 'Pará', 'PA', 1058),
(16, 'Amapá', 'AP', 1058),
(17, 'Tocantis', 'TO', 1058),
(21, 'Maranhão', 'MA', 1058),
(22, 'Piauí', 'PI', 1058),
(23, 'Ceará', 'CE', 1058),
(24, 'Rio Grande do Norte', 'RN', 1058),
(25, 'Paraíba', 'PB', 1058),
(26, 'Pernambuco', 'PE', 1058),
(27, 'Alagoas', 'AL', 1058),
(28, 'Sergipe', 'SE', 1058),
(29, 'Bahia', 'BA', 1058),
(31, 'Minas Gerais', 'MG', 1058),
(32, 'Espírito Santo', 'ES', 1058),
(33, 'Rio de Janeiro', 'RJ', 1058),
(35, 'São Paulo', 'SP', 1058),
(41, 'Paraná', 'PR', 1058),
(42, 'Santa Catarina', 'SC', 1058),
(43, 'Rio Grande do Sul', 'RS', 1058),
(50, 'Mato Grosso do Sul', 'MS', 1058),
(51, 'Mato Grosso', 'MT', 1058),
(52, 'Goiás', 'GO', 1058),
(53, 'Distrito Federal', 'DF', 1058),
(99, 'EXTERIOR', 'EX', 99);

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;