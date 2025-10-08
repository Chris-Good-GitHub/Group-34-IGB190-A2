using UnityEngine;

public class SetBonus : MonoBehaviour
{
    [SerializeField] Player player;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void CheckSetBonus(Player player)
    {
        int i = 0;
        /*foreach (Item item in )
        {
            if (item.itemTag == "Set")
            {
                i++;
            }
        }*/
        switch (i)
        {
            case 2:
                player.SetBonus = true;
                break;

            case 4:
                player.SetBonus2 = true;
                break;
                
            case 5:
                player.SetBonus3 = true;
                break;
        }
    }
}
