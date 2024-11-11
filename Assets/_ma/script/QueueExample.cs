using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QueueExample : MonoBehaviour
{
    [SerializeField] private Queue<string> myQueue = new Queue<string>();
    void Start()
    {
        myQueue.Enqueue("1st");
        myQueue.Enqueue("2nd");
        myQueue.Enqueue("3rd");

        while (myQueue.Count > 0)
        {
            string item = myQueue.Dequeue();
            Debug.Log(item);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
