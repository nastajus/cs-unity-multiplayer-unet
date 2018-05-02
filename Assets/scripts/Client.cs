using System.Collections;
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

    private int connectionId;

    private float connectionTime; //game flow
    private bool isConnected = false;
    private bool isStarted; //game flow
    private byte error;

    //not in Start() but rather on demand:
    public void Connect()
    {
        NetworkTransport.Init();
        ConnectionConfig cc = new ConnectionConfig();

        reliableChannel = cc.AddChannel(QosType.Reliable);
        unreliableChannel = cc.AddChannel(QosType.Unreliable);

        HostTopology topo = new HostTopology(cc, MAX_CONNECTION);

        hostId = NetworkTransport.AddHost(topo, port, null);

        connectionId = NetworkTransport.Connect(hostId, "localhost", port, 0, out error);

        connectionTime = Time.time;
        isConnected = true;
    }

    //start listening
    private void Update()
    {
        // we don't want Update to run if Client is not started. 
        if (!isStarted) return;

        int recHostId;
        int connectionId;
        int channelId;
        byte[] recBuffer = new byte[1024];
        int bufferSize = 1024;
        int dataSize;
        byte error;

        NetworkEventType recData = NetworkTransport.Receive(out recHostId, out connectionId, out channelId, recBuffer,
            bufferSize, out dataSize, out error);
        switch (recData)
        {
            case NetworkEventType.Nothing:          //1
                break;
            case NetworkEventType.ConnectEvent:     //2
                break;
            case NetworkEventType.DataEvent:        //3
                break;
            case NetworkEventType.DisconnectEvent:  //4
                break;
        }
    }

}
