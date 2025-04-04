using Contentful.Core.Models;

namespace LuceCarterPersonalBlog.Models;

public class Person
{ 
    public Asset Image { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public string TwitterUsername { get; set; }

    public string GitHubUsername { get; set; }

    public string TwitchUsername { get; set; }

    public string WebsiteUrl { get; set; }
}