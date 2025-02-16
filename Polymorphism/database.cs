using System;

public abstract class DatabaseConnector
{
    public abstract void Connect();
}

public class SQLDatabase : DatabaseConnector
{
    public override void Connect()
    {
        Console.WriteLine("Connecting to SQL Database...");
    }
}

public class MongoDBDatabase : DatabaseConnector
{
    public override void Connect()
    {
        Console.WriteLine("Connecting to MongoDB Database...");
    }
}

public class FirebaseDatabase : DatabaseConnector
{
    public override void Connect()
    {
        Console.WriteLine("Connecting to Firebase Database...");
    }
}

public class Program
{
    public static void Main()
    {
        DatabaseConnector sqlDb = new SQLDatabase();
        sqlDb.Connect();

        DatabaseConnector mongoDb = new MongoDBDatabase();
        mongoDb.Connect();

        DatabaseConnector firebaseDb = new FirebaseDatabase();
        firebaseDb.Connect();
    }
}
