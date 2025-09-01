# Aggregation pipeline

Um aggregation pipeline possui um ou mais estágios que processam documentos:

- Cada estágio executa uma operação nos documentos de entrada. Por exemplo, um estágio pode filtrar documentos, agrupar documentos e calcular valores.

- Os documentos vão de um estágio para outro.

- Um aggregation pipeline pode retornar resultados para grupos de documentos. Por exemplo, retornar o valor total, médio, máximo e mínimo.

Aqui estão os **estágios mais utilizados**, com exemplos simples e práticos:

---

## 🔹 `$match` — Filtra documentos (como um `WHERE` no SQL)

```js
{ $match: { tipo: "Fogo" } }
```

👉 Seleciona apenas os documentos onde o campo `tipo` é `"Fogo"`.

---

## 🔹 `$project` — Seleciona e transforma campos

```js
{ $project: { nome: 1, nivel: 1, _id: 0 } }
```

👉 Exibe apenas os campos `nome` e `nivel`, ocultando o `_id`.

---

## 🔹 `$group` — Agrupa documentos e aplica agregações

```js
{
  $group: {
    _id: "$tipo",
    mediaNivel: { $avg: "$nivel" },
    total: { $sum: 1 }
  }
}
```

👉 Agrupa por `tipo`, calcula a média de `nivel` e conta quantos Pokémon há de cada tipo.

---

## 🔹 `$sort` — Ordena os documentos

```js
{ $sort: { nivel: -1 } }
```

👉 Ordena os documentos por `nivel` de forma decrescente.

---

## 🔹 `$limit` — Limita o número de documentos

```js
{ $limit: 5 }
```

👉 Retorna apenas os **5 primeiros** documentos após o estágio anterior.

---

## 🔹 `$skip` — Pula um número de documentos

```js
{ $skip: 10 }
```

👉 Ignora os **10 primeiros** documentos.

---

## 🔹 `$unwind` — Desestrutura arrays em múltiplos documentos

```js
{ $unwind: "$habilidades" }
```

👉 Se um Pokémon tem várias habilidades, cria um documento separado para cada uma.

---

## 🔹 Exemplo completo de pipeline

```js
db.pokemon.aggregate([
  { $match: { tipo: "Água", nivel: { $gte: 20 } } },
  { $project: { nome: 1, nivel: 1, _id: 0 } },
  { $sort: { nivel: -1 } },
  { $limit: 3 }
])
```

🎯 Esse pipeline:
- Filtra Pokémon do tipo Água com nível ≥ 20
- Exibe apenas nome e nível
- Ordena por nível decrescente
- Retorna os 3 mais fortes

---

# Operadores de Agregação
Os operadores como $sum, $max, $min, $avg são chamados de operadores de agregação no MongoDB. Eles são usados principalmente dentro do estágio $group da aggregation pipeline para realizar cálculos sobre grupos de documentos.

---

## 🔧 Principais operadores de agregação

| Operador | Função | Exemplo |
|----------|--------|---------|
| `$sum`   | Soma valores ou conta documentos | `{ $sum: "$nivel" }` ou `{ $sum: 1 }` |
| `$avg`   | Calcula a média | `{ $avg: "$nivel" }` |
| `$max`   | Retorna o maior valor | `{ $max: "$nivel" }` |
| `$min`   | Retorna o menor valor | `{ $min: "$nivel" }` |
| `$count` | Conta documentos (fora do `$group`) | `{ $count: "total" }` |

---

### 🔢 1. Soma total dos níveis por nome do Pokémon
```js
db.pokemon.aggregate([
  {
    $group: {
      _id: "$nome",
      totalNivel: { $sum: "$nivel" }
    }
  }
])
```
💡 *Agrupa por nome e soma os níveis — útil se houver Pokémon repetidos com diferentes níveis.*

---

### 📈 2. Nível máximo por tipo
```js
db.pokemon.aggregate([
  {
    $group: {
      _id: "$tipo",
      nivelMaximo: { $max: "$nivel" }
    }
  }
])
```
💡 *Mostra o Pokémon de maior nível dentro de cada tipo (como Fogo, Água, etc.).*

---

### 📉 3. Nível mínimo por tipo
```js
db.pokemon.aggregate([
  {
    $group: {
      _id: "$tipo",
      nivelMinimo: { $min: "$nivel" }
    }
  }
])
```
💡 *Revela o Pokémon mais fraco em cada tipo.*

---

### 📊 4. Média dos níveis por tipo
```js
db.pokemon.aggregate([
  {
    $group: {
      _id: "$tipo",
      mediaNivel: { $avg: "$nivel" }
    }
  }
])
```
💡 *Calcula a média de nível por tipo — ótimo para comparar o poder médio de cada categoria.*

<br>

## Usando $match para aplicar filtros antes de agrupar


### 🔢 1. Soma dos níveis **somente dos Pokémon do tipo "Fogo"**
```js
db.pokemon.aggregate([
  { $match: { tipo: "Fogo" } },
  {
    $group: {
      _id: "$nome",
      totalNivel: { $sum: "$nivel" }
    }
  }
])
```
🔥 *Filtra apenas os Pokémon do tipo Fogo antes de somar os níveis por nome.*

---

### 📈 2. Nível máximo **dos Pokémon com nível acima de 50**
```js
db.pokemon.aggregate([
  { $match: { nivel: { $gt: 50 } } },
  {
    $group: {
      _id: "$tipo",
      nivelMaximo: { $max: "$nivel" }
    }
  }
])
```
⚡ *Considera apenas Pokémon com nível maior que 50 para encontrar o máximo por tipo.*

---

### 📉 3. Nível mínimo **dos Pokémon que têm "Veneno" como tipo**
```js
db.pokemon.aggregate([
  { $match: { tipo: /Veneno/ } },
  {
    $group: {
      _id: "$tipo",
      nivelMinimo: { $min: "$nivel" }
    }
  }
])
```
🧪 *Usa uma expressão regular para pegar qualquer tipo que contenha "Veneno".*

---

### 📊 4. Média dos níveis **dos Pokémon com nível entre 10 e 40**
```js
db.pokemon.aggregate([
  { $match: { nivel: { $gte: 10, $lte: 40 } } },
  {
    $group: {
      _id: "$tipo",
      mediaNivel: { $avg: "$nivel" }
    }
  }
])
```
📉 *Filtra Pokémon com nível entre 10 e 40 antes de calcular a média por tipo.*

---

# Operadores de comparação
Os operadores de comparação no MongoDB são usados para comparar valores em consultas e pipelines de agregação. Eles são essenciais para filtrar documentos com base em condições específicas — como maior que, menor que, igual, diferente, etc.


## 🔍 Principais operadores de comparação

| Operador | Significado | Exemplo | Resultado |
|----------|-------------|---------|-----------|
| `$eq`    | Igual a      | `{ nivel: { $eq: 50 } }` | Nível **igual a 50** |
| `$ne`    | Diferente de | `{ tipo: { $ne: "Normal" } }` | Tipo **diferente de "Normal"** |
| `$gt`    | Maior que    | `{ nivel: { $gt: 30 } }` | Nível **maior que 30** |
| `$gte`   | Maior ou igual| `{ nivel: { $gte: 30 } }` | Nível **maior ou igual a 30** |
| `$lt`    | Menor que    | `{ nivel: { $lt: 20 } }` | Nível **menor que 20** |
| `$lte`   | Menor ou igual| `{ nivel: { $lte: 20 } }` | Nível **menor ou igual a 20** |
| `$in`    | Está em uma lista | `{ tipo: { $in: ["Fogo", "Água"] } }` | Tipo **Fogo ou Água** |
| `$nin`   | Não está na lista | `{ tipo: { $nin: ["Fantasma", "Sombrio"] } }` | Tipo **não é Fantasma nem Sombrio** |

---

### 🔹 `$gte` — *Greater Than or Equal* (maior ou igual)
```js
{ nivel: { $gte: 30 } }
```
👉 Retorna documentos onde o campo `nivel` é **maior ou igual a 30**.

---

### 🔹 `$lte` — *Less Than or Equal* (menor ou igual)
```js
{ nivel: { $lte: 20 } }
```
👉 Retorna documentos onde o campo `nivel` é **menor ou igual a 20**.

---

### 🔹 `$gt` — *Greater Than* (maior que)
```js
{ nivel: { $gt: 50 } }
```
👉 Retorna documentos com `nivel` **estritamente maior que 50**.

---

### 🔹 `$lt` — *Less Than* (menor que)
```js
{ nivel: { $lt: 10 } }
```
👉 Retorna documentos com `nivel` **estritamente menor que 10**.

---

### 🔹 `$eq` — *Equal* (igual)
```js
{ tipo: { $eq: "Fogo" } }
```
👉 Retorna documentos onde `tipo` é **exatamente "Fogo"**.

---

### 🔹 `$ne` — *Not Equal* (diferente)
```js
{ tipo: { $ne: "Água" } }
```
👉 Retorna documentos onde `tipo` **não é "Água"**.

---

### 🔹 Combinação de operadores
Você pode combinar vários operadores para criar filtros mais precisos:

```js
{ nivel: { $gte: 20, $lte: 50 } }
```
🎯 Isso retorna Pokémon com nível **entre 20 e 50**, inclusive.

---

### 🧠 Exemplo em agregação
```js
db.pokemon.aggregate([
  {
    $match: {
      nivel: { $gte: 10, $lte: 40 },
      tipo: { $ne: "Normal" }
    }
  },
  {
    $group: {
      _id: "$tipo",
      mediaNivel: { $avg: "$nivel" }
    }
  }
])
```
💡 Aqui estamos filtrando Pokémon com nível entre 10 e 40 **que não sejam do tipo "Normal"**, e depois agrupando por tipo para calcular a média de nível.

---

# Operadores Lógicos:
São usados para combinar ou inverter condições em consultas e pipelines de agregação. Eles permitem criar filtros mais sofisticados e flexíveis, especialmente quando você precisa testar múltiplas condições ao mesmo tempo.


## 🔧 Principais operadores lógicos

| Operador | Função | Exemplo | Resultado |
|----------|--------|---------|-----------|
| `$and`   | Todas as condições devem ser verdadeiras | `{ $and: [ { tipo: "Fogo" }, { nivel: { $gte: 30 } } ] }` | Tipo Fogo **e** nível ≥ 30 |
| `$or`    | Pelo menos uma condição deve ser verdadeira | `{ $or: [ { tipo: "Água" }, { tipo: "Gelo" } ] }` | Tipo Água **ou** Gelo |
| `$nor`   | Nenhuma das condições pode ser verdadeira | `{ $nor: [ { tipo: "Fantasma" }, { tipo: "Sombrio" } ] }` | Exclui Fantasma **e** Sombrio |
| `$not`   | Inverte uma condição | `{ nivel: { $not: { $lte: 20 } } }` | Nível **não menor ou igual** a 20 |

---
## 🔹 `$and` — Todas as condições devem ser verdadeiras

```js
{
  $and: [
    { tipo: "Fogo" },
    { nivel: { $gte: 30 } }
  ]
}
```

👉 Retorna Pokémon do tipo **Fogo** com **nível maior ou igual a 30**.

---

## 🔹 `$or` — Pelo menos uma condição deve ser verdadeira

```js
{
  $or: [
    { tipo: "Água" },
    { tipo: "Gelo" }
  ]
}
```

👉 Retorna Pokémon que sejam do tipo **Água** ou **Gelo**.

---

## 🔹 `$nor` — Nenhuma das condições pode ser verdadeira

```js
{
  $nor: [
    { tipo: "Fantasma" },
    { tipo: "Sombrio" }
  ]
}
```

👉 Exclui Pokémon dos tipos **Fantasma** e **Sombrio**.

---

## 🔹 `$not` — Inverte uma condição

```js
{
  nivel: { $not: { $lte: 20 } }
}
```

👉 Retorna Pokémon com nível **maior que 20**, usando negação lógica.

---

## 🔹 Combinação com operadores de comparação

```js
{
  $and: [
    { nivel: { $gte: 10, $lte: 50 } },
    { tipo: { $ne: "Normal" } }
  ]
}
```

🎯 Retorna Pokémon com nível entre **10 e 50**, **excluindo** os do tipo **Normal**.

---

