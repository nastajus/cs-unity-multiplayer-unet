Unity Multiplayer (UNET) - Transport Layer API [C#][Stream VOD]
https://www.youtube.com/watch?v=qGkkaNkq8co

### Concepts
- actually uses `sockets`.  
- connection needs to be **maintained** generally. 
- ask yourself: 'does the receiver really need that info?'  ✓
- host: define on BOTH the client and the server. ✓
- different pathways executed: depending if you are the client or server.  ✓
- check every single frame if messages were sent.  ✓


### Lower level concepts:
- sockets: opens a connection "between the *client* and the *game*."


### Lower level terminology:
- sockets: sends data back and forth.
- UNET: peer-to-peer.
- low-level api: network transport api.
- Network Transport Layer.
- reliable vs unreliable channels  ✓
- host: both  ✓
- client: will connects with a simply line of code.
- server: will wait for a connection and wait for messages.


### Tutorial steps:
- step 1): initiate the `Network Transport Layer`
- step 2): two different pathways  ✓
- step 3): open another socket once client connects.


### Verbose Notes as Landmark Reminders:
- option 1) sync action:  racing game, an MMO game, etc. -- anything really for instant action.
- option 2) async action:  so say every 10 seconds, a request is created and there's a response. 
	- like Pokemon Go, uses a *web server*-style networking connection maintenance method instead. 



### Unrelated questions inspired and paged out
- understand difference between physics-based `FixedUpdate` calls vs. regular `update` calls. --> deemed irrelevant for now.


###### Legend 
✓ (checkmark) -- understand reason why.
CAPITALS -- personal emphasis.
`backticked` -- tech keyword i want to emphasize.
