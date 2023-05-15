# Battle Tank
Training project using Unity's Battle Tank base artwork
3D Tank Game from Outscal Project. <br/>
[Gameplay Trailer](https://drive.google.com/file/d/1NaOvFIAm1yc1RJYo-dXr7D84nWaSpCpP/view?usp=share_link) <br/>
[Playable Link](https://kishore-karic.itch.io/battletank) <br/>

# Game Functionality
1. 3 types of Tanks Blue, Green and Red tank.
2. 3 tupes of Bullets Slow, Medium and Fast.
3. Player can choose any from 3 tanks
4. There will be 3 Enemies at a time with any of the types randomly
5. Game run till Player death
6. All of the Enemies are patroling to random point until Player comes into range
7. 3 types of Achievemnts for Player, where each achievement can have 3 to 10 sub levels
8. Scores reward for Completing achievement and kill enemies
9. Collectible Health for Player
10. Indication Arrow to point Collectible Health
11. Player Health bar on UI and Enemy Health bar on top of that Enemy
12. Achievement panel to display Achievements
13. Sound system

# Design Patterns
* MVC for tanks and bullets
* Scriptable Objects for storing different types of datas of tanks and bullets
* State Machine for Enemies to do an tasks assigned for that states only
* Generic Object Pooling for tanks, bullets and particle effects to reusing same objects instead of Intantiate and Delete canstantly
* Observer Pattern for Achievements to keep track for conditions and call Observers
* Generic Singleton for Services like Player, Enemy, Bullets etc..

# Screenshots
![Picture_1](https://github.com/Kishore-Karic/battle-tank-game/assets/97879797/5355a938-ebcb-4fe0-bafe-a64243ca6d14)
![Picture_2](https://github.com/Kishore-Karic/battle-tank-game/assets/97879797/773bfe32-517c-4122-802c-2a9743b0a86b)
![Picture_3](https://github.com/Kishore-Karic/battle-tank-game/assets/97879797/9a044150-82e7-4331-bd20-8f6b6b0bd533)
![Picture_4](https://github.com/Kishore-Karic/battle-tank-game/assets/97879797/f0b08063-6e93-42d5-a4ee-109d611363ca)
