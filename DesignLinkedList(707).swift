class ListNode {
    init(storedValue: Int){
        value = storedValue
    }
    var value: Int = 0
    var next: ListNode?
    var previous: ListNode?
}

class MyLinkedList {
    
    var count = 0
    var first: ListNode?
    
    func GetLast()->ListNode?{
        if(count < 1){
            return nil
        }
        var currentNode = first
        while currentNode?.next != nil {
            currentNode = currentNode?.next
        }
        return currentNode
    }
    
    /** Initialize your data structure here. */
    init() {
        
    }
    
    /** Get the value of the index-th node in the linked list. If the index is invalid, return -1. */
    func get(_ index: Int) -> Int {
        if index > count-1 || index < 0{
            return -1
        } else if index == 0 {
            return first!.value
        }
        var currentNode = first
        for _ in 0..<index {
            currentNode = currentNode?.next
        }
        return currentNode!.value
    }
    
    /** Add a node of value val before the first element of the linked list. After the insertion, the new node will be the first node of the linked list. */
    func addAtHead(_ val: Int) {
        if first == nil {
            first = ListNode(storedValue: val)
            count+=1
            return
        }
        let newToAdd = ListNode(storedValue: val)
        first?.previous = newToAdd
        newToAdd.next = first
        first = newToAdd
        count+=1
    }
    
    /** Append a node of value val to the last element of the linked list. */
    func addAtTail(_ val: Int) {
        if(first == nil){
            first = ListNode(storedValue: val)
            count += 1
            return
        }
        let currentLast = GetLast()
        let newNode = ListNode(storedValue: val)
        currentLast?.next = newNode
        newNode.previous = currentLast
        count += 1
    }
    
    /** Add a node of value val before the index-th node in the linked list. If index equals to the length of linked list, the node will be appended to the end of linked list. If index is greater than the length, the node will not be inserted. */
    func addAtIndex(_ index: Int, _ val: Int) {
        if index > count{
            return
        } else if index == count {
            addAtTail(val)
            return
        } else if index <= 0{
            addAtHead(val)
            return
        }
        var currentNodeAtIndex = first
        for _ in 0..<index {
            currentNodeAtIndex = currentNodeAtIndex?.next
        }
        let nodeToInsert = ListNode(storedValue: val)
        nodeToInsert.next = currentNodeAtIndex
        nodeToInsert.previous = currentNodeAtIndex?.previous
        currentNodeAtIndex?.previous?.next = nodeToInsert
        currentNodeAtIndex?.previous = nodeToInsert
        count += 1
    }
    
    /** Delete the index-th node in the linked list, if the index is valid. */
    func deleteAtIndex(_ index: Int) {
        if index > count-1 || index < 0{
            return
        } else if (index == 0){
            first = first?.next
            first?.previous = nil
        }
        var currentNodeAtIndex = first
        for _ in 0..<index {
            currentNodeAtIndex = currentNodeAtIndex?.next
        }
        currentNodeAtIndex?.previous?.next = currentNodeAtIndex?.next
        currentNodeAtIndex?.next?.previous = currentNodeAtIndex?.previous
        count -= 1
    }
}

/**
 * Your MyLinkedList object will be instantiated and called as such:
 * let obj = MyLinkedList()
 * let ret_1: Int = obj.get(index)
 * obj.addAtHead(val)
 * obj.addAtTail(val)
 * obj.addAtIndex(index, val)
 * obj.deleteAtIndex(index)
 */
