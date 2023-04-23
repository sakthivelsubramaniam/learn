# Red Black Tree

*   Every node is red or black
*   Root node is always black
*   Every path from root- leaf has the same number of black node
*   No Path can have two consecutive red node
*   Nulls are black 

When the tree is voilates the rules, Need to follow the below points
* Rebalance
       Black Uncle Rotate
       Red   Uncle Color flip

* after rotation, Parent will black, children will red
* after color flip, Parent will red, children will black