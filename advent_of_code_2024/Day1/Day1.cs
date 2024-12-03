namespace advent_of_code_2024.day1;

public class Day1 : ISolution<int>
{
    public required string InputFile { get; init; }
    internal readonly SortedChainBuilder<int> ScbLeft = new(((value1, value2) => value1.CompareTo(value2)));
    internal readonly SortedChainBuilder<int> ScbRight = new(((value1, value2) => value1.CompareTo(value2)));
    public virtual int Solve()
    {
        using var fs = new FileStream(InputFile, FileMode.Open);
        using var sr = new StreamReader(fs);
        while (sr.ReadLine() is { } line)
        {
            var parts = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            ScbLeft.Add(int.Parse(parts[0]));
            ScbRight.Add(int.Parse(parts[1]));
        }
        using var enumeratorLeft = ScbLeft.Build().GetEnumerator();
        using var enumeratorRight =  ScbRight.Build().GetEnumerator();
        var result = 0;
        do
        {
            result += Math.Abs(enumeratorLeft.Current - enumeratorRight.Current);
        } while (enumeratorLeft.MoveNext() && enumeratorRight.MoveNext());
        return result;
    }

    public class SortedChainBuilder<T>(SortedChainBuilder<T>.ComparatorDelegate comparator)
    {
        private ChainElement? _start;

        public delegate int ComparatorDelegate(T value1, T value2);

        public void Add(T value)
        {
            if (_start is not {} start)
            {
                _start = new ChainElement()
                {
                    Value = value
                };
                return;
            }

            var itElement = start;

            while (itElement.Next is not null && comparator(itElement.Value, value) < 0)
            {
                itElement = itElement.Next;
            }

            var inserted = new ChainElement()
            {
                Value = value,
            };


            if (comparator(itElement.Value, value) < 0)
            {
                // after
                var before = itElement;
                var after = itElement.Next;
                inserted.Previous = before;
                inserted.Next = after;
                before.Next = inserted;
                if(after is not null)
                    after.Previous = inserted;
            }
            else
            {
                // before
                var before = itElement.Previous;
                var after = itElement;
                inserted.Previous = before;
                inserted.Next = after;
                if (before is not null)
                    before.Next = inserted;
                else
                    _start = inserted;
                after.Previous = inserted;
            }

        }

        public IEnumerable<T> Build()
        {
            if (_start is null)
                yield break;
            var itElement = _start;
            yield return itElement.Value;
            while (itElement is { Next: not null })
            {
                itElement = itElement.Next;
                yield return itElement.Value;
            }
        }

        public class ChainElement
        {
            public required T Value { get; set; }
            public ChainElement? Next { get; set; }
            public ChainElement? Previous { get; set; }
        }

    }

}