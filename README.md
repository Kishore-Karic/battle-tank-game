# battle-tank-game
Training project using Unity's Battle Tank base artwork
3D Tank Game from Outscal Project.

I have used 6 Design Patterns to make it as an Optimized game.

Design Patterns,

Generic Singleton - Created Generic Singleton and make Service script as Singletons from Generic Singleton.
MVC-S - Created Model View Controller(MVC) for Tanks and Bullets and separate Service for Tanks and Bullets which handle MVC.
Scriptable Objects - As of now there is 3 different types of Tanks and Bullets, so handle the separate data for each type with Scriptable Objects and there will be Scriptable Object List to store these types separate for tanks and Bullets. Also used this to store Achievement System details.
State Machine - Created State Machine for Enemy they have 5 different States Idle, Patrol, Chase, Attack and Dead state, and they will go from one state one to another state according to the conditions.
Observer Pattern - Created Achievement System using Observer Pattern. so, the Observer look for progress to meet its conditions and then update the Achievement.
Object Pooling - used Object Pooling for Instantiate all of the required GameObjects(Tanks, Bullets, Particle Effects) at the Start and only Enable and Disable the GameObjects to reduce System Load.

Main Functionalities,

3 types of Tanks - BlueTank - High movement speed, Slow turn speed with High Health
          GreenTank - Medium movement speed, Medium turn speed with Medium Health
          RedTank - Slow movement speed, High turn Speed with Low Health

3 types of Bullets - FastBullet  - Low damage, High speed for BlueTank
           NormalBullet - Medium damage, Medium speed for GreenTank
           SlowBullet  - High damage, Low speed for RedTank

3 types of Achievement with Sub-Levels - BulletFired with 10 Sub-Levels
                    EnemyTanksDestroyed with 5 Sub-Levels
                    EscapeFromEnemyRange with 3 Sub-Levels

Other Functionalities,

Collectible Health - Added Collectible Health for Player when Health is below 50% and it will add 30%(from Total Health) to Player Health.
Indication Object - An Arrow Object will show direction for Collectible Health.
Achievement Panel - Achievement UI panel to display the Achievement Title and Description.
Health UI - Added Health UI for Player at the Top left on the Screen. Added Health UI for Enemies at the top of their Enemy Object and it will rotate according to Player's position.
Score System - Added Scores for completing Achievements and Tanks destroyed with UI panel to display Scores.
Sound System - Added Sounds with Sound Service for both Effects and Music.
