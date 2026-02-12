-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2026. Feb 12. 13:09
-- Kiszolgáló verziója: 10.4.32-MariaDB
-- PHP verzió: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `egyenivallalkozas`
--
CREATE DATABASE IF NOT EXISTS `egyenivallalkozas` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_hungarian_ci;
USE `egyenivallalkozas`;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `kapcsolatok`
--

CREATE TABLE `kapcsolatok` (
  `Azon` int(11) NOT NULL,
  `Nev` varchar(32) NOT NULL,
  `Cim` varchar(32) NOT NULL,
  `Email` varchar(32) NOT NULL,
  `Telefon` varchar(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_hungarian_ci;

--
-- A tábla adatainak kiíratása `kapcsolatok`
--

INSERT INTO `kapcsolatok` (`Azon`, `Nev`, `Cim`, `Email`, `Telefon`) VALUES
(1, 'a', 'b', 'teszt.teszt@gmail.com', '+36000000000');

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `kapcsolatok`
--
ALTER TABLE `kapcsolatok`
  ADD PRIMARY KEY (`Azon`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `kapcsolatok`
--
ALTER TABLE `kapcsolatok`
  MODIFY `Azon` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
