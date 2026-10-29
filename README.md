# Flappy Bird (Unity)

A small Flappy Bird clone built in Unity 2D.

## How to play

- Press **Space** to flap.
- Fly through the gaps between pipes. Each gap you pass is one point.
- Hitting a pipe ends the run; use the restart button to play again.

## Running it

1. Install Unity **2022.3.59f1** (LTS) through Unity Hub.
2. Clone this repo and open the folder as a project in Unity Hub.
3. Open `Assets/Scenes/SampleScene.unity` and press Play.

## Scripts

| Script | What it does |
| --- | --- |
| `BirdScript.cs` | Applies the flap impulse on Space and triggers game over on collision |
| `PipeSpawnerScript.cs` | Spawns pipe pairs at random heights on a timer |
| `PipeMoveScript.cs` | Scrolls pipes left and destroys them off-screen |
| `PipeMiddleScript.cs` | Trigger zone in each gap that adds a point |
| `LogicManagerScript.cs` | Tracks score, shows the game-over screen, restarts the scene |
