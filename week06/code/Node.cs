using System.Security.AccessControl;
using System.Data.Common;
public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
    {
        this.Data = data;
    }

    public void Insert(int value)
    {
        // TODO Start Problem 1

        if (value < Data)
        {
            // Insert to the left if the value is smaller than current node's data
            if (Left is null)
                Left = new Node(value);     // Create a new node if left child doesn't exist
            else
            {
                // Create a new node if left child doesn't exist
                if (!Left.Contains(value))
                    Left.Insert(value);    // Recursively insert into the left subtree
            }
        }
        else
        {
            // Insert to the right if the value is greater than or equal to current node's data
            if (Right is null)
                Right = new Node(value);    // Create a new node if right child doesn't exist
            else
            { 
            // Only insert if the value is not already in the right subtree
                if (!Right.Contains(value))
                    Right.Insert(value);    // Recursively insert into the right subtree
            }
        }
    }

    public bool Contains(int value)
    {
        // TODO Start Problem 2
        // If the current node's data matches the search value, return true
        if (Data == value)
        {
            return true;
        }
        
        // If the search value is less than the current node's data, search the left subtree
        if (Data > value)
        {
            if (Left is null)             // If there's no left child, value isn't in the tree
                return false;
            return Left.Contains(value);  // Recursively search the left subtree
        }
        else
        {
            // If the search value is greater than the current node's data, search the right subtree
            if (Right is null)              // If there's no right child, value isn't in the tree
                return false;
            return Right.Contains(value);   // Recursively search the right subtree
        }
    }

    public int GetHeight()
    {
        // TODO Start Problem 4
        // Recursively get the height of the left subtree; if null, height is 0
        int LeftHeight = Left != null ? Left.GetHeight(): 0;

        // Recursively get the height of the right subtree; if null, height is 0
        int RightHeight = Right != null ? Right.GetHeight(): 0;
        
        // Return 1 (for the current node) plus the greater of the two subtree heights
        return 1 + Math.Max(LeftHeight, RightHeight); 
    }
}