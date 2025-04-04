using Contentful.Core.Models;
using Document = System.Reflection.Metadata.Document;

namespace LuceCarterPersonalBlog;

public class UsesEntry
{
    public string Name { get; set; }

    public Document Description { get; set; }

    public string ToolUrl { get; set; }

    public Asset ToolIcon { get; set; }
}
