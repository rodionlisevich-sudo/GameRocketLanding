# GameRocketLanding
The rocket automatically lands at a random point.The rocket can be restarted with the “R” button.You can add thrust to the top with the "W" button.The game has only three scripts: GameManager, LandingPlatformRandomTransform and RocketLanding.
GameManager launches the game, restarts it, and exits the game.
LandingPlatformRandomTransform moves the platform to the unpacked coordinates.
RocketLanding fires the rocket engine if the landing time is less than 3s, if the altitude is less than 1.1f the engine is turned off and the LandingManeuver() method brings the rocket to the X coordinate.
This is my first project so it's extremely simple.
