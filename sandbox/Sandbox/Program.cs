class Program
{
    static void Main(string[] args)
    {
        // Person person1 = new Person();
        // person1._name = "Luis";
        // person1._lastname = "Pardo";

        // Person person2 = new Person();
        // person2._name = "Diego";
        // person2._lastname = "Vasquez";

        // Group group1 = new Group();
        // group1._groupName = "Perrones";
        // group1._people.Add(person1);
        // group1._people.Add(person2);
        // group1.DisplayGroup();

        

        List<string> CrearLista(string palabra)
        {
            List<string> palabras = palabra.Split(" ").ToList();
            return palabras;
        }

        string CrearOracion()
        {   
            string oracion = "hey loco como estas, loco ayer te vi como eras";
            Console.WriteLine(oracion);
            Random rnd = new Random();
            List<string> palabras = CrearLista(oracion);
            int contador = 0;
            
            while(contador < palabras.Count)
            {   
                int index = rnd.Next(0, palabras.Count);
                contador = index;
                string nueva = new string('_', palabras[contador].Length);
                palabras[contador] = nueva;
                contador++;
            }

            oracion = string.Join(" ", palabras);
            return oracion;
        }

        void Hidden(){
            string ocultadas = CrearOracion();
            List<string> ls = ocultadas.Split(" ").ToList();

            for (int i = 0; i < ls.Count; i++)
            {
                if(ls[i] == (new string ('_', ls[i].Length)))
                {
                    Console.WriteLine($"{ls[i]} index: {i}");
                } else
                {
                    Console.WriteLine(ls[i]);
                }
            }
            
        }
        
        Hidden();
        

        
    }
}