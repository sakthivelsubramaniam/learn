//namespace DataStructure

module MyTree =
   
   type Tree<'INodeData> =
    | LeafNode of 'INodeData
    | InternalNode of 'INodeData*Tree<'INodeData> seq

   type Nodedata = {nodeId:int; nodeName:string; nodevalue:int}
  
   let rec totalTree (t:Tree<Nodedata>) =
      match t with 
      | LeafNode l -> l.nodevalue
      | InternalNode (d,subitems) -> d.nodevalue + Seq.sum  ( subitems |> (Seq.map totalTree))

   //tree folds 
   let fLeafNode (costsofar:int) (n1:Nodedata) =
      n1.nodevalue + costsofar

   let rec catatree fLeafNode fNode (t:Tree<Nodedata>) =
      match t with
      | LeafNode n -> fLeafNode n
      | InternalNode (nodeInfo,subitems) -> 
           fNode nodeInfo ( subitems |> (Seq.map (catatree fLeafNode fNode)))
   
   // let rec fold fLeafNode fNode acc (t:Tree<Nodedata>) =
   //    let recurse = fold fLeafNode fNode
   //    match t with 
   //    | LeafNode ln ->  fLeafNode acc ln
   //    | InternalNode (nodeInfo, subitems) -> 
   //          let localAccu = fNode acc nodeInfo
   //          let finalAccu = (subItems |> Seq.fold (recurse localAccu))
   //          finalAccu

   // let total (t:Tree<Nodedata>) = 
   //    let fLeafNode acc (ln:Nodedata) =
   //       acc + ln.nodevalue
   //    let fNode acc (ln:Nodedata) =
   //       acc + ln.nodevalue
   //    fold fLeafNode fNode 0 t
      

module MyTreeTest =
   open MyTree
   let child1 = LeafNode {nodeId=1;nodeName="leftnode1";nodevalue=10} 
   let child2 = LeafNode {nodeId=2;nodeName="rightnode1";nodevalue=20} 
   let subItems = seq { yield child1; yield child2 }
   let sampleTree = InternalNode ({nodeId=3;nodeName="middlenode2";nodevalue=100}, subItems)
   
   // total tree
   let value1 = totalTree sampleTree
   printf "value of integer is %i" value1

   //let v1 = total sampleTree
   //printf "value of fold is %i " v1

