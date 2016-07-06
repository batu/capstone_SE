using UnityEngine;
using Photon;

public class RandomMatchmaker : Photon.PunBehaviour {
    // Use this for initialization
    void Start() {
        PhotonNetwork.logLevel = PhotonLogLevel.Full;
        PhotonNetwork.ConnectUsingSettings("0.1");
    }

    public override void OnJoinedLobby() {
        PhotonNetwork.JoinRandomRoom();
    }

    void OnPhotonRandomJoinFailed() {
        Debug.Log("Can't join random room!");
        PhotonNetwork.CreateRoom(null);
    }

    void OnGUI() {
        GUILayout.Label(PhotonNetwork.connectionStateDetailed.ToString());
    }
}