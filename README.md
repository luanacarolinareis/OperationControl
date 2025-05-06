# OperationControl  
Controlo de Procedimentos e Ferramentas em Ambiente Laboratorial

OperationControl é uma aplicação web desenvolvida para centralizar e otimizar o controlo dos procedimentos diários e a gestão de ferramentas em ambientes laboratoriais. O sistema permite rastrear a realização de etapas obrigatórias (como Kamishibai e check final), gerir o inventário de ferramentas por bancada e garantir a rastreabilidade e conformidade das operações, promovendo eficiência e segurança no ambiente de trabalho (a funcionalidade foi apenas parcialmente conseguida).

---

## ✨ Funcionalidades Principais

- **Autenticação de Utilizador**  
  - Login de utilizadores para garantir rastreabilidade e segurança das operações.

- **Verificação de Procedimentos**
  - Kamishibai: registo e confirmação da realização.
  - Check Final: validação do cumprimento de todos os procedimentos antes do encerramento do dia.
  - Relatório de não realização: registo de procedimentos não efetuados.

- **Gestão de Ferramentas e Bancadas**
  - Base de dados de bancadas e ferramentas associadas.
  - Picagem e verificação do estado das ferramentas (ok, ausente, danificada, ID incorreto).
  - Atualização automática do estado na base de dados.

- **Fluxo Operacional Web**
  - Páginas web encadeadas segundo o workflow operacional: login → seleção de bancada → verificação de procedimentos → picagem de ferramentas → relatório.

- **Rastreabilidade**
  - Histórico de operações e atualizações para auditoria.

---

## 🚀 Tecnologias Utilizadas

| Tecnologia     | Função                             |
| -------------- | --------------------------------- |
| ASP.NET        | Backend (Razor Pages)              |
| PostgreSQL     | Base de dados                      |
| HTML/CSS/JS    | Interface e lógica de frontend     |
| C#             | Lógica de aplicação                |

---

## 🛠️ Como Usar

1. Clone o repositório:
- git clone https://github.com/luanacarolinareis/OperationControl.git
- cd OperationControl

2. Configure a base de dados PostgreSQL e atualize as credenciais de conexão.
3. Abra a solução `OperationControl.sln` no Visual Studio.
4. Execute o projeto e aceda via browser.

---

## 🧩 Fluxo de Utilização

- **Login:**  
O utilizador autentica-se na aplicação.

- **Seleção de Bancada:**  
Seleciona a bancada onde irá operar.

- **Verificação de Procedimentos:**  
Confirma a realização do Kamishibai e do check final. Caso não tenha sido realizado, é solicitado o registo do motivo.

- **Picagem de Ferramentas:**  
O utilizador regista o estado de cada ferramenta associada à bancada (ok, ausente, danificada, ID incorreto).

- **Atualização e Relatório:**  
O sistema atualiza o estado das ferramentas e procedimentos na base de dados e gera relatórios de não conformidade quando necessário.

---

## 📋 Estrutura de Dados

**Bancadas:**

| deskID | checkFinal (bool) | kamishibai (bool) |
|--------|-------------------|-------------------|
| 1      | false             | true              |
| 2      | true              | false             |
| 3      | false             | false             |

**Ferramentas:**

| numero | deskID | numeroSerie | nome        | estado      |
|--------|--------|-------------|-------------|-------------|
| 1      | 1      | 13412       | Multímetro  | Ok          |
| 2      | 1      | 12678       | Osciloscópio| Ausente     |
| 3      | 3      | 31245       | Termómetro  | Danificado  |
| 4      | 2      | [null]      | Pilhas      | Ok          |

---

## 👥 Equipa

- Henrique Malva - Engenharia Eletrotécnica e de Computadores
- Gabriela Mendoza - Engenharia Informática
- José Dias - Engenharia Eletrotécnica e de Computadores
- Luana Reis - Engenharia Informática

---

## 📄 Documentação & Demonstração

- [Relatório do Projeto](Relatório-OperationControl.pdf)
- [Pitch de Apresentação](PTT-OperationControl.pdf)

---

## 📢 Contribuição

Contribuições são bem-vindas!  
Abra uma issue ou envie um pull request para sugerir melhorias.

---

> OperationControl - Eficiência, rastreabilidade e segurança no controlo de procedimentos laboratoriais.  
> **Bugs N' Roses Team**
