package org.example;

import java.util.Arrays;
import java.util.List;

public class Patrat
{
    public double latura;

    public Patrat()
    {
        latura = 1.0;
    }

    public Patrat(double latura)
    {
        if(latura <= 0.0)
            throw new RuntimeException("latura trebuie sa fie un numar pozitiv");
        this.latura = latura;
    }

    public double calculeazaAria()
    {
        if(latura <= 0.0)
            throw new RuntimeException("latura trebuie sa fie un numar pozitiv");
        return latura*latura;
    }
    public double calculeazaPerimetrul()
    {
        return 4*latura;
    }
}
