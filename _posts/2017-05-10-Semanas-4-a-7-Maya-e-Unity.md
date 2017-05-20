---
title: Semanas 4 a 7 – Labirinto modelado no Maya e Avanços na Unity
categories: [projeto_de_fase, modelagem, unity, quarta_semana, quinta_semana, sexta_semana, setima_semana]
permalink: /:year/:month/:day/ Semanas-4-a-7-Maya-e-Unity.html
---

Durante essas 4 semanas, foram feitos alguns progressos:

## Modelos no Maya

O labirinto foi completamente modelado no Maya. Uma imagem dele está abaixo.

{% include image name="labirinto_maya.png" caption="Modelo no labirinto aberto no Maya." %}

Ele foi exportado para a Unity para ser integrado ao jogo. E já foi inserido o componente de física (um *mesh collider*) para evitar que objetos e personagens atravessem suas paredes e para permitir que eles possam andar nele.



## Tutorial do Survival Shooter
Foi realizado o tutorial do Survival Shooter, localizado no site oficial da Unity. Consideramos fazer esse tutorial importante porque apresenta diversos elementos que serão usados no jogo final:
- Sistema de vida
- Inimigos e IA básica com *NavMeshes*
- Combate básico
- Movimentação por um ambiente
- Física (colisão entre objetos e acionamento de “gatilhos”): útil para abrir portas e criar interações
- Câmera
- Interface gráfica básica, com textos, barra de vida e animações para o fim do jogo

Uma foto do tutorial completo aberto na Unity se encontra abaixo:

{% include image name="survival_shooter.png" caption="Imagem do tutorial completo do Survival Shooter." %}

## Projeto do Jogo na Unity
O projeto do jogo final foi iniciado na Unity. Faremos uma adaptação do Survival Shooter feito anteriormente, aproveitando alguns dos seus recursos. Por enquanto, o personagem principal (com o modelo do tutorial) foi inserido no labirinto importado, e consegue se mover pelo ambiente. Foram criados pontos de surgimento para inimigos no ambiente, também. Para a fase inicial de integração do labirinto, falta adequar a IA (NavMesh) dos inimigos ao ambiente, limitando o alcance e considerando as paredes do labirinto. E para a entrega do protótipo, falta programar implementações básicas das mecânicas do jogo.

