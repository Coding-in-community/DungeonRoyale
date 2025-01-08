# **Game Design Document (GDD): Dungeon Royale**

## **Visão Geral**

- **Título:** Dungeon Royale  
- **Gênero:** Jogo 2D Top-Down Battle Royale  
- **Plataforma:** PC (inicialmente)  
- **Game Engine:** Godot 4.x com .NET  
- **Estilo Visual:** Pixel Art retrô  
- **Público-Alvo:** Jogadores casuais e competitivos, fãs de jogos nostálgicos com elementos de RPG.  

---

## **Premissa**

**Dungeon Royale** combina o caos estratégico de um *Battle Royale* com a escolha de classes inspiradas em RPGs clássicos. Até 8 jogadores entram em uma dungeon procedural, enfrentando monstros, outros jogadores e usando suas habilidades únicas para serem o último sobrevivente.

---

## **Características Principais**

- **Multiplayer Local:** Até 8 jogadores por partida.  
- **Dungeon Procedural:** Mapas gerados automaticamente, oferecendo desafios únicos a cada partida.  
- **Classes Jogáveis:** Escolha entre Arqueiro, Cavaleiro e Mago, cada um com poderes específicos.  
- **Zona de Perigo:** O mapa encolhe gradualmente, forçando os jogadores a confrontarem uns aos outros.  
- **Monstros e Armadilhas:** Desafios adicionais em PVE para diversificar a jogabilidade.  

---

## **Classes e Habilidades**

| **Classe**   | **Habilidade Principal**                     | **Estilo de Jogo**                    |
|--------------|---------------------------------------------|---------------------------------------|
| **Arqueiro** | Dispara flechas em linha reta à distância, atravessando obstáculos. | Ataque à distância, alta mobilidade. |
| **Cavaleiro**| Golpeia com uma espada em um arco frontal, causando grande dano em curta distância. | Tanque e combate corpo a corpo.      |
| **Mago**     | Lança projéteis mágicos que explodem em área ao impacto. | Controle de área e dano mágico.      |

---

## **Gameplay**

### **Mecânicas Básicas**

- **Movimentação:** Controle fluido em quatro direções.  
- **Ataques:** Cada classe possui um ataque principal único e pode encontrar melhorias para suas habilidades no mapa.  
- **Interação com o Ambiente:** Evite armadilhas, destrua monstros e colete itens de melhoria.  

### **Progresso da Partida**

1. **Escolha de Classe:** Antes da partida, os jogadores selecionam entre Arqueiro, Cavaleiro e Mago.  
2. **Exploração:** Procure por itens e enfrente monstros para ganhar vantagens.  
3. **Zona de Perigo:** O espaço jogável diminui com o tempo, forçando confrontos.  
4. **Fim:** O último jogador sobrevivente é o vencedor.  

---

## **Monstros**

| **Monstro**     | **Descrição**                                                                |
|------------------|-----------------------------------------------------------------------------|
| **Rato**        | Movimentação lenta, causa dano ao tocar no jogador.                        |
| **Goblin**    | Atira projéteis de ossos em linha reta.                                    |
| **Chefe Aleatório (opcional)** | Um monstro especial pode surgir no final para aumentar a dificuldade. |

---

## **Sistema de Itens**

| **Item**              | **Efeito**                                   |
|-----------------------|---------------------------------------------|
| **Aumento de Dano**   | Melhora o poder do ataque principal.        |
| **Aumento de Velocidade** | Aumenta a velocidade de movimento.        |
| **Escudo**            | Absorve o dano de um ataque.                |
| **Regeneração de Vida**| Recupera parte da saúde.                    |

---

## **Estilo Visual**

- **Arte:** Pixel art colorido e detalhado, com designs únicos para cada classe.  
- **Animações:** Ataques diferenciados para cada classe, explosões mágicas e efeitos visuais imersivos.  

---

## **Interface do Usuário (UI)**

### **HUD**
- Classe escolhida, barra de vida, e itens ativos.  
- Contador de jogadores restantes.  

### **Menu Inicial**
- Opções para criar partidas, escolher classe, configurar controles e acessar tutoriais.  

---

## **Pontos Focais do Desenvolvimento**

- **Equilíbrio de Classes:** Certificar-se de que cada classe oferece vantagens e desvantagens claras, mantendo o jogo justo.  
- **Dungeon Procedural:** Mapas variados e equilibrados.  
- **Feedback Visual e Sonoro:** Ataques únicos para cada classe e ambientação imersiva.  
