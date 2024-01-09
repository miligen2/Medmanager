-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1
-- Généré le : mar. 09 jan. 2024 à 20:36
-- Version du serveur : 10.4.28-MariaDB
-- Version de PHP : 8.2.4

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

CREATE TABLE `allergies` (
  `id_allergie` int(11) NOT NULL,
  `nom` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

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

CREATE TABLE `antecedent` (
  `id` int(11) NOT NULL,
  `nom` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

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

CREATE TABLE `a_eu` (
  `id` int(11) NOT NULL,
  `id_patient` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Structure de la table `est`
--

CREATE TABLE `est` (
  `id_allergie` int(11) NOT NULL,
  `id_patient` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Structure de la table `incompatible`
--

CREATE TABLE `incompatible` (
  `id` int(11) NOT NULL,
  `id_medicament` int(11) NOT NULL,
  `id_allergie` int(11) NOT NULL,
  `id_medicament_incompatible` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Structure de la table `medecin`
--

CREATE TABLE `medecin` (
  `id` int(11) NOT NULL,
  `nom` varchar(50) NOT NULL,
  `prenom` varchar(50) NOT NULL,
  `date_naissance` date NOT NULL,
  `login` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Structure de la table `medicament`
--

CREATE TABLE `medicament` (
  `id` int(11) NOT NULL,
  `nom` varchar(50) NOT NULL,
  `contre_indiction` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

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

CREATE TABLE `ordonnance` (
  `id` int(11) NOT NULL,
  `posologie` varchar(50) NOT NULL,
  `duree_traitement` int(11) NOT NULL,
  `instruction_specifique` varchar(50) NOT NULL,
  `id_Medecin` int(11) NOT NULL,
  `id_patient` int(11) NOT NULL,
  `id_medicament` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Structure de la table `patient`
--

CREATE TABLE `patient` (
  `id_patient` int(11) NOT NULL,
  `nom` varchar(50) NOT NULL,
  `prenom` varchar(50) NOT NULL,
  `sexe` char(5) NOT NULL,
  `numero` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `patient`
--

INSERT INTO `patient` (`id_patient`, `nom`, `prenom`, `sexe`, `numero`) VALUES
(1, 'Doe', 'John', 'Homme', 0),
(2, 'Smith', 'Jane', 'Femme', 0),
(3, 'Johnson', 'Robert', 'Homme', 0),
(4, 'Williams', 'Emily', 'Femme', 0),
(5, 'Anderson', 'Alice', 'Femme', 0),
(6, 'Miller', 'Michael', 'Homme', 0),
(7, 'Brown', 'Olivia', 'Femme', 0),
(8, 'Davis', 'Daniel', 'Homme', 0),
(9, 'Garcia', 'Sophia', 'Femme', 0),
(10, 'Hernandez', 'William', 'Homme', 0),
(11, 'Smith', 'Ava', 'Femme', 0),
(12, 'Martinez', 'Matthew', 'Homme', 0),
(13, 'Johnson', 'Ella', 'Femme', 0),
(14, 'Thomas', 'Alexander', 'Homme', 0),
(15, 'White', 'Grace', 'Femme', 0),
(16, 'Jones', 'Joseph', 'Homme', 0),
(17, 'Hall', 'Mia', 'Femme', 0),
(18, 'Taylor', 'Andrew', 'Homme', 0),
(19, 'Clark', 'Chloe', 'Femme', 0),
(20, 'Walker', 'David', 'Homme', 0),
(21, 'Hill', 'Sofia', 'Femme', 0),
(22, 'Lee', 'Ethan', 'Homme', 0),
(23, 'Green', 'Emma', 'Femme', 0),
(24, 'Baker', 'Christopher', 'Homme', 0),
(25, 'Cooper', 'Lily', 'Femme', 0),
(26, 'Wright', 'Nicholas', 'Homme', 0),
(27, 'Wood', 'Madison', 'Femme', 0),
(28, 'Fisher', 'Jacob', 'Homme', 0),
(29, 'Evans', 'Abigail', 'Femme', 0),
(30, 'Barnes', 'Noah', 'Homme', 0),
(31, 'Turner', 'Isabella', 'Femme', 0),
(32, 'Mitchell', 'Oliver', 'Homme', 0),
(33, 'Young', 'Avery', 'Femme', 0),
(34, 'Harrison', 'Elijah', 'Homme', 0),
(35, 'Macaire', 'Angelo', 'Homme', 699931346),
(36, 'Macaire', 'Angelo', 'Homme', 699931346);

--
-- Index pour les tables déchargées
--

--
-- Index pour la table `allergies`
--
ALTER TABLE `allergies`
  ADD PRIMARY KEY (`id_allergie`);

--
-- Index pour la table `antecedent`
--
ALTER TABLE `antecedent`
  ADD PRIMARY KEY (`id`);

--
-- Index pour la table `a_eu`
--
ALTER TABLE `a_eu`
  ADD PRIMARY KEY (`id`,`id_patient`),
  ADD KEY `a_eu_patient0_FK` (`id_patient`);

--
-- Index pour la table `est`
--
ALTER TABLE `est`
  ADD PRIMARY KEY (`id_allergie`,`id_patient`),
  ADD KEY `est_patient0_FK` (`id_patient`);

--
-- Index pour la table `incompatible`
--
ALTER TABLE `incompatible`
  ADD PRIMARY KEY (`id`,`id_medicament`,`id_allergie`,`id_medicament_incompatible`),
  ADD KEY `incompatible_medicament0_FK` (`id_medicament`),
  ADD KEY `incompatible_allergies1_FK` (`id_allergie`),
  ADD KEY `incompatible_medicament2_FK` (`id_medicament_incompatible`);

--
-- Index pour la table `medecin`
--
ALTER TABLE `medecin`
  ADD PRIMARY KEY (`id`);

--
-- Index pour la table `medicament`
--
ALTER TABLE `medicament`
  ADD PRIMARY KEY (`id`);

--
-- Index pour la table `ordonnance`
--
ALTER TABLE `ordonnance`
  ADD PRIMARY KEY (`id`),
  ADD KEY `ordonnance_Medecin_FK` (`id_Medecin`),
  ADD KEY `ordonnance_patient0_FK` (`id_patient`),
  ADD KEY `ordonnance_medicament1_FK` (`id_medicament`);

--
-- Index pour la table `patient`
--
ALTER TABLE `patient`
  ADD PRIMARY KEY (`id_patient`);

--
-- AUTO_INCREMENT pour les tables déchargées
--

--
-- AUTO_INCREMENT pour la table `allergies`
--
ALTER TABLE `allergies`
  MODIFY `id_allergie` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=61;

--
-- AUTO_INCREMENT pour la table `antecedent`
--
ALTER TABLE `antecedent`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- AUTO_INCREMENT pour la table `medecin`
--
ALTER TABLE `medecin`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT pour la table `medicament`
--
ALTER TABLE `medicament`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- AUTO_INCREMENT pour la table `ordonnance`
--
ALTER TABLE `ordonnance`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT pour la table `patient`
--
ALTER TABLE `patient`
  MODIFY `id_patient` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=37;

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
  ADD CONSTRAINT `incompatible_Antecedent_FK` FOREIGN KEY (`id`) REFERENCES `antecedent` (`id`),
  ADD CONSTRAINT `incompatible_allergies1_FK` FOREIGN KEY (`id_allergie`) REFERENCES `allergies` (`id_allergie`),
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
