Scripts de banco GPT:

-- Criação do banco de dados (opcional, caso ainda não exista)
CREATE DATABASE barbearia;

-- Conectar ao banco de dados
\c barbearia;

-- Criação da tabela de clientes
CREATE TABLE clientes (
    cliente_id SERIAL PRIMARY KEY,
    nome VARCHAR(100) NOT NULL,
    telefone VARCHAR(15),
    email VARCHAR(100) UNIQUE,
    data_registro DATE DEFAULT CURRENT_DATE
);

-- Criação da tabela de funcionários (barbeiros)
CREATE TABLE funcionarios (
    funcionario_id SERIAL PRIMARY KEY,
    nome VARCHAR(100) NOT NULL,
    telefone VARCHAR(15),
    especialidade VARCHAR(100),
    data_contratacao DATE DEFAULT CURRENT_DATE
);

-- Criação da tabela de serviços
CREATE TABLE servicos (
    servico_id SERIAL PRIMARY KEY,
    descricao VARCHAR(100) NOT NULL,
    preco DECIMAL(10, 2) NOT NULL
);

-- Criação da tabela de agendamentos
CREATE TABLE agendamentos (
    agendamento_id SERIAL PRIMARY KEY,
    cliente_id INT REFERENCES clientes(cliente_id) ON DELETE CASCADE,
    funcionario_id INT REFERENCES funcionarios(funcionario_id) ON DELETE SET NULL,
    servico_id INT REFERENCES servicos(servico_id) ON DELETE SET NULL,
    data_agendamento DATE NOT NULL,
    hora_agendamento TIME NOT NULL,
    status VARCHAR(20) DEFAULT 'Pendente' -- Status pode ser 'Pendente', 'Concluído', 'Cancelado'
);

-- Criação da tabela de pagamentos
CREATE TABLE pagamentos (
    pagamento_id SERIAL PRIMARY KEY,
    agendamento_id INT REFERENCES agendamentos(agendamento_id) ON DELETE CASCADE,
    valor DECIMAL(10, 2) NOT NULL,
    metodo_pagamento VARCHAR(20), -- Exemplo: 'Cartão', 'Dinheiro', 'PIX'
    data_pagamento DATE DEFAULT CURRENT_DATE
);

-- Criação da tabela de horários de trabalho dos barbeiros
CREATE TABLE horarios_trabalho (
    horario_id SERIAL PRIMARY KEY,
    funcionario_id INT REFERENCES funcionarios(funcionario_id) ON DELETE CASCADE,
    dia_semana VARCHAR(15), -- Exemplo: 'Segunda', 'Terça'
    hora_inicio TIME,
    hora_fim TIME
);

-- Criação de índices para otimização de consultas
CREATE INDEX idx_cliente_nome ON clientes(nome);
CREATE INDEX idx_funcionario_nome ON funcionarios(nome);
CREATE INDEX idx_data_hora_agendamento ON agendamentos(data_agendamento, hora_agendamento);
