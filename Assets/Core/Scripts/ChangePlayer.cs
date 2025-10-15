using UnityEngine;

public class ChangePlayer : MonoBehaviour
{

    //true is necromance false is skeleton
    bool PlayerCharacter = true;
    [SerializeField] public int PlayerChange = 0;
    Vector3 NecromancerPosition;
    Vector3 SkeletonPosition;
    [SerializeField] GameObject necromancer;
    [SerializeField] GameObject skeleton;

    void Update()
    {
        
    }

    public void Change()
    {
        switch (PlayerChange)
        {
            case 0:
                skeleton.transform.position = necromancer.transform.position;
                necromancer.SetActive(true);
                skeleton.SetActive(false);
                break;

            case 1:
                necromancer.transform.position = skeleton.transform.position;
                necromancer.SetActive(false);
                skeleton.SetActive(true);
                break;
        }
    }
}
