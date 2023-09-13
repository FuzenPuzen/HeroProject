using System.Collections;
using System.Collections.Generic;

public class HeroSLData
{
    private int _id;
    private int _level;
    private bool _isOpened;
    private bool _isSquaded;

    public HeroSLData(int id)
    {
        _id = id;
        _level = 0;
        _isOpened = false;
        _isSquaded = false;
    }

    public int Level { get => _level; set => _level = value; }
    public bool IsOpened { get => _isOpened; set => _isOpened = value; }
    public bool IsSquaded { get => _isSquaded; set => _isSquaded = value; }
    public int Id { get => _id;}
}
