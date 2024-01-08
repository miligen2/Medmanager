-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : lun. 08 jan. 2024 à 13:42
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
-- Base de données : `medmanager3`
--

-- --------------------------------------------------------

--
-- Structure de la table `allergies`
--

DROP TABLE IF EXISTS `allergies`;
CREATE TABLE IF NOT EXISTS `allergies` (
  `id_allergie` int NOT NULL AUTO_INCREMENT,
  `nom` varchar(50) NOT NULL,
  PRIMARY KEY (`id_allergie`)
) ENGINE=InnoDB AUTO_INCREMENT=61 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `allergies`
--

INSERT INTO `allergies` (`id_allergie`, `nom`) VALUES
(1, 'Rhume des foins'),
(2, 'Allergie aux arachides'),
(3, 'Allergie au pollen'),
(4, 'Allergie aux acariens'),
(5, 'Allergie à la pénicilline'),
(6, 'Allergie à la sulfaméthoxazole'),
(7, 'Allergie à l\'aspirine'),
(8, 'Allergie à l\'ibuprofène'),
(9, 'Allergie à la morphine'),
(10, 'Allergie à la codéine'),
(11, 'Allergie au paracétamol'),
(12, 'Allergie à l\'amoxicilline'),
(13, 'Allergie à la ciprofloxacine'),
(14, 'Allergie à l\'insuline'),
(15, 'Allergie au naproxène'),
(16, 'Allergie à l\'ibuprofène'),
(17, 'Allergie à la metformine'),
(18, 'Allergie à la warfarine'),
(19, 'Allergie à la simvastatine'),
(20, 'Allergie à l\'atorvastatine'),
(21, 'Allergie à la fluoxétine'),
(22, 'Allergie au diazépam'),
(23, 'Allergie au sertraline'),
(24, 'Allergie à la citalopram'),
(25, 'Allergie à la poussière de maison'),
(26, 'Allergie à l\'herbe à chat'),
(27, 'Allergie aux poils de chien'),
(28, 'Allergie au pollen d\'arbre'),
(29, 'Allergie aux moisissures'),
(30, 'Allergie aux punaises de lit'),
(31, 'Allergie aux fruits rouges'),
(32, 'Allergie aux fruits tropicaux'),
(33, 'Allergie aux crustacés'),
(34, 'Allergie aux arachides'),
(35, 'Allergie aux pistaches'),
(36, 'Allergie aux noix'),
(37, 'Allergie aux mollusques'),
(38, 'Allergie à la fumée de cigarette'),
(39, 'Allergie aux piqûres d\'abeilles'),
(40, 'Allergie au nickel'),
(41, 'Allergie aux médicaments contre le rhume'),
(42, 'Allergie aux colorants alimentaires'),
(43, 'Allergie au gluten'),
(44, 'Allergie au soja');

-- --------------------------------------------------------

--
-- Structure de la table `antecedent`
--

DROP TABLE IF EXISTS `antecedent`;
CREATE TABLE IF NOT EXISTS `antecedent` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nom` varchar(50) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `antecedent`
--

INSERT INTO `antecedent` (`id`, `nom`) VALUES
(1, 'Hypertension artérielle'),
(2, 'Diabète de type 2'),
(3, 'Maladie coronarienne'),
(4, 'Antécédents d\'accident vasculaire cérébral'),
(5, 'Cancer'),
(6, 'Maladie pulmonaire obstructive chronique (MPOC)'),
(7, 'Maladie rénale chronique'),
(8, 'Troubles de la coagulation sanguine'),
(9, 'Troubles thyroïdiens'),
(10, 'Maladie hépatique chronique'),
(11, 'Antécédents de dépression'),
(12, 'Trouble bipolaire'),
(13, 'Trouble anxieux'),
(14, 'Trouble du spectre de l\'autisme (TSA)'),
(15, 'Maladie d\'Alzheimer'),
(16, 'Arthrite rhumatoïde'),
(17, 'Maladie inflammatoire de l\'intestin'),
(18, 'Allergie alimentaire sévère'),
(19, 'Asthme'),
(20, 'Trouble de la coagulation sanguine héréditaire');

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
  `id_allergie` int NOT NULL,
  `id_patient` int NOT NULL,
  PRIMARY KEY (`id_allergie`,`id_patient`),
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
  `id_allergie` int NOT NULL,
  `id_medicament_incompatible` int NOT NULL,
  PRIMARY KEY (`id`,`id_medicament`,`id_allergie`,`id_medicament_incompatible`),
  KEY `incompatible_medicament0_FK` (`id_medicament`),
  KEY `incompatible_allergies1_FK` (`id_allergie`),
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
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `medicament`
--

INSERT INTO `medicament` (`id`, `nom`, `contre_indiction`) VALUES
(1, 'Paracétamol', 'Hypersensibilité au paracétamol'),
(2, 'Ibuprofène', 'Antécédents d ulcère gastroduodénal'),
(3, 'Amoxicilline', 'Allergie aux pénicillines'),
(4, 'Lévothyroxine', 'Thyrotoxicose non traitée'),
(5, 'Atorvastatine', 'Grossesse et allaitement'),
(6, 'Omeprazole', 'Insuffisance hépatique sévère'),
(7, 'Metformine', 'Insuffisance rénale'),
(8, 'Sertraline', 'Utilisation concomitante d inhibiteurs de la MAO'),
(9, 'Ciprofloxacine', 'Myasthénie grave'),
(10, 'Amlodipine', 'Hypotension sévère'),
(11, 'Warfarine', 'Risque élevé de saignement'),
(12, 'Fluoxetine', 'Syndrome sérotoninergique'),
(13, 'Diazepam', 'Glaucome à angle fermé'),
(14, 'Morphine', 'Insuffisance respiratoire sévère'),
(15, 'Citalopram', 'Allongement de l intervalle QT'),
(16, 'Ranitidine', 'Insuffisance rénale sévère'),
(17, 'Hydrochlorothiazide', 'Allergie aux sulfamides'),
(18, 'Clopidogrel', 'Troubles hémorragiques'),
(19, 'Allopurinol', 'Réaction cutanée sévère'),
(20, 'Furosemide', 'Déshydratation sévère');

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
  `id_patient` int NOT NULL AUTO_INCREMENT,
  `nom` varchar(50) NOT NULL,
  `prenom` varchar(50) NOT NULL,
  `sexe` char(5) NOT NULL,
  PRIMARY KEY (`id_patient`)
) ENGINE=InnoDB AUTO_INCREMENT=35 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `patient`
--

INSERT INTO `patient` (`id_patient`, `nom`, `prenom`, `sexe`) VALUES
(1, 'Doe', 'John', 'Homme'),
(2, 'Smith', 'Jane', 'Femme'),
(3, 'Johnson', 'Robert', 'Homme'),
(4, 'Williams', 'Emily', 'Femme'),
(5, 'Anderson', 'Alice', 'Femme'),
(6, 'Miller', 'Michael', 'Homme'),
(7, 'Brown', 'Olivia', 'Femme'),
(8, 'Davis', 'Daniel', 'Homme'),
(9, 'Garcia', 'Sophia', 'Femme'),
(10, 'Hernandez', 'William', 'Homme'),
(11, 'Smith', 'Ava', 'Femme'),
(12, 'Martinez', 'Matthew', 'Homme'),
(13, 'Johnson', 'Ella', 'Femme'),
(14, 'Thomas', 'Alexander', 'Homme'),
(15, 'White', 'Grace', 'Femme'),
(16, 'Jones', 'Joseph', 'Homme'),
(17, 'Hall', 'Mia', 'Femme'),
(18, 'Taylor', 'Andrew', 'Homme'),
(19, 'Clark', 'Chloe', 'Femme'),
(20, 'Walker', 'David', 'Homme'),
(21, 'Hill', 'Sofia', 'Femme'),
(22, 'Lee', 'Ethan', 'Homme'),
(23, 'Green', 'Emma', 'Femme'),
(24, 'Baker', 'Christopher', 'Homme'),
(25, 'Cooper', 'Lily', 'Femme'),
(26, 'Wright', 'Nicholas', 'Homme'),
(27, 'Wood', 'Madison', 'Femme'),
(28, 'Fisher', 'Jacob', 'Homme'),
(29, 'Evans', 'Abigail', 'Femme'),
(30, 'Barnes', 'Noah', 'Homme'),
(31, 'Turner', 'Isabella', 'Femme'),
(32, 'Mitchell', 'Oliver', 'Homme'),
(33, 'Young', 'Avery', 'Femme'),
(34, 'Harrison', 'Elijah', 'Homme');

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `a_eu`
--
ALTER TABLE `a_eu`
  ADD CONSTRAINT `a_eu_Antecedent_FK` FOREIGN KEY (`id`) REFERENCES `antecedent` (`id`),
  ADD CONSTRAINT `a_eu_patient0_FK` FOREIGN KEY (`id_patient`) REFERENCES `patient` (`id_patient`);

--
-- Contraintes pour la table `est`
--
ALTER TABLE `est`
  ADD CONSTRAINT `est_allergies_FK` FOREIGN KEY (`id_allergie`) REFERENCES `allergies` (`id_allergie`),
  ADD CONSTRAINT `est_patient0_FK` FOREIGN KEY (`id_patient`) REFERENCES `patient` (`id_patient`);

--
-- Contraintes pour la table `incompatible`
--
ALTER TABLE `incompatible`
  ADD CONSTRAINT `incompatible_allergies1_FK` FOREIGN KEY (`id_allergie`) REFERENCES `allergies` (`id_allergie`),
  ADD CONSTRAINT `incompatible_Antecedent_FK` FOREIGN KEY (`id`) REFERENCES `antecedent` (`id`),
  ADD CONSTRAINT `incompatible_medicament0_FK` FOREIGN KEY (`id_medicament`) REFERENCES `medicament` (`id`),
  ADD CONSTRAINT `incompatible_medicament2_FK` FOREIGN KEY (`id_medicament_incompatible`) REFERENCES `medicament` (`id`);

--
-- Contraintes pour la table `ordonnance`
--
ALTER TABLE `ordonnance`
  ADD CONSTRAINT `ordonnance_Medecin_FK` FOREIGN KEY (`id_Medecin`) REFERENCES `medecin` (`id`),
  ADD CONSTRAINT `ordonnance_medicament1_FK` FOREIGN KEY (`id_medicament`) REFERENCES `medicament` (`id`),
  ADD CONSTRAINT `ordonnance_patient0_FK` FOREIGN KEY (`id_patient`) REFERENCES `patient` (`id_patient`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
