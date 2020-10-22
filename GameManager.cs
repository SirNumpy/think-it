using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    GameObject player;
   Vector3 playerPosition=new Vector3(0,1,0);
    Vector3 position;
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        position = playerPosition;
        
    }
    private void Update()
    {
        playerPosition = player.transform.position;
    }
    public void MoveRight()
    {
        Icommand command = new MoveRight(position,player);
        CommandManager.instance.AddComponent(command);
        position = position + new Vector3(0, 0, 2);

    }
    public void MoveLeft()
    {
        Icommand command = new MoveLeft(position, player);
        CommandManager.instance.AddComponent(command);
        position = position + new Vector3(0, 0, -2);
    }
    public void MoveForward()
    {
        Icommand command = new MoveForward(position, player);
        CommandManager.instance.AddComponent(command);
       position= position + new Vector3(2, 0, 0);
    }
}