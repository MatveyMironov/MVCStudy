using TMPro;
using UnityEngine;

namespace HealthSystem
{
    public class LoadCapacityDisplayer : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI loadCapacityText;

        public void DisplayLoadAndCapacity(int load, int capacity)
        {
            loadCapacityText.text = $"{load}/{capacity}";
        }
    }
}