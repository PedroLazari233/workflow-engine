using workflow_engine;

internal class Program
{
    private static void Main(string[] args)
    {
        var workflow = new Workflow();

        workflow.RegisterActivity(new UploadVideo());
        workflow.RegisterActivity(new WebService());
        workflow.RegisterActivity(new EmailNotification());
        workflow.RegisterActivity(new Status());

        workflow.Run();
    }
}