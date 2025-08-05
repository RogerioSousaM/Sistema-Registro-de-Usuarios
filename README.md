# 🏢 Sistema de Registro de Usuários

Sistema web desenvolvido em **ASP.NET Core** para gerenciamento completo de funcionários e controle de acesso.

## 📋 Descrição

O sistema foi desenvolvido para simplificar a vida do administrador, permitindo gerenciar as credenciais e acessos dos funcionários de forma rápida e segura. Oferece uma interface intuitiva para cadastro, edição, visualização e remoção de funcionários.

## ✨ Funcionalidades Principais

### 🔐 **Sistema de Autenticação**
- Login seguro com hash SHA256
- Controle de acesso por usuário
- Sessões seguras

### 👥 **Gestão de Funcionários**
- ✅ **Cadastro** de novos funcionários
- ✅ **Edição** de dados existentes
- ✅ **Visualização** de lista completa
- ✅ **Exclusão** de registros
- ✅ **Busca** e filtros

### 📊 **Campos Gerenciados**
- Nome completo
- Email corporativo
- Cargo/Função
- Departamento
- Senha de email
- Tipo de acesso
- Senha do sistema

### 🛡️ **Segurança**
- Validação de dados obrigatórios
- Hash de senhas com SHA256
- Controle de acesso por sessão
- Feedback claro de sucesso/erro

## 🛠️ Tecnologias Utilizadas

- **Backend:** ASP.NET Core 8.0
- **ORM:** Entity Framework Core
- **Banco de Dados:** SQL Server
- **Frontend:** Razor Pages + Bootstrap
- **Autenticação:** Hash SHA256
- **IDE:** Visual Studio 2022

## 🚀 Como Executar o Projeto

### Pré-requisitos
- .NET 8.0 SDK
- SQL Server (Express ou superior)
- Visual Studio 2022 (recomendado)

### 1. **Clone o repositório**
```bash
git clone https://github.com/RogerioSousaM/Sistema-Registro-de-Usuarios.git
cd Sistema-Registro-de-Usuarios
```

### 2. **Configure o banco de dados**
```bash
# Restaurar dependências
dotnet restore

# Aplicar migrações (cria o banco automaticamente)
dotnet ef database update
```

### 3. **Execute o projeto**
```bash
dotnet run
```

### 4. **Acesse a aplicação**
- **URL:** `http://localhost:5000`
- **Usuário:** `admin`
- **Senha:** `admin`

## 📁 Estrutura do Projeto

```
Sistema-Registro-de-Usuarios/
├── Controllers/             # Controladores MVC
│   ├── HomeController.cs    # Controlador principal
│   └── FuncionarioController.cs # CRUD de funcionários
├── Models/                  # Modelos de dados
│   ├── Funcionario.cs       # Modelo de funcionário
│   ├── Login.cs            # Modelo de autenticação
│   └── ErrorViewModel.cs    # Modelo de erro
├── Views/                   # Views Razor
│   ├── Home/               # Views da página inicial
│   ├── Funcionario/        # Views de funcionários
│   └── Shared/             # Layouts compartilhados
├── Context/                 # Contexto do Entity Framework
│   └── NovoFuncionario.cs   # DbContext
├── Migrations/              # Migrações do banco
├── wwwroot/                 # Arquivos estáticos
└── Program.cs               # Ponto de entrada
```

## 🔧 Configuração do Banco de Dados

### String de Conexão
```json
{
  "ConnectionStrings": {
    "ConexaoPadrao": "Server=localhost\\sqlexpress; Initial Catalog=NovosFuncionarios; Integrated Security=True; TrustServerCertificate=True"
  }
}
```

### Tabelas Criadas
- **Funcionarios:** Dados dos funcionários
- **Logins:** Credenciais de acesso

## 👤 Dados de Teste

Após executar as migrações, você terá:

### Usuário Administrador
- **Usuário:** `admin`
- **Senha:** `admin`

### Funcionário de Exemplo
- **Nome:** João Silva
- **Email:** joao.silva@empresa.com
- **Cargo:** Desenvolvedor
- **Departamento:** TI

## 🐛 Solução de Problemas

### Erro de Conexão com Banco
```bash
# Verificar se o SQL Server está rodando
sqlcmd -S localhost\sqlexpress -E -Q "SELECT @@VERSION"

# Recriar banco se necessário
dotnet ef database drop
dotnet ef database update
```

### Erro de Build
```bash
# Limpar cache
dotnet clean
dotnet restore
dotnet build
```

## 📝 Comandos Úteis

```bash
# Executar aplicação
dotnet run

# Executar em modo watch (desenvolvimento)
dotnet watch run

# Criar nova migração
dotnet ef migrations add NomeDaMigracao

# Aplicar migrações
dotnet ef database update

# Remover migração
dotnet ef migrations remove
```

## 🤝 Contribuição

1. Faça um fork do projeto
2. Crie uma branch para sua feature (`git checkout -b feature/AmazingFeature`)
3. Commit suas mudanças (`git commit -m 'Add some AmazingFeature'`)
4. Push para a branch (`git push origin feature/AmazingFeature`)
5. Abra um Pull Request

## 📄 Licença

Este projeto está sob a licença MIT. Veja o arquivo [LICENSE](LICENSE) para mais detalhes.

## 👨‍💻 Autor

**Rogério Sousa**
- GitHub: [@RogerioSousaM](https://github.com/RogerioSousaM)

## 📞 Suporte

Se você encontrar algum problema ou tiver dúvidas:
1. Verifique a seção de [Solução de Problemas](#-solução-de-problemas)
2. Abra uma [Issue](https://github.com/RogerioSousaM/Sistema-Registro-de-Usuarios/issues)
3. Entre em contato através do GitHub

---

⭐ **Se este projeto foi útil para você, considere dar uma estrela no repositório!**
