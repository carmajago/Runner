using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class EditorController : MonoBehaviour {

    public GameObject items;

    public float scaleObject=1f;

    public GameObject prefabActivo;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //pc
        if (Input.GetMouseButtonUp(0) && !EventSystem.current.IsPointerOverGameObject())
        {
            crearGameObject();
           
        }

        //Movil
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended && !EventSystem.current.IsPointerOverGameObject(Input.GetTouch(0).fingerId))
        {
            crearGameObject();
        }

    }

    void crearGameObject()
    {
        Vector2 mouseClick = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        float x =mouseClick.x-( mouseClick.x % scaleObject);
        float y = mouseClick.y - ( mouseClick.y % scaleObject);


        if (x >= 0)
        {
            x += (scaleObject / 2f);

        }
        else
        {
            x -= (scaleObject / 2f);

        }
        if (y >= 0)
        {
            y += (scaleObject / 2f);

        }
        else
        {
            y -= (scaleObject / 2f);
        }

        Instantiate(prefabActivo, new Vector3(x, y,0), Quaternion.identity);



    }


    void existGameObject()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        RaycastHit2D hit = Physics2D.Raycast(mousePos,Vector3.forward);
        if (hit.collider != null)
        {
            Debug.Log(hit.transform.name);
            
           
        }
    }
}
