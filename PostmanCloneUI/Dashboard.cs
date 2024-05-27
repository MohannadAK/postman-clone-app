using PostmanCloneLibrary;

namespace PostmanCloneUI;

public partial class Dashboard : Form
{
    private readonly IApiAccess _apiAccess = new ApiAccess();
    public Dashboard()
    {
        InitializeComponent();
        httpVerbSelection.SelectedIndex = 0;
    }

    private async void callApi_Click(object sender, EventArgs e)
    {
        systemStatus.Text = "Calling API...";
        responseText.Text = string.Empty;

        if (!_apiAccess.IsValidUrl(apiText.Text))
        {
            systemStatus.Text = "Invalid URL";
            return;
        }

        //HttpAction action = (HttpAction)httpVerbSelection.SelectedIndex;
        HttpAction action;
        if (!Enum.TryParse(httpVerbSelection.SelectedItem!.ToString(), out action))
        {
            systemStatus.Text = "Invalid HTTP Verb";
            return;
        }

        try
        {
            responseText.ForeColor = Color.Black;
            responseText.Text = await _apiAccess.CallApiAsync(apiText.Text, bodyText.Text, action);
            callData.SelectedTab = responseTab;
            responseTab.Focus();

            systemStatus.Text = "Ready";
        }
        catch (Exception ex)
        {
            responseText.ForeColor = Color.Red;
            responseText.Text = "Error: " + ex.Message;
            systemStatus.Text = "Error";
        }
    }
}