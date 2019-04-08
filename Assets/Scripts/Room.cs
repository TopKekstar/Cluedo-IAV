using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room : MonoBehaviour
{
    public GameInfo.ROOM_TYPE type;
    SpriteRenderer spriteRenderer;
    public RoomCell[] cells;
    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        cells = GetComponentsInChildren<RoomCell>();
    }

    // Start is called before the first frame update
    void Start()
    {
        if (spriteRenderer != null)
        {
            SetRoomColor();
        }
    }

    public RoomCell GetFreeCell()
    {
        int i = 0;
        while (cells.Length > i)
        {
            if (!cells[i].HasSomething)
            {
                return cells[i];
            }
            i++;
        }
        return null;
    }

    public RoomCell GetFreeCellRand()
    {
        return null;
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    void SetRoomColor()
    {
        spriteRenderer.color = GameInfo.GetRoomColor((int)type);
    }
}
