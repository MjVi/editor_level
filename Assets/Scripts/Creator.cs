using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creator : MonoBehaviour
{
    public Transform plat_movil;
    public Transform plat_fija;
    public Transform enemy;

    public void Create_plat_movil()
    {
        if (Player_Control.play == false)
        {
            Instantiate(plat_movil, gameObject.transform.position, Quaternion.identity);
        }
    }

    public void Create_plat_fija()
    {
        if (Player_Control.play == false)
        {
            Instantiate(plat_fija, gameObject.transform.position, Quaternion.identity);
        }
    }

    public void Create_enemy()
    {
        if (Player_Control.play == false)
        {
            Instantiate(enemy, gameObject.transform.position, Quaternion.identity);
        }
    }
}
