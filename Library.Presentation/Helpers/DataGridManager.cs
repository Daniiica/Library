using System.Windows.Forms;

namespace Library.Presentation.Helpers
{
    public class DataGridManager
    {
        public static void InitializeMyReservationDataGrid(DataGridView myReservationDataGrid)
        {
            myReservationDataGrid.DataSource = Bussiness.Books.MyReservationList();
            myReservationDataGrid.Columns["ReservationsID"].Visible = false;
            myReservationDataGrid.Columns["BookID"].Visible = false;
            myReservationDataGrid.Columns["UserID"].Visible = false;
        }
        public static void InitializeWishBookDataGrid(DataGridView wishBookDataGrid)
        {
            wishBookDataGrid.DataSource = Bussiness.Books.MyWishList();
            wishBookDataGrid.Columns["WishBookID"].Visible = false;
            wishBookDataGrid.Columns["UserID"].Visible = false;
        }
        public static void InitializeAllBookDataGrid(DataGridView BookDataGrid)
        {
            BookDataGrid.DataSource = Bussiness.Books.GetAllBooks();
            BookDataGrid.Columns["BookID"].Visible = false;
            BookDataGrid.Columns["AuthorID"].Visible = false;
            BookDataGrid.Columns["LanguageID"].Visible = false;
            BookDataGrid.Columns["PublisherID"].Visible = false;
        }
        public static void InitializeMyRentalsDataGrid(DataGridView myRentalsDataGrid)
        {
            myRentalsDataGrid.DataSource = Bussiness.Books.MyRentals();
            myRentalsDataGrid.Columns["BookID"].Visible = false;
            myRentalsDataGrid.Columns["UserID"].Visible = false;
            myRentalsDataGrid.Columns["RentalsID"].Visible = false;
        }
    }
}
