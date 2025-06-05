# DSA Study

A comprehensive study of Data Structures and Algorithms implemented in C#. This project serves as both a learning resource and a practical implementation of various DSA concepts.

## Project Structure

The solution is organized into two main projects:

- **DSAStudy.Core**: Contains the core implementations of algorithms and data structures
- **DSAStudy.Tests**: Contains comprehensive unit tests for all implementations

## Current Implementations

### Array Mastery

A collection of essential array algorithms, each with clean C# implementations and comprehensive xUnit tests.

| Algorithm                        | Description                                                      | Status   |
|----------------------------------|------------------------------------------------------------------|----------|
| Remove Duplicates from Sorted Array | Remove duplicates in-place from a sorted array.                  | ✅ Implemented & Tested |
| Move Zeros to End                | Move all zeros to the end of the array, maintaining order.        | ✅ Implemented & Tested |
| Rotate Array by K                | Rotate the array to the right by k steps.                        | ✅ Implemented & Tested |
| Kadane's Max Subarray Sum        | Find the maximum sum of a contiguous subarray (Kadane's).         | ✅ Implemented & Tested |
| Prefix Sum Array                 | Build a prefix sum array and answer range sum queries.            | ✅ Implemented & Tested |
| Merge Two Sorted Arrays          | Merge two sorted arrays into one sorted array.                    | ✅ Implemented & Tested |
| Find Missing Number              | Find the missing number in a sequence from 0 to n.                | ✅ Implemented & Tested |
| Find Duplicate Number            | Find the duplicate number in an array of n+1 elements.            | ✅ Implemented & Tested |
| Product Except Self              | Product of array except self, without division.                   | ✅ Implemented & Tested |

Each algorithm includes:
- Clean function signature
- Edge case handling
- xUnit test coverage
- Performance scenario (where meaningful)

See the `DSAStudy.Core/Algorithms/Arrays/` and `DSAStudy.Tests/Algorithms/Arrays/` directories for code and tests.

### String Manipulation

A collection of essential string manipulation algorithms, each with clean C# implementations and comprehensive xUnit tests.

| Algorithm                        | Description                                                      | Status   |
|----------------------------------|------------------------------------------------------------------|----------|
| Count Vowels and Consonants      | Count vowels and consonants in a string, handling Unicode.       | ✅ Implemented & Tested |
| First Unique Character           | Find the first non-repeating character in a string.              | ✅ Implemented & Tested |
| Remove Duplicate Characters      | Remove duplicate characters while preserving order.              | ✅ Implemented & Tested |
| String Rotation Check            | Check if one string is a rotation of another.                    | ✅ Implemented & Tested |
| Reverse String                   | Reverse a string in-place.                                       | ✅ Implemented & Tested |

Each algorithm includes:
- Clean function signature
- Edge case handling
- Unicode character support
- xUnit test coverage
- Performance considerations

See the `DSAStudy.Core/Strings/` and `DSAStudy.Tests/Strings/` directories for code and tests.

## Getting Started

### Prerequisites
- .NET 9.0 SDK or later
- Your favorite IDE (Visual Studio, VS Code, Rider, etc.)

### Building the Project
```bash
# Clone the repository
git clone https://github.com/justinianstefan/DSAStudy.git

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