namespace Folio.Services;
using Folio.Models;
using Markdig;

public class BlogService
{
    private readonly string _contentPath = Path.Combine(Directory.GetCurrentDirectory(), "Content");

    public List<Post> GetAllPosts()
    {
        var posts = new List<Post>();
        if (!Directory.Exists(_contentPath)) return posts;

        foreach (var dir in Directory.GetDirectories(_contentPath))
        {
            var slug = Path.GetFileName(dir);
            var mdPath = Path.Combine(dir, "index.md");

            if (File.Exists(mdPath))
            {
                var mdContent = File.ReadAllText(mdPath, System.Text.Encoding.UTF8);
                var pipeline = new MarkdownPipelineBuilder().UseAdvancedExtensions().Build();
                var html = Markdown.ToHtml(mdContent, pipeline);

                posts.Add(new Post
                {
                    Slug = slug,
                    Title = slug.Replace("-", " "),
                    HtmlContent = html
                });
            }
        }
        return posts;
    }
}