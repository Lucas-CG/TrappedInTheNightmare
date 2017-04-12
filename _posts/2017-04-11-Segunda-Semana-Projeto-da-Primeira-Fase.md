---
title: Segunda Semana - Projeto da Primeira Fase
categories: [projeto_de_fase, segunda_semana]
permalink: /:year/:month/:day/Segunda-Semana-Projeto-da-Primeira-Fase.html
---

Durante a segunda semana, foram discutidos alguns elementos da interface gráfica, mas ela ainda não foi completamente decidida. Após a primeira reunião com o professor na quarta-feira dessa semana, iniciamos o projeto inicial da primeira fase do jogo. 

A ideia para essa primeira fase é a seguinte: o personagem, ao entrar no labirinto, encontra uma porta transparente fechada, bloqueada por um teclado numérico ou cadeado que requer um código para ser destravado. Por trás da porta, é possível ver as escadas para o próximo andar. Nesse momento, o jogador sabe que precisa encontrar o código para desbloquear a porta. No cenário, estão espalhados 4 números que formam o código, e o jogador teria que descobrir qual das 24 combinações abriria a porta.

Usamos o site mazegenerator.net para criar um labirinto aleatório com um tamanho que definimos, formato circular e 1 saída (o máximo de saídas possível para a plataforma). Depois, o mapa gerado foi editado à mão para remover e criar algumas paredes, formando novos caminhos. O mapa resultante, com apenas as paredes, a entrada e as saídas, está abaixo:

[Mapa do labirinto apenas com as paredes. A entrada está na parte superior.]({{ site.url }}/TrappedInTheNightmare/assets/labirinto-jogo.jpg){:class="img-responsive"}

{% include image name="labirinto-jogo.jpg" caption="Mapa do labirinto apenas com as paredes. A entrada está na parte superior." %}

Depois disso, foram traçados os caminhos até cada saída e indicadas as posições de cada número e mais alguns elementos, resultando no mapa abaixo:

[Mapa do labirinto com os caminhos da entrada aos números, além das posições dos números e outros objetos de interesse que pensamos]({{ site.url }}/TrappedInTheNightmare/assets/labirinto-jogo-v1.jpg){:class="img-responsive"}

{% include image name="labirinto-jogo-v1.jpg" caption="Mapa do labirinto com os caminhos da entrada aos números, além das posições dos números e outros objetos de interesse que pensamos" %}

Nessa segunda imagem, 1, 2, 3 e 4 são os quatro números que são parte do código. O número 1 está escondido em uma pequena sala com uma porta fechada (a porta arredondada no mapa). Essa porta só pode ser aberta apertando-se o botão localizado em B, na sala circular central do labirinto. F é uma "sala falsa", que seria um beco sem saída, para frustrar um pouco o jogador.

Esse mapa é um projeto inicial, e não está completo. Falta decidir sobre o posicionamento de inimigos, armadilhas e itens.
