
public class Program{

    static List<Book> books = new List<Book>();
    public static void Main(){
        bool continueRunning = true;
        while (continueRunning)
        {
            Console.WriteLine("Choose an Operation");
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. View Books");
            Console.WriteLine("3. Update Book");
            Console.WriteLine("4. Delete Book");
            Console.WriteLine("5. Exit");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Addbook();
                    break;
                case 2:
                    ViewBooks();
                    break;
                case 3:
                    UpdateBook();
                    break;
                case 4:
                    DeleteBook();
                    break;
                case 5:
                    continueRunning = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again");
                    break;
            }

        }

    }

    static void Addbook(){
        Console.Write("Enter Book's Title: ");
        string title = Console.ReadLine();

        Console.WriteLine("Enter Book's Description: ");
        string description = Console.ReadLine();

        Book newBook = new Book{
            BookTitle = title, BookDescription = description
        };
        
        books.Add(newBook);
        
        Console.WriteLine($"Book titled: {title} added successfully!");

    }

    static void ViewBooks(){
        Console.WriteLine("Book List include: ");
        foreach (var book in books)
        {
            Console.WriteLine($"Book Title: {book.BookTitle}, Book Description: {book.BookDescription}");  
        }
    }

    static void UpdateBook(){
        Console.Write("Enter the Book Title to be updated: ");
        string titleToUpdate = Console.ReadLine();

        Book bookToUpdate = books.Find(b => b.BookTitle == titleToUpdate);

        if (bookToUpdate !=null)
        {
            Console.Write("Enter the new Book Description: ");
            string newBookDesc = Console.ReadLine();

            bookToUpdate.BookDescription = newBookDesc;

            Console.WriteLine("Person updated successfully!");
        }
    }

    static void DeleteBook(){
        Console.Write("Enter the Book Title to delete: ");
        string titleToDelete = Console.ReadLine();

        Book bookToDelete = books.Find(b => b.BookTitle == titleToDelete);
        if (bookToDelete !=null)
        {
            books.Remove(bookToDelete);
            Console.WriteLine("Book Deleted Successfully");
        }
        else
        {
            Console.WriteLine("Book Not Found");
        }




    }
}

public class Book{
    public required string BookTitle{get; set; }
    public required String BookDescription{get; set;}
}