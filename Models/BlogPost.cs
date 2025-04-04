using System;
using System.Collections.Generic;
using Contentful.Core.Models;

namespace LuceCarterPersonalBlog.Models;
public class BlogPost
{
    public DateTime Date { get; set; }
    public string Title { get; set; }
    public string Slug { get; set; }
    public Person Author { get; set; }
    public string Excerpt { get; set; }
    public List<string> Tags { get; set; }
    public string ExternalUrl { get; set; }
    public Document Body { get; set; }
}
