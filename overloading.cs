using system;
public class Box
{
private double length;
private double breadth;
private double height;
public double getVolume()
{
return length*breadth*height;
}
public void setLength(double length)
{
this.length=length;
}
public void setBreadth(double breadth)
{
this.breadth=breadth;
}
public void setHeight(double height)
{
this.height=height;
}
public tatic Box operator+ (Box b1, Box b2)
{
Box box= new Box();
box.length= b1.length+ b2.length;
box.breadth= b1.breadth+ b2.breadth;
box.height= b1.height+ b2.height;
return box;
}
}