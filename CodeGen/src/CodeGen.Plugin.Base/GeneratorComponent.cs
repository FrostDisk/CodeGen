namespace CodeGen.Plugin.Base
{
    /// <summary>
    /// GeneratorComponent
    /// </summary>
    public class GeneratorComponent
    {
        /// <summary>
        /// Id
        /// </summary>
        public int Id { get; private set; }

        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Extension
        /// </summary>
        public string Extension { get; private set; }

        /// <summary>
        /// Object
        /// </summary>
        public object Object { get; private set; }

        /// <summary>
        /// GeneratorComponent
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="extension"></param>
        /// <param name="obj"></param>
        public GeneratorComponent(int id, string name, string extension, object obj = null)
        {
            Id = id;
            Name = name;
            Extension = extension;
            Object = obj;
        }
    }
}
