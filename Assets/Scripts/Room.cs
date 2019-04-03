using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room : MonoBehaviour
{
    public GameInfo.ROOM_TYPE type;
    SpriteRenderer spriteRenderer;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        
    }

    // Start is called before the first frame update
    void Start()
    {
        if(spriteRenderer != null)
        {
            spriteRenderer.color = GameInfo.GetRoomColor((int)type);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SetRoomColor()
    {

    }
}
