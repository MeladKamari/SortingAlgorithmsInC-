using SortingAlgorithms;
var studentRecord = new SortedList();
const int min = 1;
const int max = 5000;
studentRecord.Add(Enumerable
    .Repeat(0, 20)
    .Select(i => Random.Shared.Next(min, max))
    .ToArray());
studentRecord.SetSortStrategy(new BucketSort());
studentRecord.Sort();