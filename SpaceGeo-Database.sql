START TRANSACTION;

--
-- Database: `contatos`
--
CREATE DATABASE `SpaceGeo`
USE DATABASE `SpaceGeo`
-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_forma`
--

DROP TABLE IF EXISTS `tb_forma`;
CREATE TABLE IF NOT EXISTS `tb_forma` (
  `id_forma` int NOT NULL AUTO_INCREMENT,
  `nome_forma` varchar(60) NOT NULL,
  `imagem_forma` blob,
  PRIMARY KEY (`id_forma`)
);

--
-- Inserindo dados da tabela `contato`
--

INSERT INTO `tb_forma` (`nome_forma`) VALUES
('Cubo'),
('Paralelepipedo'),
('Cilindro'),
('Esfera');

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_formula`
--

DROP TABLE IF EXISTS `tb_formula`;
CREATE TABLE IF NOT EXISTS `tb_formula` (
  `id_formula` int NOT NULL AUTO_INCREMENT,
  `nome_formula` varchar(60) NOT NULL,
  `formula` varchar(30) NOT NULL,
  `id_forma` int NOT NULL,
  PRIMARY KEY (`id_formula`),
  FOREIGN KEY (`id_forma`) REFERENCES tb_forma(`id_forma`)
);

--
-- Inserindo dados da tabela `tb_formula`
--

INSERT INTO `tb_formula` (`nome_formula`, `formula`, `id_forma`) VALUES
('Volume', '(X*X)^3', 1),
('Area Total', '6*(X*X)^2', 1),
('Volume', 'A*B*C', 2),
('Area Total', '2*A*B + 2*A*C + 2*B*C', 2),
('Volume', 'Ï€*(R^2)*H', 3),
('Area Total', '2*Ï€*R*(R+H)', 3),
('Area Total', '4*Ï€*(R^2)', 4);

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_variavel`
--

DROP TABLE IF EXISTS `tb_variavel`;
CREATE TABLE IF NOT EXISTS `tb_variavel` (
  `id_variavel` int NOT NULL AUTO_INCREMENT,
  `char_variavel` varchar(5) NOT NULL,
  `id_forma` int NOT NULL,
  PRIMARY KEY (`id_variavel`),
  FOREIGN KEY (`id_forma`) REFERENCES tb_forma(`id_forma`)
) ;

--
-- Inserindo dados da tabela `tb_variavel`
--

INSERT INTO `tb_variavel` (`char_variavel`, `id_formula`) VALUES
('X', 1),
('A', 2),
('B', 2),
('C', 2),
('Ï€', 3),
('R', 3),
('H', 3),
('Ï€', 4),
('R', 4);
COMMIT;