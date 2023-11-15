using SocketIOClient.Newtonsoft.Json;
using SocketIOClient;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json.Linq;
using TMPro;

public class SocketCameraObject : MonoBehaviour
{
    public String PlayerName;

    public TMP_Text PalyerNameTmp;
    // Start is called before the first frame update
    void Start()
    {
        //TODO: check the Uri if Valid.
       // var uri = new Uri("http://192.168.1.168:3001");
        var uri = new Uri("http://169.254.180.207/16");
        var socket = new SocketIOUnity(uri, new SocketIOOptions
        {
            Query = new Dictionary<string, string>
                {
                    {"token", "UNITY" }
                }
            ,
            EIO = 4
            ,
            Transport = SocketIOClient.Transport.TransportProtocol.WebSocket
        });
        socket.JsonSerializer = new NewtonsoftJsonSerializer();

        ///// reserved socketio events
        socket.OnConnected += (sender, e) =>
        {
            Debug.Log("socket.OnConnected");
        };
        socket.OnPing += (sender, e) =>
        {
            Debug.Log("Ping");
        };
        socket.OnPong += (sender, e) =>
        {
            Debug.Log("Pong: " + e.TotalMilliseconds);
        };
        socket.OnDisconnected += (sender, e) =>
        {
            Debug.Log("disconnect: " + e);
        };
        socket.OnReconnectAttempt += (sender, e) =>
        {
            Debug.Log($"{DateTime.Now} Reconnecting: attempt = {e}");
        };
        ////

        Debug.Log("Connecting...");
        socket.Connect();

        socket.OnUnityThread("nameServer", (data) =>
        {
             var name= data.GetValue<string>();
        });
            
        var ReceivedText = "";
        socket.OnAnyInUnityThread((name, response) =>
        {
            var data= response.GetValue<string>();
            PlayerName = data;

            Debug.Log("PlayerName"+data.ToString());
        });
    }

    // Update is called once per frame
    void Update()
    {
            PalyerNameTmp.text = PlayerName;
        
    }
}
