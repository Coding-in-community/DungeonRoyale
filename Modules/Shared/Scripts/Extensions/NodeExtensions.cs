using System.Collections.Generic;

namespace DungeonRoyale.Shared.Scripts.Extensions;

public static class NodeExtensions
{
    public static List<T> GetRecursivelyNodesOfType<T>(this Node node, List<T>? nodesList = null) where T : Node
	{
		nodesList ??= [];
		
		foreach (Node child in node.GetChildren())
		{
			if (child is T t)
			{
				nodesList.Add(t);
			}

			if (child.GetChildCount() > 0)
			{
				child.GetRecursivelyNodesOfType(nodesList);
			}
		}

		return nodesList;
	}
}
