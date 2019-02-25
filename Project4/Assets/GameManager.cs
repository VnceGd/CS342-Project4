using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject[] spaces;
    public bool playerTurn;

    public Text currentTurnText;
    public RectTransform playerSpace;
    public RectTransform opponentSpace;

    // Start is called before the first frame update
    void Start()
    {
        spaces = GameObject.FindGameObjectsWithTag("GridSpace");
        playerTurn = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlaceMarker()
    {
        if (playerTurn)
        {
            foreach(GameObject gridSpace in spaces)
            {
                if (gridSpace.GetComponent<RectTransform>().localPosition == playerSpace.localPosition)
                {
                    if (gridSpace.GetComponentInChildren<Text>().text == "")
                    {
                        gridSpace.GetComponentInChildren<Text>().text = "X";
                        playerTurn = false;
                        currentTurnText.text = "Player O Turn";
                    }
                }
            }
        }
        else
        {
            foreach (GameObject gridSpace in spaces)
            {
                if (gridSpace.GetComponent<RectTransform>().localPosition == opponentSpace.localPosition)
                {
                    if (gridSpace.GetComponentInChildren<Text>().text == "")
                    {
                        gridSpace.GetComponentInChildren<Text>().text = "O";
                        playerTurn = true;
                        currentTurnText.text = "Player X Turn";
                    }
                }
            }
        }
    }
}
