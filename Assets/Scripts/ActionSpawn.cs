using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ActionSpawn : MonoBehaviour
{
    //Cat Cards
    List<GameObject> catFoodList = new List<GameObject>();
    public GameObject catFoodCorrect;
    public GameObject catFoodWrong1;
    public GameObject catFoodWrong2;

    List<GameObject> catHabitatList = new List<GameObject>();
    public GameObject catHabitatCorrect;
    public GameObject catHabitatWrong1;
    public GameObject catHabitatWrong2;

    List<GameObject> catPersonalityList = new List<GameObject>();
    public GameObject catPersonalityCorrect;
    public GameObject catPersonalityWrong1;
    public GameObject catPersonalityWrong2;

    List<GameObject> catToxicObjList = new List<GameObject>();
    public GameObject catToxicObjCorrect;
    public GameObject catToxicObjectWrong1;
    public GameObject catToxicObjectWrong2;

    List<GameObject> catExerciseList = new List<GameObject>();
    public GameObject catExerciseCorrect;
    public GameObject catExerciseWrong1;
    public GameObject catExerciseWrong2;

    List<GameObject> catHygieneList = new List<GameObject>();
    public GameObject catHygieneCorrect;
    public GameObject catHygieneWrong1;
    public GameObject catHygieneWrong2;

    List<GameObject> catEnrichmentList = new List<GameObject>();
    public GameObject catEnrichmentCorrect;
    public GameObject catEnrichmentWrong1;
    public GameObject catEnrichmentWrong2;

    List<GameObject> catHealthScreeningList = new List<GameObject>();
    public GameObject catHealthScreeningCorrect;
    public GameObject catHeatlhScreeningWrong1;
    public GameObject catHealthScreeningWrong2;

    List<GameObject> catMaterialsList = new List<GameObject>();
    public GameObject catMaterialsCorrect;
    public GameObject catMaterialsWrong1;
    public GameObject catMaterialsWrong2;

    //Dog Cards
    List<GameObject> dogFoodList = new List<GameObject>();
    public GameObject dogFoodCorrect;
    public GameObject dogFoodWrong1;
    public GameObject dogFoodWrong2;

    List<GameObject> dogHabitatList = new List<GameObject>();
    public GameObject dogHabitatCorrect;
    public GameObject dogHabitatWrong1;
    public GameObject dogHabitatWrong2;

    List<GameObject> dogPersonalityList = new List<GameObject>();
    public GameObject dogPersonalityCorrect;
    public GameObject dogPersonalityWrong1;
    public GameObject dogPersonalityWrong2;

    List<GameObject> dogToxicObjList = new List<GameObject>();
    public GameObject dogToxicObjCorrect;
    public GameObject dogToxicObjectWrong1;
    public GameObject dogToxicObjectWrong2;

    List<GameObject> dogExerciseList = new List<GameObject>();
    public GameObject dogExerciseCorrect;
    public GameObject dogExerciseWrong1;
    public GameObject dogExerciseWrong2;

    List<GameObject> dogHygieneList = new List<GameObject>();
    public GameObject dogHygieneCorrect;
    public GameObject dogHygieneWrong1;
    public GameObject dogHygieneWrong2;

    List<GameObject> dogEnrichmentList = new List<GameObject>();
    public GameObject dogEnrichmentCorrect;
    public GameObject dogEnrichmentWrong1;
    public GameObject dogEnrichmentWrong2;

    List<GameObject> dogHealthScreeningList = new List<GameObject>();
    public GameObject dogHealthScreeningCorrect;
    public GameObject dogHealthScreeningWrong1;
    public GameObject dogHealthScreeningWrong2;

    List<GameObject> dogMaterialsList = new List<GameObject>();
    public GameObject dogMaterialsCorrect;
    public GameObject dogMaterialsWrong1;
    public GameObject dogMaterialsWrong2;


    //Rabbit Cards
    List<GameObject> rabbitFoodList = new List<GameObject>();
    public GameObject rabbitFoodCorrect;
    public GameObject rabbitFoodWrong1;
    public GameObject rabbitFoodWrong2;

    List<GameObject> rabbitHabitatList = new List<GameObject>();
    public GameObject rabbitHabitatCorrect;
    public GameObject rabbitHabitatWrong1;
    public GameObject rabbitHabitatWrong2;

    List<GameObject> rabbitPersonalityList = new List<GameObject>();
    public GameObject rabbitPersonalityCorrect;
    public GameObject rabbitPersonalityWrong1;
    public GameObject rabbitPersonalityWrong2;

    List<GameObject> rabbitToxicObjList = new List<GameObject>();
    public GameObject rabbitToxicObjCorrect;
    public GameObject rabbitToxicObjectWrong1;
    public GameObject rabbitToxicObjectWrong2;

    List<GameObject> rabbitExerciseList = new List<GameObject>();
    public GameObject rabbitExerciseCorrect;
    public GameObject rabbitExerciseWrong1;
    public GameObject rabbitExerciseWrong2;

    List<GameObject> rabbitHygieneList = new List<GameObject>();
    public GameObject rabbitHygieneCorrect;
    public GameObject rabbitHygieneWrong1;
    public GameObject rabbitHygieneWrong2;

    List<GameObject> rabbitEnrichmentList = new List<GameObject>();
    public GameObject rabbitEnrichmentCorrect;
    public GameObject rabbitEnrichmentWrong1;
    public GameObject rabbitEnrichmentWrong2;

    List<GameObject> rabbitHealthScreeningList = new List<GameObject>();
    public GameObject rabbitHealthScreeningCorrect;
    public GameObject rabbitHeatlhScreeningWrong1;
    public GameObject rabbitHealthScreeningWrong2;

    List<GameObject> rabbitMaterialsList = new List<GameObject>();
    public GameObject rabbitMaterialsCorrect;
    public GameObject rabbitMaterialsWrong1;
    public GameObject rabbitMaterialsWrong2;



    //Hamster Cards
    List<GameObject> hamsterFoodList = new List<GameObject>();
    public GameObject hamsterFoodCorrect;
    public GameObject hamsterFoodWrong1;
    public GameObject hamsterFoodWrong2;

    List<GameObject> hamsterHabitatList = new List<GameObject>();
    public GameObject hamsterHabitatCorrect;
    public GameObject hamsterHabitatWrong1;
    public GameObject hamsterHabitatWrong2;

    List<GameObject> hamsterPersonalityList = new List<GameObject>();
    public GameObject hamsterPersonalityCorrect;
    public GameObject hamsterPersonalityWrong1;
    public GameObject hamsterPersonalityWrong2;

    List<GameObject> hamsterToxicObjList = new List<GameObject>();
    public GameObject hamsterToxicObjCorrect;
    public GameObject hamsterToxicObjectWrong1;
    public GameObject hamsterToxicObjectWrong2;

    List<GameObject> hamsterExerciseList = new List<GameObject>();
    public GameObject hamsterExerciseCorrect;
    public GameObject hamsterExerciseWrong1;
    public GameObject hamsterExerciseWrong2;

    List<GameObject> hamsterHygieneList = new List<GameObject>();
    public GameObject hamsterHygieneCorrect;
    public GameObject hamsterHygieneWrong1;
    public GameObject hamsterHygieneWrong2;

    List<GameObject> hamsterEnrichmentList = new List<GameObject>();
    public GameObject hamsterEnrichmentCorrect;
    public GameObject hamsterEnrichmentWrong1;
    public GameObject hamsterEnrichmentWrong2;

    List<GameObject> hamsterHealthScreeningList = new List<GameObject>();
    public GameObject hamsterHealthScreeningCorrect;
    public GameObject hamsterHeatlhScreeningWrong1;
    public GameObject hamsterHealthScreeningWrong2;

    List<GameObject> hamsterMaterialsList = new List<GameObject>();
    public GameObject hamsterMaterialsCorrect;
    public GameObject hamsterMaterialsWrong1;
    public GameObject hamsterMaterialsWrong2;



    //public Canvas canvas;

    private int actionCardCount = 0;
    private string animalText;
    private int topicIndex;

    private List<int> availableIndices; // List to store indices available for random selection
    private int currentIndex = 0; // Current index in the shuffled list

    private void Awake()
    {
        animalText = GameObject.FindGameObjectWithTag("PersistentObj").GetComponent<PersistenceScript>().winText;
        InitializeIndices(3);



    }

    // Function to initialize available indices using Fisher-Yates shuffle
    private void InitializeIndices(int count)
    {
        print("initialize indices...");
        availableIndices = new List<int>();
        for (int i = 0; i < count; i++)
        {
            availableIndices.Add(i);
        }
        Shuffle(availableIndices); // Shuffle the list of indices
        currentIndex = 0; // Reset current index to start of shuffled list
    }

    // Fisher-Yates shuffle algorithm
    private void Shuffle(List<int> list)
    {
        print("shuffle...");
        for (int i = list.Count - 1; i > 0; i--)
        {
            int randomIndex = UnityEngine.Random.Range(0, i + 1); // Pick a random index from 0 to i
            int temp = list[i]; // Swap list[i] and list[randomIndex]
            list[i] = list[randomIndex];
            list[randomIndex] = temp;
        }
    }

    // Function to get the next unique random index
    private int GetUniqueRandomIndex()
    {
        print("getting unique random index...");
        if (currentIndex >= availableIndices.Count)
        {
            Debug.LogWarning("All indices have been used. Reshuffling...");
            InitializeIndices(3); 
        }

        int randomIndex = availableIndices[currentIndex];
        currentIndex++; // Move to the next index in the shuffled list

        return randomIndex;
    }


    public void OnMouseDown()
    {
        topicIndex = CardFlipAnim.topicIndex;
        
        int randomIndex = GetUniqueRandomIndex();
        if (actionCardCount < 3)
        {
            switch (topicIndex)
            {
                case 0: // Food
                    switch (animalText)
                    {
                        case "Cat":
                            catFoodList.Add(catFoodCorrect);
                            catFoodList.Add(catFoodWrong1);
                            catFoodList.Add(catFoodWrong2);

                            
                            Instantiate(catFoodList[randomIndex]);

                            break;
                        case "Dog":
                            dogFoodList.Add(dogFoodCorrect);
                            dogFoodList.Add(dogFoodWrong1);
                            dogFoodList.Add(dogFoodWrong2);

                            //int dogFoodIndex = UnityEngine.Random.Range(0, 3);
                            Instantiate(dogFoodList[randomIndex]);

                            break;
                        case "Rabbit":
                            rabbitFoodList.Add(rabbitFoodCorrect);
                            rabbitFoodList.Add(rabbitFoodWrong1);
                            rabbitFoodList.Add(rabbitFoodWrong2);

                            //int rabbitFoodIndex = UnityEngine.Random.Range(0, 3);
                            Instantiate(rabbitFoodList[randomIndex]);

                            break;
                        case "Hamster":
                            hamsterFoodList.Add(hamsterFoodCorrect);
                            hamsterFoodList.Add(hamsterFoodWrong1);
                            hamsterFoodList.Add(hamsterFoodWrong2);

                            //int hamsterFoodIndex = UnityEngine.Random.Range(0, 3);
                            Instantiate(hamsterFoodList[randomIndex]);

                            break;
                    }
                    break;
                case 1: // Habitats
                    switch (animalText)
                    {
                        case "Cat":
                            catHabitatList.Add(catHabitatCorrect);
                            catHabitatList.Add(catHabitatWrong1);
                            catHabitatList.Add(catHabitatWrong2);

                            //int catHabitatIndex = UnityEngine.Random.Range(0, 3);
                            Instantiate(catHabitatList[randomIndex]);

                            break;
                        case "Dog":
                            dogHabitatList.Add(dogHabitatCorrect);
                            dogHabitatList.Add(dogHabitatWrong1);
                            dogHabitatList.Add(dogHabitatWrong2);

                            //int dogHabitatIndex = UnityEngine.Random.Range(0, 3);
                            Instantiate(dogHabitatList[randomIndex]);

                            break;
                        case "Rabbit":
                            rabbitHabitatList.Add(rabbitHabitatCorrect);
                            rabbitHabitatList.Add(rabbitHabitatWrong1);
                            rabbitHabitatList.Add(rabbitHabitatWrong2);

                            //int rabbitHabitatIndex = UnityEngine.Random.Range(0, 3);
                            Instantiate(rabbitHabitatList[randomIndex]);

                            break;
                        case "Hamster":
                            hamsterHabitatList.Add(hamsterHabitatCorrect);
                            hamsterHabitatList.Add(hamsterHabitatWrong1);
                            hamsterHabitatList.Add(hamsterHabitatWrong2);

                            //int hamsterHabitatIndex = UnityEngine.Random.Range(0, 3);
                            Instantiate(hamsterHabitatList[randomIndex]);

                            break;
                    }
                    break;
                case 2: // Personality
                    switch (animalText)
                    {
                        case "Cat":
                            catPersonalityList.Add(catPersonalityCorrect);
                            catPersonalityList.Add(catPersonalityWrong1);
                            catPersonalityList.Add(catPersonalityWrong2);

                            
                            Instantiate(catPersonalityList[randomIndex]);

                            break;
                        case "Dog":
                            dogPersonalityList.Add(dogPersonalityCorrect);
                            dogPersonalityList.Add(dogPersonalityWrong1);
                            dogPersonalityList.Add(dogPersonalityWrong2);

                            //int dogPersonalityIndex = UnityEngine.Random.Range(0, 3);
                            Instantiate(dogPersonalityList[randomIndex]);

                            break;
                        case "Rabbit":
                            rabbitPersonalityList.Add(rabbitPersonalityCorrect);
                            rabbitPersonalityList.Add(rabbitPersonalityWrong1);
                            rabbitPersonalityList.Add(rabbitPersonalityWrong2);

                            //int rabbitPersonalityIndex = UnityEngine.Random.Range(0, 3);
                            Instantiate(rabbitPersonalityList[randomIndex]);

                            break;
                        case "Hamster":
                            hamsterPersonalityList.Add(hamsterPersonalityCorrect);
                            hamsterPersonalityList.Add(hamsterPersonalityWrong1);
                            hamsterPersonalityList.Add(hamsterPersonalityWrong2);

                            //int hamsterPersonalityIndex = UnityEngine.Random.Range(0, 3);
                            Instantiate(hamsterPersonalityList[randomIndex]);

                            break;
                    }
                    break;
                case 3: // Toxic Objects
                    switch (animalText)
                    {
                        case "Cat":
                            catToxicObjList.Add(catToxicObjCorrect);
                            catToxicObjList.Add(catToxicObjectWrong1);
                            catToxicObjList.Add(catToxicObjectWrong2);

                           
                            Instantiate(catToxicObjList[randomIndex]);

                            break;
                        case "Dog":
                            dogToxicObjList.Add(dogToxicObjCorrect);
                            dogToxicObjList.Add(dogToxicObjectWrong1);
                            dogToxicObjList.Add(dogToxicObjectWrong2);

                 
                            Instantiate(dogToxicObjList[randomIndex]);

                            break;
                        case "Rabbit":
                            rabbitToxicObjList.Add(rabbitToxicObjCorrect);
                            rabbitToxicObjList.Add(rabbitToxicObjectWrong1);
                            rabbitToxicObjList.Add(rabbitToxicObjectWrong2);

                         
                            Instantiate(rabbitToxicObjList[randomIndex]);

                            break;
                        case "Hamster":
                            hamsterToxicObjList.Add(hamsterToxicObjCorrect);
                            hamsterToxicObjList.Add(hamsterToxicObjectWrong1);
                            hamsterToxicObjList.Add(hamsterToxicObjectWrong2);

                            Instantiate(hamsterToxicObjList[randomIndex]);

                            break;
                    }
                    break;
                case 4: // Exercise
                    switch (animalText)
                    {
                        case "Cat":
                            catExerciseList.Add(catExerciseCorrect);
                            catExerciseList.Add(catExerciseWrong1);
                            catExerciseList.Add(catExerciseWrong2);

                            Instantiate(catExerciseList[randomIndex]);
                            break;
                        case "Dog":
                            dogExerciseList.Add(dogExerciseCorrect);
                            dogExerciseList.Add(dogExerciseWrong1);
                            dogExerciseList.Add(dogExerciseWrong2);

                            Instantiate(dogExerciseList[randomIndex]);
                            break;
                        case "Rabbit":
                            rabbitExerciseList.Add(rabbitExerciseCorrect);
                            rabbitExerciseList.Add(rabbitExerciseWrong1);
                            rabbitExerciseList.Add(rabbitExerciseWrong2);

                            Instantiate(rabbitExerciseList[randomIndex]);
                            break;
                        case "Hamster":
                            hamsterExerciseList.Add(hamsterExerciseCorrect);
                            hamsterExerciseList.Add(hamsterExerciseWrong1);
                            hamsterExerciseList.Add(hamsterExerciseWrong2);

                            Instantiate(hamsterExerciseList[randomIndex]);
                            break;
                    }
                    break;

                case 5: // Hygiene
                    switch (animalText)
                    {
                        case "Cat":
                            catHygieneList.Add(catHygieneCorrect);
                            catHygieneList.Add(catHygieneWrong1);
                            catHygieneList.Add(catHygieneWrong2);

                            Instantiate(catHygieneList[randomIndex]);
                            break;
                        case "Dog":
                            dogHygieneList.Add(dogHygieneCorrect);
                            dogHygieneList.Add(dogHygieneWrong1);
                            dogHygieneList.Add(dogHygieneWrong2);

                            Instantiate(dogHygieneList[randomIndex]);
                            break;
                        case "Rabbit":
                            rabbitHygieneList.Add(rabbitHygieneCorrect);
                            rabbitHygieneList.Add(rabbitHygieneWrong1);
                            rabbitHygieneList.Add(rabbitHygieneWrong2);

                            Instantiate(rabbitHygieneList[randomIndex]);
                            break;
                        case "Hamster":
                            hamsterHygieneList.Add(hamsterHygieneCorrect);
                            hamsterHygieneList.Add(hamsterHygieneWrong1);
                            hamsterHygieneList.Add(hamsterHygieneWrong2);

                            Instantiate(hamsterHygieneList[randomIndex]);
                            break;
                    }
                    break;

                case 6: // Enrichment
                    switch (animalText)
                    {
                        case "Cat":
                            catEnrichmentList.Add(catEnrichmentCorrect);
                            catEnrichmentList.Add(catEnrichmentWrong1);
                            catEnrichmentList.Add(catEnrichmentWrong2);

                            Instantiate(catEnrichmentList[randomIndex]);
                            break;
                        case "Dog":
                            dogEnrichmentList.Add(dogEnrichmentCorrect);
                            dogEnrichmentList.Add(dogEnrichmentWrong1);
                            dogEnrichmentList.Add(dogEnrichmentWrong2);

                            Instantiate(dogEnrichmentList[randomIndex]);
                            break;
                        case "Rabbit":
                            rabbitEnrichmentList.Add(rabbitEnrichmentCorrect);
                            rabbitEnrichmentList.Add(rabbitEnrichmentWrong1);
                            rabbitEnrichmentList.Add(rabbitEnrichmentWrong2);

                            Instantiate(rabbitEnrichmentList[randomIndex]);
                            break;
                        case "Hamster":
                            hamsterEnrichmentList.Add(hamsterEnrichmentCorrect);
                            hamsterEnrichmentList.Add(hamsterEnrichmentWrong1);
                            hamsterEnrichmentList.Add(hamsterEnrichmentWrong2);

                            Instantiate(hamsterEnrichmentList[randomIndex]);
                            break;
                    }
                    break;

                case 7: // Health Screening
                    switch (animalText)
                    {
                        case "Cat":
                            catHealthScreeningList.Add(catHealthScreeningCorrect);
                            catHealthScreeningList.Add(catHeatlhScreeningWrong1);
                            catHealthScreeningList.Add(catHealthScreeningWrong2);

                            Instantiate(catHealthScreeningList[randomIndex]);
                            break;
                        case "Dog":
                            dogHealthScreeningList.Add(dogHealthScreeningCorrect);
                            dogHealthScreeningList.Add(dogHealthScreeningWrong1);
                            dogHealthScreeningList.Add(dogHealthScreeningWrong2);

                            Instantiate(dogHealthScreeningList[randomIndex]);
                            break;
                        case "Rabbit":
                            rabbitHealthScreeningList.Add(rabbitHealthScreeningCorrect);
                            rabbitHealthScreeningList.Add(rabbitHeatlhScreeningWrong1);
                            rabbitHealthScreeningList.Add(rabbitHealthScreeningWrong2);

                            Instantiate(rabbitHealthScreeningList[randomIndex]);
                            break;
                        case "Hamster":
                            hamsterHealthScreeningList.Add(hamsterHealthScreeningCorrect);
                            hamsterHealthScreeningList.Add(hamsterHeatlhScreeningWrong1);
                            hamsterHealthScreeningList.Add(hamsterHealthScreeningWrong2);

                            Instantiate(hamsterHealthScreeningList[randomIndex]);
                            break;
                    }
                    break;

                case 8: // Materials
                    switch (animalText)
                    {
                        case "Cat":
                            catMaterialsList.Add(catMaterialsCorrect);
                            catMaterialsList.Add(catMaterialsWrong1);
                            catMaterialsList.Add(catMaterialsWrong2);

                            Instantiate(catMaterialsList[randomIndex]);
                            break;
                        case "Dog":
                            dogMaterialsList.Add(dogMaterialsCorrect);
                            dogMaterialsList.Add(dogMaterialsWrong1);
                            dogMaterialsList.Add(dogMaterialsWrong2);

                            Instantiate(dogMaterialsList[randomIndex]);
                            break;
                        case "Rabbit":
                            rabbitMaterialsList.Add(rabbitMaterialsCorrect);
                            rabbitMaterialsList.Add(rabbitMaterialsWrong1);
                            rabbitMaterialsList.Add(rabbitMaterialsWrong2);

                            Instantiate(rabbitMaterialsList[randomIndex]);
                            break;
                        case "Hamster":
                            hamsterMaterialsList.Add(hamsterMaterialsCorrect);
                            hamsterMaterialsList.Add(hamsterMaterialsWrong1);
                            hamsterMaterialsList.Add(hamsterMaterialsWrong2);

                            Instantiate(hamsterMaterialsList[randomIndex]);
                            break;
                    }
                    break;
            }

            actionCardCount++;

        }
        else
        {
            print( "You only have 3 action cards.");
        }
    }
}


