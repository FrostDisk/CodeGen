namespace CodeGen.Plugin.Base
{
    public class GeneratorComponent
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public GeneratorComponent(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
