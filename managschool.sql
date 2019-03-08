-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Hôte : localhost:8889
-- Généré le :  ven. 08 mars 2019 à 15:27
-- Version du serveur :  5.7.25
-- Version de PHP :  7.3.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";

--
-- Base de données :  `managschool`
--

-- --------------------------------------------------------

--
-- Structure de la table `Classe`
--

CREATE TABLE `Classe` (
  `idclasse` int(11) NOT NULL,
  `Nom` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `Classe`
--

INSERT INTO `Classe` (`idclasse`, `Nom`) VALUES
(1, 'B1'),
(2, 'B2'),
(3, 'B3'),
(4, 'I4'),
(5, 'I5');

-- --------------------------------------------------------

--
-- Structure de la table `Etudiant`
--

CREATE TABLE `Etudiant` (
  `idetudiant` int(11) NOT NULL,
  `Nom` varchar(50) NOT NULL,
  `Prenom` varchar(50) NOT NULL,
  `DateNaiss` date NOT NULL,
  `Adresse` varchar(100) NOT NULL,
  `Mail` varchar(100) NOT NULL,
  `idclasse` int(11) NOT NULL,
  `idville` int(11) NOT NULL,
  `idstatut` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `Etudiant`
--

INSERT INTO `Etudiant` (`idetudiant`, `Nom`, `Prenom`, `DateNaiss`, `Adresse`, `Mail`, `idclasse`, `idville`, `idstatut`) VALUES
(1, 'Colombier', 'Paul', '1998-11-17', 'Rue des Apothicaires', 'paul.colombier@epsi.fr', 2, 184, 1),
(2, 'Cros', 'Alexandre', '1997-12-26', 'Rue des Apothicaires', 'alexandre.cros@epsi.fr', 2, 320, 1),
(3, 'Henry', 'Marine', '1991-08-07', 'Rue des Apothicaires', 'marine.henry@epsi.fr', 1, 231, 1),
(4, 'Maltan', 'Elisabeth', '1996-03-14', 'Rue des Apothicaires', 'elisabeth.maltan@epsi.fr', 1, 312, 2),
(5, 'Bernard', 'Philippe', '1992-05-24', 'Rue des Apothicaires', 'philippe.bernard@epsi.fr', 1, 5, 1),
(6, 'Huret', 'Christine', '1997-08-29', 'Rue des Apothicaires', 'christine.huret@epsi.fr', 1, 75, 1),
(7, 'Lauze', 'François', '1999-04-03', 'Rue des Apothicaires', 'francois.lauze@epsi.fr', 1, 43, 1),
(8, 'Bompard', 'Alfred', '1900-01-13', 'Rue des Apothicaires', 'alfred.bompard@epsi.fr', 1, 123, 2),
(9, 'Carrefour', 'Lisa', '1997-03-19', 'Rue des Apothicaires', 'lisa.carrefour@epsi.fr', 1, 301, 1),
(10, 'Medin', 'Corentin', '1999-01-29', 'Rue des Apothicaires', 'corentin.medin@epsi.fr', 1, 231, 1),
(11, 'Curtis', 'Jessie', '1995-03-07', 'Rue des Apothicaires', 'jessie.curtis@epsi.fr', 1, 98, 1),
(12, 'Ducan', 'Noelle', '1998-05-09', 'Rue des Apothicaires', 'noelle.ducan@epsi.fr', 1, 209, 1),
(13, 'Carrol', 'Angel', '1992-04-01', 'Rue des Apothicaires', 'angel.carrol@epsi.fr', 2, 141, 2),
(14, 'Murray', 'Catherine', '1995-07-03', 'Rue des Apothicaires', 'catherine.murray@epsi.fr', 2, 188, 1),
(15, 'Cruz', 'Ronald', '1996-06-05', 'Rue des Apothicaires', 'ronald.cruz@epsi.fr', 2, 134, 1),
(16, 'Boyd', 'Oscar', '1993-06-10', 'Rue des Apothicaires', 'oscar.boyd@epsi.fr', 2, 132, 1),
(17, 'Bowman', 'Armando', '1997-04-11', 'Rue des Apothicaires', 'armando.bowman@epsi.fr', 2, 184, 2),
(18, 'Hoffman', 'Roff', '1991-05-11', 'Rue des Apothicaires', 'roff.hoffman@epsi.fr', 2, 198, 1),
(19, 'Robinson', 'Sandro', '1999-03-10', 'Rue des Apothicaires', 'sandro.robinson@epsi.fr', 3, 121, 1),
(20, 'Ellis', 'Pauline', '1998-01-04', 'Rue des Apothicaires', 'pauline.ellis@epsi.fr', 3, 100, 1),
(21, 'Smith', 'Mabel', '1998-02-12', 'Rue des Apothicaires', 'mabel.smith@epsi.fr', 3, 184, 2),
(22, 'Mason', 'Austin', '1995-04-06', 'Rue des Apothicaires', 'austin.mason@epsi.fr', 3, 34, 1),
(23, 'Beck', 'Francis', '1997-03-01', 'Rue des Apothicaires', 'francis.beck@epsi.fr', 3, 48, 1),
(24, 'Evans', 'Collin', '1996-06-08', 'Rue des Apothicaires', 'collin.evans@epsi.fr', 3, 76, 1),
(25, 'Montgomery', 'Ray', '1995-03-12', 'Rue des Apothicaires', 'ray.montgomery@epsi.fr', 3, 65, 1),
(26, 'Labonte', 'Laurène', '1992-05-25', 'Rue des Apothicaires', 'laurene.labonte@epsi.fr', 3, 65, 2),
(27, 'Bertrand', 'Yohan', '1994-07-20', 'Rue des Apothicaires', 'yohan.bertrand@epsi.fr', 3, 232, 1),
(28, 'Vergas', 'Adrien', '1999-01-03', 'Rue des Apothicaires', 'adrien.vergas@epsi.fr', 3, 12, 1),
(29, 'Caisse', 'Florent', '1989-04-30', 'Rue des Apothicaires', 'florent.caisse@epsi.fr', 3, 66, 1),
(30, 'Pouliotte', 'Romain', '1991-10-24', 'Rue des Apothicaires', 'romain.pouliotte@epsi.fr', 3, 184, 1),
(31, 'Foucault', 'Claude', '1998-02-18', 'Rue des Apothicaires', 'claude.foucault@epsi.fr', 3, 184, 2),
(32, 'Patenaude', 'Vincent', '1998-02-18', 'Rue des Apothicaires', 'vincent.patenaude@epsi.fr', 3, 164, 2),
(33, 'Grant', 'Charlie', '1997-01-03', 'Rue des Apothicaires', 'charlie.grant@epsi.fr', 3, 184, 1),
(34, 'Audric', 'Benoit', '1995-08-23', 'Rue des Apothicaires', 'benoit.audric@epsi.fr', 4, 91, 1),
(35, 'Petrie', 'David', '1990-09-21', 'Rue des Apothicaires', 'david.petrie@epsi.fr', 4, 184, 1),
(36, 'Huppe', 'Kari', '1988-08-28', 'Rue des Apothicaires', 'kari.huppe@epsi.fr', 4, 182, 1),
(37, 'Aube', 'Royale', '1988-10-03', 'Rue des Apothicaires', 'royale.aube@epsi.fr', 4, 127, 2),
(38, 'Labrosse', 'Gilbert', '1997-06-27', 'Rue des Apothicaires', 'gilbert.labrosse@epsi.fr', 4, 38, 1),
(39, 'Leclerc', 'Eddy', '1995-04-22', 'Rue des Apothicaires', 'eddy.leclerc@epsi.fr', 4, 12, 1),
(40, 'Briard', 'Paul', '1996-11-28', 'Rue des Apothicaires', 'paul.briard@epsi.fr', 4, 232, 1),
(41, 'Grimard', 'Thierry', '1993-09-29', 'Rue des Apothicaires', 'thierry.grimard@epsi.fr', 4, 58, 2),
(42, 'Brousseau', 'Mirabelle', '1996-07-13', 'Rue des Apothicaires', 'mirabelle.brousseau@epsi.fr', 4, 230, 1),
(43, 'Royer', 'Nicolas', '1994-05-14', 'Rue des Apothicaires', 'nicolas.royer@epsi.fr', 4, 77, 1),
(44, 'Dubeau', 'Eleanor', '1994-06-30', 'Rue des Apothicaires', 'eleanor.dubeau@epsi.fr', 4, 184, 2),
(45, 'Lereau', 'Mathilde', '1992-09-07', 'Rue des Apothicaires', 'mathilde.lereau@epsi.fr', 5, 184, 1),
(46, 'Deschamps', 'Hugo', '1994-12-03', 'Rue des Apothicaires', 'hugo.deschamps@epsi.fr', 5, 141, 2),
(47, 'Mouet', 'Mathieu', '1993-12-23', 'Rue des Apothicaires', 'mathieu.mouet@epsi.fr', 5, 182, 1),
(48, 'Durand', 'Delphine', '1993-10-10', 'Rue des Apothicaires', 'delphine.durand@epsi.fr', 5, 213, 1),
(49, 'Gras', 'Luc', '1992-08-04', 'Rue des Apothicaires', 'luc.gras@epsi.fr', 5, 184, 2),
(50, 'Clavette', 'Quentin', '1992-09-04', 'Rue des Apothicaires', 'quentin.clavette@epsi.fr', 5, 23, 1),
(51, 'Bourgeau', 'Adrien', '1995-02-01', 'Rue des Apothicaires', 'adrien.bourgeau@epsi.fr', 5, 53, 1),
(52, 'Lafond', 'Antoine', '1994-04-28', 'Rue des Apothicaires', 'antoine.lafond@epsi.fr', 5, 72, 1),
(53, 'Couturier', 'Eric', '1989-09-02', 'Rue des Apothicaires', 'eric.antoine@epsi.fr', 5, 184, 1);

-- --------------------------------------------------------

--
-- Structure de la table `Statut`
--

CREATE TABLE `Statut` (
  `idstatut` int(11) NOT NULL,
  `nomstatut` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `Statut`
--

INSERT INTO `Statut` (`idstatut`, `nomstatut`) VALUES
(1, 'Developpement'),
(2, 'Reseau');

-- --------------------------------------------------------

--
-- Structure de la table `Ville`
--

CREATE TABLE `Ville` (
  `idville` int(11) NOT NULL,
  `Nomville` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `Ville`
--

INSERT INTO `Ville` (`idville`, `Nomville`) VALUES
(1, 'Abeilhan (34290)'),
(2, 'Adissan (34230)'),
(3, 'Agde (34300)'),
(4, 'Agel (34210)'),
(5, 'Agonès (34190)'),
(6, 'Aigne (34210)'),
(7, 'Aigues-Vives (34210)'),
(8, 'Alignan-du-Vent (34290)'),
(9, 'Aniane (34150)'),
(10, 'Arboras (34150)'),
(11, 'Argelliers (34380)'),
(12, 'Aspiran (34800)'),
(13, 'Assas (34820)'),
(14, 'Assignan (34360)'),
(15, 'Aumelas (34230)'),
(16, 'Aumes (34530)'),
(17, 'Autignac (34480)'),
(18, 'Avène (34260)'),
(19, 'Azillanet (34210)'),
(20, 'Babeau-Bouldoux (34360)'),
(21, 'Baillargues (34670)'),
(22, 'Balaruc-le-Vieux (34540)'),
(23, 'Balaruc-les-Bains (34540)'),
(24, 'Bassan (34290)'),
(25, 'Beaufort (34210)'),
(26, 'Beaulieu (34160)'),
(27, 'Bédarieux (34600)'),
(28, 'Bélarga (34230)'),
(29, 'Berlou (34360)'),
(30, 'Bessan (34550)'),
(31, 'Béziers (34500)'),
(32, 'Boisseron (34160)'),
(33, 'Boisset (34220)'),
(34, 'Boujan-sur-Libron (34760)'),
(35, 'Bouzigues (34140)'),
(36, 'Brenas (34650)'),
(37, 'Brignac (34800)'),
(38, 'Brissac (34190)'),
(39, 'Buzignargues (34160)'),
(40, 'Cabrerolles (34480)'),
(41, 'Cabrières (34800)'),
(42, 'Cambon-et-Salvergues (34330)'),
(43, 'Campagnan (34230)'),
(44, 'Campagne (34160)'),
(45, 'Camplong (34260)'),
(46, 'Candillargues (34130)'),
(47, 'Canet (34800)'),
(48, 'Capestang (34310)'),
(49, 'Carlencas-et-Levas (34600)'),
(50, 'Cassagnoles (34210)'),
(51, 'Castanet-le-Haut (34610)'),
(52, 'Castelnau-de-Guers (34120)'),
(53, 'Castelnau-le-Lez (34170)'),
(54, 'Castries (34160)'),
(55, 'Causse-de-la-Selle (34380)'),
(56, 'Causses-et-Veyran (34490)'),
(57, 'Caussiniojouls (34600)'),
(58, 'Caux (34720)'),
(59, 'Cazedarnes (34460)'),
(60, 'Cazevieille (34270)'),
(61, 'Cazilhac (34190)'),
(62, 'Cazouls-d\'Hérault (34120)'),
(63, 'Cazouls-lès-Béziers (34370)'),
(64, 'Cébazan (34360)'),
(65, 'Ceilhes-et-Rocozels (34260)'),
(66, 'Celles (34700)'),
(67, 'Cers (34420)'),
(68, 'Cessenon-sur-Orb (34460)'),
(69, 'Cesseras (34210)'),
(70, 'Ceyras (34800)'),
(71, 'Clapiers (34830)'),
(72, 'Claret (34270)'),
(73, 'Clermont-l\'Hérault (34800)'),
(74, 'Colombières-sur-Orb (34390)'),
(75, 'Colombiers (34440)'),
(76, 'Combaillaux (34980)'),
(77, 'Combes (34240)'),
(78, 'Corneilhan (34490)'),
(79, 'Coulobres (34290)'),
(80, 'Courniou (34220)'),
(81, 'Cournonsec (34660)'),
(82, 'Cournonterral (34660)'),
(83, 'Creissan (34370)'),
(84, 'Cruzy (34310)'),
(85, 'Dio-et-Valquières (34650)'),
(86, 'Espondeilhan (34290)'),
(87, 'Fabrègues (34690)'),
(88, 'Faugères (34600)'),
(89, 'Félines-Minervois (34210)'),
(90, 'Ferrals-les-Montagnes (34210)'),
(91, 'Ferrières-les-Verreries (34190)'),
(92, 'Ferrières-Poussarou (34360)'),
(93, 'Florensac (34510)'),
(94, 'Fontanès (34270)'),
(95, 'Fontès (34320)'),
(96, 'Fos (34320)'),
(97, 'Fouzilhon (34480)'),
(98, 'Fozières (34700)'),
(99, 'Fraisse-sur-Agout (34330)'),
(100, 'Frontignan (34110)'),
(101, 'Gabian (34320)'),
(102, 'Galargues (34160)'),
(103, 'Ganges (34190)'),
(104, 'Garrigues (34160)'),
(105, 'Gigean (34770)'),
(106, 'Gignac (34150)'),
(107, 'Gorniès (34190)'),
(108, 'Grabels (34790)'),
(109, 'Graissessac (34260)'),
(110, 'Guzargues (34820)'),
(111, 'Hérépian (34600)'),
(112, 'Jacou (34830)'),
(113, 'Joncels (34650)'),
(114, 'Jonquières (34725)'),
(115, 'Juvignac (34990)'),
(116, 'La Boissière (34150)'),
(117, 'La Caunette (34210)'),
(118, 'La Grande-Motte (34280)'),
(119, 'La Livinière (34210)'),
(120, 'La Salvetat-sur-Agout (34330)'),
(121, 'La Tour-sur-Orb (34260)'),
(122, 'La Vacquerie-et-Saint-Martin-de-Castries (34520)'),
(123, 'Lacoste (34800)'),
(124, 'Lagamas (34150)'),
(125, 'Lamalou-les-Bains (34240)'),
(126, 'Lansargues (34130)'),
(127, 'Laroque (34190)'),
(128, 'Lattes (34970)'),
(129, 'Laurens (34480)'),
(130, 'Lauret (34270)'),
(131, 'Lauroux (34700)'),
(132, 'Lavalette (34700)'),
(133, 'Lavérune (34880)'),
(134, 'Le Bosc (34700)'),
(135, 'Le Bousquet-d\'Orb (34260)'),
(136, 'Le Caylar (34520)'),
(137, 'Le Crès (34920)'),
(138, 'Le Cros (34520)'),
(139, 'Le Pouget (34230)'),
(140, 'Le Poujol-sur-Orb (34600)'),
(141, 'Le Pradal (34600)'),
(142, 'Le Puech (34700)'),
(143, 'Le Soulié (34330)'),
(144, 'Le Triadou (34270)'),
(145, 'Les Aires (34600)'),
(146, 'Les Matelles (34270)'),
(147, 'Les Plans (34700)'),
(148, 'Les Rives (34520)'),
(149, 'Lespignan (34710)'),
(150, 'Lézignan-la-Cèbe (34120)'),
(151, 'Liausson (34800)'),
(152, 'Lieuran-Cabrières (34800)'),
(153, 'Lieuran-lès-Béziers (34290)'),
(154, 'Lignan-sur-Orb (34490)'),
(155, 'Lodève (34700)'),
(156, 'Loupian (34140)'),
(157, 'Lunas (34650)'),
(158, 'Lunel (34400)'),
(159, 'Lunel-Viel (34400)'),
(160, 'Magalas (34480)'),
(161, 'Maraussan (34370)'),
(162, 'Margon (34320)'),
(163, 'Marseillan (34340)'),
(164, 'Marsillargues (34590)'),
(165, 'Mas-de-Londres (34380)'),
(166, 'Mauguio (34130)'),
(167, 'Maureilhan (34370)'),
(168, 'Mérifons (34800)'),
(169, 'Mèze (34140)'),
(170, 'Minerve (34210)'),
(171, 'Mireval (34110)'),
(172, 'Mons (34390)'),
(173, 'Montady (34310)'),
(174, 'Montagnac (34530)'),
(175, 'Montarnaud (34570)'),
(176, 'Montaud (34160)'),
(177, 'Montbazin (34560)'),
(178, 'Montblanc (34290)'),
(179, 'Montels (34310)'),
(180, 'Montesquieu (34320)'),
(181, 'Montferrier-sur-Lez (34980)'),
(182, 'Montouliers (34310)'),
(183, 'Montoulieu (34190)'),
(184, 'Montpellier (34000)'),
(185, 'Montpeyroux (34150)'),
(186, 'Moulès-et-Baucels (34190)'),
(187, 'Mourèze (34800)'),
(188, 'Mudaison (34130)'),
(189, 'Murles (34980)'),
(190, 'Murviel-lès-Béziers (34490)'),
(191, 'Murviel-lès-Montpellier (34570)'),
(192, 'Nébian (34800)'),
(193, 'Neffiès (34320)'),
(194, 'Nézignan-l\'Évêque (34120)'),
(195, 'Nissan-lez-Enserune (34440)'),
(196, 'Nizas (34320)'),
(197, 'Notre-Dame-de-Londres (34380)'),
(198, 'Octon (34800)'),
(199, 'Olargues (34390)'),
(200, 'Olmet-et-Villecun (34700)'),
(201, 'Olonzac (34210)'),
(202, 'Oupia (34210)'),
(203, 'Pailhès (34490)'),
(204, 'Palavas-les-Flots (34250)'),
(205, 'Pardailhan (34360)'),
(206, 'Paulhan (34230)'),
(207, 'Pégairolles-de-Buèges (34380)'),
(208, 'Pégairolles-de-l\'Escalette (34700)'),
(209, 'Péret (34800)'),
(210, 'Pérols (34470)'),
(211, 'Pézenas (34120)'),
(212, 'Pézènes-les-Mines (34600)'),
(213, 'Pierrerue (34360)'),
(214, 'Pignan (34570)'),
(215, 'Pinet (34850)'),
(216, 'Plaissan (34230)'),
(217, 'Poilhes (34310)'),
(218, 'Pomérols (34810)'),
(219, 'Popian (34230)'),
(220, 'Portiragnes (34420)'),
(221, 'Poujols (34700)'),
(222, 'Poussan (34560)'),
(223, 'Pouzolles (34480)'),
(224, 'Pouzols (34230)'),
(225, 'Prades-le-Lez (34730)'),
(226, 'Prades-sur-Vernazobre (34360)'),
(227, 'Prémian (34390)'),
(228, 'Puéchabon (34150)'),
(229, 'Puilacher (34230)'),
(230, 'Puimisson (34480)'),
(231, 'Puissalicon (34480)'),
(232, 'Puisserguier (34620)'),
(233, 'Quarante (34310)'),
(234, 'Restinclières (34160)'),
(235, 'Rieussec (34220)'),
(236, 'Riols (34220)'),
(237, 'Romiguières (34650)'),
(238, 'Roquebrun (34460)'),
(239, 'Roqueredonde (34650)'),
(240, 'Roquessels (34320)'),
(241, 'Rosis (34610)'),
(242, 'Rouet (34380)'),
(243, 'Roujan (34320)'),
(244, 'Saint-André-de-Buèges (34190)'),
(245, 'Saint-André-de-Sangonis (34725)'),
(246, 'Saint-Aunès (34130)'),
(247, 'Saint-Bauzille-de-la-Sylve (34230)'),
(248, 'Saint-Bauzille-de-Montmel (34160)'),
(249, 'Saint-Bauzille-de-Putois (34190)'),
(250, 'Saint-Brès (34670)'),
(251, 'Saint-Chinian (34360)'),
(252, 'Saint-Christol (34400)'),
(253, 'Saint-Clément-de-Rivière (34980)'),
(254, 'Saint-Drézéry (34160)'),
(255, 'Saint-Étienne-d\'Albagnan (34390)'),
(256, 'Saint-Étienne-de-Gourgas (34700)'),
(257, 'Saint-Étienne-Estréchoux (34260)'),
(258, 'Saint-Félix-de-l\'Héras (34520)'),
(259, 'Saint-Félix-de-Lodez (34725)'),
(260, 'Saint-Gély-du-Fesc (34980)'),
(261, 'Saint-Geniès-de-Fontedit (34480)'),
(262, 'Saint-Geniès-de-Varensal (34610)'),
(263, 'Saint-Geniès-des-Mourgues (34160)'),
(264, 'Saint-Georges-d\'Orques (34680)'),
(265, 'Saint-Gervais-sur-Mare (34610)'),
(266, 'Saint-Guilhem-le-Désert (34150)'),
(267, 'Saint-Guiraud (34725)'),
(268, 'Saint-Hilaire-de-Beauvoir (34160)'),
(269, 'Saint-Jean-de-Buèges (34380)'),
(270, 'Saint-Jean-de-Cornies (34160)'),
(271, 'Saint-Jean-de-Cuculles (34270)'),
(272, 'Saint-Jean-de-Fos (34150)'),
(273, 'Saint-Jean-de-la-Blaquière (34700)'),
(274, 'Saint-Jean-de-Minervois (34360)'),
(275, 'Saint-Jean-de-Védas (34430)'),
(276, 'Saint-Julien (34390)'),
(277, 'Saint-Just (34400)'),
(278, 'Saint-Martin-de-l\'Arçon (34390)'),
(279, 'Saint-Martin-de-Londres (34380)'),
(280, 'Saint-Mathieu-de-Tréviers (34270)'),
(281, 'Saint-Maurice-Navacelles (34190)'),
(282, 'Saint-Michel (34520)'),
(283, 'Saint-Nazaire-de-Ladarez (34490)'),
(284, 'Saint-Nazaire-de-Pézan (34400)'),
(285, 'Saint-Pargoire (34230)'),
(286, 'Saint-Paul-et-Valmalle (34570)'),
(287, 'Saint-Pierre-de-la-Fage (34520)'),
(288, 'Saint-Pons-de-Mauchiens (34230)'),
(289, 'Saint-Pons-de-Thomières (34220)'),
(290, 'Saint-Privat (34700)'),
(291, 'Saint-Saturnin-de-Lucian (34725)'),
(292, 'Saint-Sériès (34400)'),
(293, 'Saint-Thibéry (34630)'),
(294, 'Saint-Vincent-d\'Olargues (34390)'),
(295, 'Saint-Vincent-de-Barbeyrargues (34730)'),
(296, 'Sainte-Croix-de-Quintillargues (34270)'),
(297, 'Salasc (34800)'),
(298, 'Saturargues (34400)'),
(299, 'Saussan (34570)'),
(300, 'Saussines (34160)'),
(301, 'Sauteyrargues (34270)'),
(302, 'Sauvian (34410)'),
(303, 'Sérignan (34410)'),
(304, 'Servian (34290)'),
(305, 'Sète (34200)'),
(306, 'Siran (34210)'),
(307, 'Sorbs (34520)'),
(308, 'Soubès (34700)'),
(309, 'Soumont (34700)'),
(310, 'Sussargues (34160)'),
(311, 'Taussac-la-Billière (34600)'),
(312, 'Teyran (34820)'),
(313, 'Thézan-lès-Béziers (34490)'),
(314, 'Tourbes (34120)'),
(315, 'Tressan (34230)'),
(316, 'Usclas-d\'Hérault (34230)'),
(317, 'Usclas-du-Bosc (34700)'),
(318, 'Vacquières (34270)'),
(319, 'Vailhan (34320)'),
(320, 'Vailhauquès (34570)'),
(321, 'Valergues (34130)'),
(322, 'Valflaunès (34270)'),
(323, 'Valmascle (34800)'),
(324, 'Valras-Plage (34350)'),
(325, 'Valros (34290)'),
(326, 'Vélieux (34220)'),
(327, 'Vendargues (34740)'),
(328, 'Vendémian (34230)'),
(329, 'Vendres (34350)'),
(330, 'Vérargues (34400)'),
(331, 'Verreries-de-Moussans (34220)'),
(332, 'Vias (34450)'),
(333, 'Vic-la-Gardiole (34110)'),
(334, 'Vieussan (34390)'),
(335, 'Villemagne-l\'Argentière (34600)'),
(336, 'Villeneuve-lès-Béziers (34420)'),
(337, 'Villeneuve-lès-Maguelone (34750)'),
(338, 'Villeneuvette (34800)'),
(339, 'Villespassans (34360)'),
(340, 'Villetelle (34400)'),
(341, 'Villeveyrac (34560)'),
(342, 'Viols-en-Laval (34380)'),
(343, 'Viols-le-Fort (34380)');

--
-- Index pour les tables déchargées
--

--
-- Index pour la table `Classe`
--
ALTER TABLE `Classe`
  ADD PRIMARY KEY (`idclasse`);

--
-- Index pour la table `Etudiant`
--
ALTER TABLE `Etudiant`
  ADD PRIMARY KEY (`idetudiant`),
  ADD KEY `Etudiant_Classe_FK` (`idclasse`),
  ADD KEY `Etudiant_Ville0_FK` (`idville`),
  ADD KEY `Etudiant_Statut1_FK` (`idstatut`);

--
-- Index pour la table `Statut`
--
ALTER TABLE `Statut`
  ADD PRIMARY KEY (`idstatut`);

--
-- Index pour la table `Ville`
--
ALTER TABLE `Ville`
  ADD PRIMARY KEY (`idville`);

--
-- AUTO_INCREMENT pour les tables déchargées
--

--
-- AUTO_INCREMENT pour la table `Classe`
--
ALTER TABLE `Classe`
  MODIFY `idclasse` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT pour la table `Etudiant`
--
ALTER TABLE `Etudiant`
  MODIFY `idetudiant` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=54;

--
-- AUTO_INCREMENT pour la table `Statut`
--
ALTER TABLE `Statut`
  MODIFY `idstatut` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT pour la table `Ville`
--
ALTER TABLE `Ville`
  MODIFY `idville` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=344;

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `Etudiant`
--
ALTER TABLE `Etudiant`
  ADD CONSTRAINT `Etudiant_Classe_FK` FOREIGN KEY (`idclasse`) REFERENCES `Classe` (`idclasse`),
  ADD CONSTRAINT `Etudiant_Statut1_FK` FOREIGN KEY (`idstatut`) REFERENCES `Statut` (`idstatut`),
  ADD CONSTRAINT `Etudiant_Ville0_FK` FOREIGN KEY (`idville`) REFERENCES `Ville` (`idville`);
