# BCrypt

BCrypt é um algoritmo de hash de senha projetado por Niels Provos e David Mazières, baseado no cifrador Blowfish. É uma função de hash adaptativa, o que significa que pode ser ajustada para permanecer segura mesmo com o aumento do poder computacional.

## Características principais:

- **Salt automático**: BCrypt gera e armazena automaticamente um salt único para cada hash
- **Função adaptativa**: Permite ajustar o "custo" computacional através do fator de trabalho
- **Resistente a ataques**: Projetado para ser lento em hardware, dificultando ataques de força bruta
- **Formato do hash**: Inclui todas as informações necessárias para verificação (versão, custo, salt e hash)

## Estrutura do hash BCrypt:

Um hash BCrypt tem o seguinte formato: `$2a$11$./V/gk0XLpMKk1.2IlOcLe9GvP2jnS66snA1JXvICFVOP6yW.zgAG`

Onde:
- `$2a$` - Identificador da versão do algoritmo
- `11` - Fator de custo (work factor)
- `./V/gk0XLpMKk1.2IlOcLe` - Salt (22 caracteres)
- `9GvP2jnS66snA1JXvICFVOP6yW.zgAG` - Hash da senha

## Exemplo de uso:

O exemplo neste projeto demonstra:
1. Como gerar um hash BCrypt de uma senha
2. Como verificar se uma senha corresponde a um hash existente

O BCrypt é amplamente utilizado para armazenamento seguro de senhas em bancos de dados. 