Claro, Erasmo! Aqui está o conteúdo formatado em **Markdown**, organizado em seções para facilitar a leitura e o uso como guia prático:

---

# 📚 Introdução ao MongoDB e Banco de Dados NoSQL

Durante o módulo ministrado pela professora **Pâmela Borges**, percebi que as aulas foram gravadas há algum tempo. Por isso, reuni aqui os links e comandos atualizados que utilizei para acompanhar as aulas. Espero que te ajude também!

---

## 🐳 Docker: Instalação e Criação de Contêiner

### 1. O que é Docker, como instalar e criar contêiner

- 📥 [Download Docker Desktop](https://docs.docker.com/desktop/setup/install/windows-install/)
- ▶️ [Tutorial de instalação (YouTube - Celke)](https://www.youtube.com/watch?v=SIpY5PZ9PBQ&ab_channel=Celke)

### 2. Iniciar Docker manualmente (caso não inicie com o Windows)

```powershell
Start-Process "C:\Program Files\Docker\Docker\Docker Desktop.exe"
```

---

## 📝 Editor VIM

### 3. Instalar o VIM (usado para editar `docker-compose.yml`)

- 📥 [Download VIM v9.1](https://www.vim.org/downloads/gvim_9.1.0821_x64.exe)
- ▶️ [Tutorial de instalação (YouTube - HashLDash)](https://www.youtube.com/watch?v=bzVfS3GKgjM&ab_channel=HashLDash)
- 📁 Caminho para variáveis de ambiente:  
  `C:\Program Files\Vim\vim91`
- 📘 [Manual do VIM (YouTube)](https://www.youtube.com/watch?v=95Fzh-HveQg&ab_channel=HashLDash)

---

## ⚙️ Criando e Editando `docker-compose.yml`

### 4. Criar arquivo com VIM

1. Crie uma pasta onde será armazenado o arquivo e o contêiner  
2. Abra o terminal na pasta  
3. Digite:

```bash
vim docker-compose.yml
```

4. Pressione `i` para entrar no modo de edição (`--INSERT--` aparecerá no terminal)

### 5. Conteúdo do arquivo `docker-compose.yml`

```yaml
version: "2.29"

services:
  db:
    image: mongo
    container_name: db
    restart: always
    environment:
      MONGO_INITDB_ROOT_USERNAME: dio
      MONGO_INITDB_ROOT_PASSWORD: dio
    ports:
      - "27017:27017"
    volumes:
      - ./dbdata:/data/db
```

Para salvar e sair: pressione `Esc`, digite `:wq` e pressione `Enter`.

---

## 🚀 Executando o MongoDB com Docker

### 7. Criar imagem e contêiner

```bash
docker-compose up -d
```

### 8. Verificar contêiner rodando

```bash
docker container ps
```

---

## 🧠 Conectando ao MongoDB

### 9. Instalar MongoDB Shell (versão atual usa `mongosh`)

- 📥 [Download MongoDB Shell](https://www.mongodb.com/try/download/shell)

### 10. Conectar ao MongoDB no contêiner

```bash
mongosh --host 127.0.0.1:27017 -u dio -p dio
```

---

## 🧪 Usando o Robomongo (Studio 3T)

- 📥 [Download Studio 3T Community Edition](https://robomongo.org/download.php)

### Passos:

1. Abra o Studio 3T  
2. Vá em **Connect > New Connection**  
3. Cole a URI:

```bash
mongodb://dio:dio@127.0.0.1:27017/?authSource=admin
```

4. Dê um nome à conexão em **Connection name**  
5. Clique em **Save**  
6. Selecione a conexão e clique em **Connect**

---

## ☁️ MongoDB Cloud (Atlas)

### 1. Criar conta e novo cluster

- 🌐 [MongoDB Atlas](https://www.mongodb.com/products/platform/atlas-database)

### 2. Conectar ao cluster via terminal

```bash
mongosh "mongodb+srv://<seu cluster aqui>" --username dio --password dio
```

---

## 🧭 MongoDB Compass

- 📥 [Download MongoDB Compass](https://www.mongodb.com/try/download/compass)

### Passos:

1. Abra o programa  
2. Clique em **+ New Connection**  
3. Cole a URI:

```bash
mongodb://dio:dio@127.0.0.1:27017/?authSource=admin
```

4. Clique em **Save & Connect**

---

Se quiser, posso transformar esse conteúdo em um guia interativo ou te ajudar a automatizar esses passos com scripts. Quer seguir por esse caminho?
