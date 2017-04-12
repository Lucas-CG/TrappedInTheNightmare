---
title: Terceira Semana - Atualização do Projeto da Primeira Fase
categories: [projeto_de_fase, terceira_semana]
permalink: /:year/:month/:day/Terceira-Semana-Atualizacao-do-Projeto-da-Primeira-Fase.html
---

Depois da segunda reunião com o professor, chegamos à conclusão de que o nosso mapa estava muito grande, e que levaria muito tempo para modelá-lo. Por isso, decidimos reduzir o seu tamanho.

Um novo labirinto aleatório circular foi gerado no MazeGenerator, e a imagem recebeu ajustes para criar novos caminhos. Objetos de interesse, as localizações para os números e os caminhos para os números foram novamente criados e posicionados. Isso resultou na imagem abaixo:

{% include image name="labirinto 2.jpeg" caption="Segunda versão do mapa do labirinto. Dessa vez, a entrada é o ponto vermelho." %}

Esse mapa é bem menos complexo que o anterior, sendo menos cansativo para o jogador e mais simples de modelar.

Adicionamos mais uma "sala falsa" (F no mapa) e reduzimos a quantidade de números que o jogador deve buscar para 3.

Mantivemos o botão em B para abrir a sala que possui o número 1.

Um outro detalhe que não havíamos decidido era a posição da porta com a escada, que o jogador necessariamente deve ver no começo da sua exploração. Como vemos pelos caminhos sinalizados, se o jogador for para a esquerda (caminho azul), ele encontra uma porta fechada e não pode realizar nenhuma ação nesse momento); e seguindo pelo caminho vermelho, para o qual ele irá voltar se ele foi para o caminho azul primeiro, ele verá a escada por trás da porta.

A sala circular central só possui duas aberturas do lado direito, forçando o jogador a andar por todos os cantos do mapa para encontrar os números. Isso é diferente da sala central da versão anterior, que possuía três acessos em direções diferentes..

Nossos próximos passos agora para o projeto dessa fase são:

- Modelar o cenário com um _software_ de modelagem 3D
- Definir a existência e o posicionamento de armadilhas, inimigos e itens
- Modelar as armadilhas, inimigos e itens a serem usados

E a última tarefa realizada nessa semana foi a criação desse blog!
