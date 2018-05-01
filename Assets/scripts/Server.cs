using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Server : MonoBehaviour {

    private const int MAX_CONNECTION = 100;

    private int port = 5701;
    private int webHostId;

    private int reliableChannel;
    private int unreliableChannel;

    private bool isStarted = false;
    private byte error;

}
