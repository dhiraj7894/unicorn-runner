CERULEAN CAT STUDIO, LLC
Animated Horse Pack
version 1.3

The Animated Horse Package includes three different resolutions; low res for mobile games, medium res for PC and console games, and high res for those up close cut scene animations. You can find them in the Source folder.

Horse High Res has 22,335 triangles, and 11,176 vertices
Horse Medium Res has 5,033 triangles, and 2,524 vertices
Horse Low Res has 2,064 triangles, and 1,034 vertices

The high and medium res horses each have 51 bones. 
The low res horse has 39 bones.


There are 14 animations including 5 gaits, 6 actions, and 3 idle cycles.
The animation cycles begin and end at the following key frames:

-BASIC GAITS-
Walk: 3 – 27
Trot: 42 – 57
Canter: 72 – 83
Gallop: 97 – 108
Back Up: 122 – 146

-ACTIONS-
Jump: 162 – 201
Skid: 217 – 254
Rear Up: 267 – 329
Kick / Fight: 342 – 378
Hit: 392 – 412
Death: 432 – 459

-IDLE CYCLES-
Paw: 482 – 552
Scratch and Chew: 562 – 722
Snooze: 752 – 1028

The basic Standing Pose is located at frame 1,062

These animations and pose are already laid out in the HorseAnim controller which is located in the Controllers folder. They are associated with the Horse_Med_Res source file and avatar.  There is also a rudimentary animator tree laid out that can be adjusted in whatever way you see fit.
In order to attach a rider to the horse, the rider should have their root bone follow the horses “spinebeginning” bone.


The Animated Horse Package includes eight coat color textures in the Textures folder. 
The textures are high res 4096 x 4096, medium res 2048x2048, and low res 1024 x 1024.
For the high and medium resolution horses there are separate files for the horse's mane and tail texture. The tail is attached and the texture baked down for the low resolution version. All textures are in the PNG format. 

These are the names of the coat files:

BUCKSKIN:
BuckHigh
BuckMed
BuckLow
BuckHair (for high and medium res horses)

GREY:
GreyHigh
GreyMed
GreyLow
GreyHair (for high and medium res horses)

CHESTNUT:
ChesHigh
ChesMed
ChesLow
ChesHair (for high and medium res horses)

PALOMINO:
PaloHigh
PaloMed
Palo Low
PaloHair (for high and medium res horses)

BAY:
BayHigh
BayMed
BayLow
BlackBayHair (for high and medium res horses)

BLACK:
BlackHigh
BlackMed
BlackLow
BlackBayHair (for high and medium res horses)

WHITE:
WhiteHigh
WhiteMed
WhiteLow
WhiteHair (for high and medium res horses)

PAINT:
PaintHigh
PaintMed
PaintLow
PaintHair (for high and medium res horses)

The textures have already been set up as materials with normals and specular in the Materials folder.

Prefabrications of all three resolutions of horse have been made in each of the coat colors. They are located in the Prefabs folder under the sub folders for high, low, and medium resolutions. Simply select the horse of the appropriate resolution and coat color, then drag and drop him into your scene.

Version 1.3's update has corrected some model rotation issues. Note: older prefabs will need to be replaced with the corrected versions.
