
# Sistema de Registro de Usuários

**Descrição**

O sistema foi desenvolvido para simplificar a vida do administrador, permitindo gerenciar as credenciais e acessos dos funcionários de forma rápida e segura.

## Funcionalidades Principais

- **Login Seguro**: Autenticação com hash de senha utilizando SHA256.
- **Gestão de Funcionários**: Criação, edição, visualização e remoção de funcionários, atribuição de cargos, departamentos e tipos de acesso personalizados.
- **Níveis de Acesso**: Diferentes permissões para acesso à rede, VPN e sistemas internos.
- **Validação de Dados**: Campos obrigatórios e validação para garantir informações corretas e seguras.
- **Feedback ao Usuário**: Mensagens claras de sucesso e erro durante as interações no sistema.

## Tecnologias Utilizadas

- Entity Framework
- C#
- .NET
- SQL Server

## Como Executar o Projeto

1. **Clone este repositório:**
   ```bash
   git clone https://github.com/RogerioSousaM/Sistema-Registro-de-Usuarios.git
   ```

2. **Navegue até o diretório do projeto:**
   ```bash
   cd Sistema-Registro-de-Usuarios
   ```

3. **Restaure as dependências:**
   ```bash
   dotnet restore
   ```

4. **Execute o projeto:**
   ```bash
   dotnet watch run
   ```

## Contribuições

Contribuições são bem-vindas! Sinta-se à vontade para abrir issues ou enviar pull requests.
