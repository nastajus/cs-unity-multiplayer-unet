Unity Multiplayer (UNET) - Transport Layer API [C#][Stream VOD]
https://www.youtube.com/watch?v=qGkkaNkq8co

### Concepts
- actually uses `sockets`.  
- connection needs to be **maintained** generally.


### Lower level concepts
- sockets: opens a connection "between the *client* and the *game*."
- UNET: peer-to-peer.


### More Landmark Reminder Notes
- option 1) sync action:  racing game, an MMO game, etc. -- anything really for instant action.
- option 2) async action:  so say every 10 seconds, a request is created and there's a response. 
	- like Pokemon Go, uses a *web server*-style networking connection maintenance method instead. 


