# 🗃️ Métodos de Inserção no MongoDB

Os métodos de inserção mais comuns são:

- `insertOne()` → insere um único documento  
- `insertMany()` → insere múltiplos documentos de uma vez

## 1️⃣ Inserindo um único documento (`insertOne`)

```js
db.personagens.insertOne({
    nome: "Bob Esponja",
    ocupacao: "Cozinheiro",
    local: "Restaurante Siri Cascudo",
    idade: 20
})
```

## 2️⃣ Inserindo múltiplos documentos (`insertMany`)

```js
db.personagens.insertMany([
    {
        nome: "Lula Molusco",
        ocupacao: "Atendente de Caixa",
        local: "Restaurante Siri Cascudo",
        idade: 45
    },
    {
        nome: "Patrick Estrela",
        ocupacao: "Desempregado",
        local: "Fenda do Biquíni",
        idade: 22
    },
    {
        nome: "Sandy Bochechas",
        ocupacao: "Cientista",
        local: "Domo de Vidro",
        idade: 25
    }
])
```

### 📌 Explicação rápida

- `db.<coleção>` → indica a coleção onde os documentos serão inseridos (ex.: `personagens`)  
- `insertOne()` → insere um objeto por vez  
- `insertMany([])` → insere um array com vários objetos  
- O MongoDB cria a coleção automaticamente na primeira inserção

---

# 🔍 Métodos de Leitura no MongoDB

A função principal para leitura é `find()`, com variações úteis.

## 1️⃣ Ler todos os documentos

```js
db.personagens.find()
```

## 2️⃣ Ler o primeiro documento encontrado

```js
db.personagens.findOne()
```

## 3️⃣ Filtrar por campo específico

Exemplo: encontrar todos que trabalham no Siri Cascudo:

```js
db.personagens.find({ local: "Restaurante Siri Cascudo" })
```

### 🔧 Operadores com `find()`

#### `.limit()`

Mostrar apenas 2 personagens:

```js
db.personagens.find().limit(2)
```

#### `$or`

Buscar quem trabalha no Siri Cascudo OU tem idade menor que 23:

```js
db.personagens.find({
    $or: [
        { local: "Restaurante Siri Cascudo" },
        { idade: { $lt: 23 } }
    ]
})
```

#### `$in`

Buscar personagens que moram no Siri Cascudo ou no Domo de Vidro:

```js
db.personagens.find({
    local: { $in: ["Restaurante Siri Cascudo", "Domo de Vidro"] }
})
```

#### `$lt`

Buscar personagens com idade menor que 25:

```js
db.personagens.find({
    idade: { $lt: 25 }
})
```

#### `$lte`

Buscar personagens com idade menor ou igual a 25:

```js
db.personagens.find({
    idade: { $lte: 25 }
})
```

---

# 🔧 Métodos de Atualização no MongoDB

## 1️⃣ `updateOne()`

Atualiza apenas o primeiro documento que corresponde ao filtro:

```js
db.personagens.updateOne(
    { nome: "Bob Esponja" },
    { $set: { ocupacao: "Gerente de Cozinha" } }
)
```

## 2️⃣ `updateMany()`

Atualiza todos os documentos que correspondem ao filtro:

```js
db.personagens.updateMany(
    { local: "Restaurante Siri Cascudo" },
    { $inc: { idade: 1 } }
)
```

## 3️⃣ `replaceOne()`

Substitui completamente um documento:

```js
db.personagens.replaceOne(
    { nome: "Patrick Estrela" },
    {
        nome: "Patrick Estrela",
        ocupacao: "Influencer Submarino",
        local: "Fenda do Biquíni",
        idade: 23
    }
)
```

> ⚠️ Campos não incluídos no novo documento serão removidos.

## 4️⃣ `findOneAndUpdate()`

Atualiza e retorna o documento (por padrão, o original):

```js
db.personagens.findOneAndUpdate(
    { nome: "Sandy Bochechas" },
    { $set: { ocupacao: "Inventora" } },
    { returnDocument: "after" }
)
```

---

# 🗑 Métodos de Remoção no MongoDB

## 1️⃣ `deleteOne()`

Remove o primeiro documento que corresponde ao filtro:

```js
db.personagens.deleteOne(
    { nome: "Lula Molusco" }
)
```

## 2️⃣ `deleteMany()`

Remove todos os documentos que correspondem ao filtro:

```js
db.personagens.deleteMany(
    { local: "Balde de Lixo" }
)
```

## 3️⃣ `findOneAndDelete()`

Remove e retorna o documento excluído:

```js
db.personagens.findOneAndDelete(
    { nome: "Plankton" }
)
```

---

### 📚 Fontes

- [MongoDB Shell - Run Commands](https://www.mongodb.com/pt-br/docs/mongodb-shell/run-commands/)
- [MongoDB Shell - Insert](https://www.mongodb.com/pt-br/docs/mongodb-shell/crud/insert/#std-label-mongosh-insert)
- [MongoDB Shell - Read](https://www.mongodb.com/pt-br/docs/mongodb-shell/crud/read/#std-label-mongosh-read)
- [MongoDB Shell - Update](https://www.mongodb.com/pt-br/docs/mongodb-shell/crud/update/#std-label-mongosh-update)
- [MongoDB Shell - Delete](https://www.mongodb.com/pt-br/docs/mongodb-shell/crud/delete/#std-label-mongosh-delete)

