This simple console calculator application allows users to perform basic arithmetic operations such as addition, subtraction, multiplication, and division. The calculator logs each operation along with its operands and result to a JSON file named "calculatorlog.json".
Features:

    Addition
    Subtraction
    Multiplication
    Division

Prerequisites:

    .NET Core SDK installed on your machine

Usage:

    Clone or download the repository to your local machine.
    Navigate to the project directory in your terminal or command prompt.
    Run the application using the following command:

    arduino

    dotnet run

    Follow the on-screen instructions to perform calculations.
    Press 'n' and Enter to exit the application.

Code Structure:

    CalculatorLibrary: Contains the Calculator class responsible for performing arithmetic operations and logging them to a JSON file.
    CalculatorProgram: Contains the Program class with the main method responsible for user interaction and invoking the calculator functionalities.

File Structure:

    calculatorlog.json: JSON file where all operations are logged along with their details.

Dependencies:

    Newtonsoft.Json: Used for JSON serialization.

How to Contribute:

    Fork the repository.
    Make your changes and enhancements.
    Create a pull request with a detailed description of your changes.

Notes:

    This calculator handles invalid inputs gracefully by prompting the user to enter valid numeric values.
    Division by zero is prevented by checking the divisor before performing the operation.
    All operations are logged to the JSON file in a structured format for easy reference and analysis.

Enjoy calculating! If you have any questions or suggestions, feel free to reach out.
