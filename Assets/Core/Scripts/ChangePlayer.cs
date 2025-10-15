using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class ChangePlayer : MonoBehaviour
{

    //Even is necromance Odd is skeleton
    public int PlayerChange = 0;
    [SerializeField] Player necromaner;
    [SerializeField] Player skeleton;
    [SerializeField] Object currentPlayer;

    [SerializeField] GameObject necromancerPreFab;
    [SerializeField] GameObject skeletonPreFab;


    void Start()
    {
        Change();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            PlayerChange++;
            
            if (CheckTransform())
            {
                Change();
            }

        }
        if (PlayerChange%2 ==0)
        {
            //targetPosition = necromancer.transform.position;
        } else
        {
            //targetPosition = skeleton.transform.position;
        }
       
    }

    public void Change()
    {
        switch (PlayerChange%2)
        {
            case 0:
                necromancerPreFab.SetActive(true);
                skeletonPreFab.SetActive(false);
                break;

            case 1:
                necromancerPreFab.SetActive(false);
                skeletonPreFab.SetActive(true);
                break;
        }
    }

    public bool CheckTransform()
    {
        return true;
    }
}
