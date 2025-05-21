STEP 1: Attach the Script: Create an empty GameObject or use your player GameObject, and attach the PlayerMovement script to it.

STEP 2: Add Rigidbody: Make sure your player has a Rigidbody component.

STEP 3: Set Ground Check: Create an empty GameObject and position it slightly below the player’s feet. Drag this GameObject into the groundCheck field in the script.

STEP 4: Set Ground Layer: Create a new layer called "Ground" (or use any layer you want) and assign it to the ground objects. In the script, select that layer for the groundLayer field.

STEP 5: Adjust Move Speed and Jump Force: You can modify the moveSpeed and jumpForce values in the Unity Inspector to tweak the movement behavior.

NOTE THAT WHEN USING 2D YOU NEED TO CHANGE THE CODE FROM Rigidbody TO Rigidbody2D WHICH MAKES JUMP NOT WORK FOR SOME REASON
