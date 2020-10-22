using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : Icommand
{
    public GameObject player;
    Vector3 position;

    public MoveForward(Vector3 position, GameObject player)
    {
        this.player = player;
        this.position = position;
    }

    public void execute()
    {

        player.GetComponent<Rigidbody>().MovePosition(new Vector3(position.x+2.0f,position.y,position.z));


    }




}
