## 🧠 O que é um índice?

Imagine uma estante com milhares de livros. Sem índice, você teria que abrir cada livro para achar o autor. Com um índice, você vai direto ao livro certo. No MongoDB, funciona igual: o índice acelera buscas em campos específicos.

---

## ⚡ Exemplo 1: Busca sem índice

Suponha que você tenha uma coleção chamada `users` com milhares de documentos:

```js
db.users.insertMany([
  { name: "Alice", age: 28 },
  { name: "Bob", age: 35 },
  { name: "Charlie", age: 42 },
  // ... muitos outros
])
```

Agora você quer buscar usuários com idade acima de 30:

```js
db.users.find({ age: { $gt: 30 } })
```

Sem índice, o MongoDB vai verificar **cada documento** da coleção — isso é chamado de **scan completo**.

---

## 🚀 Exemplo 2: Criando um índice para melhorar a performance

Vamos criar um índice no campo `age`:

```js
db.users.createIndex({ age: 1 })
```

Agora, ao fazer a mesma busca:

```js
db.users.find({ age: { $gt: 30 } }).explain("executionStats")
```

Você verá que o MongoDB usou o índice, e a consulta foi muito mais rápida. O método `.explain("executionStats")` mostra detalhes da execução, como número de documentos examinados e tempo gasto.

---

## 📊 Exemplo 3: Ordenação com índice

Se você quiser ordenar os usuários por idade:

```js
db.users.find().sort({ age: 1 })
```

Sem índice, essa ordenação pode ser lenta. Com o índice em `age`, o MongoDB já tem os dados organizados e entrega o resultado rapidamente.

---

## 🧩 Índices compostos

Se você sempre busca por `name` e `age` juntos:

```js
db.users.find({ name: "Alice", age: 28 })
```

Você pode criar um índice composto:

```js
db.users.createIndex({ name: 1, age: 1 })
```

Isso melhora ainda mais a performance para consultas que usam ambos os campos.

---

## 🧼 Dica final: não exagere!

Criar muitos índices pode **pesar no armazenamento** e **deixar as inserções mais lentas**. Use índices com sabedoria, focando nas consultas mais frequentes.
