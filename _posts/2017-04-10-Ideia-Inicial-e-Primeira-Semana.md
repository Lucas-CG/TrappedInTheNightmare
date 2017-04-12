---
layout: post
title: Ideia Inicial e Primeira Semana
categories: [ideia, história, apresentação, semana1]
permalink: /:categories/:title
---

_Trapped in the Nightmare_ é um jogo em 3D proposto para a disciplina Animação e Jogos (COS600) da UFRJ, ministrada pelo professor Ricardo Marroquim para alunos de Engenharia de Computação e Informação e da Escola de Belas Artes.

Ele será desenvolvido pelos alunos Lucas de Carvalho, Amanda Pereira e Erik Tronkos.


## Enredo

O jogo conta a história de um personagem (cuja identidade não definimos até o momento) que, logo após ir dormir, se vê de frente a uma torre gigante, em um lugar desconhecido e escuro. Ele não vê outra saída além de entrar na torre. Ao entrar lá, ele vê que está preso em um labirinto. E aí ele percebe: ele está em um pesadelo.

Para escapar, ele precisa chegar ao último andar da torre e encontrar o seu despertador. Mas do primeiro andar ao despertador, o caminho será árduo: seu tempo para subir cada andar é limitado, e se ele não conseguir achar as escadas a tempo, o andar se desfará e nosso personagem irá cair na escuridão, não conseguindo acordar. Mais ainda, cada andar possui armadilhas e inimigos.

## Elementos do Jogo

### Condições de Vitória/Derrota

Em cada labirinto, o jogador ganha se conseguir subir as escadas para o próximo andar antes de o tempo acabar.

O jogador vence o jogo se levar o personagem ao topo do labirinto.

O jogador perde em uma fase se não conseguir chegar à saída a tempo ou se morrer para uma armadilha ou monstro, perdendo uma vida no processo. O personagem possui uma barra de vida que é diminuída caso sofra um ataque, e morre caso essa barra se esgote. Caso o jogador perca todas as vidas, ele perde o jogo e precisa começar novamente.

### Labirintos

Um labirinto é um andar da torre, composto de vários corredores interligados por portas ou curvas. Ele sempre possui um ponto de entrada e pode ter um ou mais pontos de saída (escadas) definidos. Será possível a existência mais de um caminho para encontrar a saída (tornando a jogabilidade mais flexível).

### Itens

Cada labirinto pode possuir itens espalhados e guardados dentro de baús de tesouro. Os itens podem ter funções variadas. Alguns exemplos de itens são: armas de fogo para matar inimigos, controles remotos para desativar armadilhas e comidas para restaurar a barra de vida.

### Armadilhas

Podem matar o jogador e/ou impedir sua passagem. Um exemplo de armadilha seria uma barreira de raios _laser_ que queimam o personagem se ele passar por eles. Algumas podem ser desativadas por itens.

### Inimigos

Um dos maiores perigos para nosso personagem, os inimigos estão espalhados pelo cenário. Eles possuem um campo de visão definido, e podem atacar o jogador para matá-lo. Todos os inimigos terão uma dica para revelar a sua posição, podendo ser um som, uma dica visual (por exemplo, uma luz) ou rastros como pegadas. Nem todas as dicas serão óbvias.

### Mapa

Mostra o caminho pelo qual o jogador já passou e possui sinalizações de lugares e objetos úteis para o jogador (como uma porta ou um item) que estão em lugares por onde ele passou. Ele está presente no minimapa em um dos cantos da tela e em sua versão completa caso o jogador aperte o botão para abri-lo.

### Câmera e Interface Gráfica

O jogo será em primeira pessoa, para aumentar a imersão. A interface gráfica será o mais limpa possível para não atrapalhar o jogador. Ela conterá os seguintes itens:

- Barra de vida

- Relógio pequeno mostrando o tempo restante

- Minimapa

Também existem o menu de itens e o mapa completo, que serão abertos apenas quando os botões correspondentes forem pressionados. E, por isso, são elementos maiores.

### Controles

Desenvolveremos o jogo para ser jogado com teclado e mouse.

O esquema de controles atual é o seguinte:

- W, A, S, D - Movimentação (Frente, Esquerda, Trás, Direita)

- E - Interagir com objeto/pegar item

- I - Segurar para abrir menu de itens, soltar para equipar item escolhido com as setas (abaixo)

- Setas: Escolher itens dentro do menu. Segurar até soltar o botão I.

- M - Abrir mapa completo

- Barra de espaço - Pular

- Movimento do mouse - mirar arma/mover câmera

- Clique esquerdo do mouse - Usar item/arma selecionado
