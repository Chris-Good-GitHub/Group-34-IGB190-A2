using UnityEngine;

public class ChangePlayer : MonoBehaviour
{

    //even is necromance odd is skeleton
    [SerializeField] public float change;
    [SerializeField] Player currentPlayer;
    [SerializeField] Player necromaner;
    [SerializeField] Player skeleton;
    [SerializeField] GameObject necromancerPreFab;
    [SerializeField] GameObject skeletonPreFab;

    void Update()
    {
        change = LogicEngine.GetGlobalVariable<float>("PlayerChange");
        Change();
    }

    void Start()
    {
        LogicEngine.SetGlobalVariable("PlayerChange", 0.0f);
        change = LogicEngine.GetGlobalVariable<float>("PlayerChange");
        //Debug.Log(LogicEngine.GetGlobalVariable<float>("PlayerChange"));
    }

    public void Change()
    {
        switch (change%2)
        {
            case 0:
                //currentPlayer.abilities = necromaner.abilities;
                necromancerPreFab.SetActive(true);
                skeletonPreFab.SetActive(false);
                break;

            case 1:
                //currentPlayer.abilities = skeleton.abilities;
                necromancerPreFab.SetActive(false);
                skeletonPreFab.SetActive(true);
                break;
        }
    }
}
