# basketBallGame

HTC Vive Support and Troubleshooting And Basket Ball Game Documentation:
Minimum Requirements for Htc vive:

	Minimum system requirements for the HTC Vive have been unveiled, and they're as demanding as you'd expect.
	GPU: NVidia GeForce GTX 970, AMD Radeon R9 290 equivalent or better.
	CPU: Intel i5-4590, AMD FX 8350 equivalent or better.
	RAM: 4 GB or more.
	Video Output: HDMI 1.4, DisplayPort 1.2 or newer.

Note:
If you setup every things correctly but still the device is not working properly then it will probably be the hardware issue.
Furthermore you can check your device if it is capable or not using this link.
https://help.steampowered.com
Drivers and Software:
For further support please use the following link.
https://www.vive.com/us/support/
For downloading software use the following link.
https://www.vive.com/us/setup/

Setting Up Virtual Reality Device for First Time:
Some of the important component of the HTC vive are.
1.	Headset
2.	Base Station(1 Pair)
3.	Mounting kits (For fixing the Base Station on the wall).
4.	Sync Cable (Optional if base station cannot see each other).
5.	3 Power Plug. (1 for headset and 2 for pair of base stations).
6.	Vive controller (1 Pair left and Right).
7.	Link box (which links headset to the laptops/pc or screens).

Installing the Base Station:
   
        

1.	Fix the mounting kits on the wall/roof with the help of screws, diagonally at the opposite corner of the space.
2.	Now attached both the base station to the mounting kits so that the front panels facing towards the center of your free space/play area. (30-45 degree down the base Stations to play area).
3.	Attached the power adaptor to both the base station and switched it on.
4.	Base station should not be 5m or 16 feet apart.
5.	Base station should not be higher than 6.5 feet above the ground.
6.	If space between the Base stations make it impossible to see each other than attached the sync cable.

Base Station Working or Not: 
  If both base station LEDs don't turn Green after 10-15 seconds, something may be wrong try one of the following method. 
	If the LED is blue, it is still spinning up and waiting to stabilize. If it never changes from blue, check to make sure the base is mounted securely. Vibrations can cause it to be stuck in this state.
	If the LED is off, it doesn't have power – make sure that the power cord is plugged in and your outlet isn't connected to a light switch.
	If the LED is slowly blinking Green, it's in standby mode. Try on/off.
	If the LED is solid or blinking purple, the base stations are having trouble seeing each other. Make sure nothing is in the way.




Connecting Link Box And Headset:

	Connect one side of the HDMI cable to the Linked Box and other side to your PC/Laptop graphic card HDMI cable.
	Plug the one side of the Usb cable to the linked box and other side to pc.
	On the other side of the link box. Connect all the headset cable to the yellow ports.
	Finally, plug the power cord into the Link Box, and plug it into a power outlet.




Basketball Game Using VR Htc vive

Introduction:
  
 As the name explain the functionality of the game. But beside this there is something important to mention that the game this game is only single player and the player be able to pick the ball and throw it in the basket to get score.

Controls:
                   Grab button of controllers:    Use for picking the ball.	
                   Touchpads                           :    Use for movement in the play area.
                   
Programmatically Explanation: 
              The player has to place the controller right on the ball and have to press the Grab button of the controller. By pressing the button VRTK_InteractGrab script activated and the using the OnControllerGrabInteractableObject  the basketball is attached to the controller. Now when the player angle the ball and release the grab button the ThroReleaseObjectfunction is called and the ball is detached from the controllers mean while the velocity of the controllers velocity and angularVelcity  variables get there velocities from controllerEvents.GetVelocity() and controllerEvents.GetAngularVelocity built-in functions respectively.
On the both the basket the box colliders is attached and Is Trigger is activated. We have a counter name Gamescore. If the basketball is passed through the collider the OnTriggerEnter  function inside the score.c is activated and the counter is increase one count and the score is displayed.
                                                                                                                                The End 

