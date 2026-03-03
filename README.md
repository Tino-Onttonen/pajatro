# Pajatro

**Beat the odds in this engaging multiplayer tosser!**
  
*Arcade · Rogue-like · Turn-based multiplayer · Android/iOS/PC*
  
[Website](https://webpages.tuni.fi/25tiko23)  

---

## About The Game

Challenge yourself in this nostalgic game from the 90’s remade to a digital version. Pajatro is a game where you as the player try to aim for the specific sections on the gameboard with a limited amount of tokens in order to gain points. To reach the next level, the player must think strategically as each subsequent step depends on them.
Create your own play style by choosing from a vast arsenal of different power-ups and progress faster through levels in this rogue-like arcade game.

> *"The pure joy and nostalgia i've felt playing Pajatro is tremendous"*

---

## Features

**Core Mechanic** | placeholder  
**World / Levels** | placeholder  
**Characters / Story** | placeholder  
**Art Style** | placeholder  
**Audio** | placeholder  
**Save System** | placeholder  
**Multiplayer** | placeholder  
**Accessibility** | placeholder  

---

## Screenshots

<!-- 2-4 screenshots in a grid layout later.-->

---

## Getting Started

Follow these steps to get a local copy of the game running on your machine.

### Prerequisites

- [**Godot Engine 4.6**](https://godotengine.org/download) — Make sure to download the **.NET / Mono** version
- [**.NET SDK (Latest LTS recommended)**](https://dotnet.microsoft.com/en-us/download/dotnet/)
- A C# compatible IDE (recommended: [VS Code](https://code.visualstudio.com/) with the C# extension, or [Rider](https://www.jetbrains.com/rider/))

### Installation

1. **Clone the repository**
   ```bash
   git clone https://github.com/tino-onttonen/pajatro.git
   cd pajatro
   ```

2. **Restore .NET dependencies**
   ```zsh
   dotnet restore
   ```

3. **Open in Godot**
   - Launch Godot Engine (.NET version)
   - Click **Import** and navigate to the cloned folder
   - Select the `project.godot` file

### Running the Game

- Press **F5** in the Godot editor, or click the **▶ Play** button
- To export a build, go to **Project → Export** and select your target platform

---

## Project Structure

```
pajatro/
├─ design/             # Design documents & assets
│  ├─ documents/
│  └- assets/
│    ├─ sounds/        # Music, SFX
│    └─ sprites/       # 2D sprites & textures
├─ project/
│  └─ scenes/
│     ├─ game/         # Level scenes
│     └─ ui/           # UI scenes & scripts
├─ project.godot       # Godot project file
├─ .gitignore
├─ LICENSE
└─ README.md
```
---

## License

Distributed under the **MIT License**. See [`LICENSE`](LICENSE) for more information.