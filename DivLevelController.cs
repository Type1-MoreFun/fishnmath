using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DivLevelController : MonoBehaviour
{
    public TextMeshProUGUI randomNum1Text;
    public TextMeshProUGUI randomNum2Text;

    public TextMeshProUGUI correctText;
    public TextMeshProUGUI[] incorrectText;

    public Button correctDivButton;
    public Button[] incorrectDivButton;
    private int randomNum1;
    private int randomNum2;
    private int correctDiv;
    void Start()
    {
        GenerateRandomNumbers();
        SetRandomButtonPositions();
        UpdateTextFields();
    }

    public void GenerateRandomNumbers()
    {
        // Here we generate the random numbers from 0 to 100 for division problems, and then record the correct quotient at the same time.
        randomNum1 = Random.Range(0, 101);
        randomNum2 = Random.Range(0, 101);
        correctDiv = randomNum1 / randomNum2;
        while (randomNum1<randomNum2 || (randomNum1%randomNum2 !=0))
        {
            randomNum1 = Random.Range(0, 100);
            randomNum2 = Random.Range(0, 100);
            correctDiv = randomNum1 / randomNum2;
        }
        
    }

    // This function sets the location of the buttons to put the available answers on.  (random answer location)
    public void SetRandomButtonPositions()
    {
        // Creating an array of the positions
        Vector2[] positions = new Vector2[]
        {
            new Vector2(-163.9f, -100.5f),
            new Vector2(-68f, -100.5f),
            new Vector2(30.1f, -100.5f),
            new Vector2(113.2f, -100.5f)
        };

        // Shuffling it with an alg i found from stackoverflow for shuffling the array
        ShuffleArray(positions);

        // Assigning each button to a shuffled position
        SetButtonPosition(correctDivButton, positions[0]);
        for (int i = 0; i < incorrectDivButton.Length; i++)
        {
            SetButtonPosition(incorrectDivButton[i], positions[i + 1]);
        }
    }

    // Simply placing the rectangles
    public void SetButtonPosition(Button button, Vector2 position)
    {
        RectTransform rectTransform = button.GetComponent<RectTransform>();
        rectTransform.anchoredPosition = position;
    }

    public void UpdateTextFields()
    {
        randomNum1Text.text = randomNum1.ToString();
        randomNum2Text.text = randomNum2.ToString();

        correctText.text = correctDiv.ToString();
        for (int i = 0; i <= incorrectText.Length; i++)
        {
            int x = Random.Range(0, 20);



            while (x == correctDiv)
            {
                x = Random.Range(0, 20);
            }
            incorrectText[i].text = x.ToString();
        }
    }

    //Fisher-Yates shuffle algorithm
    public void ShuffleArray(Vector2[] array)
    {
        int n = array.Length;
        for (int i = n - 1; i > 0; i--)
        {
            int j = Random.Range(0, i + 1);
            Vector2 temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}