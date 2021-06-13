using UnityEngine;

public class PinkDiamondQuest  : Quest
{

    [SerializeField] private GameObject diamond;
    private void Awake()
    {
        questName = "Rozowy diament";
        questDescription = "Zbierz diament sam  ";
        questObjective = new CollectionObjective(this, 1, "pinkDiamond");
    }

    void Start()
    {
        diamond = GameObject.Find("pinkDiamond");
        diamond.SetActive(false);
    } 

    public override void Finished()
    {
        PlayerStats.Instance.UpdateRegenerationRate(3);
        base.Finished();
    }

    public override void SetActive()
    {
        base.SetActive();
        diamond.SetActive(true);
    }
}
