using UnityEngine;

public class ChangePlayer : MonoBehaviour
{

    //true is necromance false is skeleton
    bool PlayerCharacter = true;

    [SerializeField] GameObject necromancer;
    [SerializeField] GameObject skeleton;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }

    public void Change()
    {
        if (PlayerCharacter)
        {
            skeleton.transform.position = necromancer.transform.position;
            necromancer.SetActive(true);
            skeleton.SetActive(false);
        }
        else
        {
            necromancer.transform.position = skeleton.transform.position;
            necromancer.SetActive(false);
            skeleton.SetActive(true);
        }
    }
}
