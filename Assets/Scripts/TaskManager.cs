using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TaskManager : MonoBehaviour
{
    public static TaskManager instance;

    public List<Task> tasks = new List<Task>();

    public Task currentTask;
    public int previousIndex;

    [SerializeField]
    public GameObject pin;

    void Awake()
    {
        instance = this;
    }



    // Start is called before the first frame update
    void Start()
    {

        //theres probabably a better way to do this
        Task task1 = new Task("Deliver Coffee", 5f,'D', new Vector2(42.5f, 35f));
        Task task1 = new Task("Deliver Coffee", 10f,'D', new Vector2(42.5f, 35f), new Vector2(42.5f, 5f));
        tasks.Add(task1);

        Task task2 = new Task("Write Email", 4f,'P', new Vector2(-12.5f, 15f));
        Task task2 = new Task("Write Email", 4f,'P', new Vector2(-12.5f, 15f), Vector2.zero);
        tasks.Add(task2);

        
        Task task3 = new Task("Pick up the Phone", 7f, 'A',new Vector2(52f, 38.5f));
        Task task3 = new Task("Pick up the Phone", 7f, 'A',new Vector2(52f, 38.5f), Vector2.zero);
        tasks.Add(task3);
        
        Task task4 = new Task("Type a Document", 5f,'P',new Vector2(6.5f, -20f));
        Task task4 = new Task("Type a Document", 5f,'P',new Vector2(6.5f, -20f), Vector2.zero);
        tasks.Add(task4);

        previousIndex = UnityEngine.Random.Range(0, tasks.Count);
        currentTask = tasks[previousIndex];

        currentTask.Assign();
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(currentTask.taskName);
        if (!currentTask.isRuningTimer){
<<<<<<< Updated upstream

            setNewTask();
=======
            currentTask.deliverCheck = false;
            setNewTask(previousIndex);
>>>>>>> Stashed changes

            StrikesDisplay.instance.addStrike();
            
            if (StrikesDisplay.instance.activeStrikes == 3)
                StopAllCoroutines();
            
        }

            //pick a random task from the list 

            //assign task

            //when completed, pick a new task
        
    }

    public void setNewTask()
    {
        int randomIndex = UnityEngine.Random.Range(0, tasks.Count);
        while(randomIndex == previousIndex)
        {
            randomIndex = UnityEngine.Random.Range(0, tasks.Count);
        }

        
        Debug.Log("previous: "+previousIndex);
        Debug.Log("curret: "+randomIndex);

        currentTask = tasks[randomIndex];
        previousIndex = randomIndex;


        Debug.Log("strikes: "+StrikesDisplay.instance.activeStrikes);

        if (StrikesDisplay.instance.activeStrikes < 3)
        {
            StopAllCoroutines();
            currentTask.Assign();
        }
        

    }
}
