# Swatch ⌚

**Swatch** é uma aplicação web desenvolvida para gerenciar usuários e inscrições em cursos especializados em relógios. Utilizando o ambiente .NET, a aplicação oferece uma plataforma interativa para o registro, autenticação e gerenciamento de inscrições, além de permitir a exportação de dados.

## Visão Geral

O projeto **Swatch** é uma solução voltada para instituições ou indivíduos que desejam gerenciar cursos relacionados a relógios. A aplicação permite que os usuários se registrem, façam login, se inscrevam em cursos e exportem dados para análise. A interface é desenvolvida com HTML e CSS, enquanto o backend é implementado em C# com ASP.NET Web Forms. O banco de dados é gerenciado no SQL Server.

## Funcionalidades

- **Registro e Autenticação de Usuários**: Usuários podem criar contas e fazer login para acessar funcionalidades restritas.
- **Inscrição em Cursos**: Usuários registrados podem se inscrever em cursos especializados em relógios.
- **Exportação de Dados**: Permite a exportação de informações sobre usuários e inscrições em formatos adequados para análise.
- **Interface Intuitiva**: A aplicação possui uma interface limpa e consistente, desenvolvida usando HTML e CSS, com um layout unificado através de MasterPage.

## Como Utilizar  💻

1. **Iniciar a Aplicação**:
   - Acesse a aplicação através do link fornecido (ou abra o `index.html` no seu navegador).

2. **Registro e Login**:
   - Utilize a página de registro para criar uma nova conta.
   - Faça login usando suas credenciais para acessar áreas restritas da aplicação.

3. **Inscrição em Cursos**:
   - Navegue até a seção de cursos e escolha os cursos disponíveis.
   - Inscreva-se nos cursos de interesse.

4. **Exportação de Dados**:
   - Acesse a seção de exportação para gerar relatórios sobre usuários e inscrições.

## Recursos Técnicos

- **Tecnologias Utilizadas**: ASP.NET Web Forms, C#, SQL Server, HTML, CSS.
- **Backend**: Implementado em C# com ASP.NET Web Forms, gerenciando a lógica do servidor e interações com o banco de dados.
- **Banco de Dados**: SQL Server para armazenamento de informações sobre usuários e inscrições.
- **Frontend**: HTML e CSS para criar uma interface de usuário intuitiva e responsiva.

## Como Executar Localmente 💻

1. **Clone este repositório para o seu ambiente local**:

   ```bash
   git clone https://github.com/leticiaveigacs/Swatch/git
   ```

2. **Navegue até o diretório do projeto**:

   ```bash
   cd Swatch
   ```

3. **Configure o Ambiente .NET**:

   - Abra o projeto em um ambiente de desenvolvimento .NET como o Visual Studio.
   - Certifique-se de que o SQL Server está configurado e acessível.

4. **Configure o Banco de Dados**:

   - Importe o banco de dados `Swatch` para o SQL Server.
   - Certifique-se de que as tabelas `utilizadores` e os procedimentos armazenados `inserir_utilizadores` e `login` estão corretamente configurados.

5. **Execute a Aplicação**:

   - Inicie o servidor local através do Visual Studio.
   - Acesse a aplicação via navegador usando a URL local fornecida pelo ambiente de desenvolvimento.

## Agradecimentos

Este projeto foi desenvolvido para aprimorar habilidades em desenvolvimento web e gestão de dados. Agradecemos por explorar o **Swatch** e esperamos que seja uma ferramenta útil para gerenciamento de cursos e usuários. 🚀

