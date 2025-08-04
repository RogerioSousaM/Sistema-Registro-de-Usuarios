# 🚀 Guia de Deploy - Sistema de Registro de Usuários

## Problemas Identificados e Soluções

### ❌ Problema Original: Erro 404 no Vercel
O erro `404: NOT_FOUND Code: NOT_FOUND ID: gru1::qxkmk-1754334081144-5d855448ded3` indica que o Vercel não conseguiu encontrar ou executar a aplicação corretamente.

### ✅ Soluções Implementadas

1. **Arquivo `vercel.json` criado**
   - Configuração específica para ASP.NET Core
   - Rotas para arquivos estáticos
   - Build configuration adequada

2. **Configuração de banco de dados flexível**
   - Suporte a banco em memória para desenvolvimento
   - Fallback quando string de conexão não está disponível
   - Tratamento de erros de conexão

3. **Arquivos de configuração atualizados**
   - `appsettings.Production.json` criado
   - `.gitignore` adequado
   - Dependências corrigidas

## 📋 Passos para Deploy

### 1. Preparação do Repositório
```bash
# Certifique-se de que todos os arquivos estão commitados
git add .
git commit -m "Configuração para deploy no Vercel"
git push origin main
```

### 2. Configuração no Vercel

#### Via Dashboard do Vercel:
1. Acesse [vercel.com](https://vercel.com)
2. Clique em "New Project"
3. Importe seu repositório GitHub
4. Configure as seguintes variáveis de ambiente:

```
ASPNETCORE_ENVIRONMENT=Production
ConnectionStrings__ConexaoPadrao=sua-string-de-conexao-aqui
```

#### Via CLI:
```bash
# Instale o Vercel CLI
npm i -g vercel

# Login no Vercel
vercel login

# Deploy
vercel --prod
```

### 3. Configuração do Banco de Dados

#### Opção A: Azure SQL Database (Recomendado)
1. Crie um servidor SQL no Azure Portal
2. Crie um banco de dados
3. Configure as regras de firewall (permitir 0.0.0.0/0 temporariamente)
4. Obtenha a string de conexão

#### Opção B: SQL Server Local (para teste)
Use a string de conexão atual para testes locais.

### 4. String de Conexão
```
Server=seu-servidor.database.windows.net; 
Initial Catalog=NovosFuncionarios; 
User Id=seu-usuario; 
Password=sua-senha; 
TrustServerCertificate=True
```

## 🔧 Configurações Específicas

### Variáveis de Ambiente no Vercel
- **ASPNETCORE_ENVIRONMENT**: Production
- **ConnectionStrings__ConexaoPadrao**: Sua string de conexão
- **DatabaseEnabled**: true (quando banco estiver configurado)

### Arquivos Importantes
- `vercel.json`: Configuração do Vercel
- `Program.cs`: Configuração da aplicação
- `appsettings.Production.json`: Configurações de produção
- `RegistrarUsuarios.csproj`: Dependências do projeto

## 🐛 Solução de Problemas

### Erro 404 Persistente
1. Verifique se o `vercel.json` está na raiz do projeto
2. Confirme se as variáveis de ambiente estão configuradas
3. Verifique os logs no dashboard do Vercel

### Problemas de Banco de Dados
1. Teste a string de conexão localmente
2. Verifique se o banco está acessível
3. Confirme as credenciais

### Problemas de Build
1. Verifique se todas as dependências estão no `.csproj`
2. Confirme se o .NET 8.0 está sendo usado
3. Verifique os logs de build no Vercel

## 📞 Suporte

Se ainda houver problemas:
1. Verifique os logs no dashboard do Vercel
2. Teste localmente com `dotnet run`
3. Verifique se o banco está funcionando

## ✅ Checklist de Deploy

- [ ] Arquivo `vercel.json` criado
- [ ] Variáveis de ambiente configuradas
- [ ] Banco de dados configurado
- [ ] String de conexão atualizada
- [ ] Repositório sincronizado
- [ ] Deploy executado
- [ ] Aplicação testada 