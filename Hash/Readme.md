# Hash

É uma função que recebe uma quantidade de bits variáveis e retorna uma outra quantidade de bits de tamanho fixo(digest), e importante, essa função de hash são funções sem volta! Se você tiver a saída nas mãos não conseguirá ter o resultado inicial.

Principais usos:

## Exemplo:

Pense em uma função de hash(uma função matemática) em que seu papel e ter de entrada um número inteiro, e retornar outro numero, que no nosso caso é o resto da divisão por **4**.

`F(X) => X %4`

Vamos ver quais os resultados com diferentes entradas no valor de X

| X | Digest  |
|---|---|
| 4 | 0 |
| 35 | 3 |
| 48 | 0 |
| 77 | 1 |

Nesse caso podemos ver que tendo a hash(digest) com valor **Zero** não conseguimos chegar no valor inicial. Claro esse é um exemplo mais básico de como funciona hash, os algoritmos mais comuns são bem mas complexos que isso, e ajudam a ter uma menor colisão de hash(digest).