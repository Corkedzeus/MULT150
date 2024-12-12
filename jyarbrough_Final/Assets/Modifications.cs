/*
1   Directional Light- 
        -Intensity set to 2
        -Color changed
        -Direction changed behind the runner, placeing shadows in the front left of the player and other game objects
2   Fog-
        -Added in Exponential Squared mode
        -color changed
        -Density set to 0.1: moderate fog limits the player's abilivty to see the obstacles and powerup
3   Skybox-
        -NewSkybox created an applied
        -Atmoshpereic thickness increased (pollution)
        -wierd "alien" yellow/green color applied (color is purple, but Atmoshpereic pollution turnes it green)
OBSTACLE PREFAB
4   -TrafficConeStyle2
5   -Hierarchy created (empty Game object)
6   -2 New Textures applied
7   -Particle System added
        -Start Size changed to a range between 2 constants
        -Start color changed to Red
        -Shape left as cone; rotation change to (-90, 0, 0) Angle adjusted
        -Emission; Rate over time droped to 7.5
        -Render Mode changed to stretched billboard
8   -Powerup Prefab
        -Light color changed
        -Intensity increased
        -Range increased
WALL
9   -Walls renamed to Wall LEft/Wall Right
    -Wall Right Turned in to Prefab
    -Variant created and used to replace left wall
10  -Material Duplicated and renamed Wall Left/Wall right
    -Colors changed and applied to corresponding walls  

Utilized UI from Hour 14
    -Required adjustment to the level manager; had to assign correct scene name 
    -Changed TItle
    -Reviewed UI Chapter 14 and external video references for UI Creation.  
*/