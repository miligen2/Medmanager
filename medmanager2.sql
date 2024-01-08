-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : lun. 08 jan. 2024 à 10:40
-- Version du serveur : 8.0.31
-- Version de PHP : 8.0.26

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `medmanager2`
--

-- --------------------------------------------------------

--
-- Structure de la table `allergies`
--

DROP TABLE IF EXISTS `allergies`;
CREATE TABLE IF NOT EXISTS `allergies` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nom` varchar(50) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Structure de la table `antecedent`
--

DROP TABLE IF EXISTS `antecedent`;
CREATE TABLE IF NOT EXISTS `antecedent` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nom` varchar(50) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Structure de la table `a_eu`
--

DROP TABLE IF EXISTS `a_eu`;
CREATE TABLE IF NOT EXISTS `a_eu` (
  `id` int NOT NULL,
  `id_patient` int NOT NULL,
  PRIMARY KEY (`id`,`id_patient`),
  KEY `a_eu_patient0_FK` (`id_patient`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Structure de la table `est`
--

DROP TABLE IF EXISTS `est`;
CREATE TABLE IF NOT EXISTS `est` (
  `id` int NOT NULL,
  `id_patient` int NOT NULL,
  PRIMARY KEY (`id`,`id_patient`),
  KEY `est_patient0_FK` (`id_patient`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Structure de la table `incompatible`
--

DROP TABLE IF EXISTS `incompatible`;
CREATE TABLE IF NOT EXISTS `incompatible` (
  `id` int NOT NULL,
  `id_medicament` int NOT NULL,
  `id_allergies` int NOT NULL,
  `id_medicament_incompatible` int NOT NULL,
  PRIMARY KEY (`id`,`id_medicament`,`id_allergies`,`id_medicament_incompatible`),
  KEY `incompatible_medicament0_FK` (`id_medicament`),
  KEY `incompatible_allergies1_FK` (`id_allergies`),
  KEY `incompatible_medicament2_FK` (`id_medicament_incompatible`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Structure de la table `medecin`
--

DROP TABLE IF EXISTS `medecin`;
CREATE TABLE IF NOT EXISTS `medecin` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nom` varchar(50) NOT NULL,
  `prenom` varchar(50) NOT NULL,
  `date_naissance` date NOT NULL,
  `login` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Structure de la table `medicament`
--

DROP TABLE IF EXISTS `medicament`;
CREATE TABLE IF NOT EXISTS `medicament` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nom` varchar(50) NOT NULL,
  `contre_indiction` varchar(50) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Structure de la table `ordonnance`
--

DROP TABLE IF EXISTS `ordonnance`;
CREATE TABLE IF NOT EXISTS `ordonnance` (
  `id` int NOT NULL AUTO_INCREMENT,
  `posologie` varchar(50) NOT NULL,
  `duree_traitement` int NOT NULL,
  `instruction_specifique` varchar(50) NOT NULL,
  `id_Medecin` int NOT NULL,
  `id_patient` int NOT NULL,
  `id_medicament` int NOT NULL,
  PRIMARY KEY (`id`),
  KEY `ordonnance_Medecin_FK` (`id_Medecin`),
  KEY `ordonnance_patient0_FK` (`id_patient`),
  KEY `ordonnance_medicament1_FK` (`id_medicament`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Structure de la table `patient`
--

DROP TABLE IF EXISTS `patient`;
CREATE TABLE IF NOT EXISTS `patient` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nom` varchar(50) NOT NULL,
  `prenom` varchar(50) NOT NULL,
  `sexe` tinyint(1) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `a_eu`
--
ALTER TABLE `a_eu`
  ADD CONSTRAINT `a_eu_Antecedent_FK` FOREIGN KEY (`id`) REFERENCES `antecedent` (`id`),
  ADD CONSTRAINT `a_eu_patient0_FK` FOREIGN KEY (`id_patient`) REFERENCES `patient` (`id`);

--
-- Contraintes pour la table `est`
--
ALTER TABLE `est`
  ADD CONSTRAINT `est_allergies_FK` FOREIGN KEY (`id`) REFERENCES `allergies` (`id`),
  ADD CONSTRAINT `est_patient0_FK` FOREIGN KEY (`id_patient`) REFERENCES `patient` (`id`);

--
-- Contraintes pour la table `incompatible`
--
ALTER TABLE `incompatible`
  ADD CONSTRAINT `incompatible_allergies1_FK` FOREIGN KEY (`id_allergies`) REFERENCES `allergies` (`id`),
  ADD CONSTRAINT `incompatible_Antecedent_FK` FOREIGN KEY (`id`) REFERENCES `antecedent` (`id`),
  ADD CONSTRAINT `incompatible_medicament0_FK` FOREIGN KEY (`id_medicament`) REFERENCES `medicament` (`id`),
  ADD CONSTRAINT `incompatible_medicament2_FK` FOREIGN KEY (`id_medicament_incompatible`) REFERENCES `medicament` (`id`);

--
-- Contraintes pour la table `ordonnance`
--
ALTER TABLE `ordonnance`
  ADD CONSTRAINT `ordonnance_Medecin_FK` FOREIGN KEY (`id_Medecin`) REFERENCES `medecin` (`id`),
  ADD CONSTRAINT `ordonnance_medicament1_FK` FOREIGN KEY (`id_medicament`) REFERENCES `medicament` (`id`),
  ADD CONSTRAINT `ordonnance_patient0_FK` FOREIGN KEY (`id_patient`) REFERENCES `patient` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
