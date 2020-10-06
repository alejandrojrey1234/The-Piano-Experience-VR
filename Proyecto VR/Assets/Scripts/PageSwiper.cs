using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PageSwiper : MonoBehaviour, IDragHandler , IEndDragHandler
{
    private Vector3 panelLocation;
    public float percentThreshold = 0.2f;
    public int totalPages = 4;
    private int currentPage = 1;
    // Start is called before the first frame update
    void Start()
    {
        panelLocation = transform.position;
    }
    public void OnDrag(PointerEventData data)
    {
        //throw new System.NotImplementedException();
        float difference = data.pressPosition.x - data.position.x;
        transform.position = panelLocation - new Vector3(difference, 0, 0);
    }

    public void OnEndDrag(PointerEventData data)
    {
        float percentage = (data.pressPosition.x - data.position.x) / Screen.width;
        if(Mathf.Abs(percentage) >= percentThreshold){
            Vector3 newLocation = panelLocation;
            if(percentage > 0 && currentPage<totalPages)
            {
                newLocation += new Vector3(-Screen.width, 0, 0);
                currentPage++;

            }else if(percentage < 0 && currentPage > 1)
            {
                newLocation += new Vector3(Screen.width, 0, 0);
                currentPage--;
            }
            transform.position = newLocation;
            panelLocation = newLocation;
        }
        else {
            transform.position = panelLocation;
        }
    }
}
