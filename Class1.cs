using System;

public class Class1
{
    private double answer;
    private float weightOnEarth;
    private float weightOnMars;

    public Class1(float  weightOnEarth, float weightOnEarth)
	{
        this.answer = 0;
        this.weightOnEarth = 0;
        this.weightOnMars = 0;
    }

    public float calcuate()
    {
        float value = (weightOnEarth / 9.81) * 3.711;
        return value;
    }

    public void print()
    {

    }
}
