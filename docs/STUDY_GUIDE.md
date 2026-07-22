# Guia de estudo

Use este fluxo para revisar ou implementar cada tópico sem transformar o repositório em uma coleção de soluções copiadas.

1. Escreva o contrato: entradas, saídas, erros e invariantes.
2. Resolva um exemplo pequeno manualmente.
3. Implemente a primeira versão sem otimização prematura.
4. Escreva testes para limites, entradas vazias, duplicados e valores ausentes.
5. Calcule as complexidades de tempo e espaço.
6. Compare com a implementação disponível no .NET, quando existir.
7. Refatore nomes e responsabilidades sem mudar o comportamento.
8. Execute build, testes, cobertura e benchmarks relevantes.
9. Preencha o template de estudo e atualize o roadmap.

## Perguntas para revisão

- Qual invariante precisa permanecer verdadeira durante a execução?
- Qual é o pior caso e o que o provoca?
- A implementação aceita coleção vazia, valores duplicados e `null`?
- Existe diferença entre complexidade amortizada e complexidade por operação?
- Qual alternativa seria preferível em código de produção?
- Como eu explicaria a solução em cinco minutos durante uma entrevista?
