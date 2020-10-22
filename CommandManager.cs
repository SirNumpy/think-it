using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class CommandManager : MonoBehaviour
{
    private static CommandManager _instance;
    public static CommandManager instance { 
        get { return _instance; } }
    List<Icommand> commandBuffer;
    void Start()
    {
        _instance = this;
         commandBuffer = new List<Icommand>();
        
    }
    public void AddComponent(Icommand command)
    {
        commandBuffer.Add(command);
    }
    
 
    public void OnPlay()
    {
        StartCoroutine(Play());
    }
    IEnumerator Play()
    {
        foreach(Icommand command in commandBuffer)
        {
            command.execute();
            yield return new WaitForSeconds(0.4f);
        }
    }
    
}
