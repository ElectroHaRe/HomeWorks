namespace _008_Serialization
{
    public class ClassForXMLSerialization
    {
        public int firstField = 1;
        public string SecondField = "SF";

        public override string ToString()
        {
            return "First field = " + firstField.ToString() + " | Second field = " + SecondField;
        }

        public void ResetFields()
        {
            firstField = default(int);
            SecondField = default(string);
        }
    }
}
