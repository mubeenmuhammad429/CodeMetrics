import ast

# Student sample code for testing AST parsing
student_code = """
def calculate_factorial(n):
    result = 1
    for i in range(1, n + 1):
        result *= i
    return result
"""

# Convert code into Abstract Syntax Tree (AST)
tree = ast.parse(student_code)

print("=== CODE PARSED SUCCESSFULLY INTO AST TREE ===")
print(ast.dump(tree, indent=4))