
using Slack.NetStandard;
using Slack.NetStandard.Messages.Blocks;
using Slack.NetStandard.Messages.Elements;

const string slackWebToken = "";

var client = new SlackWebApiClient(slackWebToken);


_ = await client.Chat.Post(new()
{
    Channel = "",
    Blocks = [
        new Section()
        {
            Text = new MarkdownText("111")
        }
    ]
});
