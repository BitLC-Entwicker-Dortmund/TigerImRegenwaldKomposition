namespace TigerImRegenwaldKomposition {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello, Tiger!");

            Regenwald rw= new Regenwald();
            rw.SetTiger(new Tiger("Toni"));
            rw.SetTiger(new Tiger("Rugu"));
            rw.SetTiger(new Tiger("Rednaxela"));
            rw.SetTiger(new Tiger("Damahom"));


            Console.WriteLine(   rw.GetTiger()[1].GetName()  );
            //Console.WriteLine(   rw.GetTiger()[3].GetName()  );

            rw = null; // Regenwald zerstören ;-)

            //Console.WriteLine(rw.GetTiger()[1].GetName()); // hier sollte ein Fehler auftauchen

            Console.Read();
        }
    }
}