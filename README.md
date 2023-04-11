# Ball Adventure in Unity
## A simple 3D game about overcoming various obstacles with a ball. I created it in 2020 as a learning project.

### Player controller script description:
This is a script written in C# for the Unity game engine. It defines the behavior of a player character in the game. Here is a summary of what the script does:

It defines variables for various game objects, as well as for tracking whether the player is on the ground, whether the game is over, and whether the player has collected some kind of energy resource.
In the Start() method, it initializes these variables and sets up the camera to follow the player character.
In the FixedUpdate() method, it updates the player's movement and camera position each frame. If the game is over, it either decrements the player's lives or displays the "game over" screen.
In the Update() method, it allows the player to press certain keys to reset their velocity or teleport to a specific location (for testing purposes only).
Finally, there is a private method called OrbitCamera() that handles the rotation of the camera around the player character based on the player's input.
