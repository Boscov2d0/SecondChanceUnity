using UnityEngine;

public class CardAnim : MonoBehaviour
{
    bool rotate = true;
    Vector3 StartPosotion;
    Quaternion StartRitation;
    Transform Side1;
    Transform Side2;
    public GameObject Story;

    void Start()
    {
        StartPosotion = gameObject.transform.localScale;
        StartRitation = gameObject.transform.rotation;
        Side1 = gameObject.transform.GetChild(0);
        Side2 = gameObject.transform.GetChild(1);
    }

    void FixedUpdate()
    {
        if (rotate)
        {
            gameObject.transform.Rotate(0.0f, 15.0f, 0.0f);
            gameObject.transform.localScale += new Vector3(0.007f, 0.007f, 0.0f);
            if (gameObject.transform.localScale.x >= 1.5f)
            {
                rotate = false;
                gameObject.transform.localScale = StartPosotion;
                gameObject.transform.rotation = StartRitation;
                Side1.gameObject.SetActive(false);
                Side2.gameObject.SetActive(true);
                Story.SetActive(true);
            }
        }
    }
}
