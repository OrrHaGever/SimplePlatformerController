# SimplePlatformerController
made by Orr Maoz
 
Simple player controller for 2D platformer games made with Unity
This repo contains a sample scene with a platform and a player.
My controller script is attached to the player and can be easily reused in any 2D platformer game.

## How to use it in your game:
- Fisrt, create a new scene in Unity.
- Create a platform with a collider on it and crate a player object. Player object can have a sprite or just be a simple shape. In this example our player will be a simple circle.
- Add a rigidbody component and a collider component to the player object and then attach the script to it.
- Create an empty game object as a child of the player object for the ground checker, then assign it to the groundCheck variable from the editor.
- Set the public variables in the editor to whatever you like.


This is an example for my parameters.

![Script](https://user-images.githubusercontent.com/58950809/147883267-28346bbe-21ba-422f-858b-6767f4a42506.png)


Tune the rigidbody parameters accordingly untill you get smooth running and crisp jumping.

![rb](https://user-images.githubusercontent.com/58950809/147883273-53fa1027-ac43-4fb1-bb59-3b73dca03b4a.png)

**You are wellcome to use this script in your games!
**
