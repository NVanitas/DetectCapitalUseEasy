# DetectCapital - C# Solution

Este repositório contém a solução para o problema **Detect Capital** do LeetCode, implementado em C#.

## Descrição do Problema

O uso de maiúsculas em uma palavra é considerado correto se uma das seguintes condições for verdadeira:

1. Todas as letras são maiúsculas (ex: "USA").
2. Todas as letras são minúsculas (ex: "leetcode").
3. Apenas a primeira letra é maiúscula (ex: "Google").

Dado uma string `word`, o método retorna `true` se a capitalização for válida, caso contrário, retorna `false`.

## Implementação

A solução utiliza um loop para verificar se todas as letras são maiúsculas, minúsculas ou se apenas a primeira é maiúscula.

```csharp
public class Solution {
    public bool DetectCapitalUse(string word) {
        bool allUpper = true, allLower = true, firstUpperRestLower = true;

        for (int i = 0; i < word.Length; i++) {
            if (!char.IsUpper(word[i])) allUpper = false;
            if (!char.IsLower(word[i])) allLower = false;
            if (i > 0 && char.IsUpper(word[i])) firstUpperRestLower = false;
        }

        return allUpper || allLower || firstUpperRestLower;
    }
}
```

## Exemplo de Entrada e Saída

| Entrada    | Saída   |
| ---------- | ------- |
| "USA"      | `true`  |
| "FlaG"     | `false` |
| "Google"   | `true`  |
| "leetcode" | `true`  |

## Contato

Criado por **Nicolas da Silva Santos**\
📧 Email: [nicolasdasilvasantos04@gmail.com](mailto\:nicolasdasilvasantos04@gmail.com)\
🔗 [LinkedIn](https://linkedin.com/in/nicolasdasilvasantos/)\
🔗 [GitHub](https://github.com/NVanitas/)

