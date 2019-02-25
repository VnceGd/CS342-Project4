using UnityEngine;

public class OpponentController : MonoBehaviour
{
    private GameManager gameManager;

    public float spacing = 60f;
    public RectTransform opponentSpace;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        // Movement
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (opponentSpace.localPosition.y < 150f)
            {
                opponentSpace.localPosition += Vector3.up * spacing;
            }
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (opponentSpace.localPosition.x > -150f)
            {
                opponentSpace.localPosition += Vector3.left * spacing;
            }
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (opponentSpace.localPosition.y > -150f)
            {
                opponentSpace.localPosition += Vector3.down * spacing;
            }
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (opponentSpace.localPosition.x < 150f)
            {
                opponentSpace.localPosition += Vector3.right * spacing;
            }
        }

        if (Input.GetKeyDown(KeyCode.RightShift))
        {
            gameManager.PlaceMarker();
        }
    }
}
