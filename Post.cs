namespace Post
{
  public class Post
  {
    private string _title;
    private string _decription;

    private int _voteCount = 0;

    public Post( string title, string decription){
      _title = title;
      _decription = decription;
    }

    public void upVote(){
      _voteCount = _voteCount + 1;
    }

    public void downVote(){
      _voteCount = _voteCount - 1;
    }

    public int getVote() {
      return _voteCount;
    }

  }
}