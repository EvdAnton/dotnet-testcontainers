namespace DotNet.Testcontainers.Core.Images
{
  public interface IDockerImage
  {
    string Repository { get; }

    string Name { get; }

    string Tag { get; }

    string Image { get; set; }
  }
}