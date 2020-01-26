class Book
{
  private string _title {get; set;}
  private string _author {get; set;}
  private string _publisher {get; set;}
  private int _ibsn {get; set;}
  public Book()//default constructor
  {
    _title = "";
    _author = "";
    _publisher = "";
    _ibsn = 0;
  }
  public Book(string t, string a, string p, int i)
  {
    _title = t;
    _author = a;
    _publisher = p;
    _ibsn = i;
  }
  public void DisplayBook()//display properties
  {
    Console.WriteLine(t+" "+a+" "+p+" "+i);
  }
}
