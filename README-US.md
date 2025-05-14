<div align="center">
	<img src="./Resources/asfa-logo.png" alt="ASFA" widthwidth="250" height="250" />
	<h1>ASFA - Associação Católica Sagrada Família</h1>
	<a href="./README.md">[🇧🇷]</a>
</div>

## About the Project

ASFA is a desktop application developed in C# using Windows Forms with integration to the Supabase database.

The system's objective is to facilitate the control of elderly people who attend the Sagrada Família Catholic Association, allowing the registration of their personal information, data of their dependents, and the generation of PDF reports for documentation and printing purposes.

[Download the latest version here](https://github.com/LucasCoelhoSantos/ASFA/releases/latest)

## Features

- Registration of elderly people with detailed information;
- Registration of dependents linked to elderly people;
- Consultation, updating and deactivation of records;
- Exportation of data in PDF format for printing;
- Easy-to-use interface.

## Technologies Used

- Language: C# (.NET Framework)
- Graphical Interface: Windows Forms
- Database: Supabase (PostgreSQL)
- PDF Generation: ReportViewer
- ORM/Connection: Npgsql (PostgreSQL driver for C#)
- CEP Webservice: ViaCep

## Requirements

- Computer with internet connection;
- Computer with Windows 10 or higher installed.

## Estrutura do Projeto

```
/ASFA
  /Forms             -> System screens (registration, query, etc.)
  /Helpers           -> Helpers functions
  /Models            -> Entity classes
  /Reports           -> Report models
  /Repositories      -> Data persistence layer
  /Services          -> Application business rule
  /Resources         -> Images to use in the application
  Program.cs         -> Application initialization
  App.config         -> Connection settings
  appsettings.json   -> Connection strings
  client_secret.json -> Google Cloud Console configuration file
```

> [!IMPORTANT]  
> The connection settings ```appsettings.json``` and ```client_secret.json``` must be obtained from the target Supabase.

## Available Screens

The system currently has the following screens implemented:

1. Login and User Registration Screen:
Allows user authentication and registration of new accesses to the system.

2. Elderly People Menu:
Main screen for managing records. Allows viewing, adding, editing or deactivating records of elderly people.

3. Elderly People Registration:
Form for entering or editing data on elderly people, such as full name, date of birth, contact details, address, among other relevant fields.

4. Dependent Registration:
Specific form for registering dependents associated with elderly people, containing information such as name, degree of kinship and date of birth.

## How to Run

1. Clone the repository:
```
git clone https://github.com/lucas-coelho-santos/asfa.git
```
2. Open the project in Visual Studio.
3. Configure the App.config file with your Supabase credentials.
4. Restore the required NuGet packages:
    - Npgsql
    - (PDF library)
    - (Others that are used)
5. Compile and run the project.

## Database

Supabase is configured with the following main tables:

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

Relationships between seniors and their dependents are made through foreign keys.
The tables are properly related, ensuring data integrity and consistency of stored information.

## Future Improvements and Implementations

### Improvements:

- Add data auditing
- Allow registering more than one phone
- Automatic system update
- Automatic data backup
- Integration with notification and alert services
- Improvement of graphical interface
- Digital signature

### Implementations:

- Referrals
- Scheduling of home visits
- Calls
- Donations of food kits
- Miscellaneous donations
- Services

## License

This project is for the exclusive use of the Sagrada Família Catholic Association.
Distribution or commercial use is not authorized.