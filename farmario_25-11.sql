-- phpMyAdmin SQL Dump
-- version 4.0.4.2
-- http://www.phpmyadmin.net
--
-- Máquina: localhost
-- Data de Criação: 22-Nov-2023 às 19:09
-- Versão do servidor: 5.6.13
-- versão do PHP: 5.4.17

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Base de Dados: `farmario`
--
CREATE DATABASE IF NOT EXISTS `farmario` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `farmario`;

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_clientes`
--

CREATE TABLE IF NOT EXISTS `tb_clientes` (
  `cpf` varchar(14) NOT NULL,
  `nome` varchar(70) NOT NULL,
  `data_nasc` date NOT NULL,
  `telefone` varchar(15) NOT NULL,
  `cep` varchar(9) NOT NULL,
  `endereco` varchar(255) NOT NULL,
  `num` int(11) NOT NULL,
  `complemento` varchar(255) NOT NULL,
  PRIMARY KEY (`cpf`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `tb_clientes`
--

INSERT INTO `tb_clientes` (`cpf`, `nome`, `data_nasc`, `telefone`, `cep`, `endereco`, `num`, `complemento`) VALUES
('111.111.111-11', 'Maue', '2023-11-21', '(11) 11111-1111', '     -', '', 0, ''),
('121.212.121-21', 'Thais Oliveira e Silva', '2001-02-28', '(11) 98787-8787', '09050-040', 'Rua Argolas', 1213, 'Ap 8'),
('343.434.343-43', 'Gabriel Soares', '2001-03-12', '(11) 97676-7676', '     -', '', 0, '');

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_login`
--

CREATE TABLE IF NOT EXISTS `tb_login` (
  `nome` varchar(70) NOT NULL,
  `usuario` varchar(30) NOT NULL,
  `senha` varchar(20) NOT NULL,
  `cargo` varchar(30) NOT NULL,
  `cpf` varchar(14) NOT NULL,
  `celular` varchar(15) NOT NULL,
  `status` BOOLEAN DEFAULT NULL,
  PRIMARY KEY (`cpf`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `tb_login`
--

INSERT INTO `tb_login` (`nome`, `usuario`, `senha`, `cargo`, `cpf`, `celular`, `status`) VALUES
(
	'Caue Nunes Menezes', 
	'caue', 
	'caue123', 
	'Supervisor', 
	'111.111.111-11',
	'(11) 91234-1234',
	true
), (
	'Janis G S Oliveira',
	'janis',
	'janis123',
	'Operador de Caixa',
	'222.222.222-22',
	'(11) 95385-8431',
	true
), (
	'Caue Janis',
	'caja',
	'caja123',
	'Farmacêutico',
	'333.333.333-33',
	'(11) 90909-9090',
	true
), (
	'Robson Teste',
	'robson',
	'robson123',
	'Supervisor',
	'444.444.444-44',
	'(00) 91234-1234',
	true
);

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_produtos`
--

CREATE TABLE IF NOT EXISTS `tb_produtos` (
  `cod_prod` varchar(6) NOT NULL,
  `produto` varchar(255) NOT NULL,
  `qtde` int(11) DEFAULT NULL,
  `valor` decimal(8,2) NOT NULL,
  `tipo` varchar(50) NOT NULL,
  `receita` boolean DEFAULT NULL,
  PRIMARY KEY (`cod_prod`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `tb_produtos`
--

INSERT INTO `tb_produtos` (`cod_prod`, `produto`, `qtde`, `valor`, `tipo`, `receita`) VALUES
('111-11', 'ZIAGENAVIR 20MG GLAXOSMITHKLINE 240ML', 101, '366.00', 'ANTIVIRAL', 0),
('111-12', 'CEFALEXINA 250MG/5ML', 99, '25.35', 'ANTIBIOTICO', 0),
('111-13', 'IBUPRIL 400MG 10 CAPSULAS', 100, '7.39', 'ANTI-INFLAMATORIO', 0),
('111-14', 'ENZIMA DIGESTIVA 60 CAPSULAS', 100, '47.50', 'DIGESTIVO', 0),
('111-15', 'ALLEGRA 60MG 10 COMPRIMIDOS', 100, '38.25', 'ANTIALERGICO', 0),
('111-16', 'EPAREMA 10 DRAGEAS', 100, '17.19', 'ANTIEMETICO', 0),
('111-17', 'NERVOCALM 250MG 20 COMPRIMIDOS', 100, '25.04', 'ANTICONVULSIONANTE', 1),
('111-18', 'ACICLOVIR CREME 50MG', 100, '15.19', 'ANTIVIRAL', 0),
('111-19', 'AMOXIL 500MG 15 CAPSULAS', 100, '55.39', 'ANTIBIOTICO', 0),
('222-21', 'DORFLEX 10 COMPRIMIDOS', 100, '7.29', 'ANALGESICO', 0),
('222-22', 'FLUOXETINA 20MG 30 COMPRIMIDOS', 100, '40.35', 'ANTIDEPRESSIVO', 1),
('222-23', 'ACETILCISTEINA 600MG', 100, '33.59', 'EXPECTORANTE', 0),
('222-24', 'FLUTINOL COLIRIO 5ML', 100, '34.49', 'ANTI-INFLAMATORIO', 0),
('222-26', 'ALBENDAZOL 400MG 3 COMPRIMIDOS MASTIGAVEIS', 100, '21.19', 'VERMINOSE', 0),
('333-33', 'DIPIRONA MONOIDRATADA 500 MG 10 COMP', 31, '12.99', 'ANALGÉSICO', 0);

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_vendas`
--

CREATE TABLE IF NOT EXISTS `tb_vendas` (
  `id_venda` bigint(20) NOT NULL AUTO_INCREMENT,
  `cpf` varchar(14) not NULL,
  `data_compra` date NOT NULL,
  PRIMARY KEY (`id_venda`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=16 ;

--
-- Extraindo dados da tabela `tb_vendas`
--

INSERT INTO `tb_vendas` (`id_venda`, `cpf`, `data_compra`) VALUES
(11, '   .   .   -', '2023-11-22'),
(12, '121.212.121-21', '2023-11-22'),
(13, '   .   .   -', '2023-11-22'),
(14, '   .   .   -', '2023-11-22'),
(15, '   .   .   -', '2023-11-22'),
(16, '111.111.111-11', '2023-11-22'),
(17, '111.111.111-11', '2023-11-23'),
(18, '   .   .   -', '2023-11-24'),
(19, '   .   .   -', '2023-11-24'),
(20, '   .   .   -', '2023-11-24'),
(21, '   .   .   -', '2023-11-24'),
(22, '   .   .   -', '2023-11-24'),
(23, '   .   .   -', '2023-11-24'),
(24, '   .   .   -', '2023-11-24');

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_vendas_produto`
--

CREATE TABLE IF NOT EXISTS `tb_vendas_produto` (
  `saida` int(11) NOT NULL AUTO_INCREMENT,
  `cod_prod` varchar(6) NOT NULL,
  `id_venda` bigint(20) NOT NULL,
  `qtde` int(4) NOT NULL,
  `valor` decimal(8,2) NOT NULL,
  PRIMARY KEY (`saida`),
  KEY `fk_id_venda` (`id_venda`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=15 ;

--
-- Extraindo dados da tabela `tb_vendas_produto`
--

INSERT INTO `tb_vendas_produto` (`saida`, `cod_prod`, `id_venda`, `qtde`, `valor`) VALUES
(8, '111-12', 11, 1, '25.00'),
(9, '111-14', 12, 1, '47.00'),
(10, '111-13', 13, 2, '14.00'),
(11, '111-15', 13, 2, '76.00'),
(12, '111-11', 14, 1, '366.00'),
(13, '333-33', 14, 33, '396.00'),
(14, '111-12', 15, 1, '25.00'),
(15, '222-21', 16, 3, '21.00'),
(16, '222-21', 17, 3, '21.00'),
(17, '111-18', 17, 1, '15.00'),
(18, '111-19', 18, 3, '166.00'),
(19, '111-17', 18, 3, '75.00'),
(20, '111-12', 19, 1, '25.00'),
(21, '111-15', 19, 1, '38.00'),
(22, '111-16', 20, 2, '34.00'),
(23, '111-17', 20, 1, '25.00'),
(24, '111-17', 20, 1, '25.00'),
(25, '111-14', 21, 11, '522.00'),
(26, '111-13', 21, 11, '81.00'),
(27, '111-12', 22, 1, '25.00'),
(28, '111-14', 22, 1, '47.00'),
(29, '111-17', 23, 1, '25.00'),
(30, '111-17', 24, 1, '25.00'),
(31, '111-18', 24, 1, '15.00');

--
-- Constraints for dumped tables
--

--
-- Limitadores para a tabela `tb_vendas_produto`
--
ALTER TABLE `tb_vendas_produto`
  ADD CONSTRAINT `tb_vendas_produto_ibfk_1` FOREIGN KEY (`id_venda`) REFERENCES `tb_vendas` (`id_venda`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
