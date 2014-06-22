SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

CREATE SCHEMA IF NOT EXISTS `greymatterpi` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci ;
USE `greymatterpi` ;

-- -----------------------------------------------------
-- Table `greymatterpi`.`zaposlenik`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `greymatterpi`.`zaposlenik` (
  `oib` CHAR(11) NOT NULL,
  `ime` VARCHAR(45) NOT NULL,
  `prezime` VARCHAR(45) NOT NULL,
  `adresa` VARCHAR(45) NOT NULL,
  `brojTelefona` VARCHAR(45) NOT NULL,
  `korisnickoIme` VARCHAR(45) NOT NULL,
  `lozinka` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`oib`),
  UNIQUE INDEX `korisnickoIme_UNIQUE` (`korisnickoIme` ASC))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `greymatterpi`.`klijent`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `greymatterpi`.`klijent` (
  `oib` CHAR(11) NOT NULL,
  `naziv` VARCHAR(45) NOT NULL,
  `telefon` VARCHAR(45) NOT NULL,
  `e-mail` VARCHAR(45) NULL,
  `adresa` VARCHAR(45) NOT NULL,
  `ziroRacun` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`oib`),
  UNIQUE INDEX `ziroRacun_UNIQUE` (`ziroRacun` ASC))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `greymatterpi`.`narudzbenica`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `greymatterpi`.`narudzbenica` (
  `idNarudzbenice` INT NOT NULL AUTO_INCREMENT,
  `oibKlijenta` CHAR(11) NOT NULL,
  `datumIzdavanja` TIMESTAMP NOT NULL,
  `oibZaposlenika` CHAR(11) NOT NULL,
  `rokPlacanja` DATE NOT NULL,
  `status` INT NOT NULL DEFAULT 1,
  PRIMARY KEY (`idNarudzbenice`),
  INDEX `fk_racun_zaposlenik1_idx` (`oibZaposlenika` ASC),
  INDEX `fk_racun_klijent1_idx` (`oibKlijenta` ASC),
  CONSTRAINT `fk_racun_zaposlenik1`
    FOREIGN KEY (`oibZaposlenika`)
    REFERENCES `greymatterpi`.`zaposlenik` (`oib`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_racun_klijent1`
    FOREIGN KEY (`oibKlijenta`)
    REFERENCES `greymatterpi`.`klijent` (`oib`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `greymatterpi`.`jedinicnaMjera`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `greymatterpi`.`jedinicnaMjera` (
  `idJedinicnaMjera` INT NOT NULL AUTO_INCREMENT,
  `naziv` VARCHAR(45) NOT NULL,
  `kratica` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`idJedinicnaMjera`),
  UNIQUE INDEX `naziv_UNIQUE` (`naziv` ASC),
  UNIQUE INDEX `kratica_UNIQUE` (`kratica` ASC))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `greymatterpi`.`tipLijeka`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `greymatterpi`.`tipLijeka` (
  `idTipLijeka` INT NOT NULL AUTO_INCREMENT,
  `naziv` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`idTipLijeka`),
  UNIQUE INDEX `naziv_UNIQUE` (`naziv` ASC))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `greymatterpi`.`lijek`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `greymatterpi`.`lijek` (
  `idLijek` INT NOT NULL AUTO_INCREMENT,
  `naziv` VARCHAR(45) NOT NULL,
  `upute` TEXT NOT NULL,
  `datumProizvodnje` DATE NOT NULL,
  `rokUpotrebe` DATE NOT NULL,
  `cijena` FLOAT NOT NULL,
  `pakiranje` FLOAT NOT NULL,
  `doza` FLOAT NOT NULL,
  `idJedinicnaMjera` INT NOT NULL,
  `idTipLijeka` INT NOT NULL,
  `kolicina` INT NOT NULL,
  PRIMARY KEY (`idLijek`),
  INDEX `fk_lijek_jedinicnaMjera1_idx` (`idJedinicnaMjera` ASC),
  INDEX `fk_lijek_tipLijeka1_idx` (`idTipLijeka` ASC),
  CONSTRAINT `fk_lijek_jedinicnaMjera1`
    FOREIGN KEY (`idJedinicnaMjera`)
    REFERENCES `greymatterpi`.`jedinicnaMjera` (`idJedinicnaMjera`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_lijek_tipLijeka1`
    FOREIGN KEY (`idTipLijeka`)
    REFERENCES `greymatterpi`.`tipLijeka` (`idTipLijeka`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `greymatterpi`.`stavkeNarudzbenice`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `greymatterpi`.`stavkeNarudzbenice` (
  `idLijek` INT NOT NULL,
  `idNarudzbenice` INT NOT NULL,
  `kolicina` INT NOT NULL,
  PRIMARY KEY (`idLijek`, `idNarudzbenice`),
  INDEX `fk_stavkeRacuna_racun1_idx` (`idNarudzbenice` ASC),
  CONSTRAINT `fk_stavkeRacuna_lijek`
    FOREIGN KEY (`idLijek`)
    REFERENCES `greymatterpi`.`lijek` (`idLijek`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_stavkeRacuna_racun1`
    FOREIGN KEY (`idNarudzbenice`)
    REFERENCES `greymatterpi`.`narudzbenica` (`idNarudzbenice`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;

-- -----------------------------------------------------
-- Data for table `greymatterpi`.`zaposlenik`
-- -----------------------------------------------------
START TRANSACTION;
USE `greymatterpi`;
INSERT INTO `greymatterpi`.`zaposlenik` (`oib`, `ime`, `prezime`, `adresa`, `brojTelefona`, `korisnickoIme`, `lozinka`) VALUES ('14579564124', 'Stjepan', 'Borković', 'Ivana Mažuranića 61', '0984512457', 'sborkovic', 'sb123456');
INSERT INTO `greymatterpi`.`zaposlenik` (`oib`, `ime`, `prezime`, `adresa`, `brojTelefona`, `korisnickoIme`, `lozinka`) VALUES ('54698124573', 'Mirko', 'Vuk', 'Duga 18', '0914578451', 'mvuk', 'mv123456');
INSERT INTO `greymatterpi`.`zaposlenik` (`oib`, `ime`, `prezime`, `adresa`, `brojTelefona`, `korisnickoIme`, `lozinka`) VALUES ('48796554124', 'Ana', 'Horvat', 'Kratka 5', '092541265', 'ahorvat', 'ah123456');

COMMIT;


-- -----------------------------------------------------
-- Data for table `greymatterpi`.`klijent`
-- -----------------------------------------------------
START TRANSACTION;
USE `greymatterpi`;
INSERT INTO `greymatterpi`.`klijent` (`oib`, `naziv`, `telefon`, `e-mail`, `adresa`, `ziroRacun`) VALUES ('48651234578', 'Lijekovi d.o.o', '048654123', 'kontakt@lijekovi.hr', 'Sportska bb, Osijek', '1542145-51548465414');
INSERT INTO `greymatterpi`.`klijent` (`oib`, `naziv`, `telefon`, `e-mail`, `adresa`, `ziroRacun`) VALUES ('84578412344', 'Farmacia d.d', '015468798', 'kontakt@farmacia.hr', 'Ilica 42, Zagreb', '5468712-69874512324');
INSERT INTO `greymatterpi`.`klijent` (`oib`, `naziv`, `telefon`, `e-mail`, `adresa`, `ziroRacun`) VALUES ('58542145784', 'FOI d.o.o', '042879451', 'kontakt@foi.hr', 'Pavlinska 2, Varaždin', '6874512-45647894554');
INSERT INTO `greymatterpi`.`klijent` (`oib`, `naziv`, `telefon`, `e-mail`, `adresa`, `ziroRacun`) VALUES ('45478451424', 'Plava tableta d.o.o', '042451457', 'kontakt@plavatableta.hr', 'Ljudevita Gaja 184, Ivanec', '4451245-98456515564');
INSERT INTO `greymatterpi`.`klijent` (`oib`, `naziv`, `telefon`, `e-mail`, `adresa`, `ziroRacun`) VALUES ('87542154621', 'Farmal d.o.o', '38701548754', 'contact@farmal.de', 'Grosse Strasse 854, Munich', '8451474-45145483214');
INSERT INTO `greymatterpi`.`klijent` (`oib`, `naziv`, `telefon`, `e-mail`, `adresa`, `ziroRacun`) VALUES ('63521487542', 'Jeftino d.o.o', '098965451', 'kontakt@jeftino.hr', 'Svibanjska 63, Poreč', '8454121-45468484864');

COMMIT;


-- -----------------------------------------------------
-- Data for table `greymatterpi`.`narudzbenica`
-- -----------------------------------------------------
START TRANSACTION;
USE `greymatterpi`;
INSERT INTO `greymatterpi`.`narudzbenica` (`idNarudzbenice`, `oibKlijenta`, `datumIzdavanja`, `oibZaposlenika`, `rokPlacanja`, `status`) VALUES (NULL, '48651234578', '2012-12-07 09:35:54', '14579564124', '2013-01-07', 1);
INSERT INTO `greymatterpi`.`narudzbenica` (`idNarudzbenice`, `oibKlijenta`, `datumIzdavanja`, `oibZaposlenika`, `rokPlacanja`, `status`) VALUES (NULL, '84578412344', '2013-02-27 10:35:41', '14579564124', '2013--03-27', 1);
INSERT INTO `greymatterpi`.`narudzbenica` (`idNarudzbenice`, `oibKlijenta`, `datumIzdavanja`, `oibZaposlenika`, `rokPlacanja`, `status`) VALUES (NULL, '87542154621', '2013-07-02 10:11:41', '48796554124', '2013-08-02', 1);
INSERT INTO `greymatterpi`.`narudzbenica` (`idNarudzbenice`, `oibKlijenta`, `datumIzdavanja`, `oibZaposlenika`, `rokPlacanja`, `status`) VALUES (NULL, '58542145784', '2013-10-15 9:14:21', '54698124573', '2013-11-15', 1);
INSERT INTO `greymatterpi`.`narudzbenica` (`idNarudzbenice`, `oibKlijenta`, `datumIzdavanja`, `oibZaposlenika`, `rokPlacanja`, `status`) VALUES (NULL, '45478451424', '2014-02-07 13:25:11', '48796554124', '2014-03-07', 1);
INSERT INTO `greymatterpi`.`narudzbenica` (`idNarudzbenice`, `oibKlijenta`, `datumIzdavanja`, `oibZaposlenika`, `rokPlacanja`, `status`) VALUES (NULL, '48651234578', '2014-03-26 12:48:15', '14579564124', '2014-04-26', 1);
INSERT INTO `greymatterpi`.`narudzbenica` (`idNarudzbenice`, `oibKlijenta`, `datumIzdavanja`, `oibZaposlenika`, `rokPlacanja`, `status`) VALUES (NULL, '63521487542', '2014-04-29 14:21:34', '48796554124', '2014-05-29', 1);
INSERT INTO `greymatterpi`.`narudzbenica` (`idNarudzbenice`, `oibKlijenta`, `datumIzdavanja`, `oibZaposlenika`, `rokPlacanja`, `status`) VALUES (NULL, '45478451424', '2014-05-06 12:02:15', '48796554124', '2014-05-06', 1);
INSERT INTO `greymatterpi`.`narudzbenica` (`idNarudzbenice`, `oibKlijenta`, `datumIzdavanja`, `oibZaposlenika`, `rokPlacanja`, `status`) VALUES (NULL, '58542145784', '2014-05-17 10:17:52', '14579564124', '2014-06-17 ', 1);
INSERT INTO `greymatterpi`.`narudzbenica` (`idNarudzbenice`, `oibKlijenta`, `datumIzdavanja`, `oibZaposlenika`, `rokPlacanja`, `status`) VALUES (NULL, '87542154621', '2014-06-01 10:43:17', '54698124573', '2014-06-01', 1);
INSERT INTO `greymatterpi`.`narudzbenica` (`idNarudzbenice`, `oibKlijenta`, `datumIzdavanja`, `oibZaposlenika`, `rokPlacanja`, `status`) VALUES (NULL, '48651234578', '2014-06-08 13:40:10', '54698124573', '2014-07-08', 1);

COMMIT;


-- -----------------------------------------------------
-- Data for table `greymatterpi`.`jedinicnaMjera`
-- -----------------------------------------------------
START TRANSACTION;
USE `greymatterpi`;
INSERT INTO `greymatterpi`.`jedinicnaMjera` (`idJedinicnaMjera`, `naziv`, `kratica`) VALUES (NULL, 'Miligram', 'mg');
INSERT INTO `greymatterpi`.`jedinicnaMjera` (`idJedinicnaMjera`, `naziv`, `kratica`) VALUES (NULL, 'Dekagram', 'dag');
INSERT INTO `greymatterpi`.`jedinicnaMjera` (`idJedinicnaMjera`, `naziv`, `kratica`) VALUES (NULL, 'Gram', 'g');
INSERT INTO `greymatterpi`.`jedinicnaMjera` (`idJedinicnaMjera`, `naziv`, `kratica`) VALUES (NULL, 'Mililitar', 'ml');
INSERT INTO `greymatterpi`.`jedinicnaMjera` (`idJedinicnaMjera`, `naziv`, `kratica`) VALUES (NULL, 'Decilitar', 'dl');
INSERT INTO `greymatterpi`.`jedinicnaMjera` (`idJedinicnaMjera`, `naziv`, `kratica`) VALUES (NULL, 'Litar', 'l');

COMMIT;


-- -----------------------------------------------------
-- Data for table `greymatterpi`.`tipLijeka`
-- -----------------------------------------------------
START TRANSACTION;
USE `greymatterpi`;
INSERT INTO `greymatterpi`.`tipLijeka` (`idTipLijeka`, `naziv`) VALUES (NULL, 'Tableta');
INSERT INTO `greymatterpi`.`tipLijeka` (`idTipLijeka`, `naziv`) VALUES (NULL, 'Sirup');
INSERT INTO `greymatterpi`.`tipLijeka` (`idTipLijeka`, `naziv`) VALUES (NULL, 'Filmom obložena tableta');
INSERT INTO `greymatterpi`.`tipLijeka` (`idTipLijeka`, `naziv`) VALUES (NULL, 'Kapsula');
INSERT INTO `greymatterpi`.`tipLijeka` (`idTipLijeka`, `naziv`) VALUES (NULL, 'Tvrda kapsula');
INSERT INTO `greymatterpi`.`tipLijeka` (`idTipLijeka`, `naziv`) VALUES (NULL, 'Otopina za injekcije');
INSERT INTO `greymatterpi`.`tipLijeka` (`idTipLijeka`, `naziv`) VALUES (NULL, 'Kapi');
INSERT INTO `greymatterpi`.`tipLijeka` (`idTipLijeka`, `naziv`) VALUES (NULL, 'Ampula');

COMMIT;


-- -----------------------------------------------------
-- Data for table `greymatterpi`.`lijek`
-- -----------------------------------------------------
START TRANSACTION;
USE `greymatterpi`;
INSERT INTO `greymatterpi`.`lijek` (`idLijek`, `naziv`, `upute`, `datumProizvodnje`, `rokUpotrebe`, `cijena`, `pakiranje`, `doza`, `idJedinicnaMjera`, `idTipLijeka`, `kolicina`) VALUES (NULL, 'Lopin', 'Lijek za glavobolju', '2012-05-29', '2016-05-29', 37.99, 30, 5, 1, 3, 5000);
INSERT INTO `greymatterpi`.`lijek` (`idLijek`, `naziv`, `upute`, `datumProizvodnje`, `rokUpotrebe`, `cijena`, `pakiranje`, `doza`, `idJedinicnaMjera`, `idTipLijeka`, `kolicina`) VALUES (NULL, 'Ibuprofen Farmal 200 mg', 'Lijek protiv glavobolje', '2012-07-20', '2016-07-27', 69.99, 30, 200, 1, 3, 7500);
INSERT INTO `greymatterpi`.`lijek` (`idLijek`, `naziv`, `upute`, `datumProizvodnje`, `rokUpotrebe`, `cijena`, `pakiranje`, `doza`, `idJedinicnaMjera`, `idTipLijeka`, `kolicina`) VALUES (NULL, 'Ibuprofen Farmal 400 mg', 'Lijek protiv glavobolje', '2012-10-20', '2016-10-20', 99.99, 30, 400, 1, 3, 7500);
INSERT INTO `greymatterpi`.`lijek` (`idLijek`, `naziv`, `upute`, `datumProizvodnje`, `rokUpotrebe`, `cijena`, `pakiranje`, `doza`, `idJedinicnaMjera`, `idTipLijeka`, `kolicina`) VALUES (NULL, 'Ibuprofen Farmal 600 mg', 'Lijek protiv glavobolje', '2013-01-15', '2017-01-15', 119.99, 30, 600, 1, 3, 5000);
INSERT INTO `greymatterpi`.`lijek` (`idLijek`, `naziv`, `upute`, `datumProizvodnje`, `rokUpotrebe`, `cijena`, `pakiranje`, `doza`, `idJedinicnaMjera`, `idTipLijeka`, `kolicina`) VALUES (NULL, 'Biprol', 'Lijek za bolove', '2013-03-01', '2017-03-01', 89.99, 30, 10, 1, 1, 10000);
INSERT INTO `greymatterpi`.`lijek` (`idLijek`, `naziv`, `upute`, `datumProizvodnje`, `rokUpotrebe`, `cijena`, `pakiranje`, `doza`, `idJedinicnaMjera`, `idTipLijeka`, `kolicina`) VALUES (NULL, 'Lamox', 'Lijek za temperaturu', '2013-05-18', '2017-05-18', 24.99, 30, 25, 1, 1, 6500);
INSERT INTO `greymatterpi`.`lijek` (`idLijek`, `naziv`, `upute`, `datumProizvodnje`, `rokUpotrebe`, `cijena`, `pakiranje`, `doza`, `idJedinicnaMjera`, `idTipLijeka`, `kolicina`) VALUES (NULL, 'Tramadol', 'Lijek za kašalj', '2013-08-21', '2017-08-21', 62.99, 5, 50, 1, 8, 2500);
INSERT INTO `greymatterpi`.`lijek` (`idLijek`, `naziv`, `upute`, `datumProizvodnje`, `rokUpotrebe`, `cijena`, `pakiranje`, `doza`, `idJedinicnaMjera`, `idTipLijeka`, `kolicina`) VALUES (NULL, 'Sedrone', 'Lijek za čelavost', '2014-11-30', '2018-11-30', 75.99, 4, 35, 1, 3, 4500);
INSERT INTO `greymatterpi`.`lijek` (`idLijek`, `naziv`, `upute`, `datumProizvodnje`, `rokUpotrebe`, `cijena`, `pakiranje`, `doza`, `idJedinicnaMjera`, `idTipLijeka`, `kolicina`) VALUES (NULL, 'Ketoprofen', 'Lijek za rak', '2014-01-15', '2018-01-15', 145.99, 30, 50, 1, 4, 4200);
INSERT INTO `greymatterpi`.`lijek` (`idLijek`, `naziv`, `upute`, `datumProizvodnje`, `rokUpotrebe`, `cijena`, `pakiranje`, `doza`, `idJedinicnaMjera`, `idTipLijeka`, `kolicina`) VALUES (NULL, 'Itaz', 'Lijek za rane', '2014-02-06', '2018-02-16', 105.99, 60, 30, 1, 1, 6400);
INSERT INTO `greymatterpi`.`lijek` (`idLijek`, `naziv`, `upute`, `datumProizvodnje`, `rokUpotrebe`, `cijena`, `pakiranje`, `doza`, `idJedinicnaMjera`, `idTipLijeka`, `kolicina`) VALUES (NULL, 'Funzol', 'Lijek za opekline', '2014-05-20', '2018-05-20', 84.99, 7, 100, 1, 4, 8800);

COMMIT;


-- -----------------------------------------------------
-- Data for table `greymatterpi`.`stavkeNarudzbenice`
-- -----------------------------------------------------
START TRANSACTION;
USE `greymatterpi`;
INSERT INTO `greymatterpi`.`stavkeNarudzbenice` (`idLijek`, `idNarudzbenice`, `kolicina`) VALUES (1, 1, 250);
INSERT INTO `greymatterpi`.`stavkeNarudzbenice` (`idLijek`, `idNarudzbenice`, `kolicina`) VALUES (3, 1, 700);
INSERT INTO `greymatterpi`.`stavkeNarudzbenice` (`idLijek`, `idNarudzbenice`, `kolicina`) VALUES (4, 1, 500);
INSERT INTO `greymatterpi`.`stavkeNarudzbenice` (`idLijek`, `idNarudzbenice`, `kolicina`) VALUES (2, 2, 1000);
INSERT INTO `greymatterpi`.`stavkeNarudzbenice` (`idLijek`, `idNarudzbenice`, `kolicina`) VALUES (6, 2, 1200);
INSERT INTO `greymatterpi`.`stavkeNarudzbenice` (`idLijek`, `idNarudzbenice`, `kolicina`) VALUES (11, 3, 500);
INSERT INTO `greymatterpi`.`stavkeNarudzbenice` (`idLijek`, `idNarudzbenice`, `kolicina`) VALUES (8, 3, 200);
INSERT INTO `greymatterpi`.`stavkeNarudzbenice` (`idLijek`, `idNarudzbenice`, `kolicina`) VALUES (7, 3, 300);
INSERT INTO `greymatterpi`.`stavkeNarudzbenice` (`idLijek`, `idNarudzbenice`, `kolicina`) VALUES (4, 3, 100);
INSERT INTO `greymatterpi`.`stavkeNarudzbenice` (`idLijek`, `idNarudzbenice`, `kolicina`) VALUES (9, 4, 500);
INSERT INTO `greymatterpi`.`stavkeNarudzbenice` (`idLijek`, `idNarudzbenice`, `kolicina`) VALUES (6, 4, 50);
INSERT INTO `greymatterpi`.`stavkeNarudzbenice` (`idLijek`, `idNarudzbenice`, `kolicina`) VALUES (4, 5, 700);
INSERT INTO `greymatterpi`.`stavkeNarudzbenice` (`idLijek`, `idNarudzbenice`, `kolicina`) VALUES (5, 5, 400);
INSERT INTO `greymatterpi`.`stavkeNarudzbenice` (`idLijek`, `idNarudzbenice`, `kolicina`) VALUES (3, 6, 350);
INSERT INTO `greymatterpi`.`stavkeNarudzbenice` (`idLijek`, `idNarudzbenice`, `kolicina`) VALUES (11, 6, 150);
INSERT INTO `greymatterpi`.`stavkeNarudzbenice` (`idLijek`, `idNarudzbenice`, `kolicina`) VALUES (10, 6, 320);
INSERT INTO `greymatterpi`.`stavkeNarudzbenice` (`idLijek`, `idNarudzbenice`, `kolicina`) VALUES (6, 7, 200);
INSERT INTO `greymatterpi`.`stavkeNarudzbenice` (`idLijek`, `idNarudzbenice`, `kolicina`) VALUES (1, 7, 150);
INSERT INTO `greymatterpi`.`stavkeNarudzbenice` (`idLijek`, `idNarudzbenice`, `kolicina`) VALUES (3, 7, 50);
INSERT INTO `greymatterpi`.`stavkeNarudzbenice` (`idLijek`, `idNarudzbenice`, `kolicina`) VALUES (4, 7, 250);
INSERT INTO `greymatterpi`.`stavkeNarudzbenice` (`idLijek`, `idNarudzbenice`, `kolicina`) VALUES (5, 7, 100);
INSERT INTO `greymatterpi`.`stavkeNarudzbenice` (`idLijek`, `idNarudzbenice`, `kolicina`) VALUES (9, 7, 80);
INSERT INTO `greymatterpi`.`stavkeNarudzbenice` (`idLijek`, `idNarudzbenice`, `kolicina`) VALUES (1, 8, 250);
INSERT INTO `greymatterpi`.`stavkeNarudzbenice` (`idLijek`, `idNarudzbenice`, `kolicina`) VALUES (5, 8, 410);
INSERT INTO `greymatterpi`.`stavkeNarudzbenice` (`idLijek`, `idNarudzbenice`, `kolicina`) VALUES (7, 8, 650);
INSERT INTO `greymatterpi`.`stavkeNarudzbenice` (`idLijek`, `idNarudzbenice`, `kolicina`) VALUES (9, 9, 150);
INSERT INTO `greymatterpi`.`stavkeNarudzbenice` (`idLijek`, `idNarudzbenice`, `kolicina`) VALUES (10, 9, 200);
INSERT INTO `greymatterpi`.`stavkeNarudzbenice` (`idLijek`, `idNarudzbenice`, `kolicina`) VALUES (11, 9, 170);
INSERT INTO `greymatterpi`.`stavkeNarudzbenice` (`idLijek`, `idNarudzbenice`, `kolicina`) VALUES (8, 10, 250);
INSERT INTO `greymatterpi`.`stavkeNarudzbenice` (`idLijek`, `idNarudzbenice`, `kolicina`) VALUES (2, 10, 350);
INSERT INTO `greymatterpi`.`stavkeNarudzbenice` (`idLijek`, `idNarudzbenice`, `kolicina`) VALUES (1, 11, 500);

COMMIT;

USE `greymatterpi`;

DELIMITER $$
USE `greymatterpi`$$
CREATE TRIGGER `unos_smanji` AFTER INSERT ON `stavkenarudzbenice`
 FOR EACH ROW update lijek set lijek.kolicina=lijek.kolicina-new.kolicina 
	where new.idLijek=lijek.idLijek
$$


DELIMITER ;
