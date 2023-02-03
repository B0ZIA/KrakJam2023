using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField]
    float water, sun, ground, wind = 5f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void UpdateWater(float updateWaterValue)
    {
        water += updateWaterValue;
        switch (CheckValue(water))
        {
            case 0:
                break;
            case 1:
                EndingLog("Nast¹pi³a susza");
                break;
            case 2:
                EndingLog("Nast¹pi³a powódŸ");
                break;
            default:
                break;
        }
    }
    public void UpdateSun(float updateSunValue)
    {
        sun += updateSunValue;
    }
    public void UpdateGround(float updateGroundValue)
    {
        ground += updateGroundValue;
    }
    public void UpdateWind(float updateWindValue)
    {
        wind += updateWindValue;
    }

    int CheckValue(float valueToCheck)
    {
        int checkResult = 0;
        if (valueToCheck <= 0f)
        {
            checkResult = 1;
        }
        else if (valueToCheck >= 10f)
        {
            checkResult = 2;
        }
        return checkResult;
    }

    void EndingLog(string endingText)
    {
        Debug.Log(endingText);
    }
}
