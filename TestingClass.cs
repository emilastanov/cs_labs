using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Reflection
{
    public class TestingClass
    {
 public int Sum(int a, int b) { return  a+b;}
 public void Array(Array x){ return ;}
 public int x;
[NewAttribute("Property1")]
public string property1
 {
 get { return _property1; }
 set { _property1 = value; }
 }
 private string _property1;
 public int property2 { get; set; }
 [NewAttribute(Description = "Property3")]
 public double property3 { get; private set; }
 public int field1;
 public float field2;

    }
}
