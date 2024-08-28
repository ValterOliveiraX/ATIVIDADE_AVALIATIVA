CREATE DATABASE CadastroDePessoas;

USE CadastroDePessoas;

-- Tabela Pessoa
CREATE TABLE Pessoa (
    idPessoa INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(100) NOT NULL,
    dataNasc DATE NOT NULL,
    estadoCivil VARCHAR(20),
    sexo ENUM('M', 'F', 'Outro')
);

-- Tabela Endereco
CREATE TABLE Endereco (
    idEndereco INT AUTO_INCREMENT PRIMARY KEY,
    nomeDaRua VARCHAR(100),
    bairro VARCHAR(50),
    cidade VARCHAR(50),
    numero INT,
    estado VARCHAR(2),
    cep VARCHAR(9),
    idPessoa INT,
    FOREIGN KEY (idPessoa) REFERENCES Pessoa(idPessoa)
);

-- Tabela Contatos
CREATE TABLE Contatos (
    idContato INT AUTO_INCREMENT PRIMARY KEY,
    email VARCHAR(100),
    telefone VARCHAR(15),
    celular VARCHAR(15),
    idPessoa INT,
    FOREIGN KEY (idPessoa) REFERENCES Pessoa(idPessoa)
);


