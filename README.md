# DSA Study

A comprehensive study of Data Structures and Algorithms implemented in C#. This project serves as both a learning resource and a practical implementation of various DSA concepts.

## Project Structure

The solution is organized into two main projects:

- **DSAStudy.Core**: Contains the core implementations of algorithms and data structures
- **DSAStudy.Tests**: Contains comprehensive unit tests for all implementations

## Current Implementations

### Arrays
- [Two Sum](DSAStudy.Core/Algorithms/Arrays/TwoSum.cs)
  - Problem: Find two numbers in an array that add up to a target value
  - Time Complexity: O(n)
  - Space Complexity: O(n)
  - [Tests](DSAStudy.Tests/Algorithms/Arrays/TwoSumTests.cs)

## Getting Started

### Prerequisites
- .NET 9.0 SDK or later
- Your favorite IDE (Visual Studio, VS Code, Rider, etc.)

### Building the Project
```bash
# Clone the repository
git clone https://github.com/yourusername/DSAStudy.git

# Navigate to the project directory
cd DSAStudy

# Restore dependencies
dotnet restore

# Build the solution
dotnet build

# Run tests
dotnet test
```

## Contributing

Contributions are welcome! Please feel free to submit a Pull Request. For major changes, please open an issue first to discuss what you would like to change.

## Testing

The project uses xUnit for testing. Each algorithm implementation includes comprehensive test cases covering:
- Basic functionality
- Edge cases
- Performance scenarios
- Error cases

To run the tests:
```bash
dotnet test
```

## Project Goals

1. Implement common data structures and algorithms
2. Provide clear, well-documented code
3. Include comprehensive test coverage
4. Serve as a learning resource for DSA concepts
5. Demonstrate best practices in C# development

## Planned Implementations

### Data Structures
- [ ] Linked Lists
- [ ] Stacks and Queues
- [ ] Trees (Binary, AVL, Red-Black)
- [ ] Graphs
- [ ] Hash Tables
- [ ] Heaps

### Algorithms
- [ ] Sorting Algorithms
  - [ ] Quick Sort
  - [ ] Merge Sort
  - [ ] Heap Sort
- [ ] Searching Algorithms
  - [ ] Binary Search
  - [ ] Depth-First Search
  - [ ] Breadth-First Search
- [ ] Dynamic Programming
- [ ] Greedy Algorithms
- [ ] Graph Algorithms
  - [ ] Dijkstra's Algorithm
  - [ ] Kruskal's Algorithm
  - [ ] Prim's Algorithm

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Acknowledgments

- Inspired by various DSA learning resources and coding interview preparation materials
- Built with .NET and xUnit 