namespace PostmanCloneUI;

public partial class Dashboard : Form
{
    public Dashboard()
    {
        InitializeComponent();
    }

    private async void callApi_Click(object sender, EventArgs e)
    {
        //TODO: Validate the API URL

        try
        {
            systemStatus.Text = "Calling API...";

            // TODO: Replace with the actual API Call
            await Task.Delay(2000);

            systemStatus.Text = "Ready";
        }
        catch (Exception ex)
        {
            responseText.Text = "Error: " + ex.Message;
            systemStatus.Text = "Error";
        }
    }
}