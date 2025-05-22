# Endless Runner Prototype

This Unity project is a basic prototype of an Endless Runner game, developed using Unity 6. The core mechanics include dynamic platform spawning, platform movement to simulate player motion, and cleanup of unused objects for performance optimization.

## Overview

The project demonstrates fundamental concepts of endless runner games, where the player appears to move forward indefinitely while platforms continuously spawn ahead and disappear behind.

## How It Works

### Platform Spawning

Platforms are instantiated dynamically when a trigger collider is activated. This allows the environment to extend infinitely in the forward direction as the player progresses.

### Platform Movement

Each platform moves backward along the Z-axis at a constant speed. This creates the illusion that the player is running forward without actually moving the player character.

### Platform Destruction

To maintain performance and avoid clutter, platforms are destroyed once they move beyond a certain point, using a trigger tagged specifically for cleanup.

## Features

- Automated platform generation using trigger detection
- Continuous backward movement of platforms
- Efficient removal of platforms no longer in use
- Lightweight and modular code for easy integration and testing

## Project Structure

- `Scripts/PlatformSpawner.cs`: Handles the spawning of new platforms when triggered.
- `Scripts/PlatformMove.cs`: Controls platform movement and triggers destruction.
- `Prefabs/Platform.prefab`: A reusable platform object used for instantiation.
- `Scenes/MainScene.unity`: The primary scene used for testing the prototype.

## Getting Started

1. Open the project in Unity 6.
2. Add the `PlatformSpawner` script to a trigger object and tag it as `"Trigger"`.
3. Assign the `PlatformMove` script to the platform prefab.
4. Set up a secondary trigger with the tag `"Destroy"` to remove old platforms.
5. Play the scene to test the endless runner behavior.

## Requirements

- Unity 6 
- Basic understanding of Unity components such as GameObjects, Colliders, Tags, and Prefabs

## License

This project is licensed under the MIT License. You are free to use, modify, and distribute it for personal or commercial use.
