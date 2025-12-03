using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class SelectionManager : MonoBehaviour
{
    private readonly List<ISelectable> selectedList = new();

    public IReadOnlyList<ISelectable> Selected => selectedList;

    public void Clear()
    {
        foreach (var sel in selectedList)
            sel.OnDeselected();

        selectedList.Clear();
    }

    public void Add(ISelectable selectable)
    {
        if (!selectedList.Contains(selectable))
        {
            selectedList.Add(selectable);
            selectable.OnSelected();
        }
    }

    public void Remove(ISelectable selectable)
    {
        if (selectedList.Contains(selectable))
        {
            selectable.OnDeselected();
            selectedList.Remove(selectable);
        }
    }
}
