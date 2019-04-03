using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameInfo
{
    public enum ROOM_TYPE
    {
        BIBLIOTECA,
        COCINA,
        COMEDOR,
        ESTUDIO,
        PASILLO,
        RECIBIDOR,
        BILLAR,
        BAILE,
        TERRAZA,
        NONE
    }

    public const int nRooms = (int)ROOM_TYPE.NONE;


    static string[] roomNames = {
        "Biblioteca",
        "Cocina",
        "Comedor",
        "Estudio",
        "Pasillo",
        "Recibidor",
        "Sala de billar",
        "Salon de baile",
        "Terraza",
        "THE VOID"
    };

    static Color[] roomColors = {
        new Color(1,0,0),
        new Color(0,1,0),
        new Color(0,0,1),
        new Color(1,1,0),
        new Color(1,0,1),
        new Color(0,1,1),
        new Color(0.5f,0.5f,0),
        new Color(0.5f,0,0.5f),
        new Color(0,0,0),
    };
    public static Color GetRoomColor(int n)
    {
        return roomColors[n];
    }

    public static string getRoomName(int n)
    {
        return roomNames[n];
    }

    public enum PROSECUTED
    {
        AMAPOLA,
        BLANCO,
        CELESTE,
        MORADO,
        PRADO,
        RUBIO,
        NONE
    }

    public const int nProsecuted = (int)PROSECUTED.NONE;

    static string[] prosecutedNames = {
        "Srta. Amapola",
        "Sr. Blanco",
        "Srta. Celeste",
        "Sr. Morado",
        "Padre Padro",
        "Cnel. Rubio",
        "NOBODY"
    };

    public static string getProsecutedName(int n)
    {
        return prosecutedNames[n];
    }

    public enum GUN_TYPE
    {
        CANDELABRO,
        CUERDA,
        HERRAMIENTA,
        PISTOLA,
        DAGA,
        TUBERIA,
        NONE
    }
    public const int nGuns = (int)GUN_TYPE.NONE;

    static string[] gunNames ={
        "Candelabro",
        "Cuerda",
        "Herramienta",
        "Pistola",
        "Puñal",
        "Tubería de plomo",
        "NOTHING"
    };
    public static string getGunName(int n)
    {
        return gunNames[n];
    }

}
