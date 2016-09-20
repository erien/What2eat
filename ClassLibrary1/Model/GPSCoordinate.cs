using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eat.Core.Model
{
    // Let it be a struct for a performance reasons - object of struct is a value?
    // It is an error to define a default (parameterless) constructor for a struct. 
    // It is also an error to initialize an instance field in a struct body. 
    // You can initialize struct members only by using a parameterized constructor 
    // or by accessing the members individually after the struct is declared. 
    // Any private or otherwise inaccessible members can be initialized only in a constructor.

    /*
    * There is no inheritance for structs as there is for classes. 
    * A struct cannot inherit from another struct or class, and it cannot be the base of a class.
    * Structs, however, inherit from the base class Object. 
    * A struct can implement interfaces, and it does that exactly as classes do.
    */
  
public struct GPSCoordinate
{
private readonly double latitude;
private readonly double longitude;

public double Latitude
{
    get { return latitude; }
}

public double Longitude
{
    get { return longitude; }
}

public GPSCoordinate(double latitude, double longitude)
{
    this.latitude = latitude;
    this.longitude = longitude;
}

public override string ToString()
{
    return string.Format("{0},{1}", Latitude, Longitude);
}
}
}
