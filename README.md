# ✊📄✂️ Jogo Pedra, Papel e Tesoura

Aplicação de console desenvolvida em **C#** que simula o clássico jogo de Pedra, Papel e Tesoura, com suporte a múltiplos modos de jogo, placar em tempo real e salvamento de ranking em arquivo.

---

## 📋 Descrição

Este projeto permite jogar **Pedra, Papel e Tesoura** diretamente no terminal, oferecendo uma experiência interativa com:

- Modo contra o computador 🤖  
- Modo para dois jogadores 👥  
- Sistema de partidas (melhor de 3 ou melhor de 5)  
- Exibição visual das jogadas com ASCII art  
- Registro automático do vencedor em arquivo  

---

## 🧠 Estrutura do Projeto

O sistema foi organizado utilizando separação de responsabilidades, facilitando manutenção e evolução do código.

---

### 📌 Program.cs

Ponto de entrada da aplicação.

namespace pedraPapelTesoura.ConsoleApp;

class Program
{
    static void Main(string[] args)
    {
        Jogo.Iniciar();
    }
}

## 🎮 Jogo.cs

Classe principal que controla toda a execução do jogo.

### Responsabilidades:

- Exibir menu inicial  
- Permitir escolha do modo de jogo  
- Definir tipo de partida (melhor de 3 ou 5)  
- Controlar o loop das rodadas  
- Gerenciar pontuação  
- Exibir jogadas e resultados  
- Determinar o campeão  
- Salvar resultado no ranking  

### ✊ Jogada.cs

Responsável por representar as jogadas.

Funcionalidades:
- Converter número em nome da jogada
- Exibir desenho ASCII correspondente
Exemplo:

Jogada.ObterNome(1); // Pedra
Jogada.ExibirDesenho(1); // Exibe ASCII

### 🧾 Resultado.cs

Responsável pela regra de negócio do jogo.

public static string VerificarVencedor(int j1, int j2)

Regras:
- Empate → quando jogadas são iguais
- Jogador 1 vence:
Pedra vence Tesoura
Tesoura vence Papel
Papel vence Pedra
- Caso contrário → Jogador 2 vence


### 🏆 Ranking.cs

Responsável por salvar os resultados das partidas.

Funcionamento:
- Armazena o vencedor no arquivo ranking.txt
- Registra data e hora da partida

File.AppendAllText("ranking.txt", linha);

### 🚀 Funcionalidades
- 🎮 Modo contra computador
- 👥 Modo 2 jogadores
- 🔢 Melhor de 3 / melhor de 5
- 📊 Sistema de pontuação
- 🎨 Cores no console para resultados
- 🖼️ ASCII art das jogadas
- 💾 Salvamento automático de ranking

### ▶️ Como Executar

git clone https://github.com/ThiaggoSylva/pedraPapelTesoura.git

cd pedraPapelTesoura

dotnet run

🎯 Como Jogar
1. Escolha o modo de jogo:
- 1 → Contra computador
- 2 → Dois jogadores
2. Escolha o tipo de partida:
- Melhor de 3
- Melhor de 5
3. Cada jogador escolhe:
- 1 → Pedra
- 2 → Papel
- 3 → Tesoura
4. O sistema exibirá:
- Nome da jogada
- Desenho ASCII
- Resultado da rodada
- Placar atualizado
- O jogo termina quando um jogador atingir o número de vitórias necessário

### 📸 Exemplo de Execução
=== Pedra, Papel ou Tesoura ===

Modo de jogo:

1 - Contra Computador

2 - 2 Jogadores

Modo de série:

1 - Melhor de 3

2 - Melhor de 5

Jogador 1: Pedra

Computador: Tesoura

Jogador 1 venceu!
Placar: 1 x 0

### 📁 Arquivo de Ranking

Exemplo do conteúdo do arquivo ranking.txt:

31/03/2026 20:10:15 - Jogador 1

31/03/2026 20:12:02 - Jogador 2


### 📌 Conceitos Aplicados
- Separação de responsabilidades (SRP)
- Métodos estáticos organizados por domínio
- Validação de entrada do usuário
- Estruturas condicionais
- Manipulação de arquivos (System.IO)
- Uso de cores no console (Console.ForegroundColor)


