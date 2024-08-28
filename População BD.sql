use cadastrodepessoas;

INSERT INTO Pessoa (nome, dataNasc, estadoCivil, sexo)
VALUES
('Ana Clara Silva', '1990-05-12', 'Solteiro', 'F'),
('Bruno Oliveira', '1985-07-23', 'Casado', 'M'),
('Carlos Santos', '1978-03-15', 'Divorciado', 'M'),
('Daniela Mendes', '1992-11-30', 'Casado', 'F'),
('Eduardo Lima', '2000-01-10', 'Solteiro', 'M');

-- Inserindo dados na tabela Endereco
INSERT INTO Endereco (nomeDaRua, bairro, cidade, numero, estado, cep, idPessoa)
VALUES
('Rua das Flores', 'Centro', 'São Paulo', 123, 'SP', '01001-000', 1),
('Avenida Brasil', 'Jardim América', 'Rio de Janeiro', 456, 'RJ', '20000-000', 2),
('Rua do Sol', 'Boa Vista', 'Recife', 789, 'PE', '50000-000', 3),
('Praça da Liberdade', 'Savassi', 'Belo Horizonte', 101, 'MG', '30140-000', 4),
('Rua das Palmeiras', 'Centro', 'Florianópolis', 202, 'SC', '88000-000', 5);

-- Inserindo dados na tabela Contatos
INSERT INTO Contatos (email, telefone, celular, idPessoa)
VALUES
('ana.silva@example.com', '1122334455', '11987654321', 1),
('bruno.oliveira@example.com', '2233445566', '21987654321', 2),
('carlos.santos@example.com', '3344556677', '31987654321', 3),
('daniela.mendes@example.com', '4455667788', '41987654321', 4),
('eduardo.lima@example.com', '5566778899', '51987654321', 5);

select * from pessoa;