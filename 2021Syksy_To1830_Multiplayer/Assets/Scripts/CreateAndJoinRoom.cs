using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Photon.Pun;
using Photon.Realtime;
public class CreateAndJoinRoom : MonoBehaviourPunCallbacks
{
    public TMP_InputField createInput;
    public TMP_InputField joinInput;


    public void CreateRoom()
    {
        RoomOptions roomOptions  = new RoomOptions();
        ExitGames.Client.Photon.Hashtable roomCustomProps = new ExitGames.Client.Photon.Hashtable();
        roomCustomProps.Add("RedScore",0);
        roomCustomProps.Add("BlueScore",0);
        roomOptions.CustomRoomProperties = roomCustomProps;
        //Tällä käskyllä luodaan serverille uusi huone
        PhotonNetwork.CreateRoom(createInput.text,roomOptions);
    }

    public void JoinRoom()
    {
        //Tällä käskyllä liitytään valmiina olevaan huoneeseen
        PhotonNetwork.JoinRoom(joinInput.text);
    }


    public override void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel("Game");
    }
}
