using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToTarget : MonoBehaviour
{
    public bool flag;
    public float speed;
    public Vector3 TargetPosition;
    private float distance;
    GameObject limite_izq;
    GameObject limite_der;

    void Start()
    {
        limite_der = new GameObject("limite_der");
        limite_izq = new GameObject("limite_izq");
        limite_der.transform.position = gameObject.transform.position + new Vector3(2, 0, 0);
        limite_izq.transform.position = gameObject.transform.position + new Vector3(-2, 0, 0);
        flag = true;
    }

    void Update()
    {
        if (Player_Control.play == true)
        {
            if (flag == true)
            {
                flag = false;
                limite_der.transform.position = gameObject.transform.position + new Vector3(2, 0, 0);
                limite_izq.transform.position = gameObject.transform.position + new Vector3(-2, 0, 0);
                TargetPosition = limite_der.transform.position;
            }

            distance = Vector3.Distance(gameObject.transform.position, TargetPosition);
            gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, TargetPosition, (Time.deltaTime * speed) / distance);

            if (distance < 0.2f)
            {
                if (TargetPosition == limite_der.transform.position)
                {
                    TargetPosition = limite_izq.transform.position;
                }
                else
                {
                    TargetPosition = limite_der.transform.position;
                }
            }
        }
    }
}
