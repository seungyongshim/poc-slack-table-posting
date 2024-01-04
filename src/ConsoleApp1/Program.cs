
using ConsoleTables;
using Slack.NetStandard;
using Slack.NetStandard.Messages.Blocks;
using Slack.NetStandard.Messages.Elements;

const string slackWebToken = "";

var client = new SlackWebApiClient(slackWebToken);

var table = new ConsoleTable("IP", "Col1", "Col2", "Col3");

table.AddRow("1", "2", "3", "44444444444");

_ = await client.Chat.Post(new()
{
    Channel = "",
    Blocks = [
        new Section()
        {
            Text = new MarkdownText($$"""
                ```
                {{table}}
                ```
                """)
        },
        new Section()
        {
            Text = new MarkdownText($$"""
                ```
                {{Markdig.Markdown.ToHtml(table.ToMarkDownString())}}
                ```

                """)   
        }
    ]
});
