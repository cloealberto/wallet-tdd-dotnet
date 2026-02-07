## 🧪 Testes Unitários e TDD

Este projeto foi desenvolvido utilizando a abordagem de **Test Driven Development (TDD)**, seguindo o ciclo:

**Red → Green → Refactor**

Cada funcionalidade foi implementada a partir da criação de testes unitários, garantindo que as regras de negócio fossem validadas antes da implementação do código.

### Funcionalidades cobertas por testes
- Criação de conta com saldo inicial
- Depósito com validações de valor
- Saque com validações de saldo e valor
- Transferência entre contas com regras de negócio
- Cenários negativos e validações de exceções

---

## 📊 Cobertura de Testes

A cobertura de testes foi medida utilizando **Coverlet** e **ReportGenerator**.

### Resultado obtido:
- **Cobertura de linhas:** 88%
- **Cobertura de branches:** 70%

A meta definida para o desafio foi **80% de cobertura**, que foi atingida com sucesso.

![Relatório de Cobertura de Testes](docs\CoberturaTdd.png)

### Comandos utilizados
```bash
dotnet test --collect:"XPlat Code Coverage"
reportgenerator -reports:**/coverage.cobertura.xml -targetdir:coverage-report -reporttypes:Html

O relatório de cobertura pode ser acessado localmente em:
coverage-report/index.html