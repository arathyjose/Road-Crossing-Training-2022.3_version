using UnityEngine;

public class TrainingTrigger : MonoBehaviour
{
    public enum StepType { Start, Wait, Cross, Finish }
    public StepType step;

    public InstructionManager manager;

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player")) return;

        Debug.Log("Triggered: " + step);

        switch (step)
        {
            case StepType.Start:
                manager.ShowMessage("Welcome! Follow the instructions.", 4f);
                break;

            case StepType.Wait:
                manager.ShowMessage("STOP! Look left and right.", 4f);
                break;

            case StepType.Cross:
                manager.ShowMessage("Good! Cross the road carefully.", 4f);
                break;

            case StepType.Finish:
                manager.ShowMessage("Well done! You crossed safely!", 4f);
                break;
        }
    }

}
