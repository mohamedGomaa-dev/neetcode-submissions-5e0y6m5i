class MinStack:
    
    def __init__(self):
        self.stack = []    

    def check_empty(self, stack):
        return len(self.stack) == 0

    def push(self, val: int) -> None:
        self.stack.append(val)

    def pop(self) -> None:
        if(self.check_empty(self.stack)):
            print("stack is empty can't add items")
        else:
            self.stack.pop()

    def top(self) -> int:
        if len(self.stack) == 0:
            print('empty stack')
        else:
            return self.stack[len(self.stack) - 1]

    def getMin(self) -> int:
        if len(self.stack) == 0:
            print('empty stack')
        else:
            return min(self.stack)
        
        
