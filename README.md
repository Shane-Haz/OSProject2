# 📄 CPU Scheduling Simulator

This project implements and compares different CPU scheduling algorithms in C#.  
The algorithms are integrated into a Windows Forms-based simulator originally provided as a starter project for CS 3502 (Operating Systems) at Kennesaw State University.

---

## ✨ Features

- **Shortest Remaining Time First (SRTF)** _(preemptive)_
- **Highest Response Ratio Next (HRRN)** _(non-preemptive)_

The simulator calculates and displays:
- Average Waiting Time
- Average Turnaround Time
- Completion Times for each process

---

## 🛠 Project Structure

- `Process.cs`: Defines the Process class with necessary attributes.
- `HighestResponseRatioNext.cs`, 'ShortestRemainingTimeFirst.cs': Implements SRTF and HRRN scheduling methods.

---

## 🚀 How to Run

1. Clone the repository:

    ```bash
    git clone https://github.com/YOUR_USERNAME/YOUR_REPO_NAME.git
    ```

2. Open the project in **Visual Studio**.

3. Build and run the solution.

4. In the application, select the scheduling algorithm you want to simulate and click **Run**.

---

## 📈 Sample Output
After running the simulator, the console or GUI will show output like:

Process P1: WT = 2, TAT = 10  
Process P2: WT = 1, TAT = 5  
Process P3: WT = 7, TAT = 16  

Average Waiting Time = 3.33  
Average Turnaround Time = 10.33  


## 📚 Technologies Used

- **C#** (Windows Forms)
- **Visual Studio 2022**
- **.NET Framework 4.7.2**
