# Fibonacci

the Fibonacci sequence is a sequence in which each number is the sum of the two preceding ones.

## The difference in the loop and recursion model

Loops and recursion are two methods for performing repetitive tasks in programming. Loops use constructs like for and while to repeatedly execute code based on a condition, typically managing state with variables and being more memory-efficient. Recursion involves a function calling itself with simpler sub-problems and relies on the call stack to manage state, which can lead to higher memory usage and potential stack overflow issues. While loops are generally more straightforward and performant for simple iterations, recursion can be more elegant for problems that naturally fit a divide-and-conquer approach, though it may be less efficient due to the overhead of multiple function calls.

## The Big O Notation for this algorithm and how you arrive at that conclusion

To determine the Big O notation of an algorithm, analyze how its time or space complexity scales with the input size by examining the number of fundamental operations and the structure of the algorithm, such as loops or recursive calls. Identify the dominant term that grows the fastest as the input size increases, and simplify the complexity expression by dropping constants and lower-order terms. For instance, a nested loop that iterates n times in each loop has a time complexity of O(n^2), while a recursive function that makes two calls per level with depth n has a time complexity of O(2^n).
