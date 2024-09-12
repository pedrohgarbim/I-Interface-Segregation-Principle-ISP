
# 💻 Interface Segregation Principle (ISP)
![image](https://github.com/user-attachments/assets/4b1d23fa-f2ed-461f-abdf-057d32101f51)

## O que é o ISP?

O **Princípio da Segregação de Interfaces (ISP)** afirma que **os clientes não devem ser forçados a depender de interfaces que não utilizam**. 🔌 Ou seja, uma interface deve ser pequena e específica para a necessidade do cliente, ao invés de uma interface grande e cheia de métodos desnecessários. 🎛️

### 🚨 Problema comum:

Imagine uma interface `IWorker` 🛠️ que tem dois métodos: `Work()` e `Eat()`. Isso funciona bem para trabalhadores humanos, mas e se tivermos um `RobotWorker` 🤖? Robôs não comem, mas ainda assim, eles são obrigados a implementar o método `Eat()`, mesmo que ele não faça sentido para eles. Isso viola o ISP.

### ✅ Solução com ISP:

Para resolver isso, separamos a interface grande em interfaces menores e mais específicas. Criamos uma interface `IWorkable` 👨‍💻 para o trabalho e uma interface `IEatable` 🍽️ para aqueles que precisam comer. Agora, `RobotWorker` implementa apenas o que faz sentido para ele.

### 🛠️ Explicação do Projeto:

No projeto implementando o ISP:
- Dividimos a interface `IWorker` 🛠️ em interfaces menores como `IWorkable` 👨‍💻 e `IEatable` 🍽️.
- `RobotWorker` 🤖 implementa apenas `IWorkable`, enquanto `HumanWorker` 👷‍♂️ implementa tanto `IWorkable` quanto `IEatable`.

#### 🎯 Benefícios:
- **Modularidade**: Interfaces menores e específicas permitem que cada classe implemente apenas o que precisa. 🧩
- **Flexibilidade**: Podemos adaptar as classes às suas necessidades sem obrigar métodos desnecessários. 🚀
- **Redução de acoplamento**: As classes ficam menos acopladas, resultando em um sistema mais modular e fácil de manter. 🔧
