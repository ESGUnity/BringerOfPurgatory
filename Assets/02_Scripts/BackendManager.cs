using UnityEngine;
using BackEnd;

public class BackendManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        var backend = Backend.Initialize();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
