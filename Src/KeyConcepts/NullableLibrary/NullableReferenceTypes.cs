namespace NullableLibrary
{
    public class NullableReferenceTypes
    {
        public string? firstname { get; set; }
        public string surname { get; set; }
        public int age { get; set; }
        public int? department { get; set; }
    }

    public class CreateNullable
    {




        public NullableReferenceTypes CreatePerson()
        {
            NullableReferenceTypes nullableReferenceTypes = new NullableReferenceTypes();


            return nullableReferenceTypes;
        }

    }
}