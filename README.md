# Text Analyzer - NLP Windows Forms Application

## Project Overview
A C# Windows Forms Application that performs basic Natural Language Processing (NLP) tasks on user-entered text. This application demonstrates Windows Forms design, event-driven programming, and string manipulation in C#.

## Features

### Part 1: User Interface
- Clean, organized GUI with proper controls
- Multiline TextBox for text input
- Multiple labels and result fields for displaying analysis
- Action buttons for analysis and clearing
- Optional GroupBox for organization

### Part 2: NLP Features
When the user clicks "Analyze Text", the program displays:
1. **Character Count** - Total characters including spaces
2. **Word Count** - Total number of words
3. **Sentence Count** - Count based on `.`, `!`, `?`
4. **Vowel Count** - Count of a, e, i, o, u (case-insensitive)
5. **Most Frequent Word** - The most repeated word in the text

### Part 3: Search Feature
- TextBox to enter a search word
- Search button to find word occurrence count
- Displays how many times the word appears

### Part 4: Clear Functionality
- Clear button removes all text
- Clears all analysis outputs
- Resets the form to initial state

### Bonus Features
- Dark mode toggle
- MenuStrip with File and Tools menus
- Save results to file
- Read text from file
- Word frequency table (ListBox)
- Stop-word removal option

## Technical Details
- **Language**: C# (.NET Framework)
- **UI Framework**: Windows Forms
- **Target**: .NET Framework 4.7.2 or higher

## Project Structure
```
text-analyzer-nlp/
├── TextAnalyzer/
│   ├── Form1.cs
│   ├── Form1.Designer.cs
│   ├── Form1.resx
│   ├── Program.cs
│   ├── NLPAnalyzer.cs
│   ├── TextAnalyzer.csproj
│   ├── App.config
│   └── Properties/
│       ├── AssemblyInfo.cs
│       ├── Resources.resx
│       └── Settings.settings
├── TextAnalyzer.sln
└── README.md
```

## Getting Started

### Prerequisites
- Visual Studio 2019 or later
- .NET Framework 4.7.2 or higher
- C# knowledge (basic to intermediate)

### Running the Application
1. Open `TextAnalyzer.sln` in Visual Studio
2. Build the solution (Ctrl+Shift+B)
3. Run the application (F5)
4. Enter or paste text in the TextBox
5. Click "Analyze Text" to see the NLP results

## Usage Example

1. **Input**: "Hello world! This is a test. How are you?"
2. **Results**:
   - Character Count: 44
   - Word Count: 8
   - Sentence Count: 3
   - Vowel Count: 12
   - Most Frequent Word: "is" or similar
3. **Search**: Enter "a" to find all occurrences

## Learning Objectives
- Windows Forms design and layout
- Event-driven programming with event handlers
- Using various controls (TextBox, Label, Button, etc.)
- String manipulation and parsing in C#
- NLP basics and text analysis techniques
- Methods/functions for code organization
- GUI development best practices
- Debugging and testing applications

## Future Enhancements
- Sentiment analysis integration
- Text summarization
- Language detection
- Export to PDF
- Real-time analysis as user types
