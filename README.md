<div align="center">
	<img src="./Resources/asfa-logo.png" alt="ASFA" widthwidth="250" height="250" />
	<h1>ASFA - Associação Católica Sagrada Família</h1>
	[🇺🇸](./README.md) [🇧🇷](./README-BR.md)
</div>

## Sobre o Projeto

O ASFA é uma aplicação desktop desenvolvida em C# utilizando Windows Forms com integração ao banco de dados Supabase.

O objetivo do sistema é facilitar o controle das pessoas idosas que frequentam a Associação Católica Sagrada Família, permitindo o registro de suas informações pessoais, dados de seus dependentes, e a geração de relatórios em PDF para para fins de documentação e impressão.

[Baixe a versão mais recente aqui](https://github.com/LucasCoelhoSantos/ASFA/releases/latest)

## Funcionalidades

- Cadastro de pessoas idosas com informações detalhadas;
- Cadastro de dependentes vinculados às pessoas idosas;
- Consulta, atualização e inativação de registros;
- Exportação dos dados em formato PDF para impressão;
- Interface de fácil utilização.

## Tecnologias Utilizadas

- Linguagem: C# (.NET Framework)
- Interface Gráfica: Windows Forms
- Banco de Dados: Supabase (PostgreSQL)
- Geração de PDF: ReportViewer
- ORM/Conexão: Npgsql (driver PostgreSQL para C#)
- Webservice de CEP: ViaCep

## Requisitos

- Computador com conexão com internet;
- Computador com Windows 10 ou superior instalado.

## Estrutura do Projeto

```
/ASFA
  /Forms             -> Telas do sistema (cadastro, consulta, etc.)
  /Helpers           -> Funções auxiliares
  /Models            -> Classes de entidade
  /Reports           -> Modelos de relatório
  /Repositories      -> Camada de persistência de dados
  /Services          -> Regra de negócio da aplicação
  /Resources         -> Imagens para usar na aplicação
  Program.cs         -> Inicialização da aplicação
  App.config         -> Configurações de conexão
  appsettings.json   -> Conection strings
  client_secret.json -> Arquivo de configuração Google Cloud Console
```

> [!IMPORTANT]  
> As configurações de conexão ```appsettings.json``` e o ```client_secret.json``` devem ser adquiridos do Supabase de destino.

## Telas Disponíveis

Atualmente, o sistema conta com as seguintes telas implementadas:

1. Tela de Login e Cadastro de Usuário:
Permite a autenticação dos usuários e o cadastro de novos acessos ao sistema.

2. Menu de Pessoas Idosas:
Tela principal para gerenciamento dos registros. Permite visualizar, adicionar, editar ou inativar cadastros de pessoas idosas.

3. Cadastro de Pessoas Idosas:
Formulário para inserção ou edição dos dados das pessoas idosas, como nome completo, data de nascimento, contato, endereço, entre outros campos relevantes.

4. Cadastro de Dependentes:
Formulário específico para registro de dependentes associados às pessoas idosas, contendo informações como nome, grau de parentesco e data de nascimento.

## Como Executar

1. Clone o repositório:
```
git clone https://github.com/lucas-coelho-santos/asfa.git
```
2. Abra o projeto no Visual Studio.
3. Configure o arquivo App.config com suas credenciais do Supabase.
4. Restaure os pacotes NuGet necessários:
	- Npgsql
	- (Biblioteca para PDF)
	- (Outros que forem usados)
5. Compile e execute o projeto.

## Banco de Dados

O Supabase está configurado com as seguintes principais tabelas:

Pessoas

PessoasIdosas
```
- id (PK)
- nome
- data_nascimento
- contato
- endereço
- outros campos relevantes
```

Dependentes
```
- id (PK)
- idoso_id (FK)
- nome
- grau_parentesco
- data_nascimento
```

ComposicoesFamiliares
```
- id (PK)
```

Enderecos
```
- id (PK)
```

Anexos
```
- id (PK)
```

As relações entre os idosos e seus dependentes são feitas por meio de chaves estrangeiras.
As tabelas encontram-se devidamente relacionadas, garantindo a integridade dos dados e a consistência das informações armazenadas.

## Futuras Melhorias e implementações

### Melhorias:

- Adicionar auditoria de dados
- Permitir cadastrar mais de um telefone
- Atualização automática do sistema
- Backup automático dos dados
- Integração com serviços de notificação e alertas
- Melhoria de interface gráfica
- Assinatura digital

### Implementações:

- Encaminhamentos
- Agendamento de visitas domiciliares
- Ligações
- Doações de kits alimentares
- Doações diversas
- Atendimentos

## Licença

Este projeto é de uso exclusivo da Associação Católica Sagrada Família.
Distribuição ou uso comercial não autorizados.