public void ShortestRemainingTimeFirst(List<Process> processes)
{
    int time = 0;
    int completed = 0;
    int n = processes.Count;

    foreach (var process in processes)
        process.RemainingTime = process.BurstTime; // Initialize

    while (completed != n)
    {
        Process current = null;
        int minRemaining = int.MaxValue;

        foreach (var p in processes)
        {
            if (p.ArrivalTime <= time && p.RemainingTime > 0 && p.RemainingTime < minRemaining)
            {
                minRemaining = p.RemainingTime;
                current = p;
            }
        }

        if (current == null)
        {
            time++; // No available process, CPU idle
            continue;
        }

        current.RemainingTime--;
        time++;

        if (current.RemainingTime == 0)
        {
            completed++;
            current.CompletionTime = time;
            current.TurnaroundTime = current.CompletionTime - current.ArrivalTime;
            current.WaitingTime = current.TurnaroundTime - current.BurstTime;
        }
    }
}