namespace MessageServiceClientApp
{
    public class Node
    {
        public int Key { get; set; }
        public MService.Message Value { get; set; }

        public Node(int key, MService.Message value)
        {
            Key = key;
            Value = value;
        }
    }
}