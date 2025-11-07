public class Resume
{
    public string _personsName;
    public List<Job> _jobs = new List<Job>(); 

    public void DisplayResumeInfo()
    {
        Console.WriteLine(_personsName);
        foreach (Job job in _jobs)
        {
            job.DisplayJobDetails();
        } 

    }
}