using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesApp;

public class Address
{
    private int _houseNo;
    private string _street;
    private string _town;

    public Address(int houseNo = 0, string street = "", string town = "")
    {
        _houseNo = houseNo;
        _street = street;
        _town = town;
    }

    public override string ToString()
    {
        return $"Address: {_houseNo} {_street}, {_town}";
    }
}
