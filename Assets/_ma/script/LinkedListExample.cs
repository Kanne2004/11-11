using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinkedListExample : MonoBehaviour
{
    [SerializeField] private LinkedList myLinkedList = new LinkedList();
    // Start is called before the first frame update
    void Start()
    {
        myLinkedList.AddFirst(1);
        myLinkedList.AddLast(2);
        myLinkedList.AddLast(3);
        myLinkedList.AddFirst(5);
        myLinkedList.AddFirst(4);
        myLinkedList.AddFirst(6);
        myLinkedList.AddFirst(7);
        Node current = myLinkedList.Head;
        while (current != null)
        {
            Debug.Log(current.Value);
            current = current.Next;
        }
    }
    public class Node
    {
        public int Value;
        public Node Next;
        public Node(int value)
        {
            Value = value;
            Next = null;
        }
    }
    public class LinkedList
    {
        public Node Head;
        public void AddFirst(int value)
        {
            Node newNode = new Node(value); 
            newNode.Next = Head; //chuyen du lieu thanh Node ke tiep
            Head = newNode; //chuyen Node thanh du lieu moi de nhap
        }

        public void AddLast(int value)
        {
            Node newNode = new Node(value);
            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                Node current = Head; //tao 1 bien hien tai cho bang head
                while (current.Next != null)
                {
                    current = current.Next; //lui bien hien tai den khi rong thi gan
                }
                current.Next = newNode; //gan gtri node vua gan thanh node moi
            }
        }
    }
}
  
