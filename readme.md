Unity Multiplayer (UNET) - Transport Layer API [C#][Stream VOD]
https://www.youtube.com/watch?v=qGkkaNkq8co

### Tutorial steps:
- step 1): initiate the `Network Transport Layer`
- step 2): two different pathways  ✓
- step 3): open another socket once client connects.


### Types:
- option 1) sync action -- this video
- option 2) async action 


### Concepts (crucial sentences)
- connection needs to be **maintained** generally. 
- ask yourself: 'does the receiver really need that info?'  ✓
- different code pathways execute: depending if you are the client or server.  ✓
- check every single frame if messages were sent.  ✓


### Terminology:
- sockets: (used to) send data back and forth.
- sockets: (used to) open a connection "between the *client* and the *game*."
- Network Transport Layer.
- reliable vs unreliable  ✓
- UNET: peer-to-peer.
- host: define on BOTH the client and the server. ✓
- client: will connects with a simply line of code.
- server: will wait for a connection and wait for messages.



###### Legend 
✓ (checkmark) -- understand reason why.
CAPITALS -- personal emphasis.
`backticked` -- tech keyword i want to emphasize.
