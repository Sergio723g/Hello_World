using Unity.VisualScripting;
using UnityEngine;

public class MiScriptTest : MonoBehaviour
{
    public int varPublic;
    public int varSecret;
    Object[] NewArray;
    Object[] allTheGameObjects;
    [Serialize]
    public Color color;
    [Serialize]
    public bool findByTag;
    [Serialize]
    public string choosenTag;

    void Start()
    {
        NewArray = GameObject.FindObjectsByType<MonoBehaviour>(FindObjectsSortMode.None);
        /*if (findByTag)
            else { 
                allTheGameObjects = GameObject.FindObjectsByType<MonoBehaviour>(F);
                }*/
    }
    void Update()
    {
        foreach (var item in NewArray)
        {
            if (item.name == "MiScriptTest")
            {
                varPublic = 1;
                varSecret = 1;
            }
        }
    }

}

