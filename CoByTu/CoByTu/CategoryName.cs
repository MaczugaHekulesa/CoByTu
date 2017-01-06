namespace CoByTu
{
    internal class CategoryName
    {
   
        public CategoryName(string name)  //Klasa odpowiadajca za nazwe kategorii
        {
            this.NameOfCategory = name;

        }

        public string NameOfCategory { private set; get; }


        public override string ToString()
        {
            return NameOfCategory;

        }


    }
}