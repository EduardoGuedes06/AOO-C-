namespace AOO{
    class program{
        static void Main(string[] args)
        {
            var curso = new ContentContext.Curso();
            var content = new ContentContext.Content();
            curso.Nivel = ContentContext.Enumerador.EConentlevel.Begginer;
            foreach (var item in curso.Modulos)
            {
                
            }

        }

    }

}