using Library.Business;
using Library.Data.Domain;
using MaterialSkin.Controls;
using System.Collections.Generic;
using System.Linq;

namespace Library.Presentation.Helpers
{
    public class CheckListManager
    {
        public static void InitializeCheckListGenres(MaterialCheckedListBox genreCheckedListBox)
        {
            UnitOfWork _unitOfWork = new UnitOfWork();
            var genres = _unitOfWork.GenreRepository.GetAll();
            foreach (var item in genres)
            {
                genreCheckedListBox.Items.Add(item.Name);
            }
        }
        public static List<Genre> GetSelectedGenresFromCheckList(MaterialCheckedListBox genreCheckedListBox)
        {
            UnitOfWork _unitOfWork = new UnitOfWork();
            return Bussiness.Books.GetSelectedGenresFromCheckList(_unitOfWork, genreCheckedListBox);
        } 
        public static void SelectGenresInCheckList(List<Genre> genres, MaterialCheckedListBox genresCheckBox)
        {
            foreach(var allgenres in genresCheckBox.Items)
            {
                foreach(var selectedGenres in genres)
                {
                    if(allgenres.Text == selectedGenres.Name)
                    {
                        allgenres.Checked = true;
                    }
                }
            }
        }
    }
   
}
