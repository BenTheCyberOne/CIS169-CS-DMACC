class TextBook : Book
{
  private string _category {get; set;}
  private string _editor {get; set;}
  public TextBook(string t, string a, string p, string i, string c, string e) base : (t,a,p,i)//constructor with base of Book
  {
    _category = c;
    _editor = e;
  }
  public void DisplayTextBook()//display properties
  {
    Console.WriteLine(t+" "+a+" "+p+" "+i+" "+c+" "+" "+e);
  }
}
