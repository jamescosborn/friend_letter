using Microsoft.AspNetCore.Mvc;

namespace FriendLetter.Controllers
{
  public class HomeController : Controller
  {
    [Produces("text/html")]
    [Route("/")]
    public string Letter()
    {
    return
        "<!DOCTYPE html>" +
        "<html>" +
        "<head>" +
          "<title>Hello Friend!</title>" +
          "<link rel='stylesheet' href='https://maxcdn.bootstrapcdn.com/bootstrap/3.2.0/css/bootstrap.min.css'>" +
        "</head>" +
        "<body>" +
          "<h1>Hello from Mordor</h1>" +
          "<img src='/img/mordor.jpg'/>" +
          "<p>Most Dearest Friend,</p>" +
          "<p>Help me. I hope that you are having a nice weekend. I'm learning programming while in Mordor! </p>" +
          "<p>Friend, send me some food. The orcs are unkind. I should have gone to Hawaii instead.</p>" +
          "<p>But I like programming a lot, so I've got that going for me. </p>" +
          "<p>Looking forward to escaping soon. I'll bring you back the ring of power. </p>" +
          "<p>Cheers,</p>" +
          "<p>Sauron's Prisoner</p>" +
        "</body>" +
        "</html>";

    }
    [Produces("text/html")]
[Route("/favorite_photos")]
public string FavoritePhotos()
{
return
  "<!DOCTYPE html>" +
  "<html>" +
    "<head>" +
      "<title>Hello Friend!</title>" +
      "<link rel='stylesheet' href='https://maxcdn.bootstrapcdn.com/bootstrap/3.2.0/css/bootstrap.min.css'>" +
    "</head>" +
    "<body>" +
      "<h1>Favorite Traveling Photos</h1>" +
      "<ul>" +
        "<li><img src='/img/chumbawumba.jpg'/></li>" +
        "<li><img src='/img/hanggliding.jpg'/></li>" +
        "<li><img src='/img/crystalpepsi.jpg'/></li>" +
      "</ul>" +
    "</body>" +
  "</html>";
  }
}
}
