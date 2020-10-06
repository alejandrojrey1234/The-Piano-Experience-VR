using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;

public class LevelSelector : MonoBehaviour{
    public GameObject levelHolder;
    public GameObject levelIcon;
    public GameObject thisCanvas;
    public int numberOfLevels = 2;
    private Rect panelDimensions;
    private Rect iconDimensions;
    private int amountPerPage;
    private int currentLevelCount = 0;
    private string[] nombreScene = { "Concierto", "Synthwave", "Casa", "Parque" };
    private int[] numeroScene = { 2, 4, 3, 5 };
    public Sprite [] Images;
    public Button cambiar;
    public SeleccionarEscena seleccionarEscena;


    private void Start(){
        panelDimensions = levelHolder.GetComponent<RectTransform>().rect;
        iconDimensions = levelIcon.GetComponent<RectTransform>().rect;
        int maxInARow = 1;//Mathf.FloorToInt(panelDimensions.width / iconDimensions.width);
        int maxInACol = 1;//Mathf.FloorToInt(panelDimensions.height / iconDimensions.height);
        amountPerPage = maxInARow * maxInACol;
        int totalPages = Mathf.CeilToInt((float)numberOfLevels / amountPerPage);
        loadPanels(totalPages);
        
    }

    void loadPanels(int numberOfPanels)
    {
        GameObject panelClone = Instantiate(levelHolder) as GameObject;
        PageSwiper swiper = levelHolder.AddComponent<PageSwiper>();
        swiper.totalPages = numberOfPanels;

        for (int i = 1; i<= numberOfPanels; i++)
        {
            GameObject panel = Instantiate(panelClone) as GameObject;
            panel.transform.SetParent(thisCanvas.transform, false);
            panel.transform.SetParent(levelHolder.transform);
            panel.name = "Page-" + i;
            panel.GetComponent<RectTransform>().localPosition = new Vector2(panelDimensions.width * (i - 1), 0);
            SetUpGrid(panel);
            int numberOfIcons = i == numberOfPanels ? numberOfLevels - currentLevelCount : amountPerPage;
            LoadIcons(numberOfIcons, panel);
        }
        Destroy(panelClone);
    }
    void SetUpGrid(GameObject panel)
    {
        GridLayoutGroup grid = panel.AddComponent<GridLayoutGroup>();
        grid.cellSize = new Vector2(iconDimensions.width, iconDimensions.height);
        grid.childAlignment = TextAnchor.MiddleCenter;//setea donde aparece 
    }
    void LoadIcons(int numberOfIcons, GameObject parentObject)
    {
        
        for ( int i = 0; i < numberOfIcons; i++)
        {
            
            GameObject icon = Instantiate(levelIcon) as GameObject;
            icon.transform.SetParent(thisCanvas.transform, false);
            icon.transform.SetParent(parentObject.transform);
            Debug.Log(currentLevelCount);
            icon.name = nombreScene[currentLevelCount];
            icon.GetComponentInChildren<TextMeshProUGUI>().SetText(nombreScene[currentLevelCount]);
            icon.GetComponent<Image>().sprite = Images[currentLevelCount];
            icon.GetComponent<Button>().onClick.AddListener(() => { seleccionarEscena.LoadScene(numeroScene[currentLevelCount]); });
            currentLevelCount++;
        }
    }
    private void Update(){
    }
}
