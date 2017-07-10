---
title: Últimas Atualizações
categories: [entrega_final]
permalink: /:year/:month/:day/Ultimas-Atualizacoes.html
---

Esse post é sobre a versão apresentada no dia 23/6/17 em sala e sobre a entrega final, entregue dia 9/7/17, que recebeu alguns ajustes extras. Várias mudanças foram feitas do último post para agora, e é possível vê-las no *trailer* cujo *link* está ao lado.


## Luzes

A iluminação foi totalmente refeita. Removemos a iluminação global e adicionamos 220 luzes pontuais fracas, deixando o cenário mais escuro e aumentando o suspense. Para a apresentação, foi realizado um processo chamado *baking*, que reduz o custo computacional de manter as luzes salvando as alterações nas cores do labirinto em um mapa. No entanto, nessa entrega havia um pequeno *bug* que fazia com que as luzes piscassem em determinados lugares.

Isso foi consertado na entrega final, ao percebermos que o problema estava relacionado com o *baking* e com o fato de as luzes não terem sido configuadas para gerar sombras. A iluminação agora é calculada em tempo real e gera *soft shadows*.


## Personagem

Duas alterações foram para os momentos em que o jogador sofre dano:

+ Adicionado um som de batida cardíaca
+ O efeito vermelho na tela demora mais a sair

Além disso, a arma do personagem foi removida! Ela era uma possibilidade para o jogo final, com munição limitada, mas preferimos removê-la para aumentar a dificuldade.


## Inimigos


Trocamos o modelo 3D do nosso monstro. Veja na imagem abaixo:

{% include image name="monstro.png" caption="Um pouco mais assustador que o coelho, não?" %}

Ele está animado para andar e bater no jogador.

No mapa final, estão presentes 24 monstros, que patrulham partes do mapa em busca do jogador. Cada monstro possui dois pontos no mapa para onde ele deve ir periodicamente. O trajeto entre esses pontos é o que ele patrulha.

Nosso algoritmo para patrulhar é simples:

+ O monstro surge em um dos pontos de patrulha.
+ Ele toma o outro ponto como destino e anda em direção a ele.
+ Chegando a esse ponto, ele toma o ponto anterior como destino e anda em direção a ele.
+ A operação se repete permanentemente.
+ Se o jogador entrar no seu campo de visão ou ficar muito próximo a ele, ele passa a seguir o jogador e, se ele estiver próximo o suficiente, passa a atacá-lo. Se o jogador fugir, correndo além do alcance do monstro, o monstro volta a patrulhar normalmente.

Cada ataque tira metade da saúde do jogador.

O monstro não apresenta nenhuma dica visual ou sonora, mas, em compensação, ele é mais lento que o jogador e é grande.


## Objetivos

Foi criada uma nova tela de pontuação, para estimular jogadores a completarem o labirinto mais rápido. A pontuação calculada é 10000 vezes a fração de tempo restante.

{% include image name="vitoria.png" caption="" %}

Foi adicionado um limite de tempo de 15 minutos para terminar a fase. Se o jogador morrer ou não sair do labirinto a tempo...

{% include image name="game_over.png" caption="" %}

O número do labirinto foi substituído por quatro chaves espalhadas pelo labirinto que devem ser pegas para abrir a porta. Na última apresentação, apenas uma chave deveria ser coletada (para agilizar), mas, na última versão, todas as chaves devem ser obtidas, o que era o nosso objetivo inicial.



## Interface Gráfica

A interface foi refeita para a apresentação, e ajustada novamente na entrega final. É possível ver a evolução da aparência do jogo observando as três imagens abaixo.:

{% include image name="interface_grafica.png" caption="Interface gráfica do protótipo." %}
{% include image name="interface_grafica_apresentacao.png" caption="Interface gráfica da apresentação." %}
{% include image name="monstro.png" caption="Interface gráfica da versão final." %}

### Barra de Vida

A única alteração na barra de vida é a cor que indica a quantidade de saúde disponível. Trocada de branca para verde.


### Minimapa e Mapa Completo

O minimapa foi refeito. Ele ainda é uma câmera auxiliar, com uma visão vertical, que mostra apenas as redondezas do jogador. Agora essa câmera segue o jogador. Sua projeção foi mudada de perspectiva para ortográfica (essa mudança corrigiu alguns erros nas posições indicadas pelo minimapa). Além disso, sua aparência foi alterada. Isso foi feito criando-se um labirinto auxiliar, que só pode ser visto com essa câmera, além de uma iluminação global que só pode ser vista por ela. Os ícones visíveis no minimapa são também objetos apenas visíveis por essa câmera.

Para a apresentação, também removemos o símbolo que indica a saída do labirinto e o que indicava permanentemente onde estavam as chaves.

Para a entrega final, também removemos os ícones para os inimigos. Agora, um ícone dourado em formato de chave aparece no mapa quando o jogador pega uma chave, na localização da chave obtida. Isso é um marco para orientar os jogadores. Além disso, foi adicionado um ícone para indicar onde o jogador surgiu. A legenda para o mapa na versão final é:

+ Azul: jogador

+ Chave Dourada: item de interesse

+ Verde: local onde o jogador iniciou o jogo.

Também foi adicionado um mapa completo do labirinto para a entrega final, com o mesmo esquema de cores. Ele exibe os mesmos pontos do minimapa. Esse é mais um recurso para ajudar o jogador a navegar pelo labirinto. Pode-se exibir ou retirar o mapa completo usando-se a tecla "M".

### Tempo Limite

Um relógio indicando o tempo restante foi adicionado.

### Menu Principal Adicionado!

{% include image name="menu_principal.png" caption="" %}
