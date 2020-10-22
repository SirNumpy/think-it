using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : Icommand
{
    public GameObject player;

    Vector3 position;
    public MoveLeft(Vector3 position, GameObject player)
    {
        this.player = player;
        this.position = position;
    }

    public void execute()
    {

        player.GetComponent<Rigidbody>().MovePosition(new Vector3(position.x , position.y, position.z-2.0f));


    }


}
