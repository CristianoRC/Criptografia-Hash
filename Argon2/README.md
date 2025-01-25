# Argon2 - Algoritmo de Hash de Senha

O Argon2 é um algoritmo de hash de senha moderno e altamente seguro, vencedor da competição Password Hashing Competition em 2015. Ele foi projetado especificamente para ser resistente a diversos tipos de ataques, incluindo ataques de hardware especializado.

## Variantes do Argon2

O Argon2 possui três variantes principais, cada uma com suas características específicas:

### Argon2d
- Maximiza a resistência contra ataques de GPU
- Acessa a matriz de memória de forma dependente dos dados
- Mais rápido e usa mais referências à memória
- Vulnerável a ataques de canal lateral baseados em tempo
- Recomendado para: Criptomoedas e aplicações que necessitam de máxima proteção contra ataques de GPU

### Argon2i
- Acessa a matriz de memória de forma independente dos dados
- Oferece proteção contra ataques de canal lateral
- Mais lento que o Argon2d
- Recomendado para: Hashing de senhas e derivação de chaves

### Argon2id (Utilizado neste exemplo)
- Híbrido entre Argon2i e Argon2d
- Primeira metade do processo usa Argon2i
- Segunda metade usa Argon2d
- Oferece o melhor dos dois mundos: boa resistência contra ataques de canal lateral e ataques de GPU
- Recomendado para: Uso geral e quando não há certeza sobre qual variante escolher

## Características Principais

### Parâmetros Configuráveis
- `SaltSize`: 16 bytes (128 bits) de salt aleatório
- `HashSize`: 32 bytes (256 bits) para o hash final
- `DegreeOfParallelism`: 4 threads para processamento paralelo
- `NumberOfIterations`: 20 iterações (o mínimo recomendado é 10)
- `MemorySize`: 256MB de memória (o mínimo recomendado é 64MB)

### Características de Segurança
- Uso de salt aleatório para prevenir ataques de tabela rainbow
- Consumo de memória configurável para dificultar ataques por hardware especializado
- Paralelização para melhor desempenho em CPUs modernas
- Número de iterações ajustável para controlar o custo computacional

## Como Funciona

### Processo de Hash
1. A senha é convertida em bytes usando UTF-8
2. Um salt aleatório é gerado
3. O algoritmo aplica várias transformações na senha usando os parâmetros configurados
4. O resultado final é um hash de tamanho fixo

### Verificação
1. Para verificar uma senha, o mesmo processo é repetido com os mesmos parâmetros e salt
2. Os hashes são comparados byte a byte
3. Apenas se todos os bytes forem idênticos a senha é considerada válida

## Recomendações de Uso
O Argon2 é recomendado para:
- Armazenamento seguro de senhas em bancos de dados
- Sistemas que necessitam de alta segurança
- Aplicações que podem ajustar os parâmetros de acordo com o hardware disponível

## Implementação
Este projeto utiliza a biblioteca `Konscious.Security.Cryptography.Argon2`, que é uma implementação segura e bem mantida para .NET.
