using UnityEngine;

public class ChangePlayer : MonoBehaviour
{

    //even is necromance odd is skeleton
    [SerializeField] public float change;
    [SerializeField] private Player currentPlayer;
    [SerializeField] private Player necromaner;
    [SerializeField] private Player skeleton;
    private float perviousChange;
    [SerializeField] private GameObject necromancerPreFab;
    [SerializeField] private GameObject skeletonPreFab;

    void Update()
    {
        change = LogicEngine.GetGlobalVariable<float>("PlayerChange");
        if (change != perviousChange)
        {
            Change();
        }
        perviousChange = change;
        Change();
    }

    void Start()
    {
        LogicEngine.SetGlobalVariable("PlayerChange", 0.0f);
        change = LogicEngine.GetGlobalVariable<float>("PlayerChange");
        perviousChange = change;
        Change();
    }

    public void Change()
    {
        switch (change%2)
        {
            case 0:
                //currentPlayer.abilities = necromaner.abilities;
                //set the atributes
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
