namespace Project.Domain.Entities;

public class Phone
{
    public int ID {get ; set;}
    public string Title {get ; set;}
    public string Number {get ; set;}

    public int PersoneID {get ; set;}
    public Persone Persone {get ; set;}
}