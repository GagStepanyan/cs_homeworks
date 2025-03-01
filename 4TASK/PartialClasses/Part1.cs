public partial class Character {
    string? _characterName;
    int _characterLevel;

    public string Name {
        get {return  _characterName!;}
        set { _characterName = value; }
    }

    public int Level {
        get {return _characterLevel;}
        set { _characterLevel = value;}   
    }


}