﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Client : MonoBehaviour {

    private const int MAX_CONNECTION = 100;

    private int port = 5701;

    private int hostId;
    private int webHostId;

    private int reliableChannel;
    private int unreliableChannel;

    private bool isStarted = false;
    private byte error;

    //not in Start() but rather on demand:
    public void Connect()
    {
        NetworkTransport.Init();
        ConnectionConfig cc = new ConnectionConfig();

        reliableChannel = cc.AddChannel(QosType.Reliable);
        unreliableChannel = cc.AddChannel(QosType.Unreliable);

        HostTopology topo = new HostTopology(cc, MAX_CONNECTION);

        hostId = NetworkTransport.AddHost(topo, port, null); //null accepts connections from EVERYBODY.
        //does not exist. 
        //you cannot start a server in a web browser.
        //you have to use a linux standalone build or etc.
        //you can only use the Client in the browser, not the server.
        //webHostId = NetworkTransport.AddWebsocketHost(topo, port, null);

        isStarted = true;
    }

}
