using UnityEngine;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;


public class UdpClientUnity : MonoBehaviour {

    UdpClient server;

    IPEndPoint clientEP;

    Thread receiveThread;

    void Start() {
        server = new UdpClient(5000);
        clientEP = new IPEndPoint(IPAddress.Any, 0);
        receiveThread = new Thread(ReceiveData);
        receiveThread.Start();
        Debug.Log("Servidor iniciado na porta 5000");
    }
}