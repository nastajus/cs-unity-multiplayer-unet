using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;


public class Server : MonoBehaviour
{

    private const int MAX_CONNECTION = 100;

    private int port = 5701;

    //web sockets related
    private int hostId;
    private int webHostId; 

    //tcp or udp related.
    private int reliableChannel;
    private int unreliableChannel;

    private bool isStarted = false;
    private byte error;

    private void Start()
    {
        NetworkTransport.Init();
        ConnectionConfig cc = new ConnectionConfig();

        reliableChannel = cc.AddChannel(QosType.Reliable);
        unreliableChannel = cc.AddChannel(QosType.Unreliable);

        HostTopology topo = new HostTopology(cc, MAX_CONNECTION);

        hostId = NetworkTransport.AddHost(topo, port, null); //null accepts connections from EVERYBODY.
        //you have to use a linux standalone build or etc.
        webHostId = NetworkTransport.AddWebsocketHost(topo, port, null);

        isStarted = true;
    }

}
