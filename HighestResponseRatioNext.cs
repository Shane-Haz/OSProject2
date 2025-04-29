public void HighestResponseRatioNext(List<Process> processes)
{
    int time = 0;
    int completed = 0;
    int n = processes.Count;

    while (completed != n)
    {
        List<Process> available = processes
            .Where(p => p.ArrivalTime <= time && p.CompletionTime == 0)
            .ToList();

        if (available.Count == 0)
        {
            time++; // No process ready, CPU idle
            continue;
        }

        Process current = available
            .OrderByDescending(p =>
            {
                int waitingTime = time - p.ArrivalTime;
                double responseRatio = (double)(waitingTime + p.BurstTime) / p.BurstTime;
                return responseRatio;
            })
            .First();

        time += current.BurstTime;
        current.CompletionTime = time;
        current.TurnaroundTime = current.CompletionTime - current.ArrivalTime;
        current.WaitingTime = current.TurnaroundTime - current.BurstTime;
        completed++;
    }
}