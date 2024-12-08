namespace advent_of_code_2024.Day5;

public class Day6 : ASolution<int>
{

    char[][] map = null!;
    public override int Solve()
    {
        map = File
            .ReadAllLines(InputFile)
            .Select(line => line.ToCharArray())
            .ToArray();
        while(isValidGame())
        {
            printMap();
            (int x, int y) = GetGuardPosition();
            (int xNext, int yNext) = GetNextPosition((x, y));
            bool isInRange = xNext >= 0 && xNext < map.Length && yNext >= 0 && yNext < map[0].Length;
            if(isInRange && map[xNext][yNext] == '#')
            {
                // turn right
                TurnRight((x,y));
            }
            else
            {
                if(isInRange)
                    map[xNext][yNext] = map[x][y];
                map[x][y] = 'X';
            }

        }
        printMap();
        return map.Aggregate(0, (i,l) => i + l.Count(c => c == 'X'));
    }

    private void printMap()
    {
        if (!InputFile.Contains("test")) return;
        foreach (var line in map)
        {
            Console.WriteLine(line);
        }
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
    }

    bool isValidGame()
    {
        return map.Any(l => l.Any(isGuard));
    }

    bool isGuard(char c)
    {
        return c == '^' || c == '>' || c == 'v' || c == '<';
    }

    (int x, int y) GetGuardPosition()
    {
        for (var y = 0; y < map.Length; y++)
        {
            for (var x = 0; x < map[y].Length; x++)
            {
                if (isGuard(map[x][y]))
                {
                    return (x, y);
                }
            }
        }
        return (-1, -1);
    }

    (int x, int y) GetNextPosition((int x, int y) position)
    {
        var (x, y) = position;
        var c = map[x][y];
        switch (c)
        {
            case '^':
                return (x -1, y);
            case '>':
                return (x, y + 1);
            case 'v':
                return (x + 1, y);
            case '<':
                return (x, y - 1);
            default:
                return (-1, -1);
        }
    }
    void TurnRight((int x, int y) position)
    {
        var (x, y) = position;
        var c = map[x][y];
        switch (c)
        {
            case '^':
                map[x][y] = '>';
                break;
            case '>':
                map[x][y] = 'v';
                break;
            case 'v':
                map[x][y] = '<';
                break;
            case '<':
                map[x][y] = '^';
                break;
        }
    }



}