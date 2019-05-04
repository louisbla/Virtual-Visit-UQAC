Virtual Visit UQAC

Outil de visite virtuelle développée via Unity. 
Exemple d'application avec des photos 360 de l'Université du Québec à Chicoutimi

Les photos 360° sont placées selon un repère sur 3 axes (x,y,z)
Le nom de chaque photo correspond à sa position dans l'espace.
La photo 0-0-0 représente la photo de départ.

Scripts en C# :
-Le script "VRInputModule.cs" permet l'utilisation des contrôleurs de l'oculus rift. (dont le click sur le joystick qui permet le déplacement)
-Le script "Pointer.cs" permet d'afficher un laser émit depuis le contrôleur de la main droite. Il permet de respérer la direction dans laquelle l'utilisateur souhaite se déplacer.
-Le script "scriptButton.cs" permet le déplacement de l'utilisateur dans l'espace. Lorsque l'utilisateur pointe le laser dans une direction et qu'il clique sur le joystick, il se déplace dans cette direction (à condition qu'une photo soit associée à la nouvelle position)
