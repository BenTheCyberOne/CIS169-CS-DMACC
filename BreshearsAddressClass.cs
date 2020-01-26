public class Address{
  private int _houseNum;
  private string _streetName;
  private string _addr2;
  private string _townName;
  private string _state;
  private string _zipCode;//is string because of Zipcode format #####-####
  private string _country;
  public Address(){
    _houseNum = 0;
    _streetName = "";
    _addr2 = "";
    _townName = "";
    _state = "";
    _zipCode = "";
    _country = "";
  }
  public Address(int houseNum, string streetName, string townName, string state, string zipCode, string country){
    _houseNum = houseNum;
    _streetName = streetName;
    _townName = townName;
    _state = state;
    _zipCode = zipCode;
    _country = country;
  }
  public Address(int houseNum, string streetName, string addr2, string townName, string state, string zipCode, string country){
    _houseNum = houseNum;
    _streetName = streetName;
    _addr2 = addr2;
    _townName = townName;
    _state = state;
    _zipCode = zipCode;
    _country = country;
  }
  public int HouseNumber{
    get {return _houseNum;}
    set {_houseNum = value;}
  }
  public string StreetName{
    get {return _streetName;}
    set {_streetName = value;}
  }
  public string AddressExtension{
    get {return _addr2;}
    set {_addr2 = value;}
  }
  public string TownName{
    get {return _townName;}
    set {_townName = value;}
  }
  public string State{
    get {return _state;}
    set {_state = value;}
  }
  public string ZipCode{
    get {return _zipCode;}
    set {_zipCode = value;}
  }
  public string Country{
    get {return _country;}
    set {_country = value;}
  }
}
