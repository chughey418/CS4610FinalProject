# CS4610FinalProject
CS 4610 Final Project

# Demo
Youtube Link: https://youtu.be/i0Q4JU9Vtok

# To Run
- Open project in Unity. Select "Menu" scene in Project area. Click the play button to run the game.

# Project Description:
- Our game is called “Mermaid Maze”. It is a first person game where the user is placed inside a procedurally generated underwater maze. The goal of the game is to find the hidden treasure chest before the timer runs out. The game features multiple scenes with navigation options for the user.
- WASD or the arrows are used to move the character, your mermaid, around the maze.
- The mouse is used to rotate the camera to view the maze.

# Explanation of Methods:
### Scripts

**FPSMovement**  
*This script controls user movement throughout the maze*  
-   User/ camera position and rotation is updated every frame and corresponds to user input (WASD button presses and mouse movement)  


**GameController**  
*This script controls the overall game.*  
- A new maze is procedurally generated [using MazeConstructor script].
- A start trigger is placed at the user start position and a treasure chest is placed in the maze.
- The game starts.
- As the user is moving around the maze, the timer is decreasing. The game ends when the timer reaches 0 or when the user reaches the treasure chest.  


**MazeConstructor**  
*This script contains the methods that are used to set up a randomly generated maze and place game objects accordingly.*  
- It contains the method that constructs a maze [using MazeDataGenerator and MazeMeshGenerator scripts]. 
- It contains the methods that place a start trigger and a treasure chest in their correct spots within the maze.  


**MazeDataGenerator**  
*This script generates data for the maze.*  
- It determines whether a space is empty using placementThreshold.
- It is instantiated in MazeConstructor.
- The code operates on every other cell and assigns a 1 to generate the maze.  


**MazeMeshGenerator**  
*This script generates the maze mesh*  
- It uses vertices, UV coordinates and triangles to comprise the mesh.
- It then creates two triangles to make a square which then makes up the floor, ceiling, and walls.
- It is instantiated in MazeConstructor.  


### Scenes
**Main Menu**  
- This menu begins the game and allows the user the option to play the game or to quit. Quit functionality doesn’t work when rendering in Unity, but would work if you exported and built the application.  


**Scene**  
- This is the main scene that shows the procedurally generated maze. It begins with the user in a start location and the user navigates through the maze to find the treasure chest. This scene also includes a timer that the user must complete the game before the time runs out.  


**Game Over**  
- This menu appears when the user runs out of time before finding the treasure chest. If the user selects “Play Again”, another maze is generated, but if the user selects “Quit”, they are navigated back to the main menu.  
**Win Menu**  
- This menu appears when the user wins the game. If the user selects “Play Again”, the maze game starts again and if the user selects “Quit”, they are navigated back to the main menu.  

# Remaining Issues/ Potential Solutions:
- We were unable to successfully add a shark enemy to our game as we had originally planned. We were able to add the shark into the maze, but we could not get it to move around the maze. We tried creating a NavMesh at runtime so that the shark could search for the user, however, we were not able to implement the NavMesh correctly. If we had more time, our solution would be to do some additional research on implementing NavMeshes at runtime (since our maze is procedurally generated). The shark would be the NavMesh agent and the user would be its target. 

# Team Member List & Roles:
**Claire Hughey**  
- Created underwater environment
- Added treasure chest to the game 
- Worked on adding a shark enemy   


**Kaitlyn Zahn**  
- Implemented procedural maze generation
- Created scene menus- Main Menu, You Win Menu, and Game Over Menu
- Customized the UI

