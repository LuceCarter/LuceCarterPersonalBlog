using LuceCarterPersonalBlog.Models;
using Contentful.Core;
using Contentful.Core.Search;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LuceCarterPersonalBlog.Services;
public class BlogPostService
{
    private readonly IContentfulClient _client;

    public BlogPostService(IContentfulClient client)
    {
        _client = client;
    }

    public async Task<IEnumerable<BlogPost>> GetAllBlogPostsAsync()
    {
        var query = QueryBuilder<BlogPost>.New.ContentTypeIs("blogPost");
        return await _client.GetEntries(query);
    }
}
