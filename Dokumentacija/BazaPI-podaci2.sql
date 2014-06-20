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
INSERT INTO `greymatterpi`.`klijent` (`oib`, `naziv`, `telefon`, `e-mail`, `adresa`, `ziroRacun`) VALUES ('48651234578', 'Lijekovi d.o.o', '048654123', 'kontakt@lijekovi.hr', 'Sportska bb', '1542145-51548465414');
INSERT INTO `greymatterpi`.`klijent` (`oib`, `naziv`, `telefon`, `e-mail`, `adresa`, `ziroRacun`) VALUES ('84578412344', 'Farmacia d.d', '015468798', 'kontakt@farmacia.hr', 'Ilica 42', '5468712-69874512324');
INSERT INTO `greymatterpi`.`klijent` (`oib`, `naziv`, `telefon`, `e-mail`, `adresa`, `ziroRacun`) VALUES ('58542145784', 'FOI d.o.o', '042879451', 'kontakt@foi.hr', 'Pavlinska 2', '6874512-45647894554');

COMMIT;


-- -----------------------------------------------------
-- Data for table `greymatterpi`.`narudzbenica`
-- -----------------------------------------------------
START TRANSACTION;
USE `greymatterpi`;
INSERT INTO `greymatterpi`.`narudzbenica` (`idNarudzbenice`, `oibKlijenta`, `datumIzdavanja`, `oibZaposlenika`, `rokPlacanja`, `status`) VALUES (NULL, '48651234578', '2014-05-30 09:35:54', '14579564124', '2014-06-30', 1);
INSERT INTO `greymatterpi`.`narudzbenica` (`idNarudzbenice`, `oibKlijenta`, `datumIzdavanja`, `oibZaposlenika`, `rokPlacanja`, `status`) VALUES (NULL, '84578412344', '2014-05-31 10:35:41', '14579564124', '2014-06-31', 1);

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
INSERT INTO `greymatterpi`.`lijek` (`idLijek`, `naziv`, `upute`, `datumProizvodnje`, `rokUpotrebe`, `cijena`, `pakiranje`, `doza`, `idJedinicnaMjera`, `idTipLijeka`, `kolicina`) VALUES (NULL, 'Lopin', 'Lijek za glavu', '2014-05-29', '2016-05-29', 37.99, 30, 5, 1, 3, 5000);
INSERT INTO `greymatterpi`.`lijek` (`idLijek`, `naziv`, `upute`, `datumProizvodnje`, `rokUpotrebe`, `cijena`, `pakiranje`, `doza`, `idJedinicnaMjera`, `idTipLijeka`, `kolicina`) VALUES (NULL, 'Ibuprofen Farmal 200 mg', 'Lijek za glavu', '2014-05-20', '2016-05-20', 69.99, 30, 200, 1, 3, 7500);
INSERT INTO `greymatterpi`.`lijek` (`idLijek`, `naziv`, `upute`, `datumProizvodnje`, `rokUpotrebe`, `cijena`, `pakiranje`, `doza`, `idJedinicnaMjera`, `idTipLijeka`, `kolicina`) VALUES (NULL, 'Ibuprofen Farmal 400 mg', 'Lijek za glavu', '2014-05-20', '2016-05-20', 99.99, 30, 400, 1, 3, 7500);
INSERT INTO `greymatterpi`.`lijek` (`idLijek`, `naziv`, `upute`, `datumProizvodnje`, `rokUpotrebe`, `cijena`, `pakiranje`, `doza`, `idJedinicnaMjera`, `idTipLijeka`, `kolicina`) VALUES (NULL, 'Ibuprofen Farmal 600 mg', 'Lijek za glavu', '2014-05-20', '2016-05-20', 119.99, 30, 600, 1, 3, 5000);

COMMIT;


-- -----------------------------------------------------
-- Data for table `greymatterpi`.`stavkeNarudzbenice`
-- -----------------------------------------------------
START TRANSACTION;
USE `greymatterpi`;
INSERT INTO `greymatterpi`.`stavkeNarudzbenice` (`idLijek`, `idNarudzbenice`, `kolicina`) VALUES (1, 1, 250);
INSERT INTO `greymatterpi`.`stavkeNarudzbenice` (`idLijek`, `idNarudzbenice`, `kolicina`) VALUES (3, 1, 700);
INSERT INTO `greymatterpi`.`stavkeNarudzbenice` (`idLijek`, `idNarudzbenice`, `kolicina`) VALUES (4, 1, 500);
INSERT INTO `greymatterpi`.`stavkeNarudzbenice` (`idLijek`, `idNarudzbenice`, `kolicina`) VALUES (1, 2, 1000);
INSERT INTO `greymatterpi`.`stavkeNarudzbenice` (`idLijek`, `idNarudzbenice`, `kolicina`) VALUES (2, 2, 1200);

COMMIT;

