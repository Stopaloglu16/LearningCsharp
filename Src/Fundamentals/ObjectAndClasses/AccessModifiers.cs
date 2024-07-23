namespace ObjectAndClasses
{
    internal class AccessModifiers
    {

        public void Usage()
        {
            //Protected Access Modifier
            DerivedClass derivedClass = new DerivedClass();
            derivedClass.AccessProtectedMembers(); // Accesses protected members
                                                   // derivedClass.ProtectedProperty = "Cannot be accessed"; // Error
                                                   // derivedClass.ProtectedMethod(); // Error

            //Protected Internal Access Modifier: within the same assembly:
            ProtectedInternalClass protectedInternalClass = new ProtectedInternalClass();
            protectedInternalClass.ProtectedInternalProperty = "Accessible within the same assembly";
            protectedInternalClass.ProtectedInternalMethod();

            AnotherDerivedClass derivedClass1 = new AnotherDerivedClass();
            derivedClass1.AccessProtectedInternalMembers();


            // Private Protected Access Modifier
            BaseClass1 baseClass = new BaseClass1();
            // baseClass.PrivateProtectedProperty = "Not accessible"; // Error
            // baseClass.PrivateProtectedMethod(); // Error

            DerivedClassInSameAssembly derivedClass2 = new DerivedClassInSameAssembly();
            derivedClass2.AccessPrivateProtectedMembers(); // Accesses private protected members
        }


        #region Protected Access Modifier
        public class BaseClass
        {
            protected string ProtectedProperty { get; set; }

            protected void ProtectedMethod()
            {
                Console.WriteLine("This is a protected method.");
            }
        }

        public class DerivedClass : BaseClass
        {
            public void AccessProtectedMembers()
            {
                ProtectedProperty = "Accessible within derived class";
                ProtectedMethod();
            }
        }

        #endregion


        #region Protected Internal Access Modifier
        public class ProtectedInternalClass
        {
            protected internal string ProtectedInternalProperty { get; set; }

            protected internal void ProtectedInternalMethod()
            {
                Console.WriteLine("This is a protected internal method.");
            }
        }

        public class AnotherDerivedClass : ProtectedInternalClass
        {
            public void AccessProtectedInternalMembers()
            {
                ProtectedInternalProperty = "Accessible within derived class and same assembly";
                ProtectedInternalMethod();
            }
        }
        #endregion

        #region Private Protected Access Modifier

        public class BaseClass1
        {
            private protected string PrivateProtectedProperty { get; set; }

            private protected void PrivateProtectedMethod()
            {
                Console.WriteLine("This is a private protected method.");
            }
        }

        public class DerivedClassInSameAssembly : BaseClass1
        {
            public void AccessPrivateProtectedMembers()
            {
                PrivateProtectedProperty = "Accessible within derived class in the same assembly";
                PrivateProtectedMethod();
            }
        }

        // This class is in a different assembly
        // Uncommenting the below class will cause an error if placed in a different assembly.
        /*
        public class DerivedClassInDifferentAssembly : BaseClass
        {
            public void TryToAccessPrivateProtectedMembers()
            {
                // PrivateProtectedProperty = "Not accessible"; // Error
                // PrivateProtectedMethod(); // Error
            }
        }
        */
       
        #endregion

    }
}
