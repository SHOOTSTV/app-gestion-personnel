DROP DATABASE IF EXISTS MLR1;

CREATE DATABASE IF NOT EXISTS MLR1;
CREATE USER 'user'@'%' IDENTIFIED BY 'Rh6qDynA5hDCvs';
GRANT USAGE ON *.* TO 'user'@'%';
GRANT ALL PRIVILEGES ON `mlr1`.* TO 'user'@'%';
USE MLR1;
--
-- Base de données : `mlr1`
--

-- --------------------------------------------------------

--
-- Structure de la table `absence`
--

DROP TABLE IF EXISTS `absence`;
CREATE TABLE IF NOT EXISTS `absence` (
  `IDPERSONNEL` int(11) NOT NULL,
  `DATEDEBUT` datetime NOT NULL,
  `IDMOTIF` int(11) NOT NULL,
  `DATEFIN` datetime DEFAULT NULL,
  PRIMARY KEY (`IDPERSONNEL`,`DATEDEBUT`),
  KEY `I_FK_ABSENCE_MOTIF` (`IDMOTIF`),
  KEY `I_FK_ABSENCE_PERSONNEL` (`IDPERSONNEL`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `absence`
--

INSERT INTO `absence` (`IDPERSONNEL`, `DATEDEBUT`, `IDMOTIF`, `DATEFIN`) VALUES
(1, '2021-05-09 01:57:25', 1, '2021-05-25 01:57:25'),
(1, '2020-09-10 10:58:27', 1, '2020-10-05 18:44:05'),
(6, '2021-05-09 03:51:51', 4, '2021-06-26 03:51:50'),
(2, '2020-08-12 21:13:53', 2, '2020-11-18 09:56:26'),
(2, '2020-08-31 12:28:24', 1, '2020-11-25 18:53:36'),
(6, '2020-09-05 19:25:53', 2, '2020-12-16 06:44:44'),
(2, '2020-09-26 11:06:30', 1, '2020-10-20 11:39:24'),
(4, '2020-09-03 14:01:18', 2, '2020-11-08 04:59:33'),
(4, '2020-08-30 01:38:06', 4, '2020-12-02 19:59:24'),
(4, '2020-08-22 18:10:39', 2, '2020-12-20 01:58:17'),
(4, '2020-09-19 05:21:42', 1, '2020-11-21 14:57:32'),
(2, '2020-09-24 14:25:12', 4, '2020-11-11 01:54:28'),
(5, '2021-11-02 10:20:14', 1, '2021-06-25 18:53:14'),
(4, '2020-09-24 22:14:09', 1, '2020-11-19 03:47:11'),
(2, '2020-08-10 21:07:50', 2, '2020-11-18 21:42:50'),
(1, '2020-09-08 12:36:53', 4, '2020-12-12 15:14:23'),
(4, '2020-09-24 09:33:41', 4, '2020-12-22 05:05:19'),
(5, '2021-10-13 18:53:14', 1, '2021-06-25 18:53:14'),
(2, '2020-08-25 03:33:36', 2, '2020-12-17 01:49:28'),
(5, '2021-11-02 12:20:14', 1, '2021-06-25 18:53:14'),
(4, '2020-09-07 13:29:43', 4, '2020-12-15 02:36:37'),
(1, '2020-09-14 04:40:41', 1, '2020-10-12 22:38:29'),
(1, '2020-08-27 00:15:29', 4, '2020-11-12 12:51:58'),
(103, '2021-05-05 18:09:00', 2, '2021-05-13 02:25:52'),
(1, '2020-09-01 17:21:53', 4, '2020-10-20 17:57:03'),
(1, '2020-08-27 03:35:10', 3, '2020-11-23 23:52:21'),
(4, '2020-09-04 14:51:47', 3, '2020-10-19 21:09:09'),
(1, '2020-09-14 19:09:09', 3, '2020-10-01 20:14:50'),
(5, '2021-10-13 00:02:14', 1, '2021-06-25 15:53:14'),
(2, '2020-09-02 15:36:41', 1, '2020-11-13 20:29:49'),
(4, '2020-08-17 19:56:31', 1, '2020-11-21 22:12:39'),
(4, '2020-09-04 16:01:46', 4, '2020-10-14 18:45:52'),
(4, '2020-09-19 12:21:19', 4, '2020-10-14 03:45:00'),
(6, '2020-09-20 05:25:37', 3, '2020-12-29 19:55:02'),
(2, '2020-08-06 23:26:20', 4, '2020-10-01 06:10:59'),
(4, '2020-09-29 13:03:06', 2, '2020-10-02 01:12:39'),
(1, '2020-08-07 19:40:45', 3, '2020-11-14 21:06:48'),
(2, '2020-09-29 08:49:12', 2, '2020-10-31 02:56:26'),
(6, '2020-09-21 03:55:03', 1, '2020-12-17 14:04:30'),
(103, '2021-05-08 18:09:00', 1, '2021-05-16 02:25:52'),
(2, '2020-09-06 19:55:18', 4, '2020-12-27 04:14:15'),
(103, '2021-05-15 18:09:00', 1, '2021-05-20 02:25:52'),
(1, '2020-09-03 11:38:54', 4, '2020-12-14 22:36:06'),
(5, '2020-01-01 11:11:14', 1, '2021-06-25 15:53:14');

-- --------------------------------------------------------

--
-- Structure de la table `motif`
--

DROP TABLE IF EXISTS `motif`;
CREATE TABLE IF NOT EXISTS `motif` (
  `IDMOTIF` int(11) NOT NULL AUTO_INCREMENT,
  `LIBELLE` varchar(128) DEFAULT NULL,
  PRIMARY KEY (`IDMOTIF`)
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `motif`
--

INSERT INTO `motif` (`IDMOTIF`, `LIBELLE`) VALUES
(1, 'vacances'),
(2, 'maladie'),
(3, 'motif familial'),
(4, 'congé parental');

-- --------------------------------------------------------

--
-- Structure de la table `personnel`
--

DROP TABLE IF EXISTS `personnel`;
CREATE TABLE IF NOT EXISTS `personnel` (
  `IDPERSONNEL` int(11) NOT NULL AUTO_INCREMENT,
  `IDSERVICE` int(11) NOT NULL,
  `NOM` varchar(50) DEFAULT NULL,
  `PRENOM` varchar(50) DEFAULT NULL,
  `TEL` varchar(15) DEFAULT NULL,
  `MAIL` varchar(128) DEFAULT NULL,
  PRIMARY KEY (`IDPERSONNEL`),
  KEY `I_FK_PERSONNEL_SERVICE` (`IDSERVICE`)
) ENGINE=MyISAM AUTO_INCREMENT=105 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `personnel`
--

INSERT INTO `personnel` (`IDPERSONNEL`, `IDSERVICE`, `NOM`, `PRENOM`, `TEL`, `MAIL`) VALUES
(103, 2, 'Valien', 'Make', '06 25 56 85 20', 'omar.dz@malaf.com'),
(104, 2, 'Michel', 'Johan', '02 25 65 85 12', 'sadpepe@gmail.com'),
(9, 1, 'Goodwin', 'Leah', '07 88 64 42 21', 'vulputate.dui@fringillaporttitor.com'),
(8, 2, 'Vaughan', 'Amo', '01 24 00 07 45', 'dapibus.ligula@Aliquamerat.edu'),
(7, 1, 'Tran', 'Ruth', '04 82 57 81 25', 'turpis.Aliquam.adipiscing@odioa.org'),
(1, 2, 'Pitts', 'Robert', '09 36 48 55 12', 'ornare@Phaselluselitpede.com'),
(2, 3, 'Patton', 'Damian', '09 94 18 87 09', 'erat@sedsemegestas.org'),
(3, 3, 'Mcbride', 'Darryl', '04 22 76 80 51', 'fermentum.convallis@enimMauris.edu'),
(4, 2, 'Koch', 'Ino', '03 18 89 22 39', 'amet.consectetuer.adipiscing@anequeNullam.ca'),
(5, 1, 'Gillespiet', 'Rashad', '06 50 15 90 74', 'sed.pede@pellentesque.com'),
(6, 2, 'Heath', 'Sage', '03 55 25 15 52', 'montes.nascetur.ridiculus@tortordictumeu.ca');

-- --------------------------------------------------------

--
-- Structure de la table `responsable`
--

DROP TABLE IF EXISTS `responsable`;
CREATE TABLE IF NOT EXISTS `responsable` (
  `login` varchar(64) NOT NULL,
  `pwd` varchar(64) NOT NULL,
  PRIMARY KEY (`login`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `responsable`
--

INSERT INTO `responsable` (`login`, `pwd`) VALUES
('user', SHA2('Rh6qDynA5hDCvs', 256);

-- --------------------------------------------------------

--
-- Structure de la table `service`
--

DROP TABLE IF EXISTS `service`;
CREATE TABLE IF NOT EXISTS `service` (
  `IDSERVICE` int(11) NOT NULL AUTO_INCREMENT,
  `NOM` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`IDSERVICE`)
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `service`
--

INSERT INTO `service` (`IDSERVICE`, `NOM`) VALUES
(1, 'administratif'),
(2, 'médiation culturelle'),
(3, 'prêt');
COMMIT;

