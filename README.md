
# Sistema de Registro de Usuários

Sistema web desenvolvido em ASP.NET Core para gerenciamento de funcionários.

## 🚀 Deploy no Vercel

### Pré-requisitos
- Conta no Vercel
- Banco de dados SQL Server (Azure SQL Database recomendado)
- Git configurado

### Passos para Deploy

1. **Configure o banco de dados:**
   - Crie um banco SQL Server (Azure SQL Database recomendado)
   - Atualize a string de conexão em `appsettings.Production.json`

2. **Configure as variáveis de ambiente no Vercel:**
   ```
   ASPNETCORE_ENVIRONMENT=Production
   ConnectionStrings__ConexaoPadrao=sua-string-de-conexao-aqui
   ```

3. **Deploy via Git:**
   ```bash
   # Conecte seu repositório ao Vercel
   vercel --prod
   ```

4. **Ou via GitHub:**
   - Conecte seu repositório GitHub ao Vercel
   - Configure as variáveis de ambiente no painel do Vercel
   - Faça push das alterações

### Configuração do Banco de Dados

1. **Azure SQL Database (Recomendado):**
   - Crie um servidor SQL no Azure
   - Crie um banco de dados
   - Configure as regras de firewall
   - Use a string de conexão fornecida pelo Azure

2. **String de Conexão:**
   ```
   Server=seu-servidor.database.windows.net; 
   Initial Catalog=NovosFuncionarios; 
   User Id=seu-usuario; 
   Password=sua-senha; 
   TrustServerCertificate=True
   ```

### Estrutura do Projeto

- **Controllers/**: Controladores da aplicação
- **Models/**: Modelos de dados
- **Views/**: Views Razor
- **Context/**: Contexto do Entity Framework
- **Migrations/**: Migrações do banco de dados

### Funcionalidades

- Login de usuários
- Cadastro de funcionários
- Listagem de funcionários
- Edição de funcionários
- Exclusão de funcionários

### Tecnologias Utilizadas

- ASP.NET Core 8.0
- Entity Framework Core
- SQL Server
- Bootstrap
- Razor Pages

### Solução de Problemas

**Erro 404 no Vercel:**
- Verifique se o arquivo `vercel.json` está presente
- Confirme se as variáveis de ambiente estão configuradas
- Verifique se a string de conexão está correta

**Problemas de Banco de Dados:**
- Confirme se o banco está acessível
- Verifique se as credenciais estão corretas
- Teste a conexão localmente primeiro

### Desenvolvimento Local

```bash
# Restaurar dependências
dotnet restore

# Executar migrações
dotnet ef database update

# Executar aplicação
dotnet run
```

### Contribuição

1. Faça um fork do projeto
2. Crie uma branch para sua feature
3. Commit suas mudanças
4. Push para a branch
5. Abra um Pull Request
