# FPL Manager

Welcome to **FPL Manager**, a console application for managing your Fantasy Premier League (FPL) football team. This simple program allows you to set up a team by selecting players and viewing team statistics. 

## Features

- Display available players with their details.
- Add players to your team using player ID.
- Calculate total points for your team based on individual player performance.
- Currently includes placeholder methods for input validation, removing players, and viewing the team.

## Getting Started

### Prerequisites

- .NET SDK (version required: **5.0 or higher**)

### Installation

1. Clone the repository:
   ```bash
   git clone https://github.com/yourusername/fpl-manager.git
   ```
2. Navigate to the project directory:
   ```bash
   cd fpl-manager
   ```

3. Restore the dependencies (if any):
   ```bash
   dotnet restore
   ```

### Running the Application

To run the application, use the following command:

```bash
dotnet run
```

### Code Structure

```plaintext
├── Program.cs       // Main application logic
├── Player.cs        // Player class management
└── Team.cs          // Team class management
```

- **Program.cs**: Contains the main logic for user interaction and team setup.
- **Player.cs**: Handles player properties and methods like viewing player details.
- **Team.cs**: Manages team players, total points calculation, adding and removing players.

## Example Usage

Upon running the application, you'll be greeted with:

```
Welcome to FPLManager...
Let's set up your team!
-------------------------
Here are available players: 
1. ST
   Erling Haaland
2. CM
   Dominic Szobozlai
3. DEF
   Gabriel
To add player use player ID e.g. 1 adds Erling Haaland
```

You can then enter the corresponding numbers to add players to your team.

## Future Features

- Connect with actual Premier League API
- A better view of the current team and its total points.
- Points based on actual data.

## Contributing

If you'd like to contribute to the project, feel free to fork the repository and submit a pull request!

## License

This project is licensed under the GNU License - see the [LICENSE](LICENSE) file for details.

---

Feel free to customize any section further or let me know if you'd like more specific details added!
