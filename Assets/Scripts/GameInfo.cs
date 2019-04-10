using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameInfo
{
    public enum PROOF_TYPE
    {
        ROOM,
        PROSECUTED,
        GUN,
        NOTHING,
    }

    public enum ROOM_TYPE: int
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

    static Color[] prosecutedColor = {
        new Color(1,0,0),
        new Color(1,1,1),
        new Color(0,0,1),
        new Color(1,0,1),
        new Color(0,1,0),
        new Color(0,1,1),
        new Color(0,0,0),
    };

    public static Color GetProsecutedColor(int n)
    {
        return prosecutedColor[n];
    }

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

    public struct Proof
    {
        public PROOF_TYPE type;
        public int idProof;

        public Proof(PROOF_TYPE type, int idProof)
        {
            this.type = type;
            this.idProof = idProof;
        }

        public Proof(ROOM_TYPE room)
        {
            this.type = PROOF_TYPE.ROOM;
            this.idProof = (int)room;
        }

        public Proof(PROSECUTED prosecuted)
        {
            this.type = PROOF_TYPE.PROSECUTED;
            this.idProof = (int)prosecuted;
        }

        public Proof(GUN_TYPE gun)
        {
            this.type = PROOF_TYPE.GUN;
            this.idProof = (int)gun;
        }

        public static bool operator ==(Proof proof,ROOM_TYPE r)
        {
            if(proof.type != PROOF_TYPE.ROOM)
            {
                return false;
            }
            if (proof.idProof != (int)r)
            {
                return false;
            }
            return true;
        }
        public static bool operator !=(Proof proof, ROOM_TYPE r)
        {
            return !(proof==r);
        }

        public static bool operator ==(Proof proof, PROSECUTED p)
        {
            if (proof.type != PROOF_TYPE.PROSECUTED)
            {
                return false;
            }
            if (proof.idProof != (int)p)
            {
                return false;
            }
            return true;
        }
        public static bool operator !=(Proof proof, PROSECUTED p)
        {
            return !(proof == p);
        }

        public static bool operator ==(Proof proof, GUN_TYPE g)
        {
            if (proof.type != PROOF_TYPE.ROOM)
            {
                return false;
            }
            if (proof.idProof != (int)g)
            {
                return false;
            }
            return true;
        }
        public static bool operator !=(Proof proof, GUN_TYPE g)
        {
            return !(proof == g);
        }
    }

    public static List<Proof> CreateAllPendingProofs(ROOM_TYPE room, PROSECUTED prosecuted, GUN_TYPE gun)
    {
        List<Proof> proofs = new List<Proof>();
        int i = 0;
        while (i < (int)ROOM_TYPE.NONE)
        {
            if(room != (ROOM_TYPE)i)
                proofs.Add(new Proof((ROOM_TYPE)i));
            i++;
        }

        i = 0;
        while (i < (int)PROSECUTED.NONE)
        {
            if (prosecuted != (PROSECUTED)i)
                proofs.Add(new Proof((PROSECUTED)i));
            i++;
        }

        i = 0;
        while (i < (int)GUN_TYPE.NONE)
        {
            if (gun != (GUN_TYPE)i)
                proofs.Add(new Proof((GUN_TYPE)i));
            i++;
        }

        return proofs;
    }

    
    public struct Accusation
    {
        public ROOM_TYPE room;
        public PROSECUTED prosecuted;
        public GUN_TYPE gun;

        public Accusation(ROOM_TYPE room, PROSECUTED prosecuted, GUN_TYPE gun)
        {
            this.room = room;
            this.prosecuted = prosecuted;
            this.gun = gun;
        }

        public bool HasProof(Proof proof)
        {
            if(proof == room || proof == prosecuted || proof == gun)
            {
                return true;
            }
            return false;
        }

        public static bool operator ==(Accusation a1, Accusation a2)
        {
            return (a1.room == a2.room && a1.prosecuted == a2.prosecuted && a1.gun == a2.gun);
        }

        public static bool operator !=(Accusation a1, Accusation a2)
        {
            return !(a1 == a2);
        }
    }
    

}
