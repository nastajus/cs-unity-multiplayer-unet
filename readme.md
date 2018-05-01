Unity Multiplayer (UNET) - Transport Layer API [C#][Stream VOD]
https://www.youtube.com/watch?v=qGkkaNkq8co

### Concepts
- actually uses `sockets`.  
- connection needs to be **maintained** generally.
- ask yourself: 'does the receiver really need that info?'
- host: define on BOTH the client and the server. (? --> indeed, does sound weird like he says.)


### Lower level concepts:
- sockets: opens a connection "between the *client* and the *game*."


### Lower level terminology:
- sockets: sends data back and forth.
- UNET: peer-to-peer.
- low-level api: network transport api.
- Network Transport Layer.
- reliable vs unreliable channels.
- host.

### Tutorial steps:
- step 1): initiate the `Network Transport Layer`


### Verbose Notes as Landmark Reminders:
- option 1) sync action:  racing game, an MMO game, etc. -- anything really for instant action.
- option 2) async action:  so say every 10 seconds, a request is created and there's a response. 
	- like Pokemon Go, uses a *web server*-style networking connection maintenance method instead. 


