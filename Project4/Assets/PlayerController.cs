using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private GameManager gameManager;

    public float spacing = 60f;
    public RectTransform playerSpace;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        // Movement
        if (Input.GetKeyDown(KeyCode.W))
        {
            if (playerSpace.localPosition.y < 150f)
            {
                playerSpace.localPosition += Vector3.up * spacing;
            }
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            if (playerSpace.localPosition.x > -150f)
            {
                playerSpace.localPosition += Vector3.left * spacing;
            }
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            if (playerSpace.localPosition.y > -150f)
            {
                playerSpace.localPosition += Vector3.down * spacing;
            }
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            if (playerSpace.localPosition.x < 150f)
            {
                playerSpace.localPosition += Vector3.right * spacing;
            }
        }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            gameManager.PlaceMarker();
        }
    }
}
