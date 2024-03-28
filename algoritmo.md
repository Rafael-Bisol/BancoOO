# PASSO 1

ao criar a conta, perguntar se o usuário quer que seja informado o saldo inicial
depois disso fazer um depósito e um saque

## conta bancária
        precisa ser iniciada com:
    nome do titular -> pode mudar
    número da conta -> não pode mudar
    depósito inicial -> pode ser qualquer valor a partir de 0

## saldo
    o saldo não pode ser mudado diretamente, só através de saques e depósitos
        saques tem taxa de 5 verdinhas por operação
        -> a conta pode ficar com saldo negativo se o saldo não for suficiente
            para pagar a taxa

---
# PASSO 2

## MAIN
1. pedir nome, número da conta e depósito inicial
2. criar a conta do banco (objeto Conta, variável conta)
3. perguntar se deseja ser informado do saldo inicial, caso sim, informe
4. realize um depósito
5. realize um saque

## CONTA
1. propriedades nome, numConta, saldo
2. nome precisa validar o seguinte:
    1. se é menor que 3 letras ou vazia (espaços ou null)
3. numConta precisa validar o seguinta:
    1. se é menor que zero
    2. depois da atribuição inicial, não pode ser sobrescrita (set), somente lida
4. saldo precisa validar o seguinte:
    1. depois do depósito inicial, não pode ser sobrescrita, só lida
5. criar uma função Deposit(double val)
    1. val não pode ser negativo
    2. adiciona o valor ao saldo
6. criar uma função Withdraw(double val)
    1. val não pode ser negativo
    2. retira o valor do saldo, nas seguintes condições:
        1. não faz se val > saldo
    3. retira a taxa