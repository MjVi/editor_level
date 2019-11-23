using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main_Game : MonoBehaviour
{
    private float distance = 3f;
    public static Vector2 objPosition;
    private List<Vector2> positions_enemy = new List<Vector2>();
    private List<Vector2> positions_movil = new List<Vector2>();
    private List<Vector2> positions_fijo = new List<Vector2>();

    void OnMouseDrag()
    {
        if (Player_Control.play == false)
        {
            Vector2 mousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
            transform.position = objPosition;
        }

    }

    public void Guardar()
    {
        GameObject[] goToSave_enemy = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (var go in goToSave_enemy)
        {
            positions_enemy.Add(new Vector2(go.transform.position.x, go.transform.position.y));
        }

        GameObject[] goToSave_movil = GameObject.FindGameObjectsWithTag("Plat_movil");
        foreach (var go in goToSave_movil)
        {
            positions_movil.Add(new Vector2(go.transform.position.x, go.transform.position.y));
        }

        GameObject[] goToSave_fijo = GameObject.FindGameObjectsWithTag("Plat_movil");
        foreach (var go in goToSave_movil)
        {
            positions_movil.Add(new Vector2(go.transform.position.x, go.transform.position.y));
        }

    }
}
