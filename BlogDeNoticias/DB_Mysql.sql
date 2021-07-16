#Script MySQL
#Autor: Fabio de Souza


#Criação da tabela autor
CREATE TABLE `blog`.`tb_autor` (
  `id_autor` INT NOT NULL AUTO_INCREMENT,
  `nome_autor` VARCHAR(60) NULL,
  `lastname_autor` VARCHAR(60) NULL,
  `idade_autor` INT NULL,
  `nacionalidade` VARCHAR(45) NULL,
  UNIQUE INDEX `id_autor_UNIQUE` (`id_autor` ASC),
  PRIMARY KEY (`id_autor`));

#Criação da tabela Noticia
CREATE TABLE `blog`.`tb_noticia` (
  `id_noticia` INT NOT NULL AUTO_INCREMENT,
  `titulo` VARCHAR(80) NULL,
  `texto` NVARCHAR(400) NULL,
  `dt_criado` TIMESTAMP(2) NOT NULL,
  `dt_modificado` TIMESTAMP(2) NOT NULL,
  `id_autor` INT NOT NULL,
  `id_categoria` INT NOT NULL,
  PRIMARY KEY (`id_noticia`),
  UNIQUE INDEX `id_noticia_UNIQUE` (`id_noticia` ASC));

#Criação da tabela Categoria
CREATE TABLE `blog`.`tb_categoria` (
  `id_categoria` INT NOT NULL AUTO_INCREMENT,
  `nome_categoria` VARCHAR(80) NULL,
  PRIMARY KEY (`id_categoria`));

