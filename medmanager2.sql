-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1
-- Généré le : lun. 15 jan. 2024 à 20:07
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
(35, 'Allergie aux pistaches'),
(36, 'Allergie aux noix'),
(37, 'Allergie aux mollusques'),
(38, 'Allergie à la fumée de cigarette'),
(39, 'Allergie aux piqûres d\'abeilles'),
(40, 'Allergie au nickel'),
(41, 'Allergie aux médicaments contre le rhume'),
(42, 'Allergie aux colorants alimentaires'),
(43, 'Allergie au gluten'),
(44, 'Allergie au soja'),
(45, 'Allergie au lait'),
(46, 'Allergie aux œufs'),
(47, 'Allergie au blé'),
(48, 'Allergie au maïs'),
(49, 'Allergie au poisson'),
(50, 'Allergie aux fruits à coque'),
(51, 'Allergie au céleri'),
(52, 'Allergie à la moutarde'),
(53, 'Allergie au sésame'),
(54, 'Allergie aux sulfites'),
(55, 'Allergie aux légumineuses'),
(56, 'Allergie au kiwi'),
(57, 'Allergie à l\'ananas'),
(58, 'Allergie à la banane'),
(59, 'Allergie à l\'avocat'),
(60, 'Allergie à la tomate'),
(61, 'Allergie au chocolat'),
(62, 'Allergie au café'),
(63, 'Allergie au thé'),
(64, 'Allergie au poivre'),
(65, 'Allergie à l\'insuline humaine'),
(66, 'Allergie au sulfate de morphine'),
(67, 'Allergie à l\'érythromycine'),
(68, 'Allergie à la tétracycline'),
(69, 'Allergie à la doxycycline'),
(70, 'Allergie à la streptomycine'),
(71, 'Allergie à la gentamicine'),
(72, 'Allergie à la vancomycine'),
(73, 'Allergie à l\'amoxicilline-clavulanate'),
(74, 'Allergie à la ciprofloxacine'),
(75, 'Allergie à la lévofloxacine'),
(76, 'Allergie à la clarithromycine'),
(77, 'Allergie à l\'azithromycine'),
(78, 'Allergie à la nitroglycérine'),
(79, 'Allergie à l\'amlodipine'),
(80, 'Allergie à la warfarine sodique'),
(81, 'Allergie à la digoxine'),
(82, 'Allergie à l\'atorvastatine calcique'),
(83, 'Allergie à la simvastatine sodique'),
(84, 'Allergie à l\'aspirine acétylsalicylique'),
(85, 'Allergie à l\'ibuprofène'),
(86, 'Allergie à l\'acétaminophène'),
(87, 'Allergie à la morphine sulfate'),
(88, 'Allergie à la codéine phosphate'),
(89, 'Allergie à la hydrocodone bitartrate'),
(90, 'Allergie à l\'oxycodone hydrochloride'),
(91, 'Allergie à la fentanyl'),
(92, 'Allergie à la lidocaïne'),
(93, 'Allergie à la procaïne'),
(94, 'Allergie à l\'insuline glargine'),
(95, 'Allergie à l\'insuline lispro'),
(96, 'Allergie à l\'insuline detemir'),
(97, 'Allergie à l\'insuline asparte'),
(98, 'Allergie à la metformine'),
(99, 'Allergie à la pioglitazone'),
(100, 'Allergie à la sitagliptine');

-- --------------------------------------------------------

--
-- Structure de la table `antecedent`
--

CREATE TABLE `antecedent` (
  `id_antecedent` int(11) NOT NULL,
  `nom` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `antecedent`
--

INSERT INTO `antecedent` (`id_antecedent`, `nom`) VALUES
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
(20, 'Trouble de la coagulation sanguine héréditaire'),
(21, 'Trouble de la coagulation sanguine acquise'),
(22, 'Insuffisance rénale chronique'),
(23, 'Diabète de type 1'),
(24, 'Hypercholestérolémie'),
(25, 'Anémie'),
(26, 'Polyarthrite rhumatoïde'),
(27, 'Maladie de Crohn'),
(28, 'Rectocolite hémorragique'),
(29, 'Trouble bipolaire'),
(30, 'Sclérose en plaques'),
(31, 'Hépatite chronique'),
(32, 'Maladie de Parkinson'),
(33, 'Psoriasis'),
(34, 'Endométriose'),
(35, 'Fibromyalgie'),
(36, 'Syndrome de l\'intestin irritable'),
(37, 'Glaucome'),
(38, 'Ostéoporose'),
(39, 'Trouble de la personnalité borderline'),
(40, 'Hémophilie'),
(41, 'Déficit en vitamine B12'),
(42, 'Cirrhose du foie'),
(43, 'Aplasie médullaire'),
(44, 'Maladie de Raynaud'),
(45, 'Syndrome d\'alcoolisme fœtal'),
(46, 'Hyperthyroïdie'),
(47, 'Colite ulcéreuse'),
(48, 'Lupus érythémateux disséminé'),
(49, 'Myasthénie grave'),
(50, 'Sclérose latérale amyotrophique');

-- --------------------------------------------------------

--
-- Structure de la table `a_eu`
--

CREATE TABLE `a_eu` (
  `id` int(11) NOT NULL,
  `id_patient` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `a_eu`
--

INSERT INTO `a_eu` (`id`, `id_patient`) VALUES
(1, 1),
(1, 29),
(19, 1),
(19, 35);

-- --------------------------------------------------------

--
-- Structure de la table `est`
--

CREATE TABLE `est` (
  `id_allergie` int(11) NOT NULL,
  `id_patient` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `est`
--

INSERT INTO `est` (`id_allergie`, `id_patient`) VALUES
(16, 8),
(24, 28);

-- --------------------------------------------------------

--
-- Structure de la table `incompatibles`
--

CREATE TABLE `incompatibles` (
  `id_a` int(11) NOT NULL,
  `id_med` int(11) NOT NULL,
  `id_al` int(11) NOT NULL,
  `id_med_Medicament` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `incompatibles`
--

INSERT INTO `incompatibles` (`id_a`, `id_med`, `id_al`, `id_med_Medicament`) VALUES
(1, 1, 5, 1),
(2, 2, 28, 2),
(3, 3, 5, 3),
(4, 4, 9, 4),
(5, 5, 41, 5),
(6, 6, 27, 6),
(7, 7, 17, 7),
(8, 8, 25, 8),
(9, 9, 74, 9),
(10, 10, 79, 10),
(11, 11, 11, 15),
(11, 11, 32, 11),
(12, 12, 12, 10),
(12, 12, 21, 12),
(13, 13, 13, 13),
(13, 13, 22, 13),
(14, 14, 14, 20),
(14, 14, 88, 14),
(15, 15, 15, 2),
(15, 15, 26, 15),
(16, 16, 6, 16),
(16, 16, 16, 1),
(17, 17, 17, 2),
(17, 17, 54, 17),
(18, 18, 11, 18),
(18, 18, 18, 3),
(19, 19, 19, 4),
(19, 19, 43, 19),
(20, 20, 20, 5),
(20, 20, 50, 20),
(21, 21, 41, 21),
(22, 22, 84, 22),
(23, 23, 23, 23),
(24, 24, 13, 24),
(25, 25, 25, 25),
(26, 26, 26, 26),
(27, 27, 27, 27),
(28, 28, 2, 28),
(29, 29, 9, 29),
(30, 30, 1, 30),
(31, 31, 10, 31),
(32, 32, 11, 32),
(33, 33, 33, 33),
(34, 34, 4, 34),
(35, 35, 15, 35),
(36, 36, 36, 36),
(37, 37, 8, 37),
(38, 38, 38, 38),
(39, 39, 39, 39),
(40, 40, 40, 40),
(41, 41, 37, 41),
(42, 42, 10, 42),
(43, 43, 82, 43),
(44, 44, 63, 44),
(45, 45, 80, 45),
(46, 46, 69, 46),
(47, 47, 29, 47),
(48, 48, 14, 48),
(49, 49, 77, 49),
(50, 50, 16, 50);

-- --------------------------------------------------------

--
-- Structure de la table `medecin`
--

CREATE TABLE `medecin` (
  `id` int(11) NOT NULL,
  `nom` varchar(50) NOT NULL,
  `prenom` varchar(50) NOT NULL,
  `login` varchar(50) NOT NULL,
  `password` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `medecin`
--

INSERT INTO `medecin` (`id`, `nom`, `prenom`, `login`, `password`) VALUES
(1, 'macaire', 'angelo', 'a', 'a'),
(2, 'b', 'b', 'b', 'b');

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
(20, 'Furosemide', 'Déshydratation sévère'),
(21, 'Aspirine', 'Risque accru d\'ulcère gastrique'),
(22, 'Simvastatine', 'Rhabdomyolyse'),
(23, 'Fluoxétine', 'Syndrome sérotoninergique'),
(24, 'Diazépam', 'Glaucome à angle fermé'),
(25, 'Sertraline', 'Utilisation concomitante d\'inhibiteurs de la MAO'),
(26, 'Citalopram', 'Allongement de l\'intervalle QT'),
(27, 'Naproxène', 'Risque accru d\'ulcère gastrique'),
(28, 'Ibuprofène', 'Risque accru d\'ulcère gastrique'),
(29, 'Métronidazole', 'Réaction de type disulfirame avec l\'alcool'),
(30, 'Chloramphénicol', 'Risque de syndrome du bébé gris'),
(31, 'Codeine', 'Risque de dépression respiratoire sévère'),
(32, 'Warfarine', 'Risque élevé de saignement'),
(33, 'Méthotrexate', 'Toxicité hépatique'),
(34, 'Acétaminophène', 'Toxicité hépatique'),
(35, 'Amiodarone', 'Toxicité pulmonaire'),
(36, 'Thalidomide', 'Risque tératogène'),
(37, 'Carbamazépine', 'Risque de syndrome de Stevens-Johnson'),
(38, 'Phénytoïne', 'Hyperplasie gingivale'),
(39, 'Valproate', 'Risque de malformations congénitales'),
(40, 'Isotrétinoïne', 'Risque de malformations congénitales'),
(41, 'Phénylbutazone', 'Risque d\'ulcères gastro-intestinaux'),
(42, 'Doxycycline', 'Risque de photosensibilité'),
(43, 'Lithium', 'Toxicité rénale'),
(44, 'Digoxine', 'Risque de toxicité digoxique'),
(45, 'Méthylprednisolone', 'Risque accru d\'infections'),
(46, 'Risperidone', 'Risque de syndrome malin des neuroleptiques'),
(47, 'Céfotaxime', 'Réaction de type disulfirame avec l\'alcool'),
(48, 'Fentanyl', 'Dépression respiratoire sévère'),
(49, 'Levofloxacin', 'Risque de tendinite et de rupture tendineuse'),
(50, 'Oxycodone', 'Dépression respiratoire sévère'),
(51, 'Test', 'Antécédents d\'accident vasculaire cérébral'),
(52, '2test', 'Anémie'),
(53, 'test', 'Anémie');

-- --------------------------------------------------------

--
-- Structure de la table `ordonnance`
--

CREATE TABLE `ordonnance` (
  `id_o` int(11) NOT NULL,
  `posologie` varchar(50) NOT NULL,
  `duree_traitement` int(11) NOT NULL,
  `instruction_specifique` varchar(50) NOT NULL,
  `id_medecin` int(11) NOT NULL,
  `id_patient` int(11) NOT NULL,
  `id_medicament` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `ordonnance`
--

INSERT INTO `ordonnance` (`id_o`, `posologie`, `duree_traitement`, `instruction_specifique`, `id_medecin`, `id_patient`, `id_medicament`) VALUES
(28, 'a', 1, 'a', 1, 7, 3),
(31, 'a', 2, 'a', 1, 24, 1),
(33, 'a', 2, 'a', 1, 24, 1),
(35, 'a', 2, 'a', 1, 7, 3),
(37, 'r', 1, 'r', 1, 25, 3),
(39, 'r', 1, 'r', 1, 7, 9),
(41, 'a', 1, 'a', 1, 5, 3),
(43, 'a', 1, 'a', 1, 5, 3),
(45, 'a', 1, 'a', 1, 30, 28),
(47, 'a', 1, 'a', 1, 30, 5),
(49, 'r', 1, 'r', 1, 19, 4),
(51, 'a', 1, 'a', 1, 24, 6),
(53, 'r', 1, 'feazraezrze', 1, 14, 6),
(55, 'j', 0, 'ntm', 1, 36, 24),
(57, 'r', 1, 'r', 1, 30, 7);

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
(36, 'Macaire', 'Angelo', 'Homme', 699931346),
(37, 'test', 'test', 'test', 0);

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
  ADD PRIMARY KEY (`id_antecedent`);

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
-- Index pour la table `incompatibles`
--
ALTER TABLE `incompatibles`
  ADD PRIMARY KEY (`id_a`,`id_med`,`id_al`,`id_med_Medicament`),
  ADD KEY `incompatible_Medicament0_FK` (`id_med`),
  ADD KEY `incompatible_Allergie1_FK` (`id_al`),
  ADD KEY `incompatible_Medicament2_FK` (`id_med_Medicament`);

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
  ADD PRIMARY KEY (`id_o`),
  ADD KEY `ordonnance_Medecin_FK` (`id_medecin`),
  ADD KEY `ordonnance_Patient0_FK` (`id_patient`),
  ADD KEY `ordonnance_Medicament1_FK` (`id_medicament`);

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
  MODIFY `id_allergie` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=101;

--
-- AUTO_INCREMENT pour la table `antecedent`
--
ALTER TABLE `antecedent`
  MODIFY `id_antecedent` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=51;

--
-- AUTO_INCREMENT pour la table `medecin`
--
ALTER TABLE `medecin`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT pour la table `medicament`
--
ALTER TABLE `medicament`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=54;

--
-- AUTO_INCREMENT pour la table `ordonnance`
--
ALTER TABLE `ordonnance`
  MODIFY `id_o` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=59;

--
-- AUTO_INCREMENT pour la table `patient`
--
ALTER TABLE `patient`
  MODIFY `id_patient` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=38;

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `a_eu`
--
ALTER TABLE `a_eu`
  ADD CONSTRAINT `a_eu_Antecedent_FK` FOREIGN KEY (`id`) REFERENCES `antecedent` (`id_antecedent`),
  ADD CONSTRAINT `a_eu_patient0_FK` FOREIGN KEY (`id_patient`) REFERENCES `patient` (`id_patient`);

--
-- Contraintes pour la table `est`
--
ALTER TABLE `est`
  ADD CONSTRAINT `est_allergies_FK` FOREIGN KEY (`id_allergie`) REFERENCES `allergies` (`id_allergie`),
  ADD CONSTRAINT `est_patient0_FK` FOREIGN KEY (`id_patient`) REFERENCES `patient` (`id_patient`);

--
-- Contraintes pour la table `incompatibles`
--
ALTER TABLE `incompatibles`
  ADD CONSTRAINT `incompatible_Allergie1_FK` FOREIGN KEY (`id_al`) REFERENCES `allergies` (`id_allergie`),
  ADD CONSTRAINT `incompatible_Antecedent_FK` FOREIGN KEY (`id_a`) REFERENCES `antecedent` (`id_antecedent`),
  ADD CONSTRAINT `incompatible_Medicament0_FK` FOREIGN KEY (`id_med`) REFERENCES `medicament` (`id`),
  ADD CONSTRAINT `incompatible_Medicament2_FK` FOREIGN KEY (`id_med_Medicament`) REFERENCES `medicament` (`id`);

--
-- Contraintes pour la table `ordonnance`
--
ALTER TABLE `ordonnance`
  ADD CONSTRAINT `ordonnance_Medecin_FK` FOREIGN KEY (`id_medecin`) REFERENCES `medecin` (`id`),
  ADD CONSTRAINT `ordonnance_Medicament1_FK` FOREIGN KEY (`id_medicament`) REFERENCES `medicament` (`id`),
  ADD CONSTRAINT `ordonnance_Patient0_FK` FOREIGN KEY (`id_patient`) REFERENCES `patient` (`id_patient`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
