Unity Multiplayer (UNET) - Transport Layer API [C#][Stream VOD]
https://www.youtube.com/watch?v=qGkkaNkq8co
by Michael Doyon

### Tutorial steps:
- step 1): initiate the `Network Transport Layer`
- step 2): two different pathways  ✓
- step 3): open another socket once client connects.


### Networking Types:
- option 1) sync action -- this video
- option 2) async action 


### Concepts (crucial sentences)
- connection needs to be **maintained** generally. 
- ask yourself: 'does the receiver really need that info?'  ✓
- different code pathways execute: depending if you are the client or server.  ✓
- check every single frame if messages were sent.  ✓
- types of messages (only four): 1) nothing, 2) connected, 3) data, 4) disconnect.


### Terminology:
- sockets: (used to) send data back and forth.
- sockets: (used to) open a connection "between the *client* and the *game*."
- host: defined on BOTH the client and the server. ✓
- host: Starting a “Host” == Opening a Socket. ✓

- Network Transport Layer.
- reliable vs unreliable  ✓
- client: will connects with a simply line of code.
- server: will wait for a connection and wait for messages.

- LLAPI: Low-Level API (Unity-specific).
- UNET: peer-to-peer (Unity-specific).

### Networking-specific Code snippets used:
- `NetworkTransport.Receive` will receive packets.


### Unity Code snippets used:
- `GameObject.Find("NameInput").GetComponent<InputField>().text` plus `using UnityEngine.UI;` to refer to editor hierarchy > Canvas > InputField > text object.


### Off-topic questions:
- `FixedUpdate()` vs `Update()` -- what are the differences, or when to care to use Fixed?
- `private void Start()` -- what **benefit** does limiting **access modifier** to private scope give us on Unity's MonoBehavior's methods, since they're only known via reflection.


###### Legend 
✓ (checkmark) -- understand reason why.
CAPITALS -- personal emphasis.
`backticked` -- tech keyword i want to emphasize.
