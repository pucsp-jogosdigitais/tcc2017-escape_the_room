using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Info
{
    public int lives = 3;
    private static Info instance;
    public static Info Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new Info();
            }

            return instance;
        }
    }
}
