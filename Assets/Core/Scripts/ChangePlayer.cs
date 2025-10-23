using UnityEngine;

public class ChangePlayer : MonoBehaviour
{

    //even is necromance odd is skeleton
    [SerializeField] public float change;
    [SerializeField] private GameObject necromancerPreFab;
    [SerializeField] private GameObject skeletonPreFab;

    void Update()
    {
        change = LogicEngine.GetGlobalVariable<float>("PlayerChange");
        Change();
    }

    void Start()
    {
        LogicEngine.SetGlobalVariable("PlayerChange", 0.0f);
        change = LogicEngine.GetGlobalVariable<float>("PlayerChange");
        Change();
    }

    public void Change()
    {
        switch (change%2)
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
}
