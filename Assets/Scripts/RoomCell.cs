using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomCell : MonoBehaviour
{
    public Room room;

    public bool HasSomething
    {
        get
        {
            return okupa != null;
        }
    }

    public GamePiece okupa;

    // Start is called before the first frame update
    void Start()
    {
        room = GetComponentInParent<Room>();
        okupa = null;
    }

    public void FillCell(GamePiece fill)
    {
        okupa = fill;
    }

    

    // Update is called once per frame
    void Update()
    {
        
    }
}
