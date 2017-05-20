---
title: Semana 8 - Protótipo
categories: [prototipo, mecanica, unity, oitava_semana]
permalink: /:year/:month/:day/Semana-8-Prototipo.html
---

Hoje foi a entrega do protótipo. Da semana anterior para essa, foram feitos vários progressos.


## Primeira Pessoa

A câmera em primeira pessoa foi feita usando-se um recurso padrão disponível pela Unity, o *First Person Controller*, que está disponível no pacote de *assets* chamado *Characters*.

O *First Person Controller* é um personagem em primeira pessoa já pronto integrado com a câmera. Os recursos que ele já possui são:

+ Sons das batidas dos pés com o chão para qualquer movimento, que podem ser substituídos.

+ Andar, correr e pular, com velocidade e altura ajustáveis.

+ Um componente de física (*collider*) para que o personagem não atravesse por objetos.

Ele não possui um modelo 3D integrado, e nós ainda não atribuímos um ao nosso personagem. Portanto, ele é uma pessoa invisível, por enquanto.


## Personagem

Os elementos do personagem que foram criados foram todos integrados ao *First Person Controller*.


### Saúde

Para implementar a saúde, foi usado um *script* criado no tutorial do *Survival Shooter*. Ele controla a saúde do jogador, possuindo uma função para causar dano. Além disso, toda vez que a função é chamada, um fundo leve vermelho é adicionado à tela para sinalizar ao jogador que ele perdeu saúde. Por fim, quando a saúde chega a 0, o *script* desativa os controles do jogador, reproduz um áudio configurável e ativa uma animação (se existir) de morte para o *avatar* do jogador.

Esse *script* é referenciado por outros elementos do jogo:

+ Uma barra de vida presente na interface gráfica, que monitora o valor da saúde continuamente.

+ Inimigos, para que os ataques deles possam diminuir a saúde do jogador.

+ Um *script* que gerencia o surgimento de inimigos, para que inimigos só surjam se o personagem ainda estiver vivo.


### Arma

Foi aproveitada a arma do *Survival Shooter* e o som de tiro, mas retirando o seu modelo 3D. Ficamos com uma espécie de submetralhadora invisível, por enquanto.

{% include image name="arma_destro.png" caption="Destro." %}

{% include image name="arma_canhoto.png" caption="Canhoto." %}

Como vemos nas duas imagens acima, a arma dispara “traços”, e, quando esses "traços" acertam o inimigo, ele toma dano (o que é sinalizado pela "fumaça" - ou pelúcia - saindo dele).

Outra coisa que essa imagem mostra é que nosso personagem é ambidestro! Ele usa a arma com as duas mãos (ela muda aos poucos de lugar na tela à medida que o jogador vira a câmera).

O funcionamento da arma, na verdade, se dá por cinco elementos:

+ Uma luz pontual, acionada no momento do disparo, que é o clarão do disparo no entorno do jogador.

+ Um sistema de partículas, que emite uma partícula amarela brilhante e imóvel no cano da arma no momento do disparo. Esse é o clarão do disparo no cano da arma, onde ele é mais forte.

+ Um renderizador de linhas (ou *line renderer*) que renderiza uma linha amarela no momento do disparo que vai do cano da arma ao objeto atingido ou até o alcance máximo da arma. Essas são as balas que são visíveis nas imagens.

+ Um *raycaster*, que emite raios invisíveis para determinar se o inimigo foi atingido por um disparo ou não.

+ Um *script* para controlar os quatro elementos acima. Quando um jogador clica no botão de atirar, o *script* emite o som da arma, aciona a luz da arma, emite a partícula e usa o *raycaster* para emitir um raio invisível do cano da arma até o máximo do seu alcance. Se o raio colide com um inimigo, ele diminui a saúde do inimigo e usa o renderizador de linhas para criar uma linha da arma até o inimigo. E se nenhum inimigo for atingido, essa linha vai até o alcance máximo da arma. Depois dessas ações, a luz da arma e a linha da arma são desativadas e, durante um pequeno intervalo de tempo, não é possível atirar de novo. O tempo entre os disparos e o dano causado por eles é configurável, permitindo ajustar a cadência e o poder da arma.

Na demonstração, a arma possui munição ilimitada, mas, no jogo final, a munição das armas será muito escassa, e o jogador não terá sempre uma arma.


## Inimigos


### Modelo 3D

Para o protótipo, foi usado o *Zombunny*, um coelho de pelúcia zumbi que já foi usado no *Survival Shooter*. Uma imagem dele está abaixo:

{% include image name="zombunny.png" caption="Zombunny, nosso inimigo/mascote do protótipo." %}

Para adicionar um efeito de pelúcia, no próprio tutorial foi criado um sistema de partículas, e essas partículas são disparadas quando ele recebe um tiro.


### IA

A IA foi refeita para o labirinto, recompilando a *NavMesh* depois de o cenário ser inserido. A *NavMesh* é uma representação plana do ambiente que é formada apenas pelo espaço navegável, e é calculada analisando o cenário e removendo partes não-navegáveis, como paredes e objetos muito altos.

Com a *NavMesh*, os inimigos podem calcular a melhor rota para o jogador, permitindo a eles se movimentar e atacar o jogador. Esse procedimento já era feito no *Survival Shooter*, mas ele foi modificado para que os inimigos não sigam o jogador de qualquer lugar do mapa. Foi inserido um alcance configurável, de modo que um inimigo só começa a seguir um jogador quando ele entra no seu alcance. Isso também permite que o jogador perca um inimigo, caso ele saia do seu alcance.

Por enquanto, esse alcance é apenas uma distância entre dois objetos, e não considera o campo de visão.


### Ataques

Foi usado o mesmo mecanismo do *Survival Shooter*, para essa etapa. Ataques ocorrem quando o jogador colide com um inimigo, e um ataque ocorre a cada 0.5 segundos.


### Dicas Visuais

Foi acoplada uma lanterna ao inimigo, de modo a dar uma indicação visual de que ele está atrás da parede. Essa é uma tentativa de criar um clima de suspense, dado que, no jogo final, o personagem terá recursos limitados e possivelmente não terá uma arma.

{% include image name="dica_visual.png" caption="Uma luz! O que tem atrás da parede?" %}

### Saúde

Foi usado um *script* do *Survival Shooter*, que controla a saúde de inimigos e que, na morte, ativa uma animação de morte, faz o inimigo afundar no chão e o deleta após 2 segundos (evitando que inimigos mortos ocupem memória).


## Ambiente


### Labirinto

O tamanho do labirinto foi ajustado para ficar largo o suficiente, de modo que o jogador tenha espaço para se esquivar de um inimigo, e alto o suficiente, de modo que não se possa pular as paredes. Uma textura foi aplicada dentro do Maya, mas, ao importar o modelo no Unity, algum erro ocorreu e o labirinto foi importado sem a textura, mas com o material criado para ela dentro do Maya.

Portanto, foi necessário reaplicá-la no Unity. Uma imagem da textura e outra do resultado final seguem abaixo:

{% include image name="textura.jpg" caption="A textura aplicada para o labirinto inteiro. Dá um efeito de parede suja para o cenário." %}

{% include image name="labirinto_unity_com_textura.png" caption="O labirinto final usado no protótipo, com a textura e a iluminação. Os pontos coloridos são para o minimapa, e são explicados na sua seção." %}

### Iluminação

Foi usada uma luz direcional emitida de cima do labirinto com um um tom escuro de cinza, para escurecer o ambiente e tentar aumentar a tensão. No jogo final, a ideia é que a iluminação não seja para o ambiente inteiro, e sim que o ambiente seja todo muito mal iluminado, com alguns locais com mais iluminação com lâmpadas quebradas.


## Interface Gráfica

{% include image name="interface_grafica.png" caption="Interface gráfica do nosso protótipo. Câmera em primeira pessoa, barra de vida e minimapa." %}

### Barra de Vida

A barra de vida usada é a mesma do tutorial do *Survival Shooter*, criada com um elemento básico de interface gráfica do Unity, um *slider*, que é uma barra de tamanho configurável que possui duas cores. Uma delas é de saúde e a outra de dano. Quando o personagem toma dano, a parte com cor de dano aumenta na barra e a parte com cor de saúde diminui.


### Minimapa

O minimapa foi criado como uma câmera auxiliar, com uma visão panorâmica do ambiente do jogo. Como não usamos todo o labirinto, a visão dela é restrita a uma pequena parte dele. Para sinalizar os objetos de interesse, foram usadas esferas que emitem luzes coloridas que flutuam em cima desses objetos e os seguem. Essas esferas só podem ser vistas pela câmera do minimapa. Cada cor corresponde a um tipo de objeto:

+ Azul: jogador

+ Vermelho: inimigo

+ Dourado: item de interesse

+ Branco: saída do labirinto

Para essa demonstração, todos esses itens são exibidos desde o início do jogo, mas, para o jogo final, a ideia é que eles só sejam exibidos quando forem descobertos pelo jogador. Além disso, no jogo final, a câmera do minimapa deve seguir o jogador para exibir o ambiente na sua redondeza que já entrou no seu campo de visão.


## Fase de Demonstração

Usando todos os elementos mencionados acima, criamos uma pequena fase de demonstração, seguindo as ideias que pensamos para a primeira fase do jogo final.

Os eventos da *demo* ocorrem só em uma pequena parte do labirinto, como sinalizado no mapa abaixo:

{% include image name="mapa_prototipo.jpeg" caption="O mapa do labirinto usado no protótipo. O labirinto inteiro foi incluído no jogo, mas apenas a parte limitada pelos riscos vermelhos foi usada na fase de demonstração, começando do ponto vermelho, que é onde o jogador inicia." %}

A ideia que tivemos para a primeira fase do jogo final é: o jogador inicia próximo à porta de saída e necessariamente passa por ela no seu caminho inicial, mas ela está bloqueada por um teclado numérico que necessita de um código. Nesse momento, o jogador descobre que precisa encontrar um código no labirinto, e ele explora o lugar para descobrir os números da combinação.

Para esse protótipo, que foi mais focado em mecânicas básicas, reproduzimos essa ideia da seguinte forma:

+ O jogador precisa encontrar um número da combinação, apenas. Ele está como um objeto colecionável e flutuante.

+ Ao pegar esse objeto e se aproximar da porta, ela abre (é deletada), permitindo ao jogador chegar às escadas para o próximo andar.

Para demonstrar os outros elementos do jogo, usamos:

+ 2 inimigos que estão por trás de paredes, no meio do caminho do jogador. Isso serve para demonstrar a dica visual, os inimigos e a arma do jogador.

+ 1 ponto de surgimento de inimigos um pouco atrás do local de início do jogador. Lá, surge 1 *Zombunny* a cada 10 segundos. Serve para testar mais o combate e a IA de movimentação dos inimigos.

+ Uma tela de *Game Over* que aparece quando o jogador morre.

+ Um efeito de clareamento da tela que acontece quando o jogador vence a fase (chega às escadas), junto com alguns aplausos.

Seguem abaixo algumas imagens dos elementos da fase:

{% include image name="porta_fechada.png" caption="A porta que esconde a saída do labirinto." %}

{% include image name="numero_flutuante.png" caption="O número coletável." %}

{% include image name="porta_aberta.png" caption="A porta aberta depois de descobrirmos o número que a abre." %}

{% include image name="escadas.png" caption="Essas escadas indicam a vitória." %}

{% include image name="win.png" caption="GANHEI!" %}

{% include image name="game_over.png" caption="Mas, na segunda vez, os coelhos foram fortes demais..." %}
