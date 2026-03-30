class Solution:
    def isValid(self, s: str) -> bool:
        stack = []
        for item in s:
            
            if (item == '(' or item == '[' or item == '{'):
                stack.append(item)

            if (len(stack) != 0):
                if ((item == ')' and stack[len(stack) - 1] == '(') or 
                (item == ']' and stack[len(stack) - 1] == '[') or
                (item == '}' and stack[len(stack) - 1] == '{')):
                    stack.pop()
                elif(item != '(' and item != '[' and item != '{' ):
                    return False
            elif (item == ')' or item == ']' or item == '}'): 
                return False
        return True if len(stack) == 0 else False
        