# Criptografia Assimétrica

Faz o uso de de duas chaves, a chave **pública**(que qualquer um pode ter acesso) e uma chave privada.
A Chave publica é usada para criptografar o dado e a privada para descriptografar.

![-](https://nordvpn.com/wp-content/uploads/2020/02/assymetric-encryption-1200x675-1.png)


## Assinatura Digital

Usado para valdiar é a mensagem não foi alterada no meio do caminho.
Fluxo:
1. - Fazer o Hash do documento e criptografar com a chave privada
1. - Mandar o documento junto com esse hash criptografado
1. - Receber o documento
1. - Fazer o Hash
1. - Descriptografar a assinatura enviada junto com o documento
1. - Verificar se a assinatura(hash) bate com o hash do documento que foi enviado


![-](https://cdn.comparitech.com/wp-content/uploads/2019/03/digital-signatures-2.jpg)


## RSA

É a forma de criptografia assimétrica mais utilizada do mundo, e seu nome é a primeira letra de seus criadores(Rivest-Shamir-Adleman)

## ECC - Elliptic Curve Cryptography

- Mais seguro que o RSA
- Mais performático
- Limitações de tamanho de texto, pouco usada.
